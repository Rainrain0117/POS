Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intX
        Me.Height = intY - 30
        Me.Top = 0
        Me.Left = 0

        Panel4.Left = (Panel3.Width - Panel4.Width) / 2
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        With ProductList
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            Panel4.Controls.Add(ProductList)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        With frmCancelOrderList
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            Panel4.Controls.Add(frmCancelOrderList)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        With frmSales
            .WindowState = FormWindowState.Maximized
            .TopLevel = False
            Panel4.Controls.Add(frmSales)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()

    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        With Table
            .btnUpdate.Enabled = False
            .Loadrecord()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnBestSelling_Click(sender As Object, e As EventArgs) Handles btnBestSelling.Click
        With frmBestSelling
            .TopLevel = False
            Panel4.Controls.Add(frmBestSelling)
            .LoadRecords()
            .BringToFront()
            .Show()


        End With
    End Sub

    Private Sub btnSalesSummary_Click(sender As Object, e As EventArgs) Handles btnSalesSummary.Click
        With frmSalesSummary
            .TopLevel = False
            Panel4.Controls.Add(frmSalesSummary)
            .LoadYearlySales()
            .LoadQuarterlySales()
            .LoadMonthlySales()
            .LoadDailySales()
            .LoadWeeklySales()
            .LoadSASales()
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        With frmDiscount
            .LoadRecords()
            .btnUpdate.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btnStockInventory_Click(sender As Object, e As EventArgs) Handles btnStockInventory.Click
        With frmInventory
            .ShowDialog()

        End With
    End Sub
End Class