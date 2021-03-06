Public Class Bingo
    Public sortNum() As Integer = New Integer(23) {}
    Public sortLetra() As Alfabeto = New Alfabeto(23) {}
    Public cont As Byte = 0
   
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
    Public Sub reset()
        Me.cont = 0
        Dim i As Byte
        For i = 0 To sortNum(i) = Nothing
            sortNum(i) = Nothing
        Next i

        For i = 0 To sortLetra(i) = Nothing
            sortNum(i) = Nothing
        Next i


    End Sub
    Public Function randomLetra() As Alfabeto
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
        Randomize()
        Dim aux As Integer = Int((25 * Rnd()) + 0)
        While (jaSaiuNumero(aux))
            aux = Int((25 * Rnd()) + 0)
        End While
        sortNum(cont) = aux
        Return aux
    End Function
    Public Function jaSaiuNumero(ByVal Num As Integer) As Boolean
        Dim cond As Boolean = False
        Dim i As Byte
        For i = 0 To i = Me.cont + 1
            If sortNum(i) = Num Then
                cond = True
            End If
        Next i
        Return cond
    End Function
    Public Function jaSaiuLetra(ByVal letra As Alfabeto) As Boolean
        Dim cond As Boolean = False
        Dim i As Byte
        For i = 0 To i = Me.cont + 1
            If sortLetra(i) = letra Then
                cond = True
            End If
        Next i
        Return cond
    End Function
End Class
