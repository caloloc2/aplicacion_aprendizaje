Public Class naturales5
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim res1 As String = ComboBox3.Text
        Dim res2 As String = ComboBox1.Text
        Dim res3 As String = ComboBox2.Text
        Dim res4 As String = ComboBox4.Text
        Dim res5 As String = ComboBox5.Text
        Dim res6 As String = ComboBox6.Text

        If res1 = "Quimicos" Then
            calificacion += 1
        End If

        If res2 = "Fisicos" Then
            calificacion += 1
        End If

        If res3 = "Quimicos" Then
            calificacion += 1
        End If

        If res4 = "Fisicos" Then
            calificacion += 1
        End If

        If res5 = "Quimicos" Then
            calificacion += 1
        End If

        If res6 = "Fisicos" Then
            calificacion += 1
        End If

        Me.Dispose()
        Me.Close()
        naturales6.ShowDialog()
    End Sub
End Class