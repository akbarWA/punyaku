Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "AKBAR" And TextBox2.Text = "1234" Then
            MsgBox("login berhasil")
            Form2.Show()
            Me.Hide()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("user dan password belum teraisi")
                MsgBox("silakan isi user dan password")
            Else
                MsgBox("user dan password ada yang salah, silakan di perbaiki")

            End If


        End If
    End Sub
End Class
