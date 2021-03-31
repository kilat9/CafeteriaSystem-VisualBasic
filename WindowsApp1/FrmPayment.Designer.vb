<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPayment
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnRegisterStaff = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.lblProfileID = New System.Windows.Forms.Label()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbxPrice = New System.Windows.Forms.ListBox()
        Me.lbxQuantity = New System.Windows.Forms.ListBox()
        Me.lbxFoodSelected = New System.Windows.Forms.ListBox()
        Me.btnCloseItemPanel = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(0, 292)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(197, 73)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.SkyBlue
        Me.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(0, 73)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(197, 73)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnRegisterStaff
        '
        Me.btnRegisterStaff.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegisterStaff.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnRegisterStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRegisterStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterStaff.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterStaff.Location = New System.Drawing.Point(0, 219)
        Me.btnRegisterStaff.Name = "btnRegisterStaff"
        Me.btnRegisterStaff.Size = New System.Drawing.Size(197, 73)
        Me.btnRegisterStaff.TabIndex = 2
        Me.btnRegisterStaff.Text = "REGISTER NEW STAFF"
        Me.btnRegisterStaff.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(0, 146)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(197, 73)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "REGISTER CUSTOMER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(197, 73)
        Me.btnMainMenu.TabIndex = 0
        Me.btnMainMenu.Text = "MAIN MENU"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Controls.Add(Me.btnOrder)
        Me.Panel3.Controls.Add(Me.btnRegisterStaff)
        Me.Panel3.Controls.Add(Me.btnRegister)
        Me.Panel3.Controls.Add(Me.btnMainMenu)
        Me.Panel3.Location = New System.Drawing.Point(4, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 385)
        Me.Panel3.TabIndex = 26
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(221, 111)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 18)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 385)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(493, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PAYMENT"
        '
        'lblProfileName
        '
        Me.lblProfileName.AutoSize = True
        Me.lblProfileName.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileName.Location = New System.Drawing.Point(44, 90)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(81, 18)
        Me.lblProfileName.TabIndex = 5
        Me.lblProfileName.Text = "Staff Name"
        '
        'lblProfileID
        '
        Me.lblProfileID.AutoSize = True
        Me.lblProfileID.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileID.Location = New System.Drawing.Point(56, 108)
        Me.lblProfileID.Name = "lblProfileID"
        Me.lblProfileID.Size = New System.Drawing.Size(53, 18)
        Me.lblProfileID.TabIndex = 6
        Me.lblProfileID.Text = "StaffID"
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.Location = New System.Drawing.Point(871, 3)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(0, 18)
        Me.lblLogOut.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.lblProfileName)
        Me.Panel4.Controls.Add(Me.lblProfileID)
        Me.Panel4.Location = New System.Drawing.Point(930, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(154, 131)
        Me.Panel4.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.Profile
        Me.PictureBox2.Location = New System.Drawing.Point(35, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.lblLogOut)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 134)
        Me.Panel1.TabIndex = 25
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(671, 93)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 42)
        Me.Button6.TabIndex = 116
        Me.Button6.Text = "Receipt"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SkyBlue
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(569, 93)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 42)
        Me.Button5.TabIndex = 115
        Me.Button5.Text = "Payment"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(467, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 42)
        Me.Button4.TabIndex = 114
        Me.Button4.Text = "Menu List"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.APUFnBTransparent
        Me.PictureBox1.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.lbxPrice)
        Me.Panel7.Controls.Add(Me.lbxQuantity)
        Me.Panel7.Controls.Add(Me.lbxFoodSelected)
        Me.Panel7.Location = New System.Drawing.Point(222, 146)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(431, 379)
        Me.Panel7.TabIndex = 74
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
        Me.lbxPrice.Location = New System.Drawing.Point(281, 41)
        Me.lbxPrice.Name = "lbxPrice"
        Me.lbxPrice.Size = New System.Drawing.Size(128, 325)
        Me.lbxPrice.TabIndex = 2
        '
        'lbxQuantity
        '
        Me.lbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxQuantity.FormattingEnabled = True
        Me.lbxQuantity.Location = New System.Drawing.Point(156, 41)
        Me.lbxQuantity.Name = "lbxQuantity"
        Me.lbxQuantity.Size = New System.Drawing.Size(128, 325)
        Me.lbxQuantity.TabIndex = 1
        '
        'lbxFoodSelected
        '
        Me.lbxFoodSelected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxFoodSelected.FormattingEnabled = True
        Me.lbxFoodSelected.Location = New System.Drawing.Point(13, 41)
        Me.lbxFoodSelected.Name = "lbxFoodSelected"
        Me.lbxFoodSelected.Size = New System.Drawing.Size(146, 325)
        Me.lbxFoodSelected.TabIndex = 0
        '
        'btnCloseItemPanel
        '
        Me.btnCloseItemPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCloseItemPanel.FlatAppearance.BorderSize = 0
        Me.btnCloseItemPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseItemPanel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseItemPanel.Location = New System.Drawing.Point(669, 482)
        Me.btnCloseItemPanel.Name = "btnCloseItemPanel"
        Me.btnCloseItemPanel.Size = New System.Drawing.Size(102, 42)
        Me.btnCloseItemPanel.TabIndex = 111
        Me.btnCloseItemPanel.Text = "Back"
        Me.btnCloseItemPanel.UseVisualStyleBackColor = False
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1025, 500)
        Me.Controls.Add(Me.btnCloseItemPanel)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPayment"
        Me.Text = "Payment"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnRegisterStaff As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProfileName As Label
    Friend WithEvents lblProfileID As Label
    Friend WithEvents lblLogOut As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lbxPrice As ListBox
    Friend WithEvents lbxQuantity As ListBox
    Friend WithEvents lbxFoodSelected As ListBox
    Friend WithEvents btnCloseItemPanel As Button
End Class
