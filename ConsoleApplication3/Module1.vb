Module Module1

    Sub Main()
        Console.WriteLine("請輸入數字")
        Dim size As Integer = Val(Console.ReadLine())
        Dim i As Integer = 0
        Dim numberArry(size) As Integer

        Do
            numberArry(i) = Val(Console.ReadLine())
            i = i + 1
        Loop While (i < size)

        Console.WriteLine("max={0}", Getmax(numberArry))
        Console.WriteLine("min={0}", Getmin(numberArry))

        For j As Integer = 0 To UBound(numberArry)
            Console.Write(numberArry(j).ToString() + " ")
        Next

        For b As Integer = 1 To LBound(numberArry)
            Console.Write(numberArry(b).ToString() + " ")
        Next
        Console.ReadLine()
    End Sub
    Private Function Getmax(ByVal ParamArray x() As Integer) As Integer
        Dim max As Integer = x(0)
        For i As Integer = 0 To UBound(x)
            If (x(i) > max) Then
                max = x(i)
            End If
        Next
        Return max
    End Function
    Private Function Getmin(ByVal ParamArray x() As Integer) As Integer
        Dim min As Integer = x(0)
        For i As Integer = 1 To LBound(x)
            If (x(i) < min) Then
                min = x(i)
            End If
        Next
        Return min
    End Function
End Module
