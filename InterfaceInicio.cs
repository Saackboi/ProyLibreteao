using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Inicio;

namespace CapaPresentacion.Formularios
{
    // Clase parcial para la interfaz de inicio
    public partial class InterfaceInicio : Form
    {
        // Servicio para manejar la sincronización con el reloj
        private readonly SyncService _syncService;

        // Bandera para controlar la primera ejecución
        private bool primeraEjecucion = true;
        // Bandera para evitar múltiples sincronizaciones simultáneas
        private bool sincronizando = false;

        // Constructor de la interfaz de inicio
        public InterfaceInicio()
        {
            InitializeComponent();
            _syncService = new SyncService("172.30.168.219", 4370);
            this.Shown += InterfaceInicio_Shown; // Evento al mostrar el formulario
        }

        // Evento que se ejecuta al mostrar el formulario
        private async void InterfaceInicio_Shown(object sender, EventArgs e)
        {
            if (!primeraEjecucion) return;
            primeraEjecucion = false;
            await Task.Delay(200); // Espera breve antes de iniciar la sincronización
            await IniciarSincronizacionAsync();
        }

        // Evento para el botón de resincronización
        private async void btnResincronizar_Click(object sender, EventArgs e)
        {
            await IniciarSincronizacionAsync();
        }

        // Método para iniciar la sincronización
        private async Task IniciarSincronizacionAsync()
        {
            if (sincronizando) return;
            sincronizando = true;

            // Actualiza la interfaz mientras se sincroniza
            btnResincronizar.Enabled = false;
            btnResincronizar.Text = "⏳ Sincronizando...";
            lblEstadoTxt.Text = "⏳ Conectando...";
            Cursor = Cursors.WaitCursor;

            try
            {
                // Intenta sincronizar con el reloj
                var (ok, err) = await _syncService.SincronizarAsync();

                lblEstadoTxt.Text = ok ? "🟢 Listo" : $"🔴 Desconectado (Err {err})";

                if (!ok)
                {
                    MessageBox.Show(
                        $"No se pudo conectar al reloj.\n\nCódigo de error ZK: {err}\n\n" +
                        "Tip: reinicia el reloj y asegúrate de que no haya otra PC conectada.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Carga el dashboard si la sincronización fue exitosa
                await CargarDashboardAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Finaliza la sincronización y actualiza la interfaz
                FinSincronizacionUI(lblEstadoTxt.Text);
            }
        }

        // Método para finalizar la sincronización y actualizar la interfaz
        private void FinSincronizacionUI(string estado)
        {
            Cursor = Cursors.Default;
            btnResincronizar.Enabled = true;
            btnResincronizar.Text = "🔄 Volver a sincronizar";
            sincronizando = false;
            lblEstadoTxt.Text = estado;
        }

        // Método para cargar los datos del dashboard
        private async Task CargarDashboardAsync()
        {
            int totalUsuarios = await _syncService.ContarUsuariosAsync();
            int registrosHoy = await _syncService.ContarAsistenciaHoyAsync();

            // Actualiza las etiquetas con los datos obtenidos
            lblUsuarios.Text = "Usuarios\n" + totalUsuarios;
            lblAsistencias.Text = "Asistencias Hoy\n" + registrosHoy;
            lblPresentes.Text = "Presentes\n" + registrosHoy;
            lblAusentes.Text = "Ausentes\n" + Math.Max(0, totalUsuarios - registrosHoy);

            // Carga los últimos registros en el grid
            DataTable dtGrid = await _syncService.UltimosRegistrosAsync();
            dgvUltimos.DataSource = dtGrid;

            DisenarGridUltimos(); // Aplica el diseño al grid
            AjustarGridUltimos(); // Ajusta las columnas del grid
        }

        // Configura el diseño del grid de últimos registros
        private void DisenarGridUltimos()
        {
            dgvUltimos.AllowUserToAddRows = false;
            dgvUltimos.AllowUserToDeleteRows = false;
            dgvUltimos.ReadOnly = true;
            dgvUltimos.MultiSelect = false;
            dgvUltimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvUltimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimos.RowTemplate.Height = 38;
            dgvUltimos.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvUltimos.BorderStyle = BorderStyle.None;

            dgvUltimos.EnableHeadersVisualStyles = false;
            dgvUltimos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUltimos.ColumnHeadersHeight = 45;

            dgvUltimos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(12, 61, 92);
            dgvUltimos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUltimos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 10.5f, FontStyle.Bold);

            dgvUltimos.RowHeadersVisible = false;
        }

        // Ajusta las columnas del grid de últimos registros
        private void AjustarGridUltimos()
        {
            if (dgvUltimos.Columns.Contains("UserID"))
            {
                dgvUltimos.Columns["UserID"].HeaderText = "ID";
                dgvUltimos.Columns["UserID"].FillWeight = 35;
            }
            if (dgvUltimos.Columns.Contains("Nombre"))
            {
                dgvUltimos.Columns["Nombre"].HeaderText = "Nombre";
                dgvUltimos.Columns["Nombre"].FillWeight = 120;
            }
            if (dgvUltimos.Columns.Contains("Departamento"))
            {
                dgvUltimos.Columns["Departamento"].HeaderText = "Departamento";
                dgvUltimos.Columns["Departamento"].FillWeight = 110;
            }
            if (dgvUltimos.Columns.Contains("Fecha"))
            {
                dgvUltimos.Columns["Fecha"].HeaderText = "Fecha";
                dgvUltimos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvUltimos.Columns["Fecha"].FillWeight = 70;
            }
            if (dgvUltimos.Columns.Contains("HoraEntrada"))
            {
                dgvUltimos.Columns["HoraEntrada"].HeaderText = "Entrada";
                dgvUltimos.Columns["HoraEntrada"].DefaultCellStyle.Format = @"hh\:mm";
                dgvUltimos.Columns["HoraEntrada"].FillWeight = 55;
            }
            if (dgvUltimos.Columns.Contains("HoraSalida"))
            {
                dgvUltimos.Columns["HoraSalida"].HeaderText = "Salida";
                dgvUltimos.Columns["HoraSalida"].DefaultCellStyle.Format = @"hh\:mm";
                dgvUltimos.Columns["HoraSalida"].FillWeight = 55;
            }
            if (dgvUltimos.Columns.Contains("Estado"))
            {
                dgvUltimos.Columns["Estado"].HeaderText = "Estado";
                dgvUltimos.Columns["Estado"].FillWeight = 75;
            }
            if (dgvUltimos.Columns.Contains("MinutosTarde"))
            {
                dgvUltimos.Columns["MinutosTarde"].HeaderText = "Min. tarde";
                dgvUltimos.Columns["MinutosTarde"].FillWeight = 55;
                dgvUltimos.Columns["MinutosTarde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgvUltimos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvUltimos.ClearSelection();
        }
    }
}