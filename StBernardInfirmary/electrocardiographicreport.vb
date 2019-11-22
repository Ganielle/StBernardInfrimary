Public Class electrocardiographicreport
    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        electrocardiographicreportprintpreview.fullnametxt.Text = fullnametxt.Text
        electrocardiographicreportprintpreview.agetxt.Text = agetxt.Text
        electrocardiographicreportprintpreview.gendertxt.Text = gendertxt.Text
        electrocardiographicreportprintpreview.datetxt.Text = datetxt.Text
        If res1.Text = "" Then
            electrocardiographicreportprintpreview.res1.Text = "---"
        Else
            electrocardiographicreportprintpreview.res1.Text = res1.Text
        End If
        If res2.Text = "" Then
            electrocardiographicreportprintpreview.res2.Text = "---"
        Else
            electrocardiographicreportprintpreview.res2.Text = res2.Text
        End If
        If res3.Text = "" Then
            electrocardiographicreportprintpreview.res3.Text = "---"
        Else
            electrocardiographicreportprintpreview.res3.Text = res3.Text
        End If
        If res4.Text = "" Then
            electrocardiographicreportprintpreview.res4.Text = "---"
        Else
            electrocardiographicreportprintpreview.res4.Text = res4.Text
        End If
        If res5.Text = "" Then
            electrocardiographicreportprintpreview.res5.Text = "---"
        Else
            electrocardiographicreportprintpreview.res5.Text = res5.Text
        End If
        If res6.Text = "" Then
            electrocardiographicreportprintpreview.res6.Text = "---"
        Else
            electrocardiographicreportprintpreview.res6.Text = res6.Text
        End If
        If res7.Text = "" Then
            electrocardiographicreportprintpreview.res7.Text = "---"
        Else
            electrocardiographicreportprintpreview.res7.Text = res7.Text
        End If
        If res8.Text = "" Then
            electrocardiographicreportprintpreview.res8.Text = "---"
        Else
            electrocardiographicreportprintpreview.res8.Text = res8.Text
        End If
        If res9.Text = "" Then
            electrocardiographicreportprintpreview.res9.Text = "---"
        Else
            electrocardiographicreportprintpreview.res9.Text = res9.Text
        End If
        electrocardiographicreportprintpreview.Show()
        Me.Hide()

    End Sub

    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()

    End Sub
End Class