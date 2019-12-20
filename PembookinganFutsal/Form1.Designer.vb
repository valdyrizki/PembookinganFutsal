<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PembookinganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CekLapangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelolaLapangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TahunanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembookinganToolStripMenuItem, Me.KelolaLapangToolStripMenuItem, Me.MenuUserToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PembookinganToolStripMenuItem
        '
        Me.PembookinganToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookingToolStripMenuItem, Me.CekLapangToolStripMenuItem})
        Me.PembookinganToolStripMenuItem.Name = "PembookinganToolStripMenuItem"
        Me.PembookinganToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PembookinganToolStripMenuItem.Text = "Menu"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'CekLapangToolStripMenuItem
        '
        Me.CekLapangToolStripMenuItem.Name = "CekLapangToolStripMenuItem"
        Me.CekLapangToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CekLapangToolStripMenuItem.Text = "Cancel"
        '
        'KelolaLapangToolStripMenuItem
        '
        Me.KelolaLapangToolStripMenuItem.Name = "KelolaLapangToolStripMenuItem"
        Me.KelolaLapangToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.KelolaLapangToolStripMenuItem.Text = "Kelola Lapang"
        '
        'MenuUserToolStripMenuItem
        '
        Me.MenuUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
        Me.MenuUserToolStripMenuItem.Name = "MenuUserToolStripMenuItem"
        Me.MenuUserToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.MenuUserToolStripMenuItem.Text = "Menu User"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HarianToolStripMenuItem, Me.BulananToolStripMenuItem, Me.TahunanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'HarianToolStripMenuItem
        '
        Me.HarianToolStripMenuItem.Name = "HarianToolStripMenuItem"
        Me.HarianToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.HarianToolStripMenuItem.Text = "Harian"
        '
        'BulananToolStripMenuItem
        '
        Me.BulananToolStripMenuItem.Name = "BulananToolStripMenuItem"
        Me.BulananToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BulananToolStripMenuItem.Text = "Bulanan"
        '
        'TahunanToolStripMenuItem
        '
        Me.TahunanToolStripMenuItem.Name = "TahunanToolStripMenuItem"
        Me.TahunanToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.TahunanToolStripMenuItem.Text = "Tahunan"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PembookinganFutsal.My.Resources.Resources.adidas_telstar_18_official_ball_telstar_mechta_ball_for_the_final_red_black_ball_besthqwallpapers_com_1366x768
        Me.ClientSize = New System.Drawing.Size(846, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM UTAMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PembookinganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CekLapangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TahunanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelolaLapangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
