Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decBaseFee As Decimal 'Monthly base fee
        Dim decTotalFee As Decimal 'Total fee  
        Dim intMonths As Integer 'Number of months
        Dim blnInputOk As Boolean = True 'Input validation flag

        'Constraint for base fee
        Const decADULT_FEE As Decimal = 40D
        Const decCHILD_FEE As Decimal = 20D
        Const decSTUDENT_FEE As Decimal = 25D
        Const decSENIOR_FEE As Decimal = 30D

        'Constraint for additional fees
        Const decYOGA_FEE As Decimal = 10D
        Const decKARATE_FEE As Decimal = 30D
        Const decTRAINER_FEE As Decimal = 50D

        'Validate and convert the number of months input
        If Integer.TryParse(txtMonths.Text, intMonths) = False Then
            lblStatus2.Text = "Months must be an integer."
            blnInputOk = False
        ElseIf intMonths < 1 Or intMonths > 24 Then
            lblStatus2.Text = "Months must be in the range of 1 - 24."
            blnInputOk = False
        End If

        If blnInputOk = False Then
            Exit Sub
        End If

        'Determine the base fee based on the selected membership type
        If radAdult.Checked Then
            decBaseFee = decADULT_FEE
        ElseIf radChild.Checked Then
            decBaseFee = decCHILD_FEE
        ElseIf radStudent.Checked Then
            decBaseFee = decSTUDENT_FEE
        ElseIf radSenior.Checked Then
            decBaseFee = decSENIOR_FEE
        Else
            lblStatus2.Text = "Please select a membership type."
            Exit Sub
        End If

        'Check for additional fees
        If chkYoga.Checked Then
            decBaseFee += decYOGA_FEE
        End If
        If chkKarate.Checked Then
            decBaseFee += decKARATE_FEE
        End If
        If chkTrainer.Checked Then
            decBaseFee += decTRAINER_FEE
        End If

        'Calculate the total fee
        decTotalFee = decBaseFee * intMonths
        'Display the total fee
        lblMonthlyFee.Text = decBaseFee.ToString("c")
        lblTotalFee.Text = decTotalFee.ToString("c")
        lblStatus2.Text = String.Empty
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkYoga.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radAdult.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radChild.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radSenior.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkKarate.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkTrainer.CheckedChanged

    End Sub

    Private Sub txtMonths_TextChanged(sender As Object, e As EventArgs) Handles txtMonths.TextChanged

    End Sub

    Private Sub lblMonthlyFee_TextChanged(sender As Object, e As EventArgs) Handles lblMonthlyFee.TextChanged

    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotalFee.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset the radio buttons
        radAdult.Checked = True

        'Reset the checkboxes
        chkYoga.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False

        'Clear the number of months input
        txtMonths.Clear()
        'Clear the labels
        lblMonthlyFee.Text = String.Empty
        lblTotalFee.Text = String.Empty
        lblStatus2.Text = String.Empty
        'Set focus back to the number of months input
        txtMonths.Focus()
    End Sub

    Private Sub bnExit_Click(sender As Object, e As EventArgs) Handles bnExit.Click
        'Close the form 
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblStatus2.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
