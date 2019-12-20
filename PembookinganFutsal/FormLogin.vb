Imports System.Data.Odbc
Public Class FormLogin
    Dim username As String
    Dim password As String
    Const DSN_ODBC = "DSN=bookingfutsal1"
    Dim connection As OdbcConnection
    Dim command As OdbcCommand
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        username = txtUsername.Text
        password = txtPassword.Text
        Dim StrSQL As String = "SELECT id_admin FROM admin where username='" + username + "' and password='" + password + "'"
            command = New OdbcCommand(StrSQL, connection)
            DR = command.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                txtUsername.Text = ""
                txtPassword.Text = ""
            txtUsername.Focus()
            idadmin = DR("id_admin")
            FormUtama.idadmin = idadmin
            FormUtama.Show()
                Me.Hide()
            Else
            MsgBox("Username atau Password yang anda masukan salah, Mohon periksa kembali")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()
        End If
            connection.Close()
    End Sub
End Class