Public Class urinalysis
    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        urinalysisprintpreview.fullnametxt.Text = fullnametxt.Text
        urinalysisprintpreview.agetxt.Text = agetxt.Text
        urinalysisprintpreview.gendertxt.Text = gendertxt.Text
        urinalysisprintpreview.datetxt.Text = datetxt.Text
        urinalysisprintpreview.res1.Text = res1.Text
        urinalysisprintpreview.res2.Text = res2.Text
        urinalysisprintpreview.res3.Text = res3.Text
        urinalysisprintpreview.res4.Text = res4.Text
        urinalysisprintpreview.res5.Text = res5.Text
        urinalysisprintpreview.res6.Text = res6.Text
        urinalysisprintpreview.res7.Text = res7.Text
        urinalysisprintpreview.res8.Text = res8.Text
        urinalysisprintpreview.res9.Text = res9.Text
        urinalysisprintpreview.res10.Text = res10.Text
        urinalysisprintpreview.res11.Text = res11.Text
        urinalysisprintpreview.res12.Text = res12.Text
        urinalysisprintpreview.res13.Text = res13.Text
        urinalysisprintpreview.res14.Text = res14.Text
        urinalysisprintpreview.res15.Text = res15.Text
        urinalysisprintpreview.res16.Text = res16.Text
        urinalysisprintpreview.res17.Text = res17.Text
        urinalysisprintpreview.res18.Text = res18.Text
        urinalysisprintpreview.res19.Text = res19.Text
        urinalysisprintpreview.res20.Text = res20.Text
        urinalysisprintpreview.res21.Text = res21.Text
        Me.Hide()
        urinalysisprintpreview.Show()


    End Sub

    Private Sub urinalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateTime.Now()
    End Sub

    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
    End Sub
End Class