using CapaNegocio.Asistencia;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion.Formularios
{
    public partial class Asistencias : Form
    {
        private readonly AsistenciasService _service = new AsistenciasService();

        public Asistencias()
        {
            InitializeComponent();

            
            this.Load += Asistencias_Load;
            btnRefrescar.Click += btnRefrescar_Click;
        }

        private async void Asistencias_Load(object sender, EventArgs e)
        {
            await CargarHoyAsync();
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            await CargarHoyAsync();
        }

        private async Task CargarHoyAsync()
        {
            try
            {
                lblEstado.Text = "Cargando...";
                btnRefrescar.Enabled = false;

                DataTable dt = await _service.CargarHoyAsync();

                dGVHoy.AutoGenerateColumns = true;
                dGVHoy.DataSource = dt;

                // ====== ESTILO PROFESIONAL ======

                // ===== ESTILO VISUAL =====

                dGVHoy.BackgroundColor = Color.White;
                dGVHoy.DefaultCellStyle.BackColor = Color.White;
                dGVHoy.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // Todo blanco

                dGVHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dGVHoy.BorderStyle = BorderStyle.None;
                dGVHoy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dGVHoy.RowHeadersVisible = false;
                dGVHoy.EnableHeadersVisualStyles = false;

                // 🎨 Encabezado profesional
                dGVHoy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 54, 75);
                dGVHoy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dGVHoy.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dGVHoy.ColumnHeadersHeight = 42;

                // 📏 Aumentar tamaño de filas
                dGVHoy.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dGVHoy.RowTemplate.Height = 38; // ← Aquí aumentas la altura
               

                // 🎯 Selección suave
                dGVHoy.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 241);
                dGVHoy.DefaultCellStyle.SelectionForeColor = Color.Black;

                // Centrar algunas columnas si quieres
                if (dGVHoy.Columns["MinutosTarde"] != null)
                    dGVHoy.Columns["MinutosTarde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                lblEstado.Text = $"Registros: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error cargando asistencias.";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefrescar.Enabled = true;
            }
        }
    }
}