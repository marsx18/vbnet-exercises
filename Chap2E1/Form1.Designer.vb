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
        Me.chkCheckBox = New System.Windows.Forms.CheckBox()
        Me.cboPets = New System.Windows.Forms.ComboBox()
        Me.lstVegetables = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radOption3 = New System.Windows.Forms.RadioButton()
        Me.radOption2 = New System.Windows.Forms.RadioButton()
        Me.radOption1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.hsbHorizontal = New System.Windows.Forms.HScrollBar()
        Me.lblPet = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.vsbVertical = New System.Windows.Forms.VScrollBar()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblHSCrollValue = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblVegetable = New System.Windows.Forms.Label()
        Me.lblVScrollValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkCheckBox
        '
        Me.chkCheckBox.AutoSize = True
        Me.chkCheckBox.Location = New System.Drawing.Point(15, 34)
        Me.chkCheckBox.Name = "chkCheckBox"
        Me.chkCheckBox.Size = New System.Drawing.Size(170, 17)
        Me.chkCheckBox.TabIndex = 0
        Me.chkCheckBox.Text = "The Check Box is un-checked"
        Me.chkCheckBox.UseVisualStyleBackColor = True
        '
        'cboPets
        '
        Me.cboPets.FormattingEnabled = True
        Me.cboPets.Items.AddRange(New Object() {"Tiger", "Cat", "Lion", "Rabbit", "Bear"})
        Me.cboPets.Location = New System.Drawing.Point(26, 30)
        Me.cboPets.Name = "cboPets"
        Me.cboPets.Size = New System.Drawing.Size(121, 21)
        Me.cboPets.TabIndex = 1
        Me.cboPets.Text = "Choose a Pet"
        '
        'lstVegetables
        '
        Me.lstVegetables.FormattingEnabled = True
        Me.lstVegetables.Items.AddRange(New Object() {"Beans", "Broccoli", "Carrots", "Lettuce"})
        Me.lstVegetables.Location = New System.Drawing.Point(17, 19)
        Me.lstVegetables.Name = "lstVegetables"
        Me.lstVegetables.Size = New System.Drawing.Size(120, 95)
        Me.lstVegetables.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPets)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 80)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ComboBox"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 80)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CheckBox"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstVegetables)
        Me.GroupBox3.Location = New System.Drawing.Point(510, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 131)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ListBox"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radOption3)
        Me.GroupBox4.Controls.Add(Me.radOption2)
        Me.GroupBox4.Controls.Add(Me.radOption1)
        Me.GroupBox4.Location = New System.Drawing.Point(72, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 125)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RadioButton"
        '
        'radOption3
        '
        Me.radOption3.AutoSize = True
        Me.radOption3.Location = New System.Drawing.Point(25, 79)
        Me.radOption3.Name = "radOption3"
        Me.radOption3.Size = New System.Drawing.Size(65, 17)
        Me.radOption3.TabIndex = 2
        Me.radOption3.TabStop = True
        Me.radOption3.Text = "Option 3"
        Me.radOption3.UseVisualStyleBackColor = True
        '
        'radOption2
        '
        Me.radOption2.AutoSize = True
        Me.radOption2.Location = New System.Drawing.Point(25, 56)
        Me.radOption2.Name = "radOption2"
        Me.radOption2.Size = New System.Drawing.Size(65, 17)
        Me.radOption2.TabIndex = 1
        Me.radOption2.TabStop = True
        Me.radOption2.Text = "Option 2"
        Me.radOption2.UseVisualStyleBackColor = True
        '
        'radOption1
        '
        Me.radOption1.AutoSize = True
        Me.radOption1.Location = New System.Drawing.Point(25, 33)
        Me.radOption1.Name = "radOption1"
        Me.radOption1.Size = New System.Drawing.Size(65, 17)
        Me.radOption1.TabIndex = 0
        Me.radOption1.TabStop = True
        Me.radOption1.Text = "Option 1"
        Me.radOption1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.hsbHorizontal)
        Me.GroupBox5.Location = New System.Drawing.Point(287, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(166, 80)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "HScrollBar"
        '
        'hsbHorizontal
        '
        Me.hsbHorizontal.Location = New System.Drawing.Point(51, 33)
        Me.hsbHorizontal.Name = "hsbHorizontal"
        Me.hsbHorizontal.Size = New System.Drawing.Size(81, 17)
        Me.hsbHorizontal.TabIndex = 0
        '
        'lblPet
        '
        Me.lblPet.AutoSize = True
        Me.lblPet.Location = New System.Drawing.Point(105, 165)
        Me.lblPet.Name = "lblPet"
        Me.lblPet.Size = New System.Drawing.Size(72, 13)
        Me.lblPet.TabIndex = 7
        Me.lblPet.Text = "You selected:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.vsbVertical)
        Me.GroupBox6.Location = New System.Drawing.Point(548, 256)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(128, 141)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "VScrollBar"
        '
        'vsbVertical
        '
        Me.vsbVertical.Location = New System.Drawing.Point(59, 33)
        Me.vsbVertical.Name = "vsbVertical"
        Me.vsbVertical.Size = New System.Drawing.Size(10, 80)
        Me.vsbVertical.TabIndex = 0
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.Location = New System.Drawing.Point(105, 384)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(72, 13)
        Me.lblOption.TabIndex = 8
        Me.lblOption.Text = "You selected:"
        '
        'lblHSCrollValue
        '
        Me.lblHSCrollValue.AutoSize = True
        Me.lblHSCrollValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSCrollValue.Location = New System.Drawing.Point(319, 339)
        Me.lblHSCrollValue.Name = "lblHSCrollValue"
        Me.lblHSCrollValue.Size = New System.Drawing.Size(103, 17)
        Me.lblHSCrollValue.TabIndex = 9
        Me.lblHSCrollValue.Text = "Move the scroll bar"
        Me.lblHSCrollValue.UseCompatibleTextRendering = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(358, 400)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblVegetable
        '
        Me.lblVegetable.AutoSize = True
        Me.lblVegetable.Location = New System.Drawing.Point(545, 212)
        Me.lblVegetable.Name = "lblVegetable"
        Me.lblVegetable.Size = New System.Drawing.Size(72, 13)
        Me.lblVegetable.TabIndex = 11
        Me.lblVegetable.Text = "You selected:"
        '
        'lblVScrollValue
        '
        Me.lblVScrollValue.AutoSize = True
        Me.lblVScrollValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVScrollValue.Location = New System.Drawing.Point(554, 400)
        Me.lblVScrollValue.Name = "lblVScrollValue"
        Me.lblVScrollValue.Size = New System.Drawing.Size(103, 17)
        Me.lblVScrollValue.TabIndex = 12
        Me.lblVScrollValue.Text = "Move the scroll bar"
        Me.lblVScrollValue.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Experiment With These Controls"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVScrollValue)
        Me.Controls.Add(Me.lblVegetable)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHSCrollValue)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.lblPet)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkCheckBox As CheckBox
    Friend WithEvents cboPets As ComboBox
    Friend WithEvents lstVegetables As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblPet As Label
    Friend WithEvents radOption3 As RadioButton
    Friend WithEvents radOption2 As RadioButton
    Friend WithEvents radOption1 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblOption As Label
    Friend WithEvents lblHSCrollValue As Label
    Friend WithEvents vsbVertical As VScrollBar
    Friend WithEvents btnClose As Button
    Friend WithEvents lblVegetable As Label
    Friend WithEvents hsbHorizontal As HScrollBar
    Friend WithEvents lblVScrollValue As Label
    Friend WithEvents Label1 As Label
End Class
