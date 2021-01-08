Public Class FrmLoad
    Private Sub FrmLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Double
        Static ctr As Integer

        For i = 1 To 100
            Label2.Text = ProgressBar1.Value
            Label1.Text = "Please Wait..."
        Next

        If ctr <= 100 Then
            ProgressBar1.Value = ctr
            ctr += 1
        Else
            Me.Close()
            Sub_Frm.Show()
        End If
    End Sub
End Class