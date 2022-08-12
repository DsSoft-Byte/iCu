Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ("12345678908825") Then
            Form4.Button2.Enabled = True
            Form4.Button6.Enabled = True
        Else
            MessageBox.Show("DevCode invalid. Check for typos")
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class