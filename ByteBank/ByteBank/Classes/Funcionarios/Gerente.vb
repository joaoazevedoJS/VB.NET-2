Namespace Classes.Funcionarios

    Public Class Gerente
        Inherits Funcionario

        Public Sub New(_cpf)
            MyBase.New(_cpf)
        End Sub

        Public Overrides Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
    End Class

End Namespace