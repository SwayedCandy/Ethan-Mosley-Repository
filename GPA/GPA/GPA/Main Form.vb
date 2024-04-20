Imports System.Globalization

Public Class frmMain
    Private countAll As Integer
    Private countFemale As Integer
    Private countMale As Integer
    Private totalAll As Double
    Private totalFemale As Double
    Private totalMale As Double

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For gpa As Double = 1.0 To 4.0 Step 0.1
            lstGpa.Items.Add(gpa.ToString("F1", CultureInfo.InvariantCulture))
        Next
        lstGpa.SelectedItem = "3.0"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gender As String = ""

        If radFemale.Checked Then
            gender = "Female"
        ElseIf radMale.Checked Then
            gender = "Male"
        End If

        Dim gpa As Double = Double.Parse(lstGpa.SelectedItem.ToString(), CultureInfo.InvariantCulture)

        countAll += 1
        totalAll += gpa

        If gender = "Female" Then
            countFemale += 1
            totalFemale += gpa
        ElseIf gender = "Male" Then
            countMale += 1
            totalMale += gpa
        End If

        txtAvgAll.Text = CalculateAverage(totalAll, countAll).ToString("F1", CultureInfo.InvariantCulture)
        txtAvgFemale.Text = CalculateAverage(totalFemale, countFemale).ToString("F1", CultureInfo.InvariantCulture)
        txtAvgMale.Text = CalculateAverage(totalMale, countMale).ToString("F1", CultureInfo.InvariantCulture)

        lstGpa.SelectedItem = "3.0"
    End Sub

    Private Function CalculateAverage(total As Double, count As Integer) As Double
        If count > 0 Then
            Return total / count
        Else
            Return 0.0
        End If
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

