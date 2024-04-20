'Name: Ethan Mosley
'Date: 5/16/2023
'Program Name: Einstein's Equation
'Description: Program to show what equation Einstein is famous for.

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' End the application
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picEquation.Visible = True ' Display the equation
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        picEquation.Visible = False ' Stop displaying equation
    End Sub
End Class
