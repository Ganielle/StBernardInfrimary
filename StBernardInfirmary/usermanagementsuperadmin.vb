Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Public Class usermanagementsuperadmin
#Region "Declares"
    Dim connection As New MySqlConnection
#End Region

    Private Sub savebtn_Click(ByVal sender As Object, e As EventArgs) Handles savebtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"

        Dim username As String
        Dim passwordhash As String
        Dim fname As String
        Dim mname As String
        Dim lname As String
        Dim userlevel As String
        Dim query As String
        Try
            username = usernametxt.Text
            passwordhash = SHA256(passwordtxt.Text)
            fname = fnametxt.Text
            mname = mnametxt.Text
            lname = lnametxt.Text
            userlevel = userlevelcombobox.Text
            If usernametxt.Text = "" Then
                MsgBox("Please input values !")
            ElseIf passwordtxt.Text = "" Then
                MsgBox("Please input values !")
            ElseIf fnametxt.Text = "" Then
                MsgBox("Please input values !")
            ElseIf mnametxt.Text = "" Then
                MsgBox("Please input values !")
            ElseIf lnametxt.Text = "" Then
                MsgBox("Please input values !")
            ElseIf userlevelcombobox.Text = "" Then
                MsgBox("Please input values !")
            Else
                connection.Open()
                Dim existuser As String
                query = "INSERT INTO user_table(user_username,user_password,user_fname,user_mname,user_lname,user_level) VALUES('" + username + "','" + passwordhash + "','" + fname + "','" + mname + "','" + lname + "','" + userlevel + "')"
                existuser = "SELECT user_username FROM user_table WHERE user_username = '" & usernametxt.Text & "'"
                Dim command As New MySqlCommand(query, connection)
                Dim exist As New MySqlCommand(existuser, connection)
                Dim existusername As String
                existusername = exist.ExecuteScalar()
                If existusername <> usernametxt.Text Then
                    command.ExecuteNonQuery()
                    usernametxt.Text = ""
                    passwordtxt.Text = ""
                    fnametxt.Text = ""
                    mnametxt.Text = ""
                    lnametxt.Text = ""
                    userlevelcombobox.Text = ""
                    MsgBox("User Successfully Added !")
                    Dim querydatagrid As String
                    querydatagrid = "SELECT * FROM user_table ORDER BY uid ASC"
                    Dim dataadapter As New MySqlDataAdapter
                    Dim source As New BindingSource
                    Dim datatable As New DataTable
                    command = New MySqlCommand(querydatagrid, connection)
                    dataadapter.SelectCommand = command
                    dataadapter.Fill(datatable)
                    source.DataSource = datatable
                    userview.DataSource = source
                    dataadapter.Update(datatable)
                Else
                    MsgBox("User exist")
                End If
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox("Error in database")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub gobackbtn_Click(sender As Object, e As EventArgs) Handles gobackbtn.Click
        usernametxt.Text = ""
        passwordtxt.Text = ""
        fnametxt.Text = ""
        mnametxt.Text = ""
        lnametxt.Text = ""
        userlevelcombobox.Text = ""
        Me.Close()
        connection.Close()
        superadminmainmenu.Show()
    End Sub

    Private Function SHA256(ByVal content As String) As String
        Dim molecule As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim bytestring() As Byte = System.Text.Encoding.ASCII.GetBytes(content)
        bytestring = molecule.ComputeHash(bytestring)

        Dim finalstring As String = Nothing
        For Each bt As Byte In bytestring
            finalstring &= bt.ToString("x2")
        Next
        Return finalstring

    End Function

    Private Sub usermanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query As String
        query = "SELECT * FROM user_table ORDER BY uid ASC"
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Dim command As New MySqlCommand
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            dataadapter.SelectCommand = command
            dataadapter.Fill(datatable)
            source.DataSource = datatable
            userview.DataSource = source
            dataadapter.Update(datatable)
            connection.Close()
        Catch ex As Exception
            MsgBox("There was an error please try again later")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim username As String
        Dim query As String
        Dim command As New MySqlCommand
        username = usernametxt.Text
        query = "SELECT * FROM user_table WHERE user_username='" & searchtxt.Text & "'"
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            dataadapter.SelectCommand = command
            dataadapter.Fill(datatable)
            source.DataSource = datatable
            userview.DataSource = source
            dataadapter.Update(datatable)
            searchtxt.Text = ""
            connection.Close()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub userview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userview.CellClick
        userid.Text = userview.Rows(e.RowIndex).Cells(0).Value.ToString
        usernametxt.Text = userview.Rows(e.RowIndex).Cells(1).Value.ToString
        fnametxt.Text = userview.Rows(e.RowIndex).Cells(3).Value.ToString
        mnametxt.Text = userview.Rows(e.RowIndex).Cells(4).Value.ToString
        lnametxt.Text = userview.Rows(e.RowIndex).Cells(5).Value.ToString
        userlevelcombobox.Text = userview.Rows(e.RowIndex).Cells(6).Value.ToString
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim username As String
        Dim password As String = SHA256(passwordtxt.Text)
        Dim query As String
        Dim command As New MySqlCommand
        If usernametxt.Text = "" And fnametxt.Text = "" And mnametxt.Text = "" And lnametxt.Text = "" Then
            MsgBox("Please Select from the data view!")
        Else
            Try
                If passwordtxt.Text = "" Then
                    MsgBox("Please put new password for the user")
                ElseIf userlevelcombobox.Text = "" Then
                    MsgBox("Please put choose user level")
                Else
                    username = usernametxt.Text
                    query = "UPDATE user_table SET user_username='" & username & "',user_password='" & password & "',user_fname='" & fnametxt.Text & "',user_mname='" & mnametxt.Text & "',user_lname='" & lnametxt.Text & "',user_level='" & userlevelcombobox.Text & "' WHERE user_username='" & username & "'"
                    connection.Open()
                    command = New MySqlCommand(query, connection)
                    command.ExecuteNonQuery()
                    MsgBox("Update Successfull !")
                    usernametxt.Text = ""
                    passwordtxt.Text = ""
                    fnametxt.Text = ""
                    mnametxt.Text = ""
                    lnametxt.Text = ""
                    userlevelcombobox.Text = ""
                    Dim querydatagrid As String
                    querydatagrid = "SELECT * FROM user_table ORDER BY uid ASC"
                    Dim dataadapter As New MySqlDataAdapter
                    Dim source As New BindingSource
                    Dim datatable As New DataTable
                    command = New MySqlCommand(querydatagrid, connection)
                    dataadapter.SelectCommand = command
                    dataadapter.Fill(datatable)
                    source.DataSource = datatable
                    userview.DataSource = source
                    dataadapter.Update(datatable)
                End If
                connection.Close()
            Catch ex As Exception
                MsgBox("Error in system please try again later")
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim username As String
        Dim query As String
        Dim command As New MySqlCommand
        If usernametxt.Text = "" Or fnametxt.Text = "" Or mnametxt.Text = "" Or lnametxt.Text = "" Or userlevelcombobox.Text = "" Then
            MsgBox("Please Select from the data view!")
        Else
            Try
                username = usernametxt.Text
                query = "DELETE FROM user_table WHERE user_username='" & username & "'"
                connection.Open()
                command = New MySqlCommand(query, connection)
                If command.ExecuteNonQuery() Then
                    MsgBox("Successfully Deleted")
                    usernametxt.Text = ""
                    passwordtxt.Text = ""
                    fnametxt.Text = ""
                    mnametxt.Text = ""
                    lnametxt.Text = ""
                    userlevelcombobox.Text = ""
                    Dim querydatagrid As String
                    querydatagrid = "SELECT * FROM user_table ORDER BY uid ASC"
                    Dim dataadapter As New MySqlDataAdapter
                    Dim source As New BindingSource
                    Dim datatable As New DataTable
                    command = New MySqlCommand(querydatagrid, connection)
                    dataadapter.SelectCommand = command
                    dataadapter.Fill(datatable)
                    source.DataSource = datatable
                    userview.DataSource = source
                    dataadapter.Update(datatable)
                Else
                    MsgBox("User not exist")
                End If
                connection.Close()
            Catch ex As Exception
                MsgBox(ex)
            Finally
                connection.Dispose()
            End Try
        End If

    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query As String
        query = "SELECT * FROM user_table ORDER BY uid ASC"
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Dim command As New MySqlCommand
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            dataadapter.SelectCommand = command
            dataadapter.Fill(datatable)
            source.DataSource = datatable
            userview.DataSource = source
            dataadapter.Update(datatable)
            searchtxt.Text = ""
            connection.Close()
        Catch ex As Exception
            MsgBox("There was an error please try again later")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class