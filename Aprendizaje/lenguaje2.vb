Public Class lenguaje2
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Seleccionar(sender As Object, bloque As Integer)
        Quitar_Todos(bloque)
        sender.Checked = True
    End Sub

    Private Sub Quitar_Todos(bloque As Integer)
        Select Case bloque
            Case 1
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
            Case 2
                CheckBox7.Checked = False
                CheckBox8.Checked = False
                CheckBox9.Checked = False
                CheckBox10.Checked = False
                CheckBox11.Checked = False
                CheckBox12.Checked = False
            Case 3
                CheckBox13.Checked = False
                CheckBox14.Checked = False
                CheckBox15.Checked = False
                CheckBox16.Checked = False
                CheckBox17.Checked = False
                CheckBox18.Checked = False
            Case 4
                CheckBox19.Checked = False
                CheckBox20.Checked = False
                CheckBox21.Checked = False
                CheckBox22.Checked = False
                CheckBox23.Checked = False
                CheckBox24.Checked = False
        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        calificacion += 1
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        Seleccionar(sender, 1)
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged

    End Sub

    Private Sub CheckBox12_Click(sender As Object, e As EventArgs) Handles CheckBox12.Click
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged

    End Sub

    Private Sub CheckBox11_Click(sender As Object, e As EventArgs) Handles CheckBox11.Click
        calificacion += 1
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged

    End Sub

    Private Sub CheckBox10_Click(sender As Object, e As EventArgs) Handles CheckBox10.Click
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged

    End Sub

    Private Sub CheckBox9_Click(sender As Object, e As EventArgs) Handles CheckBox9.Click
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

    End Sub

    Private Sub CheckBox8_Click(sender As Object, e As EventArgs) Handles CheckBox8.Click
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

    End Sub

    Private Sub CheckBox7_Click(sender As Object, e As EventArgs) Handles CheckBox7.Click
        Seleccionar(sender, 2)
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged

    End Sub

    Private Sub CheckBox18_Click(sender As Object, e As EventArgs) Handles CheckBox18.Click
        calificacion += 1
        Seleccionar(sender, 3)
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged

    End Sub

    Private Sub CheckBox17_Click(sender As Object, e As EventArgs) Handles CheckBox17.Click
        Seleccionar(sender, 3)
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged

    End Sub

    Private Sub CheckBox16_Click(sender As Object, e As EventArgs) Handles CheckBox16.Click
        Seleccionar(sender, 3)
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged

    End Sub

    Private Sub CheckBox15_Click(sender As Object, e As EventArgs) Handles CheckBox15.Click
        Seleccionar(sender, 3)
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged

    End Sub

    Private Sub CheckBox14_Click(sender As Object, e As EventArgs) Handles CheckBox14.Click
        Seleccionar(sender, 3)
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged

    End Sub

    Private Sub CheckBox13_Click(sender As Object, e As EventArgs) Handles CheckBox13.Click
        Seleccionar(sender, 3)
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged

    End Sub

    Private Sub CheckBox24_Click(sender As Object, e As EventArgs) Handles CheckBox24.Click
        Seleccionar(sender, 4)
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged

    End Sub

    Private Sub CheckBox23_Click(sender As Object, e As EventArgs) Handles CheckBox23.Click
        Seleccionar(sender, 4)
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged

    End Sub

    Private Sub CheckBox22_Click(sender As Object, e As EventArgs) Handles CheckBox22.Click
        Seleccionar(sender, 4)
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged

    End Sub

    Private Sub CheckBox21_Click(sender As Object, e As EventArgs) Handles CheckBox21.Click
        Seleccionar(sender, 4)
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged

    End Sub

    Private Sub CheckBox20_Click(sender As Object, e As EventArgs) Handles CheckBox20.Click
        calificacion += 1
        Seleccionar(sender, 4)
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged

    End Sub

    Private Sub CheckBox19_Click(sender As Object, e As EventArgs) Handles CheckBox19.Click
        Seleccionar(sender, 4)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Dispose()
        Me.Close()
        lenguaje3.ShowDialog()
    End Sub
End Class