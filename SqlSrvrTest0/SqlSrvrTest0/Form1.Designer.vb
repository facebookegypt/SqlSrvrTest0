<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClrBtn = New System.Windows.Forms.Button()
        Me.NmTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SavBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.FindBtn = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FndBtn1 = New System.Windows.Forms.Button()
        Me.DelBtn1 = New System.Windows.Forms.Button()
        Me.EditBtn1 = New System.Windows.Forms.Button()
        Me.SavBtn1 = New System.Windows.Forms.Button()
        Me.ClrBtn1 = New System.Windows.Forms.Button()
        Me.DeTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PwdTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UsrTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Name"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'ClrBtn
        '
        Me.ClrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClrBtn.Location = New System.Drawing.Point(15, 63)
        Me.ClrBtn.Name = "ClrBtn"
        Me.ClrBtn.Size = New System.Drawing.Size(75, 28)
        Me.ClrBtn.TabIndex = 2
        Me.ClrBtn.Text = "Clear"
        Me.ClrBtn.UseCompatibleTextRendering = True
        Me.ClrBtn.UseVisualStyleBackColor = True
        '
        'NmTxt
        '
        Me.NmTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NmTxt.Location = New System.Drawing.Point(15, 29)
        Me.NmTxt.Name = "NmTxt"
        Me.NmTxt.Size = New System.Drawing.Size(361, 28)
        Me.NmTxt.TabIndex = 3
        Me.NmTxt.WordWrap = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Accounts"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'SavBtn
        '
        Me.SavBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavBtn.Location = New System.Drawing.Point(96, 63)
        Me.SavBtn.Name = "SavBtn"
        Me.SavBtn.Size = New System.Drawing.Size(75, 28)
        Me.SavBtn.TabIndex = 6
        Me.SavBtn.Text = "Save"
        Me.SavBtn.UseCompatibleTextRendering = True
        Me.SavBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Location = New System.Drawing.Point(258, 63)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(75, 28)
        Me.EditBtn.TabIndex = 7
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseCompatibleTextRendering = True
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.Location = New System.Drawing.Point(339, 63)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 28)
        Me.DelBtn.TabIndex = 8
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseCompatibleTextRendering = True
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Location = New System.Drawing.Point(421, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(238, 510)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'FindBtn
        '
        Me.FindBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindBtn.Location = New System.Drawing.Point(177, 63)
        Me.FindBtn.Name = "FindBtn"
        Me.FindBtn.Size = New System.Drawing.Size(75, 28)
        Me.FindBtn.TabIndex = 10
        Me.FindBtn.Text = "Find"
        Me.FindBtn.UseCompatibleTextRendering = True
        Me.FindBtn.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 542)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(671, 25)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Global.SqlSrvrTest0.My.Resources.Resources.Clipboard
        Me.PictureBox1.Image = Global.SqlSrvrTest0.My.Resources.Resources.Clipboard
        Me.PictureBox1.InitialImage = Global.SqlSrvrTest0.My.Resources.Resources.Clipboard
        Me.PictureBox1.Location = New System.Drawing.Point(382, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Icon"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SqlSrvrTest0.My.Resources.Resources.Refresh
        Me.PictureBox2.Location = New System.Drawing.Point(490, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.FndBtn1)
        Me.GroupBox1.Controls.Add(Me.DelBtn1)
        Me.GroupBox1.Controls.Add(Me.EditBtn1)
        Me.GroupBox1.Controls.Add(Me.SavBtn1)
        Me.GroupBox1.Controls.Add(Me.ClrBtn1)
        Me.GroupBox1.Controls.Add(Me.DeTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PwdTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.UsrTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 442)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logins"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 130)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "All Logins"
        Me.GroupBox2.UseCompatibleTextRendering = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(382, 24)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 29
        '
        'FndBtn1
        '
        Me.FndBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FndBtn1.Location = New System.Drawing.Point(162, 408)
        Me.FndBtn1.Name = "FndBtn1"
        Me.FndBtn1.Size = New System.Drawing.Size(75, 28)
        Me.FndBtn1.TabIndex = 28
        Me.FndBtn1.Text = "Find"
        Me.FndBtn1.UseCompatibleTextRendering = True
        Me.FndBtn1.UseVisualStyleBackColor = True
        '
        'DelBtn1
        '
        Me.DelBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn1.Location = New System.Drawing.Point(324, 408)
        Me.DelBtn1.Name = "DelBtn1"
        Me.DelBtn1.Size = New System.Drawing.Size(75, 28)
        Me.DelBtn1.TabIndex = 27
        Me.DelBtn1.Text = "Delete"
        Me.DelBtn1.UseCompatibleTextRendering = True
        Me.DelBtn1.UseVisualStyleBackColor = True
        '
        'EditBtn1
        '
        Me.EditBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn1.Location = New System.Drawing.Point(243, 408)
        Me.EditBtn1.Name = "EditBtn1"
        Me.EditBtn1.Size = New System.Drawing.Size(75, 28)
        Me.EditBtn1.TabIndex = 26
        Me.EditBtn1.Text = "Edit"
        Me.EditBtn1.UseCompatibleTextRendering = True
        Me.EditBtn1.UseVisualStyleBackColor = True
        '
        'SavBtn1
        '
        Me.SavBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavBtn1.Location = New System.Drawing.Point(81, 408)
        Me.SavBtn1.Name = "SavBtn1"
        Me.SavBtn1.Size = New System.Drawing.Size(75, 28)
        Me.SavBtn1.TabIndex = 25
        Me.SavBtn1.Text = "Save"
        Me.SavBtn1.UseCompatibleTextRendering = True
        Me.SavBtn1.UseVisualStyleBackColor = True
        '
        'ClrBtn1
        '
        Me.ClrBtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClrBtn1.Location = New System.Drawing.Point(0, 408)
        Me.ClrBtn1.Name = "ClrBtn1"
        Me.ClrBtn1.Size = New System.Drawing.Size(75, 28)
        Me.ClrBtn1.TabIndex = 24
        Me.ClrBtn1.Text = "Clear"
        Me.ClrBtn1.UseCompatibleTextRendering = True
        Me.ClrBtn1.UseVisualStyleBackColor = True
        '
        'DeTxt
        '
        Me.DeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeTxt.Location = New System.Drawing.Point(6, 282)
        Me.DeTxt.Multiline = True
        Me.DeTxt.Name = "DeTxt"
        Me.DeTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DeTxt.Size = New System.Drawing.Size(388, 120)
        Me.DeTxt.TabIndex = 23
        Me.DeTxt.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Details"
        Me.Label6.UseCompatibleTextRendering = True
        '
        'PwdTxt
        '
        Me.PwdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PwdTxt.Location = New System.Drawing.Point(6, 228)
        Me.PwdTxt.Name = "PwdTxt"
        Me.PwdTxt.Size = New System.Drawing.Size(388, 28)
        Me.PwdTxt.TabIndex = 21
        Me.PwdTxt.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Password"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'UsrTxt
        '
        Me.UsrTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrTxt.Location = New System.Drawing.Point(6, 174)
        Me.UsrTxt.Name = "UsrTxt"
        Me.UsrTxt.Size = New System.Drawing.Size(388, 28)
        Me.UsrTxt.TabIndex = 19
        Me.UsrTxt.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "User Name"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 567)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.FindBtn)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.SavBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NmTxt)
        Me.Controls.Add(Me.ClrBtn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Accounts Vault"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ClrBtn As Button
    Friend WithEvents NmTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SavBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents FindBtn As Button
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UsrTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PwdTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DeTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FndBtn1 As Button
    Friend WithEvents DelBtn1 As Button
    Friend WithEvents EditBtn1 As Button
    Friend WithEvents SavBtn1 As Button
    Friend WithEvents ClrBtn1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
