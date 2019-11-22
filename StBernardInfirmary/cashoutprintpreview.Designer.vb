<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashoutprintpreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cashoutprintpreview))
        Me.hematologylbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.transid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datetxt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.itemlisttxt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pricelisttxt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totaltxt = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.caneclbtn = New System.Windows.Forms.Button()
        Me.printbtn = New System.Windows.Forms.Button()
        Me.cashval = New System.Windows.Forms.Label()
        Me.cashtxt = New System.Windows.Forms.Label()
        Me.changeval = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hematologylbl
        '
        Me.hematologylbl.AutoSize = True
        Me.hematologylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hematologylbl.Location = New System.Drawing.Point(12, 9)
        Me.hematologylbl.Name = "hematologylbl"
        Me.hematologylbl.Size = New System.Drawing.Size(317, 13)
        Me.hematologylbl.TabIndex = 270
        Me.hematologylbl.Text = "ST. BERNARD INFIRMARY AND MULTY-SPECIALTY CLINIC, INC."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 13)
        Me.Label2.TabIndex = 278
        Me.Label2.Text = "Tel. No.: 470-1521 Mob. No.: 0943-8116586"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 13)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "79 Quarry Road, Brgy. Palangoy, Binangonan, Rizal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "CHARGE SLIP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 280
        Me.Label4.Text = "Transaction ID:"
        '
        'transid
        '
        Me.transid.AutoSize = True
        Me.transid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transid.Location = New System.Drawing.Point(95, 84)
        Me.transid.Name = "transid"
        Me.transid.Size = New System.Drawing.Size(44, 13)
        Me.transid.TabIndex = 281
        Me.transid.Text = "trans_id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 282
        Me.Label5.Text = "Charge Date and Time:"
        '
        'datetxt
        '
        Me.datetxt.AutoSize = True
        Me.datetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.Location = New System.Drawing.Point(132, 106)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(53, 13)
        Me.datetxt.TabIndex = 283
        Me.datetxt.Text = "date_time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 284
        Me.Label6.Text = "ITEMS"
        '
        'itemlisttxt
        '
        Me.itemlisttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemlisttxt.Location = New System.Drawing.Point(12, 161)
        Me.itemlisttxt.Name = "itemlisttxt"
        Me.itemlisttxt.Size = New System.Drawing.Size(142, 113)
        Me.itemlisttxt.TabIndex = 285
        Me.itemlisttxt.Text = "ITEMSLIST"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(158, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 286
        Me.Label8.Text = "PRICE"
        '
        'pricelisttxt
        '
        Me.pricelisttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricelisttxt.Location = New System.Drawing.Point(160, 161)
        Me.pricelisttxt.Name = "pricelisttxt"
        Me.pricelisttxt.Size = New System.Drawing.Size(142, 113)
        Me.pricelisttxt.TabIndex = 287
        Me.pricelisttxt.Text = "ITEMSLIST"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(105, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 288
        Me.Label7.Text = "TOTAL"
        '
        'totaltxt
        '
        Me.totaltxt.AutoSize = True
        Me.totaltxt.Location = New System.Drawing.Point(160, 283)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(45, 13)
        Me.totaltxt.TabIndex = 289
        Me.totaltxt.Text = "Totalval"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'caneclbtn
        '
        Me.caneclbtn.Location = New System.Drawing.Point(14, 368)
        Me.caneclbtn.Name = "caneclbtn"
        Me.caneclbtn.Size = New System.Drawing.Size(148, 38)
        Me.caneclbtn.TabIndex = 291
        Me.caneclbtn.Text = "CANCEL"
        Me.caneclbtn.UseVisualStyleBackColor = True
        '
        'printbtn
        '
        Me.printbtn.AutoSize = True
        Me.printbtn.Location = New System.Drawing.Point(168, 368)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(148, 38)
        Me.printbtn.TabIndex = 290
        Me.printbtn.Text = "PRINT"
        Me.printbtn.UseVisualStyleBackColor = True
        '
        'cashval
        '
        Me.cashval.AutoSize = True
        Me.cashval.Location = New System.Drawing.Point(161, 296)
        Me.cashval.Name = "cashval"
        Me.cashval.Size = New System.Drawing.Size(45, 13)
        Me.cashval.TabIndex = 293
        Me.cashval.Text = "Cashval"
        '
        'cashtxt
        '
        Me.cashtxt.AutoSize = True
        Me.cashtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashtxt.Location = New System.Drawing.Point(105, 296)
        Me.cashtxt.Name = "cashtxt"
        Me.cashtxt.Size = New System.Drawing.Size(35, 13)
        Me.cashtxt.TabIndex = 292
        Me.cashtxt.Text = "CASH"
        '
        'changeval
        '
        Me.changeval.AutoSize = True
        Me.changeval.Location = New System.Drawing.Point(161, 309)
        Me.changeval.Name = "changeval"
        Me.changeval.Size = New System.Drawing.Size(58, 13)
        Me.changeval.TabIndex = 295
        Me.changeval.Text = "Changeval"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(105, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 294
        Me.Label11.Text = "CHANGE"
        '
        'cashoutprintpreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(337, 427)
        Me.ControlBox = False
        Me.Controls.Add(Me.changeval)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cashval)
        Me.Controls.Add(Me.cashtxt)
        Me.Controls.Add(Me.caneclbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.totaltxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pricelisttxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.itemlisttxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.transid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hematologylbl)
        Me.Name = "cashoutprintpreview"
        Me.Text = "cashoutprintpreview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hematologylbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents transid As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents datetxt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents itemlisttxt As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pricelisttxt As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents totaltxt As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents caneclbtn As Button
    Friend WithEvents printbtn As Button
    Friend WithEvents changeval As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cashval As Label
    Friend WithEvents cashtxt As Label
End Class
