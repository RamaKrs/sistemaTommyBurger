Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBurger.Click
        PictureBox2.Visible = True
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Lenteja.wav")
        s.Play()
        Delay(5)
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIng.Click
        PictureBox7.Visible = True
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/Lenteja.wav")
        s.Play()
        Delay(5)
        Form3.Show()
    End Sub
End Class
