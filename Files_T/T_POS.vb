Public Class T_POS
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        TCON_POS.Show()
    End Sub

    Private Sub Backtomainprogram_Click(sender As Object, e As EventArgs) Handles Backtomainprogram.Click
        Me.Close()
        Main_form.Show()
    End Sub
End Class