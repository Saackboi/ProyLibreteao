
  Public Class FrmInputs

        Public Property Valor1 As String
        Public Property Valor2 As String
        Public Property Confirmado As Boolean = False

        Private Sub FrmInputs_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.StartPosition = FormStartPosition.CenterParent
            Me.BackColor = Color.WhiteSmoke

        AddHandler BtnOk.MouseEnter, Sub()
                                         BtnOk.BackColor = Color.FromArgb(243, 156, 18)
                                         BtnOk.ForeColor = Color.Black
                                         End Sub

            AddHandler BtnOk.MouseLeave, Sub()
                                             BtnOk.BackColor = Color.OldLace
                                             BtnOk.ForeColor = Color.Black
                                         End Sub

        End Sub

        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            Valor1 = txt1.Text
            Valor2 = txt2.Text
            Confirmado = True
            Me.Close()
        End Sub

    End Class
