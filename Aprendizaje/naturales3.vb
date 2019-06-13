Public Class naturales3
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim res1 As String = ComboBox1.Text
        Dim res2 As String = ComboBox2.Text
        Dim res3 As String = ComboBox3.Text
        Dim res4 As String = ComboBox4.Text

        If res1 = "interna" Then
            calificacion += 1
        End If

        If res2 = "externa" Then
            calificacion += 1
        End If

        If res3 = "núcleo" Then
            calificacion += 1
        End If

        If res4 = "corteza" Then
            calificacion += 1
        End If

        Me.Dispose()
        Me.Close()
        naturales4.ShowDialog()
    End Sub
End Class