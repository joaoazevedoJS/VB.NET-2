Namespace Classes.Funcionarios

    Public Class Funcionario
        Public Property nome As String
        Public Property salario As Double

        Private m_CPF As String

        Public ReadOnly Property CPF As String
            Get
                Return m_CPF
            End Get
        End Property

        Private Shared m_TotalDeFuncionario As Integer

        Public Sub New(_CPF As String)
            m_CPF = _CPF
            m_TotalDeFuncionario += 1
        End Sub

        Public Shared ReadOnly Property TotalDeFuncionario() As Integer
            Get
                Return m_TotalDeFuncionario
            End Get
        End Property

        Public Shared Sub ZerarTotal()
            m_TotalDeFuncionario = 0
        End Sub

        ' Overridable == Substituivel

        Public Overridable Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
    End Class

End Namespace