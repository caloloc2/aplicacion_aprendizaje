Public Class lenguaje
    Private Sub Pintar(sender As Object)
        Quitar_Todos()
        sender.ForeColor = Color.DarkOrange
    End Sub

    Private Sub Quitar_Todos()
        Button1.ForeColor = Color.SteelBlue
        Button2.ForeColor = Color.SteelBlue
        Button3.ForeColor = Color.SteelBlue
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

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub lenguaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Dispose()
        Me.Close()
        lenguaje2.ShowDialog()
    End Sub
End Class