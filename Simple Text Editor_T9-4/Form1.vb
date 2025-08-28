Imports System.IO

Public Class Form1
    ' Class–level variables
    Private strFilename As String = String.Empty ' Document filename
    Dim blnIsChanged As Boolean = False

    Sub ClearDocument()
        ' Clear the contents of the text box.
        txtDocument.Clear()

        ' Clear the document name.
        strFilename = String.Empty

        ' Set isChanged to False.
        blnIsChanged = False
    End Sub

    ' The OpenDocument procedure opens a file and loads it into the TextBox
    Sub OpenDocument()
        Dim inputFile As StreamReader ' Object variable

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFilename = ofdOpenFile.FileName
            Try
                inputFile = File.OpenText(strFilename)
                txtDocument.Text = inputFile.ReadToEnd()
                inputFile.Close()
                blnIsChanged = False
            Catch
                MessageBox.Show("Error opening the file.")
            End Try
        End If
    End Sub

    ' The SaveDocument procedure saves the current document.
    Sub SaveDocument()
        Dim output As StreamWriter
        Try
            output = File.CreateText(strFilename)
            output.Write(txtDocument.Text)
            output.Close()
            blnIsChanged = False
        Catch
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub

    ' Track changes
    Private Sub txtDocument_TextChanged(sender As Object, e As EventArgs) Handles txtDocument.TextChanged
        blnIsChanged = True
    End Sub

    ' File -> New
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                ClearDocument()
            End If
        Else
            ClearDocument()
        End If
    End Sub

    ' File -> Open
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                ClearDocument()
                OpenDocument()
            End If
        Else
            ClearDocument()
            OpenDocument()
        End If
    End Sub

    ' File -> Save
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        If strFilename = String.Empty Then
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFilename = sfdSaveFile.FileName
                SaveDocument()
            End If
        Else
            SaveDocument()
        End If
    End Sub

    ' File -> Save As
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFilename = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub

    ' File -> Exit
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    ' Help -> About
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Simple Text Editor version 1.0")
    End Sub

    ' Handle form closing
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " &
                               "Do you wish to discard your changes?",
                               "Confirm",
                               MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
