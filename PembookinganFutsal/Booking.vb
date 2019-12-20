Imports System.Data.Odbc
Public Class Booking
    Const DSN_ODBC = "DSN=bookingfutsal1"
    Dim connection As OdbcConnection
    Dim command As OdbcCommand
    Dim command1 As OdbcCommand
    Dim DA As OdbcDataAdapter
    Dim DS As DataSet
    Dim DR As OdbcDataReader
    Dim table As DataTable
    Dim tgl As String
    Public idadmin As String

    Sub koneksi()
        connection = New OdbcConnection(DSN_ODBC)
        Try
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub isiGrid()

        buatno()
        tgl = Format(Now, "yyyy-MM-dd")
        koneksi()

        DA = New OdbcDataAdapter("SELECT * from booking order by no_booking DESC", connection)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "booking")
        DataGridView1.DataSource = DS.Tables("booking")
        DataGridView1.ReadOnly = True
        connection.Close()
    End Sub

    Sub buatno()
        koneksi()
        command = New OdbcCommand("Select * from booking where no_booking in (select max(no_booking) from booking)", connection)
        DR = command.ExecuteReader
        DR.Read()
        Dim urutan As String
        Dim hitung As Long
        If Not DR.HasRows Then
            urutan = "BOOK" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
            urutan = "BOOK" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtId.Text = urutan
    End Sub

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
        DateTimePicker1.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        txtNama.ReadOnly = True
        txtNohp.ReadOnly = True
        txtWaktu.Text = "00:00"
        btnBooking.Enabled = False
        tampilDataComboBox()
    End Sub

    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        koneksi()
        Dim strtgl As String = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        Dim strwaktu As String = txtWaktu.Text
        Dim namalapang As String = cmbLapang.Text
        Dim StrSQL As String = "SELECT * FROM booking WHERE tgl_booking='" + strtgl + "' AND waktu_booking='" + strwaktu + "' AND nama_lapang='" + namalapang + "' "
        command = New OdbcCommand(StrSQL, connection)
        DR = command.ExecuteReader
        DR.Read()
        If (txtWaktu.Text = "" Or cmbLapang.Text = "") Then
            MsgBox("DATA HARUS DIISI", vbYes, "Keterangan")
        Else
            If DR.HasRows Then
                MsgBox("Lapang Penuh, cari waktu lain", vbYes, "Keterangan")
                txtWaktu.Focus()
            Else
                MsgBox("Lapang Kosong, Silahkan Lanjut Booking", vbYes, "Keterangan")
                txtNama.ReadOnly = False
                txtNohp.ReadOnly = False
                txtNama.Focus()
                btnCek.Enabled = False
                btnCek.Enabled = False
                DateTimePicker1.Enabled = False
                txtWaktu.ReadOnly = True
                cmbLapang.Enabled = False
                btnBooking.Enabled = True
            End If
        End If
        connection.Close()
    End Sub

    Sub tampilDataComboBox()
        Call koneksi()
        Dim str As String
        str = "select nama_lapang from lapang"
        command = New OdbcCommand(str, connection)
        DR = command.ExecuteReader
        If DR.HasRows Then
            Do While DR.Read
                cmbLapang.Items.Add(DR("nama_lapang"))
            Loop
        Else
        End If
        connection.Close()
    End Sub


    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Dim strtgl As String = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        Dim strwaktu As String = Val(txtWaktu.Text)
        If (txtNama.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            txtNama.Focus()
        ElseIf (txtNohp.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            txtNohp.Focus()
        ElseIf (txtWaktu.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            txtWaktu.Focus()
        ElseIf (cmbLapang.Text = "") Then
            MsgBox("Isi semua data!!!", vbYes, "Isi")
            cmbLapang.Focus()
        Else
            Try
                koneksi()
                Call koneksi()
                Dim str1 As String
                Dim hargalapang As Integer
                str1 = "select harga_lapang from lapang WHERE nama_lapang='" + cmbLapang.Text + "'"
                command1 = New OdbcCommand(str1, connection)
                DR = command1.ExecuteReader
                If DR.HasRows Then
                    hargalapang = DR("harga_lapang")
                Else
                    hargalapang = 0
                End If
                command = New OdbcCommand("insert into booking values (?, ?, ?, ?, ?, ?, ?, ?)", connection)
                With command
                    .Parameters.AddWithValue("?", txtId.Text)
                    .Parameters.AddWithValue("?", strtgl)
                    .Parameters.AddWithValue("?", txtWaktu.Text)
                    .Parameters.AddWithValue("?", txtNama.Text)
                    .Parameters.AddWithValue("?", txtNohp.Text)
                    .Parameters.AddWithValue("?", idadmin)
                    .Parameters.AddWithValue("?", cmbLapang.Text)
                    .Parameters.AddWithValue("?", hargalapang)
                    .ExecuteNonQuery()
                End With
                connection.Close()
                isiGrid()
                txtWaktu.Text = "00:00"
                txtNama.Text = ""
                txtNohp.Text = ""
                txtWaktu.Focus()
                txtNama.ReadOnly = True
                txtNohp.ReadOnly = True
                DateTimePicker1.Enabled = True
                txtWaktu.ReadOnly = False
                btnBooking.Enabled = False
                btnCek.Enabled = True
                cmbLapang.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class