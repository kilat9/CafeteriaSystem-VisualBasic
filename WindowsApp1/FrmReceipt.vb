Public Class FrmReceipt
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        FrmOrder.Show()
        FrmOrder.Location = New Point(197, 130)
        Me.Hide()
    End Sub

    Dim orderID As String = FrmOrder.txtOrderID.Text
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet


    Private Sub FrmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(1053, 600)
        Me.Location = New Point(350, 350)
        orderID = FrmOrder.orderID2

        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        'MessageBox.Show("Connection opened.")

        sql = "SELECT * FROM ORDER_T WHERE orderID = '" & orderID & "'"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "ORDERList")
        con.Close()
        'MessageBox.Show("Connection closed.")



        InitialiveValues()
    End Sub


    Sub InitialiveValues()

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

                lblOrderDate.Text = ds.Tables("ORDERList").Rows(index).Item(12)

                'DataGridView1.DataSource = ds.Tables("studentList")
            Else
                MessageBox.Show("No Data Found")
            End If

        Next
    End Sub
End Class