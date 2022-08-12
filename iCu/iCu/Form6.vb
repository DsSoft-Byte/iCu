Imports System.IO
Imports System
Imports System.IO.Compression
Public Class Form6
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists("C:\Users\Public\Downloads\File\iCu.zip") Then
            MsgBox("The Update file has been downloaded, or is obsolete but present. ERROR Code 01")
        Else
            My.Computer.Network.DownloadFile(
        "https://raw.githubusercontent.com/DsSoft-Byte/iCu/main/iCures_Updater.zip",
        "C:\Users\Public\Downloads\File\iCu.zip")
            Module1.Main()
            Process.Start("C:\Users\Public\Downloads\Updater\iCures\Updater\iCuUpdater.exe")
            Me.Close()
            Form7.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists("C:\Users\Public\Downloads\Updater\iCures") Then
            MsgBox("Extracted update file detected. Updater halted. Use iCu Cleanup feature in settings.")
            Button2.Enabled = False
            Label5.Visible = True

        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
Module Module1

    Sub Main()
        Dim startPath As String = "C:\Users\Public\Downloads"
        Dim zipPath As String = "C:\Users\Public\Downloads\File\iCu.zip"
        Dim extractPath As String = "C:\Users\Public\Downloads\Updater"

        ZipFile.ExtractToDirectory(zipPath, extractPath)
    End Sub

End Module
