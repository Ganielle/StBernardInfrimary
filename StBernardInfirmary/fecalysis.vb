Public Class fecalysis
    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        fecalysisprintpreview.fullnametxt.Text = fullnametxt.Text
        fecalysisprintpreview.agetxt.Text = agetxt.Text
        fecalysisprintpreview.gendertxt.Text = gendertxt.Text
        fecalysisprintpreview.datetxt.Text = datetxt.Text
        If res1.Text = "" Then
            fecalysisprintpreview.res1.Text = "---"
        Else
            fecalysisprintpreview.res1.Text = res1.Text
        End If
        If res2.Text = "" Then
            fecalysisprintpreview.res2.Text = "---"
        Else
            fecalysisprintpreview.res2.Text = res2.Text
        End If
        If res3.Text = "" Then
            fecalysisprintpreview.res3.Text = "---"
        Else
            fecalysisprintpreview.res3.Text = res3.Text
        End If
        If res4.Text = "" Then
            fecalysisprintpreview.res4.Text = "---"
        Else
            fecalysisprintpreview.res4.Text = res4.Text
        End If
        If res5.Text = "" Then
            fecalysisprintpreview.res5.Text = "---"
        Else
            fecalysisprintpreview.res5.Text = res5.Text
        End If
        If res6.Text = "" Then
            fecalysisprintpreview.res6.Text = "---"
        Else
            fecalysisprintpreview.res6.Text = res6.Text
        End If

        If res7.Text = "" Then
            fecalysisprintpreview.res7.Text = "---"
        Else
            fecalysisprintpreview.res7.Text = res7.Text
        End If
        If res8.Text = "" Then
            fecalysisprintpreview.res8.Text = "---"
        Else
            fecalysisprintpreview.res8.Text = res8.Text
        End If
        If res9.Text = "" Then
            fecalysisprintpreview.res9.Text = "---"
        Else
            fecalysisprintpreview.res9.Text = res9.Text
        End If
        If res10.Text = "" Then
            fecalysisprintpreview.res10.Text = "---"
        Else
            fecalysisprintpreview.res10.Text = res10.Text
        End If
        fecalysisprintpreview.Show()
        Me.Hide()
    End Sub

    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
    End Sub

    Private Sub fecalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateTime.Now()
    End Sub
End Class