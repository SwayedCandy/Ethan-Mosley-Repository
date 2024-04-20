'Name: Ethan Mosley
'Date: 6/14/2023
'Program Name: Filmore's Fast Food
'Program Description: This program is made to be an ordering tool for customers. It is to allow the customer to
'select what they would like or deselct and then check out.

Public Class frmMain

    'Defineing the class-level constants
    Private Const BURGERPRICE As Double = 5.99 'setting the burger price to $5.99
    Private Const FRIESPRICE As Double = 2.99 'setting the fries price to $2.99
    Private Const DRINKPRICE As Double = 1.99 'setting the drink price to $1.99
    Private Const CHEESEPRICE As Double = 0.5 'setting the cheese price to $0.50
    Private Const TOMATOPRICE As Double = 0.5 'setting the tomato price to $0.50
    Private Const PICKLEPRICE As Double = 0.5 'setting the pickle price to $0.50
    Private Const LETTUCEPRICE As Double = 0.5 'setting the lettuce price to $0.50
    Private Const TAXRATE As Double = 0.05 'setting the tax rate to 5%

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Exit the Program
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm() 'Button to clear the order form
    End Sub

    'Telling the button what needs to be cleared when the button is clicked
    Private Sub ClearForm()
        chkBurger.Checked = False 'Change burger check box to false
        chkFries.Checked = False 'Change fries check box to false
        chkDrink.Checked = False 'Change drink check box to false
        radCoke.Checked = False 'Change coke radio button to false
        radPepsi.Checked = False 'Change pepsi radio button to false
        radDrPepper.Checked = False 'Change dr pepper radio button to false
        radFanta.Checked = False 'Change Fanta radio button to false
        chkCheese.Checked = False 'Change cheese check box to false
        chkLettuce.Checked = False 'Change lettuce check box to false
        chkTomato.Checked = False 'Change tomato check box to false
        chkPickles.Checked = False 'Change pickles check box to false
        lblSubTotals.Text = "$0.00"
        lblTaxs.Text = "$0.00"
        lblTotalAmounts.Text = "$0.00"
    End Sub

    'Used to Calculate the SubTotal, Tax, and Total Amount
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim subtotal As Double = 0 'declaring the subtotal as a double

        'if burger is checked adds to subtotal
        If chkBurger.Checked Then
            subtotal += BURGERPRICE
        End If

        'if cheese is checked adds to subtotal
        If chkCheese.Checked Then
            subtotal += CHEESEPRICE
        End If

        'if tomato is checked adds to subtotal
        If chkTomato.Checked Then
            subtotal += TOMATOPRICE
        End If

        'if pickles is checked adds to the subtotal
        If chkPickles.Checked Then
            subtotal += PICKLEPRICE
        End If

        'if lettuce is checked adds to the subtotal
        If chkLettuce.Checked Then
            subtotal += LETTUCEPRICE
        End If

        'if fries is checked adds to the subtotal
        If chkFries.Checked Then
            subtotal += FRIESPRICE
        End If

        'if drink is checked adds to the subtotal
        If chkDrink.Checked Then
            subtotal += DRINKPRICE
        End If

        Dim tax As Double = subtotal * TAXRATE 'declaring the tax as a double and then finding the total tax amount
        Dim total As Double = subtotal + tax 'declaring the total as a double then finding the overall total

        lblSubTotals.Text = subtotal.ToString("C") 'print the subtotal
        lblTaxs.Text = tax.ToString("C") 'print the tax amount
        lblTotalAmounts.Text = total.ToString("C") 'print the totalamount
    End Sub
End Class

