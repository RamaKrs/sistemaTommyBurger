Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        PictureBox5.Visible = True
        Dim s As System.Media.SoundPlayer
        s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/mission passed.wav")
        s.Play()
        Delay(9)
        PrintForm1.Print()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub
End Class