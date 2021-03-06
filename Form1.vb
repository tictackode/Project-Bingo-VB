
Public Class Janela
    Public b As Bingo
    Public arrayL() As Label = New Label(48) {}
    Public arrayCartela() As Label = New Label(5) {}
    Public Shared MAX As Integer
    Public bingo As Image = Image.FromFile("bingo.bmp")
    Public backbingo As Image = Image.FromFile("backbingo.bmp")
    Public bmp As Bitmap = New Bitmap("bingo.bmp")

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim bingo As Bingo = New Bingo
        bmp.MakeTransparent(Color.White)
        Me.b = bingo
        Me.initLabels()
        Me.zeraLabels()
        Me.BackColor = Color.DarkGreen
        Me.Update()
        Me.btnNumero.Hide()
        Me.btnLetra.Hide()
    End Sub
    Public Sub initLabels()
        arrayL(0) = lb1
        arrayL(1) = lb2
        arrayL(2) = lb3
        arrayL(3) = lb4
        arrayL(4) = lb5
        arrayL(5) = lb6
        arrayL(6) = lb7
        arrayL(7) = lb8
        arrayL(8) = lb9
        arrayL(9) = lb10
        arrayL(10) = lb11
        arrayL(11) = lb12
        arrayL(12) = lb13
        arrayL(13) = lb14
        arrayL(14) = lb15
        arrayL(15) = lb16
        arrayL(16) = lb17
        arrayL(17) = lb18
        arrayL(18) = lb19
        arrayL(19) = lb20
        arrayL(20) = lb21
        arrayL(21) = lb22
        arrayL(22) = lb23
        arrayL(23) = lb24
        arrayL(24) = lb25
        arrayL(25) = lb26
        arrayL(26) = lb27
        arrayL(27) = lb28
        arrayL(28) = lb29
        arrayL(29) = lb30
        arrayL(30) = lb31
        arrayL(31) = lb32
        arrayL(32) = lb33
        arrayL(33) = lb34
        arrayL(34) = lb35
        arrayL(35) = lb36
        arrayL(36) = lb37
        arrayL(37) = lb38
        arrayL(38) = lb39
        arrayL(39) = lb40
        arrayL(40) = lb41
        arrayL(41) = lb42
        arrayL(42) = lb43
        arrayL(43) = lb44
        arrayL(44) = lb45
        arrayL(45) = lb46
        arrayL(46) = lb47
        arrayL(47) = lb48


        arrayCartela(0) = p1
        arrayCartela(1) = p2
        arrayCartela(2) = p3
        arrayCartela(3) = p4
        arrayCartela(4) = p5
        arrayCartela(5) = p6

    End Sub
    Public Sub zeraLabels()
        For i As Integer = 0 To 47
            arrayL(i).Text = " "
            arrayL(i).BackgroundImage = Nothing
            arrayL(i).BackColor = Color.Transparent
            arrayL(i).Update()
        Next

        For i As Integer = 0 To 5
            arrayCartela(i).Text = " "
            arrayCartela(i).BackColor = Color.Transparent
            arrayCartela(i).BorderStyle = BorderStyle.None
        Next
        Me.Update()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLetra.Click
        Me.confereBingo()
      
        If (Me.b.cont = 24) Then
            Me.perdeu()
        Else
            arrayL(Me.b.cont).Text = Me.b.randomLetra().ToString()
            arrayL(Me.b.cont).TextAlign = ContentAlignment.MiddleCenter
            arrayL(Me.b.cont).BackgroundImage = bmp
            arrayL(Me.b.cont).Update()
        End If
            Dim x As Char = arrayL(Me.b.cont).Text
            Me.confereCartela(x)

        Me.b.cont += 1
       
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles menuNumeros.Click
        Me.reiniciar()
        Me.btnNumero.Show()
        Janela.MAX = -1
        Dim b As Boolean = False
        Dim aux As String = ""
        While (b = False)
            While aux = ""
                aux = InputBox("O seu bingo irá do número 1 até o...?", "Escolha Seu bingo!", 30, 300, 300).ToString()
            End While
            Janela.MAX = Int(aux)
            If (Int(Janela.MAX) > 1 And Int(Janela.MAX) <= 48) Then
                b = True
            End If
        End While
        ' Array.Resize( b.sortNum As Integer, Janela.MAX)

        ReDim Me.b.sortNum(Janela.MAX)    ' redimensionando o array
        Me.cartelaNum()
    End Sub

    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btnNumero.Click

        Dim x As Integer = Me.b.randomNum()
        '  If (Me.b.cont) >= 24 Then
        'MsgBox("Fim!")
        '  Else
        If (Me.b.cont = Janela.MAX) Then
            Me.perdeu()
        Else
            arrayL(Me.b.cont).Text = x.ToString()
            arrayL(Me.b.cont).TextAlign = ContentAlignment.MiddleCenter
            arrayL(Me.b.cont).BackgroundImage = bmp
            arrayL(Me.b.cont).Update()
        End If
        Me.confereBingo()
        Me.confereCartelaNumero(x)

        Me.b.cont += 1
        If Me.b.cont >= Janela.MAX Then
            perdeu()
        End If
    End Sub

    Private Sub SorteiaLetrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SorteiaLetrasToolStripMenuItem.Click
        Me.reiniciar()
        Me.btnLetra.Show()
        Me.cartelaLetra()
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        Me.reiniciar()
    End Sub
    Public Function randNum()
        Dim aux As Integer = Me.b.randomNum()
        If aux = -1 Then
            perdeu()
        End If
        Return aux
    End Function
    Public Sub cartelaNum()
        fundoCartela()
        p1.Text = Me.randNum()
        p2.Text = Me.randNum()
        p3.Text = Me.randNum()
        p4.Text = Me.randNum()
        p5.Text = Me.randNum()
        p6.Text = Me.randNum()
        Me.b.zeraArrays()

        arrayCartela(0) = p1
        arrayCartela(1) = p2
        arrayCartela(2) = p3
        arrayCartela(3) = p4
        arrayCartela(4) = p5
        arrayCartela(5) = p6

    End Sub
    Public Sub cartelaLetra()
        fundoCartela()
        p1.Text = Me.b.randomLetra().ToString()
        p2.Text = Me.b.randomLetra().ToString()
        p3.Text = Me.b.randomLetra().ToString()
        p4.Text = Me.b.randomLetra().ToString()
        p5.Text = Me.b.randomLetra().ToString()
        p6.Text = Me.b.randomLetra().ToString()
        Me.b.zeraArrays()

        arrayCartela(0) = p1
        arrayCartela(1) = p2
        arrayCartela(2) = p3
        arrayCartela(3) = p4
        arrayCartela(4) = p5
        arrayCartela(5) = p6

        For i As Integer = 0 To 5
            arrayCartela(i).TextAlign = ContentAlignment.MiddleCenter
            arrayCartela(i).Update()
        Next


    End Sub
    Public Sub fundoCartela()
        For i As Integer = 0 To 5
            arrayCartela(i).BackColor = Color.AntiqueWhite
            arrayCartela(i).BorderStyle = BorderStyle.Fixed3D
        Next
    End Sub
    Public Sub apagaCartela()
        For i As Integer = 0 To 5
            arrayCartela(i).BackColor = Color.Transparent
            arrayCartela(i).BorderStyle = BorderStyle.None

        Next
    End Sub
    Public Sub confereCartela(ByVal num As Char)

        For i As Integer = 0 To 5
            If num = arrayCartela(i).Text Then
                arrayCartela(i).BackColor = Color.Red
                arrayCartela(i).Update()
            End If
        Next
    End Sub
    Public Sub confereCartelaNumero(ByVal num As Integer)
        Dim x As Integer = 0
        For i As Integer = 0 To 5
            If (arrayCartela(i).Text <> " ") Then
                x = CInt(arrayCartela(i).Text)
            End If
            If num = x Then
                arrayCartela(i).BackColor = Color.Red
                arrayCartela(i).Update()
            End If
        Next
    End Sub
    Public Sub confereBingo()
        Dim aux As Byte = 0
        For i As Integer = 0 To 5
            If arrayCartela(i).BackColor = Color.Red Then
                aux += 1
            End If
        Next
        If aux = 5 Then
            Me.BackgroundImage = backbingo
            Me.btnNumero.Hide()
            Me.btnLetra.Hide()
            Me.zeraLabels()
            Me.Update()
            Me.lbBingo.Text = "Bingo!"
            Me.lbBingo.BackColor = Color.Transparent
            Me.lbBingo.Update()



        End If
    End Sub
    Public Sub perdeu()
        ' colocar essa funcao quando cont chegar a 24
        Me.btnNumero.Hide()
        Me.btnLetra.Hide()
        Me.zeraLabels()
        Me.Update()
        Me.lbBingo.Text = "Você Perdeu!"
        Me.lbBingo.BackColor = Color.Transparent
        Me.lbBingo.Update()
    End Sub
    Public Sub reiniciar()
        Me.BackColor = Color.DarkGreen
        Me.BackgroundImage = Nothing
        Me.lbBingo.Hide()
        apagaCartela()
        Me.btnLetra.Hide()
        Me.btnNumero.Hide()
        Me.b.cont = 0
        Me.zeraLabels()
    End Sub

   
End Class
