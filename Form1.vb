Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class FormInventory
    Dim conn As New MySqlConnection
    Dim objConnection As New Connection

    Dim cmd As MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowMeTheTable()
    End Sub

    Private Sub ClearFields()
        strCodeBox.Text = ""
        strNameBox.Text = ""
        strDescriptionBox.Text = ""
        strCostBox.Text = ""
        strSaleBox.Text = ""
        strSuppliesBox.Text = ""
        strNoteBox.Text = ""
    End Sub

    Private Sub ShowMeTheTable()
        conn = objConnection.OpenConnection

        Dim query As String = "SELECT * FROM inventory"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        tblQuery.DataSource = ds.Tables(0)

        conn.Close()
        conn.Dispose()

    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If strCodeBox.Text = "" Then
            MessageBox.Show("Please, type the Product's Code", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf strNameBox.Text = "" Then
            MessageBox.Show("Please, type the Product's Name", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf strDescriptionBox.Text = "" Then
            MessageBox.Show("Please, type the Product's Description", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf strCostBox.Text = "" Then
            MessageBox.Show("Please, type the Purchase Price", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf strSaleBox.Text = "" Then
            MessageBox.Show("Please, type the Sale Price", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        ElseIf strSuppliesBox.Text = "" Then
            MessageBox.Show("Please, type how many units are available", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Else
            conn = objConnection.OpenConnection
            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "INSERT INTO inventory(Code, Article, Description, Cost, Sale, Supplies, Notes) VALUES(@cde, @art, @des, @cst, @sal, @sup ,@obs);"
                cmd.Parameters.AddWithValue("@cde", strCodeBox.Text)
                cmd.Parameters.AddWithValue("@art", strNameBox.Text)
                cmd.Parameters.AddWithValue("@des", strDescriptionBox.Text)
                cmd.Parameters.AddWithValue("@cst", strCostBox.Text)
                cmd.Parameters.AddWithValue("@sal", strSaleBox.Text)
                cmd.Parameters.AddWithValue("@sup", strSuppliesBox.Text)
                cmd.Parameters.AddWithValue("@obs", strNoteBox.Text)

                cmd.ExecuteNonQuery()

                conn.Close()
                conn.Dispose()

                ShowMeTheTable()
                ClearFields()

                SaveButton.Enabled = False
                DeleteButton.Enabled = True
                UpdateButton.Enabled = True
                tblQuery.Enabled = True
                strQueryByNameBox.Enabled = True

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles tblQuery.CellContentClick
        Dim row As DataGridViewRow = tblQuery.CurrentRow
        Try
            strCodeBox.Text = row.Cells(0).Value.ToString()
            strNameBox.Text = row.Cells(1).Value.ToString()
            strDescriptionBox.Text = row.Cells(2).Value.ToString()
            strCostBox.Text = row.Cells(3).Value.ToString().Replace(",", ".")
            strSaleBox.Text = row.Cells(4).Value.ToString().Replace(",", ".")
            strSuppliesBox.Text = row.Cells(5).Value.ToString()
            strNoteBox.Text = row.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If strCodeBox.Text = "" Then
            MessageBox.Show("Please, Choose the article that you would like to edit.", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else
            conn = objConnection.OpenConnection
            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE inventory SET Article=@art,Description=@des,Cost=@cst,Sale=@sal,Supplies=@sup,Notes=@obs WHERE (Code=@cde);"
                cmd.Parameters.AddWithValue("@cde", strCodeBox.Text)
                cmd.Parameters.AddWithValue("@art", strNameBox.Text)
                cmd.Parameters.AddWithValue("@des", strDescriptionBox.Text)
                cmd.Parameters.AddWithValue("@cst", strCostBox.Text)
                cmd.Parameters.AddWithValue("@sal", strSaleBox.Text)
                cmd.Parameters.AddWithValue("@sup", strSuppliesBox.Text)
                cmd.Parameters.AddWithValue("@obs", strNoteBox.Text)

                cmd.ExecuteNonQuery()

                ShowMeTheTable()

                conn.Close()
                conn.Dispose()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If strCodeBox.Text = "" Then
            MessageBox.Show("Please, Choose the article that you would like to delete.", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else

            conn = objConnection.OpenConnection
            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "DELETE FROM inventory WHERE (Code=@cde);"
                cmd.Parameters.AddWithValue("@cde", strCodeBox.Text)

                cmd.ExecuteNonQuery()

                ShowMeTheTable()

                conn.Close()
                conn.Dispose()

                ClearFields()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        ClearFields()
        SaveButton.Enabled = True
        DeleteButton.Enabled = False
        UpdateButton.Enabled = False
        tblQuery.Enabled = False
        strQueryByNameBox.Enabled = False
    End Sub

    Private Sub strQueryByNameBox_TextChanged(sender As Object, e As EventArgs) Handles strQueryByNameBox.TextChanged
        conn = objConnection.OpenConnection
        Try
            Dim query As String = "SELECT * FROM inventory WHERE Article LIKE '%" & strQueryByNameBox.Text & "%';"
            Dim adpt As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            tblQuery.DataSource = ds.Tables(0)

            conn.Close()
            conn.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        ''conn = objConnection.OpenConnection
        ''Try
        ''cmd = conn.CreateCommand
        ''cmd.CommandText = "SELECT * FROM inventory WHERE Article LIKE '%" & strQueryByNameBox.Text & "%';"
        ''cmd.Parameters.AddWithValue("@cde", strCodeBox.Text)
        ''
        ''cmd.ExecuteNonQuery()
        ''
        ''ShowMeTheTable()
        ''
        ''conn.Close()
        ''conn.Dispose()
        ''
        ''ClearFields()

        ''Catch ex As Exception
        ''MsgBox(ex.Message, MsgBoxStyle.Critical)
        ''End Try
    End Sub

End Class
