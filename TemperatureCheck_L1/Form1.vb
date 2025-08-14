Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' Check the temperature and show the category 
        Dim temperature As Double

        If Double.TryParse(txtTemperature.Text, temperature) Then
            Dim category As String = ""

            If temperature < 20 Then
                category = "SEJUK"
            ElseIf temperature >= 20 AndAlso temperature <= 29 Then
                category = "SEDERHANA"
            ElseIf temperature >= 30 Then
                category = "PANAS"
            End If
            lblCategory.Text = category
        Else
            lblCategory.Text = "Sila masukkan suhu yang sah."
        End If
    End Sub




    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the input and show in message box
        txtTemperature.Clear()
        lblCategory.Text = ""
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
