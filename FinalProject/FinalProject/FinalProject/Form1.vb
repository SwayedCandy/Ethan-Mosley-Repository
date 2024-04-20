Public Class Form1
    'When you click Ok it will bring you back to the main program
    Private Sub bntOk_Click(sender As Object, e As EventArgs) Handles bntOk.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class