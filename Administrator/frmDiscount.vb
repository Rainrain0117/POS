Imports MySql.Data.MySqlClient

Public Class frmDiscount
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Sub LoadRecords()
        Try
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from tbldiscount", cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("description").ToString, dr.Item("percent").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub txtPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercent.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Save this discount?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("insert into tbldiscount values(@description, @percent)", cn)
                With cm
                    .Parameters.AddWithValue("@description", txtDescription.Text)
                    .Parameters.AddWithValue("@percent", txtPercent.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("Record has been successfully saved!", vbInformation)
                LoadRecords()
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        txtDescription.Clear()
        txtPercent.Clear()
        txtDescription.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Enabled = False

    End Sub '

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colEdit" Then
            txtDescription.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            txtPercent.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            txtDescription.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        ElseIf colname = "colDelete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tbldiscount where description = @description", cn)
                cm.Parameters.AddWithValue("@description", txtDescription.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully deleted!", vbInformation)
                LoadRecords()
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If MsgBox("Update this discount?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("update tbldiscount set percent = @percent where description = @description", cn)
                With cm
                    .Parameters.AddWithValue("@percent", txtPercent.Text)
                    .Parameters.AddWithValue("@description", txtDescription.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("Record has been successfully updated!", vbInformation)
                LoadRecords()
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


End Class