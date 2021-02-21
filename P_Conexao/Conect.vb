Imports System.Data
Imports System.Data.OleDb
Public Class Conect
    Dim StrlCaminho As String = "C:\Users\gamer\Documents\Database2.accdb"
    Dim cn As OleDbConnection
    Function Conect()
        Dim Testeconect As Boolean
        cn = New OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA Source=" & StrlCaminho & "")
        Try
            cn.Open()
            Testeconect = True
        Catch ex As Exception
            Console.WriteLine(ex)
            Testeconect = False
        End Try
        Return Testeconect
    End Function
    Function Tabela()
        Dim Table As New DataTable
        Dim Cnm As New OleDbCommand
        Cnm.Connection = cn
        Cnm.CommandText = "SELECT TableSoares.* FROM TableSoares;"
        Dim adptador As New OleDbDataAdapter(Cnm)
        Try
            adptador.Fill(Table)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        cn.Close()
        Return Table
    End Function
End Class
