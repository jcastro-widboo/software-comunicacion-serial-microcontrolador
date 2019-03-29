Public Class Configuracion

    Public Estado = False

    Private Sub BtnBuscarPuertos_Click(sender As Object, e As EventArgs) Handles BtnBuscarPuertos.Click

        CboPuertos.Items.Clear()

        For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames

            CboPuertos.Items.Add(PuertoDisponible)

        Next


        If CboPuertos.Items.Count > 0 Then

            CboPuertos.Text = CboPuertos.Items(0)
            MessageBox.Show("Seleccionar el puerto de trabajo")
            BtnConectar.Enabled = True

        Else

            MessageBox.Show("Ningun puerto encontrado")
            BtnConectar.Enabled = False
            Form1.BtnEnviarDatos.Enabled = False
            CboPuertos.Items.Clear()

        End If

    End Sub

    Private Sub BtnConectar_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click

        If BtnConectar.Text = "Conectar" Then

            Try

                With Form1.SpPuerto
                    .BaudRate = 1200
                    .DataBits = 8
                    .Parity = IO.Ports.Parity.None
                    .StopBits = IO.Ports.StopBits.One
                    .PortName = CboPuertos.Text
                    .Open()
                End With

                BtnConectar.Text = "Desconectar"

                Form1.BtnEnviarDatos.Enabled = True
                Form1.Button1.Enabled = True
                Form1.Button2.Enabled = True
                Form1.Button3.Enabled = True
                Form1.Button4.Enabled = True
                Form1.Button5.Enabled = True
                Form1.Button6.Enabled = True
                Form1.Button7.Enabled = True
                Form1.ReiniciarLCDToolStripMenuItem.Enabled() = True
                Form1.TextBox1.Enabled = True

                Estado = True

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

        ElseIf BtnConectar.Text = "Desconectar" Then

            BtnConectar.Text = "Conectar"

            BtnConectar.Enabled = False
            Form1.BtnEnviarDatos.Enabled = False
            Form1.Button1.Enabled = False
            Form1.Button2.Enabled = False
            Form1.Button3.Enabled = False
            Form1.Button4.Enabled = False
            Form1.Button5.Enabled = False
            Form1.Button6.Enabled = False
            Form1.Button7.Enabled = False
            Form1.ReiniciarLCDToolStripMenuItem.Enabled() = False
            Form1.TextBox1.Enabled = False

            Form1.SpPuerto.Close()
            Estado = False
            Close()

        End If

    End Sub

    Private Sub CboPuertos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPuertos.SelectedIndexChanged

    End Sub

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BtnConectar.Enabled = False
        Form1.BtnEnviarDatos.Enabled = False
        Form1.Button1.Enabled = False
        Form1.Button2.Enabled = False
        Form1.Button3.Enabled = False
        Form1.Button4.Enabled = False
        Form1.Button5.Enabled = False
        Form1.Button6.Enabled = False
        Form1.Button7.Enabled = False
        Form1.ReiniciarLCDToolStripMenuItem.Enabled() = False
        Form1.TextBox1.Enabled = False

        If (Estado = True) Then

            Form1.BtnEnviarDatos.Enabled = True
            Form1.Button1.Enabled = True
            Form1.Button2.Enabled = True
            Form1.Button3.Enabled = True
            Form1.Button4.Enabled = True
            Form1.Button5.Enabled = True
            Form1.Button6.Enabled = True
            Form1.Button7.Enabled = True
            Form1.ReiniciarLCDToolStripMenuItem.Enabled() = True
            Form1.TextBox1.Enabled = True

        End If


    End Sub

End Class