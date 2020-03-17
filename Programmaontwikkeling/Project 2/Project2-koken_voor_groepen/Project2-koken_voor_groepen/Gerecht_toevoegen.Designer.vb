<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerecht_toevoegen
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnToevoegen)
        Me.GroupBox1.Controls.Add(Me.txtNaam)
        Me.GroupBox1.Controls.Add(Me.lblNaam)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 126)
        Me.GroupBox1.TabIndex = 1
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
        'Gerecht_toevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 150)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Gerecht_toevoegen"
        Me.Text = "Gerecht_toevoegen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnToevoegen As Button
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents lblNaam As Label
End Class
