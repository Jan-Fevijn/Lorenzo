<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kokenvoorgroepen
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
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEvenementToevoegen = New System.Windows.Forms.Button()
        Me.txtNaamEvenement = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAantalPersonen = New System.Windows.Forms.Label()
        Me.lblAantalDagen = New System.Windows.Forms.Label()
        Me.txtAantalPersonen = New System.Windows.Forms.TextBox()
        Me.txtAantalDagen = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnToevoegen)
        Me.GroupBox1.Controls.Add(Me.txtNaam)
        Me.GroupBox1.Controls.Add(Me.lblNaam)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gerecht Toevoegen"
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Location = New System.Drawing.Point(9, 71)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(234, 36)
        Me.btnToevoegen.TabIndex = 8
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(143, 33)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(100, 22)
        Me.txtNaam.TabIndex = 4
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(6, 36)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(49, 17)
        Me.lblNaam.TabIndex = 0
        Me.lblNaam.Text = "Naam:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAantalPersonen)
        Me.GroupBox2.Controls.Add(Me.txtAantalDagen)
        Me.GroupBox2.Controls.Add(Me.lblAantalPersonen)
        Me.GroupBox2.Controls.Add(Me.lblAantalDagen)
        Me.GroupBox2.Controls.Add(Me.btnEvenementToevoegen)
        Me.GroupBox2.Controls.Add(Me.txtNaamEvenement)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 207)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Evenement Toevoegen"
        '
        'btnEvenementToevoegen
        '
        Me.btnEvenementToevoegen.Location = New System.Drawing.Point(6, 151)
        Me.btnEvenementToevoegen.Name = "btnEvenementToevoegen"
        Me.btnEvenementToevoegen.Size = New System.Drawing.Size(234, 36)
        Me.btnEvenementToevoegen.TabIndex = 8
        Me.btnEvenementToevoegen.Text = "Toevoegen"
        Me.btnEvenementToevoegen.UseVisualStyleBackColor = True
        '
        'txtNaamEvenement
        '
        Me.txtNaamEvenement.Location = New System.Drawing.Point(143, 33)
        Me.txtNaamEvenement.Name = "txtNaamEvenement"
        Me.txtNaamEvenement.Size = New System.Drawing.Size(100, 22)
        Me.txtNaamEvenement.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Naam:"
        '
        'lblAantalPersonen
        '
        Me.lblAantalPersonen.AutoSize = True
        Me.lblAantalPersonen.Location = New System.Drawing.Point(6, 109)
        Me.lblAantalPersonen.Name = "lblAantalPersonen"
        Me.lblAantalPersonen.Size = New System.Drawing.Size(116, 17)
        Me.lblAantalPersonen.TabIndex = 2
        Me.lblAantalPersonen.Text = "Aantal personen:"
        '
        'lblAantalDagen
        '
        Me.lblAantalDagen.AutoSize = True
        Me.lblAantalDagen.Location = New System.Drawing.Point(6, 71)
        Me.lblAantalDagen.Name = "lblAantalDagen"
        Me.lblAantalDagen.Size = New System.Drawing.Size(96, 17)
        Me.lblAantalDagen.TabIndex = 3
        Me.lblAantalDagen.Text = "Aantal dagen:"
        '
        'txtAantalPersonen
        '
        Me.txtAantalPersonen.Location = New System.Drawing.Point(140, 106)
        Me.txtAantalPersonen.Name = "txtAantalPersonen"
        Me.txtAantalPersonen.Size = New System.Drawing.Size(100, 22)
        Me.txtAantalPersonen.TabIndex = 5
        '
        'txtAantalDagen
        '
        Me.txtAantalDagen.Location = New System.Drawing.Point(143, 68)
        Me.txtAantalDagen.Name = "txtAantalDagen"
        Me.txtAantalDagen.Size = New System.Drawing.Size(100, 22)
        Me.txtAantalDagen.TabIndex = 6
        '
        'Kokenvoorgroepen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Kokenvoorgroepen"
        Me.Text = "Koken voor groepen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNaam As Label
    Friend WithEvents btnToevoegen As Button
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEvenementToevoegen As Button
    Friend WithEvents txtNaamEvenement As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAantalPersonen As TextBox
    Friend WithEvents txtAantalDagen As TextBox
    Friend WithEvents lblAantalPersonen As Label
    Friend WithEvents lblAantalDagen As Label
End Class
