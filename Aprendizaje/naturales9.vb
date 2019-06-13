Public Class naturales9
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim resp1 As String = ComboBox1.Text
        Dim resp2 As String = ComboBox2.Text
        Dim resp3 As String = ComboBox3.Text

        If (resp1 = "Gaseoso") Then
            calificacion += 1
        End If

        If (resp2 = "Sólido") Then
            calificacion += 1
        End If

        If (resp3 = "Líquido") Then
            calificacion += 1
        End If

        Me.Dispose()
        Me.Close()
        Resultado.ShowDialog()
    End Sub
End Class