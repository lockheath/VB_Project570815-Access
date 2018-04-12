Option Explicit On
Option Strict On 'case insen
Imports System.Data 'connect db
Imports System.Data.OleDb 'connect access


Public Class M_Donater
    Dim Conn As OleDbConnection = New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet = New DataSet
    Dim dt As DataTable
    Dim CurrentRecord As Integer = 0
    Dim RecordCount As Integer = 0
    Dim ActionFlag As String = ""
    Dim tmpFileName As String = ""
    Dim IsFind As Boolean = False
    Dim ToClose As Boolean = False
    Dim strConn As String = '"Provider = Microsoft.Ace.OleDb.12.0;AttachDbFilename=|DataDirectory|\DB570815.accdb;"
    "Provider = Microsoft.Ace.OleDb.12.0;Data Source = C:\PROJECT\Project570815+Access\DB570815.accdb;"


    Private Sub ShowPosition()
        CurrentRecord = Me.BindingContext(ds, "Mtbl_D").Position + 1
        RecordCount = Me.BindingContext(ds, "Mtbl_D").Count
        lblShowPosition.Text = "รายการ: " & CurrentRecord & " /  " & RecordCount
    End Sub




    Private Sub Backtomainprogram_Click(sender As Object, e As EventArgs) Handles Backtomainprogram.Click
        Me.Close()
        Main_form.Show()
    End Sub



    Private Sub M_Donater_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DB570815DataSet.Mtbl_D' table. You can move, or remove it, as needed.
        Me.Mtbl_DTableAdapter.Fill(Me.DB570815DataSet.Mtbl_D)

        txtSearch.Focus()
        cboS.SelectedIndex = 1

        btnMFirst.Enabled = False
        btnMPre.Enabled = False
        btnMNext.Enabled = False
        btnMFin.Enabled = False

        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnDel.Enabled = False
        btnCancel.Enabled = False

        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

        Dim sqlMD As String = ""
        sqlMD = "SELECT * FROM Mtbl_D ORDER BY DID"
        da = New OleDbDataAdapter(sqlMD, Conn)
        da.Fill(ds, "Mtbl_D")

    End Sub

    Private Sub ClearAllBinding() 'clear binding
        txtID.DataBindings.Clear()
        txtAdd.DataBindings.Clear()
        txtJunwa.DataBindings.Clear()
        txtLname.DataBindings.Clear()
        txtName.DataBindings.Clear()
        txtPhone.DataBindings.Clear()
        txtPOST.DataBindings.Clear()

    End Sub

    Private Sub ClearData() 'juct clear all text box
        txtID.Text = ""
        txtAdd.Text = ""
        txtJunwa.Text = ""
        txtLname.Text = ""
        txtName.Text = ""
        txtPhone.Text = ""
        txtPOST.Text = ""
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If txtSearch.Text <> "" Then
            If (e.KeyCode = Keys.Enter) Then 'IF Key.ENTER shall >>>

                Dim sqlMD As String = "SELECT * FROM Mtbl_D" 'make sqlMD to show SQL
                If cboS.SelectedIndex = 0 Then
                    sqlMD &= " WHERE (DID LIKE'%" & txtSearch.Text & "%')"
                ElseIf cboS.SelectedIndex = 1 Then
                    sqlMD &= " WHERE (DNAME LIKE'%" & txtSearch.Text & "%')"
                ElseIf cboS.SelectedIndex = 2 Then
                    sqlMD &= " WHERE (DLNAME LIKE'%" & txtSearch.Text & "%')"
                ElseIf cboS.SelectedIndex = 3 Then
                    sqlMD &= " WHERE (DPHONE LIKE'%" & txtSearch.Text & "%')"
                End If
                sqlMD &= "ORDER BY DID" 'sortby did


                With Conn
                    If .State = ConnectionState.Open Then .Close()
                    .ConnectionString = strConn
                    .Open()
                End With


                If IsFind = True Then 'can find?
                    ds.Tables("Mtbl_D").Clear() 'Clear dataset
                End If


                da.SelectCommand.CommandText = sqlMD
                da.Fill(ds, "Mtbl_D") 'new value go to DA >>> datatable type


                If ds.Tables("Mtbl_D").Rows.Count <> 0 Then 'if record not 0
                    IsFind = True 'founddata
                    ClearAllBinding()

                    txtID.DataBindings.Add("Text", ds, "Mtbl_D.DID")
                    txtAdd.DataBindings.Add("Text", ds, "Mtbl_D.DAAD")
                    txtJunwa.DataBindings.Add("Text", ds, "Mtbl_D.DJUNWA")
                    txtLname.DataBindings.Add("Text", ds, "Mtbl_D.DLNAME")
                    txtName.DataBindings.Add("Text", ds, "Mtbl_D.DNAME")
                    txtPhone.DataBindings.Add("Text", ds, "Mtbl_D.DPHONE")
                    txtPOST.DataBindings.Add("Text", ds, "Mtbl_D.DPOST")

                    dt = ds.Tables("Mtbl_D") 'move data to dt
                    ShowPosition()

                    btnMFirst.Enabled = True
                    btnMPre.Enabled = True
                    btnMNext.Enabled = True
                    btnMFin.Enabled = True

                    btnUpdate.Enabled = True
                    btnDel.Enabled = True

                Else
                    IsFind = False 'where cant see
                    MessageBox.Show("ไม่มีผู้บริจาคในระบบ", "ผลการค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearData()
                    lblShowPosition.Text = ""

                    btnMFirst.Enabled = False
                    btnMPre.Enabled = False
                    btnMNext.Enabled = False
                    btnMFin.Enabled = False

                    txtSearch.Focus()
                    txtSearch.SelectAll()
                    Exit Sub
                End If

            End If
        End If
    End Sub

    Private Sub btnMFirst_Click(sender As Object, e As EventArgs) Handles btnMFirst.Click
        Me.BindingContext(ds, "Mtbl_D").Position = 0 'moveto first record
        ShowPosition()
    End Sub

    Private Sub btnMPre_Click(sender As Object, e As EventArgs) Handles btnMPre.Click
        Me.BindingContext(ds, "Mtbl_D").Position -= 1
        ShowPosition()
    End Sub

    Private Sub btnMNext_Click(sender As Object, e As EventArgs) Handles btnMNext.Click
        Me.BindingContext(ds, "Mtbl_D").Position += 1
        ShowPosition()
    End Sub

    Private Sub btnMFin_Click(sender As Object, e As EventArgs) Handles btnMFin.Click
        Me.BindingContext(ds, "Mtbl_D").Position = ds.Tables("Mtbl_D").Rows.Count - 1 'we have +1 in past(that why we have first number is 1 not 0 
        ShowPosition()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ActionFlag = "Add" 'we need to add 1 record
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        If IsFind = True Then
            ds.Tables("Mtbl_D").Clear()
        End If
        txtID.Focus() 'maybe txtName
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sqlMD As String = ""
        Dim comMD As OleDbCommand = New OleDbCommand()
        Dim tmpMSG As String = ""

        If (txtID.Text = "") Or (txtName.Text = "") Or (txtPhone.Text = "") Then
            MessageBox.Show("กรุณาใส่ข้อมูล รหัส, ชื่อผู้บริจาค และเบอร์ติดต่อ ด้วยครับ.", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus() 'maybe txtName
            Exit Sub
        End If

        Select Case ActionFlag
            Case "Add"
                sqlMD = "INSERT INTO Mtbl_D([DID],[DNAME],[DLNAME],[DAAD],[DJUNWA],[DPOST],[DPHONE])"
                sqlMD &= " VALUES('" & txtID.Text & "','" & txtName.Text & "','"
                sqlMD &= "'" & txtAdd.Text & "','" & txtJunwa.Text & "','" & txtPOST.Text & "','" & txtPhone.Text & "')"

            Case "Update"
                sqlMD = "UPDATE INTO Mtbl_D([DID],[DNAME],[DLNAME],[DAAD],[DJUNWA],[DPOST],[DPHONE])"
                sqlMD &= " VALUES('" & txtID.Text & "','" & txtName.Text & "','"
                sqlMD &= "'" & txtAdd.Text & "','" & txtJunwa.Text & "','" & txtPOST.Text & "','" & txtPhone.Text & "')"

                sqlMD &= " WHERE (DID='" & txtID.Text & "')"
        End Select
        MessageBox.Show(sqlMD)

        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

        If ActionFlag = "Add" Then
            tmpMSG = "เพิ่ม ข้อมูล ?"
        ElseIf ActionFlag = "Update" Then
            tmpMSG = "แก้ไข ข้อมูล ?"
        End If

        If MessageBox.Show(tmpMSG, "ตรวจสอบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            With comMD
                .CommandType = CommandType.Text
                .CommandText = sqlMD
                .Connection = Conn
                .ExecuteNonQuery()
            End With
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "สถานะข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        btnAdd.Enabled = True
        btnUpdate.Enabled = False

        ClearData()
        txtID.ReadOnly = False

        btnMFirst.Enabled = False
        btnMPre.Enabled = False
        btnMNext.Enabled = False
        btnMFin.Enabled = False

        lblShowPosition.Text = "'"
        txtSearch.Text = "'"
        txtSearch.Focus()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ActionFlag = "Update" 'we shall update
        txtID.ReadOnly = True

        btnUpdate.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        txtName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        txtID.ReadOnly = False

        btnMFirst.Enabled = False
        btnMPre.Enabled = False
        btnMNext.Enabled = False
        btnMFin.Enabled = False

        lblShowPosition.Text = ""
        txtSearch.Focus()
        txtSearch.Select()

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim sqlDel As String
        Dim comMD As OleDbCommand = New OleDbCommand()
        Dim tmpMSG As String = ""
        sqlDel = "Delete from Mtbl_D where DID = '" & txtID.Text & "'"
        MessageBox.Show(sqlDel)

        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

        tmpMSG = "ต้องการ ลบ ข้อมูล ?"
        If MessageBox.Show(tmpMSG, "ตรวจสอบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            With comMD
                .CommandType = CommandType.Text
                .CommandText = sqlDel
                .Connection = Conn
                .ExecuteNonQuery()
            End With
            MessageBox.Show("ลบข้อมูลเรียบร้อย", "สถานะข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ShowPosition()
    End Sub


End Class