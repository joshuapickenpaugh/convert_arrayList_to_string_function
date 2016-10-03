Public Class NumberClass

    Private _intNum1 As Integer
    Private _intNum2 As Integer

    Public Property Num1 As Integer
        Get
            Return _intNum1
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intNum1 = value
            Else
                _intNum1 = 0
            End If
        End Set
    End Property

    Public Property Num2 As Integer
        Get
            Return _intNum2
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intNum2 = value
            Else
                _intNum2 = 0
            End If
        End Set
    End Property

    Public Sub New()

        _intNum1 = 0
        _intNum2 = 0

    End Sub

    Public Function DisplayResult() As String

        Dim arr As New ArrayList

        For choosenNum As Integer = _intNum1 To _intNum2
            If (choosenNum Mod 2 = 0) Then

                arr.Add(choosenNum)
            End If
        Next

        'Converts the arrayList to a string (function is string type):
        Return Strings.Join(arr.ToArray, ",")

    End Function
End Class
