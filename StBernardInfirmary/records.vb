Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class records
#Region "Declares"
    Dim connection As New MySqlConnection
    Private WithEvents pd As New Printing.PrintDocument
    Private ppd As PrintPreviewDialog
    Dim fullnamedoctor As String
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        adminmainmenu.Show()
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        headertxt.Text = "ST. BERNARD INFIRMARY AND MULTI-SPECIALTY CLINIC, INC." + vbCrLf + "Doctor: " + doctortxt.Text + " " + " Date: " + DateTime.Now() + vbCrLf + "DIAGNOSIS:" + vbCrLf + vbCrLf
        Dim searchname As String = recordtxt.Text.Replace(" ", "").ToLower() + "_recordtable"
        Dim searchquery As String = "SELECT * FROM " + searchname + " ORDER BY record_id ASC"
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Dim command As New MySqlCommand
        Try
            connection.Open()
            command = New MySqlCommand(searchquery, connection)
            If command.ExecuteNonQuery() Then
                dataadapter.SelectCommand = command
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                recordview.DataSource = source
                dataadapter.Update(datatable)
                connection.Close()
            Else
                MsgBox("Record Not Exists")
            End If
        Catch ex As Exception
            MsgBox("Record Not Exists")
        Finally
            connection.Dispose()

        End Try

    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim searchname As String = recordtxt.Text.Replace(" ", "").ToLower() + "_recordtable"
        Dim searchquery As String = "SELECT * FROM" + " " + searchname + " ORDER BY record_id ASC"
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Dim command As New MySqlCommand
        Try
            connection.Open()
            command = New MySqlCommand(searchquery, connection)
            If command.ExecuteNonQuery() Then
                diagnosistxt.Text = ""
                dataadapter.SelectCommand = command
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                recordview.DataSource = source
                dataadapter.Update(datatable)
                connection.Close()
            Else
                MsgBox("Record Not Exists")
            End If
        Catch ex As Exception
            MsgBox("Record Not Exists")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim diagnosis As String = diagnosistxt.Text
        Dim searchname As String = recordtxt.Text.Replace(" ", "").ToLower() + "_recordtable"
        Dim datetoday As String = DateTime.Now()
        Dim savequery As String = "INSERT INTO " + searchname + " (record_diagnosis,record_Date_Created) VALUES('" + diagnosis + "','" + datetoday + "')"
        If recordtxt.Text = "" Then
            MsgBox("Please search the record first")
        Else
            Try
                If diagnosistxt.Text = "" Then
                    MsgBox("Please put some words in the dignosis!")
                ElseIf recordtxt.Text = "" Then
                    MsgBox("Please search the record first !")
                Else
                    connection.Open()
                    Dim query As String
                    query = "SELECT * FROM " + searchname + " ORDER BY record_ID ASC"
                    Dim command As New MySqlCommand
                    Dim commandrefresh As New MySqlCommand
                    commandrefresh = New MySqlCommand(query, connection)
                    command = New MySqlCommand(savequery, connection)
                    command.ExecuteNonQuery()
                    MsgBox("Save Successfully!")
                    Dim dataadapter As New MySqlDataAdapter
                    Dim source As New BindingSource
                    Dim datatable As New DataTable
                    dataadapter.SelectCommand = commandrefresh
                    dataadapter.Fill(datatable)
                    source.DataSource = datatable
                    recordview.DataSource = source
                    dataadapter.Update(datatable)
                    connection.Close()
                    ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                    ppd.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox(ex)
            Finally
                connection.Dispose()
            End Try
        End If


    End Sub

    Private Sub recordview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles recordview.CellClick
        ridtxt.Text = recordview.Rows(e.RowIndex).Cells(0).Value.ToString
        diagnosistxt.Text = recordview.Rows(e.RowIndex).Cells(1).Value.ToString
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim diagnosis As String = diagnosistxt.Text
        Dim searchname As String = recordtxt.Text.Replace(" ", "").ToLower() + "_recordtable"
        Dim datetoday As String = DateTime.Now()
        Dim editquery As String = "UPDATE " + searchname + " SET record_diagnosis='" & diagnosistxt.Text & "',record_Date_Edited='" & datetoday & "' WHERE record_ID='" & ridtxt.Text & "'"
        If diagnosistxt.Text = "" Then
            MsgBox("Please put some words in the diagnosis!")
        ElseIf ridtxt.Text = "" Then
            MsgBox("Please Select from the data view")
        ElseIf ridtxt.Text = "" Then
            MsgBox("Please Search for the Record First!")
        Else
            connection.Open()
            Dim command As New MySqlCommand()
            Dim query As String
            query = "SELECT * FROM " + searchname + " ORDER BY record_ID ASC"
            command = New MySqlCommand(editquery, connection)
            Dim commandrefresh As New MySqlCommand
            commandrefresh = New MySqlCommand(query, connection)
            command.ExecuteNonQuery()
            commandrefresh.ExecuteNonQuery()
            MsgBox("Edit Successfully!")
            Dim dataadapter As New MySqlDataAdapter
            Dim source As New BindingSource
            Dim datatable As New DataTable
            dataadapter.SelectCommand = commandrefresh
            dataadapter.Fill(datatable)
            source.DataSource = datatable
            recordview.DataSource = source
            dataadapter.Update(datatable)
            connection.Close()
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim searchname As String = recordtxt.Text.Replace(" ", "").ToLower() + "_recordtable"
        Dim command As New MySqlCommand
        Dim retrievecommand As New MySqlCommand
        Dim query As String = "DELETE FROM " + searchname + " WHERE record_ID='" & ridtxt.Text & "'"
        Dim retrieve As String = "SELECT * FROM " + searchname + " ORDER BY record_ID ASC"
        If ridtxt.Text = "" Then
            MsgBox("Please select from the data view first to delete!")
        ElseIf recordtxt.Text = "" Then
            MsgBox("Please Search for the record first!")
        Else
            Try
                connection.Open()
                command = New MySqlCommand(query, connection)
                retrievecommand = New MySqlCommand(retrieve, connection)
                command.ExecuteNonQuery()
                retrievecommand.ExecuteNonQuery()
                MsgBox("Deleted Successfully!")
                Dim dataadapter As New MySqlDataAdapter
                Dim source As New BindingSource
                Dim datatable As New DataTable
                dataadapter.SelectCommand = retrievecommand
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                recordview.DataSource = source
                dataadapter.Update(datatable)
                connection.Close()
            Catch ex As Exception
                MsgBox("Error in system, Please try again later!")
            Finally
                connection.Dispose()
            End Try
        End If

    End Sub

    Private Sub records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        'Single line textboxes. 
        'The locations used are just the location on the form in this case.
        Dim fnt As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        'Multiline textbox
        'Here i used the textbox bounds as the layout rectangle
        e.Graphics.DrawString(headertxt.Text, fnt, Brushes.Black, headertxt.Bounds, Drawing.StringFormat.GenericTypographic)
        e.Graphics.DrawString(diagnosistxt.Text, fnt, Brushes.Black, diagnosistxt.Bounds, Drawing.StringFormat.GenericTypographic)
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
        ppd.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If recordtxt.Text = "" Or diagnosistxt.Text = "" Then
            MsgBox("Please Search first and diagnose the patient first!")
        Else
            labrequestform.patienttxt.Text = recordtxt.Text
            labrequestform.doctornametxt.Text = doctortxt.Text
            connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
            Dim diagnosis As String = diagnosistxt.Text
            Dim searchname As String = recordtxt.Text.Replace(" ", "").ToLower() + "_recordtable"
            Dim datetoday As String = DateTime.Now()
            Dim savequery As String = "INSERT INTO " + searchname + " (record_diagnosis,record_Date_Created) VALUES('" + diagnosis + "','" + datetoday + "')"
            Try
                connection.Open()
                Dim query As String
                query = "SELECT * FROM " + searchname + " ORDER BY record_ID ASC"
                Dim command As New MySqlCommand
                Dim commandrefresh As New MySqlCommand
                commandrefresh = New MySqlCommand(query, connection)
                command = New MySqlCommand(savequery, connection)
                command.ExecuteNonQuery()
                MsgBox("Save Successfully!")
                Dim dataadapter As New MySqlDataAdapter
                Dim source As New BindingSource
                Dim datatable As New DataTable
                dataadapter.SelectCommand = commandrefresh
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                recordview.DataSource = source
                dataadapter.Update(datatable)
                connection.Close()
                ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                ppd.ShowDialog()
            Catch ex As Exception
                    MsgBox(ex)
                Finally
                    connection.Dispose()
                End Try
                labrequestform.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class