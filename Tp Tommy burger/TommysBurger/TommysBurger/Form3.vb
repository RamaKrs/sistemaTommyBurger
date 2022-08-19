Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub btnPedirProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedirProveedor.Click
        Dim nombre As String
        If RadioButton1.Checked Then
            nombre = "Hamburguesa"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton2.Checked Then
            nombre = "Lechuga"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton3.Checked Then
            nombre = "Tomate"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton4.Checked Then
            nombre = "Cebolla"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton5.Checked Then
            nombre = "Huevo"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton6.Checked Then
            nombre = "Panceta"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton7.Checked Then
            nombre = "Queso"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton8.Checked Then
            nombre = "Salsa Secreta"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton9.Checked Then
            nombre = "Aderezos"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton10.Checked Then
            nombre = "Bebida"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
        If RadioButton11.Checked Then
            nombre = "Pan"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)

        End If
        If RadioButton12.Checked Then
            nombre = "Papas"
            sql = ("INSERT INTO detallePedidos values('', " & txtCantidadPedido.Text & ", (select codIngre from ingredientes where nombre = '" & nombre & "'), (select nroProv FROM proveedores ORDER BY RAND() LIMIT 1))")
            Proc(sql)
        End If
    End Sub
End Class

