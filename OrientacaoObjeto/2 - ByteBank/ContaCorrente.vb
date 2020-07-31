
Imports _2___ByteBank.ByteBank

Public Class ContaCorrente

#Region "PROPRIEDADES"
    Private m_Extrato As String
    Public Property Extrato As String
        Get
            Return m_Extrato
        End Get
        Set(value As String)
            m_Extrato = value
        End Set
    End Property

    Public Property Conta As Integer
    Public Property Agencia As Integer

    Public m_Titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_Titular
        End Get
        Set(value As Cliente)
            m_Titular = value
        End Set
    End Property

    Private m_Saldo As Double = 100
    Public Property Saldo As Double
        Get
            Return m_Saldo
        End Get
        Set(value As Double)
            If value < 0 Then
                m_Saldo = 0
            Else
                m_Saldo = value
            End If
        End Set
    End Property

#End Region

    Public Function Sacar(ValorSacar As Double) As Boolean

        Dim Retorno As Boolean
        If Saldo < ValorSacar Then
            Retorno = False
        Else
            Saldo -= ValorSacar
            Retorno = True
        End If
        Return Retorno

    End Function

    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean

        Dim Retorno As Boolean
        If Saldo < ValorTransferencia Then
            Retorno = False
        Else
            Saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If
        Return Retorno

    End Function

    Public Sub Depositar(ValorDepositar As Double)

        Saldo += ValorDepositar

    End Sub


End Class




