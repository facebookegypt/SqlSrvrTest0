Imports Microsoft.Data.SqlClient
Public Class Connection
    Public Sub main()
        ' Create a New SqlConnectionStringBuilder And
        ' initialize it with a few name/value pairs.
        Dim builder As SqlConnectionStringBuilder =
            New SqlConnectionStringBuilder(GetConnectionString())

        ' The input connection string used the 
        ' Server key, but the New connection string uses
        ' the well-known Data Source key instead.
        Debug.WriteLine(builder.ConnectionString)
        ' You can refer to connection keys using strings, 
        ' as well. When you use this technique (the default
        ' Item property in Visual Basic, Or the indexer in C#),
        ' you can specify any synonym for the connection string key
        ' name.
        builder("Server") = "EVRY1FALLS"
        builder("Connect Timeout") = 1000
        builder("Trusted_Connection") = True
        Debug.WriteLine(builder.ConnectionString)

        Debug.WriteLine("Press Enter to finish.")
    End Sub
    Private Function GetConnectionString() As String
        'To avoid storing the connection string in your code,
        'you can retrieve it from a configuration file. 
        Return "Server=EVRY1FALLS;Trusted_Connection=True;" +
            "Initial Catalog=Accounts"
    End Function
End Class
