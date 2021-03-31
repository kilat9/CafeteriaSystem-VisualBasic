Imports System.ComponentModel

Public Class FrmReservation

    Dim CurrentItem As Integer = 0
    Dim Count As Integer = 0

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click 'Reserve function

        Check()
        'Count = Count + 1

        If Error1 >= 1 Then
            MessageBox.Show("There are " & Error1 & " errors that needs to be resolved first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim ReserveName, ReserveContact, ReserveNumber, ReserveDate, ReserveTime As String
            ReserveName = txtReserveName.Text.ToString
            ReserveContact = txtReserveContact.Text.ToString
            ReserveNumber = txtReserveNumber.Value.ToString
            ReserveDate = DateTimePicker1.Value.ToShortDateString
            ReserveTime = txtTime.Text.ToString & cbxAmPm.Text.ToString

            totalRecords = ds.Tables("reserveList").Rows.Count

            lsvReservation.Items.Add(ReserveName)
            lsvReservation.Items(totalRecords).SubItems.Add(ReserveContact)
            lsvReservation.Items(totalRecords).SubItems.Add(ReserveNumber)
            lsvReservation.Items(totalRecords).SubItems.Add(ReserveDate)
            lsvReservation.Items(totalRecords).SubItems.Add(ReserveTime)

            Dim cb As New OleDb.OleDbCommandBuilder(da)




            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("reserveList").NewRow()
            dsNewRow.Item(0) = ReserveName
            dsNewRow.Item(1) = ReserveContact
            dsNewRow.Item(2) = ReserveNumber
            dsNewRow.Item(3) = ReserveDate
            dsNewRow.Item(4) = ReserveTime

            ds.Tables("reserveList").Rows.Add(dsNewRow)

            da.Update(ds, "reserveList")

            totalRecords = totalRecords + 1
            Index += 1

            MessageBox.Show("New Record added to the Database")

            txtReserveName.Clear()
            txtReserveContact.Clear()
            txtReserveNumber.Value = 0
            DateTimePicker1.ResetText()
            txtTime.Clear()
        End If







        'Increment row number for next row
        CurrentItem += 1
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'lstbxReservation.Items.Clear()
        'lstbxReservation.Items.Add("Reservist Name" & vbTab & vbTab & "Contact" & vbTab & vbTab & "Number of pax" & vbTab & "Date" & vbTab & vbTab & "Time") 'Initialize listbox
        'lstbxReservation.Items.Add("-------------" & vbTab & vbTab & "-------------" & vbTab & "-------------" & vbTab & "-------------" & vbTab & "-------------")

        Count = 0
        txtReserveName.Clear()
        txtReserveContact.Clear()
        txtReserveNumber.Value = 0
        DateTimePicker1.ResetText()
        txtTime.Clear()
        lsvReservation.Items.Clear()
    End Sub

    Private Sub txtReserveName_Validating(sender As Object, e As CancelEventArgs) Handles txtReserveName.Validating
        If IsNumeric(txtReserveName.Text) = True Then
            MessageBox.Show("Invalid Name")
            txtReserveName.Clear()
            txtReserveName.Focus()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim index As Integer

            index = lsvReservation.FocusedItem.Index


            If MessageBox.Show("Delete selected Record?", "Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Status Cancelled")
                Exit Sub
            End If



            ds.Tables("reserveList").Rows(lsvReservation.FocusedItem.Index).Delete()
            da.Update(ds, "reserveList")
            MessageBox.Show("Record deleted.")


            lsvReservation.Items.RemoveAt(index)

        Catch exception As Exception
            MessageBox.Show("Error. Please reopen the form again to delete the record")

        End Try
    End Sub

    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim CustomerNumber As String
    Dim Index As Integer
    Dim totalRecords As Integer
    Private Sub FrmReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(1053, 600)

        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()
        'MessageBox.Show("Connection opened.")

        sql = "SELECT * FROM RESERVATION_T"

        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "reserveList")


        totalRecords = ds.Tables("reserveList").Rows.Count
        For i = 0 To totalRecords - 1 Step 1
            lsvReservation.Items.Add(ds.Tables("reserveList").Rows(i).Item(0))
            lsvReservation.Items(i).SubItems.Add(ds.Tables("reserveList").Rows(i).Item(1))
            lsvReservation.Items(i).SubItems.Add(ds.Tables("reserveList").Rows(i).Item(2))
            lsvReservation.Items(i).SubItems.Add(ds.Tables("reserveList").Rows(i).Item(3))
            lsvReservation.Items(i).SubItems.Add(ds.Tables("reserveList").Rows(i).Item(4))

        Next
        con.Close()
        'MessageBox.Show("Connection closed.")


        Index = 0

    End Sub

    Dim Error1 As Integer
    Sub Check()
        Error1 = 0
        If txtReserveName.Text = vbNullString Or IsNumeric(txtReserveName.Text) Then
            MessageBox.Show("Invalid Name")
            txtReserveName.Clear()
            txtReserveName.Focus()
            Error1 += 1
        End If

        If txtReserveContact.Text = vbNullString Or txtReserveContact.Text = "   -    " Or txtReserveContact.Text.Length < 12 Then
            MessageBox.Show("Invalid Contact")
            txtReserveContact.Clear()
            txtReserveContact.Focus()
            Error1 += 1
        End If

        If txtReserveNumber.Text = vbNullString Or txtReserveNumber.Text = "0" Then
            MessageBox.Show("Invalid Number")
            txtReserveNumber.Value = 0
            txtReserveNumber.Focus()
            Error1 += 1
        End If

        If txtTime.Text = vbNullString Or txtTime.Text = "  :" Or txtTime.Text.Length < 5 Then
            MessageBox.Show("Invalid Time")
            txtTime.Clear()
            txtTime.Focus()
            Error1 += 1
        End If




    End Sub

    Private Sub txtReserveName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReserveName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz /"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub
End Class
