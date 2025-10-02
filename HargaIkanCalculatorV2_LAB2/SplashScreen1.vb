Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set timer interval terus masa form load
        Timer1.Interval = 5000 ' 3000 ms = 3 saat
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False ' stop timer
        Me.Hide()              ' hide splash
        Form1.Show()           ' tunjuk form utama
    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

    End Sub
End Class
