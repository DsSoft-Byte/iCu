Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
    'May my soul descend into the keyboard as i am slowly coding myself to de4t5

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = IO.File.ReadAllText("C:\iCures\lastdeviceid.txt")
        Label14.Text = IO.File.ReadAllText("C:\iCures\lastdevicestate.txt")
        'These Labels will output the saved device info and output it into the tool.
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            'NotifyIcon1.Icon = SystemIcons.Application '(For custom icons from SystemIcons)'
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "DsSoft iCu is in System tray!"
            NotifyIcon1.BalloonTipText = "To open iCu again, double-click the tray icon!"
            NotifyIcon1.ShowBalloonTip(50000)
            NotifyIcon1.Text = "iCu"
            'Me.Hide() '(Simpler but less fancy)'
            ShowInTaskbar = False
        End If
    End Sub
    'General tray fuckery

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
    'General Taskbar fuckery

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        iCu_DLL.Class1.InstallJS()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        iCu_DLL.Class1.InstallXAMPP()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        iCu_DLL.Class1.RunXAMPP()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        iCu_DLL.Class1.BypassTethered()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        iCu_DLL.Class1.RunPrelaunch()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        iCu_DLL.Class1.BypassTethered()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\iCures\Dependencies\Pangu\pangu_1.0-en.exe")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form2.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        iCu_DLL.Class1.rebootloop()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        iCu_DLL.Class1.idlaststate()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        iCu_DLL.Class1.idpwn()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MessageBox.Show("I can not supply the iTunes driver in this app or else i would get legal problems. Google iTunes XP driver")
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        iCu_DLL.Class1.idlaststate()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        iCu_DLL.Class1.RunPrelaunch()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Altough donations are nice, the ukrainians need them more. Go donate to ukraine instead.")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Form4.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MessageBox.Show("Tether bypass, run pangu. After reboot bypass tethered as quick as you can. Install Filza, delete setup.app. DONE")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        iCu_DLL.Class1.KillXAMPP()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\iCures\CB-X-config.txt")
        Process.Start(fileReader)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        MessageBox.Show("INFO:


The CB/X Button is for running user-defined hosting scripts, as the default configuration tends to be troublesome for the majority of users
and i have recieved some hate about the tool not working, this is the answer to all of that, if it does not work, you can prove yourself better and execute your own magic here till i fix the tool.
The CB/A Button is comming to for custom activation scripts, too. The Programm is 100% open so you can fix the batch scripts anyway and the app too, feel free to contrib.

Defaults:

CB/X: C:\xampp\xampp-control.exe
CB/A: C:\iCures\idact.bat

Config files:

CB/X: C:\iCures\CB-X-config.txt
CB/A: C:\iCures\CB-A-config.txt

Explaination (in-depth) is at C:\iCures\CBTutorial.txt

The Tool is 100% Open and you can help fixing it if you want to, nobody forces you to use this tool and do not hate on the people you dont need to and on those doing it for free.")
    End Sub
    'Info fuckery

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\iCures\CB-A-config.txt")
        Process.Start(fileReader)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Form7.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
'This fucking piece of code took me 2h to copy from stack cuz the thread was very old and who tf reads configs from .txt's anymore man.
