Public Class urinalysisprintpreview
    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        printbtn.Hide()
        caneclbtn.Hide()
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        Me.Close()
    End Sub

    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
        urinalysis.Show()
    End Sub
End Class