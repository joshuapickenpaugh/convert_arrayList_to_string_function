'Joshua Pickenpaugh
'October 3rd, 2016
'Converts arrayList to string.

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numCls As New NumberClass()

        Integer.TryParse(txtNum1.Text, numCls.Num1)
        Integer.TryParse(txtNum2.Text, numCls.Num2)

        lblTotal.Text = numCls.DisplayResult()
    End Sub
End Class
