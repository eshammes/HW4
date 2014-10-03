
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim HourlyWage As Decimal = tb_hw.Text
        Dim NumberHours As Decimal = tb_nh.Text
        Dim PreTax As Decimal = tb_ptd.Text
        Dim AfterTax As Decimal = tb_atd.Text
        Dim TaxDeduction As Decimal
        If ((HourlyWage * NumberHours) - PreTax - AfterTax) < 500 Then
            tb_rate.Text = "18%"
            TaxDeduction = (((HourlyWage * NumberHours) - PreTax) * 0.18)
            tb_np.Text = ((((HourlyWage * NumberHours) - PreTax) - TaxDeduction) - AfterTax)
        ElseIf ((HourlyWage * NumberHours) - PreTax - AfterTax) >= 500 Then
            tb_rate.Text = "22%"
            TaxDeduction = (((HourlyWage * NumberHours) - PreTax) * 0.22)
            tb_np.Text = ((((HourlyWage * NumberHours) - PreTax) - TaxDeduction) - AfterTax)
        End If
    End Sub
End Class
