<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hbsagprintpreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hbsagprintpreview))
        Me.hematologylbl = New System.Windows.Forms.Label()
        Me.countlbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.caneclbtn = New System.Windows.Forms.Button()
        Me.printbtn = New System.Windows.Forms.Button()
        Me.datetxt = New System.Windows.Forms.Label()
        Me.gendertxt = New System.Windows.Forms.Label()
        Me.agetxt = New System.Windows.Forms.Label()
        Me.fullnametxt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.res1 = New System.Windows.Forms.Label()
        Me.res2 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.doctortxt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hematologylbl
        '
        Me.hematologylbl.AutoSize = True
        Me.hematologylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hematologylbl.Location = New System.Drawing.Point(25, 72)
        Me.hematologylbl.Name = "hematologylbl"
        Me.hematologylbl.Size = New System.Drawing.Size(451, 29)
        Me.hematologylbl.TabIndex = 64
        Me.hematologylbl.Text = "CLINICAL PATHOLOGY RESULT FORM"
        '
        'countlbl
        '
        Me.countlbl.AutoSize = True
        Me.countlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countlbl.Location = New System.Drawing.Point(75, 117)
        Me.countlbl.Name = "countlbl"
        Me.countlbl.Size = New System.Drawing.Size(65, 25)
        Me.countlbl.TabIndex = 65
        Me.countlbl.Text = "TEST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(318, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "RESULT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 22)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "HBsAG Screening"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 22)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "VDRL / RPR"
        '
        'caneclbtn
        '
        Me.caneclbtn.Location = New System.Drawing.Point(10, 283)
        Me.caneclbtn.Name = "caneclbtn"
        Me.caneclbtn.Size = New System.Drawing.Size(138, 38)
        Me.caneclbtn.TabIndex = 245
        Me.caneclbtn.Text = "CANCEL"
        Me.caneclbtn.UseVisualStyleBackColor = True
        '
        'printbtn
        '
        Me.printbtn.AutoSize = True
        Me.printbtn.Location = New System.Drawing.Point(154, 283)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(138, 38)
        Me.printbtn.TabIndex = 244
        Me.printbtn.Text = "PRINT"
        Me.printbtn.UseVisualStyleBackColor = True
        '
        'datetxt
        '
        Me.datetxt.AutoSize = True
        Me.datetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.Location = New System.Drawing.Point(323, 38)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(23, 17)
        Me.datetxt.TabIndex = 259
        Me.datetxt.Text = "---"
        '
        'gendertxt
        '
        Me.gendertxt.AutoSize = True
        Me.gendertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gendertxt.Location = New System.Drawing.Point(198, 38)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(23, 17)
        Me.gendertxt.TabIndex = 258
        Me.gendertxt.Text = "---"
        '
        'agetxt
        '
        Me.agetxt.AutoSize = True
        Me.agetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agetxt.Location = New System.Drawing.Point(59, 38)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(23, 17)
        Me.agetxt.TabIndex = 257
        Me.agetxt.Text = "---"
        '
        'fullnametxt
        '
        Me.fullnametxt.AutoSize = True
        Me.fullnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnametxt.Location = New System.Drawing.Point(115, 9)
        Me.fullnametxt.Name = "fullnametxt"
        Me.fullnametxt.Size = New System.Drawing.Size(23, 17)
        Me.fullnametxt.TabIndex = 256
        Me.fullnametxt.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 255
        Me.Label4.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 254
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 253
        Me.Label3.Text = "AGE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "Patient Name:"
        '
        'res1
        '
        Me.res1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res1.Location = New System.Drawing.Point(251, 175)
        Me.res1.Name = "res1"
        Me.res1.Size = New System.Drawing.Size(225, 22)
        Me.res1.TabIndex = 260
        Me.res1.Text = "---"
        Me.res1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'res2
        '
        Me.res2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res2.Location = New System.Drawing.Point(251, 223)
        Me.res2.Name = "res2"
        Me.res2.Size = New System.Drawing.Size(225, 22)
        Me.res2.TabIndex = 261
        Me.res2.Text = "---"
        Me.res2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'doctortxt
        '
        Me.doctortxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctortxt.Location = New System.Drawing.Point(298, 278)
        Me.doctortxt.Name = "doctortxt"
        Me.doctortxt.Size = New System.Drawing.Size(189, 28)
        Me.doctortxt.TabIndex = 264
        Me.doctortxt.Text = "fullname"
        Me.doctortxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(298, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 17)
        Me.Label9.TabIndex = 263
        Me.Label9.Text = "_______________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(354, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 262
        Me.Label10.Text = "Pathologist"
        '
        'hbsagprintpreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(518, 337)
        Me.Controls.Add(Me.res2)
        Me.Controls.Add(Me.res1)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.gendertxt)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.fullnametxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.caneclbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.countlbl)
        Me.Controls.Add(Me.hematologylbl)
        Me.Controls.Add(Me.doctortxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.MaximizeBox = False
        Me.Name = "hbsagprintpreview"
        Me.Text = "hbsagprintpreview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hematologylbl As Label
    Friend WithEvents countlbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents caneclbtn As Button
    Friend WithEvents printbtn As Button
    Friend WithEvents datetxt As Label
    Friend WithEvents gendertxt As Label
    Friend WithEvents agetxt As Label
    Friend WithEvents fullnametxt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents res1 As Label
    Friend WithEvents res2 As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents doctortxt As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
