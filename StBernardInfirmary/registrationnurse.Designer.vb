<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registrationnurse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrationnurse))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.uidtxt = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.religiontxt = New System.Windows.Forms.ComboBox()
        Me.agetxt = New System.Windows.Forms.ComboBox()
        Me.gendertxt = New System.Windows.Forms.ComboBox()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.searchtypelabel = New System.Windows.Forms.Label()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.searchtypebox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.addresstxt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.monthcombobox = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.fathertxt = New System.Windows.Forms.TextBox()
        Me.mothertxt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.spousetxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.contactnumbertxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.occupationtxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nationalitytxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.birthplacetxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.year_combobox = New System.Windows.Forms.ComboBox()
        Me.date_combobox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnametxt = New System.Windows.Forms.TextBox()
        Me.fnametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.registrationview = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.registrationview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(48, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(147, 117)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 103
        Me.PictureBox2.TabStop = False
        '
        'uidtxt
        '
        Me.uidtxt.Enabled = False
        Me.uidtxt.Location = New System.Drawing.Point(60, 244)
        Me.uidtxt.Name = "uidtxt"
        Me.uidtxt.Size = New System.Drawing.Size(48, 20)
        Me.uidtxt.TabIndex = 101
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label.Image = CType(resources.GetObject("label.Image"), System.Drawing.Image)
        Me.label.Location = New System.Drawing.Point(35, 247)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(24, 13)
        Me.label.TabIndex = 100
        Me.label.Text = "ID:"
        '
        'religiontxt
        '
        Me.religiontxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.religiontxt.FormattingEnabled = True
        Me.religiontxt.Items.AddRange(New Object() {"Christian", "Catholic", "Roman Catholic", "Hinduism", "Buddhism", "Islam", "Judaism"})
        Me.religiontxt.Location = New System.Drawing.Point(551, 535)
        Me.religiontxt.Name = "religiontxt"
        Me.religiontxt.Size = New System.Drawing.Size(126, 21)
        Me.religiontxt.TabIndex = 99
        '
        'agetxt
        '
        Me.agetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.agetxt.FormattingEnabled = True
        Me.agetxt.Location = New System.Drawing.Point(204, 386)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(65, 21)
        Me.agetxt.TabIndex = 98
        '
        'gendertxt
        '
        Me.gendertxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gendertxt.FormattingEnabled = True
        Me.gendertxt.Items.AddRange(New Object() {"Male", "Female"})
        Me.gendertxt.Location = New System.Drawing.Point(297, 386)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(79, 21)
        Me.gendertxt.TabIndex = 97
        '
        'refreshbtn
        '
        Me.refreshbtn.Location = New System.Drawing.Point(170, 210)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(54, 23)
        Me.refreshbtn.TabIndex = 96
        Me.refreshbtn.Text = "Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(114, 210)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(50, 23)
        Me.searchbtn.TabIndex = 95
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'searchtypelabel
        '
        Me.searchtypelabel.AutoSize = True
        Me.searchtypelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtypelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.searchtypelabel.Image = CType(resources.GetObject("searchtypelabel.Image"), System.Drawing.Image)
        Me.searchtypelabel.Location = New System.Drawing.Point(27, 187)
        Me.searchtypelabel.Name = "searchtypelabel"
        Me.searchtypelabel.Size = New System.Drawing.Size(46, 13)
        Me.searchtypelabel.TabIndex = 94
        Me.searchtypelabel.Text = "NONE:"
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(114, 184)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(97, 20)
        Me.searchtxt.TabIndex = 93
        '
        'searchtypebox
        '
        Me.searchtypebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchtypebox.FormattingEnabled = True
        Me.searchtypebox.Items.AddRange(New Object() {"ID", "First Name"})
        Me.searchtypebox.Location = New System.Drawing.Point(114, 157)
        Me.searchtypebox.Name = "searchtypebox"
        Me.searchtypebox.Size = New System.Drawing.Size(87, 21)
        Me.searchtypebox.TabIndex = 92
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.Location = New System.Drawing.Point(27, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 13)
        Me.Label19.TabIndex = 91
        Me.Label19.Text = "SEARCH BY:"
        '
        'addresstxt
        '
        Me.addresstxt.Location = New System.Drawing.Point(49, 434)
        Me.addresstxt.MaxLength = 100
        Me.addresstxt.Name = "addresstxt"
        Me.addresstxt.Size = New System.Drawing.Size(622, 20)
        Me.addresstxt.TabIndex = 90
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(46, 418)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "ADDRESS:"
        '
        'monthcombobox
        '
        Me.monthcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monthcombobox.FormattingEnabled = True
        Me.monthcombobox.Location = New System.Drawing.Point(219, 484)
        Me.monthcombobox.Name = "monthcombobox"
        Me.monthcombobox.Size = New System.Drawing.Size(50, 21)
        Me.monthcombobox.TabIndex = 88
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(14, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 23)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "GO BACK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(449, 622)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(134, 41)
        Me.deletebtn.TabIndex = 86
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(304, 622)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(134, 41)
        Me.editbtn.TabIndex = 85
        Me.editbtn.Text = "EDIT"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(158, 622)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(134, 41)
        Me.savebtn.TabIndex = 84
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'fathertxt
        '
        Me.fathertxt.Location = New System.Drawing.Point(486, 587)
        Me.fathertxt.MaxLength = 50
        Me.fathertxt.Name = "fathertxt"
        Me.fathertxt.Size = New System.Drawing.Size(167, 20)
        Me.fathertxt.TabIndex = 83
        '
        'mothertxt
        '
        Me.mothertxt.Location = New System.Drawing.Point(300, 587)
        Me.mothertxt.MaxLength = 50
        Me.mothertxt.Name = "mothertxt"
        Me.mothertxt.Size = New System.Drawing.Size(175, 20)
        Me.mothertxt.TabIndex = 82
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(483, 571)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "FATHER:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(297, 571)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "MOTHER:"
        '
        'spousetxt
        '
        Me.spousetxt.Location = New System.Drawing.Point(114, 587)
        Me.spousetxt.MaxLength = 50
        Me.spousetxt.Name = "spousetxt"
        Me.spousetxt.Size = New System.Drawing.Size(164, 20)
        Me.spousetxt.TabIndex = 79
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(111, 571)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "SPOUSE:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(548, 519)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "RELIGION:"
        '
        'contactnumbertxt
        '
        Me.contactnumbertxt.Location = New System.Drawing.Point(363, 535)
        Me.contactnumbertxt.MaxLength = 12
        Me.contactnumbertxt.Name = "contactnumbertxt"
        Me.contactnumbertxt.Size = New System.Drawing.Size(153, 20)
        Me.contactnumbertxt.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(360, 519)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "CONTACT NUMBER:"
        '
        'occupationtxt
        '
        Me.occupationtxt.Location = New System.Drawing.Point(208, 535)
        Me.occupationtxt.MaxLength = 20
        Me.occupationtxt.Name = "occupationtxt"
        Me.occupationtxt.Size = New System.Drawing.Size(113, 20)
        Me.occupationtxt.TabIndex = 74
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(205, 519)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "OCCUPATION:"
        '
        'nationalitytxt
        '
        Me.nationalitytxt.Location = New System.Drawing.Point(55, 535)
        Me.nationalitytxt.MaxLength = 20
        Me.nationalitytxt.Name = "nationalitytxt"
        Me.nationalitytxt.Size = New System.Drawing.Size(112, 20)
        Me.nationalitytxt.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(52, 519)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "NATIONALITY:"
        '
        'birthplacetxt
        '
        Me.birthplacetxt.Location = New System.Drawing.Point(401, 484)
        Me.birthplacetxt.MaxLength = 50
        Me.birthplacetxt.Name = "birthplacetxt"
        Me.birthplacetxt.Size = New System.Drawing.Size(247, 20)
        Me.birthplacetxt.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(398, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "BIRTHPLACE:"
        '
        'year_combobox
        '
        Me.year_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.year_combobox.FormattingEnabled = True
        Me.year_combobox.Location = New System.Drawing.Point(97, 484)
        Me.year_combobox.Name = "year_combobox"
        Me.year_combobox.Size = New System.Drawing.Size(51, 21)
        Me.year_combobox.TabIndex = 68
        '
        'date_combobox
        '
        Me.date_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.date_combobox.FormattingEnabled = True
        Me.date_combobox.Location = New System.Drawing.Point(325, 484)
        Me.date_combobox.Name = "date_combobox"
        Me.date_combobox.Size = New System.Drawing.Size(51, 21)
        Me.date_combobox.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(52, 487)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "YEAR:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(280, 487)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "DATE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(163, 487)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "MONTH:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(50, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(292, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "BIRTHDAY (to reset the date please choose MONTH again)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(201, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "AGE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(294, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "GENDER/SEX:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(46, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "LAST NAME:"
        '
        'lnametxt
        '
        Me.lnametxt.Location = New System.Drawing.Point(49, 387)
        Me.lnametxt.MaxLength = 30
        Me.lnametxt.Name = "lnametxt"
        Me.lnametxt.Size = New System.Drawing.Size(128, 20)
        Me.lnametxt.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(46, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "MIDDLE NAME:"
        '
        'mnametxt
        '
        Me.mnametxt.Location = New System.Drawing.Point(49, 338)
        Me.mnametxt.MaxLength = 20
        Me.mnametxt.Name = "mnametxt"
        Me.mnametxt.Size = New System.Drawing.Size(128, 20)
        Me.mnametxt.TabIndex = 57
        '
        'fnametxt
        '
        Me.fnametxt.Location = New System.Drawing.Point(48, 294)
        Me.fnametxt.MaxLength = 30
        Me.fnametxt.Name = "fnametxt"
        Me.fnametxt.Size = New System.Drawing.Size(100, 20)
        Me.fnametxt.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(45, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "FIRST NAME:"
        '
        'registrationview
        '
        Me.registrationview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.registrationview.Location = New System.Drawing.Point(230, 32)
        Me.registrationview.Name = "registrationview"
        Me.registrationview.Size = New System.Drawing.Size(515, 326)
        Me.registrationview.TabIndex = 54
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(756, 675)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(454, 628)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 106
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(310, 628)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 105
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(166, 628)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 104
        Me.PictureBox5.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(698, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 23)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'registrationnurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 674)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.uidtxt)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.religiontxt)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.gendertxt)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.searchtypelabel)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.searchtypebox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.addresstxt)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.monthcombobox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.fathertxt)
        Me.Controls.Add(Me.mothertxt)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.spousetxt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.contactnumbertxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.occupationtxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.nationalitytxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.birthplacetxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.year_combobox)
        Me.Controls.Add(Me.date_combobox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lnametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mnametxt)
        Me.Controls.Add(Me.fnametxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.registrationview)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "registrationnurse"
        Me.Text = "registrationadmin"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.registrationview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents uidtxt As TextBox
    Friend WithEvents label As Label
    Friend WithEvents religiontxt As ComboBox
    Friend WithEvents agetxt As ComboBox
    Friend WithEvents gendertxt As ComboBox
    Friend WithEvents refreshbtn As Button
    Friend WithEvents searchbtn As Button
    Friend WithEvents searchtypelabel As Label
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents searchtypebox As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents addresstxt As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents monthcombobox As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents fathertxt As TextBox
    Friend WithEvents mothertxt As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents spousetxt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents contactnumbertxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents occupationtxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents nationalitytxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents birthplacetxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents year_combobox As ComboBox
    Friend WithEvents date_combobox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lnametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mnametxt As TextBox
    Friend WithEvents fnametxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents registrationview As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button2 As Button
End Class
