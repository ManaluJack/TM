<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_input_barang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txthbeli = New System.Windows.Forms.TextBox()
        Me.txthjual = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.cmbsatuan = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(386, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jenis Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Harga Beli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Harga Jual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Qty"
        '
        'txtkode
        '
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(200, 77)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(149, 26)
        Me.txtkode.TabIndex = 9
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(200, 127)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(193, 26)
        Me.txtnama.TabIndex = 10
        '
        'txthbeli
        '
        Me.txthbeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthbeli.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthbeli.Location = New System.Drawing.Point(200, 277)
        Me.txthbeli.Name = "txthbeli"
        Me.txthbeli.Size = New System.Drawing.Size(122, 26)
        Me.txthbeli.TabIndex = 13
        '
        'txthjual
        '
        Me.txthjual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthjual.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthjual.Location = New System.Drawing.Point(200, 327)
        Me.txthjual.Name = "txthjual"
        Me.txthjual.Size = New System.Drawing.Size(122, 26)
        Me.txthjual.TabIndex = 14
        '
        'txtqty
        '
        Me.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtqty.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(200, 377)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(75, 26)
        Me.txtqty.TabIndex = 15
        '
        'cmbjenis
        '
        Me.cmbjenis.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Items.AddRange(New Object() {"Makanan", "Minuman", "ATK", "Alat Dapur"})
        Me.cmbjenis.Location = New System.Drawing.Point(200, 177)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(169, 26)
        Me.cmbjenis.TabIndex = 16
        '
        'cmbsatuan
        '
        Me.cmbsatuan.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsatuan.FormattingEnabled = True
        Me.cmbsatuan.Items.AddRange(New Object() {"Lusin", "Kodi", "PCS", "Bungkus", "Pack"})
        Me.cmbsatuan.Location = New System.Drawing.Point(200, 227)
        Me.cmbsatuan.Name = "cmbsatuan"
        Me.cmbsatuan.Size = New System.Drawing.Size(169, 26)
        Me.cmbsatuan.TabIndex = 17
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsave.Location = New System.Drawing.Point(449, 160)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(132, 36)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btndelete.Location = New System.Drawing.Point(449, 289)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(132, 36)
        Me.btndelete.TabIndex = 19
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnclose.Location = New System.Drawing.Point(449, 346)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(132, 36)
        Me.btnclose.TabIndex = 21
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnedit.Location = New System.Drawing.Point(449, 224)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(132, 36)
        Me.btnedit.TabIndex = 22
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Frm_input_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TM_VB.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 454)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbsatuan)
        Me.Controls.Add(Me.cmbjenis)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txthjual)
        Me.Controls.Add(Me.txthbeli)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_input_barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Data Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txthbeli As TextBox
    Friend WithEvents txthjual As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents cmbsatuan As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnedit As Button
End Class
