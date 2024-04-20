'Name: Ethan Mosley
'Date: 5/20/2023
'Program Name: Jackets
'Description: This Project is used for creating a VB program to display different types of jackets.

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles showChart.Click
        picSizeChart.visible = True ' Display the size chart
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close() ' End the application
    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        picJacket.Image = My.Resources.BlackJacket ' Display the black jacket
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        picJacket.Image = My.Resources.BlueJacket ' Display the blue jacket
    End Sub

    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click
        picJacket.Image = My.Resources.BrownJacket ' Display the brown jacket
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        picJacket.Image = My.Resources.RedJacket ' Display the red jacket
    End Sub
End Class
