Module Module1

    Sub Main()

        Dim m As Integer = 8
        Dim max, min As Integer
        Dim cv As Double

        Dim originalList As New List(Of Array)

        originalList.Add({139, 144, 149, 153, 155, 155, 155, 155})
        originalList.Add({144, 151, 153, 156, 159, 156, 156, 156})
        originalList.Add({150, 155, 160, 163, 158, 156, 156, 156})
        originalList.Add({159, 161, 162, 160, 160, 159, 159, 159})
        originalList.Add({159, 160, 161, 162, 162, 155, 155, 155})
        originalList.Add({161, 161, 161, 161, 160, 157, 157, 157})
        originalList.Add({162, 162, 161, 163, 162, 157, 157, 157})
        originalList.Add({162, 162, 161, 161, 163, 158, 158, 158})

        max = originalList.Item(0)(0)
        min = originalList.Item(0)(0)
        For Each temp As Array In originalList
            For Each temp2 As Integer In temp
                If temp2 > max Then max = temp2
                If temp2 < min Then min = temp2
            Next
        Next

        cv = (max - min) / m
        Dim dealList As New List(Of Array)
        Dim bytList As New List(Of Array)
        For Each temp As Array In originalList
            Dim tempArray As New List(Of Integer)
            Dim tempArray2 As New List(Of Integer)
            For Each temp2 As Integer In temp
                For i = 0 To m - 1
                    If temp2 >= (min + i * cv) And temp2 < (min + (i + 1) * cv) Or (i = m - 1 And temp2 = max) Then tempArray.Add(min + (i + 0.5) * cv)
                    If temp2 >= (min + i * cv) And temp2 < (min + (i + 1) * cv) Or (i = m - 1 And temp2 = max) Then tempArray2.Add(i)
                Next
            Next
            dealList.Add(tempArray.ToArray())
            bytList.Add(tempArray2.ToArray())
            tempArray.Clear()
            tempArray2.Clear()
        Next


        Console.Write("Max：" & max & vbNewLine)
        Console.Write("Min：" & min & vbNewLine)
        Console.Write("M：" & m & vbNewLine)
        Console.Write(vbNewLine)
        showList("原始陣列", originalList)
        showList("失真陣列", dealList)
        showList("位元陣列", bytList)


        Console.Write("按任意鍵繼續輸入...")
        Console.Read()

    End Sub

    Sub showList(listName As String, tempList As List(Of Array))
        Console.Write(listName & vbNewLine)
        For Each temp As Array In tempList
            For Each temp2 As Integer In temp
                Console.Write(temp2.ToString & vbTab)
            Next
            Console.Write(vbNewLine)
        Next

        Console.Write(vbNewLine)
        Console.Write(vbNewLine)
    End Sub

End Module
