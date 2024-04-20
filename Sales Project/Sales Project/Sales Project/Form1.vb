'Name: Ethan Mosley
'Date: 5/26/2023
'Project Name: Sales Project
'Description: The point of this program is to take the total amount of sales and then calculate the percentage 
'of each of the 3 sales people in relation to the total amount of sales.

Option Explicit On ' Require explicit declaration of variables
Option Strict On ' Enforce strict type checking
Option Infer Off ' Disable implicit variable typing

Public Class frmMain
    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Exit the program
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles btnCalculateSales.Click
        ' Declare variables to hold sales amounts for each salesperson
        Dim salesPerson1 As Double
        Dim salesPerson2 As Double
        Dim salesPerson3 As Double

        ' Parse sales amounts from text boxes
        Double.TryParse(txtBobSales.Text, salesPerson1)
        Double.TryParse(txtKarenSales.Text, salesPerson2)
        Double.TryParse(txtJoshSales.Text, salesPerson3)

        ' Calculate total sales
        Dim totalSales As Double = salesPerson1 + salesPerson2 + salesPerson3
        txtTotalSales.Text = totalSales.ToString("0.0")

        If totalSales <> 0 Then
            ' Calculate percentages of total sales for each salesperson
            Dim percentage1 As Double = (salesPerson1 / totalSales) * 100
            Dim percentage2 As Double = (salesPerson2 / totalSales) * 100
            Dim percentage3 As Double = (salesPerson3 / totalSales) * 100

            ' Display percentages with one decimal place and a percent sign
            txtBobPercent.Text = percentage1.ToString("0.0") & "%"
            txtKarenPercent.Text = percentage2.ToString("0.0") & "%"
            txtJoshPercent.Text = percentage3.ToString("0.0") & "%"
        Else
            ' Handle the case where total sales is zero (to avoid division by zero)
            txtBobPercent.Text = "0.0%"
            txtKarenPercent.Text = "0.0%"
            txtJoshPercent.Text = "0.0%"
        End If
    End Sub

    ' Restrict text boxes to accept only numbers, period, and Backspace key
    Private Sub txtBobSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBobSales.KeyPress, txtKarenSales.KeyPress, txtJoshSales.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class

