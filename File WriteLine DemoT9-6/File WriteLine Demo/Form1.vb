
Imports System.IO

Structure FriendInfo
    Dim strName As String
    Dim strPhone As String
End Structure
Public Class Form1
    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        Const intNUM_FRIENDS As Integer = 3

        'Local variables
        Dim strFileName As String
        Dim intCount As Integer
        Dim friendFile As StreamWriter
        Dim myFriend As FriendInfo

        'Get the file name.
        strFileName = InputBox("Enter the filename. ")

        Try
            'Open the file.
            friendFile = File.CreateText(strFileName)

            'Get the friends' information and write it to the file.
            For intCount = 1 To intNUM_FRIENDS
                'Get the friend's name.
                myFriend.strName = InputBox("Enter the name of friend " & "number " & intCount.ToString())
                'get the friend's phone number.
                myFriend.strPhone = InputBox("Enter that friend's phone number. ")

                'Write date to the file.]
                friendFile.WriteLine(myFriend.strName)
                friendFile.WriteLine(myFriend.strPhone)

            Next
            'Close the file.   
            friendFile.Close()
        Catch
            MessageBox.Show("That file cannot be created. ")

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form.
        Me.Close()
    End Sub
End Class
