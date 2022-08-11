Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
        Button1.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Text = Val(TextBox4.Text) - Val(TextBox3.Text)
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.White
        Button2.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Black
        Button2.BackColor = Color.White
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label7.Text = Val(TextBox6.Text) * Val(TextBox5.Text)
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.White
        Button3.BackColor = Color.Black
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Black
        Button3.BackColor = Color.White
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label10.Text = Val(TextBox8.Text) / Val(TextBox7.Text)
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.ForeColor = Color.White
        Button4.BackColor = Color.Black
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.Black
        Button4.BackColor = Color.White
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Val(TextBox10.Text) > Val(TextBox9.Text) Then
            Label13.Text = "True"
        Else Label13.Text = "False"
        End If
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.White
        Button5.BackColor = Color.Black
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Black
        Button5.BackColor = Color.White
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Val(TextBox12.Text) < Val(TextBox11.Text) Then
            Label16.Text = "True"
        Else Label16.Text = "False"
        End If
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.White
        Button6.BackColor = Color.Black
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.Black
        Button6.BackColor = Color.White
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Val(TextBox14.Text) <> Val(TextBox13.Text) Then
            Label19.Text = "True"
        Else Label19.Text = "False"
        End If
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.White
        Button7.BackColor = Color.Black
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Black
        Button7.BackColor = Color.White
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Val(TextBox16.Text) = Val(TextBox15.Text) Then
            Label23.Text = "True"
        Else Label23.Text = "False"
        End If
    End Sub

    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        Button8.ForeColor = Color.White
        Button8.BackColor = Color.Black
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Button8.ForeColor = Color.Black
        Button8.BackColor = Color.White
    End Sub
End Class
