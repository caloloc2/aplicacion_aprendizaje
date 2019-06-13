Public Class matematicas4
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
                Button4.ForeColor = Color.SteelBlue
                Button5.ForeColor = Color.SteelBlue
            Case 2
                Button6.ForeColor = Color.SteelBlue
                Button7.ForeColor = Color.SteelBlue
                Button8.ForeColor = Color.SteelBlue
                Button9.ForeColor = Color.SteelBlue
                Button10.ForeColor = Color.SteelBlue
            Case 3
                Button11.ForeColor = Color.SteelBlue
                Button12.ForeColor = Color.SteelBlue
                Button13.ForeColor = Color.SteelBlue
                Button14.ForeColor = Color.SteelBlue
                Button15.ForeColor = Color.SteelBlue
            Case 4
                Button16.ForeColor = Color.SteelBlue
                Button17.ForeColor = Color.SteelBlue
                Button18.ForeColor = Color.SteelBlue
                Button19.ForeColor = Color.SteelBlue
                Button20.ForeColor = Color.SteelBlue
        End Select
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pintar(sender, 1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        calificacion += 1
        Pintar(sender, 1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Pintar(sender, 1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Pintar(sender, 1)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Pintar(sender, 2)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        calificacion += 1
        Pintar(sender, 2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Pintar(sender, 2)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Pintar(sender, 2)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Pintar(sender, 2)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Pintar(sender, 2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        calificacion += 1
        Pintar(sender, 2)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Pintar(sender, 3)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Pintar(sender, 3)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Pintar(sender, 3)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Pintar(sender, 3)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        calificacion += 1
        Pintar(sender, 3)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Pintar(sender, 3)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        calificacion += 1
        Pintar(sender, 3)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Pintar(sender, 4)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        calificacion += 1
        Pintar(sender, 4)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Pintar(sender, 4)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Pintar(sender, 4)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        calificacion += 1
        Pintar(sender, 4)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Pintar(sender, 4)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Pintar(sender, 4)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Dispose()
        Me.Close()
        Resultado.ShowDialog()
    End Sub
End Class