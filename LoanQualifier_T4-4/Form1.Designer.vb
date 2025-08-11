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
        lblAnnualSalary = New Label()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(lblAnnualSalary)
        GroupBox1.Location = New Point(91, 88)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(608, 125)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter the following information: "
        ' 
        ' lblAnnualSalary
        ' 
        lblAnnualSalary.AutoSize = True
        lblAnnualSalary.Location = New Point(100, 40)
        lblAnnualSalary.Name = "lblAnnualSalary"
        lblAnnualSalary.Size = New Size(104, 20)
        lblAnnualSalary.TabIndex = 0
        lblAnnualSalary.Text = "Annual salary: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(210, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(148, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Loan Qualifier"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblAnnualSalary As Label

End Class
