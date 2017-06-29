Imports System.Net

Public Class Form1
    Dim Skype As New SKYPE4COMLib.Skype
    Public WithEvents grabber As New SKYPE4COMLib.Skype
    Dim spamcounter As Integer = 0
    Dim status_abfucker As Integer = 0
    Dim vs As New WebClient

    Public Sub sendMessage(type As String, msg As String)
        If (type = "success") Then
            FlatAlertBox1.kind = FlatAlertBox._Kind.Success
            FlatAlertBox1.Text = msg
            FlatAlertBox1.Show()
        ElseIf (type = "info") Then
            FlatAlertBox1.kind = FlatAlertBox._Kind.Info
            FlatAlertBox1.Text = msg
            FlatAlertBox1.Show()
        ElseIf (type = "error") Then
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatAlertBox1.Text = msg
            FlatAlertBox1.Show()
        Else
            MsgBox("Wrong type = '" & type & "'")
        End If
    End Sub

    Public Sub checkUpdate()
        Dim iversion As String = vs.DownloadString("http://draxxdev.tk/dev/skype-tool/version.txt")
        Dim cversion As String = "1.0"

        If (iversion = cversion) Then
        Else
            MsgBox("Updates wurden gefunden." & vbNewLine & "Bitte laden Sie die neueste Version herunter.")
            Process.Start("http://draxxdev.tk/skype-tool/")
            End
        End If
    End Sub

    Public Sub loadChangelog()
        rtxtb_changelog.Text = vs.DownloadString("http://draxxdev.tk/dev/skype-tool/changelog.txt")
    End Sub

    Function checkInternetConnection() As Boolean
        Try
            Using Client = New WebClient()
                Using stream = Client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        Try
            Skype.Attach()
            Me.Text = "Skype Tool by Draxx | Welcome: " & Skype.CurrentUser.FullName
            txb_name.Text = Skype.CurrentUser.FullName
            rtxtb_mood.Text = Skype.CurrentUser.MoodText
            Skype.CurrentUserProfile.About = "Using Draxx Skype Tool"
            pctureb_grabavatar.ImageLocation = "https://api.skype.com/users/echo123/profile/avatar"

            For Each user As SKYPE4COMLib.User In Skype.Friends
                FlatListBox1.AddItem(user.Handle)
                FlatComboBox2.Items.Add(user.Handle)
            Next

            sendMessage("success", "Erfolgreich Verbunden")
            FlatTabControl1.Controls.Add(TabPage4)
            FlatTabControl1.Controls.Add(TabPage2)
            FlatTabControl1.Controls.Add(TabPage5)
            FlatTabControl1.Controls.Add(TabPage6)
            FlatTabControl1.Controls.Add(TabPage3)
            btn_connect.Enabled = False
        Catch ex As Exception
            'MsgBox(ex.StackTrace)
        End Try

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles btn_changename.Click
        Skype.CurrentUserProfile.FullName = txb_name.Text
        sendMessage("scuess", "Name wurde erfolgreich geändert")
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        pctureb_grabavatar.ImageLocation = "https://api.skype.com/users/" & FlatListBox1.SelectedItem & "/profile/avatar"
        'Dim webclient As New System.Net.WebClient
        'Dim resolver As String = webclient.DownloadString("http://apionly.com/skype.php?username=" & FlatListBox1.SelectedItem)
        'txb_ip.Text = resolver

        txtb_grabname.Text = grabber.User(FlatListBox1.SelectedItem).FullName.ToString
        txtb_grabmood.Text = grabber.User(FlatListBox1.SelectedItem).MoodText.ToString
        txtb_grabstatus.Text = grabber.User(FlatListBox1.SelectedItem).OnlineStatus.ToString
        txtb_grabbirthday.Text = grabber.User(FlatListBox1.SelectedItem).Birthday.ToString

        sendMessage("success", "Informationen wurden erfolgreich geladen")
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        SaveFileDialog1.FileName = FlatListBox1.SelectedItem & ".jpg"
        SaveFileDialog1.Filter = ".jpg|*.jpg"
        SaveFileDialog1.ShowDialog()
        pctureb_grabavatar.Image.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        My.Computer.Clipboard.SetText(txb_ip.Text)
    End Sub

    Private Sub FlatButton3_Click_1(sender As Object, e As EventArgs) Handles btn_changemood.Click
        Skype.CurrentUserProfile.MoodText = rtxtb_mood.Text
        sendMessage("success", "Das Mood wurde erfolgreich verändert")
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles btn_moodblink.Click
        rtxtb_mood.Text = "<blink>" & rtxtb_mood.Text & "</blink>"
    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles btn_moodbold.Click
        rtxtb_mood.Text = "<b>" & rtxtb_mood.Text & "</b>"
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles btn_moodunderline.Click
        rtxtb_mood.Text = "<u>" & rtxtb_mood.Text & "</u>"
    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles btn_mooditalic.Click
        rtxtb_mood.Text = "<i>" & rtxtb_mood.Text & "</i>"
    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles btn_moodcenter.Click
        rtxtb_mood.Text = "<center>" & rtxtb_mood.Text & "</center>"
    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs) Handles btn_msend.Click
        For Each user As SKYPE4COMLib.User In Skype.Friends
            Skype.SendMessage(user.Handle, rtxtb_broadcast.Text)
        Next
        sendMessage("success", "Broadcast wurde erfolgreich ausgeführt")
    End Sub

    Private Sub FlatButton13_Click(sender As Object, e As EventArgs) Handles btn_status.Click
        If FlatComboBox1.SelectedItem = "Online" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
        ElseIf FlatComboBox1.SelectedItem = "Away" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
        ElseIf FlatComboBox1.SelectedItem = "NotAvailable" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
        ElseIf FlatComboBox1.SelectedItem = "Invisible" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
        ElseIf FlatComboBox1.SelectedItem = "Offline" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOffline
        Else
            MsgBox("Bitte wähle etwas aus")
        End If
        sendMessage("success", "Online-Status wurde geändert")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer_spammer.Tick
        Skype.SendMessage(FlatComboBox2.Text, rtxtb_spammer.Text)
        spamcounter = spamcounter + 1
        FlatTextBox1.Text = spamcounter
    End Sub

    Private Sub FlatButton14_Click(sender As Object, e As EventArgs) Handles btn_mstart.Click
        spamcounter = 0
        FlatTextBox1.Text = spamcounter
        timer_spammer.Start()
        btn_mstart.Enabled = False
        btn_mstop.Enabled = True
    End Sub

    Private Sub FlatButton15_Click(sender As Object, e As EventArgs) Handles btn_mstop.Click
        timer_spammer.Stop()
        btn_mstart.Enabled = True
        btn_mstop.Enabled = False
        sendMessage("success", "Successfully send " & spamcounter & " messages")
    End Sub

    Private Sub FlatTrackBar1_Scroll(sender As Object) Handles FlatTrackBar1.Scroll
        timer_spammer.Interval = FlatTrackBar1.Value
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If (checkInternetConnection() = True) Then
            checkUpdate()
            loadChangelog()
        Else
            MsgBox("Prüfe deine Internetverbindung")
        End If

    End Sub

    Private Sub ftoggle_afk_CheckedChanged(sender As Object) Handles ftoggle_afk.CheckedChanged
        timer_afk.Start()
    End Sub

    Private Sub ftoggle_statusabfuck_CheckedChanged(sender As Object) Handles ftoggle_statusabfuck.CheckedChanged
        If (ftoggle_statusabfuck.Checked = False) Then
            btn_status.Enabled = True
            timer_status.Stop()
            status_abfucker = 0
        ElseIf (ftoggle_statusabfuck.Checked = True) Then
            btn_status.Enabled = False
            timer_status.Start()
        End If
    End Sub

    Private Sub timer_status_Tick(sender As Object, e As EventArgs) Handles timer_status.Tick

        If (status_abfucker = 0) Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
            status_abfucker = 1
        End If

        If (status_abfucker = 1) Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
            status_abfucker = 2
        End If

        If (status_abfucker = 2) Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
            status_abfucker = 3
        End If

        If (status_abfucker = 3) Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
            status_abfucker = 0
        End If
    End Sub

    Private Sub btn_grabspammer_Click(sender As Object, e As EventArgs) Handles btn_grabspammer.Click
        FlatComboBox2.Text = FlatListBox1.SelectedItem
        TabPage5.Show()
    End Sub

    Private Sub btn_grabbergeo_Click(sender As Object, e As EventArgs) Handles btn_grabbergeo.Click
        MsgBox("Wird noch hinzugefügt")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FlatTabControl1.Controls.Remove(TabPage4)
        FlatTabControl1.Controls.Remove(TabPage2)
        FlatTabControl1.Controls.Remove(TabPage5)
        FlatTabControl1.Controls.Remove(TabPage6)
        FlatTabControl1.Controls.Remove(TabPage3)
    End Sub
End Class
