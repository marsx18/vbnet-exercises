Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Variable declarations
        Dim decSalesAmount As Decimal ' Monthly sales amount
        Dim decAdvancePayAmount As Decimal ' Advance payment amount
        Dim decCommissionRate As Decimal ' Commission rate
        Dim decCommissionAmount As Decimal ' Commission amount
        Dim decNetPay As Decimal ' Net pay after commission

        Try
            'Clear an previous messages
            lblStatus.Text = String.Empty
            'Get the sales amount of sales
            decSalesAmount = CDec(txtSalesAmount.Text)

            'Get the amount of advance payment
            decAdvancePayAmount = CDec(txtAdvancePayAmount.Text)

            'Determine the commision rate
            Select Case decSalesAmount
                Case Is < 10000
                    decCommissionRate = 0.05D ' 5% commission
                Case 10000 To 14999
                    decCommissionRate = 0.1D ' 10% commission
                Case 15000 To 17999
                    decCommissionRate = 0.12D ' 12% commission
                Case 18000 To 21999
                    decCommissionRate = 0.14D ' 14% commission
                Case Is >= 22000
                    decCommissionRate = 0.15D ' 15% commission


            End Select
            'Calculate the amount of commission and net pay amounts
            decCommissionAmount = decSalesAmount * decCommissionRate
            decNetPay = decCommissionAmount - decAdvancePayAmount

            'Display rate , commission amount and net pay
            lblCommissionRate.Text = decCommissionRate.ToString("p") ' Display as percentage
            lblCommissionAmount.Text = decCommissionAmount.ToString("c") ' Display as currency
            lblNetPay.Text = decNetPay.ToString("c") ' Display as currency
        Catch
            'Display an error message if an exception occurs.
            lblStatus.Text = "Please enter numeric values"

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the text boxes and labels.
        txtAdvancePayAmount.Clear()
        txtSalesAmount.Clear()
        lblCommissionAmount.Text = String.Empty
        lblCommissionRate.Text = String.Empty
        lblNetPay.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Set the focus to txtSalesAmount.
        txtSalesAmount.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub lblCommissionRate_Click(sender As Object, e As EventArgs) Handles lblCommissionRate.Click

    End Sub
End Class
