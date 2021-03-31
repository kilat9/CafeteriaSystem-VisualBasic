Public Class FrmMainMenu
    'Dim todaysdate As String = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now) 'Set date
    Public staffID As String
    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Dim firstName As String
    Dim lastName As String

    Dim ones, tens, hundreds, thousands As Integer
    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 'Timer for the date 1000 units = 1second irl
        Timer1.Start()
        Me.Size = New Point(1305, 803)

        lblProfileID.Text = FrmLogin.txtStaffID.Text

        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"
        con.ConnectionString = dbProvider & dbSource

        con.Open()
        'MessageBox.Show("Connection opened.")

        sql = "SELECT staffFirstName, staffLastName FROM STAFF_T WHERE staffID= '" & Trim(lblProfileID.Text) & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "staffList")
        con.Close()

        firstName = ds.Tables("staffList").Rows(0).Item(0)
        lastName = ds.Tables("staffList").Rows(0).Item(1)
        lblProfileName.Text = firstName & " " & lastName

    End Sub

    Dim da2 As OleDb.OleDbDataAdapter
    Dim ds2 As New DataSet
    Dim sql2 As String
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        con.Open()
        sql2 = "SELECT * FROM ORDER_T"
        da2 = New OleDb.OleDbDataAdapter(sql2, con)
        da2.Fill(ds2, "OrderList")
        con.Close()
        Dim Final As String = "OD0000"

        Dim cmd As New OleDb.OleDbCommandBuilder(da2)

        For i = 0 To ds2.Tables("OrderList").Rows.Count - 1
            Dim OrderID As String = ds2.Tables("OrderList").Rows(i).Item(0).ToString
            Dim Checked As String = String.Format("OD{0}{1}{2}{3}", Format(thousands, "0"), Format(hundreds, "0"), Format(tens, "0"), Format(ones, "0"))


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

                Checked = String.Format("OD{0}{1}{2}{3}", Format(thousands, "0"), Format(hundreds, "0"), Format(tens, "0"), Format(ones, "0"))
                Final = Checked
            End If


        Next

        FrmOrder.txtOrderID.Text = Final
        Final = "OD0000"
        ones = 0
        tens = 0
        hundreds = 0
        thousands = 0

        btnReservation.BackColor = Color.DodgerBlue
        btnRegisterStaff.BackColor = Color.DodgerBlue
        btnRegister.BackColor = Color.DodgerBlue
        btnOrder.BackColor = Color.DeepSkyBlue
        btnReceiptHistory.BackColor = Color.DodgerBlue
        FrmOrder.Show()
        FrmOrder.MdiParent = Me
        FrmOrder.Location = New Point(197, 130)
        LblFormTitle.Text = "ORDER"
        FrmRegisterStaff.Close()
        FrmReservation.Close()
        FrmRegister.Close()
        FrmRegisterStaff.Close()
        frmReceiptHistory.Close()



    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        btnReservation.BackColor = Color.DodgerBlue
        btnRegisterStaff.BackColor = Color.DodgerBlue
        btnRegister.BackColor = Color.DeepSkyBlue
        btnOrder.BackColor = Color.DodgerBlue
        btnReceiptHistory.BackColor = Color.DodgerBlue
        FrmRegister.Show()
        FrmRegister.MdiParent = Me
        FrmRegister.Location = New Point(197, 130)
        LblFormTitle.Text = "REGISTER CUSTOMER"
        LblFormTitle.Location = New Point(486, 30)
        FrmRegisterStaff.Close()
        FrmOrder.Close()
        FrmReservation.Close()
        frmReceiptHistory.Close()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnRegisterStaff.Click
        btnReservation.BackColor = Color.DodgerBlue
        btnRegisterStaff.BackColor = Color.DeepSkyBlue
        btnRegister.BackColor = Color.DodgerBlue
        btnOrder.BackColor = Color.DodgerBlue
        btnReceiptHistory.BackColor = Color.DodgerBlue
        FrmRegisterStaff.Show()
        FrmRegisterStaff.MdiParent = Me
        FrmRegisterStaff.Location = New Point(197, 130)
        LblFormTitle.Text = "REGISTER STAFF"
        LblFormTitle.Location = New Point(536, 30)
        FrmOrder.Close()
        FrmRegister.Close()
        FrmReservation.Close()
        frmReceiptHistory.Close()
    End Sub

    Private Sub btnReceiptHistory_Click(sender As Object, e As EventArgs) Handles btnReceiptHistory.Click
        btnReservation.BackColor = Color.DodgerBlue
        btnRegisterStaff.BackColor = Color.DodgerBlue
        btnRegister.BackColor = Color.DodgerBlue
        btnReceiptHistory.BackColor = Color.DeepSkyBlue
        btnOrder.BackColor = Color.DodgerBlue
        frmReceiptHistory.Show()
        frmReceiptHistory.MdiParent = Me
        frmReceiptHistory.Location = New Point(197, 130)
        LblFormTitle.Text = "RECEIPT"
        LblFormTitle.Location = New Point(536, 30)
        FrmOrder.Close()
        FrmRegister.Close()
        FrmRegisterStaff.Close()
        FrmReservation.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnReservation.BackColor = Color.DodgerBlue
        btnRegisterStaff.BackColor = Color.DodgerBlue
        btnRegister.BackColor = Color.DodgerBlue
        btnOrder.BackColor = Color.DodgerBlue
        btnReceiptHistory.BackColor = Color.DodgerBlue
        FrmLogin.StartPosition = FormStartPosition.Manual
        FrmLogin.Location = Me.Location
        FrmLogin.Show()
        LblFormTitle.Text = "MAIN MENU"
        LblFormTitle.Location = New Point(536, 30)
        Me.Close()
        Me.Close()
        FrmRegisterStaff.Close()
        FrmOrder.Close()
        FrmRegister.Close()
        FrmReservation.Close()
        frmReceiptHistory.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'Clock function
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        btnReservation.BackColor = Color.DeepSkyBlue
        btnRegisterStaff.BackColor = Color.DodgerBlue
        btnRegister.BackColor = Color.DodgerBlue
        btnOrder.BackColor = Color.DodgerBlue
        btnReceiptHistory.BackColor = Color.DodgerBlue
        FrmReservation.Show()
        FrmReservation.MdiParent = Me
        FrmReservation.Location = New Point(197, 130)
        LblFormTitle.Text = "RESERVATION"
        LblFormTitle.Location = New Point(536, 30)
        FrmOrder.Close()
        FrmRegister.Close()
        FrmRegisterStaff.Close()
        frmReceiptHistory.Close()


    End Sub


End Class