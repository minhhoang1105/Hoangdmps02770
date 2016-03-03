Imports System.Data.SqlClient

Module HelpVB
    Public ds As New DataSet
    'Public Connectionstring As String = "Data Source=HOANG-PC\SQLEXPRESS;Initial Catalog=hoangdmps02770;Integrated Security=True"
    Public Connectionstring As String = "workstation id=hoangdm.mssql.somee.com;packet size=4096;user id=hoangdmps02770_SQLLogin_1;pwd=yep5tvgnw2;data source=hoangdm.mssql.somee.com;persist security info=False;initial catalog=hoangdm"

    Public Sub ExecuteNonQuery(sql As String)
        Dim Connection As New SqlConnection(Connectionstring)
        Dim Command As New SqlCommand(sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub Connect(sql As String, TableName As String)
        Dim Connection As New SqlConnection(Connectionstring)
        Dim DataAdapter As New SqlDataAdapter(sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
    End Sub
End Module

