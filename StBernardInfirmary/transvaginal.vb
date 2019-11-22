Public Class transvaginal
    Private Sub transvaginal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateTime.Now()
    End Sub

    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        transvaginalprintpreview.fullnametxt.Text = fullnametxt.Text
        transvaginalprintpreview.agetxt.Text = agetxt.Text
        transvaginalprintpreview.gendertxt.Text = gendertxt.Text
        transvaginalprintpreview.datetxt.Text = datetxt.Text
        If res1.Text = "" Then
            transvaginalprintpreview.res1.Text = "---"
        Else
            transvaginalprintpreview.res1.Text = res1.Text
        End If
        If res2.Text = "" Then
            transvaginalprintpreview.res2.Text = "---"
        Else
            transvaginalprintpreview.res2.Text = res2.Text
        End If
        If res3.Text = "" Then
            transvaginalprintpreview.res3.Text = "---"
        Else
            transvaginalprintpreview.res3.Text = res3.Text
        End If
        If res4.Text = "" Then
            transvaginalprintpreview.res4.Text = "---"
        Else
            transvaginalprintpreview.res4.Text = res4.Text
        End If
        If res5.Text = "" Then
            transvaginalprintpreview.res5.Text = "---"
        Else
            transvaginalprintpreview.res5.Text = res5.Text
        End If
        If res6.Text = "" Then
            transvaginalprintpreview.res6.Text = "---"
        Else
            transvaginalprintpreview.res6.Text = res6.Text
        End If

        If res7.Text = "" Then
            transvaginalprintpreview.res7.Text = "---"
        Else
            transvaginalprintpreview.res7.Text = res7.Text
        End If
        Me.Hide()
        transvaginalprintpreview.Show()
    End Sub

    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
    End Sub
End Class