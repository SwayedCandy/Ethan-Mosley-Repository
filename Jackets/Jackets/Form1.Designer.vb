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
        Me.showChart = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnBrown = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.picsizeChart = New System.Windows.Forms.PictureBox()
        Me.picJacket = New System.Windows.Forms.PictureBox()
        CType(Me.picsizeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'showChart
        '
        Me.showChart.Location = New System.Drawing.Point(178, 32)
        Me.showChart.Name = "showChart"
        Me.showChart.Size = New System.Drawing.Size(75, 23)
        Me.showChart.TabIndex = 1
        Me.showChart.Text = "&Size Chart"
        Me.showChart.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBlack
        '
        Me.btnBlack.Location = New System.Drawing.Point(12, 219)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(75, 23)
        Me.btnBlack.TabIndex = 4
        Me.btnBlack.Text = "&Black"
        Me.btnBlack.UseVisualStyleBackColor = True
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(97, 219)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnBlue.TabIndex = 5
        Me.btnBlue.Text = "B&lue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnBrown
        '
        Me.btnBrown.Location = New System.Drawing.Point(178, 219)
        Me.btnBrown.Name = "btnBrown"
        Me.btnBrown.Size = New System.Drawing.Size(75, 23)
        Me.btnBrown.TabIndex = 6
        Me.btnBrown.Text = "Bro&wn"
        Me.btnBrown.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(259, 219)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(75, 23)
        Me.btnRed.TabIndex = 7
        Me.btnRed.Text = "&Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'picsizeChart
        '
        Me.picsizeChart.Image = Global.Jackets.My.Resources.Resources.SizeChart
        Me.picsizeChart.Location = New System.Drawing.Point(178, 61)
        Me.picsizeChart.Name = "picsizeChart"
        Me.picsizeChart.Size = New System.Drawing.Size(155, 105)
        Me.picsizeChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsizeChart.TabIndex = 3
        Me.picsizeChart.TabStop = False
        Me.picsizeChart.Visible = False
        '
        'picJacket
        '
        Me.picJacket.Image = Global.Jackets.My.Resources.Resources.RedJacket
        Me.picJacket.Location = New System.Drawing.Point(12, 30)
        Me.picJacket.Name = "picJacket"
        Me.picJacket.Size = New System.Drawing.Size(160, 165)
        Me.picJacket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJacket.TabIndex = 0
        Me.picJacket.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 259)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnBrown)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnBlack)
        Me.Controls.Add(Me.picsizeChart)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.showChart)
        Me.Controls.Add(Me.picJacket)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jackets and More"
        CType(Me.picsizeChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJacket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picJacket As PictureBox
    Friend WithEvents showChart As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents picsizeChart As PictureBox
    Friend WithEvents btnBlack As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnBrown As Button
    Friend WithEvents btnRed As Button
End Class
