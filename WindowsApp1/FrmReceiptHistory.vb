Imports System.Data.OleDb

Public Class frmReceiptHistory

    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim OrderID As String
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        lbxFoodSelected.Items.Clear()
        lbxPrice.Items.Clear()
        lbxQuantity.Items.Clear()
        ds.Tables("ORDERList").Clear()

        OrderID = txtOrderID.Text
        Dim cmd As New OleDbCommand("SELECT * FROM ORDER_T WHERE orderID = '" & OrderID & "'", con)

        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        sql = "Select * From ORDER_T WHERE orderID = '" & OrderID & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "ORDERList")

        If (dr.Read() = True) Then
            For index = 0 To ds.Tables("ORDERList").Rows.Count - 1

                If ds.Tables("ORDERList").Rows.Count > 0 Then
                    lblOrderID.Text = ds.Tables("ORDERList").Rows(index).Item(0)
                    lbxFoodSelected.Items.Add(ds.Tables("ORDERList").Rows(index).Item(1))
                    lbxQuantity.Items.Add(ds.Tables("ORDERList").Rows(index).Item(2))
                    lbxPrice.Items.Add(ds.Tables("ORDERList").Rows(index).Item(3))
                    lblPaymentSubtotal.Text = ds.Tables("ORDERList").Rows(index).Item(4)
                    lblPaymentTax.Text = ds.Tables("ORDERList").Rows(index).Item(5)
                    lblTotalAmount.Text = ds.Tables("ORDERList").Rows(index).Item(6)
                    lblCustomerPay.Text = ds.Tables("ORDERList").Rows(index).Item(7)
                    lblBalance.Text = ds.Tables("ORDERList").Rows(index).Item(8)
                    lblCustomerID.Text = ds.Tables("ORDERList").Rows(index).Item(9)
                    lblStaffID.Text = ds.Tables("ORDERList").Rows(index).Item(10)

                    lblOrderDate.Text = ds.Tables("ORDERList").Rows(index).Item(12).ToString

                End If
            Next

        Else
            MessageBox.Show("Record not found")


        End If
        con.Close()

    End Sub


    Dim sql2 As String
    Dim da2 As OleDb.OleDbDataAdapter
    Dim ds2 As New DataSet
    Private Sub frmReceiptHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"
        con.ConnectionString = dbProvider & dbSource

        Dim cmd As New OleDbCommand("SELECT * FROM ORDER_T WHERE orderID = '" & OrderID & "'", con)

        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        sql = "Select * From ORDER_T"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "ORDERList")

        sql2 = "Select DISTINCT orderID From ORDER_T"
        da2 = New OleDb.OleDbDataAdapter(sql2, con)
        da2.Fill(ds2, "ORDERList2")

        con.Close()


        For Order = 0 To ds2.Tables("ORDERList2").Rows.Count - 1
            txtOrderID.Items.Add(ds2.Tables("ORDERList2").Rows(Order).Item(0))
        Next
    End Sub


End Class