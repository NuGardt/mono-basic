'Author:
'   V. Sudharsan (vsudharsan@novell.com)
'
' (C) 2005 Novell, Inc.

Module ExpConversionBytetoLongA
    Function Main() As Integer
        Dim a As Byte = 123
        Dim b As Long
        b = CLng(a)
        If b <> 123 Then
            System.Console.WriteLine("Byte to Long Conversion is not working properly. Expected 123 but got " & b) : Return 1
        End If
    End Function
End Module
