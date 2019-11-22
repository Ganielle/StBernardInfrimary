Public Class cbcprintpreview
    Private WithEvents pd As New Printing.PrintDocument
    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        printbtn.Hide()
        caneclbtn.Hide()
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
        cbc.Show()
    End Sub

    Private Sub cbcprintpreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newMargins As System.Drawing.Printing.Margins
        newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.pd.DefaultPageSettings.Margins = newMargins
    End Sub
End Class