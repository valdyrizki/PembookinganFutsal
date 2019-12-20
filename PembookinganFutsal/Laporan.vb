Imports System.Data.Odbc
Public Class Laporan
    Dim tipe As String
    Const DSN_ODBC = "DSN=bookingfutsal1"
    Dim connection As OdbcConnection
    Dim command As OdbcCommand
    Dim command1 As OdbcCommand
    Dim DA As OdbcDataAdapter
    Dim DS As DataSet
    Dim DR As OdbcDataReader
    Dim table As DataTable
    Dim tgl As String = Format(Now, "yyyy-MM-dd")
    Dim bulan As String = Format(Now, "MM")
    Private bitmap As Bitmap

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
        If txtTipe.Text = "HARIAN" Then
            DA = New OdbcDataAdapter("SELECT no_booking, nama_booking, nohp_booking, tgl_booking, waktu_booking, nama_lapang, harga_lapang from booking WHERE tgl_booking = '" + tgl + "' order by no_booking ASC", connection)
        ElseIf txtTipe.Text = "BULANAN" Then
            DA = New OdbcDataAdapter("SELECT no_booking, nama_booking, nohp_booking, tgl_booking, waktu_booking, nama_lapang, harga_lapang from booking WHERE MONTH(tgl_booking) = '" + bulan + "' order by no_booking ASC", connection)
        ElseIf txtTipe.Text = "SEMUA" Then
            DA = New OdbcDataAdapter("SELECT no_booking, nama_booking, nohp_booking, tgl_booking, waktu_booking, nama_lapang, harga_lapang from booking order by no_booking ASC", connection)
        End If
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "booking")
        DataGridView1.DataSource = DS.Tables("booking")
        DataGridView1.ReadOnly = True
        connection.Close()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Resize DataGridView to full height.
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height

        'Create a Bitmap and draw the DataGridView on it.
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))

        'Resize DataGridView back to original height.
        DataGridView1.Height = height

        'Show the Print Preview Dialog.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Print the contents.
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
End Class