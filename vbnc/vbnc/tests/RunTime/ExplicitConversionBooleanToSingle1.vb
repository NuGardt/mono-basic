Module ExplicitConversionBooleanToSingle1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Boolean
        Dim value2 As Single
        Dim const2 As Single

        value1 = True
        value2 = CSng(value1)
        const2 = CSng(True)

        result = value2 = const2

        If result = False Then
            System.Console.WriteLine("FAIL ExplicitConversionBooleanToSingle1")
            Return 1
        End If
    End Function
End Module
