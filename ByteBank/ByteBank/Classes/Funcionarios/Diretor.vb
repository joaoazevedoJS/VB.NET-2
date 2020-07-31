Namespace Classes.Funcionarios

    Public Class Diretor
        Inherits Funcionario

        Public Sub New(_cpf)
            MyBase.New(_cpf)
        End Sub

        ' Overrides == Substitui
        ' Mybase vai pegar os dados da classe Base

        Public Overrides Function GetBonificacao() As Double
            Return salario + MyBase.GetBonificacao()
        End Function
    End Class

End Namespace

