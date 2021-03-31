<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReservation
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
        Me.txtReserveNumber = New System.Windows.Forms.NumericUpDown()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.txtReserveName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.MaskedTextBox()
        Me.cbxAmPm = New System.Windows.Forms.ComboBox()
        Me.txtReserveContact = New System.Windows.Forms.MaskedTextBox()
        Me.lsvReservation = New System.Windows.Forms.ListView()
        Me.ReservistName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumberOfPeople = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReservationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.txtReserveNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReserveNumber
        '
        Me.txtReserveNumber.Location = New System.Drawing.Point(852, 167)
        Me.txtReserveNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReserveNumber.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.txtReserveNumber.Name = "txtReserveNumber"
        Me.txtReserveNumber.ReadOnly = True
        Me.txtReserveNumber.Size = New System.Drawing.Size(40, 20)
        Me.txtReserveNumber.TabIndex = 40
        '
        'btnReserve
        '
        Me.btnReserve.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReserve.FlatAppearance.BorderSize = 0
        Me.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserve.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.Location = New System.Drawing.Point(910, 420)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(102, 42)
        Me.btnReserve.TabIndex = 34
        Me.btnReserve.Text = "Reserve"
        Me.btnReserve.UseVisualStyleBackColor = False
        '
        'txtReserveName
        '
        Me.txtReserveName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserveName.Location = New System.Drawing.Point(852, 67)
        Me.txtReserveName.MaxLength = 35
        Me.txtReserveName.Name = "txtReserveName"
        Me.txtReserveName.Size = New System.Drawing.Size(177, 23)
        Me.txtReserveName.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(708, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 36)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Number of people :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Max 25pax)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(704, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Reservist Contact :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(716, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Reservist Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Reservations"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(708, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Reservation Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(838, 222)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 20)
        Me.DateTimePicker1.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(716, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Reservation Time :"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(864, 305)
        Me.txtTime.Mask = "90:00"
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(40, 20)
        Me.txtTime.TabIndex = 44
        '
        'cbxAmPm
        '
        Me.cbxAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAmPm.FormattingEnabled = True
        Me.cbxAmPm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbxAmPm.Location = New System.Drawing.Point(910, 305)
        Me.cbxAmPm.Name = "cbxAmPm"
        Me.cbxAmPm.Size = New System.Drawing.Size(45, 21)
        Me.cbxAmPm.TabIndex = 45
        '
        'txtReserveContact
        '
        Me.txtReserveContact.Location = New System.Drawing.Point(852, 117)
        Me.txtReserveContact.Mask = "999-999 9999"
        Me.txtReserveContact.Name = "txtReserveContact"
        Me.txtReserveContact.Size = New System.Drawing.Size(80, 20)
        Me.txtReserveContact.TabIndex = 46
        '
        'lsvReservation
        '
        Me.lsvReservation.BackColor = System.Drawing.Color.LightBlue
        Me.lsvReservation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ReservistName, Me.Contact, Me.NumberOfPeople, Me.ReservationDate, Me.Time})
        Me.lsvReservation.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvReservation.FullRowSelect = True
        Me.lsvReservation.HideSelection = False
        Me.lsvReservation.LabelEdit = True
        Me.lsvReservation.Location = New System.Drawing.Point(11, 60)
        Me.lsvReservation.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvReservation.Name = "lsvReservation"
        Me.lsvReservation.Size = New System.Drawing.Size(689, 462)
        Me.lsvReservation.TabIndex = 47
        Me.lsvReservation.UseCompatibleStateImageBehavior = False
        Me.lsvReservation.View = System.Windows.Forms.View.Details
        '
        'ReservistName
        '
        Me.ReservistName.Text = "Reservist Name"
        Me.ReservistName.Width = 266
        '
        'Contact
        '
        Me.Contact.Text = "Contact"
        Me.Contact.Width = 112
        '
        'NumberOfPeople
        '
        Me.NumberOfPeople.Text = "Number of People"
        Me.NumberOfPeople.Width = 130
        '
        'ReservationDate
        '
        Me.ReservationDate.Text = "Date"
        Me.ReservationDate.Width = 97
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 71
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(748, 420)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 42)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'FrmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1053, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lsvReservation)
        Me.Controls.Add(Me.txtReserveContact)
        Me.Controls.Add(Me.cbxAmPm)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReserveNumber)
        Me.Controls.Add(Me.btnReserve)
        Me.Controls.Add(Me.txtReserveName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(197, 130)
        Me.Name = "FrmReservation"
        Me.Text = "Reservation"
        CType(Me.txtReserveNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReserveNumber As NumericUpDown
    Friend WithEvents btnReserve As Button
    Friend WithEvents txtReserveName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTime As MaskedTextBox
    Friend WithEvents cbxAmPm As ComboBox
    Friend WithEvents txtReserveContact As MaskedTextBox
    Friend WithEvents ReservistName As ColumnHeader
    Friend WithEvents Contact As ColumnHeader
    Friend WithEvents NumberOfPeople As ColumnHeader
    Friend WithEvents ReservationDate As ColumnHeader
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents btnDelete As Button
    Friend WithEvents lsvReservation As ListView
End Class
