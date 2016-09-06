' Joshua Pickenpaugh
' September 6th, 2016
' "Marcy's Department Store", CPT 432

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares the variables:
        Dim decFirstItem As Decimal
        Dim decSecondItem As Decimal
        Dim decTotal As Decimal

        'Assigns the variables to text boxes:
        Decimal.TryParse(txtFirstItem.Text, decFirstItem)
        Decimal.TryParse(txtSecondItem.Text, decSecondItem)

        'Calculates:
        If (decFirstItem > decSecondItem) Then
            decSecondItem = decSecondItem / 2
            decTotal = decFirstItem + decSecondItem
        ElseIf (decFirstItem < decSecondItem) Then
            decFirstItem = decFirstItem / 2
            decTotal = decFirstItem + decSecondItem
        End If

        lblTotal.Text = decTotal.ToString("C2")

    End Sub
End Class
