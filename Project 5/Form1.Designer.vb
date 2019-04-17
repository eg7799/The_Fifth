<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm
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
        Me.btnMain = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Blue
        Me.btnMain.Font = New System.Drawing.Font("Impact", 33.0!)
        Me.btnMain.ForeColor = System.Drawing.Color.White
        Me.btnMain.Location = New System.Drawing.Point(12, 189)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(632, 127)
        Me.btnMain.TabIndex = 0
        Me.btnMain.Text = "Check"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Red
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 19.0!)
        Me.lblMain.ForeColor = System.Drawing.Color.White
        Me.lblMain.Location = New System.Drawing.Point(272, 94)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(127, 29)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "Last Name"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtMain
        '
        Me.txtMain.Font = New System.Drawing.Font("Garamond", 24.0!)
        Me.txtMain.Location = New System.Drawing.Point(168, 126)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(336, 43)
        Me.txtMain.TabIndex = 2
        '
        'frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(656, 339)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnMain)
        Me.Name = "frm"
        Me.Text = "The Fifth!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMain As Button
    Friend WithEvents lblMain As Label
    Friend WithEvents txtMain As TextBox
End Class
