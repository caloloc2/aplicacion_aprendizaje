Public Class matematicas2
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Pintar(sender As Object, bloque As Integer)
        Quitar_Todos(bloque)
        sender.ForeColor = Color.DarkOrange
    End Sub

    Private Sub Quitar_Todos(bloque As Integer)
        Select Case bloque
            Case 1
                Button1.ForeColor = Color.SteelBlue
                Button2.ForeColor = Color.SteelBlue
                Button3.ForeColor = Color.SteelBlue
            Case 2
                Button4.ForeColor = Color.SteelBlue
                Button5.ForeColor = Color.SteelBlue
                Button6.ForeColor = Color.SteelBlue
            Case 3
                Button7.ForeColor = Color.SteelBlue
                Button8.ForeColor = Color.SteelBlue
                Button9.ForeColor = Color.SteelBlue
            Case 4
                Button10.ForeColor = Color.SteelBlue
                Button11.ForeColor = Color.SteelBlue
                Button12.ForeColor = Color.SteelBlue
        End Select
    End Sub

    Private Sub matematicas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calificacion += 1
        Pintar(sender, 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pintar(sender, 1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pintar(sender, 1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Pintar(sender, 2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        calificacion += 1
        Pintar(sender, 2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pintar(sender, 2)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        calificacion += 1
        Pintar(sender, 3)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Pintar(sender, 3)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Pintar(sender, 3)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Pintar(sender, 4)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        calificacion += 1
        Pintar(sender, 4)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Pintar(sender, 4)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Dispose()
        Me.Close()
        matematicas3.ShowDialog()
    End Sub
End Class