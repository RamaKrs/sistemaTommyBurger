Public Class Form2

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub TxtCheese_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCheese.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPay.Click

        If TxtFries.Text = "" Or TxtLettuce.Text = "" Or TxtMayo.Text = "" Or TxtOnion.Text = "" Or TxtTomato.Text = "" Or TxtSoda.Text = "" Or TxtSecret.Text = "" Or TxtBread.Text = "" Or TxtBacon.Text = "" Or TxtCheese.Text = "" Or TxtEgg.Text = "" Or TxtMeat.Text = "" Then
            MsgBox("Rellene los campos vacios", MsgBoxStyle.Critical)

        Else

            Dim IngTot As Integer
            Dim FecAc As String
            Dim NewRec As Integer
            Dim PrecTot As Integer
            Dim Burg As Integer
            Dim Toma As Integer
            Dim Lettu As Integer
            Dim Egg As Integer
            Dim Onion As Integer
            Dim Soda As Integer
            Dim Fries As Integer
            Dim Mayo As Integer
            Dim Secret As Integer
            Dim Bread As Integer
            Dim Bacon As Integer
            Dim Cheese As Integer

            sql = ("SELECT CURDATE()")
            Proc(sql)
            rs.Read()
            FecAc = rs(0)

            'sql = ("INSERT INTO Recibos VALUES('', " & FecAc & ", " & IngTot & ", " & PrecTot & ", " &  & ")") 
            'Proc(sql)
            'El el insert falta poner el codigo hamburguesa

            sql = ("SELECT MAX(NumRecibo) FROM Recibos")
            Proc(sql)
            rs1.Read()
            NewRec = rs1(0)


            Burg = TxtMeat.Text * 150
            Toma = TxtTomato.Text * 30
            Lettu = TxtLettuce.Text * 20
            Egg = TxtEgg.Text * 40
            Onion = TxtOnion.Text * 35
            Soda = TxtSoda.Text * 150
            Fries = TxtFries.Text * 100
            Mayo = TxtMayo.Text * 0
            Secret = TxtSecret.Text * 10
            Bread = TxtBread.Text * 85
            Bacon = TxtBacon.Text * 80
            Cheese = TxtCheese.Text * 60

            PrecTot = Burg + Toma + Lettu + Egg + Onion + Soda + Fries + Mayo + Secret + Bread + Bacon + Cheese

            IngTot = Val(TxtFries.Text) + Val(TxtLettuce.Text) + Val(TxtMayo.Text) + Val(TxtOnion.Text) + Val(TxtTomato.Text) + Val(TxtSoda.Text) + Val(TxtSecret.Text) + Val(TxtBread.Text) + Val(TxtBacon.Text) + Val(TxtCheese.Text) + Val(TxtEgg.Text) + Val(TxtMeat.Text)

            Form4.TxtIng.Text = (IngTot)
            Form4.TxtMonto.Text = (PrecTot)
            Form4.TxtFecha.Text = (FecAc)
            Form4.TxtRecibo.Text = (NewRec)
            'Alguien pregunte porque tira error al pedir que muestre el form 4

            PictureBox3.Visible = True
            Dim s As System.Media.SoundPlayer
            s = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/2DeCarne.wav")
            s.Play()
            Delay(6)
            Form4.Show()
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtMeat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMeat.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLettuce_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLettuce.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTomato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTomato.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtOnion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOnion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEgg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEgg.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtBacon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBacon.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSecret_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSecret.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtMayo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMayo.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSoda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSoda.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtBread_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBread.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtFries_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFries.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class