Imports System.Data.Odbc
Public Class Lapang
    Const DSN_ODBC = "DSN=bookingfutsal1"
    Dim connection As OdbcConnection
    Dim command As OdbcCommand
    Dim command1 As OdbcCommand
    Dim DA As OdbcDataAdapter
    Dim DS As DataSet
    Dim DR As OdbcDataReader
    Dim table As DataTable

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
        DA = New OdbcDataAdapter("SELECT * from lapang", connection)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "lapang")
        DataGridView1.DataSource = DS.Tables("lapang")
        connection.Close()
    End Sub

    Private Sub Lapang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtNamalapang.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            txtNamalapang.Focus()
        ElseIf (txtHargalapang.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            txtHargalapang.Focus()
        Else
            Try
                koneksi()
                command = New OdbcCommand("insert into lapang values ('', ?, ?)", connection)
                With command
                    .Parameters.AddWithValue("?", txtNamalapang.Text)
                    .Parameters.AddWithValue("?", txtHargalapang.Text)
                    .ExecuteNonQuery()
                End With
                connection.Close()
                isiGrid()
                txtId.Clear()
                txtNamalapang.Clear()
                txtHargalapang.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (txtNamalapang.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            txtNamalapang.Focus()
        ElseIf (txtHargalapang.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            txtHargalapang.Focus()
        Else
            Try
                koneksi()
                command = New OdbcCommand("UPDATE lapang SET nama_lapang = ?, harga_lapang = ? WHERE id_lapang = ?", connection)
                With command
                    .Parameters.AddWithValue("?", txtNamalapang.Text)
                    .Parameters.AddWithValue("?", txtHargalapang.Text)
                    .Parameters.AddWithValue("?", txtId.Text)
                    .ExecuteNonQuery()
                End With
                connection.Close()
                isiGrid()
                txtId.Clear()
                txtNamalapang.Clear()
                txtHargalapang.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.RowCount = 0 Then
            MsgBox("Data Masih Kosong")
        Else
            txtId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value 'TextBox Kode Kategori diisi oleh index 0
            txtNamalapang.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value 'TextBox Kode Kategori diisi oleh index 0
            txtHargalapang.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            koneksi()
            command = New OdbcCommand("DELETE FROM lapang WHERE id_lapang = ?", connection)
            With command
                .Parameters.AddWithValue("?", txtId.Text)
                .ExecuteNonQuery()
            End With
            connection.Close()
            isiGrid()
            txtId.Clear()
            txtNamalapang.Clear()
            txtHargalapang.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class