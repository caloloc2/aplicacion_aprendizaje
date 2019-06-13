Public Class matematicas3
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim respuesta1 As String = ComboBox1.Text
        Dim respuesta2 As String = ComboBox2.Text

        If (respuesta1 = "330 euros") Then
            calificacion += 1
        End If

        If (respuesta2 = "Entre 300 y 350 euros") Then
            calificacion += 1
        End If

        Me.Dispose()
        Me.Close()
        matematicas4.ShowDialog()
    End Sub
End Class