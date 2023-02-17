Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.uiMode = "None"
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        Label1.Text = "Volume : " & TrackBar1.Value & ""
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Val(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition) = 0
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Val(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition) - 10
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = Val(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition) + 10
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        Label1.Text = "Volume : " & TrackBar1.Value & ""
    End Sub

    Dim paths As String()
    Dim filenames As String()

    Private Sub btnLoadPlaylist_Click(sender As Object, e As EventArgs) Handles btnLoadPlaylist.Click
        If (OpenFileDialog2.ShowDialog = DialogResult.OK) Then
            filenames = OpenFileDialog2.SafeFileNames
            paths = OpenFileDialog2.FileNames
            For i As Integer = 0 To filenames.Length - 1
                ListBox1.Items.Add(filenames(i))
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = paths(ListBox1.SelectedIndex)
    End Sub
End Class
