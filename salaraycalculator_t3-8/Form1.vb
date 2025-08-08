Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal 'Annual salary input
        Dim intPayPeriods As Decimal 'Number of pay periods input
        Dim decSalary As Decimal 'Calculated salary per pay period

        Try
            'Get the annual salary and number of pay periods from the text boxes
            decAnnualSalary = CDec(txtAnnualSalary.Text)
            intPayPeriods = CInt(txtPayPeriods.Text)
            'Calculate the salary per pay period
            decSalary = decAnnualSalary / intPayPeriods
            'Display the result in the label
            lblSalary.Text = decSalary.ToString("")

        Catch
            'Display an error message if the input is not a valid number
            MessageBox.Show("Error: Be sure to enter nonzero numeric values")

        End Try
    End Sub
End Class
