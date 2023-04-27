Imports Microsoft.Data.SqlClient
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
    Public Function EditAccount(ByVal AccID1 As Integer, ByVal AccNm As String, ByVal Img2Byte As Byte()) As Integer
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Using Con As SqlConnection = New SqlConnection(connectionString),
            SqlCommand As SqlCommand = New SqlCommand("UpdateAccByID", Con) With {.CommandType = CommandType.StoredProcedure}
            Dim Dt1 As Date = Now.Date
            With SqlCommand.Parameters
                .Add(New SqlParameter("@AccID", AccID1))
                .Add(New SqlParameter("@AccIco1", Img2Byte))
                .Add(New SqlParameter("@Dt1", Now.Date))
                .Add(New SqlParameter("@AccNm1", AccNm))
            End With
            Con.Open()
            Return SqlCommand.ExecuteNonQuery()
        End Using
    End Function
    Public Function DelAccount(ByVal ThisAccID As Integer, ByVal AccNm As String, ByVal Img2Byte As Byte()) As Integer
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Dim Tra As SqlTransaction = Nothing
        Dim N As Integer
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Con.Open()
                Tra = Con.BeginTransaction(IsolationLevel.ReadCommitted)
                Dim SqlCommand As SqlCommand = New SqlCommand("DelFrmAccByID", Con, Tra) With {.CommandType = CommandType.StoredProcedure}
                With SqlCommand.Parameters
                    .Add(New SqlParameter("@AccID1", ThisAccID))
                End With
                N = Convert.ToInt32(SqlCommand.ExecuteNonQuery())
                SqlCommand = New SqlCommand("DelFrmLogByID", Con, Tra) With {.CommandType = CommandType.StoredProcedure}
                With SqlCommand.Parameters
                    .Add(New SqlParameter("@AccID1", ThisAccID))
                End With
                N += Convert.ToInt32(SqlCommand.ExecuteNonQuery())
                Tra.Commit()
                Return N
            End Using
        Catch ex As SqlException
            Tra.Rollback()
            Return -1
        End Try
    End Function
End Class
