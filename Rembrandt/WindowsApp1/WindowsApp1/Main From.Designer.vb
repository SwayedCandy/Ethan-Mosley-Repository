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
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblNumberSold = New System.Windows.Forms.Label()
        Me.txtNumberSold = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSoldUsedCar = New System.Windows.Forms.Label()
        Me.lblUsedCar = New System.Windows.Forms.Label()
        Me.lblSoldNewCar = New System.Windows.Forms.Label()
        Me.lblNewCar = New System.Windows.Forms.Label()
        Me.lblSoldPartTime = New System.Windows.Forms.Label()
        Me.lblPartTime = New System.Windows.Forms.Label()
        Me.lblSoldFullTime = New System.Windows.Forms.Label()
        Me.lblFullTime = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(9, 6)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "&ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(9, 21)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(76, 22)
        Me.txtID.TabIndex = 1
        '
        'lblNumberSold
        '
        Me.lblNumberSold.AutoSize = True
        Me.lblNumberSold.Location = New System.Drawing.Point(103, 6)
        Me.lblNumberSold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumberSold.Name = "lblNumberSold"
        Me.lblNumberSold.Size = New System.Drawing.Size(76, 13)
        Me.lblNumberSold.TabIndex = 2
        Me.lblNumberSold.Text = "&Number sold:"
        '
        'txtNumberSold
        '
        Me.txtNumberSold.Location = New System.Drawing.Point(106, 21)
        Me.txtNumberSold.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumberSold.Name = "txtNumberSold"
        Me.txtNumberSold.Size = New System.Drawing.Size(76, 22)
        Me.txtNumberSold.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(250, 21)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(250, 61)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSoldUsedCar)
        Me.GroupBox1.Controls.Add(Me.lblUsedCar)
        Me.GroupBox1.Controls.Add(Me.lblSoldNewCar)
        Me.GroupBox1.Controls.Add(Me.lblNewCar)
        Me.GroupBox1.Controls.Add(Me.lblSoldPartTime)
        Me.GroupBox1.Controls.Add(Me.lblPartTime)
        Me.GroupBox1.Controls.Add(Me.lblSoldFullTime)
        Me.GroupBox1.Controls.Add(Me.lblFullTime)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cars sold by"
        '
        'lblSoldUsedCar
        '
        Me.lblSoldUsedCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoldUsedCar.Location = New System.Drawing.Point(126, 95)
        Me.lblSoldUsedCar.Name = "lblSoldUsedCar"
        Me.lblSoldUsedCar.Size = New System.Drawing.Size(39, 13)
        Me.lblSoldUsedCar.TabIndex = 7
        '
        'lblUsedCar
        '
        Me.lblUsedCar.AutoSize = True
        Me.lblUsedCar.Location = New System.Drawing.Point(6, 95)
        Me.lblUsedCar.Name = "lblUsedCar"
        Me.lblUsedCar.Size = New System.Drawing.Size(113, 13)
        Me.lblUsedCar.TabIndex = 6
        Me.lblUsedCar.Text = "Used Car employees:"
        '
        'lblSoldNewCar
        '
        Me.lblSoldNewCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoldNewCar.Location = New System.Drawing.Point(126, 70)
        Me.lblSoldNewCar.Name = "lblSoldNewCar"
        Me.lblSoldNewCar.Size = New System.Drawing.Size(39, 13)
        Me.lblSoldNewCar.TabIndex = 5
        '
        'lblNewCar
        '
        Me.lblNewCar.AutoSize = True
        Me.lblNewCar.Location = New System.Drawing.Point(6, 70)
        Me.lblNewCar.Name = "lblNewCar"
        Me.lblNewCar.Size = New System.Drawing.Size(108, 13)
        Me.lblNewCar.TabIndex = 4
        Me.lblNewCar.Text = "New car employees:"
        '
        'lblSoldPartTime
        '
        Me.lblSoldPartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoldPartTime.Location = New System.Drawing.Point(126, 45)
        Me.lblSoldPartTime.Name = "lblSoldPartTime"
        Me.lblSoldPartTime.Size = New System.Drawing.Size(39, 13)
        Me.lblSoldPartTime.TabIndex = 3
        '
        'lblPartTime
        '
        Me.lblPartTime.AutoSize = True
        Me.lblPartTime.Location = New System.Drawing.Point(6, 45)
        Me.lblPartTime.Name = "lblPartTime"
        Me.lblPartTime.Size = New System.Drawing.Size(115, 13)
        Me.lblPartTime.TabIndex = 2
        Me.lblPartTime.Text = "Part-Time employees:"
        '
        'lblSoldFullTime
        '
        Me.lblSoldFullTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoldFullTime.Location = New System.Drawing.Point(126, 20)
        Me.lblSoldFullTime.Name = "lblSoldFullTime"
        Me.lblSoldFullTime.Size = New System.Drawing.Size(39, 13)
        Me.lblSoldFullTime.TabIndex = 1
        '
        'lblFullTime
        '
        Me.lblFullTime.AutoSize = True
        Me.lblFullTime.Location = New System.Drawing.Point(6, 20)
        Me.lblFullTime.Name = "lblFullTime"
        Me.lblFullTime.Size = New System.Drawing.Size(114, 13)
        Me.lblFullTime.TabIndex = 0
        Me.lblFullTime.Text = "Full-Time employees:"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(361, 207)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumberSold)
        Me.Controls.Add(Me.lblNumberSold)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rembrandt Auto-Mart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblNumberSold As Label
    Friend WithEvents txtNumberSold As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSoldUsedCar As Label
    Friend WithEvents lblUsedCar As Label
    Friend WithEvents lblSoldNewCar As Label
    Friend WithEvents lblNewCar As Label
    Friend WithEvents lblSoldPartTime As Label
    Friend WithEvents lblPartTime As Label
    Friend WithEvents lblSoldFullTime As Label
    Friend WithEvents lblFullTime As Label
End Class
