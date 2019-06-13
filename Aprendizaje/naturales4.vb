Public Class naturales4
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim res1 As String = ComboBox1.Text
        Dim res2 As String = ComboBox2.Text

        If res1 = "Aumente o disminuya la temperatura" Then
            calificacion += 1
        End If

        If res2 = "Fisico" Then
            calificacion += 1
        End If

        Me.Dispose()
        Me.Close()
        naturales5.ShowDialog()
    End Sub
End Class