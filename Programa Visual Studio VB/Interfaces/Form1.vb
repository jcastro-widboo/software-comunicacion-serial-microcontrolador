Public Class Form1

    Dim StrBufferEntrada As String
    Dim StrBufferSalida As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StrBufferEntrada = ""
        StrBufferSalida = ""
        BtnEnviarDatos.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        ReiniciarLCDToolStripMenuItem.Enabled() = False
        TextBox1.Enabled = False

        If (Configuracion.Estado = True) Then

            BtnEnviarDatos.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            ReiniciarLCDToolStripMenuItem.Enabled() = True
            TextBox1.Enabled = True

        End If

        TextBox1.MaxLength = 15

    End Sub

    Private Sub BtnEnviarDatos_Click(sender As Object, e As EventArgs) Handles BtnEnviarDatos.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "A"
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "B"
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub CboPuertos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "C"
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "D"
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "E"
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "F"
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = " " + TextBox1.Text
        SpPuerto.Write(StrBufferSalida)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "H"
        SpPuerto.Write(StrBufferSalida)

        TextBox1.Text = ""

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub

    Private Sub ReiniciarLCDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarLCDToolStripMenuItem.Click

        SpPuerto.DiscardInBuffer()
        StrBufferSalida = "H"
        SpPuerto.Write(StrBufferSalida)

        TextBox1.Text = ""

    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click

        Configuracion.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        TextBox1.CharacterCasing = CharacterCasing.Lower

    End Sub

End Class
