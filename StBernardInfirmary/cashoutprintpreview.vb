Public Class cashoutprintpreview
    Private Sub cashoutprintpreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateTime.Now()
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        printbtn.Hide()
        caneclbtn.Hide()
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        Me.Close()
    End Sub

    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
    End Sub
End Class