Public Class Form2
    Private Sub DATABARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATABARANGToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class