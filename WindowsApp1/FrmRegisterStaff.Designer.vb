<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegisterStaff
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxStaffGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStaffFirstName = New System.Windows.Forms.TextBox()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.txtStaffPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStaffStreet = New System.Windows.Forms.TextBox()
        Me.txtStaffCity = New System.Windows.Forms.TextBox()
        Me.txtStaffState = New System.Windows.Forms.TextBox()
        Me.cbxStaffCountry = New System.Windows.Forms.ComboBox()
        Me.GrbxAddress = New System.Windows.Forms.GroupBox()
        Me.lblInvalidCountry = New System.Windows.Forms.Label()
        Me.lblInvalidState = New System.Windows.Forms.Label()
        Me.lblInvalidCity = New System.Windows.Forms.Label()
        Me.lblInvalidStreet = New System.Windows.Forms.Label()
        Me.lblInvalidFirstName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInvalidLastName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStaffLastName = New System.Windows.Forms.TextBox()
        Me.lblInvalidPassword = New System.Windows.Forms.Label()
        Me.lblInvalidGender = New System.Windows.Forms.Label()
        Me.StaffDOB = New System.Windows.Forms.MaskedTextBox()
        Me.lblInvalidStaffDOB = New System.Windows.Forms.Label()
        Me.lblInvalidContact = New System.Windows.Forms.Label()
        Me.txtStaffContact = New System.Windows.Forms.MaskedTextBox()
        Me.lblInvalidEmail = New System.Windows.Forms.Label()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.pnlViewRecords = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblInvalidStaffID = New System.Windows.Forms.Label()
        Me.GrbxAddress.SuspendLayout()
        Me.pnlViewRecords.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(337, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 18)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Staff ID :"
        '
        'txtStaffID
        '
        Me.txtStaffID.Enabled = False
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(432, 18)
        Me.txtStaffID.MaxLength = 5
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.Size = New System.Drawing.Size(71, 23)
        Me.txtStaffID.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Gender :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Password :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(97, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Email :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 218)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 18)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Date of Birth :"
        '
        'cbxStaffGender
        '
        Me.cbxStaffGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStaffGender.FormattingEnabled = True
        Me.cbxStaffGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbxStaffGender.Location = New System.Drawing.Point(176, 172)
        Me.cbxStaffGender.Name = "cbxStaffGender"
        Me.cbxStaffGender.Size = New System.Drawing.Size(121, 21)
        Me.cbxStaffGender.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 18)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Contact Number :"
        '
        'txtStaffFirstName
        '
        Me.txtStaffFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffFirstName.Location = New System.Drawing.Point(176, 43)
        Me.txtStaffFirstName.Name = "txtStaffFirstName"
        Me.txtStaffFirstName.Size = New System.Drawing.Size(226, 23)
        Me.txtStaffFirstName.TabIndex = 53
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffEmail.Location = New System.Drawing.Point(176, 325)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(226, 23)
        Me.txtStaffEmail.TabIndex = 55
        '
        'txtStaffPassword
        '
        Me.txtStaffPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffPassword.Location = New System.Drawing.Point(176, 131)
        Me.txtStaffPassword.Name = "txtStaffPassword"
        Me.txtStaffPassword.Size = New System.Drawing.Size(226, 23)
        Me.txtStaffPassword.TabIndex = 56
        Me.txtStaffPassword.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Street :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "City :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 18)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "State :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Country :"
        '
        'txtStaffStreet
        '
        Me.txtStaffStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffStreet.Location = New System.Drawing.Point(91, 29)
        Me.txtStaffStreet.Name = "txtStaffStreet"
        Me.txtStaffStreet.Size = New System.Drawing.Size(177, 23)
        Me.txtStaffStreet.TabIndex = 40
        '
        'txtStaffCity
        '
        Me.txtStaffCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffCity.Location = New System.Drawing.Point(90, 77)
        Me.txtStaffCity.Name = "txtStaffCity"
        Me.txtStaffCity.Size = New System.Drawing.Size(177, 23)
        Me.txtStaffCity.TabIndex = 41
        '
        'txtStaffState
        '
        Me.txtStaffState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffState.Location = New System.Drawing.Point(91, 124)
        Me.txtStaffState.Name = "txtStaffState"
        Me.txtStaffState.Size = New System.Drawing.Size(177, 23)
        Me.txtStaffState.TabIndex = 42
        '
        'cbxStaffCountry
        '
        Me.cbxStaffCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStaffCountry.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxStaffCountry.FormattingEnabled = True
        Me.cbxStaffCountry.Items.AddRange(New Object() {"Malaysia", "Afghanistan  ", "Albania  ", "Algeria  ", "Andorra  ", "Angola  ", "Antarctica  ", "Antigua and Barbuda  ", "Argentina  ", "Armenia  ", "Aruba  ", "Australia  ", "Austria  ", "Azerbaijan  ", "Bahamas  ", "Bahrain  ", "Bangladesh  ", "Barbados  ", "Belarus  ", "Belgium  ", "Belize  ", "Benin  ", "Bhutan  ", "Bolivia  ", "Bosnia and Herzegovina  ", "Botswana  ", "Brazil  ", "Brunei  ", "Bulgaria  ", "Burkina Faso  ", "Burundi  ", "Cambodia  ", "Cameroon  ", "Canada  ", "Canary Islands  ", "Cape Verde Islands  ", "Cayman islands  ", "Central African Republic  ", "Chad  ", "Chile  ", "China  ", "Colombia  ", "Comoros  ", "Congo  ", "Cook Islands  ", "Costa Rica  ", "Croatia  ", "Cuba  ", "Cyprus  ", "Czech Republic  ", "Democratic Republic of the Congo (Zaire)  ", "Denmark  ", "Djibouti  ", "Dominica  ", "Dominican Republic  ", "East Timor  ", "Ecuador  ", "Egypt  ", "El Salvador  ", "Equatorial Guinea  ", "Eritrea  ", "Estonia  ", "Ethiopia  ", "Federated States of Micronesia  ", "Fiji  ", "Finland  ", "France  ", "French Guyana  ", "French Polynesia  ", "Gabon  ", "Gambia  ", "Georgia  ", "Germany  ", "Ghana  ", "Greece  ", "Greenland  ", "Grenada  ", "Guatemala  ", "Guinea  ", "Guinea Bissau  ", "Guyana  ", "Haiti  ", "Honduras  ", "Hong Kong  ", "Hungary  ", "Iceland  ", "India  ", "Indonesia  ", "Iran  ", "Iraq  ", "Israel  ", "Italy  ", "Ivory Coast/Côte d’Ivoire  ", "Jamaica  ", "Japan  ", "Jordan  ", "Kazakhstan  ", "Kenya  ", "Kiribati  ", "Kosovo  ", "Kuwait  ", "Kyrgyzstan  ", "Laos  ", "Latvia  ", "Lebanon  ", "Lesotho  ", "Liberia  ", "Libya  ", "Liechtenstein  ", "Lithuania  ", "Luxembourg  ", "Macedonia  ", "Madagascar  ", "Malawi  ", "Maldives  ", "Mali  ", "Malta  ", "Marshall Islands  ", "Martinique  ", "Mauritania  ", "Mauritius  ", "Mexico  ", "Moldova  ", "Monaco  ", "Mongolia  ", "Montenegro  ", "Morocco  ", "Mozambique  ", "Myanmar (Burma)  ", "Namibia  ", "Nauru  ", "Nepal  ", "New Caledonia  ", "New Zealand  ", "Nicaragua  ", "Niger  ", "Nigeria  ", "North Korea  ", "Norway  ", "Oman  ", "Pakistan  ", "Palau  ", "Palestine  ", "Panama  ", "Papua New Guinea  ", "Paraguay  ", "Peru  ", "Philippines  ", "Pitcairn Islands  ", "Poland  ", "Portugal  ", "Puerto Rico  ", "Qatar  ", "Republic of Ireland  ", "Republic of San Marino  ", "Romania  ", "Russia  ", "Rwanda  ", "Samoa  ", "Sao Tome  ", "Saudi Arabia  ", "Scotland  ", "Senegal  ", "Serbia  ", "Seychelles  ", "Sierra Leone  ", "Singapore  ", "Slovakia  ", "Slovenia  ", "Solomon Islands  ", "Somalia  ", "South Africa  ", "South Korea  ", "Spain  ", "Sri Lanka  ", "St. Kitts and Nevis  ", "St. Lucia  ", "St. Vincent and The Grenadines  ", "Sudan  ", "Suriname  ", "Swaziland  ", "Sweden  ", "Switzerland  ", "Syria  ", "Taiwan  ", "Tajikistan  ", "Tanzania  ", "Thailand  ", "The Netherlands  ", "The Vatican  ", "Togo  ", "Tonga  ", "Trinidad and Tobago  ", "Tunisia  ", "Turkey  ", "Turkmenistan  ", "Tuvalu  ", "Uganda  ", "Ukraine  ", "United Arab Emirates  ", "United Kingdom  ", "United States  ", "Uruguay  ", "Uzbekistan  ", "Vanuatu  ", "Venezuela  ", "Vietnam  ", "Wales  ", "West Bank and Gaza  ", "Western Sahara  ", "Yemen  ", "Zambia  ", "Zimbabwe  "})
        Me.cbxStaffCountry.Location = New System.Drawing.Point(91, 172)
        Me.cbxStaffCountry.Name = "cbxStaffCountry"
        Me.cbxStaffCountry.Size = New System.Drawing.Size(121, 26)
        Me.cbxStaffCountry.TabIndex = 65
        '
        'GrbxAddress
        '
        Me.GrbxAddress.BackColor = System.Drawing.Color.SkyBlue
        Me.GrbxAddress.Controls.Add(Me.lblInvalidCountry)
        Me.GrbxAddress.Controls.Add(Me.lblInvalidState)
        Me.GrbxAddress.Controls.Add(Me.lblInvalidCity)
        Me.GrbxAddress.Controls.Add(Me.lblInvalidStreet)
        Me.GrbxAddress.Controls.Add(Me.cbxStaffCountry)
        Me.GrbxAddress.Controls.Add(Me.txtStaffState)
        Me.GrbxAddress.Controls.Add(Me.txtStaffCity)
        Me.GrbxAddress.Controls.Add(Me.txtStaffStreet)
        Me.GrbxAddress.Controls.Add(Me.Label11)
        Me.GrbxAddress.Controls.Add(Me.Label10)
        Me.GrbxAddress.Controls.Add(Me.Label9)
        Me.GrbxAddress.Controls.Add(Me.Label6)
        Me.GrbxAddress.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbxAddress.Location = New System.Drawing.Point(587, 46)
        Me.GrbxAddress.Name = "GrbxAddress"
        Me.GrbxAddress.Size = New System.Drawing.Size(341, 249)
        Me.GrbxAddress.TabIndex = 57
        Me.GrbxAddress.TabStop = False
        Me.GrbxAddress.Text = "Address"
        '
        'lblInvalidCountry
        '
        Me.lblInvalidCountry.AutoSize = True
        Me.lblInvalidCountry.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidCountry.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidCountry.Location = New System.Drawing.Point(88, 201)
        Me.lblInvalidCountry.Name = "lblInvalidCountry"
        Me.lblInvalidCountry.Size = New System.Drawing.Size(110, 18)
        Me.lblInvalidCountry.TabIndex = 83
        Me.lblInvalidCountry.Text = "Invalid Country"
        Me.lblInvalidCountry.Visible = False
        '
        'lblInvalidState
        '
        Me.lblInvalidState.AutoSize = True
        Me.lblInvalidState.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidState.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidState.Location = New System.Drawing.Point(88, 147)
        Me.lblInvalidState.Name = "lblInvalidState"
        Me.lblInvalidState.Size = New System.Drawing.Size(92, 18)
        Me.lblInvalidState.TabIndex = 82
        Me.lblInvalidState.Text = "Invalid State"
        Me.lblInvalidState.Visible = False
        '
        'lblInvalidCity
        '
        Me.lblInvalidCity.AutoSize = True
        Me.lblInvalidCity.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidCity.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidCity.Location = New System.Drawing.Point(88, 103)
        Me.lblInvalidCity.Name = "lblInvalidCity"
        Me.lblInvalidCity.Size = New System.Drawing.Size(84, 18)
        Me.lblInvalidCity.TabIndex = 81
        Me.lblInvalidCity.Text = "Invalid City"
        Me.lblInvalidCity.Visible = False
        '
        'lblInvalidStreet
        '
        Me.lblInvalidStreet.AutoSize = True
        Me.lblInvalidStreet.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidStreet.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidStreet.Location = New System.Drawing.Point(88, 56)
        Me.lblInvalidStreet.Name = "lblInvalidStreet"
        Me.lblInvalidStreet.Size = New System.Drawing.Size(98, 18)
        Me.lblInvalidStreet.TabIndex = 80
        Me.lblInvalidStreet.Text = "Invalid Street"
        Me.lblInvalidStreet.Visible = False
        '
        'lblInvalidFirstName
        '
        Me.lblInvalidFirstName.AutoSize = True
        Me.lblInvalidFirstName.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidFirstName.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidFirstName.Location = New System.Drawing.Point(174, 66)
        Me.lblInvalidFirstName.Name = "lblInvalidFirstName"
        Me.lblInvalidFirstName.Size = New System.Drawing.Size(135, 18)
        Me.lblInvalidFirstName.TabIndex = 68
        Me.lblInvalidFirstName.Text = "Invalid First Name "
        Me.lblInvalidFirstName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "First Name :"
        '
        'lblInvalidLastName
        '
        Me.lblInvalidLastName.AutoSize = True
        Me.lblInvalidLastName.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidLastName.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidLastName.Location = New System.Drawing.Point(174, 107)
        Me.lblInvalidLastName.Name = "lblInvalidLastName"
        Me.lblInvalidLastName.Size = New System.Drawing.Size(132, 18)
        Me.lblInvalidLastName.TabIndex = 70
        Me.lblInvalidLastName.Text = "Invalid Last Name "
        Me.lblInvalidLastName.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Last Name :"
        '
        'txtStaffLastName
        '
        Me.txtStaffLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffLastName.Location = New System.Drawing.Point(176, 84)
        Me.txtStaffLastName.Name = "txtStaffLastName"
        Me.txtStaffLastName.Size = New System.Drawing.Size(226, 23)
        Me.txtStaffLastName.TabIndex = 71
        '
        'lblInvalidPassword
        '
        Me.lblInvalidPassword.AutoSize = True
        Me.lblInvalidPassword.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidPassword.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidPassword.Location = New System.Drawing.Point(174, 154)
        Me.lblInvalidPassword.Name = "lblInvalidPassword"
        Me.lblInvalidPassword.Size = New System.Drawing.Size(121, 18)
        Me.lblInvalidPassword.TabIndex = 72
        Me.lblInvalidPassword.Text = "Invalid Password "
        Me.lblInvalidPassword.Visible = False
        '
        'lblInvalidGender
        '
        Me.lblInvalidGender.AutoSize = True
        Me.lblInvalidGender.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidGender.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidGender.Location = New System.Drawing.Point(174, 194)
        Me.lblInvalidGender.Name = "lblInvalidGender"
        Me.lblInvalidGender.Size = New System.Drawing.Size(109, 18)
        Me.lblInvalidGender.TabIndex = 73
        Me.lblInvalidGender.Text = "Invalid Gender "
        Me.lblInvalidGender.Visible = False
        '
        'StaffDOB
        '
        Me.StaffDOB.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffDOB.Location = New System.Drawing.Point(176, 218)
        Me.StaffDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffDOB.Mask = "00/00/0000"
        Me.StaffDOB.Name = "StaffDOB"
        Me.StaffDOB.Size = New System.Drawing.Size(108, 23)
        Me.StaffDOB.TabIndex = 75
        Me.StaffDOB.ValidatingType = GetType(Date)
        '
        'lblInvalidStaffDOB
        '
        Me.lblInvalidStaffDOB.AutoSize = True
        Me.lblInvalidStaffDOB.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidStaffDOB.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidStaffDOB.Location = New System.Drawing.Point(173, 243)
        Me.lblInvalidStaffDOB.Name = "lblInvalidStaffDOB"
        Me.lblInvalidStaffDOB.Size = New System.Drawing.Size(145, 18)
        Me.lblInvalidStaffDOB.TabIndex = 76
        Me.lblInvalidStaffDOB.Text = "Invalid Date of Birth "
        Me.lblInvalidStaffDOB.Visible = False
        '
        'lblInvalidContact
        '
        Me.lblInvalidContact.AutoSize = True
        Me.lblInvalidContact.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidContact.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidContact.Location = New System.Drawing.Point(174, 297)
        Me.lblInvalidContact.Name = "lblInvalidContact"
        Me.lblInvalidContact.Size = New System.Drawing.Size(165, 18)
        Me.lblInvalidContact.TabIndex = 77
        Me.lblInvalidContact.Text = "Invalid Contact Number"
        Me.lblInvalidContact.Visible = False
        '
        'txtStaffContact
        '
        Me.txtStaffContact.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffContact.Location = New System.Drawing.Point(176, 272)
        Me.txtStaffContact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStaffContact.Mask = "999-999 9999"
        Me.txtStaffContact.Name = "txtStaffContact"
        Me.txtStaffContact.Size = New System.Drawing.Size(108, 23)
        Me.txtStaffContact.TabIndex = 78
        '
        'lblInvalidEmail
        '
        Me.lblInvalidEmail.AutoSize = True
        Me.lblInvalidEmail.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidEmail.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidEmail.Location = New System.Drawing.Point(173, 351)
        Me.lblInvalidEmail.Name = "lblInvalidEmail"
        Me.lblInvalidEmail.Size = New System.Drawing.Size(99, 18)
        Me.lblInvalidEmail.TabIndex = 79
        Me.lblInvalidEmail.Text = "Invalid Email "
        Me.lblInvalidEmail.Visible = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLastRecord.FlatAppearance.BorderSize = 0
        Me.btnLastRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLastRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLastRecord.Location = New System.Drawing.Point(615, 385)
        Me.btnLastRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(112, 35)
        Me.btnLastRecord.TabIndex = 89
        Me.btnLastRecord.Text = ">>"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNext.Location = New System.Drawing.Point(473, 385)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 35)
        Me.btnNext.TabIndex = 88
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrevious.Location = New System.Drawing.Point(327, 385)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(112, 35)
        Me.btnPrevious.TabIndex = 87
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnFirstRecord.FlatAppearance.BorderSize = 0
        Me.btnFirstRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFirstRecord.Location = New System.Drawing.Point(193, 385)
        Me.btnFirstRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(112, 35)
        Me.btnFirstRecord.TabIndex = 86
        Me.btnFirstRecord.Text = "<<"
        Me.btnFirstRecord.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(246, 445)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 58)
        Me.btnUpdate.TabIndex = 85
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(444, 445)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 58)
        Me.btnDelete.TabIndex = 84
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(642, 445)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(141, 58)
        Me.btnAddNew.TabIndex = 83
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnViewDetails.FlatAppearance.BorderSize = 0
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.Location = New System.Drawing.Point(840, 445)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(141, 58)
        Me.btnViewDetails.TabIndex = 82
        Me.btnViewDetails.Text = "View Records"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(48, 445)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(141, 58)
        Me.btnReset.TabIndex = 81
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(642, 535)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 58)
        Me.btnSubmit.TabIndex = 80
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(509, 18)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(205, 18)
        Me.lblPrompt.TabIndex = 90
        Me.lblPrompt.Text = "Please Use No. above CT0005 "
        Me.lblPrompt.Visible = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(409, 136)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword.TabIndex = 91
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'pnlViewRecords
        '
        Me.pnlViewRecords.Controls.Add(Me.btnBack)
        Me.pnlViewRecords.Controls.Add(Me.DataGridView1)
        Me.pnlViewRecords.Location = New System.Drawing.Point(29, 12)
        Me.pnlViewRecords.Name = "pnlViewRecords"
        Me.pnlViewRecords.Size = New System.Drawing.Size(961, 605)
        Me.pnlViewRecords.TabIndex = 92
        Me.pnlViewRecords.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(403, 508)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(141, 58)
        Me.btnBack.TabIndex = 75
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(897, 465)
        Me.DataGridView1.TabIndex = 0
        '
        'lblInvalidStaffID
        '
        Me.lblInvalidStaffID.AutoSize = True
        Me.lblInvalidStaffID.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidStaffID.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidStaffID.Location = New System.Drawing.Point(429, 46)
        Me.lblInvalidStaffID.Name = "lblInvalidStaffID"
        Me.lblInvalidStaffID.Size = New System.Drawing.Size(106, 18)
        Me.lblInvalidStaffID.TabIndex = 93
        Me.lblInvalidStaffID.Text = "Invalid Staff ID"
        Me.lblInvalidStaffID.Visible = False
        '
        'FrmRegisterStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1053, 642)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInvalidStaffID)
        Me.Controls.Add(Me.pnlViewRecords)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnLastRecord)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirstRecord)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblInvalidEmail)
        Me.Controls.Add(Me.txtStaffContact)
        Me.Controls.Add(Me.lblInvalidContact)
        Me.Controls.Add(Me.lblInvalidStaffDOB)
        Me.Controls.Add(Me.StaffDOB)
        Me.Controls.Add(Me.lblInvalidGender)
        Me.Controls.Add(Me.lblInvalidPassword)
        Me.Controls.Add(Me.txtStaffLastName)
        Me.Controls.Add(Me.lblInvalidLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblInvalidFirstName)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrbxAddress)
        Me.Controls.Add(Me.txtStaffPassword)
        Me.Controls.Add(Me.txtStaffEmail)
        Me.Controls.Add(Me.txtStaffFirstName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxStaffGender)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegisterStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterStaff"
        Me.GrbxAddress.ResumeLayout(False)
        Me.GrbxAddress.PerformLayout()
        Me.pnlViewRecords.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label13 As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxStaffGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStaffFirstName As TextBox
    Friend WithEvents txtStaffEmail As TextBox
    Friend WithEvents txtStaffPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStaffStreet As TextBox
    Friend WithEvents txtStaffCity As TextBox
    Friend WithEvents txtStaffState As TextBox
    Friend WithEvents cbxStaffCountry As ComboBox
    Friend WithEvents GrbxAddress As GroupBox
    Friend WithEvents lblInvalidFirstName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblInvalidLastName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStaffLastName As TextBox
    Friend WithEvents lblInvalidPassword As Label
    Friend WithEvents lblInvalidGender As Label
    Friend WithEvents StaffDOB As MaskedTextBox
    Friend WithEvents lblInvalidStaffDOB As Label
    Friend WithEvents lblInvalidContact As Label
    Friend WithEvents lblInvalidCountry As Label
    Friend WithEvents lblInvalidState As Label
    Friend WithEvents lblInvalidCity As Label
    Friend WithEvents lblInvalidStreet As Label
    Friend WithEvents txtStaffContact As MaskedTextBox
    Friend WithEvents lblInvalidEmail As Label
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents pnlViewRecords As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblInvalidStaffID As Label
End Class
