Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox6.Text = 0.5 * Val(TextBox4.Text) * Val(TextBox5.Text)
    End Sub
End Class