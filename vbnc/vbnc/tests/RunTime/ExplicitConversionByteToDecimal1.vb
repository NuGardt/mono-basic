Module ExplicitConversionByteToDecimal1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Byte
        Dim value2 As Decimal
        Dim const2 As Decimal

        value1 = CByte(10)
        value2 = CDec(value1)
        const2 = CDec(CByte(10))

        result = value2 = const2

        If result = False Then
            System.Console.WriteLine("FAIL ExplicitConversionByteToDecimal1")
            Return 1
        End If
    End Function
End Module
