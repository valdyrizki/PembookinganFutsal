Imports System.Data.Odbc
Public Class CancelBooking
    Const DSN_ODBC = "DSN=bookingfutsal1"
    Dim connection As OdbcConnection
    Dim command As OdbcCommand
    Dim DA As OdbcDataAdapter
    Dim DS As DataSet
    Dim DR As OdbcDataReader
    Sub koneksi()
        connection = New OdbcConnection(DSN_ODBC)
        Try
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub isiGrid()
        koneksi()
        DA = New OdbcDataAdapter("SELECT * from booking ", connection)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "booking")
        DataGridView1.DataSource = DS.Tables("booking")
        DataGridView1.ReadOnly = True
        connection.Close()
    End Sub

    Private Sub CancelBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If MsgBox("Apakah data ini akan dihapus", MsgBoxStyle.YesNo, "Warning!") = MsgBoxResult.Yes Then
            koneksi()
            Dim id As String
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            command = New OdbcCommand("DELETE FROM booking WHERE no_booking = ?", connection)
            With command
                .Parameters.AddWithValue("?", id)
                .ExecuteNonQuery()
            End With
            connection.Close()
            isiGrid()
        Else
        End If
    End Sub
End Class