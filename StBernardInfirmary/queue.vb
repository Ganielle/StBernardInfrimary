Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class queue
#Region "Declares"
    Dim connection As New MySqlConnection
#End Region
    Private Sub nursequeue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateDGV()
    End Sub
    Private Sub UpdateDGV()
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none"
        Dim process As String = "SELECT queue_reference FROM queue_table ORDER BY qid ASC LIMIT 1"
        Dim queue1 As String = "SELECT queue_reference FROM queue_table WHERE queue_reference <> '" & processtxt.Text & "' ORDER BY qid LIMIT 4"
        Dim queue2 As String = "SELECT queue_reference FROM queue_table WHERE queue_reference <> '" & processtxt.Text & "' AND queue_reference <> '" & q1.Text & "' ORDER BY qid LIMIT 4"
        Dim queue3 As String = "SELECT queue_reference FROM queue_table WHERE queue_reference <> '" & processtxt.Text & "' AND queue_reference <> '" & q2.Text & "' AND queue_reference <> '" & q1.Text & "' ORDER BY qid LIMIT 4"
        Dim queue4 As String = "SELECT queue_reference FROM queue_table WHERE queue_reference <> '" & processtxt.Text & "' AND queue_reference <> '" & q3.Text & "' AND queue_reference <> '" & q2.Text & "' AND queue_reference <> '" & q1.Text & "' ORDER BY qid LIMIT 4"
        Dim processcmd As New MySqlCommand()
        Dim queue1cmd As New MySqlCommand
        Dim queue2cmd As New MySqlCommand
        Dim queue3cmd As New MySqlCommand
        Dim queue4cmd As New MySqlCommand
        Try
            connection.Open()
            processcmd = New MySqlCommand(process, connection)
            queue1cmd = New MySqlCommand(queue1, connection)
            queue2cmd = New MySqlCommand(queue2, connection)
            queue3cmd = New MySqlCommand(queue3, connection)
            queue4cmd = New MySqlCommand(queue4, connection)
            processtxt.Text = processcmd.ExecuteScalar
            q1.Text = queue1cmd.ExecuteScalar
            q2.Text = queue2cmd.ExecuteScalar
            q3.Text = queue3cmd.ExecuteScalar
            q4.Text = queue4cmd.ExecuteScalar
            connection.Close()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class