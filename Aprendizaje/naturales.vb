Public Class naturales
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim resp1 As String = ComboBox1.Text
        Dim resp2 As String = ComboBox2.Text
        Dim resp3 As String = ComboBox3.Text
        Dim resp4 As String = ComboBox4.Text
        Dim resp5 As String = ComboBox5.Text

        If (resp1 = "Corteza") Then
            calificacion += 1
        End If

        If (resp2 = "Manto") Then
            calificacion += 1
        End If

        If (resp3 = "Núcleo") Then
            calificacion += 1
        End If

        If (resp4 = "Núcleo externo") Then
            calificacion += 1
        End If

        If (resp5 = "Núcleo interno") Then
            calificacion += 1
        End If

        Me.Dispose()
        Me.Close()
        naturales2.ShowDialog()
    End Sub
End Class