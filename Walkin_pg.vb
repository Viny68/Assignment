Public Class Walkin_pg
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Regis_pg.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main_pg.Show()
    End Sub

    Private Sub Walkin_pg_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()

    End Sub
End Class