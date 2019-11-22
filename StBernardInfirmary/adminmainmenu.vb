Public Class adminmainmenu
    Private Sub registrationbtn_Click(sender As Object, e As EventArgs) 
        Me.Close()
        registrationnurse.Show()
    End Sub

    Private Sub adminmainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub labrequest_Click(sender As Object, e As EventArgs) 
        Me.Close()
        labrequestform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        records.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Me.Close()
        labrequestform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        adminqueue.Close()
        Login.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class