Public Class ContaCorrente
    Public Titular As String
    Public Agencia As Integer
    Public Conta As Integer
    Public Saldo As Double = 100
    Public Extrato As String = ""

    Public Function Sacar(valorSacar As Double) As Boolean
        If Saldo < valorSacar Then
            Return False
        Else
            Saldo -= valorSacar

            Return True
        End If
    End Function

    Public Function Transferir(valor As Double, ByRef contaDestino As ContaCorrente) As Boolean
        If Saldo < valor Then
            Return False
        Else
            Saldo -= valor
            contaDestino.Depositar(valor)

            Return True
        End If
    End Function

    Public Sub Depositar(valorDepositar As Double)
        Saldo += valorDepositar
    End Sub
End Class