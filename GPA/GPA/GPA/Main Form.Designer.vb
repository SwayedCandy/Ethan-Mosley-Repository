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
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.lstGpa = New System.Windows.Forms.ListBox()
        Me.lblGpa = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpAverageGpa = New System.Windows.Forms.GroupBox()
        Me.lblAvgMale = New System.Windows.Forms.Label()
        Me.lblAvgFemale = New System.Windows.Forms.Label()
        Me.lblAvgAll = New System.Windows.Forms.Label()
        Me.txtAvgMale = New System.Windows.Forms.TextBox()
        Me.txtAvgFemale = New System.Windows.Forms.TextBox()
        Me.txtAvgAll = New System.Windows.Forms.TextBox()
        Me.grpAverageGpa.SuspendLayout()
        Me.SuspendLayout()
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(34, 27)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(63, 19)
        Me.radFemale.TabIndex = 0
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "&Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(34, 52)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(51, 19)
        Me.radMale.TabIndex = 1
        Me.radMale.TabStop = True
        Me.radMale.Text = "&Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'lstGpa
        '
        Me.lstGpa.FormattingEnabled = True
        Me.lstGpa.ItemHeight = 15
        Me.lstGpa.Location = New System.Drawing.Point(140, 45)
        Me.lstGpa.Name = "lstGpa"
        Me.lstGpa.Size = New System.Drawing.Size(70, 139)
        Me.lstGpa.TabIndex = 2
        '
        'lblGpa
        '
        Me.lblGpa.AutoSize = True
        Me.lblGpa.Location = New System.Drawing.Point(137, 27)
        Me.lblGpa.Name = "lblGpa"
        Me.lblGpa.Size = New System.Drawing.Size(32, 15)
        Me.lblGpa.TabIndex = 3
        Me.lblGpa.Text = "&GPA:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(233, 45)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(233, 74)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpAverageGpa
        '
        Me.grpAverageGpa.Controls.Add(Me.lblAvgMale)
        Me.grpAverageGpa.Controls.Add(Me.lblAvgFemale)
        Me.grpAverageGpa.Controls.Add(Me.lblAvgAll)
        Me.grpAverageGpa.Controls.Add(Me.txtAvgMale)
        Me.grpAverageGpa.Controls.Add(Me.txtAvgFemale)
        Me.grpAverageGpa.Controls.Add(Me.txtAvgAll)
        Me.grpAverageGpa.Location = New System.Drawing.Point(12, 190)
        Me.grpAverageGpa.Name = "grpAverageGpa"
        Me.grpAverageGpa.Size = New System.Drawing.Size(352, 100)
        Me.grpAverageGpa.TabIndex = 6
        Me.grpAverageGpa.TabStop = False
        Me.grpAverageGpa.Text = "Average GPA"
        '
        'lblAvgMale
        '
        Me.lblAvgMale.AutoSize = True
        Me.lblAvgMale.Location = New System.Drawing.Point(243, 29)
        Me.lblAvgMale.Name = "lblAvgMale"
        Me.lblAvgMale.Size = New System.Drawing.Size(36, 15)
        Me.lblAvgMale.TabIndex = 5
        Me.lblAvgMale.Text = "M&ale:"
        '
        'lblAvgFemale
        '
        Me.lblAvgFemale.AutoSize = True
        Me.lblAvgFemale.Location = New System.Drawing.Point(122, 29)
        Me.lblAvgFemale.Name = "lblAvgFemale"
        Me.lblAvgFemale.Size = New System.Drawing.Size(48, 15)
        Me.lblAvgFemale.TabIndex = 4
        Me.lblAvgFemale.Text = "F&emale:"
        '
        'lblAvgAll
        '
        Me.lblAvgAll.AutoSize = True
        Me.lblAvgAll.Location = New System.Drawing.Point(3, 29)
        Me.lblAvgAll.Name = "lblAvgAll"
        Me.lblAvgAll.Size = New System.Drawing.Size(73, 15)
        Me.lblAvgAll.TabIndex = 3
        Me.lblAvgAll.Text = "&All Students:"
        '
        'txtAvgMale
        '
        Me.txtAvgMale.Location = New System.Drawing.Point(246, 47)
        Me.txtAvgMale.Name = "txtAvgMale"
        Me.txtAvgMale.Size = New System.Drawing.Size(100, 23)
        Me.txtAvgMale.TabIndex = 2
        Me.txtAvgMale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAvgFemale
        '
        Me.txtAvgFemale.Location = New System.Drawing.Point(125, 47)
        Me.txtAvgFemale.Name = "txtAvgFemale"
        Me.txtAvgFemale.Size = New System.Drawing.Size(100, 23)
        Me.txtAvgFemale.TabIndex = 1
        Me.txtAvgFemale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAvgAll
        '
        Me.txtAvgAll.Location = New System.Drawing.Point(6, 47)
        Me.txtAvgAll.Name = "txtAvgAll"
        Me.txtAvgAll.Size = New System.Drawing.Size(100, 23)
        Me.txtAvgAll.TabIndex = 0
        Me.txtAvgAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 300)
        Me.Controls.Add(Me.grpAverageGpa)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblGpa)
        Me.Controls.Add(Me.lstGpa)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.radFemale)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPA Calculator"
        Me.grpAverageGpa.ResumeLayout(False)
        Me.grpAverageGpa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lstGpa As ListBox
    Friend WithEvents lblGpa As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpAverageGpa As GroupBox
    Friend WithEvents txtAvgAll As TextBox
    Friend WithEvents txtAvgMale As TextBox
    Friend WithEvents txtAvgFemale As TextBox
    Friend WithEvents lblAvgFemale As Label
    Friend WithEvents lblAvgAll As Label
    Friend WithEvents lblAvgMale As Label
End Class
