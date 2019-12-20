Imports System.Data.Odbc
Public Class FormUtama
    Public idadmin As String
    Dim namaadmin As String
    Dim leveladmin As String
    Const DSN_ODBC = "DSN=bookingfutsal1"
    Dim connection As OdbcConnection
    Dim command As OdbcCommand
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

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        FormLogin.Close()
        Close()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Booking.idadmin = idadmin
        Booking.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Dim StrSQL As String = "SELECT nama_admin, level FROM admin where id_admin ='" + idadmin + "'"
        command = New OdbcCommand(StrSQL, connection)
        DR = command.ExecuteReader
        DR.Read()
        namaadmin = DR("nama_admin")
        leveladmin = DR("level")
        MsgBox("Selamat datang " + namaadmin)
        If leveladmin = "admin" Then
            LaporanToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub CekLapangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CekLapangToolStripMenuItem.Click
        CancelBooking.Show()
    End Sub

    Private Sub HarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HarianToolStripMenuItem.Click
        Dim tipe As String = "HARIAN"
        Laporan.Label2.Text = tipe
        Laporan.txtTipe.Text = tipe
        Laporan.Show()
    End Sub

    Private Sub BulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulananToolStripMenuItem.Click
        Dim tipe As String = "BULANAN"
        Laporan.Label2.Text = tipe
        Laporan.txtTipe.Text = tipe
        Laporan.Show()
    End Sub

    Private Sub TahunanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TahunanToolStripMenuItem.Click
        Dim tipe As String = "SEMUA"
        Laporan.Label2.Text = tipe
        Laporan.txtTipe.Text = tipe
        Laporan.Show()
    End Sub

    Private Sub KelolaLapangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelolaLapangToolStripMenuItem.Click
        Lapang.Show()
    End Sub
End Class