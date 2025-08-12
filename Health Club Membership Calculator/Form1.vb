Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decBaseFee As Decimal 'Monthly base fee
        Dim decTotalFee As Decimal 'Total fee  
        Dim intMonths As Integer 'Number of months
        Dim blnInputOk As Boolean = True 'Input validation flag

        'Constraint for base fee
        Const decADULT_FEE As Decimal = 40D
        Const decCHILD_FEE As Decimal = 20D
        Const decSTUDENT_FEE As Decimal = 25D
        Const decSENIOR_FEE As Decimal = 30D

        'Constraint for additional fees
        Const decYOGA_FEE As Decimal = 10D
        Const decKARATE_FEE As Decimal = 30D
        Const decTRAINER_FEE As Decimal = 50D

    End Sub
End Class
