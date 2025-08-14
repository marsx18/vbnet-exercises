Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles lblCategory.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTemperature.TextChanged

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'cHEthe temperature and set the category
        Dim temperature As Double
        If Double.TryParse(txtTemperature.Text, temperature) Then
            If temperature < 20 Then

                lblCategory.Text = "SEJUK"
            ElseIf temperature >= 20 AndAlso temperature < 30 Then
                lblCategory.Text = "SEDERHANA"
            Else
                lblCategory.Text = "PANAS"
            End If
        Else
            lblCategory.Text = "SILA MASUKKAN NILAI YANG BETUL"
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the input and output
        txtTemperature.Clear()
        lblCategory.Text = String.Empty

        txtTemperature.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'cLOSE THE FORM
        Me.Close()
    End Sub
End Class
