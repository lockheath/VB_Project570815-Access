<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_Donater
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblShowPosition = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMPre = New System.Windows.Forms.Button()
        Me.btnMFirst = New System.Windows.Forms.Button()
        Me.btnMFin = New System.Windows.Forms.Button()
        Me.btnMNext = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Backtomainprogram = New System.Windows.Forms.Button()
        Me.cboS = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DB570815DataSet = New Project570815.DB570815DataSet()
        Me.MtblDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mtbl_DTableAdapter = New Project570815.DB570815DataSetTableAdapters.Mtbl_DTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DB570815DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MtblDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 205)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลผู้บริจาค"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(192, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(73, 29)
        Me.txtID.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 24)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "รหัสผู้บริจาค"
        '
        'txtPOST
        '
        Me.txtPOST.Location = New System.Drawing.Point(322, 161)
        Me.txtPOST.Mask = "00000"
        Me.txtPOST.Name = "txtPOST"
        Me.txtPOST.Size = New System.Drawing.Size(72, 29)
        Me.txtPOST.TabIndex = 20
        Me.txtPOST.ValidatingType = GetType(Integer)
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(502, 160)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(131, 29)
        Me.txtPhone.TabIndex = 19
        '
        'txtJunwa
        '
        Me.txtJunwa.Location = New System.Drawing.Point(322, 126)
        Me.txtJunwa.Name = "txtJunwa"
        Me.txtJunwa.Size = New System.Drawing.Size(194, 29)
        Me.txtJunwa.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "เบอร์โทร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(522, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "นามสกุล"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "รหัสไปรษณีย์"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(598, 35)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(194, 29)
        Me.txtLname.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "จังหวัด"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(322, 35)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(194, 29)
        Me.txtName.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ที่อยู่"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(321, 72)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(341, 48)
        Me.txtAdd.TabIndex = 16
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
        Me.GroupBox2.Location = New System.Drawing.Point(26, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(957, 71)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาข้อมูลผู้บริจาค"
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.lblShowPosition)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.btnMPre)
        Me.GroupBox3.Controls.Add(Me.btnMFirst)
        Me.GroupBox3.Controls.Add(Me.btnMFin)
        Me.GroupBox3.Controls.Add(Me.btnMNext)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(26, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(957, 289)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายการแสดงข้อมูลผู้บริจาค"
        '
        'lblShowPosition
        '
        Me.lblShowPosition.AutoSize = True
        Me.lblShowPosition.Location = New System.Drawing.Point(378, 236)
        Me.lblShowPosition.Name = "lblShowPosition"
        Me.lblShowPosition.Size = New System.Drawing.Size(48, 24)
        Me.lblShowPosition.TabIndex = 68
        Me.lblShowPosition.Text = " หน้า"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(87, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(748, 194)
        Me.DataGridView1.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัสผู้บริจาค"
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
        'btnMPre
        '
        Me.btnMPre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMPre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMPre.Location = New System.Drawing.Point(284, 228)
        Me.btnMPre.Name = "btnMPre"
        Me.btnMPre.Size = New System.Drawing.Size(86, 41)
        Me.btnMPre.TabIndex = 67
        Me.btnMPre.Text = "ก่อนหน้า"
        Me.btnMPre.UseVisualStyleBackColor = False
        '
        'btnMFirst
        '
        Me.btnMFirst.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMFirst.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMFirst.Location = New System.Drawing.Point(192, 228)
        Me.btnMFirst.Name = "btnMFirst"
        Me.btnMFirst.Size = New System.Drawing.Size(86, 41)
        Me.btnMFirst.TabIndex = 64
        Me.btnMFirst.Text = "หน้าสุด"
        Me.btnMFirst.UseVisualStyleBackColor = False
        '
        'btnMFin
        '
        Me.btnMFin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMFin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMFin.Location = New System.Drawing.Point(618, 228)
        Me.btnMFin.Name = "btnMFin"
        Me.btnMFin.Size = New System.Drawing.Size(86, 41)
        Me.btnMFin.TabIndex = 66
        Me.btnMFin.Text = "สุดท้าย"
        Me.btnMFin.UseVisualStyleBackColor = False
        '
        'btnMNext
        '
        Me.btnMNext.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMNext.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMNext.Location = New System.Drawing.Point(526, 228)
        Me.btnMNext.Name = "btnMNext"
        Me.btnMNext.Size = New System.Drawing.Size(86, 41)
        Me.btnMNext.TabIndex = 65
        Me.btnMNext.Text = "ถัดไป"
        Me.btnMNext.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.btnDel)
        Me.GroupBox4.Controls.Add(Me.btnUpdate)
        Me.GroupBox4.Controls.Add(Me.btnAdd)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(176, 309)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 72)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ปรับแต่งข้อมูล"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(425, 25)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 41)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(149, 25)
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
        Me.btnDel.Location = New System.Drawing.Point(333, 25)
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
        Me.btnUpdate.Location = New System.Drawing.Point(241, 25)
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
        Me.btnAdd.Location = New System.Drawing.Point(55, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 41)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Backtomainprogram
        '
        Me.Backtomainprogram.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Backtomainprogram.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backtomainprogram.Location = New System.Drawing.Point(755, 334)
        Me.Backtomainprogram.Name = "Backtomainprogram"
        Me.Backtomainprogram.Size = New System.Drawing.Size(175, 40)
        Me.Backtomainprogram.TabIndex = 71
        Me.Backtomainprogram.Text = "กลับสู่หน้าจอหลัก"
        Me.Backtomainprogram.UseVisualStyleBackColor = True
        '
        'cboS
        '
        Me.cboS.FormattingEnabled = True
        Me.cboS.Items.AddRange(New Object() {"รหัสผู้บริจาค", "ชื่อผู้บริจาค", "นามสกุล", "เบอร์ติดต่อ"})
        Me.cboS.Location = New System.Drawing.Point(195, 28)
        Me.cboS.Name = "cboS"
        Me.cboS.Size = New System.Drawing.Size(133, 32)
        Me.cboS.TabIndex = 50
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
        'DB570815DataSet
        '
        Me.DB570815DataSet.DataSetName = "DB570815DataSet"
        Me.DB570815DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MtblDBindingSource
        '
        Me.MtblDBindingSource.DataMember = "Mtbl_D"
        Me.MtblDBindingSource.DataSource = Me.DB570815DataSet
        '
        'Mtbl_DTableAdapter
        '
        Me.Mtbl_DTableAdapter.ClearBeforeFill = True
        '
        'M_Donater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Backtomainprogram)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "M_Donater"
        Me.Text = "ระเบียนข้อมูลผู้บริจาค"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DB570815DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MtblDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btnMPre As Button
    Friend WithEvents btnMFirst As Button
    Friend WithEvents btnMFin As Button
    Friend WithEvents btnMNext As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Backtomainprogram As Button
    Friend WithEvents lblShowPosition As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboS As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DB570815DataSet As DB570815DataSet
    Friend WithEvents MtblDBindingSource As BindingSource
    Friend WithEvents Mtbl_DTableAdapter As DB570815DataSetTableAdapters.Mtbl_DTableAdapter
End Class
