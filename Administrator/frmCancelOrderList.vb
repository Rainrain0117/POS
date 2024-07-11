Imports MySql.Data.MySqlClient

Public Class frmCancelOrderList
    Dim sdate1 As String
    Dim sdate2 As String
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frmCancelOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub LoadRecords()
        Try
            sdate1 = dt1.Value.ToString("yyyy-MM-dd")
            sdate2 = dt2.Value.ToString("yyyy-MM-dd")
            Dim i As Integer

            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from vwcart where status like 'Cancel Order' and tdate between '" & sdate1 & "' and '" & sdate2 & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("transno").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString, dr.Item("tableno").ToString, dr.Item("user").ToString, Format(CDate(dr.Item("tdate").ToString).ToShortDateString))

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