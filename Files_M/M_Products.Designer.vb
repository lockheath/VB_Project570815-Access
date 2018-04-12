<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Products
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Rb3 = New System.Windows.Forms.RadioButton()
        Me.Rb2 = New System.Windows.Forms.RadioButton()
        Me.Rb1 = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboS = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnPic = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 457)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(972, 247)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายการวัตถุมงคล"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(137, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(716, 166)
        Me.DataGridView1.TabIndex = 55
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "รหัสสินค้า"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 105
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column2.HeaderText = "ชื่อสินค้า"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 96
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column3.HeaderText = "ประเภทสินค้า"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 132
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column4.HeaderText = "รหัสผู้จัดจำหน่าย"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 155
        '
        'Column6
        '
        Me.Column6.HeaderText = "ราคา"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column5.HeaderText = "จำนวน"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 86
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.btnPic)
        Me.GroupBox1.Controls.Add(Me.PicBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtP)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Rb3)
        Me.GroupBox1.Controls.Add(Me.Rb2)
        Me.GroupBox1.Controls.Add(Me.Rb1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 300)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลสินค้าวัตถุมงคล"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(498, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 24)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "บาท"
        '
        'txtP
        '
        Me.txtP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtP.Location = New System.Drawing.Point(341, 253)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(134, 29)
        Me.txtP.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 24)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "ราคา"
        '
        'Rb3
        '
        Me.Rb3.AutoSize = True
        Me.Rb3.Location = New System.Drawing.Point(341, 173)
        Me.Rb3.Name = "Rb3"
        Me.Rb3.Size = New System.Drawing.Size(143, 28)
        Me.Rb3.TabIndex = 84
        Me.Rb3.TabStop = True
        Me.Rb3.Text = "เครื่องรางของขลัง"
        Me.Rb3.UseVisualStyleBackColor = True
        '
        'Rb2
        '
        Me.Rb2.AutoSize = True
        Me.Rb2.Location = New System.Drawing.Point(341, 139)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(97, 28)
        Me.Rb2.TabIndex = 83
        Me.Rb2.TabStop = True
        Me.Rb2.Text = "พระเครื่อง"
        Me.Rb2.UseVisualStyleBackColor = True
        '
        'Rb1
        '
        Me.Rb1.AutoSize = True
        Me.Rb1.Location = New System.Drawing.Point(341, 105)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(110, 28)
        Me.Rb1.TabIndex = 82
        Me.Rb1.TabStop = True
        Me.Rb1.Text = "พระพุทธรูป"
        Me.Rb1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(498, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 24)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "หน่วย"
        '
        'txtT
        '
        Me.txtT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtT.Location = New System.Drawing.Point(341, 205)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(134, 29)
        Me.txtT.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 24)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "จำนวนคงเหลือ"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(422, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 24)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "ชื่อสินค้า"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.Location = New System.Drawing.Point(499, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(210, 29)
        Me.txtName.TabIndex = 76
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtID.Location = New System.Drawing.Point(316, 51)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(98, 29)
        Me.txtID.TabIndex = 74
        Me.txtID.Text = "PM1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 24)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "รหัสสินค้าวัตถุมงคล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "ประเภทสินค้า"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.Location = New System.Drawing.Point(377, 382)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(98, 29)
        Me.TextBox2.TabIndex = 58
        Me.TextBox2.Text = "SM1"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "รหัสผู้จัดจำหน่าย"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "เบอร์โทร"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MaskedTextBox1.Location = New System.Drawing.Point(377, 464)
        Me.MaskedTextBox1.Mask = "(999) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(134, 29)
        Me.MaskedTextBox1.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 24)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "ชื่อ"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(377, 426)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 29)
        Me.TextBox1.TabIndex = 52
        '
        'Backtomainprogram
        '
        Me.Backtomainprogram.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Backtomainprogram.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backtomainprogram.Location = New System.Drawing.Point(31, 398)
        Me.Backtomainprogram.Name = "Backtomainprogram"
        Me.Backtomainprogram.Size = New System.Drawing.Size(175, 40)
        Me.Backtomainprogram.TabIndex = 38
        Me.Backtomainprogram.Text = "กลับสู่หน้าจอหลัก"
        Me.Backtomainprogram.UseVisualStyleBackColor = True
        '
        'lblShowPosition
        '
        Me.lblShowPosition.AutoSize = True
        Me.lblShowPosition.Location = New System.Drawing.Point(406, 208)
        Me.lblShowPosition.Name = "lblShowPosition"
        Me.lblShowPosition.Size = New System.Drawing.Size(48, 24)
        Me.lblShowPosition.TabIndex = 78
        Me.lblShowPosition.Text = " หน้า"
        '
        'btnMPre
        '
        Me.btnMPre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMPre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMPre.Location = New System.Drawing.Point(312, 200)
        Me.btnMPre.Name = "btnMPre"
        Me.btnMPre.Size = New System.Drawing.Size(86, 41)
        Me.btnMPre.TabIndex = 77
        Me.btnMPre.Text = "ก่อนหน้า"
        Me.btnMPre.UseVisualStyleBackColor = False
        '
        'btnMFirst
        '
        Me.btnMFirst.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMFirst.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMFirst.Location = New System.Drawing.Point(220, 200)
        Me.btnMFirst.Name = "btnMFirst"
        Me.btnMFirst.Size = New System.Drawing.Size(86, 41)
        Me.btnMFirst.TabIndex = 74
        Me.btnMFirst.Text = "หน้าสุด"
        Me.btnMFirst.UseVisualStyleBackColor = False
        '
        'btnMFin
        '
        Me.btnMFin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMFin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMFin.Location = New System.Drawing.Point(646, 200)
        Me.btnMFin.Name = "btnMFin"
        Me.btnMFin.Size = New System.Drawing.Size(86, 41)
        Me.btnMFin.TabIndex = 76
        Me.btnMFin.Text = "สุดท้าย"
        Me.btnMFin.UseVisualStyleBackColor = False
        '
        'btnMNext
        '
        Me.btnMNext.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMNext.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMNext.Location = New System.Drawing.Point(554, 200)
        Me.btnMNext.Name = "btnMNext"
        Me.btnMNext.Size = New System.Drawing.Size(86, 41)
        Me.btnMNext.TabIndex = 75
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
        Me.GroupBox5.Location = New System.Drawing.Point(232, 380)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(552, 73)
        Me.GroupBox5.TabIndex = 73
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ปรับแต่งข้อมูล"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(444, 28)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 41)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(142, 28)
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
        Me.btnDel.Location = New System.Drawing.Point(341, 28)
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
        Me.btnUpdate.Location = New System.Drawing.Point(243, 28)
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
        Me.btnAdd.Location = New System.Drawing.Point(40, 28)
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
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboS)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(957, 71)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาข้อมูลวัตถุมงคล"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(377, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 24)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "คำสำคัญ"
        '
        'cboS
        '
        Me.cboS.FormattingEnabled = True
        Me.cboS.Items.AddRange(New Object() {"รหัสวัตถุมงคล", "ชื่อวัตถุมงคล", "ประเภทวัตถุ"})
        Me.cboS.Location = New System.Drawing.Point(195, 28)
        Me.cboS.Name = "cboS"
        Me.cboS.Size = New System.Drawing.Size(133, 32)
        Me.cboS.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(640, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 24)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "กด Enter เพื่อค้นหา"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(454, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 29)
        Me.txtSearch.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(89, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 24)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "ค้นหาจาก"
        '
        'btnPic
        '
        Me.btnPic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPic.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPic.Location = New System.Drawing.Point(805, 226)
        Me.btnPic.Name = "btnPic"
        Me.btnPic.Size = New System.Drawing.Size(100, 42)
        Me.btnPic.TabIndex = 91
        Me.btnPic.Text = "เพิ่มรูปภาพ"
        Me.btnPic.UseVisualStyleBackColor = False
        '
        'PicBox
        '
        Me.PicBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicBox.Location = New System.Drawing.Point(769, 28)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(172, 192)
        Me.PicBox.TabIndex = 90
        Me.PicBox.TabStop = False
        '
        'M_Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Backtomainprogram)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "M_Products"
        Me.Text = "ระเบียนสินค้าวัตถุมงคล"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Rb3 As RadioButton
    Friend WithEvents Rb2 As RadioButton
    Friend WithEvents Rb1 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
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
    Friend WithEvents Label8 As Label
    Friend WithEvents cboS As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnPic As Button
    Friend WithEvents PicBox As PictureBox
End Class
