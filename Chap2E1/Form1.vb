Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub cboPets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPets.SelectedIndexChanged
        lblPet.Text = cboPets.Text
    End Sub


    Private Sub radOption3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOption3.CheckedChanged
        If radOption3.Checked = True Then
            lblOption.Text = "Option 3"
        End If

    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub lstVegetables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVegetables.SelectedIndexChanged
        lblVegetable.Text = lstVegetables.Text

    End Sub


    Private Sub chkCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckBox.CheckedChanged
        If chkCheckBox.Checked Then
            chkCheckBox.Text = "Checked"
        Else
            chkCheckBox.Text = "Unchecked"
        End If
    End Sub

    Private Sub radOption1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOption1.CheckedChanged
        If radOption1.Checked = True Then
            lblOption.Text = "Option 1"
        End If

    End Sub

    Private Sub radOption2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOption2.CheckedChanged
        If radOption2.Checked = True Then
            lblOption.Text = "Option 2"
        End If

    End Sub

    Private Sub vsbVertical_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbVertical.Scroll
        lblVScrollValue.Text = CStr(vsbVertical.Value)

    End Sub

    Private Sub hsbHorizontal_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbHorizontal.Scroll
        lblHSCrollValue.Text = CStr(hsbHorizontal.Value)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
