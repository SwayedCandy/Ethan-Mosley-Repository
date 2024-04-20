<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.radCoke = New System.Windows.Forms.RadioButton()
        Me.radPepsi = New System.Windows.Forms.RadioButton()
        Me.radDrPepper = New System.Windows.Forms.RadioButton()
        Me.radFanta = New System.Windows.Forms.RadioButton()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grpMenuItems = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkPickles = New System.Windows.Forms.CheckBox()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.lblSubTotals = New System.Windows.Forms.Label()
        Me.lblTaxs = New System.Windows.Forms.Label()
        Me.lblTotalAmounts = New System.Windows.Forms.Label()
        Me.chkBurger = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkDrink = New System.Windows.Forms.CheckBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMenuItems.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(143, 15)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Filmore's Fast Food Menu"
        '
        'radCoke
        '
        Me.radCoke.AutoSize = True
        Me.radCoke.Location = New System.Drawing.Point(15, 96)
        Me.radCoke.Name = "radCoke"
        Me.radCoke.Size = New System.Drawing.Size(52, 19)
        Me.radCoke.TabIndex = 5
        Me.radCoke.Text = "Coke"
        Me.radCoke.UseVisualStyleBackColor = True
        '
        'radPepsi
        '
        Me.radPepsi.AutoSize = True
        Me.radPepsi.Location = New System.Drawing.Point(15, 121)
        Me.radPepsi.Name = "radPepsi"
        Me.radPepsi.Size = New System.Drawing.Size(53, 19)
        Me.radPepsi.TabIndex = 6
        Me.radPepsi.Text = "Pepsi"
        Me.radPepsi.UseVisualStyleBackColor = True
        '
        'radDrPepper
        '
        Me.radDrPepper.AutoSize = True
        Me.radDrPepper.Location = New System.Drawing.Point(15, 146)
        Me.radDrPepper.Name = "radDrPepper"
        Me.radDrPepper.Size = New System.Drawing.Size(77, 19)
        Me.radDrPepper.TabIndex = 7
        Me.radDrPepper.Text = "Dr Pepper"
        Me.radDrPepper.UseVisualStyleBackColor = True
        '
        'radFanta
        '
        Me.radFanta.AutoSize = True
        Me.radFanta.Location = New System.Drawing.Point(15, 171)
        Me.radFanta.Name = "radFanta"
        Me.radFanta.Size = New System.Drawing.Size(54, 19)
        Me.radFanta.TabIndex = 8
        Me.radFanta.Text = "Fanta"
        Me.radFanta.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Filmore_s_Fast_Food.My.Resources.Resources.fastfoodlogo1
        Me.picLogo.Location = New System.Drawing.Point(239, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(261, 228)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'grpMenuItems
        '
        Me.grpMenuItems.Controls.Add(Me.chkDrink)
        Me.grpMenuItems.Controls.Add(Me.chkFries)
        Me.grpMenuItems.Controls.Add(Me.chkBurger)
        Me.grpMenuItems.Controls.Add(Me.radDrPepper)
        Me.grpMenuItems.Controls.Add(Me.radFanta)
        Me.grpMenuItems.Controls.Add(Me.radPepsi)
        Me.grpMenuItems.Controls.Add(Me.radCoke)
        Me.grpMenuItems.Location = New System.Drawing.Point(15, 38)
        Me.grpMenuItems.Name = "grpMenuItems"
        Me.grpMenuItems.Size = New System.Drawing.Size(116, 199)
        Me.grpMenuItems.TabIndex = 9
        Me.grpMenuItems.TabStop = False
        Me.grpMenuItems.Text = "Main Menu"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(6, 81)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(64, 19)
        Me.chkCheese.TabIndex = 10
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(6, 156)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(65, 19)
        Me.chkLettuce.TabIndex = 11
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(6, 106)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(66, 19)
        Me.chkTomato.TabIndex = 12
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkPickles
        '
        Me.chkPickles.AutoSize = True
        Me.chkPickles.Location = New System.Drawing.Point(6, 131)
        Me.chkPickles.Name = "chkPickles"
        Me.chkPickles.Size = New System.Drawing.Size(62, 19)
        Me.chkPickles.TabIndex = 13
        Me.chkPickles.Text = "Pickles"
        Me.chkPickles.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkLettuce)
        Me.grpToppings.Controls.Add(Me.chkCheese)
        Me.grpToppings.Controls.Add(Me.chkPickles)
        Me.grpToppings.Controls.Add(Me.chkTomato)
        Me.grpToppings.Location = New System.Drawing.Point(137, 38)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(85, 199)
        Me.grpToppings.TabIndex = 14
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Burger Toppings *ALL TOPPINGS $0.50!*"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(12, 277)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(54, 15)
        Me.lblSubtotal.TabIndex = 15
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(134, 277)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(27, 15)
        Me.lblTax.TabIndex = 16
        Me.lblTax.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(222, 277)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 15)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total Amount:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(143, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "&Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(425, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(23, 243)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(84, 23)
        Me.btnFinish.TabIndex = 20
        Me.btnFinish.Text = "&Finish Order"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lblSubTotals
        '
        Me.lblSubTotals.AutoSize = True
        Me.lblSubTotals.Location = New System.Drawing.Point(66, 277)
        Me.lblSubTotals.Name = "lblSubTotals"
        Me.lblSubTotals.Size = New System.Drawing.Size(0, 15)
        Me.lblSubTotals.TabIndex = 21
        '
        'lblTaxs
        '
        Me.lblTaxs.AutoSize = True
        Me.lblTaxs.Location = New System.Drawing.Point(167, 277)
        Me.lblTaxs.Name = "lblTaxs"
        Me.lblTaxs.Size = New System.Drawing.Size(0, 15)
        Me.lblTaxs.TabIndex = 22
        '
        'lblTotalAmounts
        '
        Me.lblTotalAmounts.AutoSize = True
        Me.lblTotalAmounts.Location = New System.Drawing.Point(310, 277)
        Me.lblTotalAmounts.Name = "lblTotalAmounts"
        Me.lblTotalAmounts.Size = New System.Drawing.Size(0, 15)
        Me.lblTotalAmounts.TabIndex = 23
        '
        'chkBurger
        '
        Me.chkBurger.AutoSize = True
        Me.chkBurger.Location = New System.Drawing.Point(8, 21)
        Me.chkBurger.Name = "chkBurger"
        Me.chkBurger.Size = New System.Drawing.Size(99, 19)
        Me.chkBurger.TabIndex = 14
        Me.chkBurger.Text = "Burger - $5.99"
        Me.chkBurger.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(8, 46)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(88, 19)
        Me.chkFries.TabIndex = 15
        Me.chkFries.Text = "Fries - $2.99"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkDrink
        '
        Me.chkDrink.AutoSize = True
        Me.chkDrink.Location = New System.Drawing.Point(8, 71)
        Me.chkDrink.Name = "chkDrink"
        Me.chkDrink.Size = New System.Drawing.Size(92, 19)
        Me.chkDrink.TabIndex = 16
        Me.chkDrink.Text = "Drink - $1.99"
        Me.chkDrink.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 312)
        Me.Controls.Add(Me.lblTotalAmounts)
        Me.Controls.Add(Me.lblTaxs)
        Me.Controls.Add(Me.lblSubTotals)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpMenuItems)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filmore's Fast Food"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMenuItems.ResumeLayout(False)
        Me.grpMenuItems.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents radCoke As RadioButton
    Friend WithEvents radPepsi As RadioButton
    Friend WithEvents radDrPepper As RadioButton
    Friend WithEvents radFanta As RadioButton
    Friend WithEvents grpMenuItems As GroupBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents chkPickles As CheckBox
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents lblSubTotals As Label
    Friend WithEvents lblTaxs As Label
    Friend WithEvents lblTotalAmounts As Label
    Friend WithEvents chkBurger As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkDrink As CheckBox
End Class
