Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = ("" & TimeString)
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://github.com/DsSoft-Byte/iCu/blob/main/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse
        Dim sr As IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

        Dim newestversions As String = sr.ReadToEnd
        Dim currentversion As String = Application.ProductVersion

        If newestversions.Contains(currentversion) Then
            MsgBox("You are up to date!")
        Else
            Form6.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Computer.FileSystem.DirectoryExists("C:\Users\Public\Downloads\Updater\iCures\") Then
            My.Computer.FileSystem.DeleteDirectory(
"C:\Users\Public\Downloads\Updater\iCures\",
FileIO.DeleteDirectoryOption.DeleteAllContents)
            MsgBox("Junk files have been found and deleted.")
        Else
            MsgBox("The Update temp files are not present! If you are sure there are some left over clean them manually!
The files would be located at C:\Users\Public\Downloads\Updater\iCures\")
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\iCures\Patchnotes.txt")
        Label10.Text = (fileReader)
    End Sub
End Class