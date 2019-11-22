Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class labrequestform
#Region "Declares"
    Dim connection As New MySqlConnection
    Dim cbcval As Integer = 500
    Dim plateletval As Integer = 500
    Dim urinalysisval As Integer = 500
    Dim fecalysisval As Integer = 500D
    Dim pregnancyval As Integer = 500D
    Dim hbsagval As Integer = 500
    Dim fbsval As Integer = 500
    Dim lipidval As Integer = 500
#End Region
    Private Sub labrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        For a As Integer = 1 To 99 Step 1
            agetxt.Items.Add(a)
        Next
        For i As Integer = 1 To 12 Step 1
            monthcombobox.Items.Add(i)
        Next
        Dim year As Integer = Date.Now.Year
        Dim finalyear As Integer = Date.Now.Year
        finalyear = year - 90
        For i As Integer = year To finalyear Step -1
            yeartxt.Items.Add(i)
        Next
    End Sub

    Private Sub sendbtn_Click(sender As Object, e As EventArgs) Handles sendbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim totalamount As Integer = 0
        Dim labrequest As String = ""
        Dim cardiorequest As String = ""
        Dim ultrasoundrequest As String = ""
        Dim birthday As String = monthcombobox.Text + "/" + datetxt.Text + "/" + yeartxt.Text
        Dim status = "Not Finished"
        If (lablist.CheckedItems.Count > 0) Or (cardiolist.CheckedItems.Count > 0) Or (ultrasoundlist.CheckedItems.Count > 0) Then
            For i As Integer = 0 To lablist.CheckedItems.Count - 1
                labrequest += lablist.CheckedItems(i) + " "
            Next
            For i As Integer = 0 To cardiolist.CheckedItems.Count - 1
                cardiorequest += cardiolist.CheckedItems(i) + " "
            Next
            For i As Integer = 0 To ultrasoundlist.CheckedItems.Count - 1
                ultrasoundrequest += ultrasoundlist.CheckedItems(i) + " "
            Next
            Try
                connection.Open()
                Dim query = "INSERT INTO labrequest_table (lab_patient_name,lab_age,lab_gender,lab_birthday,lab_address,lab_contact,lab_laboratory_request,lab_ultrasound_request,lab_cardio_request,doctor_request,lab_status) VALUES('" + patienttxt.Text + "','" + agetxt.Text + "','" + gendertxt.Text + "','" + birthday + "','" + addresstxt.Text + "','" + contacttxt.Text + "','" + labrequest + "','" + ultrasoundrequest + "','" + cardiorequest + "','" + doctornametxt.Text + "','" + status + "')"
                Dim command As New MySqlCommand
                command = New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
                MsgBox("Issue Request Successful")
                connection.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex)
            Finally
                connection.Dispose()
            End Try
        Else
            MsgBox("Please Choose First !")
        End If
    End Sub


    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub

    Private Sub monthcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monthcombobox.SelectedIndexChanged
        Dim x, y, z, leapyear As Integer
        If yeartxt.Text = "" Then
            MsgBox("Please choose Years first to know if its LEAP YEAR")
            monthcombobox.Refresh()
            monthcombobox.Text = ""
        ElseIf monthcombobox.Text = "2" Then
            leapyear = yeartxt.Text
            x = leapyear Mod 4
            y = leapyear Mod 100
            z = leapyear Mod 400
            If ((x = 0 And Not (y = 0)) Or z = 0) Then
                datetxt.Items.Clear()
                For i As Integer = 1 To 29 Step 1
                    datetxt.Items.Add(i)
                Next
            Else
                datetxt.Items.Clear()
                For i As Integer = 1 To 28 Step 1
                    datetxt.Items.Add(i)
                Next
            End If
        ElseIf monthcombobox.Text = "1" Or monthcombobox.Text = "3" Or monthcombobox.Text = "5" Or monthcombobox.Text = "7" Or monthcombobox.Text = "8" Or monthcombobox.Text = "10" Or monthcombobox.Text = "12" Then
            datetxt.Items.Clear()
            For i As Integer = 1 To 31 Step 1
                datetxt.Items.Add(i)
            Next
        Else
            datetxt.Items.Clear()
            For i As Integer = 1 To 30 Step 1
                datetxt.Items.Add(i)
            Next
        End If
    End Sub

    Private Sub ultraradio_CheckedChanged(sender As Object, e As EventArgs) Handles ultraradio.CheckedChanged
        cardiolist.Enabled = False
        ultrasoundlist.Enabled = True
        lablist.Enabled = False
    End Sub

    Private Sub cardioradio_CheckedChanged(sender As Object, e As EventArgs) Handles cardioradio.CheckedChanged
        ultrasoundlist.Enabled = False
        cardiolist.Enabled = True
        lablist.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lablist.Enabled = True
        ultrasoundlist.Enabled = False
        cardiolist.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
