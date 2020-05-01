<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.broodToevoegen = New System.Windows.Forms.Button()
        Me.broodmetprijs = New System.Windows.Forms.DataGridView()
        Me.lblH1 = New System.Windows.Forms.Label()
        Me.btnTonen = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnSaldo = New System.Windows.Forms.Button()
        Me.btnOpwaarderen = New System.Windows.Forms.Button()
        Me.Saldo = New System.Windows.Forms.DataGridView()
        CType(Me.broodmetprijs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Saldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'broodToevoegen
        '
        Me.broodToevoegen.Location = New System.Drawing.Point(12, 12)
        Me.broodToevoegen.Name = "broodToevoegen"
        Me.broodToevoegen.Size = New System.Drawing.Size(142, 36)
        Me.broodToevoegen.TabIndex = 0
        Me.broodToevoegen.Text = "Brood Toevoegen"
        Me.broodToevoegen.UseVisualStyleBackColor = True
        '
        'broodmetprijs
        '
        Me.broodmetprijs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.broodmetprijs.Location = New System.Drawing.Point(12, 215)
        Me.broodmetprijs.Name = "broodmetprijs"
        Me.broodmetprijs.RowHeadersWidth = 51
        Me.broodmetprijs.RowTemplate.Height = 24
        Me.broodmetprijs.Size = New System.Drawing.Size(734, 291)
        Me.broodmetprijs.TabIndex = 1
        '
        'lblH1
        '
        Me.lblH1.AutoSize = True
        Me.lblH1.Location = New System.Drawing.Point(12, 192)
        Me.lblH1.Name = "lblH1"
        Me.lblH1.Size = New System.Drawing.Size(105, 17)
        Me.lblH1.TabIndex = 2
        Me.lblH1.Text = "Opties bekijken"
        '
        'btnTonen
        '
        Me.btnTonen.Location = New System.Drawing.Point(123, 189)
        Me.btnTonen.Name = "btnTonen"
        Me.btnTonen.Size = New System.Drawing.Size(75, 23)
        Me.btnTonen.TabIndex = 3
        Me.btnTonen.Text = "Tonen"
        Me.btnTonen.UseVisualStyleBackColor = True
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(283, 12)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(48, 17)
        Me.lblSaldo.TabIndex = 4
        Me.lblSaldo.Text = "Saldo:"
        '
        'btnSaldo
        '
        Me.btnSaldo.Location = New System.Drawing.Point(211, 52)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(120, 23)
        Me.btnSaldo.TabIndex = 6
        Me.btnSaldo.Text = "Saldo bekijken"
        Me.btnSaldo.UseVisualStyleBackColor = True
        '
        'btnOpwaarderen
        '
        Me.btnOpwaarderen.Location = New System.Drawing.Point(211, 81)
        Me.btnOpwaarderen.Name = "btnOpwaarderen"
        Me.btnOpwaarderen.Size = New System.Drawing.Size(120, 23)
        Me.btnOpwaarderen.TabIndex = 7
        Me.btnOpwaarderen.Text = "Opwaarderen"
        Me.btnOpwaarderen.UseVisualStyleBackColor = True
        '
        'Saldo
        '
        Me.Saldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Saldo.Location = New System.Drawing.Point(337, 12)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.RowHeadersWidth = 51
        Me.Saldo.RowTemplate.Height = 24
        Me.Saldo.Size = New System.Drawing.Size(329, 150)
        Me.Saldo.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 518)
        Me.Controls.Add(Me.Saldo)
        Me.Controls.Add(Me.btnOpwaarderen)
        Me.Controls.Add(Me.btnSaldo)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.btnTonen)
        Me.Controls.Add(Me.lblH1)
        Me.Controls.Add(Me.broodmetprijs)
        Me.Controls.Add(Me.broodToevoegen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.broodmetprijs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Saldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents broodToevoegen As Button
    Friend WithEvents broodmetprijs As DataGridView
    Friend WithEvents lblH1 As Label
    Friend WithEvents btnTonen As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents btnSaldo As Button
    Friend WithEvents btnOpwaarderen As Button
    Friend WithEvents Saldo As DataGridView
End Class
