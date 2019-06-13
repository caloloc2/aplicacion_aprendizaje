Public Class lenguaje4
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim resp1 As String = ComboBox1.Text
        Dim resp2 As String = ComboBox2.Text
        Dim resp3 As String = ComboBox3.Text
        Dim resp4 As String = ComboBox4.Text


        If (resp1 = "El doctor") And (resp1 = "el enfermero") And (resp1 = "el bisturi, por favor") And (resp1 = "lenguaje verbal, hablado") Then
            calificacion += 1
        End If


        Dim resp5 As String = ComboBox5.Text
        Dim resp6 As String = ComboBox6.Text
        Dim resp7 As String = ComboBox7.Text
        Dim resp8 As String = ComboBox8.Text

        If (resp1 = "madre") And (resp1 = "hija") And (resp1 = "lo bien que se lo está pasando") And (resp1 = "lenguaje verbal, escrito") Then
            calificacion += 1
        End If

        Me.Dispose()
        Me.Close()
        lenguaje5.ShowDialog()
    End Sub
End Class