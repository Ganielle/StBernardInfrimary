Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class getlabrequest
#Region "Declares"
    Dim connection As New MySqlConnection
#End Region
    Private Sub cbcbtn_Click(sender As Object, e As EventArgs) Handles cbcbtn.Click
        cbcprintpreview.fullnametxt.Text = doctortxt.Text
        cbc.Show()
        cbc.fullnametxt.Text = fullnametxt.Text
        cbc.agetxt.Text = agetxt.Text
        cbc.gendertxt.Text = gendertxt.Text
        urinalysis.fullnametxt.Text = fullnametxt.Text
        urinalysis.agetxt.Text = agetxt.Text
        urinalysis.gendertxt.Text = gendertxt.Text
        cbctxt.Text = ""
        If cbctxt.Text = "" Then
            cbcbtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub urinalysisbtn_Click(sender As Object, e As EventArgs) Handles urinalysisbtn.Click
        urinalysisprintpreview.doctortxt.Text = doctortxt.Text
        urinalysis.Show()
        urinalysis.fullnametxt.Text = fullnametxt.Text
        urinalysis.agetxt.Text = agetxt.Text
        urinalysis.gendertxt.Text = gendertxt.Text
        urinalysistxt.Text = ""
        If urinalysistxt.Text = "" Then
            urinalysisbtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub fecalysisbtn_Click(sender As Object, e As EventArgs) Handles fecalysisbtn.Click
        fecalysisprintpreview.doctortxt.Text = doctortxt.Text
        fecalysis.Show()
        fecalysis.fullnametxt.Text = fullnametxt.Text
        fecalysis.agetxt.Text = agetxt.Text
        fecalysis.gendertxt.Text = gendertxt.Text
        fecalysistxt.Text = ""
        If fecalysistxt.Text = "" Then
            fecalysisbtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub hbsagbtn_Click(sender As Object, e As EventArgs) Handles hbsagbtn.Click
        hbsagprintpreview.doctortxt.Text = doctortxt.Text
        hbsag.Show()
        hbsag.fullnametxt.Text = fullnametxt.Text
        hbsag.agetxt.Text = agetxt.Text
        hbsag.gendertxt.Text = gendertxt.Text
        hbsagtxt.Text = ""
        If hbsagtxt.Text = "" Then
            hbsagbtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub lipidprofilebtn_Click(sender As Object, e As EventArgs) Handles lipidprofilebtn.Click
        lipidprofileprintpreview.doctortxt.Text = doctortxt.Text
        lipidprofile.Show()
        lipidprofile.fullnametxt.Text = fullnametxt.Text
        lipidprofile.agetxt.Text = agetxt.Text
        lipidprofile.gendertxt.Text = gendertxt.Text
        lipidprofiletxt.Text = ""
        If lipidprofiletxt.Text = "" Then
            lipidprofilebtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub finishbtn_Click(sender As Object, e As EventArgs) Handles finishbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query As String = "UPDATE labrequest_table SET lab_status='" & "Finished" & "' WHERE labid ='" & labidtxt.Text & "'"
        Dim cmd As New MySqlCommand()
        If fullnametxt.Text = "" Then
            MsgBox("Please Select form the data view and finished the task!")
        Else
            Dim notfinished = "Not Finished"
            Dim queryget As String = "SELECT * FROM labrequest_table WHERE lab_status = '" & notfinished & "' ORDER BY labid ASC"
            Dim getcmd As New MySqlCommand()
            Dim dataadapter As New MySqlDataAdapter
            Dim source As New BindingSource
            Dim datatable As New DataTable
            Try
                connection.Open()
                getcmd = New MySqlCommand(queryget, connection)
                cmd = New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()
                dataadapter.SelectCommand = getcmd
                dataadapter.Fill(datatable)
                source.DataSource = datatable
                labview.DataSource = source
                dataadapter.Update(datatable)
                MsgBox("Successfully Finished")
                finishbtn.Enabled = False
                connection.Close()
            Catch ex As Exception
                MsgBox(ex)
            Finally
                connection.Close()
            End Try
        End If

    End Sub

    Private Sub treebtn_Click(sender As Object, e As EventArgs) Handles treebtn.Click
        hepatobiliarytreeprintpreview.doctortxt.Text = doctortxt.Text
        hepatobiliarytree.fullnametxt.Text = fullnametxt.Text
        hepatobiliarytree.agetxt.Text = agetxt.Text
        hepatobiliarytree.gendertxt.Text = gendertxt.Text
        hepatobiliarytree.Show()
        treetxt.Text = ""
        If treetxt.Text = "" Then
            treebtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub vaginalbtn_Click(sender As Object, e As EventArgs) Handles vaginalbtn.Click
        transvaginalprintpreview.doctortxt.Text = doctortxt.Text
        transvaginal.fullnametxt.Text = fullnametxt.Text
        transvaginal.agetxt.Text = agetxt.Text
        transvaginal.gendertxt.Text = gendertxt.Text
        transvaginal.Show()
        vaginaltxt.Text = ""
        If vaginaltxt.Text = "" Then
            vaginalbtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub carbtn_Click(sender As Object, e As EventArgs) Handles carbtn.Click
        electrocardiographicreportprintpreview.doctor.Text = doctortxt.Text
        electrocardiographicreport.fullnametxt.Text = fullnametxt.Text
        electrocardiographicreport.agetxt.Text = agetxt.Text
        electrocardiographicreport.gendertxt.Text = gendertxt.Text
        cardtxt.Text = ""
        electrocardiographicreport.Show()
        If cardtxt.Text = "" Then
            carbtn.Enabled = False
        End If
        If cbctxt.Text = "" And urinalysistxt.Text = "" And fecalysistxt.Text = "" And hbsagtxt.Text = "" And lipidprofiletxt.Text = "" And treetxt.Text = "" And vaginaltxt.Text = "" And cardtxt.Text = "" Then
            finishbtn.Enabled = True
        Else
            finishbtn.Enabled = False
        End If
    End Sub

    Private Sub labview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles labview.CellClick
        labidtxt.Text = ""
        fullnametxt.Text = ""
        gendertxt.Text = ""
        agetxt.Text = ""
        doctortxt.Text = ""
        cbctxt.Text = ""
        urinalysistxt.Text = ""
        fecalysistxt.Text = ""
        hbsagtxt.Text = ""
        lipidprofiletxt.Text = ""
        treetxt.Text = ""
        vaginaltxt.Text = ""
        cardtxt.Text = ""
        labidtxt.Text = labview.Rows(e.RowIndex).Cells(0).Value.ToString
        fullnametxt.Text = labview.Rows(e.RowIndex).Cells(1).Value.ToString
        gendertxt.Text = labview.Rows(e.RowIndex).Cells(3).Value.ToString
        agetxt.Text = labview.Rows(e.RowIndex).Cells(2).Value.ToString
        doctortxt.Text = labview.Rows(e.RowIndex).Cells(10).Value.ToString
        Dim s As String = labview.Rows(e.RowIndex).Cells(7).Value.ToString
        Dim words As String() = s.Split(New Char() {" "c})
        Dim word As String
        For Each word In words
            If word = "CBC" Then
                cbctxt.Text = "CHECK"
            End If
            If word = "URINALYSIS" Then
                urinalysistxt.Text = "CHECK"
            End If
            If word = "FECALYSIS" Then
                fecalysistxt.Text = "CHECK"
            End If
            If word = "HBSAG" Then
                hbsagtxt.Text = "CHECK"
            End If
            If word = "LIPID_PROFILE" Then
                lipidprofiletxt.Text = "CHECK"
            End If
        Next
        If cbctxt.Text = "CHECK" Then
            cbcbtn.Enabled = True
        Else
            cbcbtn.Enabled = False
        End If
        If urinalysistxt.Text = "CHECK" Then
            urinalysisbtn.Enabled = True
        Else
            urinalysisbtn.Enabled = False
        End If
        If fecalysistxt.Text = "CHECK" Then
            fecalysisbtn.Enabled = True
        Else
            fecalysisbtn.Enabled = False
        End If
        If hbsagtxt.Text = "CHECK" Then
            hbsagbtn.Enabled = True
        Else
            hbsagbtn.Enabled = False
        End If
        If lipidprofiletxt.Text = "CHECK" Then
            lipidprofilebtn.Enabled = True
        Else
            lipidprofilebtn.Enabled = False
        End If
        Dim ultrasound As String = labview.Rows(e.RowIndex).Cells(8).Value.ToString
        Dim ultraword As String() = ultrasound.Split(New Char() {" "c})
        Dim finalultra As String
        For Each finalultra In ultraword
            If finalultra = "HEPATOBILIARY_TREE" Then
                treetxt.Text = "CHECK"
            End If
            If finalultra = "TRANSVAGINAL" Then
                vaginaltxt.Text = "CHECK"
            End If
        Next
        If treetxt.Text = "CHECK" Then
            treebtn.Enabled = True
        Else
            treebtn.Enabled = False
        End If
        If vaginaltxt.Text = "CHECK" Then
            vaginalbtn.Enabled = True
        Else
            vaginalbtn.Enabled = False
        End If
        Dim cardio As String = labview.Rows(e.RowIndex).Cells(9).Value.ToString
        Dim cardioword As String() = cardio.Split(New Char() {" "c})
        Dim finalcardio As String
        For Each finalcardio In cardioword
            If finalcardio = "ECG" Then
                cardtxt.Text = "CHECK"
            End If
        Next
        If cardtxt.Text = "CHECK" Then
            carbtn.Enabled = True
        Else
            carbtn.Enabled = False
        End If
    End Sub

    Private Sub getlabrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim notfinished = "Not Finished"
        Dim querydelete As String = "SELECT * FROM labrequest_table WHERE lab_status = '" & notfinished & "' ORDER BY labid ASC"
        Dim getcmd As New MySqlCommand()
            Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Try
            connection.Open()
            getcmd = New MySqlCommand(querydelete, connection)
            getcmd.ExecuteNonQuery()
            dataadapter.SelectCommand = getcmd
            dataadapter.Fill(datatable)
            source.DataSource = datatable
            labview.DataSource = source
            dataadapter.Update(datatable)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim notfinished = "Not Finished"
        Dim querydelete As String = "SELECT * FROM labrequest_table WHERE lab_status = '" & notfinished & "' ORDER BY labid ASC"
        Dim getcmd As New MySqlCommand()
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Try
            connection.Open()
            getcmd = New MySqlCommand(querydelete, connection)
            getcmd.ExecuteNonQuery()
            dataadapter.SelectCommand = getcmd
            dataadapter.Fill(datatable)
            source.DataSource = datatable
            labview.DataSource = source
            dataadapter.Update(datatable)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        medtechmainmenu.Show()
    End Sub
End Class