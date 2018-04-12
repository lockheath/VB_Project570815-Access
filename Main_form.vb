Public Class Main_form

    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub บรจาคToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles บรจาคToolStripMenuItem.Click
        T_Donate.Show()
    End Sub

    Private Sub นำเขาวตถมงคลToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles นำเขาวตถมงคลToolStripMenuItem.Click
        T_import.Show()
    End Sub

    Private Sub จำหนายวตถมงคลToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จำหนายวตถมงคลToolStripMenuItem.Click
        T_POS.Show()
    End Sub

    Private Sub ผบรจาคลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ผบรจาคลกคาToolStripMenuItem.Click
        M_Donater.Show()
    End Sub

    Private Sub สนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สนคาToolStripMenuItem.Click
        M_Products.Show()
    End Sub

    Private Sub มคนายกToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles มคนายกToolStripMenuItem.Click
        M_Emp.Show()
    End Sub

    Private Sub ขอมลวดToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ขอมลวดToolStripMenuItem1.Click
        About_Form.Show()
    End Sub
End Class