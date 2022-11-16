Public Class Form1
    Private Sub DIRIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIRIToolStripMenuItem.Click
        Form2.ShowDialog()

    End Sub

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ORANGTUAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORANGTUAToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub KALKULATORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KALKULATORToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BIODATAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BIODATAToolStripMenuItem.Click

    End Sub
End Class
