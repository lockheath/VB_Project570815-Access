Option Explicit On
Option Strict On 'case insen
Imports System.Data 'connect db
Imports System.Data.OleDb 'connect access



Public Class M_Products
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
        CurrentRecord = Me.BindingContext(ds, "Mtbl_P").Position + 1
        RecordCount = Me.BindingContext(ds, "Mtbl_P").Count
        lblShowPosition.Text = "รายการ: " & CurrentRecord & " /  " & RecordCount

        If CurrentRecord > 0 Then
            If Convert.ToString(dt.Rows(CurrentRecord - 1).Item("Mtbl_P")) = "พระพุทธรูป" Then
                Rb1.Checked = True
            ElseIf Convert.ToString(dt.Rows(CurrentRecord - 1).Item("Mtbl_P")) = "พระเครื่อง" Then
                Rb2.Checked = True
            ElseIf Convert.ToString(dt.Rows(CurrentRecord - 1).Item("Mtbl_P")) = "เครื่องรางวัตถุมงคล" Then
                Rb3.Checked = True

            End If
        End If
    End Sub

    Private Sub Backtomainprogram_Click(sender As Object, e As EventArgs) Handles Backtomainprogram.Click
        Me.Close()
        Main_form.Show()
    End Sub

    Private Sub M_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sqlMD = "SELECT * FROM Mtbl_P ORDER BY PID"
        da = New OleDbDataAdapter(sqlMD, Conn)
        da.Fill(ds, "Mtbl_P")

    End Sub

    Private Sub ClearAllBinding() 'clear binding
        txtID.DataBindings.Clear()
        txtName.DataBindings.Clear()
        txtT.DataBindings.Clear()
        txtP.DataBindings.Clear()
        PicBox.DataBindings.Clear()
    End Sub

    Private Sub ClearData() 'juct clear all text box
        txtID.Text = ""
        txtName.Text = ""
        txtT.DataBindings.Clear()
        txtP.DataBindings.Clear()
        PicBox.Image = Nothing
        PicBox.BackColor = Color.Empty
        PicBox.Invalidate()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If (e.KeyCode = Keys.Enter) Then 'IF Key.ENTER shall >>>

            Dim sqlMD As String = "SELECT * FROM Mtbl_P" 'make sqlMD to show SQL
            If cboS.SelectedIndex = 0 Then
                sqlMD &= " WHERE (PID LIKE'%" & txtSearch.Text & "%')"
            ElseIf cboS.SelectedIndex = 1 Then
                sqlMD &= " WHERE (PNAME LIKE'%" & txtSearch.Text & "%')"
            ElseIf cboS.SelectedIndex = 2 Then
                sqlMD &= " WHERE (PCAT LIKE'%" & txtSearch.Text & "%')"
            End If
            sqlMD &= "ORDER BY PID" 'sortby did


            With Conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConn
                .Open()
            End With


            If IsFind = True Then 'can find?
                ds.Tables("Mtbl_P").Clear() 'Clear dataset
            End If


            da.SelectCommand.CommandText = sqlMD
            da.Fill(ds, "Mtbl_P") 'new value go to DA >>> datatable type


            If ds.Tables("Mtbl_P").Rows.Count <> 0 Then 'if record not 0
                IsFind = True 'founddata
                ClearAllBinding()

                txtID.DataBindings.Add("Text", ds, "Mtbl_P.PID")
                txtName.DataBindings.Add("Text", ds, "Mtbl_P.PNAME")
                PicBox.DataBindings.Add(New Binding("image", ds, "Mtbl_P.PPIC"))
                dt = ds.Tables("Mtbl_E") 'move data to dt
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
    End Sub


    Private Sub btnMFirst_Click(sender As Object, e As EventArgs) Handles btnMFirst.Click
        Me.BindingContext(ds, "Mtbl_E").Position = 0 'moveto first record
        ShowPosition()
    End Sub

    Private Sub btnMPre_Click(sender As Object, e As EventArgs) Handles btnMPre.Click
        Me.BindingContext(ds, "Mtbl_E").Position -= 1
        ShowPosition()
    End Sub

    Private Sub btnMNext_Click(sender As Object, e As EventArgs) Handles btnMNext.Click
        Me.BindingContext(ds, "Mtbl_E").Position += 1
        ShowPosition()
    End Sub

    Private Sub btnMFin_Click(sender As Object, e As EventArgs) Handles btnMFin.Click
        Me.BindingContext(ds, "Mtbl_E").Position = ds.Tables("Mtbl_E").Rows.Count - 1 'we have +1 in past(that why we have first number is 1 not 0 
        ShowPosition()
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ActionFlag = "Add" 'we need to add 1 record
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        If IsFind = True Then
            ds.Tables("Mtbl_P").Clear()
        End If
        txtID.Focus() 'maybe txtName
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
        sqlDel = "Delete from Mtbl_P where PID = '" & txtID.Text & "'"
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


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sqlMD As String = ""
        Dim comMD As OleDbCommand = New OleDbCommand()
        Dim tmpMSG As String = ""

        If (txtID.Text = "") Or (txtName.Text = "") Or (txtT.Text = "") Or (txtP.Text = "") Then
            MessageBox.Show("กรุณาใส่ข้อมูลให้ครบด้วยครับ.", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus() 'maybe txtName
            Exit Sub
        End If

        Select Case ActionFlag
            Case "Add"

                sqlMD &= "INSERT INTO Mtbl_P"
                sqlMD &= "SET [PID] = '" & txtID.Text & "',"
                If Rb1.Checked = True Then
                    sqlMD &= "[PCAT]='พระพุทธรูป',"
                ElseIf Rb2.Checked = True Then
                    sqlMD &= "[PCAT]='พระเครื่อง',"
                ElseIf Rb3.Checked = True Then
                    sqlMD &= "[PCAT]='เครื่องรางวัตถุมงคล',"
                End If
                '   sqlMD &= "[PCAT]='" & combox.text & "',"
                sqlMD &= " [PPRICE]= '" & txtP.Text & "',"
                sqlMD &= " [PTOL]='" & txtT.Text & "')"



            Case "Update"
                sqlMD &= "UPDATE Mtbl_P"
                sqlMD &= "SET [PID] = '" & txtID.Text & "',"
                If Rb1.Checked = True Then
                    sqlMD &= "[PCAT]='พระพุทธรูป',"
                ElseIf Rb2.Checked = True Then
                    sqlMD &= "[PCAT]='พระเครื่อง',"
                ElseIf Rb3.Checked = True Then
                    sqlMD &= "[PCAT]='เครื่องรางวัตถุมงคล',"
                End If
                '   sqlMD &= "[PCAT]='" & combox.text & "',"
                sqlMD &= " [PPRICE]= '" & txtP.Text & "',"
                sqlMD &= " [PTOL]='" & txtT.Text & "')"



                sqlMD &= " WHERE (PID='" & txtID.Text & "')"
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


End Class