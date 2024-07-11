Imports MySql.Data.MySqlClient


Public Class frmSales
    Dim total As Double
    Dim startamount As Double
    Dim sdate1 As String
    Dim sdate2 As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Sub LoadRecords()
        Try
            sdate1 = dt1.Value.ToString("yyyy-MM-dd")
            sdate2 = dt2.Value.ToString("yyyy-MM-dd")
            Dim i As Integer
            total = 0
            startamount = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from vwcart where status like 'Completed' and tdate between '" & sdate1 & "' and '" & sdate2 & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                total += CDbl(dr.Item("total").ToString)
                DataGridView1.Rows.Add(i, dr.Item("transno").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString, dr.Item("tableno").ToString, dr.Item("user").ToString, Format(CDate(dr.Item("tdate").ToString).ToShortDateString))

            End While
            dr.Close()
            cn.Close()

            cn.Open()
            cm = New MySqlCommand("select ifnull(sum(initialcash),0) as cash from tblstart where sdate between '" & sdate1 & "' and '" & sdate2 & "'", cn)
            startamount = CDbl(cm.ExecuteScalar)
            cn.Close()


            lblTotal.Text = "Sales: " & Format(total, "₱ #, ##0.00") & Space(5) & "Start Amount: " & Format(startamount, "₱ #, ##0.00") & Space(5) & "TOTAL AMOUNT: " & Format(total + startamount, "₱ #, ##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        LoadRecords()

    End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt1.Value = Now
        dt2.Value = Now
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        LoadRecords()

    End Sub

    Private Sub picPreview_Click(sender As Object, e As EventArgs) Handles picPreview.Click
        With frmPrintPreview
            .PrintPreview("select * from vwcart where status like 'Completed%' and tdate between '" & sdate1 & "' and '" & sdate2 & "'", startamount, total + startamount)
            .ShowDialog()
        End With
    End Sub
End Class