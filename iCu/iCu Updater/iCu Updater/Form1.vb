Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists("C:\Users\Public\Downloads\Updater\iCures\MainProgramm\iCu.exe") Then
            My.Computer.FileSystem.CopyDirectory("C:\Users\Public\Downloads\Updater\iCures\", "C:\iCures", True)
            Label1.Text = "DsSoft iCu software is updating..."
            Label2.Text = "To avoid data corruption do NOT Sleep, Shut down or Restart the Machine, DO NOT close this window"
            Button1.Text = "Updating..."
            Button1.Enabled = False
            System.Threading.Thread.Sleep(150)
            Button1.Text = "Update Done!"
            Label1.Text = "DsSoft iCu software updated successfully!"
            Label2.Text = "Now click the close button to exit the updater"
            Button2.Enabled = True
            My.Computer.FileSystem.DeleteFile("C:\Users\Public\Downloads\File\iCu.zip")
            System.Threading.Thread.Sleep(10000)
            MsgBox("Update is done, downloaded files have been cleaned.")
        Else
            MsgBox("Whoops... We dont know how did you get here but the update file is not present/exctracted... ERROR Code 002")
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
