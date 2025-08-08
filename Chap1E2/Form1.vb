Public Class Form1
    Private Sub EnglishButton_Click(sender As Object, e As EventArgs) Handles EnglishButton.Click
        HelloLabel.Text = "Hello"
    End Sub
    Private Sub SpanishButton_Click(sender As Object, e As EventArgs) Handles SpanishButton.Click
        HelloLabel.Text = "Hola"
    End Sub
    Private Sub FrenchButton_Click(sender As Object, e As EventArgs) Handles FrenchButton.Click
        HelloLabel.Text = "Bonjour"
    End Sub
End Class
