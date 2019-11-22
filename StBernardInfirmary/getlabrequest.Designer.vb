<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class getlabrequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(getlabrequest))
        Me.labview = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fullnametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gendertxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbctxt = New System.Windows.Forms.TextBox()
        Me.cbcbtn = New System.Windows.Forms.Button()
        Me.urinalysistxt = New System.Windows.Forms.TextBox()
        Me.urinalysisbtn = New System.Windows.Forms.Button()
        Me.hbsagtxt = New System.Windows.Forms.TextBox()
        Me.fecalysistxt = New System.Windows.Forms.TextBox()
        Me.fecalysisbtn = New System.Windows.Forms.Button()
        Me.hbsagbtn = New System.Windows.Forms.Button()
        Me.lipidprofiletxt = New System.Windows.Forms.TextBox()
        Me.lipidprofilebtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.treetxt = New System.Windows.Forms.TextBox()
        Me.treebtn = New System.Windows.Forms.Button()
        Me.vaginaltxt = New System.Windows.Forms.TextBox()
        Me.vaginalbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.carbtn = New System.Windows.Forms.Button()
        Me.finishbtn = New System.Windows.Forms.Button()
        Me.cardtxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.doctortxt = New System.Windows.Forms.TextBox()
        Me.labidtxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.labview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labview
        '
        Me.labview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.labview.Location = New System.Drawing.Point(218, 52)
        Me.labview.Name = "labview"
        Me.labview.Size = New System.Drawing.Size(350, 150)
        Me.labview.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "GO BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Full Name:"
        '
        'fullnametxt
        '
        Me.fullnametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fullnametxt.Enabled = False
        Me.fullnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnametxt.Location = New System.Drawing.Point(15, 72)
        Me.fullnametxt.Name = "fullnametxt"
        Me.fullnametxt.Size = New System.Drawing.Size(197, 29)
        Me.fullnametxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "GENDER:"
        '
        'gendertxt
        '
        Me.gendertxt.Enabled = False
        Me.gendertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gendertxt.Location = New System.Drawing.Point(15, 136)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(75, 29)
        Me.gendertxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "AGE:"
        '
        'agetxt
        '
        Me.agetxt.Enabled = False
        Me.agetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agetxt.Location = New System.Drawing.Point(15, 205)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(75, 29)
        Me.agetxt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(12, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LABORATORY REQUEST"
        '
        'cbctxt
        '
        Me.cbctxt.Enabled = False
        Me.cbctxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbctxt.Location = New System.Drawing.Point(15, 278)
        Me.cbctxt.Name = "cbctxt"
        Me.cbctxt.Size = New System.Drawing.Size(75, 20)
        Me.cbctxt.TabIndex = 9
        '
        'cbcbtn
        '
        Me.cbcbtn.Enabled = False
        Me.cbcbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcbtn.Location = New System.Drawing.Point(15, 304)
        Me.cbcbtn.Name = "cbcbtn"
        Me.cbcbtn.Size = New System.Drawing.Size(118, 39)
        Me.cbcbtn.TabIndex = 10
        Me.cbcbtn.Text = "CBC"
        Me.cbcbtn.UseVisualStyleBackColor = True
        '
        'urinalysistxt
        '
        Me.urinalysistxt.Enabled = False
        Me.urinalysistxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.urinalysistxt.Location = New System.Drawing.Point(139, 278)
        Me.urinalysistxt.Name = "urinalysistxt"
        Me.urinalysistxt.Size = New System.Drawing.Size(75, 20)
        Me.urinalysistxt.TabIndex = 11
        '
        'urinalysisbtn
        '
        Me.urinalysisbtn.Enabled = False
        Me.urinalysisbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.urinalysisbtn.Location = New System.Drawing.Point(139, 304)
        Me.urinalysisbtn.Name = "urinalysisbtn"
        Me.urinalysisbtn.Size = New System.Drawing.Size(118, 39)
        Me.urinalysisbtn.TabIndex = 12
        Me.urinalysisbtn.Text = "URINALYSIS"
        Me.urinalysisbtn.UseVisualStyleBackColor = True
        '
        'hbsagtxt
        '
        Me.hbsagtxt.Enabled = False
        Me.hbsagtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hbsagtxt.Location = New System.Drawing.Point(139, 349)
        Me.hbsagtxt.Name = "hbsagtxt"
        Me.hbsagtxt.Size = New System.Drawing.Size(75, 20)
        Me.hbsagtxt.TabIndex = 13
        '
        'fecalysistxt
        '
        Me.fecalysistxt.Enabled = False
        Me.fecalysistxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecalysistxt.Location = New System.Drawing.Point(15, 349)
        Me.fecalysistxt.Name = "fecalysistxt"
        Me.fecalysistxt.Size = New System.Drawing.Size(75, 20)
        Me.fecalysistxt.TabIndex = 14
        '
        'fecalysisbtn
        '
        Me.fecalysisbtn.Enabled = False
        Me.fecalysisbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecalysisbtn.Location = New System.Drawing.Point(15, 375)
        Me.fecalysisbtn.Name = "fecalysisbtn"
        Me.fecalysisbtn.Size = New System.Drawing.Size(118, 39)
        Me.fecalysisbtn.TabIndex = 15
        Me.fecalysisbtn.Text = "FECALYSIS"
        Me.fecalysisbtn.UseVisualStyleBackColor = True
        '
        'hbsagbtn
        '
        Me.hbsagbtn.Enabled = False
        Me.hbsagbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hbsagbtn.Location = New System.Drawing.Point(139, 375)
        Me.hbsagbtn.Name = "hbsagbtn"
        Me.hbsagbtn.Size = New System.Drawing.Size(118, 39)
        Me.hbsagbtn.TabIndex = 16
        Me.hbsagbtn.Text = "HBSAG"
        Me.hbsagbtn.UseVisualStyleBackColor = True
        '
        'lipidprofiletxt
        '
        Me.lipidprofiletxt.Enabled = False
        Me.lipidprofiletxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lipidprofiletxt.Location = New System.Drawing.Point(94, 420)
        Me.lipidprofiletxt.Name = "lipidprofiletxt"
        Me.lipidprofiletxt.Size = New System.Drawing.Size(75, 20)
        Me.lipidprofiletxt.TabIndex = 17
        '
        'lipidprofilebtn
        '
        Me.lipidprofilebtn.Enabled = False
        Me.lipidprofilebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lipidprofilebtn.Location = New System.Drawing.Point(75, 446)
        Me.lipidprofilebtn.Name = "lipidprofilebtn"
        Me.lipidprofilebtn.Size = New System.Drawing.Size(118, 39)
        Me.lipidprofilebtn.TabIndex = 18
        Me.lipidprofilebtn.Text = "LIPID PROFILE"
        Me.lipidprofilebtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(323, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ULTRASOUND REQUEST"
        '
        'treetxt
        '
        Me.treetxt.Enabled = False
        Me.treetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treetxt.Location = New System.Drawing.Point(326, 278)
        Me.treetxt.Name = "treetxt"
        Me.treetxt.Size = New System.Drawing.Size(75, 20)
        Me.treetxt.TabIndex = 20
        '
        'treebtn
        '
        Me.treebtn.Enabled = False
        Me.treebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treebtn.Location = New System.Drawing.Point(326, 304)
        Me.treebtn.Name = "treebtn"
        Me.treebtn.Size = New System.Drawing.Size(118, 39)
        Me.treebtn.TabIndex = 21
        Me.treebtn.Text = "HEPATOBILIARY TREE"
        Me.treebtn.UseVisualStyleBackColor = True
        '
        'vaginaltxt
        '
        Me.vaginaltxt.Enabled = False
        Me.vaginaltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaginaltxt.Location = New System.Drawing.Point(450, 278)
        Me.vaginaltxt.Name = "vaginaltxt"
        Me.vaginaltxt.Size = New System.Drawing.Size(75, 20)
        Me.vaginaltxt.TabIndex = 22
        '
        'vaginalbtn
        '
        Me.vaginalbtn.Enabled = False
        Me.vaginalbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaginalbtn.Location = New System.Drawing.Point(450, 304)
        Me.vaginalbtn.Name = "vaginalbtn"
        Me.vaginalbtn.Size = New System.Drawing.Size(118, 39)
        Me.vaginalbtn.TabIndex = 23
        Me.vaginalbtn.Text = "TRANSVAGINAL"
        Me.vaginalbtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(323, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "CARDIOVASCULAR REQUEST"
        '
        'carbtn
        '
        Me.carbtn.Enabled = False
        Me.carbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carbtn.Location = New System.Drawing.Point(326, 398)
        Me.carbtn.Name = "carbtn"
        Me.carbtn.Size = New System.Drawing.Size(118, 39)
        Me.carbtn.TabIndex = 25
        Me.carbtn.Text = "ECG"
        Me.carbtn.UseVisualStyleBackColor = True
        '
        'finishbtn
        '
        Me.finishbtn.Enabled = False
        Me.finishbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finishbtn.Location = New System.Drawing.Point(326, 444)
        Me.finishbtn.Name = "finishbtn"
        Me.finishbtn.Size = New System.Drawing.Size(190, 39)
        Me.finishbtn.TabIndex = 26
        Me.finishbtn.Text = "FINISH REQUEST"
        Me.finishbtn.UseVisualStyleBackColor = True
        '
        'cardtxt
        '
        Me.cardtxt.Enabled = False
        Me.cardtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardtxt.Location = New System.Drawing.Point(326, 372)
        Me.cardtxt.Name = "cardtxt"
        Me.cardtxt.Size = New System.Drawing.Size(75, 20)
        Me.cardtxt.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(218, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 26)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(530, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "_"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(323, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "REQUESTING DOCTOR"
        '
        'doctortxt
        '
        Me.doctortxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.doctortxt.Enabled = False
        Me.doctortxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctortxt.Location = New System.Drawing.Point(326, 225)
        Me.doctortxt.Name = "doctortxt"
        Me.doctortxt.Size = New System.Drawing.Size(213, 20)
        Me.doctortxt.TabIndex = 32
        '
        'labidtxt
        '
        Me.labidtxt.Enabled = False
        Me.labidtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labidtxt.Location = New System.Drawing.Point(110, 136)
        Me.labidtxt.Name = "labidtxt"
        Me.labidtxt.Size = New System.Drawing.Size(75, 29)
        Me.labidtxt.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(107, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "REQUEST ID:"
        '
        'getlabrequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.labidtxt)
        Me.Controls.Add(Me.doctortxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cardtxt)
        Me.Controls.Add(Me.finishbtn)
        Me.Controls.Add(Me.carbtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.vaginalbtn)
        Me.Controls.Add(Me.vaginaltxt)
        Me.Controls.Add(Me.treebtn)
        Me.Controls.Add(Me.treetxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lipidprofilebtn)
        Me.Controls.Add(Me.lipidprofiletxt)
        Me.Controls.Add(Me.hbsagbtn)
        Me.Controls.Add(Me.fecalysisbtn)
        Me.Controls.Add(Me.fecalysistxt)
        Me.Controls.Add(Me.hbsagtxt)
        Me.Controls.Add(Me.urinalysisbtn)
        Me.Controls.Add(Me.urinalysistxt)
        Me.Controls.Add(Me.cbcbtn)
        Me.Controls.Add(Me.cbctxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gendertxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fullnametxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.labview)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "getlabrequest"
        Me.Text = "getlabrequest"
        CType(Me.labview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labview As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents fullnametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gendertxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents agetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbctxt As TextBox
    Friend WithEvents cbcbtn As Button
    Friend WithEvents urinalysistxt As TextBox
    Friend WithEvents urinalysisbtn As Button
    Friend WithEvents hbsagtxt As TextBox
    Friend WithEvents fecalysistxt As TextBox
    Friend WithEvents fecalysisbtn As Button
    Friend WithEvents hbsagbtn As Button
    Friend WithEvents lipidprofiletxt As TextBox
    Friend WithEvents lipidprofilebtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents treetxt As TextBox
    Friend WithEvents treebtn As Button
    Friend WithEvents vaginaltxt As TextBox
    Friend WithEvents vaginalbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents carbtn As Button
    Friend WithEvents finishbtn As Button
    Friend WithEvents cardtxt As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents doctortxt As TextBox
    Friend WithEvents labidtxt As TextBox
    Friend WithEvents Label8 As Label
End Class
