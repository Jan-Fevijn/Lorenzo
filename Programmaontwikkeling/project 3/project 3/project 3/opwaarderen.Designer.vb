<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opwaarderen
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
        Me.txtklant = New System.Windows.Forms.TextBox()
        Me.lblnaam = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.lblBroodpositiedatum = New System.Windows.Forms.Label()
        Me.lblDatum = New System.Windows.Forms.Label()
        Me.txtbroodpositiedatum = New System.Windows.Forms.TextBox()
        Me.txtDatum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtklant
        '
        Me.txtklant.Location = New System.Drawing.Point(26, 49)
        Me.txtklant.Name = "txtklant"
        Me.txtklant.Size = New System.Drawing.Size(100, 22)
        Me.txtklant.TabIndex = 0
        '
        'lblnaam
        '
        Me.lblnaam.AutoSize = True
        Me.lblnaam.Location = New System.Drawing.Point(23, 29)
        Me.lblnaam.Name = "lblnaam"
        Me.lblnaam.Size = New System.Drawing.Size(53, 17)
        Me.lblnaam.TabIndex = 1
        Me.lblnaam.Text = "idklant:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(197, 49)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 22)
        Me.txtSaldo.TabIndex = 2
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(194, 29)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(48, 17)
        Me.lblSaldo.TabIndex = 3
        Me.lblSaldo.Text = "Saldo:"
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Location = New System.Drawing.Point(109, 139)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(97, 33)
        Me.btnToevoegen.TabIndex = 4
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'lblBroodpositiedatum
        '
        Me.lblBroodpositiedatum.AutoSize = True
        Me.lblBroodpositiedatum.Location = New System.Drawing.Point(194, 91)
        Me.lblBroodpositiedatum.Name = "lblBroodpositiedatum"
        Me.lblBroodpositiedatum.Size = New System.Drawing.Size(129, 17)
        Me.lblBroodpositiedatum.TabIndex = 5
        Me.lblBroodpositiedatum.Text = "broodpositiedatum:"
        '
        'lblDatum
        '
        Me.lblDatum.AutoSize = True
        Me.lblDatum.Location = New System.Drawing.Point(23, 91)
        Me.lblDatum.Name = "lblDatum"
        Me.lblDatum.Size = New System.Drawing.Size(53, 17)
        Me.lblDatum.TabIndex = 6
        Me.lblDatum.Text = "Datum:"
        '
        'txtbroodpositiedatum
        '
        Me.txtbroodpositiedatum.Location = New System.Drawing.Point(197, 111)
        Me.txtbroodpositiedatum.Name = "txtbroodpositiedatum"
        Me.txtbroodpositiedatum.Size = New System.Drawing.Size(100, 22)
        Me.txtbroodpositiedatum.TabIndex = 7
        '
        'txtDatum
        '
        Me.txtDatum.Location = New System.Drawing.Point(26, 111)
        Me.txtDatum.Name = "txtDatum"
        Me.txtDatum.Size = New System.Drawing.Size(100, 22)
        Me.txtDatum.TabIndex = 8
        '
        'opwaarderen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 198)
        Me.Controls.Add(Me.txtDatum)
        Me.Controls.Add(Me.txtbroodpositiedatum)
        Me.Controls.Add(Me.lblDatum)
        Me.Controls.Add(Me.lblBroodpositiedatum)
        Me.Controls.Add(Me.btnToevoegen)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.lblnaam)
        Me.Controls.Add(Me.txtklant)
        Me.Name = "opwaarderen"
        Me.Text = "opwaarderen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtklant As TextBox
    Friend WithEvents lblnaam As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents btnToevoegen As Button
    Friend WithEvents lblBroodpositiedatum As Label
    Friend WithEvents lblDatum As Label
    Friend WithEvents txtbroodpositiedatum As TextBox
    Friend WithEvents txtDatum As TextBox
End Class
