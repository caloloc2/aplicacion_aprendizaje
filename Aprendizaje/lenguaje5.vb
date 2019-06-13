Public Class lenguaje5
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Seleccionar(sender As Object, bloque As Integer)
        Quitar_Todos(bloque)
        sender.Checked = True
    End Sub

    Private Sub Quitar_Todos(bloque)
        Select Case bloque
            Case 1
                CheckBox6.Checked = False
                CheckBox1.Checked = False
                CheckBox2.Checked = False
            Case 2
                CheckBox5.Checked = False
                CheckBox4.Checked = False
                CheckBox3.Checked = False
        End Select
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        calificacion += 1
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        calificacion += 1
        Seleccionar(sender, 2)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Dispose()
        Me.Close()
        lenguaje6.ShowDialog()
    End Sub
End Class