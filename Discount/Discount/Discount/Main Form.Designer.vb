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
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.lblOriginalPrice = New System.Windows.Forms.Label()
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lstDiscountRates = New System.Windows.Forms.ListBox()
        Me.txtDiscountedPrice = New System.Windows.Forms.TextBox()
        Me.lblDiscountedPrice = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDiscountRates = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOriginalPrice
        '
        Me.txtOriginalPrice.Location = New System.Drawing.Point(12, 32)
        Me.txtOriginalPrice.Name = "txtOriginalPrice"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtOriginalPrice.TabIndex = 0
        Me.txtOriginalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOriginalPrice
        '
        Me.lblOriginalPrice.AutoSize = True
        Me.lblOriginalPrice.Location = New System.Drawing.Point(12, 14)
        Me.lblOriginalPrice.Name = "lblOriginalPrice"
        Me.lblOriginalPrice.Size = New System.Drawing.Size(81, 15)
        Me.lblOriginalPrice.TabIndex = 1
        Me.lblOriginalPrice.Text = "&Original Price:"
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.Location = New System.Drawing.Point(12, 128)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.Size = New System.Drawing.Size(100, 23)
        Me.txtDiscountAmount.TabIndex = 2
        Me.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.AutoSize = True
        Me.lblDiscountAmount.Location = New System.Drawing.Point(12, 110)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(57, 15)
        Me.lblDiscountAmount.TabIndex = 3
        Me.lblDiscountAmount.Text = "&Discount:"
        '
        'lstDiscountRates
        '
        Me.lstDiscountRates.FormattingEnabled = True
        Me.lstDiscountRates.ItemHeight = 15
        Me.lstDiscountRates.Location = New System.Drawing.Point(130, 27)
        Me.lstDiscountRates.Name = "lstDiscountRates"
        Me.lstDiscountRates.Size = New System.Drawing.Size(120, 109)
        Me.lstDiscountRates.TabIndex = 4
        '
        'txtDiscountedPrice
        '
        Me.txtDiscountedPrice.Location = New System.Drawing.Point(12, 172)
        Me.txtDiscountedPrice.Name = "txtDiscountedPrice"
        Me.txtDiscountedPrice.Size = New System.Drawing.Size(100, 23)
        Me.txtDiscountedPrice.TabIndex = 5
        Me.txtDiscountedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscountedPrice
        '
        Me.lblDiscountedPrice.AutoSize = True
        Me.lblDiscountedPrice.Location = New System.Drawing.Point(12, 154)
        Me.lblDiscountedPrice.Name = "lblDiscountedPrice"
        Me.lblDiscountedPrice.Size = New System.Drawing.Size(99, 15)
        Me.lblDiscountedPrice.TabIndex = 6
        Me.lblDiscountedPrice.Text = "D&iscounted Price:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 70)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(157, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDiscountRates
        '
        Me.lblDiscountRates.AutoSize = True
        Me.lblDiscountRates.Location = New System.Drawing.Point(127, 9)
        Me.lblDiscountRates.Name = "lblDiscountRates"
        Me.lblDiscountRates.Size = New System.Drawing.Size(88, 15)
        Me.lblDiscountRates.TabIndex = 9
        Me.lblDiscountRates.Text = "Di&scount Rates:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 208)
        Me.Controls.Add(Me.lblDiscountRates)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDiscountedPrice)
        Me.Controls.Add(Me.txtDiscountedPrice)
        Me.Controls.Add(Me.lstDiscountRates)
        Me.Controls.Add(Me.lblDiscountAmount)
        Me.Controls.Add(Me.txtDiscountAmount)
        Me.Controls.Add(Me.lblOriginalPrice)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents lblOriginalPrice As Label
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents lblDiscountAmount As Label
    Friend WithEvents lstDiscountRates As ListBox
    Friend WithEvents txtDiscountedPrice As TextBox
    Friend WithEvents lblDiscountedPrice As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDiscountRates As Label
End Class
