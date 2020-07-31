Imports ByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas

    Public Class GerenciadorBonificacao
        Private _TotalBonificacao As Double

        Public Sub Registrar(Funcionario As Funcionario)
            _TotalBonificacao += Funcionario.GetBonificacao()
        End Sub

        Public Function GetBonificacao() As Double
            Return _TotalBonificacao
        End Function
    End Class

End Namespace
