
' Name:         Jerome
' Purpose:      Displays gross pay
' Programmer:   <Jhonniel Ygay> on <Sep 6,2020>

Option Explicit On
Option Infer Off
Option Strict On



Public Class frmMain


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub txtItemPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemPrice.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtItemPrice_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemPrice.Enter
        txtItemPrice.SelectAll()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private dblItemPrice, dblSubPrice As Double
    Private dblSalesTax, dblShipping, dblTotalDue As Double

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")



        Double.TryParse(txtItemPrice.Text, dblItemPrice)

        dblSubPrice += dblItemPrice

        dblSalesTax = dblSubPrice * 0.05



        If dblSubPrice >= 100 Then

            dblShipping = 0

        Else

            dblShipping = 6.5

        End If
        dblTotalDue = dblSubPrice + dblSalesTax + dblShipping

        lblSub.Text = Format(dblSubPrice, "C2")
        lblSaleTax.Text = Format(dblSalesTax, "C2")
        lblShip.Text = Format(dblShipping, "C2")
        lblTotalDue.Text = Format(dblTotalDue, "C2")


        txtItemPrice.Focus()

    End Sub


    Private Sub txtItemPrice_TextChanged(sender As Object, e As EventArgs) Handles txtItemPrice.TextChanged

    End Sub
End Class
