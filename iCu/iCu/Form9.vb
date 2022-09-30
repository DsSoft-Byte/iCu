Public Class Form9
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MessageBox.Show("This feature is soon to be added, MAY BE DESTRUCTIVE!!! KEEP A COPY OF YOUR HOSTS FILE BEFORE USING THIS!!!")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Use the button in the main window.")
    End Sub
End Class