Imports System.ComponentModel
Imports System.Data.OleDb


'Default Login is SF001
'Password is password
Public Class FrmLogin

    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String
    Public staffID As String
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"
        con.ConnectionString = dbProvider & dbSource
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click  'Exit Button
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim StaffID, StaffPassword As String

        'Feature taught by Muhammad Fuad bin Abdullah TP055682 
        If txtStaffID.Text = vbNullString Or txtPassword.Text = vbNullString Then
            MessageBox.Show("Please fill your crredentials first")
            Exit Sub

        Else
            Dim cmd As New OleDbCommand("SELECT * FROM STAFF_T WHERE staffID = '" & Trim(txtStaffID.Text) & "' AND staffPassword = '" & Trim(txtPassword.Text) & "' ", con)
            con.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            sql = "Select * From STAFF_T"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "staffList")

            If (dr.Read() = True) Then
                StaffID = dr("staffID")
                StaffPassword = dr("staffPassword")

                StaffID = txtStaffID.Text

                FrmMainMenu.StartPosition = FormStartPosition.Manual
                FrmMainMenu.Location = Me.Location
                FrmMainMenu.Show()
                Me.Hide()

            Else
                MessageBox.Show("Credentials not found")


            End If
            con.Close()

            txtPassword.Clear()
            txtStaffID.Clear()

        End If

    End Sub

End Class
