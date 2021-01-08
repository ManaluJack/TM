<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpenjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtgrandtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtkasir = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtjam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfaktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.date_clock2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.txtjenisbarang = New System.Windows.Forms.TextBox()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txttotalharga = New System.Windows.Forms.TextBox()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1321, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.GroupBox3.Controls.Add(Me.txtgrandtotal)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(493, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(825, 157)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grand Total"
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.BackColor = System.Drawing.Color.Black
        Me.txtgrandtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgrandtotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtgrandtotal.Font = New System.Drawing.Font("Baskerville Old Face", 69.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrandtotal.ForeColor = System.Drawing.Color.Lime
        Me.txtgrandtotal.Location = New System.Drawing.Point(3, 22)
        Me.txtgrandtotal.Multiline = True
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.ReadOnly = True
        Me.txtgrandtotal.Size = New System.Drawing.Size(819, 132)
        Me.txtgrandtotal.TabIndex = 10
        Me.txtgrandtotal.Text = "2000000"
        Me.txtgrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.GroupBox2.Controls.Add(Me.txtkasir)
        Me.GroupBox2.Controls.Add(Me.txttanggal)
        Me.GroupBox2.Controls.Add(Me.txtjam)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtfaktur)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 157)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'txtkasir
        '
        Me.txtkasir.Location = New System.Drawing.Point(264, 111)
        Me.txtkasir.Name = "txtkasir"
        Me.txtkasir.ReadOnly = True
        Me.txtkasir.Size = New System.Drawing.Size(205, 26)
        Me.txtkasir.TabIndex = 8
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(264, 43)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.ReadOnly = True
        Me.txttanggal.Size = New System.Drawing.Size(205, 26)
        Me.txttanggal.TabIndex = 7
        '
        'txtjam
        '
        Me.txtjam.Location = New System.Drawing.Point(28, 111)
        Me.txtjam.Name = "txtjam"
        Me.txtjam.ReadOnly = True
        Me.txtjam.Size = New System.Drawing.Size(192, 26)
        Me.txtjam.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(261, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kasir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(261, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jam"
        '
        'txtfaktur
        '
        Me.txtfaktur.Location = New System.Drawing.Point(28, 43)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.ReadOnly = True
        Me.txtfaktur.Size = New System.Drawing.Size(192, 26)
        Me.txtfaktur.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Faktur"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.GroupBox4.Controls.Add(Me.StatusStrip1)
        Me.GroupBox4.Controls.Add(Me.btnclose)
        Me.GroupBox4.Controls.Add(Me.btnclear)
        Me.GroupBox4.Controls.Add(Me.btnsave)
        Me.GroupBox4.Controls.Add(Me.txtkembalian)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtbayar)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(0, 521)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1321, 154)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pembayaran"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.date_clock2})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 128)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1315, 23)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'date_clock2
        '
        Me.date_clock2.BackColor = System.Drawing.SystemColors.Control
        Me.date_clock2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_clock2.ForeColor = System.Drawing.Color.Black
        Me.date_clock2.Name = "date_clock2"
        Me.date_clock2.Size = New System.Drawing.Size(150, 18)
        Me.date_clock2.Text = "ToolStripStatusLabel1"
        '
        'btnclose
        '
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Red
        Me.btnclose.Location = New System.Drawing.Point(1203, 70)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(98, 36)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Lime
        Me.btnclear.Location = New System.Drawing.Point(1088, 70)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(98, 36)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Baskerville Old Face", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Maroon
        Me.btnsave.Location = New System.Drawing.Point(671, 36)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(148, 74)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtkembalian
        '
        Me.txtkembalian.BackColor = System.Drawing.Color.Black
        Me.txtkembalian.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkembalian.ForeColor = System.Drawing.Color.Yellow
        Me.txtkembalian.Location = New System.Drawing.Point(293, 43)
        Me.txtkembalian.Multiline = True
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(353, 59)
        Me.txtkembalian.TabIndex = 6
        Me.txtkembalian.Text = "200000"
        Me.txtkembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(290, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kembalian"
        '
        'txtbayar
        '
        Me.txtbayar.BackColor = System.Drawing.Color.Black
        Me.txtbayar.Font = New System.Drawing.Font("Baskerville Old Face", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbayar.Location = New System.Drawing.Point(9, 43)
        Me.txtbayar.Multiline = True
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(261, 59)
        Me.txtbayar.TabIndex = 4
        Me.txtbayar.Text = "500000"
        Me.txtbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Bayar"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Location = New System.Drawing.Point(88, 206)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(203, 20)
        Me.txtkodebarang.TabIndex = 4
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(289, 206)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.ReadOnly = True
        Me.txtnamabarang.Size = New System.Drawing.Size(251, 20)
        Me.txtnamabarang.TabIndex = 5
        '
        'txtjenisbarang
        '
        Me.txtjenisbarang.Location = New System.Drawing.Point(539, 206)
        Me.txtjenisbarang.Name = "txtjenisbarang"
        Me.txtjenisbarang.ReadOnly = True
        Me.txtjenisbarang.Size = New System.Drawing.Size(201, 20)
        Me.txtjenisbarang.TabIndex = 6
        '
        'txtsatuan
        '
        Me.txtsatuan.Location = New System.Drawing.Point(738, 206)
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.ReadOnly = True
        Me.txtsatuan.Size = New System.Drawing.Size(101, 20)
        Me.txtsatuan.TabIndex = 7
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(838, 206)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.ReadOnly = True
        Me.txtharga.Size = New System.Drawing.Size(190, 20)
        Me.txtharga.TabIndex = 8
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(1027, 206)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(104, 20)
        Me.txtquantity.TabIndex = 9
        '
        'txttotalharga
        '
        Me.txttotalharga.Location = New System.Drawing.Point(1127, 206)
        Me.txttotalharga.Name = "txttotalharga"
        Me.txttotalharga.ReadOnly = True
        Me.txttotalharga.Size = New System.Drawing.Size(189, 20)
        Me.txttotalharga.TabIndex = 10
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 190
        '
        'Column6
        '
        Me.Column6.HeaderText = "Quantity"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 190
        '
        'Column4
        '
        Me.Column4.HeaderText = "Satuan"
        Me.Column4.Name = "Column4"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(47, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1225, 382)
        Me.DataGridView1.TabIndex = 3
        '
        'Frmpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.TM_VB.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1321, 675)
        Me.Controls.Add(Me.txttotalharga)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtsatuan)
        Me.Controls.Add(Me.txtjenisbarang)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.txtkodebarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmpenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmpenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfaktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtkasir As TextBox
    Friend WithEvents txttanggal As TextBox
    Friend WithEvents txtjam As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtgrandtotal As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents date_clock2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtkodebarang As TextBox
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents txtjenisbarang As TextBox
    Friend WithEvents txtsatuan As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txttotalharga As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
