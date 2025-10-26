Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub BindData()
        Try
            Dim query As String = "
                SELECT 
                    k.Name AS [Kayak Name],
                    r.Hourly_Rate AS [Hourly Rate],
                    r.Daily_Rate AS [Daily Rate],
                    r.Weekly_Rate AS [Weekly Rate]
                FROM KayakTypes k
                INNER JOIN RentalPrices r ON k.ID = r.Kayak_Id
                ORDER BY k.Name
            "

            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\Kayaks.mdf;Integrated Security=True;Connect Timeout=30")
                Using cmd As New SqlCommand(query, con)
                    Using sda As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        sda.Fill(dt)

                        DataGridView1.DataSource = dt

                        ' Formatting
                        DataGridView1.Columns("Hourly Rate").DefaultCellStyle.Format = "N2"
                        DataGridView1.Columns("Daily Rate").DefaultCellStyle.Format = "N2"
                        DataGridView1.Columns("Weekly Rate").DefaultCellStyle.Format = "N2"

                        DataGridView1.AllowUserToAddRows = False
                        DataGridView1.AllowUserToDeleteRows = False
                        DataGridView1.ReadOnly = True
                        DataGridView1.RowHeadersVisible = False
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
