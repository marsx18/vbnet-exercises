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
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnFifteen = New System.Windows.Forms.Button()
        Me.btnTwenty = New System.Windows.Forms.Button()
        Me.btnTwentyFive = New System.Windows.Forms.Button()
        Me.lblTip = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBillAmount
        '
        Me.txtBillAmount.Location = New System.Drawing.Point(378, 100)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(134, 22)
        Me.txtBillAmount.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(273, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Amount of Bill:"
        '
        'btnFifteen
        '
        Me.btnFifteen.Location = New System.Drawing.Point(263, 162)
        Me.btnFifteen.Name = "btnFifteen"
        Me.btnFifteen.Size = New System.Drawing.Size(75, 23)
        Me.btnFifteen.TabIndex = 2
        Me.btnFifteen.Text = "15%"
        Me.btnFifteen.UseVisualStyleBackColor = True
        '
        'btnTwenty
        '
        Me.btnTwenty.Location = New System.Drawing.Point(363, 162)
        Me.btnTwenty.Name = "btnTwenty"
        Me.btnTwenty.Size = New System.Drawing.Size(75, 23)
        Me.btnTwenty.TabIndex = 3
        Me.btnTwenty.Text = "20%"
        Me.btnTwenty.UseVisualStyleBackColor = True
        '
        'btnTwentyFive
        '
        Me.btnTwentyFive.Location = New System.Drawing.Point(464, 162)
        Me.btnTwentyFive.Name = "btnTwentyFive"
        Me.btnTwentyFive.Size = New System.Drawing.Size(75, 23)
        Me.btnTwentyFive.TabIndex = 4
        Me.btnTwentyFive.Text = "25%"
        Me.btnTwentyFive.UseVisualStyleBackColor = True
        '
        'lblTip
        '
        Me.lblTip.Location = New System.Drawing.Point(378, 240)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(134, 22)
        Me.lblTip.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(273, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Amount to Tip:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 392)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.btnTwentyFive)
        Me.Controls.Add(Me.btnTwenty)
        Me.Controls.Add(Me.btnFifteen)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBillAmount)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBillAmount As TextBox
    Friend WithEvents Label11 As Label
    Private WithEvents btnFifteen As Button
    Friend WithEvents btnTwenty As Button
    Friend WithEvents btnTwentyFive As Button
    Friend WithEvents lblTip As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnExit As Button
End Class
