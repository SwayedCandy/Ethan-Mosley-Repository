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
        Me.radBusiness = New System.Windows.Forms.RadioButton()
        Me.radResidential = New System.Windows.Forms.RadioButton()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstPremium = New System.Windows.Forms.ListBox()
        Me.lblPremium = New System.Windows.Forms.Label()
        Me.lstConnections = New System.Windows.Forms.ListBox()
        Me.lblConnections = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radBusiness
        '
        Me.radBusiness.AutoSize = True
        Me.radBusiness.Location = New System.Drawing.Point(27, 23)
        Me.radBusiness.Name = "radBusiness"
        Me.radBusiness.Size = New System.Drawing.Size(70, 19)
        Me.radBusiness.TabIndex = 0
        Me.radBusiness.Text = "&Business"
        Me.radBusiness.UseVisualStyleBackColor = True
        '
        'radResidential
        '
        Me.radResidential.AutoSize = True
        Me.radResidential.Location = New System.Drawing.Point(27, 58)
        Me.radResidential.Name = "radResidential"
        Me.radResidential.Size = New System.Drawing.Size(82, 19)
        Me.radResidential.TabIndex = 1
        Me.radResidential.Text = "&Residential"
        Me.radResidential.UseVisualStyleBackColor = True
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(24, 166)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(58, 15)
        Me.lblTotalDue.TabIndex = 2
        Me.lblTotalDue.Text = "Total due:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(168, 158)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Ca&lculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(270, 158)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstPremium
        '
        Me.lstPremium.FormattingEnabled = True
        Me.lstPremium.ItemHeight = 15
        Me.lstPremium.Location = New System.Drawing.Point(168, 42)
        Me.lstPremium.Name = "lstPremium"
        Me.lstPremium.Size = New System.Drawing.Size(55, 94)
        Me.lstPremium.TabIndex = 5
        '
        'lblPremium
        '
        Me.lblPremium.AutoSize = True
        Me.lblPremium.Location = New System.Drawing.Point(165, 23)
        Me.lblPremium.Name = "lblPremium"
        Me.lblPremium.Size = New System.Drawing.Size(109, 15)
        Me.lblPremium.TabIndex = 6
        Me.lblPremium.Text = "&Premium channels:"
        '
        'lstConnections
        '
        Me.lstConnections.FormattingEnabled = True
        Me.lstConnections.ItemHeight = 15
        Me.lstConnections.Location = New System.Drawing.Point(286, 42)
        Me.lstConnections.Name = "lstConnections"
        Me.lstConnections.Size = New System.Drawing.Size(59, 94)
        Me.lstConnections.TabIndex = 7
        '
        'lblConnections
        '
        Me.lblConnections.AutoSize = True
        Me.lblConnections.Location = New System.Drawing.Point(283, 23)
        Me.lblConnections.Name = "lblConnections"
        Me.lblConnections.Size = New System.Drawing.Size(77, 15)
        Me.lblConnections.TabIndex = 8
        Me.lblConnections.Text = "&Connections:"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Location = New System.Drawing.Point(24, 181)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(58, 15)
        Me.lblTotalAmount.TabIndex = 9
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 224)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblConnections)
        Me.Controls.Add(Me.lstConnections)
        Me.Controls.Add(Me.lblPremium)
        Me.Controls.Add(Me.lstPremium)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.radResidential)
        Me.Controls.Add(Me.radBusiness)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radBusiness As RadioButton
    Friend WithEvents radResidential As RadioButton
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstPremium As ListBox
    Friend WithEvents lblPremium As Label
    Friend WithEvents lstConnections As ListBox
    Friend WithEvents lblConnections As Label
    Friend WithEvents lblTotalAmount As Label
End Class
