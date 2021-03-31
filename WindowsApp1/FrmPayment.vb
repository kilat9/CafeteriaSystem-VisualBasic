Public Class FrmPayment
    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Timer1.Interval = 1000 'Timer for the date 1000 units = 1second irl
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub
End Class