<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Q2 = New System.Windows.Forms.RadioButton()
        Me.Q1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.D1 = New System.Windows.Forms.TextBox()
        Me.D2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.M = New System.Windows.Forms.CheckBox()
        Me.Prefix1 = New System.Windows.Forms.TextBox()
        Me.Prefix2 = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.RadioButton()
        Me.U = New System.Windows.Forms.RadioButton()
        Me.A = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(82, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(82, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rarity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Q2
        '
        Me.Q2.AutoSize = True
        Me.Q2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q2.Location = New System.Drawing.Point(11, 29)
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(64, 24)
        Me.Q2.TabIndex = 1
        Me.Q2.TabStop = True
        Me.Q2.Text = "Two"
        Me.Q2.UseVisualStyleBackColor = True
        '
        'Q1
        '
        Me.Q1.AutoSize = True
        Me.Q1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q1.Location = New System.Drawing.Point(11, 3)
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(64, 24)
        Me.Q1.TabIndex = 0
        Me.Q1.TabStop = True
        Me.Q1.Text = "One"
        Me.Q1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        ' Me.Button1.BackgroundImage = Global.Item_Generator.My.Resources.Resources._180_50_Button
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Old English Text MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(42, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(299, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Item(s)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name1
        '
        Me.Name1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Name1.Location = New System.Drawing.Point(239, 135)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(248, 23)
        Me.Name1.TabIndex = 7
        Me.Name1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name2
        '
        Me.Name2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Name2.Location = New System.Drawing.Point(532, 135)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(248, 23)
        Me.Name2.TabIndex = 8
        Me.Name2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'D1
        '
        Me.D1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D1.Location = New System.Drawing.Point(239, 178)
        Me.D1.Multiline = True
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(248, 180)
        Me.D1.TabIndex = 9
        '
        'D2
        '
        Me.D2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.D2.Location = New System.Drawing.Point(532, 178)
        Me.D2.Multiline = True
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(248, 180)
        Me.D2.TabIndex = 10
        '
        'Button2
        '
        ' Me.Button2.BackgroundImage = Global.Item_Generator.My.Resources.Resources._180_50_Button
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Old English Text MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(42, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 50)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(65, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Chance at Modifier"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'M
        '
        Me.M.AutoSize = True
        Me.M.BackColor = System.Drawing.Color.Transparent
        Me.M.Location = New System.Drawing.Point(123, 379)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(18, 17)
        Me.M.TabIndex = 13
        Me.M.UseVisualStyleBackColor = False
        '
        'Prefix1
        '
        Me.Prefix1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Prefix1.Location = New System.Drawing.Point(239, 374)
        Me.Prefix1.Multiline = True
        Me.Prefix1.Name = "Prefix1"
        Me.Prefix1.Size = New System.Drawing.Size(248, 134)
        Me.Prefix1.TabIndex = 14
        '
        'Prefix2
        '
        Me.Prefix2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Prefix2.Location = New System.Drawing.Point(532, 374)
        Me.Prefix2.Multiline = True
        Me.Prefix2.Name = "Prefix2"
        Me.Prefix2.Size = New System.Drawing.Size(248, 134)
        Me.Prefix2.TabIndex = 15
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(11, 16)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(103, 24)
        Me.C.TabIndex = 0
        Me.C.TabStop = True
        Me.C.Text = "Common"
        Me.C.UseVisualStyleBackColor = True
        '
        'U
        '
        Me.U.AutoSize = True
        Me.U.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U.Location = New System.Drawing.Point(11, 43)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(123, 24)
        Me.U.TabIndex = 1
        Me.U.TabStop = True
        Me.U.Text = "Uncommon"
        Me.U.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.Location = New System.Drawing.Point(11, 70)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(92, 24)
        Me.A.TabIndex = 2
        Me.A.TabStop = True
        Me.A.Text = "Artifact"
        Me.A.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Q1)
        Me.Panel1.Controls.Add(Me.Q2)
        Me.Panel1.Location = New System.Drawing.Point(64, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(98, 64)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.C)
        Me.Panel2.Controls.Add(Me.U)
        Me.Panel2.Controls.Add(Me.A)
        Me.Panel2.Location = New System.Drawing.Point(64, 239)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 98)
        Me.Panel2.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ' Me.BackgroundImage = Global.Item_Generator.My.Resources.Resources.Map_of_Known_World
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 557)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Prefix2)
        Me.Controls.Add(Me.Prefix1)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.D2)
        Me.Controls.Add(Me.D1)
        Me.Controls.Add(Me.Name2)
        Me.Controls.Add(Me.Name1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Q2 As RadioButton
    Friend WithEvents Q1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Name1 As Label
    Friend WithEvents Name2 As Label
    Friend WithEvents D1 As TextBox
    Friend WithEvents D2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents M As CheckBox
    Friend WithEvents Prefix1 As TextBox
    Friend WithEvents Prefix2 As TextBox
    Friend WithEvents C As RadioButton
    Friend WithEvents U As RadioButton
    Friend WithEvents A As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
