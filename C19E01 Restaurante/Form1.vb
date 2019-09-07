Public Class Form1

    Dim entrada As String
    Dim bebida As String
    Dim platoPrincipal As String
    Dim postre As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        elegirEntrada()
    End Sub

    Sub elegirEntrada()
        txtOpciones.Text = "Elija su entrada:"
        ComboBox1.Items.Clear()
        If radioBtnRegular.Checked Then
            ComboBox1.Items.Add("Bastones de mozzarella")
            ComboBox1.Items.Add("Mix de fiambres")
            ComboBox1.Items.Add("Omelette de jamón y queso")
            ComboBox1.SelectedIndex = 0
        ElseIf radioBtnVeg.Checked Then
            ComboBox1.Items.Add("Ensalada rusa")
            ComboBox1.Items.Add("Sopa de vegetales")
            ComboBox1.Items.Add("Champiñoñes a la provenzal")
            ComboBox1.SelectedIndex = 0
        ElseIf radioBtnOtra.Checked Then
            ComboBox1.Items.Add("Rabas")
            ComboBox1.Items.Add("Mejillones a la provenzal")
            ComboBox1.Items.Add("Otra")
            ComboBox1.SelectedIndex = 0
        End If
        ComboBox1.Items.Add("Ninguna")
    End Sub

    Sub elegirBebida()
        txtOpciones.Text = "Elija su bebida:"
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Agua sin gas")
        ComboBox1.Items.Add("Agua con gas")
        ComboBox1.Items.Add("Coca-Cola")
        ComboBox1.Items.Add("Fanta")
        ComboBox1.Items.Add("Sprite")
        ComboBox1.Items.Add("Cerveza Quilmes")
        ComboBox1.SelectedIndex = 0
    End Sub

    Sub elegirPlatoPrincipal()
        txtOpciones.Text = "Elija su plato principal:"
        ComboBox1.Items.Clear()
        If radioBtnRegular.Checked Then
            ComboBox1.Items.Add("Milanesa de carne")
            ComboBox1.Items.Add("Vacío al horno con guarnición")
            ComboBox1.Items.Add("Hamburguesa completa")
            ComboBox1.Items.Add("Pizza grande de mozzarella")
            ComboBox1.Items.Add("Suprema napolitana")
            ComboBox1.SelectedIndex = 0
        ElseIf radioBtnVeg.Checked Then
            ComboBox1.Items.Add("Tarta vegetariana")
            ComboBox1.Items.Add("Ensalada lechuga y tomate")
            ComboBox1.Items.Add("Pizza vegetariana")
            ComboBox1.SelectedIndex = 0
        ElseIf radioBtnOtra.Checked Then
            ComboBox1.Items.Add("Filet de merluza")
            ComboBox1.Items.Add("Tallarines")
            ComboBox1.Items.Add("Ñoquis de papa")
            ComboBox1.SelectedIndex = 0
        End If
        ComboBox1.Items.Add("Platillo especial 1")
        ComboBox1.Items.Add("Platillo especial 2")
        ComboBox1.Items.Add("Ninguno")
        ComboBox1.SelectedIndex = 0
    End Sub

    Sub elegirPostre()
        txtOpciones.Text = "Elija su postre:"
        ComboBox1.Items.Clear()
        If radioBtnRegular.Checked Then
            ComboBox1.Items.Add("Flan casero con dulce de leche")
            ComboBox1.Items.Add("Helado tres sabores")
            ComboBox1.Items.Add("Brownies")
            ComboBox1.SelectedIndex = 0
        ElseIf radioBtnVeg.Checked Then
            ComboBox1.Items.Add("Ensalada de frutas")
            ComboBox1.Items.Add("Postre de vainilla")
            ComboBox1.Items.Add("Manzana crocante")
            ComboBox1.SelectedIndex = 0
        ElseIf radioBtnOtra.Checked Then
            ComboBox1.Items.Add("Lemon Pie")
            ComboBox1.Items.Add("Cheese cake")
            ComboBox1.SelectedIndex = 0
        End If
        ComboBox1.Items.Add("Ninguno")
        ComboBox1.SelectedIndex = 0
    End Sub


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If entrada = "" Then
            entrada = ComboBox1.SelectedItem.ToString
            txtPedido.Text = "Entrada: " & Environment.NewLine & entrada & Environment.NewLine
            elegirBebida()
            btnAtras.Enabled = True
        ElseIf bebida = "" Then
            bebida = ComboBox1.SelectedItem.ToString
            txtPedido.AppendText("Bebida: " & Environment.NewLine & bebida & Environment.NewLine)
            elegirPlatoPrincipal()
        ElseIf platoPrincipal = "" Then
            platoPrincipal = ComboBox1.SelectedItem.ToString
            txtPedido.AppendText("Plato Principal: " & Environment.NewLine & platoPrincipal & Environment.NewLine)
            elegirPostre()
        ElseIf postre = "" Then
            postre = ComboBox1.SelectedItem.ToString
            txtPedido.AppendText("Postre: " & Environment.NewLine & postre & Environment.NewLine)
            btnConfirmarPedido.Enabled = True
        End If

    End Sub

    Private Sub radioBtnRegular_CheckedChanged(sender As Object, e As EventArgs) Handles radioBtnRegular.CheckedChanged, radioBtnVeg.CheckedChanged, radioBtnOtra.CheckedChanged
        If entrada = "" Then
            elegirEntrada()
        ElseIf bebida = "" Then
            elegirBebida()
        ElseIf platoPrincipal = "" Then
            elegirPlatoPrincipal()
        ElseIf postre = "" Then
            elegirPostre()
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim newList As List(Of String) = txtPedido.Lines.ToList
        newList.RemoveAt(newList.Count - 1)
        newList.RemoveAt(newList.Count - 1)
        newList.RemoveAt(newList.Count - 1)
        txtPedido.Lines = newList.ToArray
        If entrada <> "" Then
            txtPedido.AppendText(Environment.NewLine)
        End If

        If postre <> "" Then
            postre = ""
            btnConfirmarPedido.Enabled = False
        ElseIf platoPrincipal <> "" Then
            platoPrincipal = ""
            elegirPlatoPrincipal()
        ElseIf bebida <> "" Then
            bebida = ""
            elegirBebida()
        ElseIf entrada <> "" Then
            entrada = ""
            elegirEntrada()
            btnAtras.Enabled = False
        End If
    End Sub

    Private Sub btnConfirmarPedido_Click(sender As Object, e As EventArgs) Handles btnConfirmarPedido.Click
        MsgBox("¡Pedido realizado con éxito!")
        btnConfirmarPedido.Enabled = False
        txtPedido.Clear()
        elegirEntrada()
    End Sub
End Class
