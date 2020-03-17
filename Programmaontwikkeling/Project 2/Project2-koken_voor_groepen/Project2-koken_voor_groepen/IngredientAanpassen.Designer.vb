<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngredientAanpassen
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
        Me.btnAanpassen = New System.Windows.Forms.Button()
        Me.cbGerechten = New System.Windows.Forms.ComboBox()
        Me.lblIngrediënt = New System.Windows.Forms.Label()
        Me.btnGerecht = New System.Windows.Forms.Button()
        Me.lblGerecht = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbIngrediënten = New System.Windows.Forms.ListBox()
        Me.btnIngrediënt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAanpassen
        '
        Me.btnAanpassen.Location = New System.Drawing.Point(237, 205)
        Me.btnAanpassen.Name = "btnAanpassen"
        Me.btnAanpassen.Size = New System.Drawing.Size(265, 48)
        Me.btnAanpassen.TabIndex = 1
        Me.btnAanpassen.Text = "Aanpassen"
        Me.btnAanpassen.UseVisualStyleBackColor = True
        '
        'cbGerechten
        '
        Me.cbGerechten.FormattingEnabled = True
        Me.cbGerechten.Location = New System.Drawing.Point(8, 28)
        Me.cbGerechten.Name = "cbGerechten"
        Me.cbGerechten.Size = New System.Drawing.Size(121, 24)
        Me.cbGerechten.TabIndex = 3
        '
        'lblIngrediënt
        '
        Me.lblIngrediënt.AutoSize = True
        Me.lblIngrediënt.Location = New System.Drawing.Point(9, 74)
        Me.lblIngrediënt.Name = "lblIngrediënt"
        Me.lblIngrediënt.Size = New System.Drawing.Size(120, 17)
        Me.lblIngrediënt.TabIndex = 5
        Me.lblIngrediënt.Text = "Ingrediënt kiezen:"
        '
        'btnGerecht
        '
        Me.btnGerecht.Location = New System.Drawing.Point(150, 28)
        Me.btnGerecht.Name = "btnGerecht"
        Me.btnGerecht.Size = New System.Drawing.Size(157, 28)
        Me.btnGerecht.TabIndex = 8
        Me.btnGerecht.Text = "Gerechten laden"
        Me.btnGerecht.UseVisualStyleBackColor = True
        '
        'lblGerecht
        '
        Me.lblGerecht.AutoSize = True
        Me.lblGerecht.Location = New System.Drawing.Point(9, 9)
        Me.lblGerecht.Name = "lblGerecht"
        Me.lblGerecht.Size = New System.Drawing.Size(108, 17)
        Me.lblGerecht.TabIndex = 9
        Me.lblGerecht.Text = "Gerecht kiezen:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 218)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Aanpassen:"
        '
        'lbIngrediënten
        '
        Me.lbIngrediënten.FormattingEnabled = True
        Me.lbIngrediënten.ItemHeight = 16
        Me.lbIngrediënten.Location = New System.Drawing.Point(12, 94)
        Me.lbIngrediënten.Name = "lbIngrediënten"
        Me.lbIngrediënten.Size = New System.Drawing.Size(120, 84)
        Me.lbIngrediënten.TabIndex = 14
        '
        'btnIngrediënt
        '
        Me.btnIngrediënt.Location = New System.Drawing.Point(150, 94)
        Me.btnIngrediënt.Name = "btnIngrediënt"
        Me.btnIngrediënt.Size = New System.Drawing.Size(197, 31)
        Me.btnIngrediënt.TabIndex = 15
        Me.btnIngrediënt.Text = "Ingrediënt kiezen"
        Me.btnIngrediënt.UseVisualStyleBackColor = True
        '
        'IngredientAanpassen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 276)
        Me.Controls.Add(Me.btnIngrediënt)
        Me.Controls.Add(Me.lbIngrediënten)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblGerecht)
        Me.Controls.Add(Me.btnGerecht)
        Me.Controls.Add(Me.lblIngrediënt)
        Me.Controls.Add(Me.cbGerechten)
        Me.Controls.Add(Me.btnAanpassen)
        Me.Name = "IngredientAanpassen"
        Me.Text = "Aanpassen Ingredient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAanpassen As Button
    Friend WithEvents cbGerechten As ComboBox
    Friend WithEvents lblIngrediënt As Label
    Friend WithEvents btnGerecht As Button
    Friend WithEvents lblGerecht As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbIngrediënten As ListBox
    Friend WithEvents btnIngrediënt As Button
End Class
