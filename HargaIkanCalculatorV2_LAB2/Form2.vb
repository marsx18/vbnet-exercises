Public Class SummaryForm
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show number of customers
        lblCustomers.Text = Form1.TotalCustomers.ToString()

        ' Show total sales
        lblSales.Text = "RM " & Form1.TotalSales.ToString("F2")

        ' Show average sales
        If Form1.TotalCustomers > 0 Then
            Dim avg As Double = Form1.TotalSales / Form1.TotalCustomers
            lblAverage.Text = "RM " & avg.ToString("F2")
        Else
            lblAverage.Text = "RM 0.00"
        End If
    End Sub
End Class
