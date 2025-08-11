Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub btnCheckQualifications_Click(sender As Object, e As EventArgs) Handles btnCheckQualifications.Click
        'Variables to hold input data
        Dim dblSalary As Double
        Dim intYearsOnJob As Integer

        Try
            'Get the users input
            dblSalary = CDbl(txtSalary.Text)
            intYearsOnJob = CInt(txtYearsOnJob.Text)

            'Determine wether the user qualifies for a loan
            If dblSalary > 3000 Then
                If intYearsOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does not qualify. "
                End If
            Else
                If intYearsOnJob > 5 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does not qualify."
                End If
            End If

        Catch ex As Exception
            'Display an error message
            lblMessage.Text = "Please enter numeric values"

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'cLear the text boxes and label
        txtSalary.Clear()
        txtYearsOnJob.Clear()
        lblMessage.Text = String.Empty
        txtSalary.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
