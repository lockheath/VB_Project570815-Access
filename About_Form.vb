Public Class About_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Main_form.Show()
    End Sub

    Private Sub Backtomainprogram_Click(sender As Object, e As EventArgs) Handles Backtomainprogram.Click
        Me.Close()
        Main_form.Show()
    End Sub
End Class