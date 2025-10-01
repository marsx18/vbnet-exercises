<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SummaryForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Customers :"
        '
        'lblCustomers
        '
        Me.lblCustomers.Location = New System.Drawing.Point(352, 129)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.ReadOnly = True
        Me.lblCustomers.Size = New System.Drawing.Size(112, 22)
        Me.lblCustomers.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Sales :"
        '
        'lblSales
        '
        Me.lblSales.Location = New System.Drawing.Point(352, 184)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.ReadOnly = True
        Me.lblSales.Size = New System.Drawing.Size(112, 22)
        Me.lblSales.TabIndex = 3
        '
        'lblAverage
        '
        Me.lblAverage.Location = New System.Drawing.Point(352, 245)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.ReadOnly = True
        Me.lblAverage.Size = New System.Drawing.Size(112, 22)
        Me.lblAverage.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Average Sales :"
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustomers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SummaryForm"
        Me.Text = "Summary Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustomers As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSales As TextBox
    Friend WithEvents lblAverage As TextBox
    Friend WithEvents Label3 As Label
End Class
