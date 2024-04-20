<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtPassCount = New System.Windows.Forms.TextBox()
        Me.lblNumberPassing = New System.Windows.Forms.Label()
        Me.lblNumberFailing = New System.Windows.Forms.Label()
        Me.txtFailCount = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPercentPassing = New System.Windows.Forms.Label()
        Me.lblPercentFailing = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPassPercentage = New System.Windows.Forms.Label()
        Me.lblFailPercentage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassCount
        '
        Me.txtPassCount.Location = New System.Drawing.Point(125, 6)
        Me.txtPassCount.Name = "txtPassCount"
        Me.txtPassCount.Size = New System.Drawing.Size(100, 20)
        Me.txtPassCount.TabIndex = 0
        Me.txtPassCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNumberPassing
        '
        Me.lblNumberPassing.AutoSize = True
        Me.lblNumberPassing.Location = New System.Drawing.Point(12, 9)
        Me.lblNumberPassing.Name = "lblNumberPassing"
        Me.lblNumberPassing.Size = New System.Drawing.Size(92, 13)
        Me.lblNumberPassing.TabIndex = 2
        Me.lblNumberPassing.Text = "Passing Students:"
        '
        'lblNumberFailing
        '
        Me.lblNumberFailing.AutoSize = True
        Me.lblNumberFailing.Location = New System.Drawing.Point(12, 35)
        Me.lblNumberFailing.Name = "lblNumberFailing"
        Me.lblNumberFailing.Size = New System.Drawing.Size(85, 13)
        Me.lblNumberFailing.TabIndex = 3
        Me.lblNumberFailing.Text = "Failing Students:"
        '
        'txtFailCount
        '
        Me.txtFailCount.Location = New System.Drawing.Point(125, 32)
        Me.txtFailCount.Name = "txtFailCount"
        Me.txtFailCount.Size = New System.Drawing.Size(100, 20)
        Me.txtFailCount.TabIndex = 4
        Me.txtFailCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(115, 58)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate Percentage"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblPercentPassing
        '
        Me.lblPercentPassing.AutoSize = True
        Me.lblPercentPassing.Location = New System.Drawing.Point(12, 93)
        Me.lblPercentPassing.Name = "lblPercentPassing"
        Me.lblPercentPassing.Size = New System.Drawing.Size(105, 13)
        Me.lblPercentPassing.TabIndex = 7
        Me.lblPercentPassing.Text = "Percentage Passing:"
        '
        'lblPercentFailing
        '
        Me.lblPercentFailing.AutoSize = True
        Me.lblPercentFailing.Location = New System.Drawing.Point(12, 124)
        Me.lblPercentFailing.Name = "lblPercentFailing"
        Me.lblPercentFailing.Size = New System.Drawing.Size(98, 13)
        Me.lblPercentFailing.TabIndex = 8
        Me.lblPercentFailing.Text = "Percentage Failing:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Grade.My.Resources.Resources.grades
        Me.PictureBox1.Location = New System.Drawing.Point(254, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lblPassPercentage
        '
        Me.lblPassPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPassPercentage.Location = New System.Drawing.Point(125, 84)
        Me.lblPassPercentage.Name = "lblPassPercentage"
        Me.lblPassPercentage.Size = New System.Drawing.Size(91, 26)
        Me.lblPassPercentage.TabIndex = 13
        Me.lblPassPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFailPercentage
        '
        Me.lblFailPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFailPercentage.Location = New System.Drawing.Point(125, 117)
        Me.lblFailPercentage.Name = "lblFailPercentage"
        Me.lblFailPercentage.Size = New System.Drawing.Size(91, 26)
        Me.lblFailPercentage.TabIndex = 14
        Me.lblFailPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 185)
        Me.Controls.Add(Me.lblFailPercentage)
        Me.Controls.Add(Me.lblPassPercentage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPercentFailing)
        Me.Controls.Add(Me.lblPercentPassing)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFailCount)
        Me.Controls.Add(Me.lblNumberFailing)
        Me.Controls.Add(Me.lblNumberPassing)
        Me.Controls.Add(Me.txtPassCount)
        Me.Name = "Form1"
        Me.Text = "Grade Project"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassCount As TextBox
    Friend WithEvents lblNumberPassing As Label
    Friend WithEvents lblNumberFailing As Label
    Friend WithEvents txtFailCount As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPercentPassing As Label
    Friend WithEvents lblPercentFailing As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPassPercentage As Label
    Friend WithEvents lblFailPercentage As Label
End Class
