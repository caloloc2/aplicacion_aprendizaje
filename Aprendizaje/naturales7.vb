Public Class naturales7
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Pintar(sender As Object)
        Quitar_Todos()
        sender.ForeColor = Color.DarkOrange
    End Sub

    Private Sub Quitar_Todos()
        Button1.ForeColor = Color.SteelBlue
        Button2.ForeColor = Color.SteelBlue
        Button3.ForeColor = Color.SteelBlue
        Button4.ForeColor = Color.SteelBlue
        Button5.ForeColor = Color.SteelBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pintar(sender)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pintar(sender)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        calificacion += 1
        Pintar(sender)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pintar(sender)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Pintar(sender)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Dispose()
        Me.Close()
        naturales8.ShowDialog()
    End Sub
End Class