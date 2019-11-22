<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashout
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
        Me.cashoutbtn = New System.Windows.Forms.Button()
        Me.changetxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cashtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.transidtxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cashoutbtn
        '
        Me.cashoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashoutbtn.Location = New System.Drawing.Point(27, 218)
        Me.cashoutbtn.Name = "cashoutbtn"
        Me.cashoutbtn.Size = New System.Drawing.Size(84, 41)
        Me.cashoutbtn.TabIndex = 13
        Me.cashoutbtn.Text = "CASHOUT"
        Me.cashoutbtn.UseVisualStyleBackColor = True
        '
        'changetxt
        '
        Me.changetxt.Enabled = False
        Me.changetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changetxt.Location = New System.Drawing.Point(142, 174)
        Me.changetxt.Name = "changetxt"
        Me.changetxt.Size = New System.Drawing.Size(93, 30)
        Me.changetxt.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CHANGE:"
        '
        'cashtxt
        '
        Me.cashtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashtxt.Location = New System.Drawing.Point(142, 138)
        Me.cashtxt.Name = "cashtxt"
        Me.cashtxt.Size = New System.Drawing.Size(93, 30)
        Me.cashtxt.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CASH:"
        '
        'totaltxt
        '
        Me.totaltxt.Enabled = False
        Me.totaltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltxt.Location = New System.Drawing.Point(143, 102)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(92, 30)
        Me.totaltxt.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TOTAL:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(136, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 41)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "₱"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "₱"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "₱"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 22)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "TRANS. ID:"
        '
        'transidtxt
        '
        Me.transidtxt.Enabled = False
        Me.transidtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transidtxt.Location = New System.Drawing.Point(124, 42)
        Me.transidtxt.Name = "transidtxt"
        Me.transidtxt.Size = New System.Drawing.Size(141, 27)
        Me.transidtxt.TabIndex = 19
        '
        'cashout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.transidtxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cashoutbtn)
        Me.Controls.Add(Me.changetxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cashtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totaltxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cashout"
        Me.Text = "cashout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cashoutbtn As Button
    Friend WithEvents changetxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cashtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents totaltxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents transidtxt As TextBox
End Class
