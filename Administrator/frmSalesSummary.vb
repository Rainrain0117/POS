Imports MySql.Data.MySqlClient
Public Class frmSalesSummary
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Sub LoadYearlySales()
        Try
            dgvYear.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select year(sdate) as year, sum(total) as total from tblsales group by year(sdate) order by year(sdate) desc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvYear.Rows.Add(dr.Item("year").ToString, Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub LoadSASales()
        Try
            dgvSA.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select month(sdate) as month, week(sdate) as week, sum(total) as total from tblsales group by month(sdate)<6, week(sdate) order by month(sdate) desc, week (sdate) desc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvSA.Rows.Add(dr.Item("month").ToString, (dr.Item("week").ToString), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub LoadQuarterlySales()
        Try
            dgvQuarter.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select year(sdate) as year, quarter(sdate) as quarter, sum(total) as total from tblsales group by year(sdate), quarter(sdate) order by year(sdate) desc, quarter(sdate) desc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvQuarter.Rows.Add(dr.Item("year").ToString, dr.Item("quarter").ToString, Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub LoadMonthlySales()
        Try
            dgvMonth.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select year(sdate) as year, month(sdate) as month, sum(total) as total from tblsales group by year(sdate), month(sdate) order by year(sdate) desc, month (sdate) desc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvMonth.Rows.Add(dr.Item("year").ToString, (dr.Item("month").ToString), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub LoadWeeklySales()
        Try
            dgvWeek.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select month(sdate) as month, week(sdate) as week, sum(total) as total from tblsales group by month(sdate), week(sdate) order by month(sdate) desc, week (sdate) desc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvWeek.Rows.Add(dr.Item("month").ToString, (dr.Item("week").ToString), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub LoadDailySales()
        Try
            dgvDaily.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select sdate, sum(total) as total from tblsales group by sdate order by sdate desc", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvDaily.Rows.Add(Format(CDate(dr.Item("sdate").ToString), "ddd MMM dd, yyyy"), Format(CDbl(dr.Item("total").ToString), "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click
        dgvQuarter.Visible = False
        dgvDaily.Visible = False
        dgvYear.Visible = True
        dgvMonth.Visible = False
        dgvWeek.Visible = False
        dgvSA.Visible = False
    End Sub

    Private Sub btnQuarterly_Click(sender As Object, e As EventArgs) Handles btnQuarterly.Click
        dgvQuarter.Visible = True
        dgvDaily.Visible = False
        dgvYear.Visible = False
        dgvMonth.Visible = False
        dgvWeek.Visible = False
        dgvSA.Visible = False

    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        dgvQuarter.Visible = False
        dgvDaily.Visible = False
        dgvYear.Visible = False
        dgvMonth.Visible = True
        dgvWeek.Visible = False
        dgvSA.Visible = False
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        dgvQuarter.Visible = False
        dgvDaily.Visible = True
        dgvYear.Visible = False
        dgvMonth.Visible = False
        dgvWeek.Visible = False
        dgvSA.Visible = False
    End Sub


    Private Sub btnWeek_Click(sender As Object, e As EventArgs) Handles btnWeek.Click
        dgvQuarter.Visible = False
        dgvDaily.Visible = False
        dgvYear.Visible = False
        dgvMonth.Visible = False
        dgvWeek.Visible = True
        dgvSA.Visible = False
    End Sub



    Private Sub btnSemiAnnual_Click(sender As Object, e As EventArgs) Handles btnSemiAnnual.Click
        dgvQuarter.Visible = False
        dgvDaily.Visible = False
        dgvYear.Visible = False
        dgvMonth.Visible = False
        dgvWeek.Visible = False
        dgvSA.Visible = True
    End Sub

    Private Sub frmSalesSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class