Imports System.Data.SqlClient
Imports System.Configuration
Public Class Accs
    Public Function AddNewAccount(ByVal AccNm As String, ByVal Img2Byte As Byte()) As Integer
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Using Con As SqlConnection = New SqlConnection(connectionString),
            SqlCommand As SqlCommand = New SqlCommand("SaveAcc", Con) With {.CommandType = CommandType.StoredProcedure}
            Dim Dt1 As Date = Now.Date
            With SqlCommand.Parameters
                .Add(New SqlParameter("@Acc1", AccNm))
                .Add(New SqlParameter("@Acc2", Img2Byte))
                .Add(New SqlParameter("@Acc3", Dt1))
                .Add(New SqlParameter("@Acc4", Dt1))
            End With
            Con.Open()
            Return SqlCommand.ExecuteNonQuery()
        End Using
    End Function
End Class
