Imports ByteBank.Classes.Funcionarios
Imports ByteBank.Classes.Bibliotecas

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "ByteBank"
        Lbl_Principal.Text = "Principal"
        Btn_Click.Text = "Clique aqui!"
        Btn_Heranca.Text = "Cliquei no botão e olha no que deu"
        Btn_ClasseBase.Text = "Bonificação [Classe Base]"
    End Sub

    Private Sub Btn_Click_Click(sender As Object, e As EventArgs) Handles Btn_Click.Click
        Dim gerenciadorBonificacao As New GerenciadorBonificacao

        Dim Joao As New Gerente("534.423.343-00")
        Joao.nome = "João Azevedo"
        Joao.salario = 7000
        gerenciadorBonificacao.Registrar(Joao)

        Dim Bia As New Diretor("534.145.343-00")
        Bia.nome = "Bia Caroline"
        Bia.salario = 10000
        gerenciadorBonificacao.Registrar(Bia)

        MsgBox("Salario do " + Joao.nome + " é " + Joao.salario.ToString)
        MsgBox("Bonificação do " + Joao.nome + " é " + Joao.GetBonificacao().ToString)

        MsgBox("Salario da " + Bia.nome + " é " + Bia.salario.ToString)
        MsgBox("Bonificação da " + Bia.nome + " é " + Bia.GetBonificacao().ToString)

        MsgBox("Valor total " + gerenciadorBonificacao.GetBonificacao().ToString, MsgBoxStyle.Information)
    End Sub

    Private Sub Btn_Heranca_Click(sender As Object, e As EventArgs) Handles Btn_Heranca.Click
        Funcionario.ZerarTotal()

        Dim vDiretor As New Diretor("534.425.343-00")
        Dim vFuncionario As New Funcionario("534.445.343-00")
        Dim vDiFun As New Funcionario("534.415.343-00")

        MsgBox("Números de Funcionarios Instanciado atualmente é de " + Funcionario.TotalDeFuncionario().ToString)

        vDiretor.salario = 10000
        vFuncionario.salario = 10000

        vDiFun = vDiretor

        Dim vSaida As String = "A bonificação do diretor é " + vDiretor.GetBonificacao().ToString + vbCrLf
        vSaida += "A bonificação do Funcionario é " + vFuncionario.GetBonificacao().ToString + vbCrLf
        vSaida += "A bonificação do vDiFun é " + vDiFun.GetBonificacao().ToString + vbCrLf

        MsgBox(vSaida)
    End Sub

    Private Sub Btn_ClasseBase_Click(sender As Object, e As EventArgs) Handles Btn_ClasseBase.Click
        Dim vDiretor As New Diretor("534.445.343-30")
        vDiretor.salario = 10000

        MsgBox("A bonificação do diretor é " + vDiretor.GetBonificacao().ToString)
    End Sub
End Class
