Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class cashier
#Region "Declares"
    Dim connection As New MySqlConnection
    Dim val As Integer
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query = "SELECT trans_items,trans_price FROM cashier_table WHERE trans_id='" & transidtxt.Text & "' AND trans_status='" & "Not Paid" & "'"
        Dim cmd As New MySqlCommand()
        Dim reader As MySqlDataReader
        If transidtxt.Text = "" Then
            MsgBox("Please input transaction ID first!")
        Else
            Try
                connection.Open()
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader
                While reader.Read
                    Dim sname As String
                    sname = reader.Item("trans_items")
                    itemlisttxt.Items.Add(sname)
                    pricelisttxt.Items.Add(reader.Item("trans_price"))
                End While
                Dim total As Integer
                For Each list As String In pricelisttxt.Items
                    total = total + CInt(list)
                Next
                totaltxt.Text = total
                connection.Close()
            Catch ex As Exception
                MsgBox("Error in System. Please try again later!")
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        transidtxt.Text = ""
        itemlisttxt.Items.Clear()
        pricelisttxt.Items.Clear()
        totaltxt.Text = ""
        If totaltxt.Text = "" Or pricelisttxt.Text = "" Or itemlisttxt.Text = "" Then
            MsgBox("Please search for the item first!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sbitem As New StringBuilder
        Dim sbprice As New StringBuilder
        If totaltxt.Text = "" Or totaltxt.Text = "0" Then
            MsgBox("Please search for the items first!")
        Else
            For Each list As String In itemlisttxt.Items
                sbitem.AppendLine(list)
            Next
            For Each list As String In pricelisttxt.Items
                sbprice.AppendLine(list)
            Next
            cashoutprintpreview.pricelisttxt.Text = sbprice.ToString()
            cashoutprintpreview.itemlisttxt.Text = sbitem.ToString()
            cashoutprintpreview.transid.Text = transidtxt.Text
            cashout.transidtxt.Text = transidtxt.Text
            cashout.totaltxt.Text = totaltxt.Text
            cashout.Show()
        End If

    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class