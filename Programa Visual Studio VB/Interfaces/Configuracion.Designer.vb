<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.CboPuertos = New System.Windows.Forms.ComboBox()
        Me.BtnConectar = New System.Windows.Forms.Button()
        Me.BtnBuscarPuertos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CboPuertos
        '
        Me.CboPuertos.FormattingEnabled = True
        Me.CboPuertos.Location = New System.Drawing.Point(12, 58)
        Me.CboPuertos.Name = "CboPuertos"
        Me.CboPuertos.Size = New System.Drawing.Size(292, 21)
        Me.CboPuertos.TabIndex = 6
        '
        'BtnConectar
        '
        Me.BtnConectar.Location = New System.Drawing.Point(12, 98)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(292, 23)
        Me.BtnConectar.TabIndex = 5
        Me.BtnConectar.Text = "Conectar"
        Me.BtnConectar.UseVisualStyleBackColor = True
        '
        'BtnBuscarPuertos
        '
        Me.BtnBuscarPuertos.Location = New System.Drawing.Point(12, 15)
        Me.BtnBuscarPuertos.Name = "BtnBuscarPuertos"
        Me.BtnBuscarPuertos.Size = New System.Drawing.Size(292, 23)
        Me.BtnBuscarPuertos.TabIndex = 4
        Me.BtnBuscarPuertos.Text = "Buscar Puertos"
        Me.BtnBuscarPuertos.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.CboPuertos)
        Me.Controls.Add(Me.BtnConectar)
        Me.Controls.Add(Me.BtnBuscarPuertos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CboPuertos As System.Windows.Forms.ComboBox
    Friend WithEvents BtnConectar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarPuertos As System.Windows.Forms.Button
End Class
