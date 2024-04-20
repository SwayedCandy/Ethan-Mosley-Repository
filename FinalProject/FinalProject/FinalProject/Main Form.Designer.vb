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
        Me.lblDVDs = New System.Windows.Forms.Label()
        Me.lstDVDs = New System.Windows.Forms.ListBox()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.lblCart = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClearDVDs = New System.Windows.Forms.Button()
        Me.btnClearCart = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtShipping = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDVDSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearCartSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDVDs
        '
        Me.lblDVDs.AutoSize = True
        Me.lblDVDs.Location = New System.Drawing.Point(12, 39)
        Me.lblDVDs.Name = "lblDVDs"
        Me.lblDVDs.Size = New System.Drawing.Size(38, 15)
        Me.lblDVDs.TabIndex = 1
        Me.lblDVDs.Text = "DVDs:"
        '
        'lstDVDs
        '
        Me.lstDVDs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDVDs.FormattingEnabled = True
        Me.lstDVDs.ItemHeight = 14
        Me.lstDVDs.Location = New System.Drawing.Point(15, 57)
        Me.lstDVDs.Name = "lstDVDs"
        Me.lstDVDs.Size = New System.Drawing.Size(218, 88)
        Me.lstDVDs.TabIndex = 2
        '
        'lstCart
        '
        Me.lstCart.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 14
        Me.lstCart.Location = New System.Drawing.Point(348, 57)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(218, 88)
        Me.lstCart.TabIndex = 6
        '
        'lblCart
        '
        Me.lblCart.AutoSize = True
        Me.lblCart.Location = New System.Drawing.Point(345, 39)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(32, 15)
        Me.lblCart.TabIndex = 5
        Me.lblCart.Text = "Cart:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(254, 66)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add ->"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(254, 95)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "<- &Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnClearDVDs
        '
        Me.btnClearDVDs.Location = New System.Drawing.Point(15, 157)
        Me.btnClearDVDs.Name = "btnClearDVDs"
        Me.btnClearDVDs.Size = New System.Drawing.Size(75, 23)
        Me.btnClearDVDs.TabIndex = 7
        Me.btnClearDVDs.Text = "&Clear"
        Me.btnClearDVDs.UseVisualStyleBackColor = True
        '
        'btnClearCart
        '
        Me.btnClearCart.Location = New System.Drawing.Point(348, 157)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(75, 23)
        Me.btnClearCart.TabIndex = 8
        Me.btnClearCart.Text = "C&lear"
        Me.btnClearCart.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(345, 212)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(54, 15)
        Me.lblSubtotal.TabIndex = 9
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(399, 242)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(27, 15)
        Me.lblTax.TabIndex = 11
        Me.lblTax.Text = "Tax:"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(426, 272)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(57, 15)
        Me.lblShipping.TabIndex = 13
        Me.lblShipping.Text = "Shipping:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(483, 302)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(35, 15)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "Total:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(402, 209)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.txtSubtotal.TabIndex = 10
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(432, 238)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(100, 23)
        Me.txtTax.TabIndex = 12
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShipping
        '
        Me.txtShipping.Location = New System.Drawing.Point(486, 269)
        Me.txtShipping.Name = "txtShipping"
        Me.txtShipping.ReadOnly = True
        Me.txtShipping.Size = New System.Drawing.Size(100, 23)
        Me.txtShipping.TabIndex = 14
        Me.txtShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(524, 298)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtTotal.TabIndex = 16
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(641, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearDVDSelectionToolStripMenuItem, Me.ClearCartSelectionToolStripMenuItem, Me.ToolStripSeparator1, Me.ClearCartToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearDVDSelectionToolStripMenuItem
        '
        Me.ClearDVDSelectionToolStripMenuItem.Name = "ClearDVDSelectionToolStripMenuItem"
        Me.ClearDVDSelectionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearDVDSelectionToolStripMenuItem.Text = "Cl&ear DVD Selection"
        '
        'ClearCartSelectionToolStripMenuItem
        '
        Me.ClearCartSelectionToolStripMenuItem.Name = "ClearCartSelectionToolStripMenuItem"
        Me.ClearCartSelectionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearCartSelectionToolStripMenuItem.Text = "Clear Ca&rt Selection"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'ClearCartToolStripMenuItem
        '
        Me.ClearCartToolStripMenuItem.Name = "ClearCartToolStripMenuItem"
        Me.ClearCartToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearCartToolStripMenuItem.Text = "Clear Ca&rt"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 345)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtShipping)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnClearCart)
        Me.Controls.Add(Me.btnClearDVDs)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblCart)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.lstDVDs)
        Me.Controls.Add(Me.lblDVDs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDVDs As Label
    Friend WithEvents lstDVDs As ListBox
    Friend WithEvents lstCart As ListBox
    Friend WithEvents lblCart As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClearDVDs As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtShipping As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearDVDSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearCartSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ClearCartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
