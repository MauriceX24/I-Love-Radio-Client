Imports System.Net
Imports System.Net.NetworkInformation
Public Class Form1
    ' Form Start
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.S1 = True Then
            B1.Enabled = True
            Star1.Image = My.Resources.star_on
        Else
            Star1.Image = My.Resources.star_off
        End If
        If My.Settings.S2 = True Then
            B2.Enabled = True
            Star2.Image = My.Resources.star_on
        Else
            Star2.Image = My.Resources.star_off
        End If
        If My.Settings.S3 = True Then
            B3.Enabled = True
            Star3.Image = My.Resources.star_on
        Else
        End If
        Star3.Image = My.Resources.star_off
        If My.Settings.S4 = True Then
            B4.Enabled = True
            Star4.Image = My.Resources.star_on
        Else
            Star5.Image = My.Resources.star_off
        End If
        If My.Settings.S5 = True Then
            B5.Enabled = True
            Star5.Image = My.Resources.star_on
        Else
            Star5.Image = My.Resources.star_off
        End If
        If My.Settings.S6 = True Then
            B6.Enabled = True
            Star6.Image = My.Resources.star_on
        Else
            Star6.Image = My.Resources.star_off
        End If
        If My.Settings.S7 = True Then
            B7.Enabled = True
            Star7.Image = My.Resources.star_on
        Else
            Star7.Image = My.Resources.star_off
        End If
    End Sub
    ' Updates
    Sub Updater()
        Dim Web As New WebClient
        Dim versionold As Integer = versionlbl.Text
        Dim version As String = Web.DownloadString("https://raw.githubusercontent.com/MauriceX24/I-Love-Radio-Client/master/version")
        If version > versionold Then
            MsgBox("Version " & version & " wurde gefunden.", MsgBoxStyle.Information, "Updater")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Updater()
    End Sub
    ' Timer for FavPage
    Private Sub FavTimer_Tick(sender As Object, e As EventArgs) Handles FavTimer.Tick
        Colorchanger()
    End Sub

    'Sub for Color Change
    Sub Colorchanger()
        Dim Num As New Random
        ' Dim List As List(Of TabControl.ControlCollection)
        B1.ForeColor = Color.FromArgb(Num.Next(0, 255), Num.Next(0, 255), Num.Next(0, 255))
        B2.ForeColor = Color.FromArgb(Num.Next(0, 255), Num.Next(0, 255), Num.Next(0, 255))
        B3.ForeColor = Color.FromArgb(Num.Next(0, 255), Num.Next(0, 255), Num.Next(0, 255))
        B4.ForeColor = Color.FromArgb(Num.Next(0, 255), Num.Next(0, 255), Num.Next(0, 255))
        B5.ForeColor = Color.FromArgb(Num.Next(0, 255), Num.Next(0, 255), Num.Next(0, 255))
        B6.ForeColor = Color.FromArgb(Num.Next(0, 255), Num.Next(0, 255), Num.Next(0, 255))
        B7.ForeColor = Color.FromArgb(Num.Next(0, 255), Num.Next(0, 255), Num.Next(0, 255))
    End Sub
    ' Star (Favoriten hinzufügen) ======
    ' 1
    Private Sub Star1_Click(sender As Object, e As EventArgs) Handles Star1.Click
        If My.Settings.S1 = False Then
            My.Settings.S1 = True
            Star1.Image = My.Resources.star_on
        Else
            My.Settings.S1 = False
            Star1.Image = My.Resources.star_off
        End If
        SettingsSaver()
    End Sub
    ' 2
    Private Sub Star2_Click(sender As Object, e As EventArgs) Handles Star2.Click
        If My.Settings.S2 = False Then
            My.Settings.S2 = True
            Star2.Image = My.Resources.star_on
        Else
            My.Settings.S2 = False
            Star2.Image = My.Resources.star_off
        End If
        SettingsSaver()
    End Sub
    ' 3
    Private Sub Star3_Click(sender As Object, e As EventArgs) Handles Star3.Click
        If My.Settings.S3 = False Then
            My.Settings.S3 = True
            Star3.Image = My.Resources.star_on
        Else
            My.Settings.S3 = False
            Star3.Image = My.Resources.star_off
        End If
        SettingsSaver()
    End Sub
    ' 4
    Private Sub Star4_Click(sender As Object, e As EventArgs) Handles Star4.Click
        If My.Settings.S4 = False Then
            My.Settings.S4 = True
            Star4.Image = My.Resources.star_on
        Else
            My.Settings.S4 = False
            Star4.Image = My.Resources.star_off
        End If
        SettingsSaver()
    End Sub
    ' 5
    Private Sub Star5_Click(sender As Object, e As EventArgs) Handles Star5.Click
        If My.Settings.S5 = False Then
            My.Settings.S5 = True
            Star5.Image = My.Resources.star_on
        Else
            My.Settings.S5 = False
            Star5.Image = My.Resources.star_off
        End If
        SettingsSaver()
    End Sub
    ' 6
    Private Sub Star6_Click(sender As Object, e As EventArgs) Handles Star6.Click
        If My.Settings.S6 = False Then
            My.Settings.S6 = True
            Star6.Image = My.Resources.star_on
        Else
            My.Settings.S6 = False
            Star6.Image = My.Resources.star_off
        End If
        SettingsSaver()
    End Sub
    ' 7
    Private Sub Star7_Click(sender As Object, e As EventArgs) Handles Star7.Click
        If My.Settings.S7 = False Then
            My.Settings.S7 = True
            Star7.Image = My.Resources.star_on
        Else
            My.Settings.S7 = False
            Star7.Image = My.Resources.star_off
        End If
        SettingsSaver()
    End Sub
    ' Settings Speichern
    Sub SettingsSaver()
        My.Settings.Save()
        Task1()
    End Sub
    ' Buttons freigeben
    Sub Task1()
        If My.Settings.S1 = True Then
            B1.Enabled = True
        Else
            B1.Enabled = False
        End If

        If My.Settings.S2 = True Then
            B2.Enabled = True
        Else
            B2.Enabled = False
        End If

        If My.Settings.S3 = True Then
            B3.Enabled = True
        Else
            B3.Enabled = False
        End If

        If My.Settings.S4 = True Then
            B4.Enabled = True
        Else
            B4.Enabled = False
        End If

        If My.Settings.S5 = True Then
            B5.Enabled = True
        Else
            B5.Enabled = False
        End If

        If My.Settings.S6 = True Then
            B6.Enabled = True
        Else
            B6.Enabled = False
        End If

        If My.Settings.S7 = True Then
            B7.Enabled = True
        Else
            B7.Enabled = False
        End If
    End Sub
    ' Radio Buttons #1
    Private Sub ILR1B_Click(sender As Object, e As EventArgs) Handles ILR1B.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio1.mp3")
    End Sub
    ' #2
    Private Sub ILR2B_Click(sender As Object, e As EventArgs) Handles ILR2B.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio5.mp3")
    End Sub
    ' #3
    Private Sub ILR3B_Click(sender As Object, e As EventArgs) Handles ILR3B.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio20.mp3")
    End Sub
    ' #4
    Private Sub ILR4B_Click(sender As Object, e As EventArgs) Handles ILR4B.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio6.mp3")
    End Sub
    ' #5 
    Private Sub ILR5B_Click(sender As Object, e As EventArgs) Handles ILR5B.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio15.mp3")
    End Sub
    ' #6
    Private Sub ILR6B_Click(sender As Object, e As EventArgs) Handles ILR6B.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio22.mp3")
    End Sub
    ' #7
    Private Sub ILR7B_Click(sender As Object, e As EventArgs) Handles ILR7B.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio12.mp3")
    End Sub
    ' FAVORITEN ====================
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio1.mp3")
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio5.mp3")
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio20.mp3")
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio6.mp3")
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio15.mp3")
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio22.mp3")
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        AxWindowsMediaPlayer1.URL = ("http://stream01.ilovemusic.de/iloveradio12.mp3")
    End Sub
    ' =================================================================================
    Sub Checks()
        Dim fontName As String = "Exo"
        Dim fontSize As Single = 12
        Dim fontTester As New Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel)
        If fontTester.Name = fontName Then ' Font exists

        Else ' Font doesn't exist
            MsgBox("Software wird vorbereitet...", MsgBoxStyle.Information)
        End If
    End Sub
End Class
