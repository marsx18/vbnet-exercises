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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSiakap = New System.Windows.Forms.CheckBox()
        Me.chkKerisi = New System.Windows.Forms.CheckBox()
        Me.chkKembung = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkNone = New System.Windows.Forms.CheckBox()
        Me.chkSiang = New System.Windows.Forms.CheckBox()
        Me.txtKembungWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKerisiWeight = New System.Windows.Forms.TextBox()
        Me.txtSiakapWeight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROCESSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULATEPRICEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWSUMMARYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSiakap)
        Me.GroupBox1.Controls.Add(Me.chkKerisi)
        Me.GroupBox1.Controls.Add(Me.chkKembung)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Types of fish"
        '
        'chkSiakap
        '
        Me.chkSiakap.AutoSize = True
        Me.chkSiakap.Location = New System.Drawing.Point(26, 109)
        Me.chkSiakap.Name = "chkSiakap"
        Me.chkSiakap.Size = New System.Drawing.Size(72, 20)
        Me.chkSiakap.TabIndex = 2
        Me.chkSiakap.Text = "Siakap"
        Me.chkSiakap.UseVisualStyleBackColor = True
        '
        'chkKerisi
        '
        Me.chkKerisi.AutoSize = True
        Me.chkKerisi.Location = New System.Drawing.Point(26, 73)
        Me.chkKerisi.Name = "chkKerisi"
        Me.chkKerisi.Size = New System.Drawing.Size(62, 20)
        Me.chkKerisi.TabIndex = 1
        Me.chkKerisi.Text = "Kerisi"
        Me.chkKerisi.UseVisualStyleBackColor = True
        '
        'chkKembung
        '
        Me.chkKembung.AutoSize = True
        Me.chkKembung.Location = New System.Drawing.Point(26, 37)
        Me.chkKembung.Name = "chkKembung"
        Me.chkKembung.Size = New System.Drawing.Size(86, 20)
        Me.chkKembung.TabIndex = 0
        Me.chkKembung.Text = "Kembung"
        Me.chkKembung.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkNone)
        Me.GroupBox2.Controls.Add(Me.chkSiang)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 153)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Services"
        '
        'chkNone
        '
        Me.chkNone.AutoSize = True
        Me.chkNone.Location = New System.Drawing.Point(18, 89)
        Me.chkNone.Name = "chkNone"
        Me.chkNone.Size = New System.Drawing.Size(62, 20)
        Me.chkNone.TabIndex = 4
        Me.chkNone.Text = "None"
        Me.chkNone.UseVisualStyleBackColor = True
        '
        'chkSiang
        '
        Me.chkSiang.AutoSize = True
        Me.chkSiang.Location = New System.Drawing.Point(18, 37)
        Me.chkSiang.Name = "chkSiang"
        Me.chkSiang.Size = New System.Drawing.Size(179, 36)
        Me.chkSiang.TabIndex = 3
        Me.chkSiang.Text = "Disiang dan Dibersihkan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( Add RM1)"
        Me.chkSiang.UseVisualStyleBackColor = True
        '
        'txtKembungWeight
        '
        Me.txtKembungWeight.Location = New System.Drawing.Point(191, 229)
        Me.txtKembungWeight.Name = "txtKembungWeight"
        Me.txtKembungWeight.Size = New System.Drawing.Size(142, 22)
        Me.txtKembungWeight.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kembung (kg):"
        '
        'txtKerisiWeight
        '
        Me.txtKerisiWeight.Location = New System.Drawing.Point(191, 267)
        Me.txtKerisiWeight.Name = "txtKerisiWeight"
        Me.txtKerisiWeight.Size = New System.Drawing.Size(142, 22)
        Me.txtKerisiWeight.TabIndex = 4
        '
        'txtSiakapWeight
        '
        Me.txtSiakapWeight.Location = New System.Drawing.Point(191, 307)
        Me.txtSiakapWeight.Name = "txtSiakapWeight"
        Me.txtSiakapWeight.Size = New System.Drawing.Size(142, 22)
        Me.txtSiakapWeight.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kerisi (kg):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Siakap (kg):"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(460, 248)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(128, 60)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(608, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 60)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(608, 248)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 60)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.PROCESSToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'NToolStripMenuItem
        '
        Me.NToolStripMenuItem.Name = "NToolStripMenuItem"
        Me.NToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.NToolStripMenuItem.Text = "NEXT CUSTOMER"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'PROCESSToolStripMenuItem
        '
        Me.PROCESSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULATEPRICEToolStripMenuItem, Me.VIEWSUMMARYToolStripMenuItem})
        Me.PROCESSToolStripMenuItem.Name = "PROCESSToolStripMenuItem"
        Me.PROCESSToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.PROCESSToolStripMenuItem.Text = "PROCESS"
        '
        'CALCULATEPRICEToolStripMenuItem
        '
        Me.CALCULATEPRICEToolStripMenuItem.Name = "CALCULATEPRICEToolStripMenuItem"
        Me.CALCULATEPRICEToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.CALCULATEPRICEToolStripMenuItem.Text = "CALCULATE PRICE"
        '
        'VIEWSUMMARYToolStripMenuItem
        '
        Me.VIEWSUMMARYToolStripMenuItem.Name = "VIEWSUMMARYToolStripMenuItem"
        Me.VIEWSUMMARYToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.VIEWSUMMARYToolStripMenuItem.Text = "VIEW SUMMARY"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSiakapWeight)
        Me.Controls.Add(Me.txtKerisiWeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKembungWeight)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Harga Ikan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkKerisi As CheckBox
    Friend WithEvents chkKembung As CheckBox
    Friend WithEvents chkSiakap As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkNone As CheckBox
    Friend WithEvents chkSiang As CheckBox
    Friend WithEvents txtKembungWeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKerisiWeight As TextBox
    Friend WithEvents txtSiakapWeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROCESSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULATEPRICEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWSUMMARYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
End Class
