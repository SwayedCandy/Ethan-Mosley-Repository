'Name: Ethan Mosley
'Date: 7/7/2023
'Program Name: Rembrandt 
'Program Description: The program is used for a car dealership. The employees wither they are part or full time or used/new cars salesman.
'Enter their employee ID and the number sold and it is then put into the chart and will continue to add the total 
'amount of cars sold and by whom.
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Exit the program
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Decalring the variables
        Static intCarsSoldFullTime As Integer = 0
        Static intCarsSoldPartTime As Integer = 0
        Static intNewCarsSold As Integer = 0
        Static intUsedCarsSold As Integer = 0

        'get number total sold 
        Dim intNumberSold As Integer
        Integer.TryParse(txtNumberSold.Text, intNumberSold)

        'if number is not > 0 show error 
        If intNumberSold <= 0 Then
            MessageBox.Show(
                "Please enter number sold greater than 0.",
                "Input Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Exit Sub
        End If


        'If less Then than 5 characters are entered In the ID field, inform the user, Select the text, And make the text box the active control
        'If the Then 1St 3 characters are Not numbers, inform the user, Select the text, And make the text box the active control
        'If the Then 4th character Is Not an 'F' or a 'P', inform the user, make the text box the active control , and select the 4th character
        'If the Then 5th character Is Not an 'N' or a 'U', inform the user, make the text box the active control , and select the 5th character

        Dim strID As String = txtID.Text.ToUpper

        If Not strID Like "###[NU][FP]" Then
            MessageBox.Show(
                "Please enter a valid employee ID.",
                "Input Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Exit Sub
        End If

        'increment counters
        'look at 4th then determine if it was a new or used car that was sold
        If strID(3).ToString = "N" Then
            intNewCarsSold += intNumberSold
        ElseIf strID(3).ToString = "U" Then
            intUsedCarsSold += intNumberSold
        Else
            'If somehow user was able to break it program
            MessageBox.Show(
                "Error, Something wrong with new or used car employee.",
                "Input Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Exit Sub
        End If

        'look at 5th then determine if it was a full or part time employee
        If strID(4).ToString = "F" Then
            intCarsSoldFullTime += intNumberSold
        ElseIf strID(4).ToString = "P" Then
            intCarsSoldPartTime += intNumberSold
        Else
            'If somehow user was able to break it program
            MessageBox.Show(
                "Error, Something wrong with full or part time employee.",
                "Input Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Exit Sub
        End If

        'Update lbls
        lblSoldFullTime.Text = intCarsSoldFullTime.ToString("n0")
        lblSoldPartTime.Text = intCarsSoldPartTime.ToString("n0")

        lblSoldNewCar.Text = intNewCarsSold.ToString("n0")
        lblSoldUsedCar.Text = intUsedCarsSold.ToString("n0")

    End Sub
End Class


