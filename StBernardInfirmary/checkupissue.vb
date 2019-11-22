Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Data.SqlClient
Public Class checkupissue
#Region "Declares"
    Dim connection As New MySqlConnection
    Dim transid As String
    Dim queueid As String
    Private WithEvents pd As New Printing.PrintDocument
    Private ppd As PrintPreviewDialog
#End Region
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        nursemainmenu.Show()
    End Sub

    Private Sub checkupissue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Me.CenterToScreen()
        Dim getfinalqueue As String = "SELECT queue_reference FROM queue_table ORDER BY qid DESC LIMIT 1"
        Dim gettingqueue As New MySqlCommand(getfinalqueue, connection)
        Try
            connection.Open()
            Dim final As String = gettingqueue.ExecuteScalar()
            If final = "" Then
                qtxt.Text = 1
            Else
                qtxt.Text = gettingqueue.ExecuteScalar() + 1
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub yesbtn_CheckedChanged(sender As Object, e As EventArgs) Handles yesbtn.CheckedChanged
        fnametxt.Enabled = True
        lnametxt.Enabled = True
        searchbtn.Enabled = True
        patientview.Enabled = True
        patienttxt.Enabled = False
    End Sub
    Private Sub nobtn_CheckedChanged(sender As Object, e As EventArgs) Handles nobtn.CheckedChanged
        fnametxt.Enabled = False
        lnametxt.Enabled = false
        searchbtn.Enabled = False
        patientview.Enabled = False
        fnametxt.Text = "First Name"
        lnametxt.Text = "Last Name"
    End Sub

    Private Sub sendbtn_Click(sender As Object, e As EventArgs) Handles sendbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim request As String = ""
        Dim dateAndTime As Date
        Dim normal As String = "Normal Checkup"
        Dim neww As String = "New Patient"
        Dim normaltotal As String = "500"
        Dim newprice As String = "1000"
        Dim statsfalse As String = "Not Paid"
        Dim datenow As String = DateTime.Now()
        Dim stats As String = "Not Finished"
        Dim dataadapter As New MySqlDataAdapter
        Dim ds As New DataSet
        dateAndTime = Now
        transid = Format(dateAndTime, "yyyyMMddHHmmss").ToString

        'If user Then did Not exist 
        'normal checkup
        If normalradio.Checked = True And nobtn.Checked = True And patienttxt.Text = "" Then
            Dim querynormal As String = "INSERT INTO cashier_table(trans_id, trans_date, trans_items, trans_price, trans_status) VALUES('" + transid + "','" + datenow + "','" + normal + "','" + normaltotal + "','" + statsfalse + "')"
            Dim querynew As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + neww + "','" + newprice + "','" + statsfalse + "')"
            Dim queue As String = "INSERT INTO queue_table(queue_reference,queue_fullname,queue_status) VALUES('" + qtxt.Text + "','" + patienttxt.Text + "','" + stats + "')"
            Dim getfinalqueue As String = "SELECT queue_reference FROM queue_table ORDER BY qid DESC LIMIT 1"
            Dim commandqueue As New MySqlCommand()
            Dim commandnormal As New MySqlCommand()
            Dim commandnew As New MySqlCommand()
            Dim gett As New MySqlCommand()
            Try
                connection.Open()
                ds.Clear()
                commandnormal = New MySqlCommand(querynormal, connection)
                commandqueue = New MySqlCommand(queue, connection)
                commandnew = New MySqlCommand(querynew, connection)
                gett = New MySqlCommand(getfinalqueue, connection)
                dataadapter = New MySqlDataAdapter(gett)
                commandnormal.ExecuteNonQuery()
                commandnew.ExecuteNonQuery()
                commandqueue.ExecuteNonQuery()
                dataadapter.Fill(ds, "queue_table")
                qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                queueid = ds.Tables(0).Rows(0).Item(0)
                MsgBox("Sent Issue Successfully!")
                registrationnurse.Show()
                ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                ppd.ShowDialog()
                connection.Close()
            Catch ex As Exception
                MsgBox("Error in System. Please try again later!")
            Finally
                connection.Dispose()
            End Try
            'laboratory checkup
        ElseIf labradio.Checked = True And nobtn.Checked = True And patienttxt.Text = "" Then
            Dim querynew As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + neww + "','" + newprice + "','" + statsfalse + "')"
            Dim queue As String = "INSERT INTO queue_table(queue_reference,queue_fullname,queue_status) VALUES('" + qtxt.Text + "','" + patienttxt.Text + "','" + stats + "')"
            Dim getfinalqueue As String = "SELECT queue_reference FROM queue_table ORDER BY qid DESC LIMIT 1"
            Dim gett As New MySqlCommand()
            Dim commandnew As New MySqlCommand()
            Dim commandqueue As New MySqlCommand()
            If lablist.CheckedItems.Count > 0 Then
                Try
                    connection.Open()
                    ds.Clear()
                    commandqueue = New MySqlCommand(queue, connection)
                    commandqueue.ExecuteNonQuery()
                    commandnew = New MySqlCommand(querynew, connection)
                    gett = New MySqlCommand(getfinalqueue, connection)
                    dataadapter = New MySqlDataAdapter(gett)
                    commandnew.ExecuteNonQuery()
                    dataadapter.Fill(ds, "queue_table")
                    qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                    queueid = ds.Tables(0).Rows(0).Item(0)
                    connection.Close()
                Catch ex As Exception
                    MsgBox("Error in System. Please try again later!")
                Finally
                    connection.Dispose()
                End Try
                Dim labprice As String = "90"
                For i As Integer = 0 To lablist.CheckedItems.Count - 1
                    Dim query As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + lablist.CheckedItems(i) + "','" + labprice + "','" + statsfalse + "')"
                    Dim command As New MySqlCommand()
                    Try
                        connection.Open()
                        command = New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        MsgBox("Error in System. Please try again later!")
                    Finally
                        connection.Dispose()
                    End Try
                Next
                registrationnurse.Show()
                MsgBox("Sent Issue Successfully!")
                ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                ppd.ShowDialog()
            Else
                MsgBox("Please choose types of laboratory!")
            End If

            'radiology checkup
        ElseIf radiologyradio.Checked = True And nobtn.Checked = True And patienttxt.Text = "" Then
            Dim querynew As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + neww + "','" + newprice + "','" + statsfalse + "')"
            Dim commandnew As New MySqlCommand()
            Dim queue As String = "INSERT INTO queue_table(queue_reference,queue_fullname,queue_status) VALUES('" + qtxt.Text + "','" + patienttxt.Text + "','" + stats + "')"
            Dim getfinalqueue As String = "SELECT queue_reference FROM queue_table ORDER BY qid DESC LIMIT 1"
            Dim gett As New MySqlCommand()
            Dim commandqueue As New MySqlCommand()
            If cardioradio.Checked = True Then
                If cardiolist.CheckedItems.Count > 0 Then
                    Try
                        connection.Open()

                        commandqueue = New MySqlCommand(queue, connection)
                        commandqueue.ExecuteNonQuery()
                        commandnew = New MySqlCommand(querynew, connection)
                        commandnew.ExecuteNonQuery()
                        gett = New MySqlCommand(getfinalqueue, connection)
                        dataadapter = New MySqlDataAdapter(gett)
                        dataadapter.Fill(ds, "queue_table")
                        qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                        queueid = ds.Tables(0).Rows(0).Item(0)
                        connection.Close()
                    Catch ex As Exception
                        MsgBox("Error in System. Please try again later!")
                    Finally
                        connection.Dispose()
                    End Try
                    Dim xrayprice As String = "350"
                    For i As Integer = 0 To cardiolist.CheckedItems.Count - 1
                        Dim query As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + cardiolist.CheckedItems(i) + "','" + xrayprice + "','" + statsfalse + "')"
                        Dim command As New MySqlCommand()
                        Try
                            connection.Open()
                            command = New MySqlCommand(query, connection)
                            command.ExecuteNonQuery()
                            connection.Close()
                        Catch ex As Exception
                            MsgBox("Error in System. Please try again later!")
                        Finally
                            connection.Dispose()
                        End Try
                    Next
                    registrationnurse.Show()
                    MsgBox("Sent Issue Successfully!")
                    ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                    ppd.ShowDialog()
                Else
                    MsgBox("Please choose xray type!")
                End If
            ElseIf ultraradio.Checked = True Then
                If ultrasoundlist.CheckedItems.Count > 0 Then
                    Try
                        connection.Open()
                        commandnew = New MySqlCommand(querynew, connection)
                        commandnew.ExecuteNonQuery()
                        gett = New MySqlCommand(getfinalqueue, connection)
                        dataadapter = New MySqlDataAdapter(gett)
                        dataadapter.Fill(ds, "queue_table")
                        qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                        queueid = ds.Tables(0).Rows(0).Item(0)
                        connection.Close()
                    Catch ex As Exception
                        MsgBox("Error in System. Please try again later!")
                    Finally
                        connection.Dispose()
                    End Try
                    Dim ultrasoundprice As String = "500"
                    For i As Integer = 0 To ultrasoundlist.CheckedItems.Count - 1
                        Dim query As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + ultrasoundlist.CheckedItems(i) + "','" + ultrasoundprice + "','" + statsfalse + "')"
                        Dim command As New MySqlCommand()
                        Try
                            connection.Open()
                            command = New MySqlCommand(query, connection)
                            command.ExecuteNonQuery()
                            connection.Close()
                        Catch ex As Exception
                            MsgBox("Error in System. Please try again later!")
                        Finally
                            connection.Dispose()
                        End Try
                    Next
                    registrationnurse.Show()
                    MsgBox("Sent Issue Successfully!")
                    ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                    ppd.ShowDialog()
                Else
                    MsgBox("Please choose ultrasound type !")
                End If
            Else
                MsgBox("Please choose Radiology request!")
            End If
            'if user exist 
            'normal checkup
        ElseIf normalradio.Checked = True And yesbtn.Checked = True And patienttxt.Text <> "" Then
            Dim querynormal As String = "INSERT INTO cashier_table(trans_id, trans_date, trans_items, trans_price, trans_status) VALUES('" + transid + "','" + datenow + "','" + normal + "','" + normaltotal + "','" + statsfalse + "')"
            Dim queue As String = "INSERT INTO queue_table(queue_reference,queue_fullname,queue_status) VALUES('" + qtxt.Text + "','" + patienttxt.Text + "','" + stats + "')"
            Dim getfinalqueue As String = "SELECT queue_reference FROM queue_table ORDER BY qid DESC LIMIT 1"
            Dim gett As New MySqlCommand()
            Dim commandqueue As New MySqlCommand()
            Dim commandcashier As New MySqlCommand()
            Try
                connection.Open()
                commandqueue = New MySqlCommand(queue, connection)
                commandcashier = New MySqlCommand(querynormal, connection)
                commandqueue.ExecuteNonQuery()
                commandcashier.ExecuteNonQuery()
                gett = New MySqlCommand(getfinalqueue, connection)
                dataadapter = New MySqlDataAdapter(gett)
                dataadapter.Fill(ds, "queue_table")
                qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                queueid = ds.Tables(0).Rows(0).Item(0)
                MsgBox("Sent Issue Successfully!")
                ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                ppd.ShowDialog()
                connection.Close()
            Catch ex As Exception
                MsgBox("Error in System. Please try again later!")
            Finally
                connection.Dispose()
            End Try

            'laboratory checkup
        ElseIf labradio.Checked = True And yesbtn.Checked = True And patienttxt.Text <> "" Then
            Dim queue As String = "INSERT INTO queue_table(queue_reference,queue_fullname,queue_status) VALUES('" + qtxt.Text + "','" + patienttxt.Text + "','" + stats + "')"
            Dim getfinalqueue As String = "SELECT queue_reference FROM queue_table ORDER BY qid DESC LIMIT 1"
            Dim gett As New MySqlCommand()
            If lablist.CheckedItems.Count > 0 Then

                Dim labprice As String = "90"
                Dim commandqueue As New MySqlCommand()
                Try
                    connection.Open()
                    commandqueue = New MySqlCommand(queue, connection)
                    commandqueue.ExecuteNonQuery()
                    gett = New MySqlCommand(getfinalqueue, connection)
                    dataadapter = New MySqlDataAdapter(gett)
                    dataadapter.Fill(ds, "queue_table")
                    qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                    queueid = ds.Tables(0).Rows(0).Item(0)
                    connection.Close()
                Catch ex As Exception
                    MsgBox("Error in System. Please try again later!")
                Finally
                    connection.Dispose()
                End Try
                For i As Integer = 0 To lablist.CheckedItems.Count - 1
                    Dim query As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + lablist.CheckedItems(i) + "','" + labprice + "','" + statsfalse + "')"
                    Dim command As New MySqlCommand()
                    Try
                        connection.Open()
                        command = New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        MsgBox("Error in System. Please try again later!")
                    Finally
                        connection.Dispose()
                    End Try
                Next
                MsgBox("Sent Issue Successfully!")
                ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                ppd.ShowDialog()
            Else
                MsgBox("Please choose types of laboratory!")
            End If

            'radiology checkup
        ElseIf radiologyradio.Checked = True And yesbtn.Checked = True And patienttxt.Text <> "" Then
            Dim queue As String = "INSERT INTO queue_table(queue_reference,queue_fullname,queue_status) VALUES('" + qtxt.Text + "','" + patienttxt.Text + "','" + stats + "')"
            Dim getfinalqueue As String = "SELECT queue_reference FROM queue_table ORDER BY qid DESC LIMIT 1"
            Dim gett As New MySqlCommand()
            If cardioradio.Checked = True Then
                If cardiolist.CheckedItems.Count > 0 Then
                    Dim commandqueue As New MySqlCommand()
                    Try
                        connection.Open()
                        commandqueue = New MySqlCommand(queue, connection)
                        commandqueue.ExecuteNonQuery()
                        gett = New MySqlCommand(getfinalqueue, connection)
                        dataadapter = New MySqlDataAdapter(gett)
                        dataadapter.Fill(ds, "queue_table")
                        qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                        queueid = ds.Tables(0).Rows(0).Item(0)
                        connection.Close()
                    Catch ex As Exception
                        MsgBox("Error in System. Please try again later!")
                    Finally
                        connection.Dispose()
                    End Try
                    Dim xrayprice As String = "350"
                    For i As Integer = 0 To cardiolist.CheckedItems.Count - 1
                        Dim query As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + cardiolist.CheckedItems(i) + "','" + xrayprice + "','" + statsfalse + "')"
                        Dim command As New MySqlCommand()
                        Try
                            connection.Open()
                            command = New MySqlCommand(query, connection)
                            command.ExecuteNonQuery()
                            connection.Close()
                        Catch ex As Exception
                            MsgBox("Error in System. Please try again later!")
                        Finally
                            connection.Dispose()
                        End Try
                    Next
                    MsgBox("Sent Issue Successfully!")
                    ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                    ppd.ShowDialog()
                Else
                    MsgBox("Please choose xray type!")
                End If
            ElseIf ultraradio.Checked = True Then
                If ultrasoundlist.CheckedItems.Count > 0 Then
                    Dim commandqueue As New MySqlCommand()
                    Try
                        connection.Open()
                        commandqueue = New MySqlCommand(queue, connection)
                        commandqueue.ExecuteNonQuery()
                        gett = New MySqlCommand(getfinalqueue, connection)
                        dataadapter = New MySqlDataAdapter(gett)
                        dataadapter.Fill(ds, "queue_table")
                        qtxt.Text = ds.Tables(0).Rows(0).Item(0) + 1
                        queueid = ds.Tables(0).Rows(0).Item(0)
                        connection.Close()
                    Catch ex As Exception
                        MsgBox("Error in System. Please try again later!")
                    Finally
                        connection.Dispose()
                    End Try
                    Dim ultrasoundprice As String = "500"
                    For i As Integer = 0 To ultrasoundlist.CheckedItems.Count - 1
                        Dim query As String = "INSERT INTO cashier_table(trans_id,trans_date,trans_items,trans_price,trans_status) VALUES('" + transid + "','" + datenow + "','" + ultrasoundlist.CheckedItems(i) + "','" + ultrasoundprice + "','" + statsfalse + "')"
                        Dim command As New MySqlCommand()
                        Try
                            connection.Open()
                            command = New MySqlCommand(query, connection)
                            command.ExecuteNonQuery()
                            connection.Close()
                        Catch ex As Exception
                            MsgBox("Error in System. Please try again later!")
                        Finally
                            connection.Dispose()
                        End Try
                    Next
                    MsgBox("Sent Issue Successfully!")
                    ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
                    ppd.ShowDialog()
                Else
                    MsgBox("Please choose ultrasound type !")
                End If
            Else
                MsgBox("Please choose Radiology request!")
            End If
        Else
            MsgBox("Please enter patient's full name first!")
        End If


    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        connection.ConnectionString = "server=localhost; userid= root; password= ; database= stbernard_database; Character Set = utf8; SslMode=none;"
        Dim query As String
        query = "SELECT register_fname,register_mname,register_lname FROM registration_table WHERE register_fname='" & fnametxt.Text & "' AND register_lname='" & lnametxt.Text & "'  ORDER BY ruid ASC"
        Dim dataadapter As New MySqlDataAdapter
        Dim source As New BindingSource
        Dim datatable As New DataTable
        Dim command As New MySqlCommand
        Try
            connection.Open()
            command = New MySqlCommand(query, connection)
            dataadapter.SelectCommand = command
            dataadapter.Fill(datatable)
            source.DataSource = datatable
            patientview.DataSource = source
            dataadapter.Update(datatable)
            connection.Close()
        Catch ex As Exception
            MsgBox("There was an error please try again later")
        Finally
            connection.Dispose()
        End Try
    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles labradio.CheckedChanged
        lablist.Enabled = True
        radiologybox.Enabled = False
        If fnametxt.Text = "" Or lnametxt.Text = "" And yesbtn.Checked = True Then
            fnametxt.Text = "First Name"
            lnametxt.Text = "Last Name"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles normalradio.CheckedChanged
        lablist.Enabled = False
        radiologybox.Enabled = False
        If fnametxt.Text = "" Or lnametxt.Text = "" And yesbtn.Checked = True Then
            fnametxt.Text = "First Name"
            lnametxt.Text = "Last Name"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radiologyradio.CheckedChanged
        radiologybox.Enabled = True
        lablist.Enabled = False
        If fnametxt.Text = "" Or lnametxt.Text = "" And yesbtn.Checked = True Then
            fnametxt.Text = "First Name"
            lnametxt.Text = "Last Name"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles cardioradio.CheckedChanged
        cardiolist.Enabled = True
        ultrasoundlist.Enabled = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles ultraradio.CheckedChanged
        ultrasoundlist.Enabled = True
        cardiolist.Enabled = False
    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        'Single line textboxes. 
        'The locations used are just the location on the form in this case.
        Dim fntl As New Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point)
        Dim fnts As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        'Multiline textbox
        'Here i used the textbox bounds as the layout rectangle
        e.Graphics.DrawString("ST. BERNARD INFIRMARY AND MULTI-SPECIALTY CLINIC INC.", fnts, Brushes.Black, 0, 0)
        e.Graphics.DrawString("YOUR QUEUE NUMBER", fnts, Brushes.Black, 0, 25)
        e.Graphics.DrawString(queueid, fntl, Brushes.Black, 0, 60)
        e.Graphics.DrawString("Please present this in cashier to payout", fnts, Brushes.Black, 0, 90)
        e.Graphics.DrawString("YOUR TRANSACTION NUMBER", fnts, Brushes.Black, 0, 110)
        e.Graphics.DrawString(transid, fntl, Brushes.Black, 0, 130)
    End Sub

    Private Sub patientview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles patientview.CellClick
        patienttxt.Text = patientview.Rows(e.RowIndex).Cells(0).Value.ToString + " " + patientview.Rows(e.RowIndex).Cells(1).Value.ToString + " " + patientview.Rows(e.RowIndex).Cells(2).Value.ToString
    End Sub

    Private Sub fnametxt_click(sender As Object, e As EventArgs) Handles fnametxt.Click
        fnametxt.Text = ""
        If lnametxt.Text = "" Then
            lnametxt.Text = "Last Name"
        End If
    End Sub

    Private Sub lablist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lablist.SelectedIndexChanged
        If fnametxt.Text = "" And lnametxt.Text = "" And yesbtn.Checked = True Then
            fnametxt.Text = "First Name"
            lnametxt.Text = "Last Name"
        End If
    End Sub

    Private Sub lnametxt_click(sender As Object, e As EventArgs) Handles lnametxt.Click
        lnametxt.Text = ""
        If fnametxt.Text = "" Then
            fnametxt.Text = "First Name"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class