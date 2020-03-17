<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class evenement_Toevoegen
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAantalDagen = New System.Windows.Forms.Label()
        Me.lblAantalPersonen = New System.Windows.Forms.Label()
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.txtPersonen = New System.Windows.Forms.TextBox()
        Me.txtDagen = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDagen)
        Me.GroupBox1.Controls.Add(Me.txtPersonen)
        Me.GroupBox1.Controls.Add(Me.txtNaam)
        Me.GroupBox1.Controls.Add(Me.btnToevoegen)
        Me.GroupBox1.Controls.Add(Me.lblAantalDagen)
        Me.GroupBox1.Controls.Add(Me.lblAantalPersonen)
        Me.GroupBox1.Controls.Add(Me.lblNaam)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Evenement Toevoegen"
        '
        'lblAantalDagen
        '
        Me.lblAantalDagen.AutoSize = True
        Me.lblAantalDagen.Location = New System.Drawing.Point(6, 108)
        Me.lblAantalDagen.Name = "lblAantalDagen"
        Me.lblAantalDagen.Size = New System.Drawing.Size(117, 17)
        Me.lblAantalDagen.TabIndex = 2
        Me.lblAantalDagen.Text = "Aantal Personen:"
        '
        'lblAantalPersonen
        '
        Me.lblAantalPersonen.AutoSize = True
        Me.lblAantalPersonen.Location = New System.Drawing.Point(6, 67)
        Me.lblAantalPersonen.Name = "lblAantalPersonen"
        Me.lblAantalPersonen.Size = New System.Drawing.Size(98, 17)
        Me.lblAantalPersonen.TabIndex = 1
        Me.lblAantalPersonen.Text = "Aantal Dagen:"
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(6, 32)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(49, 17)
        Me.lblNaam.TabIndex = 0
        Me.lblNaam.Text = "Naam:"
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Location = New System.Drawing.Point(9, 164)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(111, 39)
        Me.btnToevoegen.TabIndex = 1
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(164, 29)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(100, 22)
        Me.txtNaam.TabIndex = 3
        '
        'txtPersonen
        '
        Me.txtPersonen.Location = New System.Drawing.Point(164, 105)
        Me.txtPersonen.Name = "txtPersonen"
        Me.txtPersonen.Size = New System.Drawing.Size(100, 22)
        Me.txtPersonen.TabIndex = 4
        '
        'txtDagen
        '
        Me.txtDagen.Location = New System.Drawing.Point(164, 64)
        Me.txtDagen.Name = "txtDagen"
        Me.txtDagen.Size = New System.Drawing.Size(100, 22)
        Me.txtDagen.TabIndex = 5
        '
        'evenement_Toevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 243)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "evenement_Toevoegen"
        Me.Text = "evenementen_Toevoegen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblAantalDagen As Label
    Friend WithEvents lblAantalPersonen As Label
    Friend WithEvents lblNaam As Label
    Friend WithEvents btnToevoegen As Button
    Friend WithEvents txtDagen As TextBox
    Friend WithEvents txtPersonen As TextBox
    Friend WithEvents txtNaam As TextBox
End Class
