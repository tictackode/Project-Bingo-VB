Public Class Bingo
    Public sortNum() As Integer = New Integer(30) {}
    Public sortLetra() As Alfabeto = New Alfabeto(23) {}
    Public cont As Integer = 0
    Enum Alfabeto
        A = 0
        B = 1
        C = 2
        D = 3
        E = 4
        F = 5
        G = 6
        H = 7
        I = 8
        J = 9
        K = 10
        L = 11
        M = 12
        N = 13
        O = 14
        P = 15
        Q = 16
        R = 17
        S = 18
        T = 19
        U = 20
        V = 21
        X = 22
        W = 23
        Y = 24
        Z = 25
    End Enum
    Public Function randomLetra() As Alfabeto
        'gera uma letra randomicamente  
        Dim aux As Alfabeto
        Randomize()
        aux = Int((25 * Rnd()) + 0)
        While (jaSaiuLetra(aux))
            aux = Int((25 * Rnd()) + 0)
        End While
        sortLetra(cont) = aux
        Return aux
    End Function
    Public Function randomNum() As Integer
        ' gera um numero randomicamente
        Randomize()
        Dim aux As Integer = Int((Janela.MAX * Rnd()) + 1)
        While (jaSaiuNumero(aux))
            aux = Int((Janela.MAX * Rnd()) + 1)
        End While
        If (cont < Janela.MAX) Then
            sortNum(cont) = aux
        Else
            aux = -1
        End If

        Return aux
    End Function
    Public Function jaSaiuNumero(ByVal Num As Integer) As Boolean
        ' confere se ha repetição de numero
        Dim cond As Boolean = False
        For i As Integer = 0 To 23
            If sortNum(i) = Num Then
                cond = True
            End If
        Next i
        Return cond
    End Function
    Public Function jaSaiuLetra(ByVal letra As Alfabeto) As Boolean
        ' confere se há repetição de letra
        Dim cond As Boolean = False
        For i As Integer = 0 To 23
            If sortLetra(i) = letra Then
                cond = True
            End If
        Next i
        Return cond
    End Function
    Public Sub zeraArrays()

        For i As Integer = 0 To 23
            sortLetra(i) = Nothing
            sortNum(i) = Nothing
        Next
    End Sub
   
End Class
