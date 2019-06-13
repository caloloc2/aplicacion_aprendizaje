Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombres As String = TextBox1.Text
        Dim materia As String = ComboBox1.Text

        If (nombres <> "") And (materia <> "") Then
            nombre_usuario = nombres
            calificacion = 0

            Select Case UCase(materia)
                Case "MATEMATICAS"
                    matematicas.ShowDialog()
                Case "LENGUAJE"
                    lenguaje.ShowDialog()
                Case "NATURALES"
                    naturales.ShowDialog()
            End Select
        Else
            MsgBox("Debe ingresar sus nombres y apellidos y escoger una materia.", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
