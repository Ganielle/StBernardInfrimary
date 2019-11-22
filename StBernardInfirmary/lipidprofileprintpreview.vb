Public Class lipidprofileprintpreview
    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        printbtn.Hide()
        cancelbtn.Hide()
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        Me.Close()
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
        lipidprofile.Show()
    End Sub
End Class