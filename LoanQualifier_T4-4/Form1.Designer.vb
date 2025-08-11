<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        txtYearsOnJob = New TextBox()
        Label1 = New Label()
        txtSalary = New TextBox()
        Label2 = New Label()
        lblMessage = New TextBox()
        Label3 = New Label()
        btnCheckQualifications = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtYearsOnJob)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtSalary)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(91, 88)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(608, 125)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter the following information: "
        ' 
        ' txtYearsOnJob
        ' 
        txtYearsOnJob.Location = New Point(309, 75)
        txtYearsOnJob.Name = "txtYearsOnJob"
        txtYearsOnJob.Size = New Size(148, 27)
        txtYearsOnJob.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 20)
        Label1.TabIndex = 2
        Label1.Text = "Number of years at your current job: "
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(309, 33)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(148, 27)
        txtSalary.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(199, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 0
        Label2.Text = "Annual salary: "
        ' 
        ' lblMessage
        ' 
        lblMessage.Location = New Point(158, 247)
        lblMessage.Multiline = True
        lblMessage.Name = "lblMessage"
        lblMessage.ReadOnly = True
        lblMessage.Size = New Size(500, 52)
        lblMessage.TabIndex = 4
        lblMessage.WordWrap = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(444, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 5
        ' 
        ' btnCheckQualifications
        ' 
        btnCheckQualifications.Location = New Point(119, 343)
        btnCheckQualifications.Name = "btnCheckQualifications"
        btnCheckQualifications.Size = New Size(165, 74)
        btnCheckQualifications.TabIndex = 6
        btnCheckQualifications.Text = "Check Qualifications"
        btnCheckQualifications.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(334, 343)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(165, 74)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(550, 343)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(165, 74)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 447)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCheckQualifications)
        Controls.Add(Label3)
        Controls.Add(lblMessage)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Loan Qualifier"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtYearsOnJob As TextBox
    Friend WithEvents lblMessage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCheckQualifications As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
