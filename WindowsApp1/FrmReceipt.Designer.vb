<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceipt
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbxPrice = New System.Windows.Forms.ListBox()
        Me.lbxQuantity = New System.Windows.Forms.ListBox()
        Me.lbxFoodSelected = New System.Windows.Forms.ListBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblPaymentSubtotal = New System.Windows.Forms.Label()
        Me.lblCustomerPay = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblPaymentTax = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(653, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(383, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Selected Items"
        '
        'lbxPrice
        '
        Me.lbxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxPrice.FormattingEnabled = True
        Me.lbxPrice.Location = New System.Drawing.Point(384, 63)
        Me.lbxPrice.Name = "lbxPrice"
        Me.lbxPrice.Size = New System.Drawing.Size(128, 390)
        Me.lbxPrice.TabIndex = 141
        '
        'lbxQuantity
        '
        Me.lbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxQuantity.FormattingEnabled = True
        Me.lbxQuantity.Location = New System.Drawing.Point(259, 63)
        Me.lbxQuantity.Name = "lbxQuantity"
        Me.lbxQuantity.Size = New System.Drawing.Size(128, 390)
        Me.lbxQuantity.TabIndex = 140
        '
        'lbxFoodSelected
        '
        Me.lbxFoodSelected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxFoodSelected.FormattingEnabled = True
        Me.lbxFoodSelected.Location = New System.Drawing.Point(116, 63)
        Me.lbxFoodSelected.Name = "lbxFoodSelected"
        Me.lbxFoodSelected.Size = New System.Drawing.Size(146, 390)
        Me.lbxFoodSelected.TabIndex = 139
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(473, 516)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(102, 42)
        Me.btnback.TabIndex = 146
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.Location = New System.Drawing.Point(690, 133)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(72, 18)
        Me.lblOrderID.TabIndex = 147
        Me.lblOrderID.Text = "Order ID :"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(690, 401)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(102, 18)
        Me.lblBalance.TabIndex = 133
        Me.lblBalance.Text = "Balance : RM0"
        '
        'lblPaymentSubtotal
        '
        Me.lblPaymentSubtotal.AutoSize = True
        Me.lblPaymentSubtotal.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentSubtotal.Location = New System.Drawing.Point(690, 247)
        Me.lblPaymentSubtotal.Name = "lblPaymentSubtotal"
        Me.lblPaymentSubtotal.Size = New System.Drawing.Size(103, 18)
        Me.lblPaymentSubtotal.TabIndex = 134
        Me.lblPaymentSubtotal.Text = "Subtotal : RM0"
        '
        'lblCustomerPay
        '
        Me.lblCustomerPay.AutoSize = True
        Me.lblCustomerPay.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerPay.Location = New System.Drawing.Point(690, 363)
        Me.lblCustomerPay.Name = "lblCustomerPay"
        Me.lblCustomerPay.Size = New System.Drawing.Size(115, 18)
        Me.lblCustomerPay.TabIndex = 132
        Me.lblCustomerPay.Text = "Customer Pays :"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(690, 323)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(140, 20)
        Me.lblTotalAmount.TabIndex = 131
        Me.lblTotalAmount.Text = "Total Amount : RM0"
        '
        'lblPaymentTax
        '
        Me.lblPaymentTax.AutoSize = True
        Me.lblPaymentTax.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentTax.Location = New System.Drawing.Point(690, 285)
        Me.lblPaymentTax.Name = "lblPaymentTax"
        Me.lblPaymentTax.Size = New System.Drawing.Size(105, 18)
        Me.lblPaymentTax.TabIndex = 135
        Me.lblPaymentTax.Text = "Tax (6%) : RM0"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(690, 171)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(104, 18)
        Me.lblCustomerID.TabIndex = 148
        Me.lblCustomerID.Text = " Customer ID :"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(690, 209)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(132, 18)
        Me.lblStaffID.TabIndex = 149
        Me.lblStaffID.Text = "Servicing Staff ID :"
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AllowDrop = True
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderDate.Location = New System.Drawing.Point(690, 95)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(47, 18)
        Me.lblOrderDate.TabIndex = 150
        Me.lblOrderDate.Text = "Date :"
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(623, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(538, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 18)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Servicing Staff ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(566, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = " Customer ID :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(598, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Order ID :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(598, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "Tax (6%) :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(560, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Total Amount :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(570, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 18)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "Paid Amount :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(597, 247)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 18)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "Subtotal :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(598, 401)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 18)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "Balance :"
        '
        'FrmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1053, 600)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbxPrice)
        Me.Controls.Add(Me.lbxQuantity)
        Me.Controls.Add(Me.lbxFoodSelected)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPaymentTax)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblCustomerPay)
        Me.Controls.Add(Me.lblPaymentSubtotal)
        Me.Controls.Add(Me.lblBalance)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "FrmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReceipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbxPrice As ListBox
    Friend WithEvents lbxQuantity As ListBox
    Friend WithEvents lbxFoodSelected As ListBox
    Friend WithEvents btnback As Button
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblPaymentSubtotal As Label
    Friend WithEvents lblCustomerPay As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblPaymentTax As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
