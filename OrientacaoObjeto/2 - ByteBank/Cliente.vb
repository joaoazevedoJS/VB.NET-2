

Namespace ByteBank

    Public Class Cliente

#Region "PROPRIEDADES"

        Private m_Nome As String
        Public Property Nome As String
            Get
                Return m_Nome
            End Get
            Set(value As String)
                m_Nome = value
            End Set
        End Property

        Private m_CPF As String
        Public Property CPF As String
            Get
                Return m_CPF
            End Get
            Set(value As String)
                m_CPF = TestaCPF(value)
            End Set
        End Property

        Public Property Profissao As String
        Public Property Cidade As String

#End Region

#Region "FUNÇÕES ESPECIAIS"
        Private Function TestaCPF(CPF As String) As String
            Dim dadosArray() As String = {"11111111111", "22222222222", "33333333333", "44444444444",
            "55555555555", "66666666666", "77777777777", "88888888888", "99999999999"}
            Dim vResultado As Boolean = True
            Dim i, x, n1, n2 As Integer
            CPF = CPF.Trim
            For i = 0 To dadosArray.Length - 1
                If CPF.Length <> 11 Or dadosArray(i).Equals(CPF) Then
                    vResultado = False
                End If
            Next
            If vResultado = False Then
                Return "00000000000"
            Else
                For x = 0 To 1
                    n1 = 0
                    For i = 0 To 8 + x
                        n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
                    Next
                    n2 = 11 - (n1 - (Int(n1 / 11) * 11))
                    If n2 = 10 Or n2 = 11 Then n2 = 0
                    If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                        vResultado = False
                        Exit For
                    End If
                Next
                If vResultado = False Then
                    Return "00000000000"
                End If
            End If
            Return CPF
        End Function
#End Region

    End Class

End Namespace



