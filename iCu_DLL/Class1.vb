Public Class Class1
    Public Shared Sub Mfunc()
        MsgBox("iCu DLL file is found when no error mesage was shown everything exists")
        My.Computer.FileSystem.ReadAllText("C:\iCures\idact.bat")
        My.Computer.FileSystem.ReadAllText("C:\iCures\sliver.php")
        My.Computer.FileSystem.ReadAllText("C:\iCures\runapache.bat")
    End Sub

    Public Shared Sub InstallJS()
        Process.Start("C:\iCures\Dependencies\node.msi")
    End Sub

    Public Shared Sub InstallXAMPP()
        Process.Start("C:\iCures\Dependencies\XAMMP7.exe")

    End Sub

    Public Shared Sub RunXAMPP()
        Process.Start("C:\xampp\xampp-control.exe")
    End Sub

    Public Shared Sub KillXAMPP()
        Process.Start("C:\xampp\xampp_stop.exe")
    End Sub

    Public Shared Sub BypassTethered()
        Process.Start("C:\iCures\idact.bat")
    End Sub
    Public Shared Sub RunPrelaunch()
        Process.Start("C:\iCures\prelaunch.bat")
    End Sub

    Public Shared Sub rebootloop()
        Process.Start("C:\iCures\idbootloopfix.bat")
    End Sub

    Public Shared Sub idlaststate()
        Process.Start("C:\iCures\idlaststate.bat")
    End Sub

    Public Shared Sub idpwn()
        Process.Start("C:\iCures\idpwn.bat")
    End Sub

End Class
