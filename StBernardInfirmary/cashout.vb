Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class cashout
#Region "Declares"
    Dim connection As New MySqlConnection
    Dim val As Integer
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cashoutbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query = "SELECT trans_items,trans_price FROM cashier_table WHERE trans_id='" & transidtxt.Text & "' AND trans_status='" & "Not Paid" & "'"
        Dim update = "UPDATE cashier_table SET trans_status = '" & "Paid" & "' WHERE trans_id = '" & transidtxt.Text & "'"
        Dim cmd As New MySqlCommand()
        Dim updatecmd As New MySqlCommand(update, connection)
        Try
            connection.Open()
            cmd = New MySqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            updatecmd.ExecuteNonQuery()
            MsgBox("Cash out successful!")
            cashoutprintpreview.cashval.Text = cashtxt.Text
            cashoutprintpreview.changeval.Text = changetxt.Text
            cashoutprintpreview.totaltxt.Text = totaltxt.Text
            cashier.transidtxt.Text = ""
            cashier.totaltxt.Text = ""
            cashier.itemlisttxt.Items.Clear()
            cashier.pricelisttxt.Items.Clear()
            cashoutprintpreview.Show()
            Me.Close()
            connection.Close()
        Catch ex As Exception
            MsgBox("Error in System. Please try again later!")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub cashtxt_TextChanged(sender As Object, e As EventArgs) Handles cashtxt.TextChanged
        Dim intcash As Integer
        Dim inttotal As Integer
        If cashtxt.Text <> "" Then
            intcash = CInt(cashtxt.Text)
            inttotal = CInt(totaltxt.Text)
            If intcash < inttotal Then
                cashoutbtn.Enabled = False
            Else
                cashoutbtn.Enabled = True
                changetxt.Text = intcash - inttotal
            End If
        Else
            MsgBox("Please Input value")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub cashout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class