Public Class Rad_pg
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Pmt_pg.ShowDialog()

    End Sub

    Private Sub Rad_pg_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class