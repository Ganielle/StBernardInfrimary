Public Class hbsag
    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        hbsagprintpreview.fullnametxt.Text = fullnametxt.Text
        hbsagprintpreview.agetxt.Text = agetxt.Text
        hbsagprintpreview.gendertxt.Text = gendertxt.Text
        hbsagprintpreview.datetxt.Text = datetxt.Text
        If res1.Text = "" Then
            hbsagprintpreview.res1.Text = "---"
        Else
            hbsagprintpreview.res1.Text = res1.Text
        End If
        If res2.Text = "" Then
            hbsagprintpreview.res2.Text = "---"
        Else
            hbsagprintpreview.res2.Text = res2.Text
        End If
        hbsagprintpreview.Show()
        Me.Hide()
    End Sub

    Private Sub hbsag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateTime.Now()
    End Sub

    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
    End Sub
End Class