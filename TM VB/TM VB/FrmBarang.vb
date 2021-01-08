Imports System.Data.OleDb
Public Class FrmBarang
    Sub tampil_barang()
        cmd = New OleDbCommand("select * from tbl_barang", cnn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub
    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_barang()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cmd = New OleDbCommand("select * from tbl_barang where nama_barang like '%" & txtcari.Text & "%'", cnn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_input_barang.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class