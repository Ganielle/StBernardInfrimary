Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Login

#Region "Declares"
    Dim MysqlConn As New MySqlConnection
#End Region

    Private Sub BTLogin_Click(ByVal sender As Object, e As EventArgs) Handles BTLogin.Click
        MysqlConn.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        queue.Show()
        Try
            MysqlConn.Open()
            Dim username As String = TxtUsername.Text
            Dim passwordhash As String = SHA256(TxtPassword.Text)
            Dim query As String
            query = "SELECT user_level FROM user_table WHERE user_username='" & username & "' AND user_password='" & passwordhash & "'"
            Dim fname As String = "SELECT user_fname FROM user_table WHERE user_username='" & username & "' AND user_password='" & passwordhash & "'"
            Dim lname As String = "SELECT user_lname FROM user_table WHERE user_username='" & username & "' AND user_password='" & passwordhash & "'"
            Dim fnamecmd As New MySqlCommand(fname, MysqlConn)
            Dim lnamecmd As New MySqlCommand(lname, MysqlConn)
            Dim login As New MySqlCommand(query, MysqlConn)
            Dim finallogin As String = login.ExecuteScalar
            Dim fullname As String = fnamecmd.ExecuteScalar + " " + lnamecmd.ExecuteScalar
            If finallogin = "Super Admin" Then
                superadminmainmenu.fullnametxt.Text = fullname
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                superadminmainmenu.Show()
                Me.Hide()
            ElseIf finallogin = "Doctor" Then
                labrequestform.doctornametxt.Text = fullname
                adminmainmenu.fullnametxt.Text = fullname
                records.doctortxt.Text = fullname
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                adminmainmenu.Show()
                adminqueue.Show()
                Me.Hide()
            ElseIf finallogin = "Medical  Technology" Then
                medtechmainmenu.fullnametxt.Text = fullname
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                medtechmainmenu.Show()
                Me.Hide()
            ElseIf finallogin = "Nurse" Then
                nursemainmenu.fullnametxt.Text = fullname
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                nursemainmenu.Show()
                nursequeue.Show()
                Me.Hide()
            ElseIf finallogin = "Cashier" Then
                cashier.Show()
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                Me.Hide()
            Else
                MsgBox("Enter correct username and password")
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        queue.Show()
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
