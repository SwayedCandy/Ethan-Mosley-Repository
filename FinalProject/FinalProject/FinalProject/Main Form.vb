'Name: Ethan Mosley 
'Date: 8/01/2023 
'Program: Final Project - Shopping Cart 
'Description: This program was made to have a list of dvds and allow the user to select and add those dvds to a cart.
'When they add the dvds to the cart the program will then add the totals and then allow the user to edit their cart.

Imports System.IO ' Import the System.IO namespace for file operations.

Public Class frmMain
    Private dvdNames As New List(Of String) ' List to store DVD names.
    Private dvdPrices As New List(Of Double) ' List to store DVD prices.
    Private cartItems As New List(Of String) ' List to store DVDs added to the cart.

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDVDsFromFile("DVDs.txt") ' Load DVD data from the file.
        UpdateDVDListBox() ' Update the DVD list box with the loaded DVDs.
        UpdateCartListBox() ' Update the cart list box with the cart items.
        lstDVDs.HorizontalScrollbar = True ' Enable horizontal scrollbar for DVD list box.
        lstCart.HorizontalScrollbar = True ' Enable horizontal scrollbar for cart list box.
    End Sub

    ' Method to load DVD data from the specified file.
    Private Sub LoadDVDsFromFile(filePath As String)
        If File.Exists(filePath) Then ' Check if the file exists.
            Dim lines As String() = File.ReadAllLines(filePath) ' Read all lines from the file.
            For i As Integer = 0 To lines.Length - 2 Step 2 ' Process DVD names and prices in pairs.
                dvdNames.Add(lines(i)) ' Add the DVD name to the dvdNames list.
                Dim price As Double
                If Double.TryParse(lines(i + 1), price) Then
                    dvdPrices.Add(price) ' Use a separate list for DVD prices and add the parsed price here.
                Else
                    ' Display an error message and end the application if the price is not a valid number.
                    MessageBox.Show("Error: Invalid price format in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                End If
            Next
            ' Sort the DVDs in alphabetic ascending order.
            dvdNames.Sort()
        Else
            ' Display an error message and end the application if the file does not exist.
            MessageBox.Show("Error: DVDs file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
    End Sub

    ' Method to update the DVD list box with DVD names and prices.
    Private Sub UpdateDVDListBox()
        lstDVDs.Items.Clear() ' Clear the DVD list box.
        For i As Integer = 0 To dvdNames.Count - 1 ' Loop through all DVDs.
            Dim dvdItem As String = dvdNames(i).PadRight(20) & dvdPrices(i).ToString("C").PadLeft(8) ' Format the DVD name and price.
            lstDVDs.Items.Add(dvdItem) ' Add the formatted DVD entry to the DVD list box.
        Next
    End Sub

    ' Method to update the cart list box with cart items.
    Private Sub UpdateCartListBox()
        lstCart.Items.Clear() ' Clear the cart list box.
        For Each item In cartItems ' Loop through all cart items.
            lstCart.Items.Add(item) ' Add the cart item to the cart list box.
        Next
        UpdateOutputLabels() ' Update the output labels to reflect the changes in the cart.
    End Sub

    ' Method to update the output labels (subtotal, tax, shipping, and total).
    Private Sub UpdateOutputLabels()
        Dim subtotal As Double = 0 ' Initialize the subtotal variable to zero.
        For Each item In cartItems ' Loop through all cart items.
            Dim index As Integer = dvdNames.IndexOf(item) ' Get the index of the DVD in the dvdNames list.
            If index >= 0 AndAlso index < dvdPrices.Count Then ' Check if the index is valid.
                subtotal += dvdPrices(index) ' Add the DVD price to the subtotal.
            End If
        Next

        txtSubtotal.Text = subtotal.ToString("C") ' Display the subtotal in the corresponding label.
        txtTax.Text = (subtotal * 0.1).ToString("C") ' Calculate and display the tax in the corresponding label.
        txtShipping.Text = "Free" ' Display "Free" for shipping charge.
        txtTotal.Text = (subtotal * 1.1).ToString("C") ' Calculate and display the total in the corresponding label.
    End Sub

    ' Event handler for the "Add to Cart" button click.
    Private Sub ButtonAddToCart_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lstDVDs.SelectedIndex >= 0 Then ' Check if a DVD is selected in the DVD list.
            Dim selectedDVD As String = lstDVDs.SelectedItem.ToString().Substring(0, 20).Trim() ' Get the selected DVD name.
            If Not cartItems.Contains(selectedDVD) Then ' Check if the selected DVD is not already in the cart.
                cartItems.Add(selectedDVD) ' Add the selected DVD to the cartItems list.
                UpdateCartListBox() ' Update the cart list box to reflect the changes.
                lstDVDs.ClearSelected() ' Clear the selection in the DVD list box.
            Else
                MessageBox.Show("The selected DVD is already in the cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please select a DVD to add to the cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        UpdateOutputLabels() ' Update the output labels to reflect the changes in the cart.
    End Sub

    ' Event handler for the "Remove from Cart" button click.
    Private Sub ButtonRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstCart.SelectedIndex >= 0 Then ' Check if a DVD is selected in the cart list.
            Dim selectedDVD As String = lstCart.SelectedItem.ToString() ' Get the selected DVD name.
            cartItems.Remove(selectedDVD) ' Remove the selected DVD from the cartItems list.
            UpdateCartListBox() ' Update the cart list box to reflect the changes.
        Else
            MessageBox.Show("Please select a DVD to remove from the cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event handler for the "Clear Cart Selection" menu item click.
    Private Sub ClearCartSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCartSelectionToolStripMenuItem.Click
        cartItems.Clear() ' Clear all items from the cartItems list.
        UpdateCartListBox() ' Update the cart list box to reflect the changes.
        UpdateOutputLabels() ' Update the output labels to reflect the changes in the cart.
    End Sub

    ' Event handler for the "Clear DVD Selection" menu item click.
    Private Sub ClearDVDSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDVDSelectionToolStripMenuItem.Click
        lstDVDs.ClearSelected() ' Clear the selection in the DVD list box.
    End Sub

    ' Event handler for the "Clear Cart" menu item click.
    Private Sub ClearCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCartToolStripMenuItem.Click
        cartItems.Clear() ' Clear all items from the cartItems list.
        UpdateCartListBox() ' Update the cart list box to reflect the changes.
        UpdateOutputLabels() ' Update the output labels to reflect the changes in the cart.
    End Sub

    ' Event handler for the "Exit" menu item click.
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() ' Close the application.
    End Sub

    ' Event handler for the "Clear Cart" button click.
    Private Sub ButtonClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        cartItems.Clear() ' Clear all items from the cartItems list.
        UpdateCartListBox() ' Update the cart list box to reflect the changes.
        UpdateOutputLabels() ' Update the output labels to reflect the changes in the cart.
    End Sub

    ' Event handler for the "About" menu item click.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide() ' Hide the current MainForm.
        Form1.Show() ' Show the AboutBoxForm. Replace "Form1" with the actual name of the AboutBoxForm.
    End Sub
End Class

