Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Security.Authentication.ExtendedProtection
Imports System.Text.RegularExpressions


Public Class FrmRegister

    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim CustomerNumber As String
    Dim Index As Integer
    Dim totalRecords As Integer

    Dim Counter As String


    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        'MessageBox.Show("Connection opened.")

        sql = "SELECT * FROM CUSTOMER_T"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "customerList")
        con.Close()
        'MessageBox.Show("Connection closed.")


        Index = 0
        totalRecords = ds.Tables("customerList").Rows.Count
        NavigateRecord() 'Call Statement

        Counter = ds.Tables("customerList").Rows((ds.Tables("customerList").Rows.Count - 1)).Item(0)
        lblPrompt.Text = "Please Use No. above " & Counter
        Me.Size = New Point(1053, 600)
    End Sub


    'Only allows alpahbet
    Private Sub TextBox1KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustCity.KeyPress, txtCustFirstName.KeyPress, txtCustLastName.KeyPress, txtCustState.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz /."
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    'Only allows numbers for ID
    Private Sub txtCustomerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerID.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click 'Reset Button
        Clear()
    End Sub


    '##############START Enter shift focus feature START##################################
    Private Sub txtCustName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustFirstName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCustLastName.Focus()
        End If

    End Sub

    Private Sub txtCustLastName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustLastName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbxCustGender.Focus()
        End If
    End Sub

    Private Sub cbxCustGender_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxCustGender.KeyDown
        If e.KeyCode = Keys.Enter Then
            custDOB.Focus()
        End If
    End Sub

    Private Sub custDOB_KeyDown(sender As Object, e As KeyEventArgs) Handles custDOB.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCustContact.Focus()
        End If
    End Sub

    Private Sub txtCustContact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustContact.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCustStreet.Focus()
        End If
    End Sub

    Private Sub txtCustStreet_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustStreet.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCustCity.Focus()
        End If
    End Sub

    Private Sub txtCustCity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCustState.Focus()
        End If
    End Sub

    Private Sub txtCustState_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustState.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbxCustCountry.Focus()
        End If
    End Sub

    Private Sub txtCustCountry_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxCustCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.Focus()
        End If
    End Sub
    '############## END Enter shift focus feature END ##################################


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click 'Submit Button
        Check()

        If Error1 >= 1 Then
            MessageBox.Show("There are " & Error1 & " errors that needs to be resolved first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("customerList").NewRow()
            dsNewRow.Item(0) = txtCustomerID.Text
            dsNewRow.Item(1) = txtCustFirstName.Text
            dsNewRow.Item(2) = txtCustLastName.Text
            dsNewRow.Item(3) = cbxCustGender.Text
            dsNewRow.Item(4) = custDOB.Text
            dsNewRow.Item(5) = txtCustContact.Text
            dsNewRow.Item(6) = txtEmail.Text
            dsNewRow.Item(7) = txtCustStreet.Text
            dsNewRow.Item(8) = txtCustCity.Text
            dsNewRow.Item(9) = txtCustState.Text
            dsNewRow.Item(10) = cbxCustCountry.Text


            ds.Tables("customerList").Rows.Add(dsNewRow)

            da.Update(ds, "customerList")

            For Each btn In {btnDelete, btnFirstRecord, btnLastRecord, btnNext, btnPrevious, btnReset, btnUpdate, btnViewDetails}
                btn.Enabled = True
            Next

            btnAddNew.Text = "Add New"
            btnSubmit.Enabled = False
            AddNew = 0
            Clear()
            totalRecords = totalRecords + 1
            Index += 1
            txtCustomerID.Enabled = False

            Counter = ds.Tables("customerList").Rows((ds.Tables("customerList").Rows.Count - 1)).Item(0)
            lblPrompt.Text = "Please Use No. above " & Counter

            MessageBox.Show("New Record added to the Database")
            Clear()
            NavigateRecord()
            lblPrompt.Visible = False
            btnReset.Enabled = False

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
                Clear()
                txtCustomerID.Enabled = True
                lblPrompt.Visible = True
                txtCustomerID.Text = "CT"

                Dim Final As String = "CT0000"
                Dim cmd As New OleDb.OleDbCommandBuilder(da)

                For i = 0 To ds.Tables("customerList").Rows.Count - 1
                    Dim OrderID As String = ds.Tables("customerList").Rows(i).Item(0).ToString
                    Dim Checked As String = String.Format("CT{0}{1}{2}{3}", Format(thousands, "0"), Format(hundreds, "0"), Format(tens, "0"), Format(ones, "0"))


                    If OrderID = Checked Then
                        ones += 1
                        If ones = 10 Then
                            tens += 1
                            ones = 0
                        ElseIf tens = 10 Then
                            hundreds += 1
                            tens = 0
                        ElseIf hundreds = 10 Then
                            thousands += 1
                            hundreds = 0
                        ElseIf thousands = 10 Then
                            ones = 0
                            tens = 0
                            hundreds = 0
                            thousands = 0
                            MessageBox.Show("Record limit reach")
                        End If

                        Checked = String.Format("CT{0}{1}{2}{3}", Format(thousands, "0"), Format(hundreds, "0"), Format(tens, "0"), Format(ones, "0"))
                        Final = Checked

                    End If

                Next

                txtCustomerID.Text = Final
                Final = "CT0000"
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
                Clear()
                NavigateRecord()
                txtCustomerID.Enabled = False
                lblPrompt.Visible = False
                txtCustomerID.Text = ds.Tables("customerList").Rows(Index).Item(0)
                NavigateRecord()

            Next
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Delete Button
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Update()

        If MessageBox.Show("Delete selected Record?", "Delete",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Status Cancelled")
            Exit Sub
        End If

        ds.Tables("customerList").Rows(Index).Delete()


        da.Update(ds, "customerList")
        MessageBox.Show("Record deleted.")

        totalRecords = totalRecords - 1
        Index -= 1

        Clear()
        NavigateRecord()


        Counter = ds.Tables("customerList").Rows((ds.Tables("customerList").Rows.Count - 1)).Item(0)
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
        DataGridView1.DataSource = ds.Tables("customerList")

        For Each btn In {btnDelete, btnFirstRecord, btnLastRecord, btnNext, btnPrevious, btnUpdate, btnViewDetails, btnReset}
            btn.Enabled = False
        Next
    End Sub

    Overloads Sub Update()
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("customerList").Rows(Index).Item(0) = txtCustomerID.Text
        ds.Tables("customerList").Rows(Index).Item(1) = txtCustFirstName.Text
        ds.Tables("customerList").Rows(Index).Item(2) = txtCustLastName.Text
        ds.Tables("customerList").Rows(Index).Item(3) = cbxCustGender.Text
        ds.Tables("customerList").Rows(Index).Item(4) = custDOB.Text
        ds.Tables("customerList").Rows(Index).Item(5) = txtCustContact.Text
        ds.Tables("customerList").Rows(Index).Item(6) = txtEmail.Text
        ds.Tables("customerList").Rows(Index).Item(7) = txtCustStreet.Text
        ds.Tables("customerList").Rows(Index).Item(8) = txtCustCity.Text
        ds.Tables("customerList").Rows(Index).Item(9) = txtCustCity.Text
        ds.Tables("customerList").Rows(Index).Item(10) = cbxCustCountry.Text

        da.Update(ds, "customerList")

    End Sub

    Sub NavigateRecord()
        If ds.Tables("customerList").Rows.Count > 0 Then
            txtCustomerID.Text = ds.Tables("customerList").Rows(Index).Item(0)
            txtCustFirstName.Text = ds.Tables("customerList").Rows(Index).Item(1)
            txtCustLastName.Text = ds.Tables("customerList").Rows(Index).Item(2)
            cbxCustGender.Text = ds.Tables("customerList").Rows(Index).Item(3)
            custDOB.Text = ds.Tables("customerList").Rows(Index).Item(4)
            txtCustContact.Text = ds.Tables("customerList").Rows(Index).Item(5)
            txtEmail.Text = ds.Tables("customerList").Rows(Index).Item(6)
            txtCustStreet.Text = ds.Tables("customerList").Rows(Index).Item(7)
            txtCustCity.Text = ds.Tables("customerList").Rows(Index).Item(8)
            txtCustState.Text = ds.Tables("customerList").Rows(Index).Item(9)
            cbxCustCountry.Text = ds.Tables("customerList").Rows(Index).Item(10)

            'DataGridView1.DataSource = ds.Tables("studentList")
        Else
            MessageBox.Show("No Data Found")
        End If
    End Sub


    Sub Clear()

        For Each txt In {txtCustCity, txtCustContact, txtCustFirstName, txtCustLastName, txtCustState, txtCustStreet, txtEmail, custDOB}
            txt.Clear()
        Next

        cbxCustGender.SelectedIndex = -1
        cbxCustCountry.SelectedIndex = -1

        For Each lbl In {lblInavlidCustNo, lblInvalidCity, lblInvalidContact, lblInvalidCountry, lblInvalidDate, lblInvalidEmail, lblInvalidFirstName, lblInvalidGender, lblInvalidLastName, lblInvalidState, lblInvalidStreet}
            lbl.Visible = False
        Next
    End Sub

    Dim Error1 As Integer
    Sub Check()
        Error1 = 0
        If IsNumeric(txtCustFirstName.Text) = True Then 'Checks if value inputed is numeric(numbers)
            MessageBox.Show("First Name cannot contain numbers")
            txtCustFirstName.Clear()
            txtCustFirstName.Focus()
            lblInvalidFirstName.Visible = True
            Error1 += 1
        Else
            lblInvalidFirstName.Visible = False

        End If


        If IsNumeric(txtCustLastName.Text) = True Then
            MessageBox.Show("Last Name cannot contain numbers")
            txtCustLastName.Clear()
            txtCustLastName.Focus()
            lblInvalidLastName.Visible = True
            Error1 += 1
        Else
            lblInvalidLastName.Visible = False

        End If



        If IsNumeric(txtCustCity.Text) = True Then
            MessageBox.Show("City cannot contain numbers")
            txtCustCity.Clear()
            txtCustCity.Focus()
            lblInvalidCity.Visible = True
            Error1 += 1
        Else
            lblInvalidCity.Visible = False

        End If

        If IsNumeric(txtCustState.Text) = True Then
            MessageBox.Show("State cannot contain numbers")
            txtCustState.Clear()
            txtCustState.Focus()
            lblInvalidState.Visible = True
            Error1 += 1
        Else
            lblInvalidState.Visible = False

        End If


        If txtCustFirstName.Text = vbNullString Then 'Checks if the textbox is empty
            MessageBox.Show("First Name cannot be empty")
            txtCustFirstName.Clear()
            txtCustFirstName.Focus()
            lblInvalidFirstName.Visible = True
            Error1 += 1
        Else
            lblInvalidFirstName.Visible = False

        End If

        If txtCustLastName.Text = vbNullString Then
            MessageBox.Show("Last Name cannot be empty")
            txtCustLastName.Clear()
            txtCustLastName.Focus()
            lblInvalidLastName.Visible = True
            Error1 += 1
        Else
            lblInvalidLastName.Visible = False

        End If

        If cbxCustGender.Text = vbNullString Then
            MessageBox.Show("Gender cannot be empty")
            cbxCustGender.Focus()
            lblInvalidGender.Visible = True
            Error1 += 1
        Else
            lblInvalidGender.Visible = False

        End If

        If custDOB.Text = "  -  -" Or custDOB.Text.Length < 8 Then
            MessageBox.Show("Date not selected")
            custDOB.Focus()
            lblInvalidDate.Visible = True
            Error1 += 1
        Else
            lblInvalidDate.Visible = False

        End If

        If txtCustContact.Text = "   -    " Or txtCustContact.Text.Length < 12 Then
            MessageBox.Show("Contact cannot be empty")
            txtCustContact.Clear()
            txtCustContact.Focus()
            lblInvalidContact.Visible = True
            Error1 += 1
        Else
            lblInvalidContact.Visible = False

        End If

        If txtEmail.Text = vbNullString Then
            MessageBox.Show("Email cannot be empty")
            txtEmail.Clear()
            txtEmail.Focus()
            lblInvalidEmail.Visible = True
            Error1 += 1
        Else
            lblInvalidEmail.Visible = False

        End If

        If txtCustStreet.Text = vbNullString Then
            MessageBox.Show("Street cannot be empty")
            txtCustStreet.Clear()
            txtCustStreet.Focus()
            lblInvalidStreet.Visible = True
            Error1 += 1
        Else
            lblInvalidStreet.Visible = False

        End If

        If txtCustCity.Text = vbNullString Then
            MessageBox.Show("City cannot be empty")
            txtCustCity.Clear()
            txtCustCity.Focus()
            lblInvalidCity.Visible = True
            Error1 += 1
        Else
            lblInvalidCity.Visible = False

        End If

        If txtCustState.Text = vbNullString Then
            MessageBox.Show("State cannot be empty")
            txtCustState.Clear()
            txtCustState.Focus()
            lblInvalidState.Visible = True
            Error1 += 1
        Else
            lblInvalidState.Visible = False

        End If

        If cbxCustCountry.Text = vbNullString Then
            MessageBox.Show("Country cannot be empty")
            cbxCustCountry.Focus()
            lblInvalidCountry.Visible = True
            Error1 += 1
        Else
            lblInvalidCountry.Visible = False

        End If


        If txtCustomerID.Text = "CT" Or txtCustomerID.Text = "" Then
            MessageBox.Show("Customer ID cannot be empty")
            txtCustomerID.Focus()
            lblInavlidCustNo.Visible = True
            Error1 += 1
        Else
            lblInavlidCustNo.Visible = False

        End If

        'Validaing email from https://www.aspsnippets.com/Articles/Email-Validation-using-Regular-Expression-in-C-and-VBNet.aspx
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txtEmail.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid Email.")
            txtEmail.Clear()
            txtEmail.Focus()
            lblInvalidEmail.Visible = True
            Error1 += 1

        Else
            lblInvalidEmail.Visible = False
        End If

    End Sub



End Class