'Name: Ethan Mosley
'Date: 6/19/2023
'program: Discount
'Description: The point of this program is to be able to let the user enter in the 
'original price of an item. As well as the discount rate and that will then show the final price.

Public Class frmMain
    ' Class-level variables
    Private discountRates() As Decimal = {0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4}

    ' Form Load event handler
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the Discount list box with percentages
        For Each rate As Decimal In discountRates
            lstDiscountRates.Items.Add((rate * 100).ToString() & "%")
        Next

        ' Set default selected percent
        lstDiscountRates.SelectedIndex = 0
    End Sub

    ' Calculate button click event handler
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Clear previous outputs
        txtDiscountAmount.Text = ""
        txtDiscountedPrice.Text = ""

        ' Get input values
        Dim originalPrice As Decimal = Decimal.Parse(txtOriginalPrice.Text)
        Dim discountRate As Decimal = discountRates(lstDiscountRates.SelectedIndex)

        ' Calculate discount and discounted price
        Dim discountAmount As Decimal = originalPrice * discountRate
        Dim discountedPrice As Decimal = originalPrice - discountAmount

        ' Display results
        txtDiscountAmount.Text = discountAmount.ToString("C")
        txtDiscountedPrice.Text = discountedPrice.ToString("C")
    End Sub

    ' Input Text Box TextChanged event handler
    Private Sub txtOriginalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtOriginalPrice.TextChanged
        ' Clear outputs when input changes
        txtDiscountAmount.Text = ""
        txtDiscountedPrice.Text = ""
    End Sub

    ' Input Text Box Enter event handler
    Private Sub txtOriginalPrice_Enter(sender As Object, e As EventArgs) Handles txtOriginalPrice.Enter
        ' Select all existing text when tabbed to
        txtOriginalPrice.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the program
        Me.Close()
    End Sub
End Class
