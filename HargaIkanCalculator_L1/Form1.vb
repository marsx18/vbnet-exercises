Public Class Form1
    Private Sub chkKembung_CheckedChanged(sender As Object, e As EventArgs) Handles chkKembung.CheckedChanged
        txtKembungWeight.Enabled = chkKembung.Checked
        If Not chkKembung.Checked Then txtKembungWeight.Clear()
    End Sub

    Private Sub chkKerisi_CheckedChanged(sender As Object, e As EventArgs) Handles chkKerisi.CheckedChanged
        txtKerisiWeight.Enabled = chkKerisi.Checked
        If Not chkKerisi.Checked Then txtKerisiWeight.Clear()
    End Sub

    Private Sub chkSiakap_CheckedChanged(sender As Object, e As EventArgs) Handles chkSiakap.CheckedChanged
        txtSiakapWeight.Enabled = chkSiakap.Checked
        If Not chkSiakap.Checked Then txtSiakapWeight.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalPrice As Double = 0
        Dim totalKg As Double = 0

        ' Kembung RM9/kg
        If chkKembung.Checked Then
            Dim weight As Double
            If Double.TryParse(txtKembungWeight.Text, weight) Then
                totalPrice += weight * 9.0
                totalKg += weight
            Else
                MessageBox.Show("Please enter a valid weight for Kembung.")
                Exit Sub
            End If
        End If

        ' Kerisi RM10/kg
        If chkKerisi.Checked Then
            Dim weight As Double
            If Double.TryParse(txtKerisiWeight.Text, weight) Then
                totalPrice += weight * 10.0
                totalKg += weight
            Else
                MessageBox.Show("Please enter a valid weight for Kerisi.")
                Exit Sub
            End If
        End If

        ' Siakap RM12/kg
        If chkSiakap.Checked Then
            Dim weight As Double
            If Double.TryParse(txtSiakapWeight.Text, weight) Then
                totalPrice += weight * 12.0
                totalKg += weight
            Else
                MessageBox.Show("Please enter a valid weight for Siakap.")
                Exit Sub
            End If
        End If

        ' Cleaning fee RM1/kg if selected
        If chkSiang.Checked Then
            totalPrice += totalKg * 1.0
        End If

        ' Display breakdown + total
        MessageBox.Show("Total weight: " & totalKg & " kg" & vbCrLf &
                        "Total price: " & totalPrice.ToString("C2"),
                        "Price Calculation")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all checkboxes and textboxes
        chkKembung.Checked = False
        chkKerisi.Checked = False
        chkSiakap.Checked = False
        txtKembungWeight.Clear()
        txtKerisiWeight.Clear()
        txtSiakapWeight.Clear()
        chkSiang.Checked = False
        txtKembungWeight.Enabled = False
        txtKerisiWeight.Enabled = False
        txtSiakapWeight.Enabled = False
        MessageBox.Show("All fields have been cleared.", "Clear Fields")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
