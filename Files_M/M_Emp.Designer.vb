<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Emp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPic = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Backtomainprogram = New System.Windows.Forms.Button()
        Me.lblShowPosition = New System.Windows.Forms.Label()
        Me.btnMPre = New System.Windows.Forms.Button()
        Me.btnMFirst = New System.Windows.Forms.Button()
        Me.btnMFin = New System.Windows.Forms.Button()
        Me.btnMNext = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboS = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPOST = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtJunwa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPOST)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtJunwa)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAdd)
        Me.GroupBox1.Controls.Add(Me.btnPic)
        Me.GroupBox1.Controls.Add(Me.PicBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 317)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลเจ้าหน้าที่"
        '
        'btnPic
        '
        Me.btnPic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPic.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPic.Location = New System.Drawing.Point(773, 221)
        Me.btnPic.Name = "btnPic"
        Me.btnPic.Size = New System.Drawing.Size(100, 42)
        Me.btnPic.TabIndex = 31
        Me.btnPic.Text = "เพิ่มรูปภาพ"
        Me.btnPic.UseVisualStyleBackColor = False
        '
        'PicBox
        '
        Me.PicBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicBox.Location = New System.Drawing.Point(737, 23)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(172, 192)
        Me.PicBox.TabIndex = 30
        Me.PicBox.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.lblShowPosition)
        Me.GroupBox3.Controls.Add(Me.btnMPre)
        Me.GroupBox3.Controls.Add(Me.btnMFirst)
        Me.GroupBox3.Controls.Add(Me.btnMFin)
        Me.GroupBox3.Controls.Add(Me.btnMNext)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 412)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(735, 299)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายการแสดงข้อมูลเจ้าหน้าที่"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 190)
        Me.DataGridView1.TabIndex = 55
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัสเจ้าหน้าที่"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อ"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "นามสกุล"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "ที่อยู่"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "จังหวัด"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "รหัสไปรษณีย์"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "เบอร์โทร"
        Me.Column7.Name = "Column7"
        '
        'Backtomainprogram
        '
        Me.Backtomainprogram.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Backtomainprogram.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backtomainprogram.Location = New System.Drawing.Point(795, 652)
        Me.Backtomainprogram.Name = "Backtomainprogram"
        Me.Backtomainprogram.Size = New System.Drawing.Size(175, 40)
        Me.Backtomainprogram.TabIndex = 42
        Me.Backtomainprogram.Text = "กลับสู่หน้าจอหลัก"
        Me.Backtomainprogram.UseVisualStyleBackColor = True
        '
        'lblShowPosition
        '
        Me.lblShowPosition.AutoSize = True
        Me.lblShowPosition.Location = New System.Drawing.Point(303, 248)
        Me.lblShowPosition.Name = "lblShowPosition"
        Me.lblShowPosition.Size = New System.Drawing.Size(48, 24)
        Me.lblShowPosition.TabIndex = 73
        Me.lblShowPosition.Text = " หน้า"
        '
        'btnMPre
        '
        Me.btnMPre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMPre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMPre.Location = New System.Drawing.Point(209, 240)
        Me.btnMPre.Name = "btnMPre"
        Me.btnMPre.Size = New System.Drawing.Size(86, 41)
        Me.btnMPre.TabIndex = 72
        Me.btnMPre.Text = "ก่อนหน้า"
        Me.btnMPre.UseVisualStyleBackColor = False
        '
        'btnMFirst
        '
        Me.btnMFirst.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMFirst.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMFirst.Location = New System.Drawing.Point(117, 240)
        Me.btnMFirst.Name = "btnMFirst"
        Me.btnMFirst.Size = New System.Drawing.Size(86, 41)
        Me.btnMFirst.TabIndex = 69
        Me.btnMFirst.Text = "หน้าสุด"
        Me.btnMFirst.UseVisualStyleBackColor = False
        '
        'btnMFin
        '
        Me.btnMFin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMFin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMFin.Location = New System.Drawing.Point(543, 240)
        Me.btnMFin.Name = "btnMFin"
        Me.btnMFin.Size = New System.Drawing.Size(86, 41)
        Me.btnMFin.TabIndex = 71
        Me.btnMFin.Text = "สุดท้าย"
        Me.btnMFin.UseVisualStyleBackColor = False
        '
        'btnMNext
        '
        Me.btnMNext.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMNext.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMNext.Location = New System.Drawing.Point(451, 240)
        Me.btnMNext.Name = "btnMNext"
        Me.btnMNext.Size = New System.Drawing.Size(86, 41)
        Me.btnMNext.TabIndex = 70
        Me.btnMNext.Text = "ถัดไป"
        Me.btnMNext.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.btnCancel)
        Me.GroupBox5.Controls.Add(Me.btnSave)
        Me.GroupBox5.Controls.Add(Me.btnDel)
        Me.GroupBox5.Controls.Add(Me.btnUpdate)
        Me.GroupBox5.Controls.Add(Me.btnAdd)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(753, 412)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(248, 223)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ปรับแต่งข้อมูล"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(32, 158)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(188, 41)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(134, 40)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 41)
        Me.btnSave.TabIndex = 63
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDel.Location = New System.Drawing.Point(134, 100)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(86, 41)
        Me.btnDel.TabIndex = 62
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(32, 100)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 41)
        Me.btnUpdate.TabIndex = 61
        Me.btnUpdate.Text = "แก้ไข"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(32, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 41)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cboS)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(957, 71)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาข้อมูลเจ้าหน้าที่"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(377, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 24)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "คำสำคัญ"
        '
        'cboS
        '
        Me.cboS.FormattingEnabled = True
        Me.cboS.Items.AddRange(New Object() {"รหัสเจ้าหน้าที่", "ชื่อเจ้าหน้าที่", "นามสกุล", "เบอร์ติดต่อ"})
        Me.cboS.Location = New System.Drawing.Point(195, 28)
        Me.cboS.Name = "cboS"
        Me.cboS.Size = New System.Drawing.Size(133, 32)
        Me.cboS.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(640, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 24)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "กด Enter เพื่อค้นหา"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(454, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 29)
        Me.txtSearch.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "ค้นหาจาก"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(216, 60)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(91, 29)
        Me.txtID.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 24)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "รหัสเจ้าหน้าที่"
        '
        'txtPOST
        '
        Me.txtPOST.Location = New System.Drawing.Point(215, 231)
        Me.txtPOST.Mask = "00000"
        Me.txtPOST.Name = "txtPOST"
        Me.txtPOST.Size = New System.Drawing.Size(72, 29)
        Me.txtPOST.TabIndex = 43
        Me.txtPOST.ValidatingType = GetType(Integer)
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(395, 230)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(131, 29)
        Me.txtPhone.TabIndex = 42
        '
        'txtJunwa
        '
        Me.txtJunwa.Location = New System.Drawing.Point(215, 196)
        Me.txtJunwa.Name = "txtJunwa"
        Me.txtJunwa.Size = New System.Drawing.Size(194, 29)
        Me.txtJunwa.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(319, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "เบอร์โทร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "นามสกุล"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "รหัสไปรษณีย์"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(491, 105)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(194, 29)
        Me.txtLname.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(141, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "จังหวัด"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(215, 105)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(194, 29)
        Me.txtName.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "ชื่อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 24)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "ที่อยู่"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(214, 142)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(341, 48)
        Me.txtAdd.TabIndex = 40
        '
        'M_Emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Backtomainprogram)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "M_Emp"
        Me.Text = "ระเบียนเจ้าหน้าที่"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPic As Button
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Backtomainprogram As Button
    Friend WithEvents lblShowPosition As Label
    Friend WithEvents btnMPre As Button
    Friend WithEvents btnMFirst As Button
    Friend WithEvents btnMFin As Button
    Friend WithEvents btnMNext As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboS As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPOST As MaskedTextBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtJunwa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdd As TextBox
End Class
