﻿Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnterNames_Click(sender As Object, e As EventArgs) Handles btnEnterNames.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim strNames(intMAX_SUBSCRIPT) As String
        Dim intCount As Integer

        'Tell user what we ae about to do
        MessageBox.Show("I'm going to ask you to enter the " & "names of five friends. ")

        'Get the names and store them in the array
        For intCount = 0 To intMAX_SUBSCRIPT
            strNames(intCount) = InputBox("Enter a friend's name. ")
        Next
        'Clear the list box of its current contents 
        lstFriends.Items.Clear()

        'Display the contents of the array in the list box
        For intCount = 0 To intMAX_SUBSCRIPT
            lstFriends.Items.Add(strNames(intCount))
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
