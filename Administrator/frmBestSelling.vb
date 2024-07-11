Imports MySql.Data.MySqlClient
Public Class frmBestSelling

    Sub LoadRecords()
        Try
            Dim i As Integer
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select distinct description, price, ifnull(sum(qty), 0) as qty, ifnull(sum(total),0) as total from vwcart where tdate between '" & dt1.Value.ToString("yyyy-MM-dd") & "' and '" & dt2.Value.ToString("yyyy-MM-dd") & "' group by description order by qty desc, total desc", cn)
            dr = cm.ExecuteReader
            While (dr.Read)
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("description").ToString, Format(CDbl(dr.Item("price").ToString), "#,##0.00"), Format(CDbl(dr.Item("qty").ToString), "#,##0.00"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))


            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        LoadRecords()

    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        LoadRecords()

    End Sub
End Class