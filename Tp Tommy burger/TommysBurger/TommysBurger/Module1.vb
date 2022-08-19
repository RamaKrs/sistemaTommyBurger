Imports System.Data.Odbc

Module Module1

    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rs1 As OdbcDataReader
    Public dni As Integer
    Public Flag As Integer
    Public sql As String


    Public Function conectar()
        Flag = 0
        Try

            cnn = New OdbcConnection("DSN=Hamburgueseria")
            cnn.Open()
            MsgBox("Conexión exitosa", , "Estado")

        Catch ex As Exception


            MsgBox("Conexión Fallida" & vbNewLine & ex.ToString(), , "Estado")

        End Try

        Return 0
    End Function

    Public Sub Proc(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        If Flag = 0 Then
            rs = cmd.ExecuteReader()
            Flag = 1
        Else
            rs1 = cmd.ExecuteReader()
        End If

        cmd.Dispose()
    End Sub
End Module



