<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class queue
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
        Me.components = New System.ComponentModel.Container()
        Me.processtxt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.q1 = New System.Windows.Forms.Label()
        Me.q2 = New System.Windows.Forms.Label()
        Me.q3 = New System.Windows.Forms.Label()
        Me.q4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'processtxt
        '
        Me.processtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.processtxt.Location = New System.Drawing.Point(372, 146)
        Me.processtxt.Name = "processtxt"
        Me.processtxt.Size = New System.Drawing.Size(286, 147)
        Me.processtxt.TabIndex = 0
        Me.processtxt.Text = "queue"
        Me.processtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(365, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ON PROCESS"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(75, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 49)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ON QUEUE"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'q1
        '
        Me.q1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q1.Location = New System.Drawing.Point(75, 88)
        Me.q1.Name = "q1"
        Me.q1.Size = New System.Drawing.Size(201, 49)
        Me.q1.TabIndex = 3
        Me.q1.Text = "QUEUE1"
        Me.q1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q2
        '
        Me.q2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q2.Location = New System.Drawing.Point(75, 137)
        Me.q2.Name = "q2"
        Me.q2.Size = New System.Drawing.Size(201, 49)
        Me.q2.TabIndex = 4
        Me.q2.Text = "QUEUE2"
        Me.q2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q3
        '
        Me.q3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q3.Location = New System.Drawing.Point(75, 186)
        Me.q3.Name = "q3"
        Me.q3.Size = New System.Drawing.Size(201, 49)
        Me.q3.TabIndex = 5
        Me.q3.Text = "QUEUE3"
        Me.q3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q4
        '
        Me.q4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.q4.Location = New System.Drawing.Point(75, 235)
        Me.q4.Name = "q4"
        Me.q4.Size = New System.Drawing.Size(201, 49)
        Me.q4.TabIndex = 6
        Me.q4.Text = "QUEUE4"
        Me.q4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(606, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(657, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.q4)
        Me.Controls.Add(Me.q3)
        Me.Controls.Add(Me.q2)
        Me.Controls.Add(Me.q1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.processtxt)
        Me.Name = "queue"
        Me.Text = "QUEUE"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents processtxt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents q1 As Label
    Friend WithEvents q2 As Label
    Friend WithEvents q3 As Label
    Friend WithEvents q4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
