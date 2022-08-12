Public Class Form4
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://www.youtube.com/watch?v=-AXetJvTfU0")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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
End Class