<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegister
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustFirstName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.GrbxAddress = New System.Windows.Forms.GroupBox()
        Me.lblInvalidCountry = New System.Windows.Forms.Label()
        Me.lblInvalidState = New System.Windows.Forms.Label()
        Me.lblInvalidCity = New System.Windows.Forms.Label()
        Me.lblInvalidStreet = New System.Windows.Forms.Label()
        Me.cbxCustCountry = New System.Windows.Forms.ComboBox()
        Me.txtCustState = New System.Windows.Forms.TextBox()
        Me.txtCustCity = New System.Windows.Forms.TextBox()
        Me.txtCustStreet = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxCustGender = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustLastName = New System.Windows.Forms.TextBox()
        Me.lblInvalidFirstName = New System.Windows.Forms.Label()
        Me.lblInvalidLastName = New System.Windows.Forms.Label()
        Me.lblInvalidGender = New System.Windows.Forms.Label()
        Me.lblInvalidContact = New System.Windows.Forms.Label()
        Me.lblInvalidEmail = New System.Windows.Forms.Label()
        Me.lblInvalidDate = New System.Windows.Forms.Label()
        Me.txtCustContact = New System.Windows.Forms.MaskedTextBox()
        Me.custDOB = New System.Windows.Forms.MaskedTextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.pnlViewRecords = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblInavlidCustNo = New System.Windows.Forms.Label()
        Me.GrbxAddress.SuspendLayout()
        Me.pnlViewRecords.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "First Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Gender :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Street :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Contact Number :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(97, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Email :"
        '
        'txtCustFirstName
        '
        Me.txtCustFirstName.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustFirstName.Location = New System.Drawing.Point(167, 68)
        Me.txtCustFirstName.Name = "txtCustFirstName"
        Me.txtCustFirstName.Size = New System.Drawing.Size(226, 23)
        Me.txtCustFirstName.TabIndex = 33
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(167, 286)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(226, 23)
        Me.txtEmail.TabIndex = 36
        '
        'GrbxAddress
        '
        Me.GrbxAddress.BackColor = System.Drawing.Color.SkyBlue
        Me.GrbxAddress.Controls.Add(Me.lblInvalidCountry)
        Me.GrbxAddress.Controls.Add(Me.lblInvalidState)
        Me.GrbxAddress.Controls.Add(Me.lblInvalidCity)
        Me.GrbxAddress.Controls.Add(Me.lblInvalidStreet)
        Me.GrbxAddress.Controls.Add(Me.cbxCustCountry)
        Me.GrbxAddress.Controls.Add(Me.txtCustState)
        Me.GrbxAddress.Controls.Add(Me.txtCustCity)
        Me.GrbxAddress.Controls.Add(Me.txtCustStreet)
        Me.GrbxAddress.Controls.Add(Me.Label11)
        Me.GrbxAddress.Controls.Add(Me.Label10)
        Me.GrbxAddress.Controls.Add(Me.Label9)
        Me.GrbxAddress.Controls.Add(Me.Label6)
        Me.GrbxAddress.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbxAddress.Location = New System.Drawing.Point(473, 78)
        Me.GrbxAddress.Name = "GrbxAddress"
        Me.GrbxAddress.Size = New System.Drawing.Size(360, 252)
        Me.GrbxAddress.TabIndex = 39
        Me.GrbxAddress.TabStop = False
        Me.GrbxAddress.Text = "Address"
        '
        'lblInvalidCountry
        '
        Me.lblInvalidCountry.AutoSize = True
        Me.lblInvalidCountry.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidCountry.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidCountry.Location = New System.Drawing.Point(81, 216)
        Me.lblInvalidCountry.Name = "lblInvalidCountry"
        Me.lblInvalidCountry.Size = New System.Drawing.Size(142, 18)
        Me.lblInvalidCountry.TabIndex = 63
        Me.lblInvalidCountry.Text = "No Country Selected"
        Me.lblInvalidCountry.Visible = False
        '
        'lblInvalidState
        '
        Me.lblInvalidState.AutoSize = True
        Me.lblInvalidState.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidState.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidState.Location = New System.Drawing.Point(89, 161)
        Me.lblInvalidState.Name = "lblInvalidState"
        Me.lblInvalidState.Size = New System.Drawing.Size(92, 18)
        Me.lblInvalidState.TabIndex = 62
        Me.lblInvalidState.Text = "Invalid State"
        Me.lblInvalidState.Visible = False
        '
        'lblInvalidCity
        '
        Me.lblInvalidCity.AutoSize = True
        Me.lblInvalidCity.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidCity.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidCity.Location = New System.Drawing.Point(89, 103)
        Me.lblInvalidCity.Name = "lblInvalidCity"
        Me.lblInvalidCity.Size = New System.Drawing.Size(84, 18)
        Me.lblInvalidCity.TabIndex = 61
        Me.lblInvalidCity.Text = "Invalid City"
        Me.lblInvalidCity.Visible = False
        '
        'lblInvalidStreet
        '
        Me.lblInvalidStreet.AutoSize = True
        Me.lblInvalidStreet.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidStreet.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidStreet.Location = New System.Drawing.Point(89, 58)
        Me.lblInvalidStreet.Name = "lblInvalidStreet"
        Me.lblInvalidStreet.Size = New System.Drawing.Size(98, 18)
        Me.lblInvalidStreet.TabIndex = 56
        Me.lblInvalidStreet.Text = "Invalid Street"
        Me.lblInvalidStreet.Visible = False
        '
        'cbxCustCountry
        '
        Me.cbxCustCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCustCountry.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCustCountry.FormattingEnabled = True
        Me.cbxCustCountry.Items.AddRange(New Object() {"Malaysia", "Afghanistan  ", "Albania  ", "Algeria  ", "Andorra  ", "Angola  ", "Antarctica  ", "Antigua and Barbuda  ", "Argentina  ", "Armenia  ", "Aruba  ", "Australia  ", "Austria  ", "Azerbaijan  ", "Bahamas  ", "Bahrain  ", "Bangladesh  ", "Barbados  ", "Belarus  ", "Belgium  ", "Belize  ", "Benin  ", "Bhutan  ", "Bolivia  ", "Bosnia and Herzegovina  ", "Botswana  ", "Brazil  ", "Brunei  ", "Bulgaria  ", "Burkina Faso  ", "Burundi  ", "Cambodia  ", "Cameroon  ", "Canada  ", "Canary Islands  ", "Cape Verde Islands  ", "Cayman islands  ", "Central African Republic  ", "Chad  ", "Chile  ", "China  ", "Colombia  ", "Comoros  ", "Congo  ", "Cook Islands  ", "Costa Rica  ", "Croatia  ", "Cuba  ", "Cyprus  ", "Czech Republic  ", "Democratic Republic of the Congo (Zaire)  ", "Denmark  ", "Djibouti  ", "Dominica  ", "Dominican Republic  ", "East Timor  ", "Ecuador  ", "Egypt  ", "El Salvador  ", "Equatorial Guinea  ", "Eritrea  ", "Estonia  ", "Ethiopia  ", "Federated States of Micronesia  ", "Fiji  ", "Finland  ", "France  ", "French Guyana  ", "French Polynesia  ", "Gabon  ", "Gambia  ", "Georgia  ", "Germany  ", "Ghana  ", "Greece  ", "Greenland  ", "Grenada  ", "Guatemala  ", "Guinea  ", "Guinea Bissau  ", "Guyana  ", "Haiti  ", "Honduras  ", "Hong Kong  ", "Hungary  ", "Iceland  ", "India  ", "Indonesia  ", "Iran  ", "Iraq  ", "Israel  ", "Italy  ", "Ivory Coast/Côte d’Ivoire  ", "Jamaica  ", "Japan  ", "Jordan  ", "Kazakhstan  ", "Kenya  ", "Kiribati  ", "Kosovo  ", "Kuwait  ", "Kyrgyzstan  ", "Laos  ", "Latvia  ", "Lebanon  ", "Lesotho  ", "Liberia  ", "Libya  ", "Liechtenstein  ", "Lithuania  ", "Luxembourg  ", "Macedonia  ", "Madagascar  ", "Malawi  ", "Maldives  ", "Mali  ", "Malta  ", "Marshall Islands  ", "Martinique  ", "Mauritania  ", "Mauritius  ", "Mexico  ", "Moldova  ", "Monaco  ", "Mongolia  ", "Montenegro  ", "Morocco  ", "Mozambique  ", "Myanmar (Burma)  ", "Namibia  ", "Nauru  ", "Nepal  ", "New Caledonia  ", "New Zealand  ", "Nicaragua  ", "Niger  ", "Nigeria  ", "North Korea  ", "Norway  ", "Oman  ", "Pakistan  ", "Palau  ", "Palestine  ", "Panama  ", "Papua New Guinea  ", "Paraguay  ", "Peru  ", "Philippines  ", "Pitcairn Islands  ", "Poland  ", "Portugal  ", "Puerto Rico  ", "Qatar  ", "Republic of Ireland  ", "Republic of San Marino  ", "Romania  ", "Russia  ", "Rwanda  ", "Samoa  ", "Sao Tome  ", "Saudi Arabia  ", "Scotland  ", "Senegal  ", "Serbia  ", "Seychelles  ", "Sierra Leone  ", "Singapore  ", "Slovakia  ", "Slovenia  ", "Solomon Islands  ", "Somalia  ", "South Africa  ", "South Korea  ", "Spain  ", "Sri Lanka  ", "St. Kitts and Nevis  ", "St. Lucia  ", "St. Vincent and The Grenadines  ", "Sudan  ", "Suriname  ", "Swaziland  ", "Sweden  ", "Switzerland  ", "Syria  ", "Taiwan  ", "Tajikistan  ", "Tanzania  ", "Thailand  ", "The Netherlands  ", "The Vatican  ", "Togo  ", "Tonga  ", "Trinidad and Tobago  ", "Tunisia  ", "Turkey  ", "Turkmenistan  ", "Tuvalu  ", "Uganda  ", "Ukraine  ", "United Arab Emirates  ", "United Kingdom  ", "United States  ", "Uruguay  ", "Uzbekistan  ", "Vanuatu  ", "Venezuela  ", "Vietnam  ", "Wales  ", "West Bank and Gaza  ", "Western Sahara  ", "Yemen  ", "Zambia  ", "Zimbabwe  "})
        Me.cbxCustCountry.Location = New System.Drawing.Point(84, 187)
        Me.cbxCustCountry.Name = "cbxCustCountry"
        Me.cbxCustCountry.Size = New System.Drawing.Size(177, 26)
        Me.cbxCustCountry.TabIndex = 60
        '
        'txtCustState
        '
        Me.txtCustState.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustState.Location = New System.Drawing.Point(84, 135)
        Me.txtCustState.Name = "txtCustState"
        Me.txtCustState.Size = New System.Drawing.Size(177, 23)
        Me.txtCustState.TabIndex = 42
        '
        'txtCustCity
        '
        Me.txtCustCity.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustCity.Location = New System.Drawing.Point(84, 77)
        Me.txtCustCity.Name = "txtCustCity"
        Me.txtCustCity.Size = New System.Drawing.Size(177, 23)
        Me.txtCustCity.TabIndex = 41
        '
        'txtCustStreet
        '
        Me.txtCustStreet.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustStreet.Location = New System.Drawing.Point(84, 35)
        Me.txtCustStreet.Name = "txtCustStreet"
        Me.txtCustStreet.Size = New System.Drawing.Size(177, 23)
        Me.txtCustStreet.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Country :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 18)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "State :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "City :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(51, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 18)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Date of Birth :"
        '
        'cbxCustGender
        '
        Me.cbxCustGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCustGender.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCustGender.FormattingEnabled = True
        Me.cbxCustGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbxCustGender.Location = New System.Drawing.Point(167, 157)
        Me.cbxCustGender.Name = "cbxCustGender"
        Me.cbxCustGender.Size = New System.Drawing.Size(121, 26)
        Me.cbxCustGender.TabIndex = 41
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(643, 530)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 58)
        Me.btnSubmit.TabIndex = 43
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(49, 440)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(141, 58)
        Me.btnReset.TabIndex = 44
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnViewDetails.FlatAppearance.BorderSize = 0
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.Location = New System.Drawing.Point(841, 440)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(141, 58)
        Me.btnViewDetails.TabIndex = 45
        Me.btnViewDetails.Text = "View Records"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(227, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Customer No. :"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(359, 20)
        Me.txtCustomerID.MaxLength = 6
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(71, 23)
        Me.txtCustomerID.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Last Name :"
        '
        'txtCustLastName
        '
        Me.txtCustLastName.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLastName.Location = New System.Drawing.Point(167, 113)
        Me.txtCustLastName.Name = "txtCustLastName"
        Me.txtCustLastName.Size = New System.Drawing.Size(226, 23)
        Me.txtCustLastName.TabIndex = 49
        '
        'lblInvalidFirstName
        '
        Me.lblInvalidFirstName.AutoSize = True
        Me.lblInvalidFirstName.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidFirstName.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidFirstName.Location = New System.Drawing.Point(171, 91)
        Me.lblInvalidFirstName.Name = "lblInvalidFirstName"
        Me.lblInvalidFirstName.Size = New System.Drawing.Size(135, 18)
        Me.lblInvalidFirstName.TabIndex = 50
        Me.lblInvalidFirstName.Text = "Invalid First Name "
        Me.lblInvalidFirstName.Visible = False
        '
        'lblInvalidLastName
        '
        Me.lblInvalidLastName.AutoSize = True
        Me.lblInvalidLastName.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidLastName.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidLastName.Location = New System.Drawing.Point(171, 136)
        Me.lblInvalidLastName.Name = "lblInvalidLastName"
        Me.lblInvalidLastName.Size = New System.Drawing.Size(132, 18)
        Me.lblInvalidLastName.TabIndex = 51
        Me.lblInvalidLastName.Text = "Invalid Last Name "
        Me.lblInvalidLastName.Visible = False
        '
        'lblInvalidGender
        '
        Me.lblInvalidGender.AutoSize = True
        Me.lblInvalidGender.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidGender.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidGender.Location = New System.Drawing.Point(168, 179)
        Me.lblInvalidGender.Name = "lblInvalidGender"
        Me.lblInvalidGender.Size = New System.Drawing.Size(137, 18)
        Me.lblInvalidGender.TabIndex = 52
        Me.lblInvalidGender.Text = "No Gender Selected"
        Me.lblInvalidGender.Visible = False
        '
        'lblInvalidContact
        '
        Me.lblInvalidContact.AutoSize = True
        Me.lblInvalidContact.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidContact.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidContact.Location = New System.Drawing.Point(168, 265)
        Me.lblInvalidContact.Name = "lblInvalidContact"
        Me.lblInvalidContact.Size = New System.Drawing.Size(165, 18)
        Me.lblInvalidContact.TabIndex = 53
        Me.lblInvalidContact.Text = "Invalid Contact Number"
        Me.lblInvalidContact.Visible = False
        '
        'lblInvalidEmail
        '
        Me.lblInvalidEmail.AutoSize = True
        Me.lblInvalidEmail.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblInvalidEmail.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidEmail.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidEmail.Location = New System.Drawing.Point(164, 312)
        Me.lblInvalidEmail.Name = "lblInvalidEmail"
        Me.lblInvalidEmail.Size = New System.Drawing.Size(99, 18)
        Me.lblInvalidEmail.TabIndex = 54
        Me.lblInvalidEmail.Text = "Invalid Email "
        Me.lblInvalidEmail.Visible = False
        '
        'lblInvalidDate
        '
        Me.lblInvalidDate.AutoSize = True
        Me.lblInvalidDate.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidDate.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidDate.Location = New System.Drawing.Point(171, 221)
        Me.lblInvalidDate.Name = "lblInvalidDate"
        Me.lblInvalidDate.Size = New System.Drawing.Size(120, 18)
        Me.lblInvalidDate.TabIndex = 64
        Me.lblInvalidDate.Text = "No Date Selected"
        Me.lblInvalidDate.Visible = False
        '
        'txtCustContact
        '
        Me.txtCustContact.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustContact.Location = New System.Drawing.Point(167, 243)
        Me.txtCustContact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustContact.Mask = "999-999 9999"
        Me.txtCustContact.Name = "txtCustContact"
        Me.txtCustContact.Size = New System.Drawing.Size(108, 23)
        Me.txtCustContact.TabIndex = 65
        '
        'custDOB
        '
        Me.custDOB.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custDOB.Location = New System.Drawing.Point(167, 198)
        Me.custDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.custDOB.Mask = "00/00/0000"
        Me.custDOB.Name = "custDOB"
        Me.custDOB.Size = New System.Drawing.Size(108, 23)
        Me.custDOB.TabIndex = 66
        Me.custDOB.ValidatingType = GetType(Date)
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAddNew.FlatAppearance.BorderSize = 0
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.Location = New System.Drawing.Point(643, 440)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(141, 58)
        Me.btnAddNew.TabIndex = 67
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(445, 440)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 58)
        Me.btnDelete.TabIndex = 68
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(247, 440)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 58)
        Me.btnUpdate.TabIndex = 69
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLastRecord.FlatAppearance.BorderSize = 0
        Me.btnLastRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLastRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLastRecord.Location = New System.Drawing.Point(615, 363)
        Me.btnLastRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(112, 35)
        Me.btnLastRecord.TabIndex = 73
        Me.btnLastRecord.Text = ">>"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNext.Location = New System.Drawing.Point(473, 363)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 35)
        Me.btnNext.TabIndex = 72
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrevious.Location = New System.Drawing.Point(327, 363)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(112, 35)
        Me.btnPrevious.TabIndex = 71
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnFirstRecord.FlatAppearance.BorderSize = 0
        Me.btnFirstRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFirstRecord.Location = New System.Drawing.Point(193, 363)
        Me.btnFirstRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(112, 35)
        Me.btnFirstRecord.TabIndex = 70
        Me.btnFirstRecord.Text = "<<"
        Me.btnFirstRecord.UseVisualStyleBackColor = False
        '
        'pnlViewRecords
        '
        Me.pnlViewRecords.Controls.Add(Me.btnBack)
        Me.pnlViewRecords.Controls.Add(Me.DataGridView1)
        Me.pnlViewRecords.Location = New System.Drawing.Point(30, 3)
        Me.pnlViewRecords.Name = "pnlViewRecords"
        Me.pnlViewRecords.Size = New System.Drawing.Size(952, 585)
        Me.pnlViewRecords.TabIndex = 74
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
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(447, 20)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(205, 18)
        Me.lblPrompt.TabIndex = 75
        Me.lblPrompt.Text = "Please Use No. above CT0005 "
        Me.lblPrompt.Visible = False
        '
        'lblInavlidCustNo
        '
        Me.lblInavlidCustNo.AutoSize = True
        Me.lblInavlidCustNo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInavlidCustNo.ForeColor = System.Drawing.Color.Red
        Me.lblInavlidCustNo.Location = New System.Drawing.Point(324, 46)
        Me.lblInavlidCustNo.Name = "lblInavlidCustNo"
        Me.lblInavlidCustNo.Size = New System.Drawing.Size(179, 18)
        Me.lblInavlidCustNo.TabIndex = 76
        Me.lblInavlidCustNo.Text = "Invalid Customer Number"
        Me.lblInavlidCustNo.Visible = False
        '
        'FrmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1053, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInavlidCustNo)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.pnlViewRecords)
        Me.Controls.Add(Me.btnLastRecord)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirstRecord)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.custDOB)
        Me.Controls.Add(Me.txtCustContact)
        Me.Controls.Add(Me.lblInvalidDate)
        Me.Controls.Add(Me.lblInvalidEmail)
        Me.Controls.Add(Me.lblInvalidContact)
        Me.Controls.Add(Me.lblInvalidGender)
        Me.Controls.Add(Me.lblInvalidLastName)
        Me.Controls.Add(Me.lblInvalidFirstName)
        Me.Controls.Add(Me.txtCustLastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cbxCustGender)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GrbxAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCustFirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.GrbxAddress.ResumeLayout(False)
        Me.GrbxAddress.PerformLayout()
        Me.pnlViewRecords.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustFirstName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents GrbxAddress As GroupBox
    Friend WithEvents txtCustState As TextBox
    Friend WithEvents txtCustCity As TextBox
    Friend WithEvents txtCustStreet As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxCustGender As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents cbxCustCountry As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustLastName As TextBox
    Friend WithEvents lblInvalidCountry As Label
    Friend WithEvents lblInvalidState As Label
    Friend WithEvents lblInvalidCity As Label
    Friend WithEvents lblInvalidStreet As Label
    Friend WithEvents lblInvalidFirstName As Label
    Friend WithEvents lblInvalidLastName As Label
    Friend WithEvents lblInvalidGender As Label
    Friend WithEvents lblInvalidContact As Label
    Friend WithEvents lblInvalidEmail As Label
    Friend WithEvents lblInvalidDate As Label
    Friend WithEvents txtCustContact As MaskedTextBox
    Friend WithEvents custDOB As MaskedTextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents pnlViewRecords As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblInavlidCustNo As Label
End Class
