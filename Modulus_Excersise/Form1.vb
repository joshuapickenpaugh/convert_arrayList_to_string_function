'Joshua Pickenpaugh
'October 3rd, 2016
'Converts arrayList to string.

Public Class frmMain

    Dim numCls As New NumberClass()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Integer.TryParse(txtNum1.Text, numCls.Num1)
        Integer.TryParse(txtNum2.Text, numCls.Num2)

        lblDivByTwo.Text = numCls.DivisibleByTwo()
        lblDivisibleByThree.Text = numCls.DivisibleByThree()
        lblDivisibleByFive.Text = numCls.DivisibleByFive()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblDivByTwo.Text = String.Empty
        lblDivisibleByThree.Text = String.Empty
        lblDivisibleByFive.Text = String.Empty

        numCls.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
