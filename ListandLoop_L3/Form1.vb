Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hargaSehari As Double = 0
        Dim jumlah As Double = 0
        Dim hari As Integer

        'Semak kalau tiada kereta dipilih
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Sila pilih jenis kereta.")
            Exit Sub
        End If

        'Semak input bilangan hari
        If Not Integer.TryParse(txtDays.Text, hari) Or hari <= 0 Then
            MessageBox.Show("Sila masukkan bilangan hari yang sah.")
            Exit Sub
        End If

        'Tetapkan harga berdasarkan pilihan kereta
        Select Case ListBox1.SelectedItem.ToString()
            Case "Viva"
                hargaSehari = 100
            Case "MyVi"
                hargaSehari = 150
            Case "Alza"
                hargaSehari = 170
            Case "Saga"
                hargaSehari = 120
            Case "Persona"
                hargaSehari = 150
        End Select

        'Kira jumlah
        jumlah = hargaSehari * hari

        'Paparkan dalam textbox jumlah
        txtTotal.Text = "RM " & jumlah.ToString("F2")
    End Sub
End Class
