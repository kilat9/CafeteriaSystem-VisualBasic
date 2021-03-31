Imports System.Windows.Forms.VisualStyles

'ORDER system inspired by DJ Oamen on Youtube
'https://www.youtube.com/watch?v=4OA9rMfGBjQ
Public Class FrmOrder

    Const PriceFriedRice As Decimal = 5
    Const PriceChickenRice As Decimal = 3.5
    Const PriceFriedNoodles As Decimal = 5
    Const PriceSoupNoodles As Decimal = 4.5
    Const PriceChickenBurger As Decimal = 6.5
    Const PriceShepardPie As Decimal = 15
    Const PriceBeefBurger As Decimal = 7.5
    Const PriceSandwich As Decimal = 2
    Const PricePizza As Decimal = 10
    Const PriceRotiCanai As Decimal = 1.5
    Const PriceSpaghetti As Decimal = 4.5
    Const PriceToast As Decimal = 1.5
    Const PriceMineralWater As Decimal = 1
    Const PriceSirap As Decimal = 1.5
    Const PriceLemonade As Decimal = 1.5
    Const PriceCannedDrinks As Decimal = 2.5
    Const PriceMilo As Decimal = 2
    Const PriceShake As Decimal = 5
    Const PriceChocalateCake As Decimal = 2.5
    Const PriceIceCream As Decimal = 1.5
    Const PriceVanillaCake As Decimal = 2.5
    Const PriceShavedIce As Decimal = 3.5
    Const PriceStrawberry As Decimal = 2.5
    Const PriceApplePie As Decimal = 4.5

    Dim Tax As Decimal = 0.06
    Dim SubTotal As Decimal
    Dim SubTotalTax As Decimal
    Dim Total As Decimal
    Dim itemcost(23) As Decimal

    Dim orderID As String


    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String

    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim CustomerNumber As String

    Dim sql3 As String
    Dim da3 As OleDb.OleDbDataAdapter
    Dim ds3 As New DataSet

    Dim totalRecords As Integer

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(1053, 600)

        staffID = FrmMainMenu.lblProfileID.Text

        orderDate = FrmMainMenu.lblDate.Text

        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        'MessageBox.Show("Connection opened.")

        Sql = "SELECT * FROM ORDER_T"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "ORDERList")

        con.Close()
        'MessageBox.Show("Connection closed.")

        con.Open()
        sql3 = "SELECT * FROM CUSTOMER_T"
        da3 = New OleDb.OleDbDataAdapter(sql3, con)
        da3.Fill(ds3, "customerList")
        con.Close()

        totalRecords = (ds.Tables("ORDERList").Rows.Count)
        orderID = ds.Tables("ORDERList").Rows(totalRecords - 1).Item(0)

        lblPrompt.Text = "Please Use No. above " & orderID


        For Customer = 0 To (ds3.Tables("customerList").Rows.Count) - 1
            txtCustomerID.Items.Add(ds3.Tables("customerList").Rows(Customer).Item(0))
        Next

        'Clear()
    End Sub
    Dim AfterTax As Double
    Sub Calculate()
        SubTotal = 0
        SubTotalTax = 0
        Total = 0


        itemcost(0) = QuantityApplePie.Value * PriceApplePie
        itemcost(1) = QuantityBeefBurger.Value * PriceBeefBurger
        itemcost(2) = QuantityCannedDrinks.Value * PriceCannedDrinks
        itemcost(3) = QuantityChickenBurger.Value * PriceChickenBurger
        itemcost(4) = QuantityChickenRice.Value * PriceChickenRice
        itemcost(5) = QuantityChocolateCake.Value * PriceChocalateCake
        itemcost(6) = QuantityFriedNoodles.Value * PriceFriedNoodles
        itemcost(7) = QuantityFriedRice.Value * PriceFriedRice
        itemcost(8) = QuantityIceCream.Value * PriceIceCream
        itemcost(9) = QuantityLemonade.Value * PriceLemonade
        itemcost(10) = QuantityMilo.Value * PriceMilo
        itemcost(11) = QuantityMineral.Value * PriceMineralWater
        itemcost(12) = QuantityPizza.Value * PricePizza
        itemcost(13) = QuantityRotiCanai.Value * PriceRotiCanai
        itemcost(14) = QuantitySandwich.Value * PriceSandwich
        itemcost(15) = QuantityShake.Value * PriceShake
        itemcost(16) = QuantityShavedIce.Value * PriceShavedIce
        itemcost(17) = QuantityShepardpie.Value * PriceShepardPie
        itemcost(18) = QuantitySirap.Value * PriceSirap
        itemcost(19) = QuantitySoupNoodles.Value * PriceSoupNoodles
        itemcost(20) = QuantitySpaghetti.Value * PriceSpaghetti
        itemcost(21) = QuantityStrawberryCake.Value * PriceStrawberry
        itemcost(22) = QuantityToast.Value * PriceToast
        itemcost(23) = QuantityVanillaCake.Value * PriceVanillaCake

        SubTotal = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) + itemcost(7) + itemcost(8) + itemcost(9) + itemcost(10) + itemcost(11) + itemcost(12) + itemcost(13) + itemcost(14) + itemcost(15) + itemcost(16) + itemcost(17) + itemcost(18) + itemcost(19) + itemcost(20) + itemcost(21) + itemcost(22) + itemcost(23)
        SubTotalTax = SubTotal * Tax
        Total = SubTotal + SubTotalTax
        Total = Math.Round(Total, 1)
        'Total = itemcost(0)
        lblSubTotal.Text = "Subtotal : RM" & SubTotal.ToString("F2")
        lblTax.Text = "Tax (6%) : RM" & SubTotalTax.ToString("F2")
        lbltotal.Text = "Total Payment : RM" & (Math.Round(Total, 1)).ToString("F2")
        AfterTax = SubTotalTax

        lblPaymentSubtotal.Text = "Subtotal : RM" & SubTotal.ToString("F2")
        lblPaymentTax.Text = "Tax (6%) : RM" & AfterTax.ToString("F2")
        lblTotalAmount.Text = "Total Payment : RM" & (Math.Round(Total, 1)).ToString("F2")





        If QuantityApplePie.Enabled = True And QuantityApplePie.Value = 0 Then
            cbxApplePie.Checked = False
        End If

        If QuantityBeefBurger.Enabled = True And QuantityBeefBurger.Value = 0 Then
            cbxBeefBurger.Checked = False
        End If

        If QuantityCannedDrinks.Enabled = True And QuantityCannedDrinks.Value = 0 Then
            cbxCannedDrinks.Checked = False
        End If

        If QuantityChickenBurger.Enabled = True And QuantityChickenBurger.Value = 0 Then
            cbxChickenBurger.Checked = False
        End If

        If QuantityChickenRice.Enabled = True And QuantityChickenRice.Value = 0 Then
            cbxChickenRice.Checked = False
        End If

        If QuantityChocolateCake.Enabled = True And QuantityChocolateCake.Value = 0 Then
            cbxChocolateCake.Checked = False
        End If

        If QuantityFriedNoodles.Enabled = True And QuantityFriedNoodles.Value = 0 Then
            cbxFriedNoodles.Checked = False
        End If

        If QuantityFriedRice.Enabled = True And QuantityFriedRice.Value = 0 Then
            cbxFriedRice.Checked = False
        End If

        If QuantityIceCream.Enabled = True And QuantityIceCream.Value = 0 Then
            cbxIceCream.Checked = False
        End If

        If QuantityLemonade.Enabled = True And QuantityLemonade.Value = 0 Then
            cbxLemonade.Checked = False
        End If

        If QuantityMilo.Enabled = True And QuantityMilo.Value = 0 Then
            cbxMilo.Checked = False
        End If

        If QuantityMineral.Enabled = True And QuantityMineral.Value = 0 Then
            cbxMineralWater.Checked = False
        End If

        If QuantityPizza.Enabled = True And QuantityPizza.Value = 0 Then
            cbxPizza.Checked = False
        End If

        If QuantityRotiCanai.Enabled = True And QuantityRotiCanai.Value = 0 Then
            cbxRotiCanai.Checked = False
        End If

        If QuantitySandwich.Enabled = True And QuantitySandwich.Value = 0 Then
            cbxSandwich.Checked = False
        End If

        If QuantityShake.Enabled = True And QuantityShake.Value = 0 Then
            cbxShake.Checked = False
        End If

        If QuantityShavedIce.Enabled = True And QuantityShavedIce.Value = 0 Then
            cbxShavedIce.Checked = False
        End If

        If QuantityShepardpie.Enabled = True And QuantityShepardpie.Value = 0 Then
            cbxShepardpie.Checked = False
        End If

        If QuantitySirap.Enabled = True And QuantitySirap.Value = 0 Then
            cbxSirap.Checked = False
        End If

        If QuantitySoupNoodles.Enabled = True And QuantitySoupNoodles.Value = 0 Then
            cbxSoupNoodles.Checked = False
        End If

        If QuantitySpaghetti.Enabled = True And QuantitySpaghetti.Value = 0 Then
            cbxSpaghetti.Checked = False
        End If
        If QuantityStrawberryCake.Enabled = True And QuantityStrawberryCake.Value = 0 Then
            cbxStrawberry.Checked = False
        End If
        If QuantityToast.Enabled = True And QuantityToast.Value = 0 Then
            cbxToast.Checked = False
        End If
        If QuantityVanillaCake.Enabled = True And QuantityVanillaCake.Value = 0 Then
            cbxVanillaCake.Checked = False
        End If

    End Sub
    Dim error1 As Integer = 0
    Sub CheckItems()
        lbxFoodSelected.Items.Clear()
        lbxQuantity.Items.Clear()
        lbxPrice.Items.Clear()
        itemcost(0) = QuantityApplePie.Value * PriceApplePie
        itemcost(1) = QuantityBeefBurger.Value * PriceBeefBurger
        itemcost(2) = QuantityCannedDrinks.Value * PriceCannedDrinks
        itemcost(3) = QuantityChickenBurger.Value * PriceChickenBurger
        itemcost(4) = QuantityChickenRice.Value * PriceChickenRice
        itemcost(5) = QuantityChocolateCake.Value * PriceChocalateCake
        itemcost(6) = QuantityFriedNoodles.Value * PriceFriedNoodles
        itemcost(7) = QuantityFriedRice.Value * PriceFriedRice
        itemcost(8) = QuantityIceCream.Value * PriceIceCream
        itemcost(9) = QuantityLemonade.Value * PriceLemonade
        itemcost(10) = QuantityMilo.Value * PriceMilo
        itemcost(11) = QuantityMineral.Value * PriceMineralWater
        itemcost(12) = QuantityPizza.Value * PricePizza
        itemcost(13) = QuantityRotiCanai.Value * PriceRotiCanai
        itemcost(14) = QuantitySandwich.Value * PriceSandwich
        itemcost(15) = QuantityShake.Value * PriceShake
        itemcost(16) = QuantityShavedIce.Value * PriceShavedIce
        itemcost(17) = QuantityShepardpie.Value * PriceShepardPie
        itemcost(18) = QuantitySirap.Value * PriceSirap
        itemcost(19) = QuantitySoupNoodles.Value * PriceSoupNoodles
        itemcost(20) = QuantitySpaghetti.Value * PriceSpaghetti
        itemcost(21) = QuantityStrawberryCake.Value * PriceStrawberry
        itemcost(22) = QuantityToast.Value * PriceToast
        itemcost(23) = QuantityVanillaCake.Value * PriceVanillaCake



        If QuantityApplePie.Enabled = True And QuantityApplePie.Value = 0 Then
            cbxApplePie.Checked = False
        End If

        If QuantityBeefBurger.Enabled = True And QuantityBeefBurger.Value = 0 Then
            cbxBeefBurger.Checked = False
        End If

        If QuantityCannedDrinks.Enabled = True And QuantityCannedDrinks.Value = 0 Then
            cbxCannedDrinks.Checked = False
        End If

        If QuantityChickenBurger.Enabled = True And QuantityChickenBurger.Value = 0 Then
            cbxChickenBurger.Checked = False
        End If

        If QuantityChickenRice.Enabled = True And QuantityChickenRice.Value = 0 Then
            cbxChickenRice.Checked = False
        End If

        If QuantityChocolateCake.Enabled = True And QuantityChocolateCake.Value = 0 Then
            cbxChocolateCake.Checked = False
        End If

        If QuantityFriedNoodles.Enabled = True And QuantityFriedNoodles.Value = 0 Then
            cbxFriedNoodles.Checked = False
        End If

        If QuantityFriedRice.Enabled = True And QuantityFriedRice.Value = 0 Then
            cbxFriedRice.Checked = False
        End If

        If QuantityIceCream.Enabled = True And QuantityIceCream.Value = 0 Then
            cbxIceCream.Checked = False
        End If

        If QuantityLemonade.Enabled = True And QuantityLemonade.Value = 0 Then
            cbxLemonade.Checked = False
        End If

        If QuantityMilo.Enabled = True And QuantityMilo.Value = 0 Then
            cbxMilo.Checked = False
        End If

        If QuantityMineral.Enabled = True And QuantityMineral.Value = 0 Then
            cbxMineralWater.Checked = False
        End If

        If QuantityPizza.Enabled = True And QuantityPizza.Value = 0 Then
            cbxPizza.Checked = False
        End If

        If QuantityRotiCanai.Enabled = True And QuantityRotiCanai.Value = 0 Then
            cbxRotiCanai.Checked = False
        End If

        If QuantitySandwich.Enabled = True And QuantitySandwich.Value = 0 Then
            cbxSandwich.Checked = False
        End If

        If QuantityShake.Enabled = True And QuantityShake.Value = 0 Then
            cbxShake.Checked = False
        End If

        If QuantityShavedIce.Enabled = True And QuantityShavedIce.Value = 0 Then
            cbxShavedIce.Checked = False
        End If

        If QuantityShepardpie.Enabled = True And QuantityShepardpie.Value = 0 Then
            cbxShepardpie.Checked = False
        End If

        If QuantitySirap.Enabled = True And QuantitySirap.Value = 0 Then
            cbxSirap.Checked = False
        End If

        If QuantitySoupNoodles.Enabled = True And QuantitySoupNoodles.Value = 0 Then
            cbxSoupNoodles.Checked = False
        End If

        If QuantitySpaghetti.Enabled = True And QuantitySpaghetti.Value = 0 Then
            cbxSpaghetti.Checked = False
        End If

        If QuantityStrawberryCake.Enabled = True And QuantityStrawberryCake.Value = 0 Then
            cbxStrawberry.Checked = False
        End If

        If QuantityToast.Enabled = True And QuantityToast.Value = 0 Then
            cbxToast.Checked = False
        End If

        If QuantityVanillaCake.Enabled = True And QuantityVanillaCake.Value = 0 Then
            cbxVanillaCake.Checked = False
        End If




        For Each cbx In {cbxApplePie, cbxBeefBurger, cbxCannedDrinks, cbxChickenBurger, cbxChickenRice, cbxChocolateCake, cbxFriedNoodles,
            cbxFriedRice, cbxIceCream, cbxLemonade, cbxMilo, cbxMineralWater, cbxPizza, cbxRotiCanai, cbxSandwich, cbxShake, cbxShavedIce, cbxShepardpie,
            cbxSirap, cbxSoupNoodles, cbxSpaghetti, cbxStrawberry, cbxToast, cbxVanillaCake}

            If cbx.Checked = True Then
                lbxFoodSelected.Items.Add(cbx.Text)


            End If
        Next


        For Each Amount In {QuantityApplePie, QuantityBeefBurger, QuantityCannedDrinks, QuantityChickenBurger, QuantityChickenRice, QuantityChocolateCake,
            QuantityFriedNoodles, QuantityFriedRice, QuantityIceCream, QuantityLemonade, QuantityMilo, QuantityMineral, QuantityPizza, QuantityRotiCanai,
            QuantitySandwich, QuantityShake, QuantityShavedIce, QuantityShepardpie, QuantitySirap, QuantitySoupNoodles, QuantitySpaghetti, QuantityStrawberryCake,
            QuantityToast, QuantityVanillaCake}

            If Amount.Enabled = True Then
                lbxQuantity.Items.Add(Amount.Value)

            End If
        Next

        For Each Price In {itemcost(0), itemcost(1), itemcost(2), itemcost(3), itemcost(4), itemcost(5), itemcost(6), itemcost(7), itemcost(8), itemcost(9), itemcost(10), itemcost(11), itemcost(12), itemcost(13), itemcost(14), itemcost(15), itemcost(16), itemcost(17), itemcost(18), itemcost(19), itemcost(20), itemcost(21), itemcost(22), itemcost(23)}
            If Price <> 0 Then

                lbxPrice.Items.Add(Price.ToString("F2"))

            End If


        Next

    End Sub


    Sub Clear()
        For Each cbx In {cbxApplePie, cbxBeefBurger, cbxCannedDrinks, cbxChickenBurger, cbxChickenRice, cbxChocolateCake, cbxFriedNoodles,
           cbxFriedRice, cbxIceCream, cbxLemonade, cbxMilo, cbxMineralWater, cbxPizza, cbxRotiCanai, cbxSandwich, cbxShake, cbxShavedIce, cbxShepardpie,
           cbxSirap, cbxSoupNoodles, cbxSpaghetti, cbxStrawberry, cbxToast, cbxVanillaCake}
            cbx.Checked = False

            lblSubTotal.Text = "Subtotal : RM0"
            lblTax.Text = "Tax (6%) : RM0"
            lbltotal.Text = "Total Payment : RM0"

            txtCustomerID.SelectedIndex = -1

        Next
    End Sub

    Private Sub btnMainMenu_Click_1(sender As Object, e As EventArgs)
        FrmMainMenu.StartPosition = FormStartPosition.Manual
        FrmMainMenu.Location = Me.Location
        FrmMainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        FrmRegister.StartPosition = FormStartPosition.Manual
        FrmRegister.Location = Me.Location
        FrmRegister.Show()
        Me.Hide()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        FrmRegisterStaff.StartPosition = FormStartPosition.Manual
        FrmRegisterStaff.Location = Me.Location
        FrmRegisterStaff.Show()
        Me.Hide()
    End Sub
    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs)
        FrmLogin.StartPosition = FormStartPosition.Manual
        FrmLogin.Location = Me.Location
        FrmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub cbxFriedRice_CheckedChanged(sender As Object, e As EventArgs) Handles cbxFriedRice.CheckedChanged
        If cbxFriedRice.Checked = True Then
            QuantityFriedRice.Enabled = True
        Else
            QuantityFriedRice.Enabled = False
            QuantityFriedRice.Value = 0

        End If
    End Sub

    Private Sub cbxChickenRice_CheckedChanged(sender As Object, e As EventArgs) Handles cbxChickenRice.CheckedChanged
        If cbxChickenRice.Checked = True Then
            QuantityChickenRice.Enabled = True
        Else
            QuantityChickenRice.Enabled = False
            QuantityChickenRice.Value = 0
        End If

    End Sub

    Private Sub cbxFriedNoodles_CheckedChanged(sender As Object, e As EventArgs) Handles cbxFriedNoodles.CheckedChanged
        If cbxFriedNoodles.Checked = True Then
            QuantityFriedNoodles.Enabled = True
        Else
            QuantityFriedNoodles.Enabled = False
            QuantityFriedNoodles.Value = 0
        End If
    End Sub

    Private Sub cbxSoupNoodles_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSoupNoodles.CheckedChanged
        If cbxSoupNoodles.Checked = True Then
            QuantitySoupNoodles.Enabled = True
        Else
            QuantitySoupNoodles.Enabled = False
            QuantitySoupNoodles.Value = 0
        End If
    End Sub

    Private Sub cbxChickenBurger_CheckedChanged(sender As Object, e As EventArgs) Handles cbxChickenBurger.CheckedChanged
        If cbxChickenBurger.Checked = True Then
            QuantityChickenBurger.Enabled = True
        Else
            QuantityChickenBurger.Enabled = False
            QuantityChickenBurger.Value = 0
        End If
    End Sub

    Private Sub cbxShepardpie_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShepardpie.CheckedChanged
        If cbxShepardpie.Checked = True Then
            QuantityShepardpie.Enabled = True
        Else
            QuantityShepardpie.Enabled = False
            QuantityShepardpie.Value = 0
        End If
    End Sub

    Private Sub cbxBeefBurger_CheckedChanged(sender As Object, e As EventArgs) Handles cbxBeefBurger.CheckedChanged
        If cbxBeefBurger.Checked = True Then
            QuantityBeefBurger.Enabled = True
        Else
            QuantityBeefBurger.Enabled = False
            QuantityBeefBurger.Value = 0
        End If
    End Sub

    Private Sub cbxSandwich_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSandwich.CheckedChanged
        If cbxSandwich.Checked = True Then
            QuantitySandwich.Enabled = True
        Else
            QuantitySandwich.Enabled = False
            QuantitySandwich.Value = 0
        End If
    End Sub

    Private Sub cbxPizza_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPizza.CheckedChanged
        If cbxPizza.Checked = True Then
            QuantityPizza.Enabled = True
        Else
            QuantityPizza.Enabled = False
            QuantityPizza.Value = 0
        End If
    End Sub

    Private Sub cbxRotiCanai_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRotiCanai.CheckedChanged
        If cbxRotiCanai.Checked = True Then
            QuantityRotiCanai.Enabled = True
        Else
            QuantityRotiCanai.Enabled = False
            QuantityRotiCanai.Value = 0
        End If
    End Sub

    Private Sub cbxSpaghetti_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSpaghetti.CheckedChanged
        If cbxSpaghetti.Checked = True Then
            QuantitySpaghetti.Enabled = True
        Else
            QuantitySpaghetti.Enabled = False
            QuantitySpaghetti.Value = 0
        End If
    End Sub

    Private Sub cbxToast_CheckedChanged(sender As Object, e As EventArgs) Handles cbxToast.CheckedChanged
        If cbxToast.Checked = True Then
            QuantityToast.Enabled = True
        Else
            QuantityToast.Enabled = False
            QuantityToast.Value = 0
        End If
    End Sub

    Private Sub cbxMineralWater_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMineralWater.CheckedChanged
        If cbxMineralWater.Checked = True Then
            QuantityMineral.Enabled = True
        Else
            QuantityMineral.Enabled = False
            QuantityMineral.Value = 0
        End If
    End Sub

    Private Sub cbxSirap_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSirap.CheckedChanged
        If cbxSirap.Checked = True Then
            QuantitySirap.Enabled = True
        Else
            QuantitySirap.Enabled = False
            QuantitySirap.Value = 0
        End If
    End Sub

    Private Sub cbxLemonade_CheckedChanged(sender As Object, e As EventArgs) Handles cbxLemonade.CheckedChanged
        If cbxLemonade.Checked = True Then
            QuantityLemonade.Enabled = True
        Else
            QuantityLemonade.Enabled = False
            QuantityLemonade.Value = 0
        End If
    End Sub

    Private Sub cbxCannedDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCannedDrinks.CheckedChanged
        If cbxCannedDrinks.Checked = True Then
            QuantityCannedDrinks.Enabled = True
        Else
            QuantityCannedDrinks.Enabled = False
            QuantityCannedDrinks.Value = 0
        End If
    End Sub

    Private Sub cbxMilo_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMilo.CheckedChanged
        If cbxMilo.Checked = True Then
            QuantityMilo.Enabled = True
        Else
            QuantityMilo.Enabled = False
            QuantityMilo.Value = 0
        End If
    End Sub

    Private Sub cbxShake_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShake.CheckedChanged
        If cbxShake.Checked = True Then
            QuantityShake.Enabled = True
        Else
            QuantityShake.Enabled = False
            QuantityShake.Value = 0
        End If
    End Sub

    Private Sub cbxChocolateCake_CheckedChanged(sender As Object, e As EventArgs) Handles cbxChocolateCake.CheckedChanged
        If cbxChocolateCake.Checked = True Then
            QuantityChocolateCake.Enabled = True
        Else
            QuantityChocolateCake.Enabled = False
            QuantityChocolateCake.Value = 0
        End If
    End Sub

    Private Sub cbxVanillaCake_CheckedChanged(sender As Object, e As EventArgs) Handles cbxVanillaCake.CheckedChanged
        If cbxVanillaCake.Checked = True Then
            QuantityVanillaCake.Enabled = True
        Else
            QuantityVanillaCake.Enabled = False
            QuantityVanillaCake.Value = 0
        End If
    End Sub

    Private Sub cbxStrawberry_CheckedChanged(sender As Object, e As EventArgs) Handles cbxStrawberry.CheckedChanged
        If cbxStrawberry.Checked = True Then
            QuantityStrawberryCake.Enabled = True
        Else
            QuantityStrawberryCake.Enabled = False
            QuantityStrawberryCake.Value = 0
        End If
    End Sub

    Private Sub cbxIceCream_CheckedChanged(sender As Object, e As EventArgs) Handles cbxIceCream.CheckedChanged
        If cbxIceCream.Checked = True Then
            QuantityIceCream.Enabled = True
        Else
            QuantityIceCream.Enabled = False
            QuantityIceCream.Value = 0
        End If
    End Sub

    Private Sub cbxShavedIce_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShavedIce.CheckedChanged
        If cbxShavedIce.Checked = True Then
            QuantityShavedIce.Enabled = True
        Else
            QuantityShavedIce.Enabled = False
            QuantityShavedIce.Value = 0
        End If
    End Sub

    Private Sub cbxApplePie_CheckedChanged(sender As Object, e As EventArgs) Handles cbxApplePie.CheckedChanged
        If cbxApplePie.Checked = True Then
            QuantityApplePie.Enabled = True
        Else
            QuantityApplePie.Enabled = False
            QuantityApplePie.Value = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calculate()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCheckItems.Click 'Check Items
        PanelCheckItems.Visible = True
        Panel5.Visible = False
        PanelCheckItems.Location = New Point(305, 14)
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        PanelCustomerNumber.Visible = False
        btnCloseItemPanel.Text = "Close"
        CheckItems()

    End Sub

    Private Sub btnCloseItemPanel_Click(sender As Object, e As EventArgs) Handles btnCloseItemPanel.Click 'Close Panel
        PanelCheckItems.Visible = False
        Panel5.Visible = True
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        PanelCustomerNumber.Visible = True
        PanelPayment.Visible = False
    End Sub

    Private Sub btnPayment_Click_1(sender As Object, e As EventArgs) Handles btnPayment.Click 'Payment Button
        error1 = 0

        CheckItems()

        If lbxFoodSelected.Items.Count = 0 Then
            MessageBox.Show("No Food Selected")
            error1 += 1
        End If

        If txtCustomerID.Text = "" Or txtCustomerID.Text = "CT" Then
            MessageBox.Show("Please insert Customer ID")
            error1 += 1
        End If

        If txtOrderID.Text = "" Or txtOrderID.Text = "OD" Then
            MessageBox.Show("Please insert Order ID")
            error1 += 1
        End If


        If error1 = False Then
            PanelCheckItems.Visible = True
            PanelPayment.Visible = True
            Panel5.Visible = False
            PanelCustomerNumber.Visible = False
            PanelCheckItems.Location = New Point(158, 52)
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            btnCloseItemPanel.Text = "Back"
            btnConfrim.Enabled = False

            Calculate()
        End If

    End Sub

    Dim CustomerPay As Double
    Private Sub btnBalane_Click(sender As Object, e As EventArgs) Handles btnBalance.Click  'Balance Button


        If txtCustPays.Text = vbNullString Then
            CustomerPay = 0
        Else
            CustomerPay = txtCustPays.Text
        End If


        If txtCustPays.Text = "" Then
            MessageBox.Show("Customer Payment cannot be empty")
            txtCustPays.Clear()
            txtCustPays.Focus()
            txtCustomerPaymentAmount.Clear()
        ElseIf CustomerPay < Total Then
            MessageBox.Show("Customer Payment is not sufficient")
            txtCustPays.Clear()
            txtCustPays.Focus()
            txtCustomerPaymentAmount.Clear()
        Else
            lblBalance.Text = "Balance : RM" & (CustomerPay - Total).ToString("F2")

        End If

        If lblBalance.Text = "Balance : RM" Or txtCustPays.Text = "0.00" Or txtCustPays.Text = "" Then
            MessageBox.Show("Customer Payment cannot be empty")
            btnConfrim.Enabled = False
        Else

            btnConfrim.Enabled = True
        End If


    End Sub
    Public staffID, orderDate, orderID2 As String

    Private Sub btnRM50_Click(sender As Object, e As EventArgs) Handles btnRM50.Click



        CustomerPay = CustomerPay + 50
            txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")


        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRM20.Click


        CustomerPay = CustomerPay + 20
            txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")


        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub btnRM10_Click(sender As Object, e As EventArgs) Handles btnRM10.Click


        CustomerPay = CustomerPay + 10
        txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")


        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub btnRM5_Click(sender As Object, e As EventArgs) Handles btnRM5.Click


        CustomerPay = CustomerPay + 5
            txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")


        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        Else

        End If
    End Sub

    Private Sub btnRM1_Click(sender As Object, e As EventArgs) Handles btnRM1.Click


        CustomerPay = CustomerPay + 1
            txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")


        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub btn50sen_Click(sender As Object, e As EventArgs) Handles btn50sen.Click


        CustomerPay = CustomerPay + 0.5
            txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")


        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub btn20sen_Click(sender As Object, e As EventArgs) Handles btn20sen.Click


        CustomerPay = CustomerPay + 0.2
            txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")



        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub btn10sen_Click(sender As Object, e As EventArgs) Handles btn10sen.Click


        CustomerPay = CustomerPay + 0.1
        txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")



        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub



    Private Sub btn5sen_Click(sender As Object, e As EventArgs) Handles btn5sen.Click


        CustomerPay = CustomerPay + 0.05
        txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")


        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub btnCustomerPaymentClear_Click(sender As Object, e As EventArgs) Handles btnCustomerPaymentClear.Click
        CustomerPay = 0
        txtCustomerPaymentAmount.Text = CustomerPay
    End Sub

    Private Sub btnCustomerPaymentClose_Click(sender As Object, e As EventArgs) Handles btnCustomerPaymentClose.Click
        pnlCustomerPayment.Visible = False
        txtCustPays.Text = CustomerPay.ToString("F2")
        btnConfrim.Visible = True
    End Sub


    Private Sub btnCustomerPayment_Click(sender As Object, e As EventArgs) Handles btnCustomerPayment.Click
        pnlCustomerPayment.Visible = True
        txtCustPays.Text = CustomerPay.ToString("F2")
        btnConfrim.Visible = False
    End Sub

    Private Sub btnRM100_Click(sender As Object, e As EventArgs) Handles btnRM100.Click

        CustomerPay = CustomerPay + 100
        txtCustomerPaymentAmount.Text = CustomerPay.ToString("F2")

        If CustomerPay < 0 Then
            MessageBox.Show("Error, value can't be negative")
            CustomerPay = 0
        End If
    End Sub

    Private Sub btnConfrim_Click(sender As Object, e As EventArgs) Handles btnConfrim.Click
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String

        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet


        dbProvider = "Provider = Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data source = VBNFoodSystemDB.mdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()
        'MessageBox.Show("Connection opened.")

        sql = "SELECT * FROM ORDER_T"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "orderList")

        Dim cb As New OleDb.OleDbCommandBuilder(da)

        Dim dsNewRow As DataRow

        If MessageBox.Show("Confirm Order?", "Order Confirmation",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Status Cancelled")
            Exit Sub
        End If

        For Item As Integer = 0 To Me.lbxFoodSelected.Items.Count - 1

            dsNewRow = ds.Tables("orderList").NewRow()
            dsNewRow.Item(0) = txtOrderID.Text
            dsNewRow.Item(1) = lbxFoodSelected.Items(Item)
            dsNewRow.Item(2) = lbxQuantity.Items(Item)
            dsNewRow.Item(3) = lbxPrice.Items(Item)
            dsNewRow.Item(4) = SubTotal.ToString("F2")
            dsNewRow.Item(5) = AfterTax.ToString("F2")
            dsNewRow.Item(6) = Total.ToString("F2")
            dsNewRow.Item(7) = CustomerPay.ToString("F2")
            dsNewRow.Item(8) = (CustomerPay - Total).ToString("F2")
            dsNewRow.Item(9) = txtCustomerID.Text
            dsNewRow.Item(10) = staffID
            dsNewRow.Item(12) = FrmMainMenu.lblDate.Text

            ds.Tables("orderList").Rows.Add(dsNewRow)

        Next
        orderID2 = txtOrderID.Text

        da.Update(ds, "orderList")

        con.Close()
        'MessageBox.Show("Connection closed.")

        Dim da2 As OleDb.OleDbDataAdapter
        Dim ds2 As New DataSet
        Dim sql2 As String

        Dim ones, tens, hundreds, thousands As Integer
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
        txtOrderID.Text = Final
        Final = "OD0000"
        ones = 0
        tens = 0
        hundreds = 0
        thousands = 0

        Final = "OD0000"

        FrmReceipt.Show()
        FrmReservation.Hide()
        FrmRegisterStaff.Hide()
        FrmRegister.Hide()

        PanelCheckItems.Visible = False
        Panel5.Visible = True
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        PanelCustomerNumber.Visible = True
        PanelPayment.Visible = False
        txtCustPays.Text = ""
        CustomerPay = 0

        totalRecords = (ds.Tables("ORDERList").Rows.Count)
        orderID = ds.Tables("ORDERList").Rows(totalRecords - 1).Item(0)
        lblPrompt.Text = "Please Use No. above " & orderID

        Clear()

    End Sub


End Class