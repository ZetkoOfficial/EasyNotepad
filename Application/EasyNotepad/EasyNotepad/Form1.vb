Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuickSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickSaveToolStripMenuItem.Click

        'QuickSave
        Dim text As String
        text = RichTextBox1.Text
        My.Settings.quickSaveLine = text


    End Sub

    Private Sub QuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickOpenToolStripMenuItem.Click

        'Quick open
        RichTextBox1.Text = My.Settings.quickSaveLine

    End Sub

    Private Sub QuickDeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickDeleteToolStripMenuItem.Click

        My.Settings.quickSaveLine = ""

    End Sub

    Private Sub CreditsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        MsgBox("Made by Zetko and Lovro")
    End Sub
End Class
