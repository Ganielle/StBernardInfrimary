Public Class superadminmainmenu
    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles registrationbtn.Click
        Me.Hide()
        registration.Show()
    End Sub

    Private Sub usermanagementbtn_Click(sender As Object, e As EventArgs) Handles usermanagementbtn.Click
        Me.Hide()
        usermanagementsuperadmin.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class