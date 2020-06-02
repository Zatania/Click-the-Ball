Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Close()
        Form1.Enabled = True
        Form1.Show()
    End Sub
End Class