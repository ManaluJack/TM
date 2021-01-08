Imports System.Data.OleDb

Module Module1
    Public cmd As OleDbCommand
    Public cnn As OleDbConnection
    Public rd As OleDbDataReader

    Sub koneksi()
        cnn = New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source =DBPenjualan.mdb")
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
    End Sub
End Module
