Public Class Resultado
    Private Sub Resultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = nombre_usuario
        Label2.Text = calificacion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
        Form1.Show()
    End Sub
End Class