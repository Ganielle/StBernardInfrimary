<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nursequeue
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.q4 = New System.Windows.Forms.Label()
        Me.q3 = New System.Windows.Forms.Label()
        Me.q2 = New System.Windows.Forms.Label()
        Me.q1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.processtxt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fullnametxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(550, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(601, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'q4
        '
        Me.q4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q4.Location = New System.Drawing.Point(14, 231)
        Me.q4.Name = "q4"
        Me.q4.Size = New System.Drawing.Size(201, 49)
        Me.q4.TabIndex = 25
        Me.q4.Text = "QUEUE4"
        Me.q4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q3
        '
        Me.q3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q3.Location = New System.Drawing.Point(14, 182)
        Me.q3.Name = "q3"
        Me.q3.Size = New System.Drawing.Size(201, 49)
        Me.q3.TabIndex = 24
        Me.q3.Text = "QUEUE3"
        Me.q3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q2
        '
        Me.q2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q2.Location = New System.Drawing.Point(14, 133)
        Me.q2.Name = "q2"
        Me.q2.Size = New System.Drawing.Size(201, 49)
        Me.q2.TabIndex = 23
        Me.q2.Text = "QUEUE2"
        Me.q2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q1
        '
        Me.q1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q1.Location = New System.Drawing.Point(14, 84)
        Me.q1.Name = "q1"
        Me.q1.Size = New System.Drawing.Size(201, 49)
        Me.q1.TabIndex = 22
        Me.q1.Text = "QUEUE1"
        Me.q1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(14, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 49)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "ON QUEUE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(301, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 49)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ON PROCESS"
        '
        'processtxt
        '
        Me.processtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.processtxt.Location = New System.Drawing.Point(308, 108)
        Me.processtxt.Name = "processtxt"
        Me.processtxt.Size = New System.Drawing.Size(286, 147)
        Me.processtxt.TabIndex = 19
        Me.processtxt.Text = "queue"
        Me.processtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "FULL NAME:"
        '
        'fullnametxt
        '
        Me.fullnametxt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.fullnametxt.Enabled = False
        Me.fullnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnametxt.Location = New System.Drawing.Point(380, 258)
        Me.fullnametxt.Name = "fullnametxt"
        Me.fullnametxt.Size = New System.Drawing.Size(255, 30)
        Me.fullnametxt.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 51)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "DELETE ALL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nursequeue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 357)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.q4)
        Me.Controls.Add(Me.q3)
        Me.Controls.Add(Me.q2)
        Me.Controls.Add(Me.q1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.processtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fullnametxt)
        Me.Controls.Add(Me.Button1)
        Me.Name = "nursequeue"
        Me.Text = "nursequeue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents q4 As Label
    Friend WithEvents q3 As Label
    Friend WithEvents q2 As Label
    Friend WithEvents q1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents processtxt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fullnametxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
