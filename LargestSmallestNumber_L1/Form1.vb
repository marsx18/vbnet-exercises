Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Find the first number in the text box
        Dim firstNumber As Double
        If Double.TryParse(txtFirstNumber.Text, firstNumber) Then
            'Find the second number in the text box
            Dim secondNumber As Double
            If Double.TryParse(txtSecondNumber.Text, secondNumber) Then
                'Find the smallest and largest numbers
                Dim smallestNumber As Double = Math.Min(firstNumber, secondNumber)
                Dim largestNumber As Double = Math.Max(firstNumber, secondNumber)

                'Display the results in a MessageBox
                MessageBox.Show("The smallest number is: " & smallestNumber.ToString() & Environment.NewLine &
                                "The largest number is: " & largestNumber.ToString(), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Please enter a valid second number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter a valid first number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the text boxes
        txtFirstNumber.Clear()
        txtSecondNumber.Clear()
        txtFirstNumber.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
