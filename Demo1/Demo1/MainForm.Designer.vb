﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picEquation = New System.Windows.Forms.PictureBox()
        Me.picEinstein = New System.Windows.Forms.PictureBox()
        CType(Me.picEquation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEinstein, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(12, 298)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(96, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "&Show Equation"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(161, 298)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(95, 23)
        Me.btnHide.TabIndex = 3
        Me.btnHide.Text = "&Hide Equation"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(308, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picEquation
        '
        Me.picEquation.Image = Global.Demo1.My.Resources.Resources.Equation
        Me.picEquation.Location = New System.Drawing.Point(253, 113)
        Me.picEquation.Name = "picEquation"
        Me.picEquation.Size = New System.Drawing.Size(142, 59)
        Me.picEquation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEquation.TabIndex = 1
        Me.picEquation.TabStop = False
        Me.picEquation.Visible = False
        '
        'picEinstein
        '
        Me.picEinstein.Image = Global.Demo1.My.Resources.Resources.Einstein
        Me.picEinstein.Location = New System.Drawing.Point(12, 12)
        Me.picEinstein.Name = "picEinstein"
        Me.picEinstein.Size = New System.Drawing.Size(199, 248)
        Me.picEinstein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEinstein.TabIndex = 0
        Me.picEinstein.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 333)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.picEquation)
        Me.Controls.Add(Me.picEinstein)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstien's Famous Equation"
        CType(Me.picEquation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEinstein, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEinstein As PictureBox
    Friend WithEvents picEquation As PictureBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnExit As Button
End Class
