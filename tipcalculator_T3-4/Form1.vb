Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtBillAmount_TextChanged(sender As Object, e As EventArgs) Handles txtBillAmount.TextChanged

    End Sub

    Private Sub btnFifteen_Click(sender As Object, e As EventArgs) Handles btnFifteen.Click
        'Variable Declaration.
        Dim dblBill As Double = 0.0 'aaaaaaaa
        Dim dblTip As Double = 0.0

        'Get the amount of the bil.
        dblBill = CDbl(txtBillAmount.Text)

        'Calculate a 15 percent tip.
        dblTip = dblBill * 0.15

        'Display the tip
        lblTip.Text = CStr(dblTip)


    End Sub

    Private Sub btnTwenty_Click(sender As Object, e As EventArgs) Handles btnTwenty.Click
        'Variable Declaration.
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        'Get amount of the bill
        dblBill = CDbl(txtBillAmount.Text)

        'Calculate a 20 percent tip
        dblTip = dblBill * 0.2

        'Display the tip
        lblTip.Text = CStr(dblTip)

    End Sub

    Private Sub btnTwentyFive_Click(sender As Object, e As EventArgs) Handles btnTwentyFive.Click
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        dblBill = CDbl(txtBillAmount.Text)

        dblTip = dblBill * 0.25

        lblTip.Text = CStr(dblTip)

    End Sub

    Private Sub lblTip_TextChanged(sender As Object, e As EventArgs) Handles lblTip.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close form
        Me.Close()


    End Sub
End Class
