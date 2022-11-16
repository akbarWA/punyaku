Public Class Form3

    Sub KOSONGKANFILELD()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Sub MATIKANFILELD()
        TextBox1.Text = False
        TextBox2.Text = False
        TextBox3.Text = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        End If
    End Sub
End Class