<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnStockInventory = New System.Windows.Forms.Button()
        Me.btnSalesSummary = New System.Windows.Forms.Button()
        Me.btnBestSelling = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1346, 60)
        Me.Panel1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(68, 36)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 15)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Label1"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(68, 21)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(43, 15)
        Me.lblRole.TabIndex = 2
        Me.lblRole.Text = "Label1"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(68, 3)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 18)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(20, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1346, 571)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1146, 571)
        Me.Panel4.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Location = New System.Drawing.Point(6, 59)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1120, 128)
        Me.Panel6.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(837, 16)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(269, 100)
        Me.Panel9.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(562, 16)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(269, 100)
        Me.Panel8.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.lblProduct)
        Me.Panel7.Location = New System.Drawing.Point(287, 16)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(269, 100)
        Me.Panel7.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TOTAL PRODUCT"
        '
        'lblProduct
        '
        Me.lblProduct.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.ForeColor = System.Drawing.Color.White
        Me.lblProduct.Location = New System.Drawing.Point(3, 0)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(266, 71)
        Me.lblProduct.TabIndex = 2
        Me.lblProduct.Text = "0"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblTotalSales)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(12, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(269, 100)
        Me.Panel5.TabIndex = 0
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.Color.White
        Me.lblTotalSales.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(266, 71)
        Me.lblTotalSales.TabIndex = 1
        Me.lblTotalSales.Text = "0.00"
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL SALES"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDiscount)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.btnStockInventory)
        Me.Panel3.Controls.Add(Me.btnSalesSummary)
        Me.Panel3.Controls.Add(Me.btnBestSelling)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.btnCancelOrder)
        Me.Panel3.Controls.Add(Me.btnSales)
        Me.Panel3.Controls.Add(Me.btnTable)
        Me.Panel3.Controls.Add(Me.btnProduct)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 571)
        Me.Panel3.TabIndex = 0
        '
        'btnDiscount
        '
        Me.btnDiscount.BackColor = System.Drawing.Color.Green
        Me.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiscount.FlatAppearance.BorderSize = 0
        Me.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscount.ForeColor = System.Drawing.Color.White
        Me.btnDiscount.Image = CType(resources.GetObject("btnDiscount.Image"), System.Drawing.Image)
        Me.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.Location = New System.Drawing.Point(2, 339)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnDiscount.Size = New System.Drawing.Size(195, 50)
        Me.btnDiscount.TabIndex = 9
        Me.btnDiscount.Text = "Manage Discount"
        Me.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDiscount.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Green
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(2, 451)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(195, 50)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "   System Settings"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btnStockInventory
        '
        Me.btnStockInventory.BackColor = System.Drawing.Color.Green
        Me.btnStockInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockInventory.FlatAppearance.BorderSize = 0
        Me.btnStockInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockInventory.ForeColor = System.Drawing.Color.White
        Me.btnStockInventory.Image = CType(resources.GetObject("btnStockInventory.Image"), System.Drawing.Image)
        Me.btnStockInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockInventory.Location = New System.Drawing.Point(0, 395)
        Me.btnStockInventory.Name = "btnStockInventory"
        Me.btnStockInventory.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnStockInventory.Size = New System.Drawing.Size(195, 50)
        Me.btnStockInventory.TabIndex = 7
        Me.btnStockInventory.Text = "   Stock Inventory"
        Me.btnStockInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStockInventory.UseVisualStyleBackColor = False
        '
        'btnSalesSummary
        '
        Me.btnSalesSummary.BackColor = System.Drawing.Color.Green
        Me.btnSalesSummary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalesSummary.FlatAppearance.BorderSize = 0
        Me.btnSalesSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesSummary.ForeColor = System.Drawing.Color.White
        Me.btnSalesSummary.Image = CType(resources.GetObject("btnSalesSummary.Image"), System.Drawing.Image)
        Me.btnSalesSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalesSummary.Location = New System.Drawing.Point(2, 283)
        Me.btnSalesSummary.Name = "btnSalesSummary"
        Me.btnSalesSummary.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnSalesSummary.Size = New System.Drawing.Size(195, 50)
        Me.btnSalesSummary.TabIndex = 6
        Me.btnSalesSummary.Text = "   Sales Summary"
        Me.btnSalesSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalesSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalesSummary.UseVisualStyleBackColor = False
        '
        'btnBestSelling
        '
        Me.btnBestSelling.BackColor = System.Drawing.Color.Green
        Me.btnBestSelling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBestSelling.FlatAppearance.BorderSize = 0
        Me.btnBestSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestSelling.ForeColor = System.Drawing.Color.White
        Me.btnBestSelling.Image = CType(resources.GetObject("btnBestSelling.Image"), System.Drawing.Image)
        Me.btnBestSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestSelling.Location = New System.Drawing.Point(2, 227)
        Me.btnBestSelling.Name = "btnBestSelling"
        Me.btnBestSelling.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnBestSelling.Size = New System.Drawing.Size(195, 50)
        Me.btnBestSelling.TabIndex = 5
        Me.btnBestSelling.Text = "   Best Selling Items"
        Me.btnBestSelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBestSelling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBestSelling.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(2, 518)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(195, 50)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "   Logout"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.BackColor = System.Drawing.Color.Green
        Me.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelOrder.FlatAppearance.BorderSize = 0
        Me.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelOrder.ForeColor = System.Drawing.Color.White
        Me.btnCancelOrder.Image = CType(resources.GetObject("btnCancelOrder.Image"), System.Drawing.Image)
        Me.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelOrder.Location = New System.Drawing.Point(2, 171)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnCancelOrder.Size = New System.Drawing.Size(195, 50)
        Me.btnCancelOrder.TabIndex = 3
        Me.btnCancelOrder.Text = "   Cancel Order"
        Me.btnCancelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelOrder.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.Green
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Image = CType(resources.GetObject("btnSales.Image"), System.Drawing.Image)
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(2, 115)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnSales.Size = New System.Drawing.Size(195, 50)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "   Sales"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnTable
        '
        Me.btnTable.BackColor = System.Drawing.Color.Green
        Me.btnTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTable.FlatAppearance.BorderSize = 0
        Me.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTable.ForeColor = System.Drawing.Color.White
        Me.btnTable.Image = CType(resources.GetObject("btnTable.Image"), System.Drawing.Image)
        Me.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTable.Location = New System.Drawing.Point(2, 59)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnTable.Size = New System.Drawing.Size(195, 50)
        Me.btnTable.TabIndex = 1
        Me.btnTable.Text = "   Table"
        Me.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTable.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.Green
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.ForeColor = System.Drawing.Color.White
        Me.btnProduct.Image = CType(resources.GetObject("btnProduct.Image"), System.Drawing.Image)
        Me.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.Location = New System.Drawing.Point(2, 3)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnProduct.Size = New System.Drawing.Size(195, 50)
        Me.btnProduct.TabIndex = 0
        Me.btnProduct.Text = "   Product"
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 711)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Taza Mia POS System - Administrator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents btnStockInventory As Button
    Friend WithEvents btnSalesSummary As Button
    Friend WithEvents btnBestSelling As Button
    Friend WithEvents btnDiscount As Button
End Class
