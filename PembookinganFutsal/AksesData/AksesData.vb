Imports MySql.Data.MySqlClient
Namespace AksesData
    Public Class DataControl
        Private myconnection As New AksesData.KoneksiDB
        Public Function GetDataSet(ByVal SQL As String) As DataSet
            Dim adapter As New MySqlDataAdapter(SQL, myconnection.open)
            Dim myData As New DataSet
            Adapter.Fill(myData, "Data")
            Return myData
        End Function
    End Class
End Namespace