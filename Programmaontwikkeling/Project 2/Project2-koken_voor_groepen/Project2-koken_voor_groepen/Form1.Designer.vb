<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kokenvoorgroepen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnGerechtToevoegen = New System.Windows.Forms.Button()
        Me.btnSluiten = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEvenementToevoegen = New System.Windows.Forms.Button()
        Me.btnAanpassenIngrediënt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGerechtToevoegen
        '
        Me.btnGerechtToevoegen.Location = New System.Drawing.Point(12, 39)
        Me.btnGerechtToevoegen.Name = "btnGerechtToevoegen"
        Me.btnGerechtToevoegen.Size = New System.Drawing.Size(186, 40)
        Me.btnGerechtToevoegen.TabIndex = 0
        Me.btnGerechtToevoegen.Text = "Gerecht Toevoegen"
        Me.btnGerechtToevoegen.UseVisualStyleBackColor = True
        '
        'btnSluiten
        '
        Me.btnSluiten.Location = New System.Drawing.Point(245, 12)
        Me.btnSluiten.Name = "btnSluiten"
        Me.btnSluiten.Size = New System.Drawing.Size(89, 40)
        Me.btnSluiten.TabIndex = 1
        Me.btnSluiten.Text = "Sluiten"
        Me.btnSluiten.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Wat wil je doen?"
        '
        'btnEvenementToevoegen
        '
        Me.btnEvenementToevoegen.Location = New System.Drawing.Point(12, 85)
        Me.btnEvenementToevoegen.Name = "btnEvenementToevoegen"
        Me.btnEvenementToevoegen.Size = New System.Drawing.Size(186, 40)
        Me.btnEvenementToevoegen.TabIndex = 3
        Me.btnEvenementToevoegen.Text = "Evenement Toevoegen"
        Me.btnEvenementToevoegen.UseVisualStyleBackColor = True
        '
        'btnAanpassenIngrediënt
        '
        Me.btnAanpassenIngrediënt.Location = New System.Drawing.Point(12, 131)
        Me.btnAanpassenIngrediënt.Name = "btnAanpassenIngrediënt"
        Me.btnAanpassenIngrediënt.Size = New System.Drawing.Size(186, 40)
        Me.btnAanpassenIngrediënt.TabIndex = 4
        Me.btnAanpassenIngrediënt.Text = "Ingrediënt aanpassen"
        Me.btnAanpassenIngrediënt.UseVisualStyleBackColor = True
        '
        'Kokenvoorgroepen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 190)
        Me.Controls.Add(Me.btnAanpassenIngrediënt)
        Me.Controls.Add(Me.btnEvenementToevoegen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSluiten)
        Me.Controls.Add(Me.btnGerechtToevoegen)
        Me.Name = "Kokenvoorgroepen"
        Me.Text = "Koken voor groepen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGerechtToevoegen As Button
    Friend WithEvents btnSluiten As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEvenementToevoegen As Button
    Friend WithEvents btnAanpassenIngrediënt As Button
End Class
