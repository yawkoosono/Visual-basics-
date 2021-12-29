Module Main
    Public Function FormatZipCode(ByVal zipcode As String) As String

        If zipcode.Length = 9 Then
            Dim str = zipcode.Substring(0, 5) & "-" & zipcode.Substring(5)
            Return str
        Else
            Return zipcode
        End If
    End Function
End Module
