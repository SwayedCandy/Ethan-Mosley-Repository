'Name: Ethan Mosley
'Date: 6/28/2023
'Project: Cable Director
'Description: This program lets residentital customers and business customers order channels and connections. 
' It allowd the user to select what they need and then the program calculates their total due.
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate lstPremium with numbers from 0 to 20
        For i As Integer = 0 To 20
            lstPremium.Items.Add(i)
        Next

        ' Set the initial selected item in lstPremium
        lstPremium.SelectedIndex = 0

        ' Populate lstConnections with numbers from 0 to 100
        For i As Integer = 0 To 100
            lstConnections.Items.Add(i)
        Next

        ' Set the initial selected item in lstConnections
        lstConnections.SelectedIndex = 0
    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Verify if the user wants to close the application
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True ' Cancel the form closing event
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Check if the "Business" radio button is selected
        If radBusiness.Checked Then
            ' Check if no connection is selected
            If lstConnections.SelectedIndex = 0 Then
                MessageBox.Show("Please select at least one connection.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub ' Exit the event handler without performing further calculations
            End If
        End If

        ' Calculate and display the cable bill
        Dim totalDue As Double
        If radBusiness.Checked Then
            totalDue = CalculateBusinessBill()
        ElseIf radResidential.Checked Then
            totalDue = CalculateResidentialBill()
        End If

        lblTotalAmount.Text = totalDue.ToString("C")
    End Sub

    Private Function CalculateBusinessBill() As Double
        Const processingFee As Double = 16.5
        Const basicServiceFeeFirst10 As Double = 80
        Const basicServiceFeeAdditional As Double = 4
        Const premiumChannelFee As Double = 5

        Dim totalDue As Double = processingFee

        ' Calculate basic service fee
        Dim selectedConnections As Integer = lstConnections.SelectedIndex + 1 ' Add 1 to count the selected item itself
        Dim basicServiceFee As Double
        If selectedConnections > 10 Then
            basicServiceFee = basicServiceFeeFirst10 + (selectedConnections - 10) * basicServiceFeeAdditional
        Else
            basicServiceFee = basicServiceFeeFirst10
        End If
        totalDue += basicServiceFee

        ' Calculate premium channel fee
        Dim selectedPremiumChannels As Integer = lstPremium.SelectedIndex
        Dim premiumChannelCost As Double = selectedPremiumChannels * premiumChannelFee
        totalDue += premiumChannelCost

        ' Multiply premium channel cost by the selected connections
        totalDue += premiumChannelCost * selectedConnections

        Return totalDue
    End Function
    Private Function CalculateResidentialBill() As Double
        Const processingFee As Double = 4.5
        Const basicServiceFee As Double = 30
        Const premiumChannelFee As Double = 5

        Dim totalDue As Double = processingFee + basicServiceFee

        ' Calculate premium channel fee
        Dim selectedPremiumChannels As Integer = lstPremium.SelectedIndex + 1 ' Add 1 to count the selected item itself
        Dim premiumChannelCost As Double = selectedPremiumChannels * premiumChannelFee
        totalDue += premiumChannelCost

        Return totalDue
    End Function


    Private Sub ClearOutput()
        lblTotalAmount.Text = ""
    End Sub

    Private Sub lstPremium_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPremium.SelectedIndexChanged
        ClearOutput()
    End Sub

    Private Sub lstConnections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConnections.SelectedIndexChanged
        ClearOutput()
    End Sub

    Private Sub radBusiness_CheckedChanged(sender As Object, e As EventArgs) Handles radBusiness.CheckedChanged
        ClearOutput()
    End Sub

    Private Sub radResidential_CheckedChanged(sender As Object, e As EventArgs) Handles radResidential.CheckedChanged
        If radResidential.Checked Then
            lstConnections.Visible = False
            lblConnections.Visible = False
        Else
            lstConnections.Visible = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

