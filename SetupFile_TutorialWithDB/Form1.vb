Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim id As Integer = Integer.Parse(TextBox1.Text)
            Dim name As String = TextBox2.Text
            Dim address As String = TextBox3.Text
            Dim age As Integer = Integer.Parse(TextBox4.Text)

            Dim query As String = "INSERT INTO UserInfo_Tab (id, name, address, age) VALUES (@id, @name, @address, @age)"

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\MyAttachedDB.mdf;Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@age", age)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    BindData()
                End Using
            End Using

            MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BindData()
        Try
            Dim query As String = "SELECT * FROM UserInfo_Tab"

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\MyAttachedDB.mdf;Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    Using sda As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindData()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
