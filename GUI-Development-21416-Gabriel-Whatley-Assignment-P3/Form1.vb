'Name: Gabriel Whatley
'Date : 4/2/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that calculates the price of a catering platter based on user input.
Public Class Form1

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        clear()
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Dim loyalty_points As Decimal
        Dim final_cost As Decimal
        Dim percentage_off As Int16
        Dim price As Decimal

        If String.IsNullOrEmpty(textbox_input.Text) Then ' if no input set loyalty points to 0
            loyalty_points = 0
        ElseIf Decimal.TryParse(textbox_input.Text, loyalty_points) = False Then 'if the str can't be made a short, popup the error message and break.
            MsgBox("The input needs to be a number, please try again", 0, "Error")
            clear()
            Exit Sub '<-- Alternate sub exit point.
        Else
            loyalty_points = Convert.ToDecimal(textbox_input.Text) ' Convert the textbox input to decimal.
        End If

        percentage_off = 5 * Math.Floor(loyalty_points / 10) ' Convert the layalty points into a discount percentage

        Select Case True ' Set the price based on radio button selection
            Case rdio_singl_shrimp.Checked
                price = 49.99
            Case rdio_boyardee.Checked
                price = 59.99
            Case rdio_sushi.Checked
                price = 29.99
            Case rdio_grits.Checked
                price = 49.99
            Case rdio_durian.Checked
                price = 29.99
        End Select

        final_cost = (price / 100) * (100 - percentage_off) ' Calculate the final cost.

        If final_cost <= 0 Then ' If the final cost is 0 or less than 0 tell the customer to not use so many loyalty points.
            MsgBox("Sorry, you can't use that many loyalty points for your order.", 0, "Error")
            clear()
            Exit Sub '<-- Alternate sub exit point.
        End If

        set_output(final_cost)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub set_output(output_dec As Decimal) 'Set the output label using a supplied decimal, if the supplied decimal is 0, clear the output.
        Dim output_str As String
        If output_dec = 0 Then
            output_str = ""
        Else
            output_str = FormatCurrency(output_dec, , , TriState.True, TriState.True)
        End If
        lbl_output.Text = "Please Pay: " + output_str
    End Sub

    Private Sub clear() 'Clear all inputs and reset the form to defaults, focus on input box.
        textbox_input.Clear()
        rdio_singl_shrimp.Select()
        rdio_pre_pay.Select()
        set_output(0)
        textbox_input.Focus()
    End Sub

End Class