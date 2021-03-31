<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.lblProfileID = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblFormTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnRegisterStaff = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnReceiptHistory = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.lblLogOut)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.LblFormTitle)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-5, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1298, 134)
        Me.Panel1.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(199, 134)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(873, 385)
        Me.Panel5.TabIndex = 28
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
        Me.Panel4.Location = New System.Drawing.Point(1109, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(154, 131)
        Me.Panel4.TabIndex = 9
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
        'LblFormTitle
        '
        Me.LblFormTitle.AutoSize = True
        Me.LblFormTitle.Font = New System.Drawing.Font("Bookman Old Style", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormTitle.Location = New System.Drawing.Point(536, 30)
        Me.LblFormTitle.Name = "LblFormTitle"
        Me.LblFormTitle.Size = New System.Drawing.Size(301, 54)
        Me.LblFormTitle.TabIndex = 4
        Me.LblFormTitle.Text = "MAIN MENU"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.btnReceiptHistory)
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Controls.Add(Me.btnOrder)
        Me.Panel3.Controls.Add(Me.btnRegisterStaff)
        Me.Panel3.Controls.Add(Me.btnRegister)
        Me.Panel3.Controls.Add(Me.btnReservation)
        Me.Panel3.Location = New System.Drawing.Point(1, 132)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 621)
        Me.Panel3.TabIndex = 3
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(0, 513)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(197, 73)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(-3, 102)
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
        Me.btnRegisterStaff.Location = New System.Drawing.Point(-3, 296)
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
        Me.btnRegister.Location = New System.Drawing.Point(-3, 199)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(197, 73)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "REGISTER CUSTOMER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnReservation
        '
        Me.btnReservation.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservation.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservation.Location = New System.Drawing.Point(-3, 5)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(197, 73)
        Me.btnReservation.TabIndex = 0
        Me.btnReservation.Text = "RESERVATIONS"
        Me.btnReservation.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(196, 132)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1097, 642)
        Me.Panel6.TabIndex = 5
        Me.Panel6.Visible = False
        '
        'btnReceiptHistory
        '
        Me.btnReceiptHistory.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReceiptHistory.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnReceiptHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReceiptHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceiptHistory.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiptHistory.Location = New System.Drawing.Point(0, 391)
        Me.btnReceiptHistory.Name = "btnReceiptHistory"
        Me.btnReceiptHistory.Size = New System.Drawing.Size(197, 73)
        Me.btnReceiptHistory.TabIndex = 5
        Me.btnReceiptHistory.Text = "RECEIPT HISTORY"
        Me.btnReceiptHistory.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.Profile
        Me.PictureBox2.Location = New System.Drawing.Point(35, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
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
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1285, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.Name = "FrmMainMenu"
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblFormTitle As Label
    Friend WithEvents lblProfileID As Label
    Friend WithEvents lblProfileName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblLogOut As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnRegisterStaff As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnReservation As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnReceiptHistory As Button
End Class
