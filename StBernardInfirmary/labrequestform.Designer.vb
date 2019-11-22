<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class labrequestform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.patienttxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.agetxt = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gendertxt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.monthcombobox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datetxt = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.yeartxt = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addresstxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.contacttxt = New System.Windows.Forms.TextBox()
        Me.sendbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.lablist = New System.Windows.Forms.CheckedListBox()
        Me.radiologybox = New System.Windows.Forms.GroupBox()
        Me.ultraradio = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cardioradio = New System.Windows.Forms.RadioButton()
        Me.ultrasoundlist = New System.Windows.Forms.CheckedListBox()
        Me.cardiolist = New System.Windows.Forms.CheckedListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.doctornametxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.radiologybox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PATIENT NAME:"
        '
        'patienttxt
        '
        Me.patienttxt.Enabled = False
        Me.patienttxt.Location = New System.Drawing.Point(141, 15)
        Me.patienttxt.MaxLength = 50
        Me.patienttxt.Name = "patienttxt"
        Me.patienttxt.Size = New System.Drawing.Size(269, 20)
        Me.patienttxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AGE:"
        '
        'agetxt
        '
        Me.agetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.agetxt.FormattingEnabled = True
        Me.agetxt.Location = New System.Drawing.Point(45, 107)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(52, 21)
        Me.agetxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "GENDER/SEX:"
        '
        'gendertxt
        '
        Me.gendertxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gendertxt.FormattingEnabled = True
        Me.gendertxt.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendertxt.Location = New System.Drawing.Point(107, 107)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(58, 21)
        Me.gendertxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "BIRTHDATE"
        '
        'monthcombobox
        '
        Me.monthcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monthcombobox.FormattingEnabled = True
        Me.monthcombobox.Location = New System.Drawing.Point(212, 107)
        Me.monthcombobox.Name = "monthcombobox"
        Me.monthcombobox.Size = New System.Drawing.Size(58, 21)
        Me.monthcombobox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MONTH:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(292, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "DATE:"
        '
        'datetxt
        '
        Me.datetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.datetxt.FormattingEnabled = True
        Me.datetxt.Location = New System.Drawing.Point(292, 107)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(58, 21)
        Me.datetxt.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "YEAR:"
        '
        'yeartxt
        '
        Me.yeartxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yeartxt.FormattingEnabled = True
        Me.yeartxt.Location = New System.Drawing.Point(365, 107)
        Me.yeartxt.Name = "yeartxt"
        Me.yeartxt.Size = New System.Drawing.Size(58, 21)
        Me.yeartxt.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ADDRESS:"
        '
        'addresstxt
        '
        Me.addresstxt.Location = New System.Drawing.Point(430, 147)
        Me.addresstxt.MaxLength = 50
        Me.addresstxt.Name = "addresstxt"
        Me.addresstxt.Size = New System.Drawing.Size(185, 20)
        Me.addresstxt.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "CONTACT NUMBER:"
        '
        'contacttxt
        '
        Me.contacttxt.Location = New System.Drawing.Point(159, 147)
        Me.contacttxt.MaxLength = 12
        Me.contacttxt.Name = "contacttxt"
        Me.contacttxt.Size = New System.Drawing.Size(185, 20)
        Me.contacttxt.TabIndex = 16
        '
        'sendbtn
        '
        Me.sendbtn.Location = New System.Drawing.Point(233, 318)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(141, 38)
        Me.sendbtn.TabIndex = 64
        Me.sendbtn.Text = "SEND REQUEST"
        Me.sendbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(391, 318)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(141, 38)
        Me.cancelbtn.TabIndex = 65
        Me.cancelbtn.Text = "CANCEL REQUEST"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'lablist
        '
        Me.lablist.Enabled = False
        Me.lablist.FormattingEnabled = True
        Me.lablist.Items.AddRange(New Object() {"CBC", "URINALYSIS", "FECALYSIS", "HBSAG", "LIPID_PROFILE"})
        Me.lablist.Location = New System.Drawing.Point(320, 42)
        Me.lablist.Name = "lablist"
        Me.lablist.Size = New System.Drawing.Size(141, 79)
        Me.lablist.TabIndex = 70
        '
        'radiologybox
        '
        Me.radiologybox.Controls.Add(Me.ultraradio)
        Me.radiologybox.Controls.Add(Me.RadioButton1)
        Me.radiologybox.Controls.Add(Me.cardioradio)
        Me.radiologybox.Controls.Add(Me.lablist)
        Me.radiologybox.Controls.Add(Me.ultrasoundlist)
        Me.radiologybox.Controls.Add(Me.cardiolist)
        Me.radiologybox.Location = New System.Drawing.Point(45, 173)
        Me.radiologybox.Name = "radiologybox"
        Me.radiologybox.Size = New System.Drawing.Size(468, 139)
        Me.radiologybox.TabIndex = 81
        Me.radiologybox.TabStop = False
        Me.radiologybox.Text = "RADIOLOGY"
        '
        'ultraradio
        '
        Me.ultraradio.Location = New System.Drawing.Point(19, 21)
        Me.ultraradio.Name = "ultraradio"
        Me.ultraradio.Size = New System.Drawing.Size(100, 17)
        Me.ultraradio.TabIndex = 79
        Me.ultraradio.Text = "ULTRASOUND"
        Me.ultraradio.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(320, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton1.TabIndex = 80
        Me.RadioButton1.Text = "LABORATORY "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cardioradio
        '
        Me.cardioradio.Location = New System.Drawing.Point(19, 61)
        Me.cardioradio.Name = "cardioradio"
        Me.cardioradio.Size = New System.Drawing.Size(123, 17)
        Me.cardioradio.TabIndex = 4
        Me.cardioradio.Text = "CARDIOVASCULAR"
        Me.cardioradio.UseVisualStyleBackColor = True
        '
        'ultrasoundlist
        '
        Me.ultrasoundlist.Enabled = False
        Me.ultrasoundlist.FormattingEnabled = True
        Me.ultrasoundlist.Items.AddRange(New Object() {"HEPATOBILIARY_TREE", "TRANSVAGINAL"})
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(570, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 23)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "_"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'doctornametxt
        '
        Me.doctornametxt.Enabled = False
        Me.doctornametxt.Location = New System.Drawing.Point(141, 41)
        Me.doctornametxt.MaxLength = 50
        Me.doctornametxt.Name = "doctornametxt"
        Me.doctornametxt.Size = New System.Drawing.Size(269, 20)
        Me.doctornametxt.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Requesting Doctor:"
        '
        'labrequestform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.doctornametxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.sendbtn)
        Me.Controls.Add(Me.contacttxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.addresstxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.yeartxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.monthcombobox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gendertxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.patienttxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radiologybox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "labrequestform"
        Me.Text = " LABORATORY REQUEST"
        Me.radiologybox.ResumeLayout(False)
        Me.radiologybox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents patienttxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents agetxt As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gendertxt As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents monthcombobox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents datetxt As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents yeartxt As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addresstxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents contacttxt As TextBox
    Friend WithEvents sendbtn As Button
    Friend WithEvents cancelbtn As Button
    Friend WithEvents lablist As CheckedListBox
    Friend WithEvents radiologybox As GroupBox
    Friend WithEvents ultraradio As RadioButton
    Friend WithEvents cardioradio As RadioButton
    Friend WithEvents ultrasoundlist As CheckedListBox
    Friend WithEvents cardiolist As CheckedListBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents doctornametxt As TextBox
    Friend WithEvents Label10 As Label
End Class
