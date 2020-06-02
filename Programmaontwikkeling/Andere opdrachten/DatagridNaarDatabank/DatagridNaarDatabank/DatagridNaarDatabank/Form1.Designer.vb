<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnWeergeven = New System.Windows.Forms.Button()
        Me.btnUpdates = New System.Windows.Forms.Button()
        Me.dgWeergave = New System.Windows.Forms.DataGridView()
        Me.btnSluiten = New System.Windows.Forms.Button()
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.btntest = New System.Windows.Forms.Button()
        CType(Me.dgWeergave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnWeergeven
        '
        Me.btnWeergeven.Location = New System.Drawing.Point(12, 35)
        Me.btnWeergeven.Name = "btnWeergeven"
        Me.btnWeergeven.Size = New System.Drawing.Size(135, 44)
        Me.btnWeergeven.TabIndex = 0
        Me.btnWeergeven.Text = "weergeven"
        Me.btnWeergeven.UseVisualStyleBackColor = True
        '
        'btnUpdates
        '
        Me.btnUpdates.Location = New System.Drawing.Point(153, 35)
        Me.btnUpdates.Name = "btnUpdates"
        Me.btnUpdates.Size = New System.Drawing.Size(124, 44)
        Me.btnUpdates.TabIndex = 1
        Me.btnUpdates.Text = "updates"
        Me.btnUpdates.UseVisualStyleBackColor = True
        '
        'dgWeergave
        '
        Me.dgWeergave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgWeergave.Location = New System.Drawing.Point(12, 95)
        Me.dgWeergave.Name = "dgWeergave"
        Me.dgWeergave.RowHeadersWidth = 51
        Me.dgWeergave.RowTemplate.Height = 24
        Me.dgWeergave.Size = New System.Drawing.Size(508, 213)
        Me.dgWeergave.TabIndex = 2
        '
        'btnSluiten
        '
        Me.btnSluiten.Location = New System.Drawing.Point(432, 45)
        Me.btnSluiten.Name = "btnSluiten"
        Me.btnSluiten.Size = New System.Drawing.Size(132, 44)
        Me.btnSluiten.TabIndex = 3
        Me.btnSluiten.Text = "Sluiten"
        Me.btnSluiten.UseVisualStyleBackColor = True
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Location = New System.Drawing.Point(283, 35)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(128, 44)
        Me.btnToevoegen.TabIndex = 4
        Me.btnToevoegen.Text = "Record Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'btntest
        '
        Me.btntest.Location = New System.Drawing.Point(611, 43)
        Me.btntest.Name = "btntest"
        Me.btntest.Size = New System.Drawing.Size(75, 23)
        Me.btntest.TabIndex = 5
        Me.btntest.Text = "test"
        Me.btntest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.Controls.Add(Me.btntest)
        Me.Controls.Add(Me.btnToevoegen)
        Me.Controls.Add(Me.btnSluiten)
        Me.Controls.Add(Me.dgWeergave)
        Me.Controls.Add(Me.btnUpdates)
        Me.Controls.Add(Me.btnWeergeven)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgWeergave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWeergeven As Button
    Friend WithEvents btnUpdates As Button
    Friend WithEvents dgWeergave As DataGridView
    Friend WithEvents btnSluiten As Button
    Friend WithEvents btnToevoegen As Button
    Friend WithEvents btntest As Button
End Class
