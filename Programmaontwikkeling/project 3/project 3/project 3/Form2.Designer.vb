<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Brood_Toevoegen
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBrood = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Toevoegen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBrood
        '
        Me.txtBrood.Location = New System.Drawing.Point(47, 147)
        Me.txtBrood.Name = "txtBrood"
        Me.txtBrood.Size = New System.Drawing.Size(100, 22)
        Me.txtBrood.TabIndex = 1
        '
        'Brood_Toevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 317)
        Me.Controls.Add(Me.txtBrood)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Brood_Toevoegen"
        Me.Text = "Brood Toevoegen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtBrood As TextBox
End Class
