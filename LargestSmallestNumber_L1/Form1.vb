Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Find the first number in the text box
        Dim firstNumber As Double
        If Double.TryParse(txtFirstNumber.Text, firstNumber) Then
            'Find the second number in the text box
            Dim secondNumber As Double
            If Double.TryParse(txtSecondNumber.Text, secondNumber) Then
                'Find the smallest number
                Dim smallestNumber As Double = Math.Min(firstNumber, secondNumber)
                'Find the largest number
                Dim largestNumber As Double = Math.Max(firstNumber, secondNumber)
                'Display the results
                lblSmallestNumber.Text = smallestNumber.ToString()
                lblLargestNumber.Text = largestNumber.ToString()
            Else
                MessageBox.Show("Please enter a valid second number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter a valid first number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the text boxes and labels
        txtFirstNumber.Clear()
        txtFirstNumber.Focus()
        txtSecondNumber.Clear()
        lblSmallestNumber.Text = String.Empty
        lblLargestNumber.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
