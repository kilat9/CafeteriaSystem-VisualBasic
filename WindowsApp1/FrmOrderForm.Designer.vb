<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrder
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCheckItems = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QuantityToast = New System.Windows.Forms.NumericUpDown()
        Me.cbxToast = New System.Windows.Forms.CheckBox()
        Me.QuantityRotiCanai = New System.Windows.Forms.NumericUpDown()
        Me.cbxRotiCanai = New System.Windows.Forms.CheckBox()
        Me.QuantitySandwich = New System.Windows.Forms.NumericUpDown()
        Me.cbxSandwich = New System.Windows.Forms.CheckBox()
        Me.QuantityShepardpie = New System.Windows.Forms.NumericUpDown()
        Me.cbxShepardpie = New System.Windows.Forms.CheckBox()
        Me.QuantitySoupNoodles = New System.Windows.Forms.NumericUpDown()
        Me.QuantityChickenRice = New System.Windows.Forms.NumericUpDown()
        Me.cbxSoupNoodles = New System.Windows.Forms.CheckBox()
        Me.cbxChickenRice = New System.Windows.Forms.CheckBox()
        Me.QuantitySpaghetti = New System.Windows.Forms.NumericUpDown()
        Me.cbxSpaghetti = New System.Windows.Forms.CheckBox()
        Me.QuantityPizza = New System.Windows.Forms.NumericUpDown()
        Me.cbxPizza = New System.Windows.Forms.CheckBox()
        Me.QuantityBeefBurger = New System.Windows.Forms.NumericUpDown()
        Me.cbxBeefBurger = New System.Windows.Forms.CheckBox()
        Me.QuantityChickenBurger = New System.Windows.Forms.NumericUpDown()
        Me.cbxChickenBurger = New System.Windows.Forms.CheckBox()
        Me.QuantityFriedNoodles = New System.Windows.Forms.NumericUpDown()
        Me.QuantityFriedRice = New System.Windows.Forms.NumericUpDown()
        Me.cbxFriedNoodles = New System.Windows.Forms.CheckBox()
        Me.cbxFriedRice = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown23 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.QuantityShake = New System.Windows.Forms.NumericUpDown()
        Me.cbxShake = New System.Windows.Forms.CheckBox()
        Me.QuantityMilo = New System.Windows.Forms.NumericUpDown()
        Me.cbxMilo = New System.Windows.Forms.CheckBox()
        Me.QuantityCannedDrinks = New System.Windows.Forms.NumericUpDown()
        Me.cbxCannedDrinks = New System.Windows.Forms.CheckBox()
        Me.QuantityLemonade = New System.Windows.Forms.NumericUpDown()
        Me.cbxLemonade = New System.Windows.Forms.CheckBox()
        Me.QuantitySirap = New System.Windows.Forms.NumericUpDown()
        Me.cbxSirap = New System.Windows.Forms.CheckBox()
        Me.QuantityMineral = New System.Windows.Forms.NumericUpDown()
        Me.cbxMineralWater = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.QuantityApplePie = New System.Windows.Forms.NumericUpDown()
        Me.cbxApplePie = New System.Windows.Forms.CheckBox()
        Me.QuantityShavedIce = New System.Windows.Forms.NumericUpDown()
        Me.cbxShavedIce = New System.Windows.Forms.CheckBox()
        Me.QuantityVanillaCake = New System.Windows.Forms.NumericUpDown()
        Me.QuantityIceCream = New System.Windows.Forms.NumericUpDown()
        Me.cbxIceCream = New System.Windows.Forms.CheckBox()
        Me.QuantityChocolateCake = New System.Windows.Forms.NumericUpDown()
        Me.cbxChocolateCake = New System.Windows.Forms.CheckBox()
        Me.QuantityStrawberryCake = New System.Windows.Forms.NumericUpDown()
        Me.cbxVanillaCake = New System.Windows.Forms.CheckBox()
        Me.cbxStrawberry = New System.Windows.Forms.CheckBox()
        Me.PanelCheckItems = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCloseItemPanel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbxPrice = New System.Windows.Forms.ListBox()
        Me.lbxQuantity = New System.Windows.Forms.ListBox()
        Me.lbxFoodSelected = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPaymentTax = New System.Windows.Forms.Label()
        Me.lblPaymentSubtotal = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCustomerPayment = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.txtCustPays = New System.Windows.Forms.TextBox()
        Me.PanelPayment = New System.Windows.Forms.Panel()
        Me.btnConfrim = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCustomerNumber = New System.Windows.Forms.Panel()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.pnlCustomerPayment = New System.Windows.Forms.Panel()
        Me.btnCustomerPaymentClose = New System.Windows.Forms.Button()
        Me.btnCustomerPaymentClear = New System.Windows.Forms.Button()
        Me.btn5sen = New System.Windows.Forms.Button()
        Me.btn10sen = New System.Windows.Forms.Button()
        Me.btn20sen = New System.Windows.Forms.Button()
        Me.btn50sen = New System.Windows.Forms.Button()
        Me.btnRM1 = New System.Windows.Forms.Button()
        Me.btnRM5 = New System.Windows.Forms.Button()
        Me.btnRM10 = New System.Windows.Forms.Button()
        Me.btnRM20 = New System.Windows.Forms.Button()
        Me.btnRM50 = New System.Windows.Forms.Button()
        Me.btnRM100 = New System.Windows.Forms.Button()
        Me.txtCustomerPaymentAmount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.ComboBox()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QuantityToast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityRotiCanai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySandwich, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityShepardpie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySoupNoodles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityChickenRice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySpaghetti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityBeefBurger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityChickenBurger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityFriedNoodles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityFriedRice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityShake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityMilo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityCannedDrinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityLemonade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantitySirap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityMineral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.QuantityApplePie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityShavedIce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityVanillaCake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityIceCream, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityChocolateCake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityStrawberryCake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCheckItems.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelPayment.SuspendLayout()
        Me.PanelCustomerNumber.SuspendLayout()
        Me.pnlCustomerPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel5.Controls.Add(Me.btnPayment)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.btnCalculate)
        Me.Panel5.Controls.Add(Me.btnCheckItems)
        Me.Panel5.Controls.Add(Me.btnClearForm)
        Me.Panel5.Location = New System.Drawing.Point(643, 316)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(378, 192)
        Me.Panel5.TabIndex = 68
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(222, 137)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(102, 42)
        Me.btnPayment.TabIndex = 111
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel6.Controls.Add(Me.lblTax)
        Me.Panel6.Controls.Add(Me.lblSubTotal)
        Me.Panel6.Controls.Add(Me.lbltotal)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(202, 118)
        Me.Panel6.TabIndex = 110
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(48, 47)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(105, 18)
        Me.lblTax.TabIndex = 15
        Me.lblTax.Text = "Tax (6%) : RM0"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(50, 12)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(103, 18)
        Me.lblSubTotal.TabIndex = 14
        Me.lblSubTotal.Text = "Subtotal : RM0"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(9, 88)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(144, 18)
        Me.lbltotal.TabIndex = 16
        Me.lbltotal.Text = "Total Payment : RM0"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCalculate.FlatAppearance.BorderSize = 0
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(222, 74)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(102, 42)
        Me.btnCalculate.TabIndex = 60
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnCheckItems
        '
        Me.btnCheckItems.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCheckItems.FlatAppearance.BorderSize = 0
        Me.btnCheckItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckItems.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckItems.Location = New System.Drawing.Point(222, 11)
        Me.btnCheckItems.Name = "btnCheckItems"
        Me.btnCheckItems.Size = New System.Drawing.Size(102, 42)
        Me.btnCheckItems.TabIndex = 59
        Me.btnCheckItems.Text = "Check Items"
        Me.btnCheckItems.UseVisualStyleBackColor = False
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClearForm.FlatAppearance.BorderSize = 0
        Me.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearForm.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(45, 138)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(102, 42)
        Me.btnClearForm.TabIndex = 57
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QuantityToast)
        Me.GroupBox1.Controls.Add(Me.cbxToast)
        Me.GroupBox1.Controls.Add(Me.QuantityRotiCanai)
        Me.GroupBox1.Controls.Add(Me.cbxRotiCanai)
        Me.GroupBox1.Controls.Add(Me.QuantitySandwich)
        Me.GroupBox1.Controls.Add(Me.cbxSandwich)
        Me.GroupBox1.Controls.Add(Me.QuantityShepardpie)
        Me.GroupBox1.Controls.Add(Me.cbxShepardpie)
        Me.GroupBox1.Controls.Add(Me.QuantitySoupNoodles)
        Me.GroupBox1.Controls.Add(Me.QuantityChickenRice)
        Me.GroupBox1.Controls.Add(Me.cbxSoupNoodles)
        Me.GroupBox1.Controls.Add(Me.cbxChickenRice)
        Me.GroupBox1.Controls.Add(Me.QuantitySpaghetti)
        Me.GroupBox1.Controls.Add(Me.cbxSpaghetti)
        Me.GroupBox1.Controls.Add(Me.QuantityPizza)
        Me.GroupBox1.Controls.Add(Me.cbxPizza)
        Me.GroupBox1.Controls.Add(Me.QuantityBeefBurger)
        Me.GroupBox1.Controls.Add(Me.cbxBeefBurger)
        Me.GroupBox1.Controls.Add(Me.QuantityChickenBurger)
        Me.GroupBox1.Controls.Add(Me.cbxChickenBurger)
        Me.GroupBox1.Controls.Add(Me.QuantityFriedNoodles)
        Me.GroupBox1.Controls.Add(Me.QuantityFriedRice)
        Me.GroupBox1.Controls.Add(Me.cbxFriedNoodles)
        Me.GroupBox1.Controls.Add(Me.cbxFriedRice)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 429)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Meal"
        '
        'QuantityToast
        '
        Me.QuantityToast.Enabled = False
        Me.QuantityToast.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityToast.Location = New System.Drawing.Point(302, 361)
        Me.QuantityToast.Name = "QuantityToast"
        Me.QuantityToast.Size = New System.Drawing.Size(43, 23)
        Me.QuantityToast.TabIndex = 94
        '
        'cbxToast
        '
        Me.cbxToast.AutoSize = True
        Me.cbxToast.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxToast.Location = New System.Drawing.Point(187, 353)
        Me.cbxToast.Name = "cbxToast"
        Me.cbxToast.Size = New System.Drawing.Size(84, 40)
        Me.cbxToast.TabIndex = 93
        Me.cbxToast.Text = "Toast" & Global.Microsoft.VisualBasic.ChrW(10) & "(RM1.50)"
        Me.cbxToast.UseVisualStyleBackColor = True
        '
        'QuantityRotiCanai
        '
        Me.QuantityRotiCanai.Enabled = False
        Me.QuantityRotiCanai.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityRotiCanai.Location = New System.Drawing.Point(302, 299)
        Me.QuantityRotiCanai.Name = "QuantityRotiCanai"
        Me.QuantityRotiCanai.Size = New System.Drawing.Size(43, 23)
        Me.QuantityRotiCanai.TabIndex = 92
        '
        'cbxRotiCanai
        '
        Me.cbxRotiCanai.AutoSize = True
        Me.cbxRotiCanai.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRotiCanai.Location = New System.Drawing.Point(187, 291)
        Me.cbxRotiCanai.Name = "cbxRotiCanai"
        Me.cbxRotiCanai.Size = New System.Drawing.Size(101, 40)
        Me.cbxRotiCanai.TabIndex = 91
        Me.cbxRotiCanai.Text = "Roti Canai " & Global.Microsoft.VisualBasic.ChrW(10) & "(RM1.50)"
        Me.cbxRotiCanai.UseVisualStyleBackColor = True
        '
        'QuantitySandwich
        '
        Me.QuantitySandwich.Enabled = False
        Me.QuantitySandwich.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantitySandwich.Location = New System.Drawing.Point(302, 237)
        Me.QuantitySandwich.Name = "QuantitySandwich"
        Me.QuantitySandwich.Size = New System.Drawing.Size(43, 23)
        Me.QuantitySandwich.TabIndex = 90
        '
        'cbxSandwich
        '
        Me.cbxSandwich.AutoSize = True
        Me.cbxSandwich.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSandwich.Location = New System.Drawing.Point(187, 229)
        Me.cbxSandwich.Name = "cbxSandwich"
        Me.cbxSandwich.Size = New System.Drawing.Size(91, 40)
        Me.cbxSandwich.TabIndex = 89
        Me.cbxSandwich.Text = "Sandwich" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM2.00)"
        Me.cbxSandwich.UseVisualStyleBackColor = True
        '
        'QuantityShepardpie
        '
        Me.QuantityShepardpie.Enabled = False
        Me.QuantityShepardpie.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityShepardpie.Location = New System.Drawing.Point(302, 171)
        Me.QuantityShepardpie.Name = "QuantityShepardpie"
        Me.QuantityShepardpie.Size = New System.Drawing.Size(43, 23)
        Me.QuantityShepardpie.TabIndex = 88
        '
        'cbxShepardpie
        '
        Me.cbxShepardpie.AutoSize = True
        Me.cbxShepardpie.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShepardpie.Location = New System.Drawing.Point(187, 163)
        Me.cbxShepardpie.Name = "cbxShepardpie"
        Me.cbxShepardpie.Size = New System.Drawing.Size(116, 40)
        Me.cbxShepardpie.TabIndex = 87
        Me.cbxShepardpie.Text = "Shepard's Pie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM15)"
        Me.cbxShepardpie.UseVisualStyleBackColor = True
        '
        'QuantitySoupNoodles
        '
        Me.QuantitySoupNoodles.Enabled = False
        Me.QuantitySoupNoodles.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantitySoupNoodles.Location = New System.Drawing.Point(302, 109)
        Me.QuantitySoupNoodles.Name = "QuantitySoupNoodles"
        Me.QuantitySoupNoodles.Size = New System.Drawing.Size(43, 23)
        Me.QuantitySoupNoodles.TabIndex = 86
        '
        'QuantityChickenRice
        '
        Me.QuantityChickenRice.Enabled = False
        Me.QuantityChickenRice.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityChickenRice.Location = New System.Drawing.Point(302, 44)
        Me.QuantityChickenRice.Name = "QuantityChickenRice"
        Me.QuantityChickenRice.Size = New System.Drawing.Size(43, 23)
        Me.QuantityChickenRice.TabIndex = 83
        '
        'cbxSoupNoodles
        '
        Me.cbxSoupNoodles.AutoSize = True
        Me.cbxSoupNoodles.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSoupNoodles.Location = New System.Drawing.Point(187, 101)
        Me.cbxSoupNoodles.Name = "cbxSoupNoodles"
        Me.cbxSoupNoodles.Size = New System.Drawing.Size(117, 40)
        Me.cbxSoupNoodles.TabIndex = 85
        Me.cbxSoupNoodles.Text = "Soup Noodles " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM4.50)"
        Me.cbxSoupNoodles.UseVisualStyleBackColor = True
        '
        'cbxChickenRice
        '
        Me.cbxChickenRice.AutoSize = True
        Me.cbxChickenRice.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxChickenRice.Location = New System.Drawing.Point(187, 36)
        Me.cbxChickenRice.Name = "cbxChickenRice"
        Me.cbxChickenRice.Size = New System.Drawing.Size(117, 40)
        Me.cbxChickenRice.TabIndex = 84
        Me.cbxChickenRice.Text = "Chicken Rice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM3.50)"
        Me.cbxChickenRice.UseVisualStyleBackColor = True
        '
        'QuantitySpaghetti
        '
        Me.QuantitySpaghetti.Enabled = False
        Me.QuantitySpaghetti.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantitySpaghetti.Location = New System.Drawing.Point(122, 361)
        Me.QuantitySpaghetti.Name = "QuantitySpaghetti"
        Me.QuantitySpaghetti.Size = New System.Drawing.Size(43, 23)
        Me.QuantitySpaghetti.TabIndex = 82
        '
        'cbxSpaghetti
        '
        Me.cbxSpaghetti.AutoSize = True
        Me.cbxSpaghetti.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSpaghetti.Location = New System.Drawing.Point(6, 353)
        Me.cbxSpaghetti.Name = "cbxSpaghetti"
        Me.cbxSpaghetti.Size = New System.Drawing.Size(94, 40)
        Me.cbxSpaghetti.TabIndex = 81
        Me.cbxSpaghetti.Text = "Spaghetti " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM4.50)"
        Me.cbxSpaghetti.UseVisualStyleBackColor = True
        '
        'QuantityPizza
        '
        Me.QuantityPizza.Enabled = False
        Me.QuantityPizza.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityPizza.Location = New System.Drawing.Point(122, 299)
        Me.QuantityPizza.Name = "QuantityPizza"
        Me.QuantityPizza.Size = New System.Drawing.Size(43, 23)
        Me.QuantityPizza.TabIndex = 80
        '
        'cbxPizza
        '
        Me.cbxPizza.AutoSize = True
        Me.cbxPizza.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPizza.Location = New System.Drawing.Point(6, 291)
        Me.cbxPizza.Name = "cbxPizza"
        Me.cbxPizza.Size = New System.Drawing.Size(72, 40)
        Me.cbxPizza.TabIndex = 79
        Me.cbxPizza.Text = "Pizza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM10)"
        Me.cbxPizza.UseVisualStyleBackColor = True
        '
        'QuantityBeefBurger
        '
        Me.QuantityBeefBurger.Enabled = False
        Me.QuantityBeefBurger.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityBeefBurger.Location = New System.Drawing.Point(122, 237)
        Me.QuantityBeefBurger.Name = "QuantityBeefBurger"
        Me.QuantityBeefBurger.Size = New System.Drawing.Size(43, 23)
        Me.QuantityBeefBurger.TabIndex = 78
        '
        'cbxBeefBurger
        '
        Me.cbxBeefBurger.AutoSize = True
        Me.cbxBeefBurger.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBeefBurger.Location = New System.Drawing.Point(6, 229)
        Me.cbxBeefBurger.Name = "cbxBeefBurger"
        Me.cbxBeefBurger.Size = New System.Drawing.Size(105, 40)
        Me.cbxBeefBurger.TabIndex = 77
        Me.cbxBeefBurger.Text = "Beef Burger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM7.50)"
        Me.cbxBeefBurger.UseVisualStyleBackColor = True
        '
        'QuantityChickenBurger
        '
        Me.QuantityChickenBurger.Enabled = False
        Me.QuantityChickenBurger.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityChickenBurger.Location = New System.Drawing.Point(122, 180)
        Me.QuantityChickenBurger.Name = "QuantityChickenBurger"
        Me.QuantityChickenBurger.Size = New System.Drawing.Size(43, 23)
        Me.QuantityChickenBurger.TabIndex = 76
        '
        'cbxChickenBurger
        '
        Me.cbxChickenBurger.AutoSize = True
        Me.cbxChickenBurger.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxChickenBurger.Location = New System.Drawing.Point(6, 163)
        Me.cbxChickenBurger.Name = "cbxChickenBurger"
        Me.cbxChickenBurger.Size = New System.Drawing.Size(137, 40)
        Me.cbxChickenBurger.TabIndex = 75
        Me.cbxChickenBurger.Text = "Chicken Burger " & Global.Microsoft.VisualBasic.ChrW(10) & "(RM6.50)"
        Me.cbxChickenBurger.UseVisualStyleBackColor = True
        '
        'QuantityFriedNoodles
        '
        Me.QuantityFriedNoodles.Enabled = False
        Me.QuantityFriedNoodles.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityFriedNoodles.Location = New System.Drawing.Point(122, 109)
        Me.QuantityFriedNoodles.Name = "QuantityFriedNoodles"
        Me.QuantityFriedNoodles.Size = New System.Drawing.Size(43, 23)
        Me.QuantityFriedNoodles.TabIndex = 72
        '
        'QuantityFriedRice
        '
        Me.QuantityFriedRice.Enabled = False
        Me.QuantityFriedRice.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityFriedRice.Location = New System.Drawing.Point(122, 44)
        Me.QuantityFriedRice.Name = "QuantityFriedRice"
        Me.QuantityFriedRice.Size = New System.Drawing.Size(43, 23)
        Me.QuantityFriedRice.TabIndex = 67
        '
        'cbxFriedNoodles
        '
        Me.cbxFriedNoodles.AutoSize = True
        Me.cbxFriedNoodles.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFriedNoodles.Location = New System.Drawing.Point(6, 101)
        Me.cbxFriedNoodles.Name = "cbxFriedNoodles"
        Me.cbxFriedNoodles.Size = New System.Drawing.Size(115, 40)
        Me.cbxFriedNoodles.TabIndex = 70
        Me.cbxFriedNoodles.Text = "Fried Noodles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM5)"
        Me.cbxFriedNoodles.UseVisualStyleBackColor = True
        '
        'cbxFriedRice
        '
        Me.cbxFriedRice.AutoSize = True
        Me.cbxFriedRice.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFriedRice.Location = New System.Drawing.Point(6, 36)
        Me.cbxFriedRice.Name = "cbxFriedRice"
        Me.cbxFriedRice.Size = New System.Drawing.Size(94, 40)
        Me.cbxFriedRice.TabIndex = 69
        Me.cbxFriedRice.Text = "Fried Rice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM5)"
        Me.cbxFriedRice.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDown23)
        Me.GroupBox2.Controls.Add(Me.CheckBox23)
        Me.GroupBox2.Controls.Add(Me.QuantityShake)
        Me.GroupBox2.Controls.Add(Me.cbxShake)
        Me.GroupBox2.Controls.Add(Me.QuantityMilo)
        Me.GroupBox2.Controls.Add(Me.cbxMilo)
        Me.GroupBox2.Controls.Add(Me.QuantityCannedDrinks)
        Me.GroupBox2.Controls.Add(Me.cbxCannedDrinks)
        Me.GroupBox2.Controls.Add(Me.QuantityLemonade)
        Me.GroupBox2.Controls.Add(Me.cbxLemonade)
        Me.GroupBox2.Controls.Add(Me.QuantitySirap)
        Me.GroupBox2.Controls.Add(Me.cbxSirap)
        Me.GroupBox2.Controls.Add(Me.QuantityMineral)
        Me.GroupBox2.Controls.Add(Me.cbxMineralWater)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(395, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 429)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drinks"
        '
        'NumericUpDown23
        '
        Me.NumericUpDown23.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown23.Location = New System.Drawing.Point(176, 474)
        Me.NumericUpDown23.Name = "NumericUpDown23"
        Me.NumericUpDown23.Size = New System.Drawing.Size(43, 23)
        Me.NumericUpDown23.TabIndex = 108
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox23.Location = New System.Drawing.Point(39, 466)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(137, 40)
        Me.CheckBox23.TabIndex = 109
        Me.CheckBox23.Text = "Shake of the day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM5)"
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'QuantityShake
        '
        Me.QuantityShake.Enabled = False
        Me.QuantityShake.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityShake.Location = New System.Drawing.Point(163, 361)
        Me.QuantityShake.Name = "QuantityShake"
        Me.QuantityShake.Size = New System.Drawing.Size(43, 23)
        Me.QuantityShake.TabIndex = 105
        '
        'cbxShake
        '
        Me.cbxShake.AutoSize = True
        Me.cbxShake.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShake.Location = New System.Drawing.Point(26, 353)
        Me.cbxShake.Name = "cbxShake"
        Me.cbxShake.Size = New System.Drawing.Size(137, 40)
        Me.cbxShake.TabIndex = 106
        Me.cbxShake.Text = "Shake of the day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM5)"
        Me.cbxShake.UseVisualStyleBackColor = True
        '
        'QuantityMilo
        '
        Me.QuantityMilo.Enabled = False
        Me.QuantityMilo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityMilo.Location = New System.Drawing.Point(163, 299)
        Me.QuantityMilo.Name = "QuantityMilo"
        Me.QuantityMilo.Size = New System.Drawing.Size(43, 23)
        Me.QuantityMilo.TabIndex = 103
        '
        'cbxMilo
        '
        Me.cbxMilo.AutoSize = True
        Me.cbxMilo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMilo.Location = New System.Drawing.Point(26, 291)
        Me.cbxMilo.Name = "cbxMilo"
        Me.cbxMilo.Size = New System.Drawing.Size(64, 40)
        Me.cbxMilo.TabIndex = 104
        Me.cbxMilo.Text = "Milo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM2)"
        Me.cbxMilo.UseVisualStyleBackColor = True
        '
        'QuantityCannedDrinks
        '
        Me.QuantityCannedDrinks.Enabled = False
        Me.QuantityCannedDrinks.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityCannedDrinks.Location = New System.Drawing.Point(163, 237)
        Me.QuantityCannedDrinks.Name = "QuantityCannedDrinks"
        Me.QuantityCannedDrinks.Size = New System.Drawing.Size(43, 23)
        Me.QuantityCannedDrinks.TabIndex = 101
        '
        'cbxCannedDrinks
        '
        Me.cbxCannedDrinks.AutoSize = True
        Me.cbxCannedDrinks.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCannedDrinks.Location = New System.Drawing.Point(26, 229)
        Me.cbxCannedDrinks.Name = "cbxCannedDrinks"
        Me.cbxCannedDrinks.Size = New System.Drawing.Size(128, 40)
        Me.cbxCannedDrinks.TabIndex = 102
        Me.cbxCannedDrinks.Text = "Canned Drinks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM2.50)"
        Me.cbxCannedDrinks.UseVisualStyleBackColor = True
        '
        'QuantityLemonade
        '
        Me.QuantityLemonade.Enabled = False
        Me.QuantityLemonade.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLemonade.Location = New System.Drawing.Point(163, 173)
        Me.QuantityLemonade.Name = "QuantityLemonade"
        Me.QuantityLemonade.Size = New System.Drawing.Size(43, 23)
        Me.QuantityLemonade.TabIndex = 99
        '
        'cbxLemonade
        '
        Me.cbxLemonade.AutoSize = True
        Me.cbxLemonade.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLemonade.Location = New System.Drawing.Point(26, 165)
        Me.cbxLemonade.Name = "cbxLemonade"
        Me.cbxLemonade.Size = New System.Drawing.Size(95, 40)
        Me.cbxLemonade.TabIndex = 100
        Me.cbxLemonade.Text = "Lemonade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM1.50)"
        Me.cbxLemonade.UseVisualStyleBackColor = True
        '
        'QuantitySirap
        '
        Me.QuantitySirap.Enabled = False
        Me.QuantitySirap.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantitySirap.Location = New System.Drawing.Point(163, 109)
        Me.QuantitySirap.Name = "QuantitySirap"
        Me.QuantitySirap.Size = New System.Drawing.Size(43, 23)
        Me.QuantitySirap.TabIndex = 97
        '
        'cbxSirap
        '
        Me.cbxSirap.AutoSize = True
        Me.cbxSirap.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSirap.Location = New System.Drawing.Point(26, 101)
        Me.cbxSirap.Name = "cbxSirap"
        Me.cbxSirap.Size = New System.Drawing.Size(84, 40)
        Me.cbxSirap.TabIndex = 98
        Me.cbxSirap.Text = "Sirap " & Global.Microsoft.VisualBasic.ChrW(10) & "(RM1.50)"
        Me.cbxSirap.UseVisualStyleBackColor = True
        '
        'QuantityMineral
        '
        Me.QuantityMineral.Enabled = False
        Me.QuantityMineral.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityMineral.Location = New System.Drawing.Point(163, 52)
        Me.QuantityMineral.Name = "QuantityMineral"
        Me.QuantityMineral.Size = New System.Drawing.Size(43, 23)
        Me.QuantityMineral.TabIndex = 95
        '
        'cbxMineralWater
        '
        Me.cbxMineralWater.AutoSize = True
        Me.cbxMineralWater.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMineralWater.Location = New System.Drawing.Point(26, 44)
        Me.cbxMineralWater.Name = "cbxMineralWater"
        Me.cbxMineralWater.Size = New System.Drawing.Size(126, 40)
        Me.cbxMineralWater.TabIndex = 96
        Me.cbxMineralWater.Text = "Mineral Water " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM1)"
        Me.cbxMineralWater.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.QuantityApplePie)
        Me.GroupBox3.Controls.Add(Me.cbxApplePie)
        Me.GroupBox3.Controls.Add(Me.QuantityShavedIce)
        Me.GroupBox3.Controls.Add(Me.cbxShavedIce)
        Me.GroupBox3.Controls.Add(Me.QuantityVanillaCake)
        Me.GroupBox3.Controls.Add(Me.QuantityIceCream)
        Me.GroupBox3.Controls.Add(Me.cbxIceCream)
        Me.GroupBox3.Controls.Add(Me.QuantityChocolateCake)
        Me.GroupBox3.Controls.Add(Me.cbxChocolateCake)
        Me.GroupBox3.Controls.Add(Me.QuantityStrawberryCake)
        Me.GroupBox3.Controls.Add(Me.cbxVanillaCake)
        Me.GroupBox3.Controls.Add(Me.cbxStrawberry)
        Me.GroupBox3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(643, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 231)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Desserts"
        '
        'QuantityApplePie
        '
        Me.QuantityApplePie.Enabled = False
        Me.QuantityApplePie.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityApplePie.Location = New System.Drawing.Point(258, 180)
        Me.QuantityApplePie.Name = "QuantityApplePie"
        Me.QuantityApplePie.Size = New System.Drawing.Size(43, 23)
        Me.QuantityApplePie.TabIndex = 117
        '
        'cbxApplePie
        '
        Me.cbxApplePie.AutoSize = True
        Me.cbxApplePie.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxApplePie.Location = New System.Drawing.Point(175, 163)
        Me.cbxApplePie.Name = "cbxApplePie"
        Me.cbxApplePie.Size = New System.Drawing.Size(91, 40)
        Me.cbxApplePie.TabIndex = 118
        Me.cbxApplePie.Text = "Apple Pie " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM4.50)"
        Me.cbxApplePie.UseVisualStyleBackColor = True
        '
        'QuantityShavedIce
        '
        Me.QuantityShavedIce.Enabled = False
        Me.QuantityShavedIce.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityShavedIce.Location = New System.Drawing.Point(258, 118)
        Me.QuantityShavedIce.Name = "QuantityShavedIce"
        Me.QuantityShavedIce.Size = New System.Drawing.Size(43, 23)
        Me.QuantityShavedIce.TabIndex = 115
        '
        'cbxShavedIce
        '
        Me.cbxShavedIce.AutoSize = True
        Me.cbxShavedIce.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShavedIce.Location = New System.Drawing.Point(175, 101)
        Me.cbxShavedIce.Name = "cbxShavedIce"
        Me.cbxShavedIce.Size = New System.Drawing.Size(103, 40)
        Me.cbxShavedIce.TabIndex = 116
        Me.cbxShavedIce.Text = "Shaved Ice " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM3.50)"
        Me.cbxShavedIce.UseVisualStyleBackColor = True
        '
        'QuantityVanillaCake
        '
        Me.QuantityVanillaCake.Enabled = False
        Me.QuantityVanillaCake.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityVanillaCake.Location = New System.Drawing.Point(104, 118)
        Me.QuantityVanillaCake.Name = "QuantityVanillaCake"
        Me.QuantityVanillaCake.Size = New System.Drawing.Size(43, 23)
        Me.QuantityVanillaCake.TabIndex = 109
        '
        'QuantityIceCream
        '
        Me.QuantityIceCream.Enabled = False
        Me.QuantityIceCream.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityIceCream.Location = New System.Drawing.Point(258, 61)
        Me.QuantityIceCream.Name = "QuantityIceCream"
        Me.QuantityIceCream.Size = New System.Drawing.Size(43, 23)
        Me.QuantityIceCream.TabIndex = 113
        '
        'cbxIceCream
        '
        Me.cbxIceCream.AutoSize = True
        Me.cbxIceCream.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIceCream.Location = New System.Drawing.Point(175, 44)
        Me.cbxIceCream.Name = "cbxIceCream"
        Me.cbxIceCream.Size = New System.Drawing.Size(100, 40)
        Me.cbxIceCream.TabIndex = 114
        Me.cbxIceCream.Text = "Ice Cream " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM1.50)"
        Me.cbxIceCream.UseVisualStyleBackColor = True
        '
        'QuantityChocolateCake
        '
        Me.QuantityChocolateCake.Enabled = False
        Me.QuantityChocolateCake.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityChocolateCake.Location = New System.Drawing.Point(104, 61)
        Me.QuantityChocolateCake.Name = "QuantityChocolateCake"
        Me.QuantityChocolateCake.Size = New System.Drawing.Size(43, 23)
        Me.QuantityChocolateCake.TabIndex = 107
        '
        'cbxChocolateCake
        '
        Me.cbxChocolateCake.AutoSize = True
        Me.cbxChocolateCake.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxChocolateCake.Location = New System.Drawing.Point(21, 44)
        Me.cbxChocolateCake.Name = "cbxChocolateCake"
        Me.cbxChocolateCake.Size = New System.Drawing.Size(135, 40)
        Me.cbxChocolateCake.TabIndex = 108
        Me.cbxChocolateCake.Text = "Chocolate Cake " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM2.50)"
        Me.cbxChocolateCake.UseVisualStyleBackColor = True
        '
        'QuantityStrawberryCake
        '
        Me.QuantityStrawberryCake.Enabled = False
        Me.QuantityStrawberryCake.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityStrawberryCake.Location = New System.Drawing.Point(104, 182)
        Me.QuantityStrawberryCake.Name = "QuantityStrawberryCake"
        Me.QuantityStrawberryCake.Size = New System.Drawing.Size(43, 23)
        Me.QuantityStrawberryCake.TabIndex = 111
        '
        'cbxVanillaCake
        '
        Me.cbxVanillaCake.AutoSize = True
        Me.cbxVanillaCake.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxVanillaCake.Location = New System.Drawing.Point(21, 101)
        Me.cbxVanillaCake.Name = "cbxVanillaCake"
        Me.cbxVanillaCake.Size = New System.Drawing.Size(117, 40)
        Me.cbxVanillaCake.TabIndex = 110
        Me.cbxVanillaCake.Text = "Vanilla Cake " & Global.Microsoft.VisualBasic.ChrW(10) & "(RM2.50)"
        Me.cbxVanillaCake.UseVisualStyleBackColor = True
        '
        'cbxStrawberry
        '
        Me.cbxStrawberry.AutoSize = True
        Me.cbxStrawberry.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxStrawberry.Location = New System.Drawing.Point(21, 165)
        Me.cbxStrawberry.Name = "cbxStrawberry"
        Me.cbxStrawberry.Size = New System.Drawing.Size(142, 40)
        Me.cbxStrawberry.TabIndex = 112
        Me.cbxStrawberry.Text = "Strawberry Cake " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM2.50)"
        Me.cbxStrawberry.UseVisualStyleBackColor = True
        '
        'PanelCheckItems
        '
        Me.PanelCheckItems.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PanelCheckItems.Controls.Add(Me.Panel2)
        Me.PanelCheckItems.Controls.Add(Me.Label7)
        Me.PanelCheckItems.Controls.Add(Me.Label6)
        Me.PanelCheckItems.Controls.Add(Me.Label1)
        Me.PanelCheckItems.Controls.Add(Me.btnCloseItemPanel)
        Me.PanelCheckItems.Controls.Add(Me.Label3)
        Me.PanelCheckItems.Controls.Add(Me.lbxPrice)
        Me.PanelCheckItems.Controls.Add(Me.lbxQuantity)
        Me.PanelCheckItems.Controls.Add(Me.lbxFoodSelected)
        Me.PanelCheckItems.Location = New System.Drawing.Point(158, 52)
        Me.PanelCheckItems.Name = "PanelCheckItems"
        Me.PanelCheckItems.Size = New System.Drawing.Size(443, 519)
        Me.PanelCheckItems.TabIndex = 73
        Me.PanelCheckItems.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(440, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 519)
        Me.Panel2.TabIndex = 131
        Me.Panel2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(133, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 42)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 21)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Payment"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(51, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 392)
        Me.Panel3.TabIndex = 111
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(82, 305)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 42)
        Me.Button2.TabIndex = 129
        Me.Button2.Text = "Balance"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(145, 174)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 23)
        Me.TextBox1.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 18)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Tax (6%) : RM0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 20)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Total Amount : RM0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 18)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Customer Pays :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(70, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 18)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Balance : RM0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(69, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 18)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Subtotal : RM0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(274, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Item"
        '
        'btnCloseItemPanel
        '
        Me.btnCloseItemPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCloseItemPanel.FlatAppearance.BorderSize = 0
        Me.btnCloseItemPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseItemPanel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseItemPanel.Location = New System.Drawing.Point(156, 457)
        Me.btnCloseItemPanel.Name = "btnCloseItemPanel"
        Me.btnCloseItemPanel.Size = New System.Drawing.Size(102, 42)
        Me.btnCloseItemPanel.TabIndex = 111
        Me.btnCloseItemPanel.Text = "Close"
        Me.btnCloseItemPanel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Selected Items"
        '
        'lbxPrice
        '
        Me.lbxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxPrice.FormattingEnabled = True
        Me.lbxPrice.Location = New System.Drawing.Point(275, 59)
        Me.lbxPrice.Name = "lbxPrice"
        Me.lbxPrice.Size = New System.Drawing.Size(128, 390)
        Me.lbxPrice.TabIndex = 2
        '
        'lbxQuantity
        '
        Me.lbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxQuantity.FormattingEnabled = True
        Me.lbxQuantity.Location = New System.Drawing.Point(150, 59)
        Me.lbxQuantity.Name = "lbxQuantity"
        Me.lbxQuantity.Size = New System.Drawing.Size(128, 390)
        Me.lbxQuantity.TabIndex = 1
        '
        'lbxFoodSelected
        '
        Me.lbxFoodSelected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxFoodSelected.FormattingEnabled = True
        Me.lbxFoodSelected.Location = New System.Drawing.Point(7, 59)
        Me.lbxFoodSelected.Name = "lbxFoodSelected"
        Me.lbxFoodSelected.Size = New System.Drawing.Size(146, 390)
        Me.lbxFoodSelected.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Customer No. :"
        '
        'lblPaymentTax
        '
        Me.lblPaymentTax.AutoSize = True
        Me.lblPaymentTax.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentTax.Location = New System.Drawing.Point(67, 72)
        Me.lblPaymentTax.Name = "lblPaymentTax"
        Me.lblPaymentTax.Size = New System.Drawing.Size(105, 18)
        Me.lblPaymentTax.TabIndex = 128
        Me.lblPaymentTax.Text = "Tax (6%) : RM0"
        '
        'lblPaymentSubtotal
        '
        Me.lblPaymentSubtotal.AutoSize = True
        Me.lblPaymentSubtotal.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentSubtotal.Location = New System.Drawing.Point(69, 19)
        Me.lblPaymentSubtotal.Name = "lblPaymentSubtotal"
        Me.lblPaymentSubtotal.Size = New System.Drawing.Size(103, 18)
        Me.lblPaymentSubtotal.TabIndex = 127
        Me.lblPaymentSubtotal.Text = "Subtotal : RM0"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(79, 213)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(102, 18)
        Me.lblBalance.TabIndex = 126
        Me.lblBalance.Text = "Balance : RM0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Customer Pays :"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(34, 125)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(140, 20)
        Me.lblTotalAmount.TabIndex = 124
        Me.lblTotalAmount.Text = "Total Amount : RM0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.btnCustomerPayment)
        Me.Panel1.Controls.Add(Me.lblBalance)
        Me.Panel1.Controls.Add(Me.btnBalance)
        Me.Panel1.Controls.Add(Me.txtCustPays)
        Me.Panel1.Controls.Add(Me.lblPaymentTax)
        Me.Panel1.Controls.Add(Me.lblTotalAmount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblPaymentSubtotal)
        Me.Panel1.Location = New System.Drawing.Point(51, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 392)
        Me.Panel1.TabIndex = 111
        '
        'btnCustomerPayment
        '
        Me.btnCustomerPayment.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCustomerPayment.FlatAppearance.BorderSize = 0
        Me.btnCustomerPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerPayment.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerPayment.Location = New System.Drawing.Point(27, 252)
        Me.btnCustomerPayment.Name = "btnCustomerPayment"
        Me.btnCustomerPayment.Size = New System.Drawing.Size(200, 42)
        Me.btnCustomerPayment.TabIndex = 131
        Me.btnCustomerPayment.Text = "Customer Payment Method"
        Me.btnCustomerPayment.UseVisualStyleBackColor = False
        '
        'btnBalance
        '
        Me.btnBalance.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBalance.FlatAppearance.BorderSize = 0
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalance.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.Location = New System.Drawing.Point(82, 328)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(102, 42)
        Me.btnBalance.TabIndex = 129
        Me.btnBalance.Text = "Balance"
        Me.btnBalance.UseVisualStyleBackColor = False
        '
        'txtCustPays
        '
        Me.txtCustPays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustPays.Location = New System.Drawing.Point(145, 174)
        Me.txtCustPays.Name = "txtCustPays"
        Me.txtCustPays.ReadOnly = True
        Me.txtCustPays.Size = New System.Drawing.Size(71, 23)
        Me.txtCustPays.TabIndex = 75
        '
        'PanelPayment
        '
        Me.PanelPayment.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PanelPayment.Controls.Add(Me.btnConfrim)
        Me.PanelPayment.Controls.Add(Me.Label2)
        Me.PanelPayment.Controls.Add(Me.Panel1)
        Me.PanelPayment.Location = New System.Drawing.Point(601, 52)
        Me.PanelPayment.Name = "PanelPayment"
        Me.PanelPayment.Size = New System.Drawing.Size(355, 531)
        Me.PanelPayment.TabIndex = 115
        Me.PanelPayment.Visible = False
        '
        'btnConfrim
        '
        Me.btnConfrim.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnConfrim.Enabled = False
        Me.btnConfrim.FlatAppearance.BorderSize = 0
        Me.btnConfrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfrim.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfrim.Location = New System.Drawing.Point(133, 457)
        Me.btnConfrim.Name = "btnConfrim"
        Me.btnConfrim.Size = New System.Drawing.Size(102, 42)
        Me.btnConfrim.TabIndex = 130
        Me.btnConfrim.Text = "Confirm"
        Me.btnConfrim.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Payment"
        '
        'PanelCustomerNumber
        '
        Me.PanelCustomerNumber.Controls.Add(Me.txtCustomerID)
        Me.PanelCustomerNumber.Controls.Add(Me.lblPrompt)
        Me.PanelCustomerNumber.Controls.Add(Me.Label14)
        Me.PanelCustomerNumber.Controls.Add(Me.txtOrderID)
        Me.PanelCustomerNumber.Controls.Add(Me.Label5)
        Me.PanelCustomerNumber.Location = New System.Drawing.Point(179, 3)
        Me.PanelCustomerNumber.Name = "PanelCustomerNumber"
        Me.PanelCustomerNumber.Size = New System.Drawing.Size(649, 43)
        Me.PanelCustomerNumber.TabIndex = 116
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(441, 12)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(164, 18)
        Me.lblPrompt.TabIndex = 77
        Me.lblPrompt.Text = "Order No must be above"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(258, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 18)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Order No :"
        '
        'txtOrderID
        '
        Me.txtOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderID.Location = New System.Drawing.Point(338, 12)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(97, 23)
        Me.txtOrderID.TabIndex = 76
        '
        'pnlCustomerPayment
        '
        Me.pnlCustomerPayment.BackColor = System.Drawing.Color.SkyBlue
        Me.pnlCustomerPayment.Controls.Add(Me.btnCustomerPaymentClose)
        Me.pnlCustomerPayment.Controls.Add(Me.btnCustomerPaymentClear)
        Me.pnlCustomerPayment.Controls.Add(Me.btn5sen)
        Me.pnlCustomerPayment.Controls.Add(Me.btn10sen)
        Me.pnlCustomerPayment.Controls.Add(Me.btn20sen)
        Me.pnlCustomerPayment.Controls.Add(Me.btn50sen)
        Me.pnlCustomerPayment.Controls.Add(Me.btnRM1)
        Me.pnlCustomerPayment.Controls.Add(Me.btnRM5)
        Me.pnlCustomerPayment.Controls.Add(Me.btnRM10)
        Me.pnlCustomerPayment.Controls.Add(Me.btnRM20)
        Me.pnlCustomerPayment.Controls.Add(Me.btnRM50)
        Me.pnlCustomerPayment.Controls.Add(Me.btnRM100)
        Me.pnlCustomerPayment.Controls.Add(Me.txtCustomerPaymentAmount)
        Me.pnlCustomerPayment.Controls.Add(Me.Label15)
        Me.pnlCustomerPayment.Location = New System.Drawing.Point(158, 52)
        Me.pnlCustomerPayment.Name = "pnlCustomerPayment"
        Me.pnlCustomerPayment.Size = New System.Drawing.Size(443, 531)
        Me.pnlCustomerPayment.TabIndex = 117
        Me.pnlCustomerPayment.Visible = False
        '
        'btnCustomerPaymentClose
        '
        Me.btnCustomerPaymentClose.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCustomerPaymentClose.FlatAppearance.BorderSize = 0
        Me.btnCustomerPaymentClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerPaymentClose.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerPaymentClose.Location = New System.Drawing.Point(201, 461)
        Me.btnCustomerPaymentClose.Name = "btnCustomerPaymentClose"
        Me.btnCustomerPaymentClose.Size = New System.Drawing.Size(102, 42)
        Me.btnCustomerPaymentClose.TabIndex = 144
        Me.btnCustomerPaymentClose.Text = "Confirm"
        Me.btnCustomerPaymentClose.UseVisualStyleBackColor = False
        '
        'btnCustomerPaymentClear
        '
        Me.btnCustomerPaymentClear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCustomerPaymentClear.FlatAppearance.BorderSize = 0
        Me.btnCustomerPaymentClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerPaymentClear.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerPaymentClear.Location = New System.Drawing.Point(260, 14)
        Me.btnCustomerPaymentClear.Name = "btnCustomerPaymentClear"
        Me.btnCustomerPaymentClear.Size = New System.Drawing.Size(102, 42)
        Me.btnCustomerPaymentClear.TabIndex = 132
        Me.btnCustomerPaymentClear.Text = "Clear"
        Me.btnCustomerPaymentClear.UseVisualStyleBackColor = False
        '
        'btn5sen
        '
        Me.btn5sen.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._5sen
        Me.btn5sen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn5sen.Location = New System.Drawing.Point(76, 440)
        Me.btn5sen.Name = "btn5sen"
        Me.btn5sen.Size = New System.Drawing.Size(94, 85)
        Me.btn5sen.TabIndex = 142
        Me.btn5sen.UseVisualStyleBackColor = True
        '
        'btn10sen
        '
        Me.btn10sen.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._10sen
        Me.btn10sen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn10sen.Location = New System.Drawing.Point(260, 352)
        Me.btn10sen.Name = "btn10sen"
        Me.btn10sen.Size = New System.Drawing.Size(94, 85)
        Me.btn10sen.TabIndex = 141
        Me.btn10sen.UseVisualStyleBackColor = True
        '
        'btn20sen
        '
        Me.btn20sen.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._20sen
        Me.btn20sen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn20sen.Location = New System.Drawing.Point(140, 352)
        Me.btn20sen.Name = "btn20sen"
        Me.btn20sen.Size = New System.Drawing.Size(94, 85)
        Me.btn20sen.TabIndex = 140
        Me.btn20sen.UseVisualStyleBackColor = True
        '
        'btn50sen
        '
        Me.btn50sen.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._50sen
        Me.btn50sen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn50sen.Location = New System.Drawing.Point(22, 349)
        Me.btn50sen.Name = "btn50sen"
        Me.btn50sen.Size = New System.Drawing.Size(94, 85)
        Me.btn50sen.TabIndex = 139
        Me.btn50sen.UseVisualStyleBackColor = True
        '
        'btnRM1
        '
        Me.btnRM1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.RM1
        Me.btnRM1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRM1.Location = New System.Drawing.Point(201, 251)
        Me.btnRM1.Name = "btnRM1"
        Me.btnRM1.Size = New System.Drawing.Size(137, 67)
        Me.btnRM1.TabIndex = 138
        Me.btnRM1.UseVisualStyleBackColor = True
        '
        'btnRM5
        '
        Me.btnRM5.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.RM5
        Me.btnRM5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRM5.Location = New System.Drawing.Point(33, 251)
        Me.btnRM5.Name = "btnRM5"
        Me.btnRM5.Size = New System.Drawing.Size(137, 67)
        Me.btnRM5.TabIndex = 137
        Me.btnRM5.UseVisualStyleBackColor = True
        '
        'btnRM10
        '
        Me.btnRM10.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.RM10
        Me.btnRM10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRM10.Location = New System.Drawing.Point(201, 168)
        Me.btnRM10.Name = "btnRM10"
        Me.btnRM10.Size = New System.Drawing.Size(137, 67)
        Me.btnRM10.TabIndex = 136
        Me.btnRM10.UseVisualStyleBackColor = True
        '
        'btnRM20
        '
        Me.btnRM20.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.RM20
        Me.btnRM20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRM20.Location = New System.Drawing.Point(33, 170)
        Me.btnRM20.Name = "btnRM20"
        Me.btnRM20.Size = New System.Drawing.Size(137, 67)
        Me.btnRM20.TabIndex = 135
        Me.btnRM20.UseVisualStyleBackColor = True
        '
        'btnRM50
        '
        Me.btnRM50.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.RM50
        Me.btnRM50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRM50.Location = New System.Drawing.Point(201, 84)
        Me.btnRM50.Name = "btnRM50"
        Me.btnRM50.Size = New System.Drawing.Size(137, 67)
        Me.btnRM50.TabIndex = 134
        Me.btnRM50.UseVisualStyleBackColor = True
        '
        'btnRM100
        '
        Me.btnRM100.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.RM100
        Me.btnRM100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRM100.Location = New System.Drawing.Point(33, 84)
        Me.btnRM100.Name = "btnRM100"
        Me.btnRM100.Size = New System.Drawing.Size(137, 67)
        Me.btnRM100.TabIndex = 133
        Me.btnRM100.UseVisualStyleBackColor = True
        '
        'txtCustomerPaymentAmount
        '
        Me.txtCustomerPaymentAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerPaymentAmount.Location = New System.Drawing.Point(140, 27)
        Me.txtCustomerPaymentAmount.Name = "txtCustomerPaymentAmount"
        Me.txtCustomerPaymentAmount.ReadOnly = True
        Me.txtCustomerPaymentAmount.Size = New System.Drawing.Size(110, 23)
        Me.txtCustomerPaymentAmount.TabIndex = 132
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 18)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Customer Pays :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCustomerID.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.FormattingEnabled = True
        Me.txtCustomerID.Location = New System.Drawing.Point(121, 9)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(81, 26)
        Me.txtCustomerID.TabIndex = 118
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1460, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlCustomerPayment)
        Me.Controls.Add(Me.PanelCustomerNumber)
        Me.Controls.Add(Me.PanelCheckItems)
        Me.Controls.Add(Me.PanelPayment)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel5)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmOrder"
        Me.Text = "Order"
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.QuantityToast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityRotiCanai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySandwich, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityShepardpie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySoupNoodles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityChickenRice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySpaghetti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityPizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityBeefBurger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityChickenBurger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityFriedNoodles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityFriedRice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityShake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityMilo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityCannedDrinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityLemonade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantitySirap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityMineral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.QuantityApplePie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityShavedIce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityVanillaCake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityIceCream, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityChocolateCake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityStrawberryCake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCheckItems.ResumeLayout(False)
        Me.PanelCheckItems.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelPayment.ResumeLayout(False)
        Me.PanelPayment.PerformLayout()
        Me.PanelCustomerNumber.ResumeLayout(False)
        Me.PanelCustomerNumber.PerformLayout()
        Me.pnlCustomerPayment.ResumeLayout(False)
        Me.pnlCustomerPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QuantityToast As NumericUpDown
    Friend WithEvents cbxToast As CheckBox
    Friend WithEvents QuantityRotiCanai As NumericUpDown
    Friend WithEvents cbxRotiCanai As CheckBox
    Friend WithEvents QuantitySandwich As NumericUpDown
    Friend WithEvents cbxSandwich As CheckBox
    Friend WithEvents QuantityShepardpie As NumericUpDown
    Friend WithEvents cbxShepardpie As CheckBox
    Friend WithEvents QuantitySoupNoodles As NumericUpDown
    Friend WithEvents QuantityChickenRice As NumericUpDown
    Friend WithEvents cbxSoupNoodles As CheckBox
    Friend WithEvents cbxChickenRice As CheckBox
    Friend WithEvents QuantitySpaghetti As NumericUpDown
    Friend WithEvents cbxSpaghetti As CheckBox
    Friend WithEvents QuantityPizza As NumericUpDown
    Friend WithEvents cbxPizza As CheckBox
    Friend WithEvents QuantityBeefBurger As NumericUpDown
    Friend WithEvents cbxBeefBurger As CheckBox
    Friend WithEvents QuantityChickenBurger As NumericUpDown
    Friend WithEvents cbxChickenBurger As CheckBox
    Friend WithEvents QuantityFriedNoodles As NumericUpDown
    Friend WithEvents QuantityFriedRice As NumericUpDown
    Friend WithEvents cbxFriedNoodles As CheckBox
    Friend WithEvents cbxFriedRice As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbxMineralWater As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents NumericUpDown23 As NumericUpDown
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents QuantityShake As NumericUpDown
    Friend WithEvents cbxShake As CheckBox
    Friend WithEvents QuantityMilo As NumericUpDown
    Friend WithEvents cbxMilo As CheckBox
    Friend WithEvents QuantityCannedDrinks As NumericUpDown
    Friend WithEvents cbxCannedDrinks As CheckBox
    Friend WithEvents QuantityLemonade As NumericUpDown
    Friend WithEvents cbxLemonade As CheckBox
    Friend WithEvents QuantitySirap As NumericUpDown
    Friend WithEvents cbxSirap As CheckBox
    Friend WithEvents QuantityMineral As NumericUpDown
    Friend WithEvents QuantityApplePie As NumericUpDown
    Friend WithEvents cbxApplePie As CheckBox
    Friend WithEvents QuantityShavedIce As NumericUpDown
    Friend WithEvents cbxShavedIce As CheckBox
    Friend WithEvents QuantityVanillaCake As NumericUpDown
    Friend WithEvents QuantityIceCream As NumericUpDown
    Friend WithEvents cbxIceCream As CheckBox
    Friend WithEvents QuantityChocolateCake As NumericUpDown
    Friend WithEvents cbxChocolateCake As CheckBox
    Friend WithEvents QuantityStrawberryCake As NumericUpDown
    Friend WithEvents cbxVanillaCake As CheckBox
    Friend WithEvents cbxStrawberry As CheckBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCheckItems As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents PanelCheckItems As Panel
    Friend WithEvents btnCloseItemPanel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbxPrice As ListBox
    Friend WithEvents lbxQuantity As ListBox
    Friend WithEvents lbxFoodSelected As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents lblPaymentTax As Label
    Friend WithEvents lblPaymentSubtotal As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelPayment As Panel
    Friend WithEvents PanelCustomerNumber As Panel
    Friend WithEvents txtCustPays As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfrim As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnBalance As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnCustomerPayment As Button
    Friend WithEvents pnlCustomerPayment As Panel
    Friend WithEvents btn5sen As Button
    Friend WithEvents btn10sen As Button
    Friend WithEvents btn20sen As Button
    Friend WithEvents btn50sen As Button
    Friend WithEvents btnRM1 As Button
    Friend WithEvents btnRM5 As Button
    Friend WithEvents btnRM10 As Button
    Friend WithEvents btnRM20 As Button
    Friend WithEvents btnRM50 As Button
    Friend WithEvents btnRM100 As Button
    Friend WithEvents txtCustomerPaymentAmount As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCustomerPaymentClose As Button
    Friend WithEvents btnCustomerPaymentClear As Button
    Friend WithEvents txtCustomerID As ComboBox
End Class
