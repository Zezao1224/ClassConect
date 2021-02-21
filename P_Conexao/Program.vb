Imports System
Imports System.Data
Module Program
    Sub Main(args As String())
        Dim table As New DataTable
        Dim dtr As DataRow()
        Dim txt As String = ""
        Console.WriteLine("Hello World!")
        Dim conect = New Conect()
        If conect.Conect() = True Then
            table = conect.Tabela()
            dtr = table.Select()
            For j As Integer = 0 To table.Columns.Count() - 1
                txt = txt & "|" & table.Columns(j).ToString()
            Next
            Console.WriteLine(txt)
            txt = ""
            'coluna'
            For j As Integer = 0 To dtr.Length() - 1
                'linha'
                For i As Integer = 0 To dtr(0).ItemArray.Length() - 1
                    txt = txt & "|" & dtr(j).ItemArray(i)
                Next
                Console.WriteLine(txt)
                txt = ""
            Next
        Else
            Console.WriteLine()
        End If
    End Sub
End Module
