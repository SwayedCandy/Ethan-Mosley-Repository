'Name: Ethan Mosley
'Date: 5/26/2023
'Project Name: Grade
'Description: The point of this project is to get the total number of students who are passing and failing
'and find the perecentage of passing and failing.

Public Class Form1
    Private Sub extButton_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'For the exit button to end the application
    End Sub

    ' Grabs the number of students who pass and fail as integers
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim passCount As Integer
        Dim failCount As Integer

        ' Try parsing the input from txtPassCount.Text as an integer and store the result in passCount
        ' If the parsing succeeds, move to the next condition and attempt parsing the input from txtFailCount.Text
        If Integer.TryParse(txtPassCount.Text, passCount) AndAlso Integer.TryParse(txtFailCount.Text, failCount) Then
            Dim totalStudents As Integer = passCount + failCount ' Calculate the total number of students by summing the counts of passing and failing students

            Dim passPercentage As Double
            Dim failPercentage As Double

            ' Check if totalStudents is zero to avoid division by zero
            If totalStudents = 0 Then
                passPercentage = 0
                failPercentage = 0
            Else
                passPercentage = (passCount / totalStudents) * 100 ' Calculate the percentage of passing students
                failPercentage = (failCount / totalStudents) * 100 ' Calculate the percentage of failing students
            End If

            lblPassPercentage.Text = "Pass: " & passPercentage.ToString("N1") & "%" ' Display the pass percentage rounded to 1 decimal place in the PassPercentage Label
            lblFailPercentage.Text = "Fail: " & failPercentage.ToString("N1") & "%" ' Display the fail percentage rounded to 1 decimal place in the FailPercentage Label
        Else
            MessageBox.Show("Invalid input. Please enter valid numbers for pass and fail counts.") ' Show an error message if the parsing fails for either passCount or failCount
        End If
    End Sub

    ' Restrict text boxes to accept only numbers and Backspace key
    Private Sub txtPassCount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassCount.KeyPress, txtFailCount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class




