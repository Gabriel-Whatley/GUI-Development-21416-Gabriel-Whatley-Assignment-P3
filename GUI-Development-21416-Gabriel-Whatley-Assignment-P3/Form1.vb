Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_clear.PerformClick()
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Dim loyalty_points As Decimal




        loyalty_points = Convert.ToDecimal(textbox_input.Text)
        set_output(loyalty_points)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        textbox_input.Clear()
        textbox_input.Focus()
        rdio_singl_shrimp.Select()
        rdio_pre_pay.Select()

    End Sub

    Private Sub set_output(output As Decimal)
        lbl_output.Text = "Please Pay: " + output.ToString
    End Sub

End Class