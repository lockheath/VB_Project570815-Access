Public Class T_import
    Private Sub T_import_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TC_import.Show()
    End Sub

    Private Sub Backtomainprogram_Click(sender As Object, e As EventArgs) Handles Backtomainprogram.Click
        Me.Close()
        Main_form.Show()
    End Sub
End Class