Imports System.Data.OleDb
Public Class Frmpenjualan
    Sub no_faktur()
        cmd = New OleDbCommand("select * from tbl_jual where faktur_jual in (select max(faktur_jual) from tbl_jual) order by faktur_jual DESC", cnn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            txtfaktur.Text = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                txtfaktur.Text = Format(Now, "yyMMdd") + "0001"
            Else
                txtfaktur.Text = rd.Item("faktur_jual") + 1
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Frmpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Call koneksi()
        Call no_faktur()
        txtbayar.Text = "0"
        txtkembalian.Text = "0"
        txtkodebarang.Focus()
        Call grand_total()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_clock2.Text = DateTime.Now.ToString("ss:mm:hh tt    dd/MM/yyyy")
        txttanggal.Text = Format(Now, "dd/MM/yyyy")
        txtjam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub txtkodebarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkodebarang.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from tbl_barang where kode_barang= '" & txtkodebarang.Text & "'", cnn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = True Then
                txtnamabarang.Text = rd.Item("nama_barang")
                txtjenisbarang.Text = rd.Item("jenis_barang")
                txtsatuan.Text = rd.Item("satuan_barang")
                txtharga.Text = rd.Item("harga_jual")
                txtquantity.Focus()
            Else
                txtnamabarang.Text = ""
                txtjenisbarang.Text = ""
                txtsatuan.Text = ""
                txtharga.Text = ""
                txtkodebarang.Focus()
                MessageBox.Show("Barang Ini Tidak terdaftar Di Database !!", "OOps !")
            End If
        End If
    End Sub
    Sub bersih()
        txtkodebarang.Text = ""
        txtnamabarang.Text = ""
        txtjenisbarang.Text = ""
        txtsatuan.Text = ""
        txtharga.Text = ""
        txtquantity.Text = ""
        txttotalharga.Text = "0"
        txtkodebarang.Focus()
    End Sub
    Sub grand_total()
        Dim jumlah As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            jumlah = jumlah + DataGridView1.Rows(i).Cells(6).Value
            txtgrandtotal.Text = jumlah
        Next
    End Sub
    Private Sub txtquantity_TextChanged(sender As Object, e As EventArgs) Handles txtquantity.TextChanged
        Try
            txttotalharga.Text = Val(txtharga.Text) * Val(txtquantity.Text)
        Catch ex As Exception
            txttotalharga.Text = ""
        End Try
    End Sub

    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        If e.KeyChar = Chr(13) Then
            DataGridView1.Rows.Add(txtkodebarang.Text, txtnamabarang.Text, txtjenisbarang.Text, txtsatuan.Text, txtharga.Text, txtquantity.Text, txttotalharga.Text)
            Call bersih()
            Call grand_total()
        End If
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            txtgrandtotal.Text = DataGridView1.RowCount - 1
            Call grand_total()
            txtkembalian.Text = Val(txtbayar.Text) - Val(txtgrandtotal.Text)
        End If
    End Sub

    Private Sub txtkodebarang_TextChanged(sender As Object, e As EventArgs) Handles txtkodebarang.TextChanged
        cmd = New OleDbCommand("select * from tbl_barang where kode_barang= '" & txtkodebarang.Text & "'", cnn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = True Then
            txtnamabarang.Text = rd(1)
            txtjenisbarang.Text = rd(2)
            txtsatuan.Text = rd(3)
            txtharga.Text = rd.Item(5)
            txtquantity.Focus()
        Else
            txtnamabarang.Text = ""
            txtjenisbarang.Text = ""
            txtsatuan.Text = ""
            txtharga.Text = ""
            txtkodebarang.Focus()

        End If
    End Sub

    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles txtbayar.TextChanged
        Try
            txtkembalian.Text = Val(txtbayar.Text) - Val(txtgrandtotal.Text)
        Catch ex As Exception
            txtkembalian.Text = "0"
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtgrandtotal.Text = "0" Then
            MessageBox.Show("Belum Ada Transaksi !!")
        ElseIf val(txtbayar.Text) < Val(txtgrandtotal.Text) Then
            MessageBox.Show("Pembayaran Masih Kurang !!")
        Else
            'Menyimpan Data Ke Tabel Barang
            Call koneksi()
            cmd = New OleDbCommand("insert into tbl_jual(faktur_jual,tanggal_jual,jam,grand_total,dibayar,kembalian,kasir)values('" & txtfaktur.Text &
                                   "','" & txttanggal.Text &
                                   "','" & txtjam.Text &
                                   "','" & txtgrandtotal.Text &
                                   "','" & txtbayar.Text &
                                   "','" & txtkembalian.Text &
                                   "','" & txtkasir.Text &
                                   "')", cnn)
            cmd.ExecuteNonQuery()
            'Menyimpan Rincian Transaksi
            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                cmd = New OleDbCommand("insert into tbl_rinci_jual values('" & txtfaktur.Text &
                                       "','" & DataGridView1.Rows(baris).Cells(0).Value &
                                       "','" & DataGridView1.Rows(baris).Cells(5).Value &
                                       "','" & DataGridView1.Rows(baris).Cells(6).Value &
                                       "')", cnn)
                cmd.ExecuteNonQuery()
                'Counter Stock
                cmd = New OleDbCommand("select * from tbl_barang where kode_barang= '" & DataGridView1.Rows(baris).Cells(0).Value & "'", cnn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    cmd = New OleDbCommand("update tbl_barang set stok = '" & rd.Item("stok") - Val(DataGridView1.Rows(baris).Cells(5).Value) &
                                           "'where kode_barang='" & DataGridView1.Rows(baris).Cells(0).Value & "'", cnn)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Transaksi Selesai !!")
            'Membersihkan Transaksi
            DataGridView1.Rows.Clear()
            txtgrandtotal.Text = "0"
            txtbayar.Text = "0"
            txtkembalian.Text = "0"
            Call no_faktur()
            Call bersih()
        End If
    End Sub
End Class