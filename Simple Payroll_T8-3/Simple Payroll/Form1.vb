Public Class Form1
    Private Sub btnCalcPay_Click(sender As Object, e As EventArgs) Handles btnCalcPay.Click
        'Constants
        Const decHOURLY_RATE As Decimal = 15D
        Const intMAX_SUBSCRIPT As Integer = 5

        'Array and other variables
        Dim dblHoursArray(intMAX_SUBSCRIPT) As Double
        Dim intCount As Integer = 0
        Dim decEmpPay As Decimal

        'Prepare the user to enter each employee's hours worked
        MessageBox.Show("I'm going to ask you for each " & "employee's hours worked. ")
        'Get the hours worked for each employee
        Do While intCount < dblHoursArray.Length
            Try
                dblHoursArray(intCount) =
                    CDbl(InputBox("Employee number " & (intCount + 1).ToString()))
                intCount += 1
            Catch
                'Display an error message
                MessageBox.Show("Enter a valid number of hours for that employee")

            End Try
        Loop

        'Calculate and display each employee's pay
        For intCount = 0 To dblHoursArray.Length - 1
            decEmpPay = CDec(dblHoursArray(intCount) * decHOURLY_RATE)

            lstOutput.Items.Add("Employee " & (intCount + 1).ToString() & " earned " & decEmpPay.ToString("c"))


        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
