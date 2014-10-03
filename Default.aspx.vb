
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim HourlyWage As Decimal = Val(tb_hw.Text)
        Dim NumberHours As Decimal = Val(tb_nh.Text)
        Dim PreTax As Decimal = Val(tb_ptd.Text)
        Dim AfterTax As Decimal = Val(tb_atd.Text)
        Dim TaxDeduction As Decimal
        Dim NetPay As Decimal
        If ((HourlyWage * NumberHours) - PreTax - AfterTax) < 500 Then
            tb_rate.Text = "18%"
            TaxDeduction = (((HourlyWage * NumberHours) - PreTax) * 0.18)
            NetPay = ((((HourlyWage * NumberHours) - PreTax) - TaxDeduction) - AfterTax)
            tb_np.Text = NetPay.ToString("C2")
        ElseIf ((HourlyWage * NumberHours) - PreTax - AfterTax) >= 500 Then
            tb_rate.Text = "22%"
            TaxDeduction = (((HourlyWage * NumberHours) - PreTax) * 0.22)
            NetPay = ((((HourlyWage * NumberHours) - PreTax) - TaxDeduction) - AfterTax)
            tb_np.Text = NetPay.ToString("C2")
        End If
    End Sub

    Protected Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tb_atd.Text = ""
        tb_hw.Text = ""
        tb_nh.Text = ""
        tb_np.Text = ""
        tb_ptd.Text = ""
        tb_rate.Text = ""
    End Sub
End Class
