Public Class hepatobiliarytree
    Private Sub caneclbtn_Click(sender As Object, e As EventArgs) Handles caneclbtn.Click
        Me.Close()
    End Sub

    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        hepatobiliarytreeprintpreview.fullnametxt.Text = fullnametxt.Text
        hepatobiliarytreeprintpreview.agetxt.Text = agetxt.Text
        hepatobiliarytreeprintpreview.gendertxt.Text = gendertxt.Text
        hepatobiliarytreeprintpreview.datetxt.Text = datetxt.Text
        If res1.Text = "" Then
            hepatobiliarytreeprintpreview.res1.Text = "---"
        Else
            hepatobiliarytreeprintpreview.res1.Text = res1.Text
        End If
        If res2.Text = "" Then
            hepatobiliarytreeprintpreview.res2.Text = "---"
        Else
            hepatobiliarytreeprintpreview.res2.Text = res2.Text
        End If
        If res3.Text = "" Then
            hepatobiliarytreeprintpreview.res3.Text = "---"
        Else
            hepatobiliarytreeprintpreview.res3.Text = res3.Text
        End If
        If res4.Text = "" Then
            hepatobiliarytreeprintpreview.res4.Text = "---"
        Else
            hepatobiliarytreeprintpreview.res4.Text = res4.Text
        End If
        If res5.Text = "" Then
            hepatobiliarytreeprintpreview.res5.Text = "---"
        Else
            hepatobiliarytreeprintpreview.res5.Text = res5.Text
        End If
        hepatobiliarytreeprintpreview.Show()
        Me.Hide()
    End Sub

    Private Sub hepatobiliarytree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateTime.Now()
    End Sub
End Class