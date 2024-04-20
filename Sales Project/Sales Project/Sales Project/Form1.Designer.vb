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
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.lblBobSales = New System.Windows.Forms.Label()
        Me.txtBobSales = New System.Windows.Forms.TextBox()
        Me.lblKarenSales = New System.Windows.Forms.Label()
        Me.txtKarenSales = New System.Windows.Forms.TextBox()
        Me.lblJoshSales = New System.Windows.Forms.Label()
        Me.txtJoshSales = New System.Windows.Forms.TextBox()
        Me.btnCalculateSales = New System.Windows.Forms.Button()
        Me.lblBobPercent = New System.Windows.Forms.Label()
        Me.lblKarenPercent = New System.Windows.Forms.Label()
        Me.lblJoshPercent = New System.Windows.Forms.Label()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtBobPercent = New System.Windows.Forms.TextBox()
        Me.txtJoshPercent = New System.Windows.Forms.TextBox()
        Me.txtKarenPercent = New System.Windows.Forms.TextBox()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Location = New System.Drawing.Point(9, 100)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(113, 15)
        Me.lblTotalSales.TabIndex = 0
        Me.lblTotalSales.Text = "Total Amount of Sales"
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(139, 97)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSales.TabIndex = 1
        Me.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBobSales
        '
        Me.lblBobSales.AutoSize = True
        Me.lblBobSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBobSales.Location = New System.Drawing.Point(9, 10)
        Me.lblBobSales.Name = "lblBobSales"
        Me.lblBobSales.Size = New System.Drawing.Size(96, 15)
        Me.lblBobSales.TabIndex = 2
        Me.lblBobSales.Text = "Bob Sales Amount"
        '
        'txtBobSales
        '
        Me.txtBobSales.Location = New System.Drawing.Point(139, 7)
        Me.txtBobSales.Name = "txtBobSales"
        Me.txtBobSales.Size = New System.Drawing.Size(100, 20)
        Me.txtBobSales.TabIndex = 3
        Me.txtBobSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblKarenSales
        '
        Me.lblKarenSales.AutoSize = True
        Me.lblKarenSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKarenSales.Location = New System.Drawing.Point(9, 41)
        Me.lblKarenSales.Name = "lblKarenSales"
        Me.lblKarenSales.Size = New System.Drawing.Size(105, 15)
        Me.lblKarenSales.TabIndex = 4
        Me.lblKarenSales.Text = "Karen Sales Amount"
        '
        'txtKarenSales
        '
        Me.txtKarenSales.Location = New System.Drawing.Point(139, 38)
        Me.txtKarenSales.Name = "txtKarenSales"
        Me.txtKarenSales.Size = New System.Drawing.Size(100, 20)
        Me.txtKarenSales.TabIndex = 5
        Me.txtKarenSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblJoshSales
        '
        Me.lblJoshSales.AutoSize = True
        Me.lblJoshSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJoshSales.Location = New System.Drawing.Point(9, 70)
        Me.lblJoshSales.Name = "lblJoshSales"
        Me.lblJoshSales.Size = New System.Drawing.Size(99, 15)
        Me.lblJoshSales.TabIndex = 6
        Me.lblJoshSales.Text = "Josh Sales Amount"
        '
        'txtJoshSales
        '
        Me.txtJoshSales.Location = New System.Drawing.Point(139, 67)
        Me.txtJoshSales.Name = "txtJoshSales"
        Me.txtJoshSales.Size = New System.Drawing.Size(100, 20)
        Me.txtJoshSales.TabIndex = 7
        Me.txtJoshSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculateSales
        '
        Me.btnCalculateSales.Location = New System.Drawing.Point(87, 143)
        Me.btnCalculateSales.Name = "btnCalculateSales"
        Me.btnCalculateSales.Size = New System.Drawing.Size(152, 23)
        Me.btnCalculateSales.TabIndex = 8
        Me.btnCalculateSales.Text = "&Calculate Sales Percentage"
        Me.btnCalculateSales.UseVisualStyleBackColor = True
        '
        'lblBobPercent
        '
        Me.lblBobPercent.AutoSize = True
        Me.lblBobPercent.Location = New System.Drawing.Point(21, 196)
        Me.lblBobPercent.Name = "lblBobPercent"
        Me.lblBobPercent.Size = New System.Drawing.Size(73, 13)
        Me.lblBobPercent.TabIndex = 9
        Me.lblBobPercent.Text = "Bob's Percent"
        '
        'lblKarenPercent
        '
        Me.lblKarenPercent.AutoSize = True
        Me.lblKarenPercent.Location = New System.Drawing.Point(121, 196)
        Me.lblKarenPercent.Name = "lblKarenPercent"
        Me.lblKarenPercent.Size = New System.Drawing.Size(82, 13)
        Me.lblKarenPercent.TabIndex = 10
        Me.lblKarenPercent.Text = "Karen's Percent"
        '
        'lblJoshPercent
        '
        Me.lblJoshPercent.AutoSize = True
        Me.lblJoshPercent.Location = New System.Drawing.Point(231, 196)
        Me.lblJoshPercent.Name = "lblJoshPercent"
        Me.lblJoshPercent.Size = New System.Drawing.Size(76, 13)
        Me.lblJoshPercent.TabIndex = 11
        Me.lblJoshPercent.Text = "Josh's Percent"
        '
        'picSales
        '
        Me.picSales.Image = Global.Sales_Project.My.Resources.Resources.sales
        Me.picSales.Location = New System.Drawing.Point(293, 7)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(141, 119)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSales.TabIndex = 12
        Me.picSales.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(359, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtBobPercent
        '
        Me.txtBobPercent.Location = New System.Drawing.Point(9, 212)
        Me.txtBobPercent.Name = "txtBobPercent"
        Me.txtBobPercent.Size = New System.Drawing.Size(100, 20)
        Me.txtBobPercent.TabIndex = 14
        Me.txtBobPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJoshPercent
        '
        Me.txtJoshPercent.Location = New System.Drawing.Point(221, 212)
        Me.txtJoshPercent.Name = "txtJoshPercent"
        Me.txtJoshPercent.Size = New System.Drawing.Size(100, 20)
        Me.txtJoshPercent.TabIndex = 15
        Me.txtJoshPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKarenPercent
        '
        Me.txtKarenPercent.Location = New System.Drawing.Point(115, 212)
        Me.txtKarenPercent.Name = "txtKarenPercent"
        Me.txtKarenPercent.Size = New System.Drawing.Size(100, 20)
        Me.txtKarenPercent.TabIndex = 16
        Me.txtKarenPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 256)
        Me.Controls.Add(Me.txtKarenPercent)
        Me.Controls.Add(Me.txtJoshPercent)
        Me.Controls.Add(Me.txtBobPercent)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picSales)
        Me.Controls.Add(Me.lblJoshPercent)
        Me.Controls.Add(Me.lblKarenPercent)
        Me.Controls.Add(Me.lblBobPercent)
        Me.Controls.Add(Me.btnCalculateSales)
        Me.Controls.Add(Me.txtJoshSales)
        Me.Controls.Add(Me.lblJoshSales)
        Me.Controls.Add(Me.txtKarenSales)
        Me.Controls.Add(Me.lblKarenSales)
        Me.Controls.Add(Me.txtBobSales)
        Me.Controls.Add(Me.lblBobSales)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Name = "frmMain"
        Me.Text = "Sales Calculation"
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalSales As Label
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents lblBobSales As Label
    Friend WithEvents txtBobSales As TextBox
    Friend WithEvents lblKarenSales As Label
    Friend WithEvents txtKarenSales As TextBox
    Friend WithEvents lblJoshSales As Label
    Friend WithEvents txtJoshSales As TextBox
    Friend WithEvents btnCalculateSales As Button
    Friend WithEvents lblBobPercent As Label
    Friend WithEvents lblKarenPercent As Label
    Friend WithEvents lblJoshPercent As Label
    Friend WithEvents picSales As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents txtBobPercent As TextBox
    Friend WithEvents txtJoshPercent As TextBox
    Friend WithEvents txtKarenPercent As TextBox
End Class
