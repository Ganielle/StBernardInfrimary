Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class registration
#Region "Declares"
    Dim connection As New MySqlConnection
    Public Property passtransid As String
    Public Property passqueueid As String
#End Region
    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        For i As Integer = 1 To 12 Step 1
            monthcombobox.Items.Add(i)
        Next
        Dim year As Integer = Date.Now.Year
        Dim finalyear As Integer = Date.Now.Year
        finalyear = year - 90
        For i As Integer = year To finalyear Step -1
            year_combobox.Items.Add(i)
        Next
        For i As Integer = 0 To 99 Step 1
            agetxt.Items.Add(i)
        Next
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query As String
        query = "SELECT * FROM registration_table ORDER BY ruid ASC"
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
            registrationview.DataSource = source
            dataadapter.Update(datatable)
            connection.Close()
        Catch ex As Exception
            MsgBox("There was an error please try again later")
        Finally
            connection.Dispose()
        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Close()
        superadminmainmenu.Show()
    End Sub

    Private Sub registrationview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles registrationview.CellClick
        uidtxt.Text = registrationview.Rows(e.RowIndex).Cells(0).Value.ToString
        fnametxt.Text = registrationview.Rows(e.RowIndex).Cells(1).Value.ToString
        mnametxt.Text = registrationview.Rows(e.RowIndex).Cells(2).Value.ToString
        lnametxt.Text = registrationview.Rows(e.RowIndex).Cells(3).Value.ToString
        agetxt.Text = registrationview.Rows(e.RowIndex).Cells(4).Value.ToString
        gendertxt.Text = registrationview.Rows(e.RowIndex).Cells(5).Value.ToString
        addresstxt.Text = registrationview.Rows(e.RowIndex).Cells(6).Value.ToString
        monthcombobox.Text = registrationview.Rows(e.RowIndex).Cells(7).Value.ToString
        date_combobox.Text = registrationview.Rows(e.RowIndex).Cells(8).Value.ToString
        year_combobox.Text = registrationview.Rows(e.RowIndex).Cells(9).Value.ToString
        birthplacetxt.Text = registrationview.Rows(e.RowIndex).Cells(10).Value.ToString
        nationalitytxt.Text = registrationview.Rows(e.RowIndex).Cells(11).Value.ToString
        occupationtxt.Text = registrationview.Rows(e.RowIndex).Cells(12).Value.ToString
        contactnumbertxt.Text = registrationview.Rows(e.RowIndex).Cells(13).Value.ToString
        religiontxt.Text = registrationview.Rows(e.RowIndex).Cells(14).Value.ToString
        spousetxt.Text = registrationview.Rows(e.RowIndex).Cells(15).Value.ToString
        mothertxt.Text = registrationview.Rows(e.RowIndex).Cells(16).Value.ToString
        fathertxt.Text = registrationview.Rows(e.RowIndex).Cells(17).Value.ToString

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles searchtypelabel.Click

    End Sub

    Private Sub searchtypebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchtypebox.SelectedIndexChanged
        searchtypelabel.Text = searchtypebox.Text
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim searchtype As String
        Dim query As String
        Dim command As New MySqlCommand
        searchtype = searchtypebox.Text
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Try
            If searchtype = "ID" Then
                connection.Open()
                query = "SELECT * FROM registration_table WHERE ruid='" & searchtxt.Text & "'"
                command = New MySqlCommand(query, connection)
                dataadapter.SelectCommand = command
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                registrationview.DataSource = source
                dataadapter.Update(datatable)
                searchtxt.Text = ""
                connection.Close()
            Else
                connection.Open()
                query = "SELECT * FROM registration_table WHERE register_fname='" & searchtxt.Text & "'"
                command = New MySqlCommand(query, connection)
                dataadapter.SelectCommand = command
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                registrationview.DataSource = source
                dataadapter.Update(datatable)
                searchtxt.Text = ""
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query As String
        query = "SELECT * FROM registration_table ORDER BY ruid ASC"
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
            registrationview.DataSource = source
            dataadapter.Update(datatable)
            searchtxt.Text = ""
            connection.Close()
        Catch ex As Exception
            MsgBox("There was an error in system please try again later!")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim fname As String = fnametxt.Text
        Dim mname As String = mnametxt.Text
        Dim lname As String = lnametxt.Text
        Dim age As String = agetxt.Text
        Dim gender As String = gendertxt.Text
        Dim address As String = addresstxt.Text
        Dim month As String = monthcombobox.Text
        Dim datee As String = date_combobox.Text
        Dim year As String = year_combobox.Text
        Dim birthplace As String = birthplacetxt.Text
        Dim nationality As String = nationalitytxt.Text
        Dim occupation As String = occupationtxt.Text
        Dim contact As String = contactnumbertxt.Text
        Dim religion As String = religiontxt.Text
        Dim spouse As String = spousetxt.Text
        Dim mother As String = mothertxt.Text
        Dim father As String = fathertxt.Text
        Dim query As String = ""
        Dim existfname As String = "SELECT register_fname FROM registration_table"
        Dim existmname As String = "SELECT register_mname FROM registration_table"
        Dim existlname As String = "SELECT register_lname FROM registration_table"
        Try
            query = "INSERT INTO registration_table(register_fname,register_mname,register_lname,register_age,register_gender,register_address,register_birthmonth,register_birthdate,register_birthyear,register_birthplace,register_nationality,register_occupation,register_contact,register_religion,register_spouse,register_mother,register_father) VALUES('" + fname + "','" + mname + "','" + lname + "','" + age + "','" + gender + "','" + address + "','" + month + "','" + datee + "','" + year + "','" + birthplace + "','" + nationality + "','" + occupation + "','" + contact + "','" + religion + "','" + spouse + "','" + mother + "','" + father + "')"
            If (fname <> "") And (mname <> "") And (lname <> "") And (age <> "") And (gender <> "") And (address <> "") And (month <> "") And (datee <> "") And (year <> "") And (nationality <> "") And (occupation <> "") And (contact <> "") And (religion <> "") And (spouse <> "") And (mother <> "") And (father <> "") Then
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                Dim commandfname As New MySqlCommand(existfname, connection)
                Dim commandmname As New MySqlCommand(existmname, connection)
                Dim commandlname As New MySqlCommand(existlname, connection)
                commandfname.ExecuteNonQuery()
                commandmname.ExecuteNonQuery()
                commandlname.ExecuteNonQuery()
                Dim existf As String = Convert.ToString(commandfname.ExecuteScalar())
                Dim existm As String = Convert.ToString(commandmname.ExecuteScalar())
                Dim existl As String = Convert.ToString(commandlname.ExecuteScalar())
                Dim fullnametrim As String = fname.Replace(" ", "") + lname.Replace(" ", "")
                Dim fullnamefinal = fullnametrim.ToLower()
                Dim fullname As String = fullnamefinal + "_recordtable"
                If (fname = existf) And (mname = existm) And (lname = existl) Then
                    MsgBox("User Exist")
                Else
                    Dim querysavetable As String = "CREATE TABLE IF NOT EXISTS " + fullname + "(record_ID int NOT NULL AUTO_INCREMENT, record_diagnosis varchar(300),record_Date_Created varchar(30),record_Date_Edited varchar(30), PRIMARY KEY (record_ID))"
                    Dim commandsavetable As New MySqlCommand(querysavetable, connection)
                    commandsavetable.ExecuteNonQuery()
                    command.ExecuteNonQuery()
                    fnametxt.Text = ""
                    mnametxt.Text = ""
                    lnametxt.Text = ""
                    agetxt.Text = ""
                    gendertxt.Text = ""
                    addresstxt.Text = ""
                    monthcombobox.Text = ""
                    date_combobox.Text = ""
                    year_combobox.Text = ""
                    nationalitytxt.Text = ""
                    occupationtxt.Text = ""
                    contactnumbertxt.Text = ""
                    religiontxt.Text = ""
                    spousetxt.Text = ""
                    mothertxt.Text = ""
                    fathertxt.Text = ""
                    MsgBox("User Successfully Added !")
                    Dim querydatagrid As String
                    querydatagrid = "SELECT * FROM registration_table ORDER BY ruid ASC"
                    Dim dataadapter As New MySqlDataAdapter
                    Dim source As New BindingSource
                    Dim datatable As New DataTable
                    command = New MySqlCommand(querydatagrid, connection)
                    dataadapter.SelectCommand = command
                    dataadapter.Fill(datatable)
                    source.DataSource = datatable
                    registrationview.DataSource = source
                    dataadapter.Update(datatable)
                    connection.Close()
                End If
            Else
                MsgBox("Please fill up the form")
            End If
        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim fname As String = fnametxt.Text
        Dim mname As String = mnametxt.Text
        Dim lname As String = lnametxt.Text
        Dim age As String = agetxt.Text
        Dim gender As String = gendertxt.Text
        Dim address As String = addresstxt.Text
        Dim month As String = monthcombobox.Text
        Dim datee As String = date_combobox.Text
        Dim year As String = year_combobox.Text
        Dim birthplace As String = birthplacetxt.Text
        Dim nationality As String = nationalitytxt.Text
        Dim occupation As String = occupationtxt.Text
        Dim contact As String = contactnumbertxt.Text
        Dim religion As String = religiontxt.Text
        Dim spouse As String = spousetxt.Text
        Dim mother As String = mothertxt.Text
        Dim father As String = fathertxt.Text
        Dim query As String = "UPDATE registration_table SET register_fname='" & fname & "',register_mname='" & mname & "',register_lname='" & lname & "',register_age='" & age & "',register_gender='" & gender & "',register_address='" & address & "',register_birthmonth='" & month & "',register_birthdate='" & datee & "',register_birthyear='" & year & "',register_birthplace='" & birthplace & "',register_nationality='" & nationality & "',register_occupation='" & occupation & "',register_contact='" & contact & "',register_religion='" & religion & "',register_spouse='" & spouse & "',register_mother='" & mother & "',register_father='" & father & "' WHERE ruid='" & uidtxt.Text & "'"
        If (fname <> "") And (mname <> "") And (lname <> "") And (age <> "") And (gender <> "") And (address <> "") And (month <> "") And (datee <> "") And (year <> "") And (nationality <> "") And (occupation <> "") And (contact <> "") And (religion <> "") And (spouse <> "") And (mother <> "") And (father <> "") Then
            Try
                connection.Open()
                Dim command As New MySqlCommand
                command = New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
                MsgBox("Update Successfull")
                fnametxt.Text = ""
                mnametxt.Text = ""
                lnametxt.Text = ""
                agetxt.Text = ""
                gendertxt.Text = ""
                addresstxt.Text = ""
                monthcombobox.Text = ""
                date_combobox.Text = ""
                year_combobox.Text = ""
                nationalitytxt.Text = ""
                occupationtxt.Text = ""
                contactnumbertxt.Text = ""
                religiontxt.Text = ""
                spousetxt.Text = ""
                mothertxt.Text = ""
                fathertxt.Text = ""
                Dim querydatagrid As String
                querydatagrid = "SELECT * FROM registration_table ORDER BY ruid ASC"
                Dim dataadapter As New MySqlDataAdapter
                Dim source As New BindingSource
                Dim datatable As New DataTable
                command = New MySqlCommand(querydatagrid, connection)
                dataadapter.SelectCommand = command
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                registrationview.DataSource = source
                dataadapter.Update(datatable)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex)
            Finally
                connection.Dispose()
            End Try
        Else
            MsgBox("Please fill up the form first!")
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim fname As String = fnametxt.Text
        Dim mname As String = mnametxt.Text
        Dim lname As String = lnametxt.Text
        Dim age As String = agetxt.Text
        Dim gender As String = gendertxt.Text
        Dim address As String = addresstxt.Text
        Dim month As String = monthcombobox.Text
        Dim datee As String = date_combobox.Text
        Dim year As String = year_combobox.Text
        Dim birthplace As String = birthplacetxt.Text
        Dim nationality As String = nationalitytxt.Text
        Dim occupation As String = occupationtxt.Text
        Dim contact As String = contactnumbertxt.Text
        Dim religion As String = religiontxt.Text
        Dim spouse As String = spousetxt.Text
        Dim mother As String = mothertxt.Text
        Dim father As String = fathertxt.Text
        Dim query As String = "DELETE FROM registration_table WHERE ruid='" & uidtxt.Text & "'"
        Dim command As New MySqlCommand
        If (fname = "") And (mname = "") And (lname = "") And (age = "") And (gender = "") And (address = "") And (month = "") And (datee = "") And (year = "") And (nationality = "") And (occupation = "") And (contact = "") And (religion = "") And (spouse = "") And (mother = "") And (father = "") Then
            MsgBox("Please Select from the data view!")
        Else
            Try
                connection.Open()
                command = New MySqlCommand(query, connection)
                If command.ExecuteNonQuery Then
                    MsgBox("Successfully Deleted")
                    fnametxt.Text = ""
                    mnametxt.Text = ""
                    lnametxt.Text = ""
                    agetxt.Text = ""
                    gendertxt.Text = ""
                    addresstxt.Text = ""
                    monthcombobox.Text = ""
                    date_combobox.Text = ""
                    year_combobox.Text = ""
                    nationalitytxt.Text = ""
                    occupationtxt.Text = ""
                    contactnumbertxt.Text = ""
                    religiontxt.Text = ""
                    spousetxt.Text = ""
                    mothertxt.Text = ""
                    fathertxt.Text = ""
                    Dim querydatagrid As String
                    querydatagrid = "SELECT * FROM registration_table ORDER BY ruid ASC"
                    Dim dataadapter As New MySqlDataAdapter
                    Dim source As New BindingSource
                    Dim datatable As New DataTable
                    command = New MySqlCommand(querydatagrid, connection)
                    dataadapter.SelectCommand = command
                    dataadapter.Fill(datatable)
                    source.DataSource = datatable
                    registrationview.DataSource = source
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

    Private Sub monthcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monthcombobox.SelectedIndexChanged
        Dim x, y, z, leapyear As Integer
        If year_combobox.Text = "" Then
            MsgBox("Please choose Years first to know if its LEAP YEAR")
            monthcombobox.Refresh()
            monthcombobox.Text = ""
        ElseIf monthcombobox.Text = "2" Then
            leapyear = year_combobox.Text
            x = leapyear Mod 4
            y = leapyear Mod 100
            z = leapyear Mod 400
            If ((x = 0 And Not (y = 0)) Or z = 0) Then
                date_combobox.Items.Clear()
                For i As Integer = 1 To 29 Step 1
                    date_combobox.Items.Add(i)
                Next
            Else
                date_combobox.Items.Clear()
                For i As Integer = 1 To 28 Step 1
                    date_combobox.Items.Add(i)
                Next
            End If
        ElseIf monthcombobox.Text = "1" Or monthcombobox.Text = "3" Or monthcombobox.Text = "5" Or monthcombobox.Text = "7" Or monthcombobox.Text = "8" Or monthcombobox.Text = "10" Or monthcombobox.Text = "12" Then
            date_combobox.Items.Clear()
            For i As Integer = 1 To 31 Step 1
                date_combobox.Items.Add(i)
            Next
        Else
            date_combobox.Items.Clear()
            For i As Integer = 1 To 30 Step 1
                date_combobox.Items.Add(i)
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class