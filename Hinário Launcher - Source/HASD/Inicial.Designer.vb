<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicial))
        Me.NumeroHino = New System.Windows.Forms.TextBox()
        Me.Abrir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NumeroHino
        '
        Me.NumeroHino.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.NumeroHino.Location = New System.Drawing.Point(204, 449)
        Me.NumeroHino.Name = "NumeroHino"
        Me.NumeroHino.Size = New System.Drawing.Size(52, 32)
        Me.NumeroHino.TabIndex = 0
        Me.NumeroHino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Abrir
        '
        Me.Abrir.Location = New System.Drawing.Point(204, 482)
        Me.Abrir.Name = "Abrir"
        Me.Abrir.Size = New System.Drawing.Size(52, 22)
        Me.Abrir.TabIndex = 1
        Me.Abrir.Text = "Abrir"
        Me.Abrir.UseVisualStyleBackColor = True
        '
        'Inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(455, 560)
        Me.Controls.Add(Me.Abrir)
        Me.Controls.Add(Me.NumeroHino)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Inicial"
        Me.Text = "Hinário Adventista do Sétimo Dia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumeroHino As System.Windows.Forms.TextBox
    Friend WithEvents Abrir As System.Windows.Forms.Button

End Class
