
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Security.Authentication.ExtendedProtection
Public Class FrmRegisterStaff


    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim staffomerNumber As String
    Dim Index As Integer
    Dim totalRecords As Integer

    Dim Counter As String


    Private Sub FrmRegisterStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()
        'MessageBox.Show("Connection opened.")

        sql = "Select * From STAFF_T"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "staffList")

        con.Close()
        'MessageBox.Show("Connection closed.")


        Index = 0
        totalRecords = ds.Tables("staffList").Rows.Count
        NavigateRecord() 'Call Statement

        Counter = ds.Tables("staffList").Rows((ds.Tables("staffList").Rows.Count - 1)).Item(0)
        lblPrompt.Text = "Please Use No. above " & Counter

        Me.Size = New Point(1053, 600)
    End Sub

    Private Sub TextBox1KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaffCity.KeyPress, txtStaffFirstName.KeyPress, txtStaffLastName.KeyPress, txtStaffState.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz /"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtCustomerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaffID.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        clear()
    End Sub

    Private Sub txtStaffCity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStaffState.Focus()
        End If
    End Sub

    Private Sub txtStaffState_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffState.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbxStaffCountry.Focus()
        End If
    End Sub

    Private Sub txtStaffCountry_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxStaffCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.Focus()
        End If
    End Sub

    Dim AddNew As Integer = 0
    Dim ones, tens, hundreds, thousands As Integer
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click 'Add New button

        AddNew += 1
        If AddNew = 1 Then
            For Each btn In {btnDelete, btnFirstRecord, btnLastRecord, btnNext, btnPrevious, btnUpdate, btnViewDetails}
                btn.Enabled = False


                btnAddNew.Text = "Cancel"
                btnSubmit.Enabled = True
                btnReset.Enabled = True
                clear()
                txtStaffID.Enabled = True
                lblPrompt.Visible = True
                txtStaffID.Text = "SF"

                Dim Final As String = "SF000"
                Dim cmd As New OleDb.OleDbCommandBuilder(da)


                For i = 0 To ds.Tables("staffList").Rows.Count - 1
                    Dim OrderID As String = ds.Tables("staffList").Rows(i).Item(0).ToString
                    Dim Checked As String = String.Format("SF{0}{1}{2}", Format(hundreds, "0"), Format(tens, "0"), Format(ones, "0"))


                    If OrderID = Checked Then
                        ones += 1
                        If ones = 10 Then
                            tens += 1
                            ones = 0
                        ElseIf tens = 10 Then
                            hundreds += 1
                            tens = 0
                        ElseIf hundreds = 10 Then
                            ones = 0
                            tens = 0
                            hundreds = 0
                            MessageBox.Show("Record limit reach")
                        End If

                        Checked = String.Format("SF{0}{1}{2}", Format(hundreds, "0"), Format(tens, "0"), Format(ones, "0"))
                        Final = Checked
                    End If


                Next

                txtStaffID.Text = Final
                Final = "SF000"
                ones = 0
                tens = 0
                hundreds = 0
                thousands = 0
            Next
        End If

        If AddNew = 2 Then
            For Each btn In {btnDelete, btnFirstRecord, btnLastRecord, btnNext, btnPrevious, btnUpdate, btnViewDetails}
                btn.Enabled = True

                btnAddNew.Text = "Add New"
                btnSubmit.Enabled = False
                btnReset.Enabled = False
                AddNew = 0
                clear()
                NavigateRecord()
                txtStaffID.Enabled = False
                lblPrompt.Visible = False
                txtStaffID.Text = ds.Tables("staffList").Rows(Index).Item(0)
            Next
        End If



    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Check()
        If Error1 >= 1 Then

            MessageBox.Show("There are " & Error1 & " errors that needs to be resolved first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim cb As New OleDb.OleDbCommandBuilder(da)

            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("staffList").NewRow()
            dsNewRow.Item(0) = txtStaffID.Text
            dsNewRow.Item(1) = txtStaffFirstName.Text
            dsNewRow.Item(2) = txtStaffLastName.Text
            dsNewRow.Item(3) = txtStaffPassword.Text
            dsNewRow.Item(4) = cbxStaffGender.Text
            dsNewRow.Item(5) = StaffDOB.Text
            dsNewRow.Item(6) = txtStaffContact.Text
            dsNewRow.Item(7) = txtStaffEmail.Text
            dsNewRow.Item(8) = txtStaffStreet.Text
            dsNewRow.Item(9) = txtStaffCity.Text
            dsNewRow.Item(10) = txtStaffState.Text
            dsNewRow.Item(11) = cbxStaffCountry.Text


            ds.Tables("staffList").Rows.Add(dsNewRow)

            da.Update(ds, "staffList")

            For Each btn In {btnDelete, btnFirstRecord, btnLastRecord, btnNext, btnPrevious, btnReset, btnUpdate, btnViewDetails}
                btn.Enabled = True
            Next

            btnAddNew.Text = "Add New"
            btnSubmit.Enabled = False
            AddNew = 0
            clear()
            totalRecords = totalRecords + 1
            Index += 1
            txtStaffID.Enabled = False

            Counter = ds.Tables("staffList").Rows((ds.Tables("staffList").Rows.Count - 1)).Item(0)
            lblPrompt.Text = "Please Use No. above " & Counter

            MessageBox.Show("New Record added to the Database")
            clear()
            NavigateRecord()
            lblPrompt.Visible = False
            btnReset.Enabled = False

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click 'Update Button
        Check()
        If Error1 >= 1 Then
            MessageBox.Show("There are " & Error1 & " errors that needs to be resolved first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Update()
            MessageBox.Show("Update successful.")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If Index > 0 Then
            Index -= 1
            NavigateRecord()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If Index < (totalRecords - 1) Then
            Index += 1
            NavigateRecord()
        End If
    End Sub

    Private Sub btnFirstRecord_Click(sender As Object, e As EventArgs) Handles btnFirstRecord.Click
        Index = 0
        NavigateRecord()
    End Sub

    Private Sub btnLastRecord_Click(sender As Object, e As EventArgs) Handles btnLastRecord.Click
        Index = totalRecords - 1
        NavigateRecord()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Update()

        If MessageBox.Show("Delete selected Record?", "Delete",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Status Cancelled")
            Exit Sub
        End If

        ds.Tables("staffList").Rows(Index).Delete()


        da.Update(ds, "staffList")
        MessageBox.Show("Record deleted.")

        totalRecords = totalRecords - 1
        Index -= 1

        clear()
        NavigateRecord()


        Counter = ds.Tables("staffList").Rows((ds.Tables("staffList").Rows.Count - 1)).Item(0)
        lblPrompt.Text = "Please Use No. above " & Counter
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlViewRecords.Visible = False
        For Each btn In {btnDelete, btnFirstRecord, btnLastRecord, btnNext, btnPrevious, btnUpdate, btnViewDetails, btnReset}
            btn.Enabled = True

            lblPrompt.Visible = False
        Next
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        pnlViewRecords.Visible = True
        DataGridView1.DataSource = ds.Tables("staffList")

        For Each btn In {btnDelete, btnFirstRecord, btnLastRecord, btnNext, btnPrevious, btnUpdate, btnViewDetails, btnReset}
            btn.Enabled = False
        Next
    End Sub


    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtStaffPassword.UseSystemPasswordChar = False
        Else
            txtStaffPassword.UseSystemPasswordChar = True
        End If
    End Sub





    Private Sub txtStaffFirstName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffFirstName.KeyDown  'Enter shift focus feature
        If e.KeyCode = Keys.Enter Then
            txtStaffLastName.Focus()
        End If
    End Sub

    Private Sub txtStaffLastName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffLastName.KeyDown  'Enter shift focus feature
        If e.KeyCode = Keys.Enter Then
            txtStaffPassword.Focus()
        End If
    End Sub
    Private Sub txtStaffPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbxStaffGender.Focus()
        End If
    End Sub
    Private Sub cbxStaffGender_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxStaffGender.KeyDown
        If e.KeyCode = Keys.Enter Then
            StaffDOB.Focus()
        End If
    End Sub

    Private Sub StaffDOB_KeyDown(sender As Object, e As KeyEventArgs) Handles StaffDOB.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStaffContact.Focus()
        End If
    End Sub

    Private Sub txtStaffContact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffContact.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStaffEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStaffStreet.Focus()
        End If
    End Sub

    Private Sub txtStaffStreet_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaffStreet.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStaffCity.Focus()
        End If
    End Sub


    Dim Error1 As Integer
    Sub Check()
        Error1 = 0

        If IsNumeric(txtStaffFirstName.Text) = True Then 'Checks if value inputed is numeric(numbers)
            MessageBox.Show("First Name cannot contain numbers")
            txtStaffFirstName.Clear()
            txtStaffFirstName.Focus()
            lblInvalidFirstName.Visible = True
            Error1 += 1
        Else
            lblInvalidFirstName.Visible = False

        End If


        If IsNumeric(txtStaffLastName.Text) = True Then
            MessageBox.Show("Last Name cannot contain numbers")
            txtStaffLastName.Clear()
            txtStaffLastName.Focus()
            lblInvalidLastName.Visible = True
            Error1 += 1
        Else
            lblInvalidLastName.Visible = False

        End If



        If IsNumeric(txtStaffCity.Text) = True Then
            MessageBox.Show("City cannot contain numbers")
            txtStaffCity.Clear()
            txtStaffCity.Focus()
            lblInvalidCity.Visible = True
            Error1 += 1
        Else
            lblInvalidCity.Visible = False

        End If

        If IsNumeric(txtStaffState.Text) = True Then
            MessageBox.Show("State cannot contain numbers")
            txtStaffState.Clear()
            txtStaffState.Focus()
            lblInvalidState.Visible = True
            Error1 += 1
        Else
            lblInvalidState.Visible = False

        End If


        If txtStaffFirstName.Text = vbNullString Then 'Checks if the textbox is empty
            MessageBox.Show("First Name cannot be empty")
            txtStaffFirstName.Clear()
            txtStaffFirstName.Focus()
            lblInvalidFirstName.Visible = True
            Error1 += 1
        Else
            lblInvalidFirstName.Visible = False

        End If

        If txtStaffLastName.Text = vbNullString Then
            MessageBox.Show("Last Name cannot be empty")
            txtStaffLastName.Clear()
            txtStaffLastName.Focus()
            lblInvalidLastName.Visible = True
            Error1 += 1
        Else
            lblInvalidLastName.Visible = False

        End If


        If txtStaffPassword.Text = vbNullString Then
            MessageBox.Show("Last Name cannot be empty")
            txtStaffPassword.Clear()
            txtStaffPassword.Focus()
            lblInvalidPassword.Visible = True
            Error1 += 1
        Else
            lblInvalidPassword.Visible = False

        End If

        If cbxStaffGender.Text = vbNullString Then
            MessageBox.Show("Gender cannot be empty")
            cbxStaffGender.Focus()
            lblInvalidGender.Visible = True
            Error1 += 1
        Else
            lblInvalidGender.Visible = False

        End If

        If StaffDOB.Text = "  -  -" Or StaffDOB.Text.Length < 8 Then
            MessageBox.Show("Date cannnot be empty")
            StaffDOB.Focus()
            lblInvalidStaffDOB.Visible = True
            Error1 += 1
        Else
            lblInvalidStaffDOB.Visible = False

        End If



        If txtStaffContact.Text = "   -    " Or txtStaffContact.Text.Length < 12 Then
            MessageBox.Show("Contact cannot be empty")
            txtStaffContact.Clear()
            txtStaffContact.Focus()
            lblInvalidContact.Visible = True
            Error1 += 1
        Else
            lblInvalidContact.Visible = False

        End If

        If txtStaffEmail.Text = vbNullString Then
            MessageBox.Show("Email cannot be empty")
            txtStaffEmail.Clear()
            txtStaffEmail.Focus()
            lblInvalidEmail.Visible = True
            Error1 += 1
        Else
            lblInvalidEmail.Visible = False

        End If

        If txtStaffStreet.Text = vbNullString Then
            MessageBox.Show("Street cannot be empty")
            txtStaffStreet.Clear()
            txtStaffStreet.Focus()
            lblInvalidStreet.Visible = True
            Error1 += 1
        Else
            lblInvalidStreet.Visible = False

        End If

        If txtStaffCity.Text = vbNullString Then
            MessageBox.Show("City cannot be empty")
            txtStaffCity.Clear()
            txtStaffCity.Focus()
            lblInvalidCity.Visible = True
            Error1 += 1
        Else
            lblInvalidCity.Visible = False

        End If

        If txtStaffState.Text = vbNullString Then
            MessageBox.Show("State cannot be empty")
            txtStaffState.Clear()
            txtStaffState.Focus()
            lblInvalidState.Visible = True
            Error1 += 1
        Else
            lblInvalidState.Visible = False

        End If

        If cbxStaffCountry.Text = vbNullString Then
            MessageBox.Show("Country cannot be empty")
            cbxStaffCountry.Focus()
            lblInvalidCountry.Visible = True
            Error1 += 1
        Else
            lblInvalidCountry.Visible = False

        End If

        If txtStaffID.Text = "SF" Or txtStaffID.Text = "" Then
            MessageBox.Show("Staff ID cannot be empty")
            txtStaffID.Focus()
            lblInvalidState.Visible = True
            Error1 += 1
        Else
            lblInvalidState.Visible = False
        End If

        'Validaing email from https://www.aspsnippets.com/Articles/Email-Validation-using-Regular-Expression-in-C-and-VBNet.aspx
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txtStaffEmail.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid Email.")
            txtStaffEmail.Clear()
            txtStaffEmail.Focus()
            lblInvalidEmail.Visible = True
            Error1 += 1

        Else
            lblInvalidEmail.Visible = False
        End If
    End Sub


    Sub NavigateRecord()
        If ds.Tables("staffList").Rows.Count > 0 Then
            txtStaffID.Text = ds.Tables("staffList").Rows(Index).Item(0)
            txtStaffFirstName.Text = ds.Tables("staffList").Rows(Index).Item(1)
            txtStaffLastName.Text = ds.Tables("staffList").Rows(Index).Item(2)
            txtStaffPassword.Text = ds.Tables("staffList").Rows(Index).Item(3)
            cbxStaffGender.Text = ds.Tables("staffList").Rows(Index).Item(4)
            StaffDOB.Text = ds.Tables("staffList").Rows(Index).Item(5)
            txtStaffContact.Text = ds.Tables("staffList").Rows(Index).Item(6)
            txtStaffEmail.Text = ds.Tables("staffList").Rows(Index).Item(7)
            txtStaffStreet.Text = ds.Tables("staffList").Rows(Index).Item(8)
            txtStaffCity.Text = ds.Tables("staffList").Rows(Index).Item(9)
            txtStaffState.Text = ds.Tables("staffList").Rows(Index).Item(10)
            cbxStaffCountry.Text = ds.Tables("staffList").Rows(Index).Item(11)


        Else
            MessageBox.Show("No Data Found")
        End If
    End Sub
    Sub clear()
        For Each txt In {txtStaffFirstName, txtStaffCity, txtStaffContact, txtStaffEmail, txtStaffPassword, txtStaffState, txtStaffStreet, StaffDOB, txtStaffLastName}
            txt.Clear()

        Next
        cbxStaffGender.SelectedIndex = -1
        cbxStaffCountry.SelectedIndex = -1
        StaffDOB.ResetText()


        For Each lbl In {lblInvalidState, lblInvalidCity, lblInvalidPassword, lblInvalidContact, lblInvalidCountry, lblInvalidStaffDOB, lblInvalidEmail, lblInvalidFirstName, lblInvalidGender, lblInvalidLastName, lblInvalidState, lblInvalidStreet}
            lbl.Visible = False
        Next
    End Sub

    Overloads Sub Update()
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("staffList").Rows(Index).Item(0) = txtStaffID.Text
        ds.Tables("staffList").Rows(Index).Item(1) = txtStaffFirstName.Text
        ds.Tables("staffList").Rows(Index).Item(2) = txtStaffLastName.Text
        ds.Tables("staffList").Rows(Index).Item(3) = txtStaffPassword.Text
        ds.Tables("staffList").Rows(Index).Item(4) = cbxStaffGender.Text
        ds.Tables("staffList").Rows(Index).Item(5) = StaffDOB.Text
        ds.Tables("staffList").Rows(Index).Item(6) = txtStaffContact.Text
        ds.Tables("staffList").Rows(Index).Item(7) = txtStaffEmail.Text
        ds.Tables("staffList").Rows(Index).Item(8) = txtStaffStreet.Text
        ds.Tables("staffList").Rows(Index).Item(9) = txtStaffCity.Text
        ds.Tables("staffList").Rows(Index).Item(10) = txtStaffCity.Text
        ds.Tables("staffList").Rows(Index).Item(11) = cbxStaffCountry.Text

        da.Update(ds, "staffList")

    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        clear()
    End Sub
End Class