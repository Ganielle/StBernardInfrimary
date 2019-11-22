<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkupissue
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
        Me.patientview = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nobtn = New System.Windows.Forms.RadioButton()
        Me.yesbtn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.patienttxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.sendbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lablist = New System.Windows.Forms.CheckedListBox()
        Me.label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radiologyradio = New System.Windows.Forms.RadioButton()
        Me.labradio = New System.Windows.Forms.RadioButton()
        Me.normalradio = New System.Windows.Forms.RadioButton()
        Me.ultrasoundlist = New System.Windows.Forms.CheckedListBox()
        Me.cardiolist = New System.Windows.Forms.CheckedListBox()
        Me.cardioradio = New System.Windows.Forms.RadioButton()
        Me.ultraradio = New System.Windows.Forms.RadioButton()
        Me.radiologybox = New System.Windows.Forms.GroupBox()
        Me.fnametxt = New System.Windows.Forms.TextBox()
        Me.lnametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.qtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.patientview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.radiologybox.SuspendLayout()
        Me.SuspendLayout()
        '
        'patientview
        '
        Me.patientview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.patientview.Enabled = False
        Me.patientview.Location = New System.Drawing.Point(12, 33)
        Me.patientview.Name = "patientview"
        Me.patientview.Size = New System.Drawing.Size(515, 108)
        Me.patientview.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nobtn)
        Me.GroupBox1.Controls.Add(Me.yesbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 41)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existing Patient"
        '
        'nobtn
        '
        Me.nobtn.AutoSize = True
        Me.nobtn.Location = New System.Drawing.Point(81, 18)
        Me.nobtn.Name = "nobtn"
        Me.nobtn.Size = New System.Drawing.Size(41, 17)
        Me.nobtn.TabIndex = 1
        Me.nobtn.Text = "NO"
        Me.nobtn.UseVisualStyleBackColor = True
        '
        'yesbtn
        '
        Me.yesbtn.AutoSize = True
        Me.yesbtn.Checked = True
        Me.yesbtn.Location = New System.Drawing.Point(19, 18)
        Me.yesbtn.Name = "yesbtn"
        Me.yesbtn.Size = New System.Drawing.Size(46, 17)
        Me.yesbtn.TabIndex = 0
        Me.yesbtn.TabStop = True
        Me.yesbtn.Text = "YES"
        Me.yesbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patient Name:"
        '
        'patienttxt
        '
        Me.patienttxt.Location = New System.Drawing.Point(212, 255)
        Me.patienttxt.MaxLength = 50
        Me.patienttxt.Name = "patienttxt"
        Me.patienttxt.Size = New System.Drawing.Size(189, 20)
        Me.patienttxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search Patient:"
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(407, 162)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 8
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'sendbtn
        '
        Me.sendbtn.Location = New System.Drawing.Point(407, 252)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(100, 23)
        Me.sendbtn.TabIndex = 9
        Me.sendbtn.Text = "SEND ISSUE"
        Me.sendbtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(407, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lablist
        '
        Me.lablist.Enabled = False
        Me.lablist.FormattingEnabled = True
        Me.lablist.Items.AddRange(New Object() {"CBC", "URINALYSIS", "FECALYSIS", "HBSAG", "LIPID PROFILE"})
        Me.lablist.Location = New System.Drawing.Point(33, 322)
        Me.lablist.Name = "lablist"
        Me.lablist.Size = New System.Drawing.Size(141, 79)
        Me.lablist.TabIndex = 72
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(30, 302)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(80, 13)
        Me.label.TabIndex = 71
        Me.label.Text = "LABORATORY"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radiologyradio)
        Me.GroupBox2.Controls.Add(Me.labradio)
        Me.GroupBox2.Controls.Add(Me.normalradio)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 86)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TYPE OF CHECKUP"
        '
        'radiologyradio
        '
        Me.radiologyradio.AutoSize = True
        Me.radiologyradio.Location = New System.Drawing.Point(16, 53)
        Me.radiologyradio.Name = "radiologyradio"
        Me.radiologyradio.Size = New System.Drawing.Size(142, 17)
        Me.radiologyradio.TabIndex = 3
        Me.radiologyradio.Text = "RADIOLOGY CHECKUP"
        Me.radiologyradio.UseVisualStyleBackColor = True
        '
        'labradio
        '
        Me.labradio.AutoSize = True
        Me.labradio.Location = New System.Drawing.Point(16, 36)
        Me.labradio.Name = "labradio"
        Me.labradio.Size = New System.Drawing.Size(152, 17)
        Me.labradio.TabIndex = 2
        Me.labradio.Text = "LABORATORY CHECKUP"
        Me.labradio.UseVisualStyleBackColor = True
        '
        'normalradio
        '
        Me.normalradio.AutoSize = True
        Me.normalradio.Checked = True
        Me.normalradio.Location = New System.Drawing.Point(16, 18)
        Me.normalradio.Name = "normalradio"
        Me.normalradio.Size = New System.Drawing.Size(125, 17)
        Me.normalradio.TabIndex = 2
        Me.normalradio.TabStop = True
        Me.normalradio.Text = "NORMAL CHECKUP"
        Me.normalradio.UseVisualStyleBackColor = True
        '
        'ultrasoundlist
        '
        Me.ultrasoundlist.Enabled = False
        Me.ultrasoundlist.FormattingEnabled = True
        Me.ultrasoundlist.Items.AddRange(New Object() {"HEPATOBILIARY TREE", "TRANSVAGINAL"})
        Me.ultrasoundlist.Location = New System.Drawing.Point(125, 21)
        Me.ultrasoundlist.Name = "ultrasoundlist"
        Me.ultrasoundlist.Size = New System.Drawing.Size(148, 34)
        Me.ultrasoundlist.TabIndex = 78
        '
        'cardiolist
        '
        Me.cardiolist.Enabled = False
        Me.cardiolist.FormattingEnabled = True
        Me.cardiolist.Items.AddRange(New Object() {"ECG"})
        Me.cardiolist.Location = New System.Drawing.Point(158, 61)
        Me.cardiolist.Name = "cardiolist"
        Me.cardiolist.Size = New System.Drawing.Size(57, 19)
        Me.cardiolist.TabIndex = 76
        '
        'cardioradio
        '
        Me.cardioradio.AutoSize = True
        Me.cardioradio.Location = New System.Drawing.Point(19, 61)
        Me.cardioradio.Name = "cardioradio"
        Me.cardioradio.Size = New System.Drawing.Size(123, 17)
        Me.cardioradio.TabIndex = 4
        Me.cardioradio.Text = "CARDIOVASCULAR"
        Me.cardioradio.UseVisualStyleBackColor = True
        '
        'ultraradio
        '
        Me.ultraradio.AutoSize = True
        Me.ultraradio.Location = New System.Drawing.Point(19, 21)
        Me.ultraradio.Name = "ultraradio"
        Me.ultraradio.Size = New System.Drawing.Size(100, 17)
        Me.ultraradio.TabIndex = 79
        Me.ultraradio.Text = "ULTRASOUND"
        Me.ultraradio.UseVisualStyleBackColor = True
        '
        'radiologybox
        '
        Me.radiologybox.Controls.Add(Me.ultraradio)
        Me.radiologybox.Controls.Add(Me.cardioradio)
        Me.radiologybox.Controls.Add(Me.ultrasoundlist)
        Me.radiologybox.Controls.Add(Me.cardiolist)
        Me.radiologybox.Enabled = False
        Me.radiologybox.Location = New System.Drawing.Point(209, 304)
        Me.radiologybox.Name = "radiologybox"
        Me.radiologybox.Size = New System.Drawing.Size(281, 97)
        Me.radiologybox.TabIndex = 80
        Me.radiologybox.TabStop = False
        Me.radiologybox.Text = "RADIOLOGY"
        '
        'fnametxt
        '
        Me.fnametxt.Location = New System.Drawing.Point(212, 164)
        Me.fnametxt.MaxLength = 50
        Me.fnametxt.Name = "fnametxt"
        Me.fnametxt.Size = New System.Drawing.Size(92, 20)
        Me.fnametxt.TabIndex = 81
        Me.fnametxt.Text = "First Name"
        '
        'lnametxt
        '
        Me.lnametxt.Location = New System.Drawing.Point(310, 164)
        Me.lnametxt.MaxLength = 50
        Me.lnametxt.Name = "lnametxt"
        Me.lnametxt.Size = New System.Drawing.Size(92, 20)
        Me.lnametxt.TabIndex = 82
        Me.lnametxt.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Queue No.:"
        '
        'qtxt
        '
        Me.qtxt.Enabled = False
        Me.qtxt.Location = New System.Drawing.Point(212, 203)
        Me.qtxt.MaxLength = 50
        Me.qtxt.Name = "qtxt"
        Me.qtxt.Size = New System.Drawing.Size(59, 20)
        Me.qtxt.TabIndex = 84
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(486, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 23)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "_"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'checkupissue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.qtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lnametxt)
        Me.Controls.Add(Me.fnametxt)
        Me.Controls.Add(Me.radiologybox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lablist)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.sendbtn)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.patienttxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.patientview)
        Me.MaximizeBox = False
        Me.Name = "checkupissue"
        Me.Text = "CHECK-UP ISSUE FORM"
        CType(Me.patientview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.radiologybox.ResumeLayout(False)
        Me.radiologybox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents patientview As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nobtn As RadioButton
    Friend WithEvents yesbtn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents patienttxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents searchbtn As Button
    Friend WithEvents sendbtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents label As Label
    Friend WithEvents lablist As CheckedListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents labradio As RadioButton
    Friend WithEvents normalradio As RadioButton
    Friend WithEvents radiologyradio As RadioButton
    Friend WithEvents ultrasoundlist As CheckedListBox
    Friend WithEvents cardiolist As CheckedListBox
    Friend WithEvents cardioradio As RadioButton
    Friend WithEvents ultraradio As RadioButton
    Friend WithEvents radiologybox As GroupBox
    Friend WithEvents fnametxt As TextBox
    Friend WithEvents lnametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents qtxt As TextBox
    Friend WithEvents Button1 As Button
End Class
