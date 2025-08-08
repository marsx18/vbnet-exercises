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
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscountPercentage = New System.Windows.Forms.TextBox()
        Me.lblSalePrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOriginalPrice
        '
        Me.txtOriginalPrice.Location = New System.Drawing.Point(416, 96)
        Me.txtOriginalPrice.Name = "txtOriginalPrice"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(156, 22)
        Me.txtOriginalPrice.TabIndex = 0
        '
        'txtDiscountPercentage
        '
        Me.txtDiscountPercentage.Location = New System.Drawing.Point(416, 147)
        Me.txtDiscountPercentage.Name = "txtDiscountPercentage"
        Me.txtDiscountPercentage.Size = New System.Drawing.Size(156, 22)
        Me.txtDiscountPercentage.TabIndex = 1
        '
        'lblSalePrice
        '
        Me.lblSalePrice.Location = New System.Drawing.Point(416, 204)
        Me.lblSalePrice.Multiline = True
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(156, 44)
        Me.lblSalePrice.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the item's original price: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter the discount percentage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sale price:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(249, 328)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(155, 66)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Sale Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(417, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 66)
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
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.txtDiscountPercentage)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Name = "Form1"
        Me.Text = "Sale Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents txtDiscountPercentage As TextBox
    Friend WithEvents lblSalePrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decOriginalPrice As Decimal = 0 'Original price input
        Dim decDiscountPercentage As Decimal = 0 'Discount percentage input
        Dim decDiscountAmount As Decimal = 0 'Calculated discount amount
        Dim decSalePrice As Decimal = 0 'Calculated sale price

        'Get the original price
        decOriginalPrice = CDec(txtOriginalPrice.Text)
        'Get the discount percentage
        decDiscountPercentage = CDec(txtDiscountPercentage.Text)

        'Move percentage decimal to the left two places
        decDiscountPercentage = decDiscountPercentage / 100
        'Calculate the discount amount
        decDiscountAmount = decOriginalPrice * decDiscountPercentage
        'Calculate the sale price
        decSalePrice = decOriginalPrice - decDiscountAmount
        'Display the sale price
        lblSalePrice.Text = decSalePrice.ToString("c") '"c" means currency format

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()

    End Sub
End Class
