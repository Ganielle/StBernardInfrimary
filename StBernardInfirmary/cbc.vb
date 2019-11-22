Public Class cbc
    Private WithEvents pd As New Printing.PrintDocument
    Private ppd As PrintPreviewDialog
    Public Property fname As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        cbcprintpreview.namelbl.Text = fullnametxt.Text
        cbcprintpreview.agelbl.Text = agetxt.Text
        cbcprintpreview.gendelbl.Text = gendertxt.Text
        cbcprintpreview.datelbl.Text = datetxt.Text
        cbcprintpreview.res1.Text = res1.Text + " g/L"
        cbcprintpreview.res2.Text = res2.Text + " vol%"
        cbcprintpreview.res3.Text = res3.Text + "x10^2/L"
        cbcprintpreview.res4.Text = res4.Text + "x10^9/L "
        cbcprintpreview.res5.Text = res5.Text + "x10^9/L"
        cbcprintpreview.res6.Text = res6.Text
        cbcprintpreview.res7.Text = res7.Text
        cbcprintpreview.res8.Text = res8.Text
        cbcprintpreview.res9.Text = res9.Text
        cbcprintpreview.res10.Text = res10.Text
        cbcprintpreview.res11.Text = res11.Text
        cbcprintpreview.res12.Text = res12.Text
        cbcprintpreview.res14.Text = res14.Text
        cbcprintpreview.res14.Text = res14.Text
        cbcprintpreview.res15.Text = res15.Text + " min"
        cbcprintpreview.res16.Text = res16.Text
        cbcprintpreview.res17.text = res17.Text
        cbcprintpreview.res18.Text = res18.Text
        cbcprintpreview.res19.Text = res19.Text
        cbcprintpreview.Show()
        Me.Hide()
    End Sub
    Private Sub cbc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateTime.Now()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class