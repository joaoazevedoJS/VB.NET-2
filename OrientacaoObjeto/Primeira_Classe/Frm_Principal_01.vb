Public Class frm_principal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Conta Corrente"
        Lbl_Principal.Text = "Hello World!"

        Btn_Acao1.Text = "Verifique sua Conta Do João Aqui!"
        Btn_Acao2.Text = "Verifique sua Conta Da Ana Aqui!"
        Btn_ValRef.Text = "Clique aqui"

        Lbl_Saldo.Text = "Saldo"
        Lbl_Incremento.Text = "Incremento"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Acao1.Click
        'Dim Titular As String = "João Azevedo"
        'Dim Agencia As Integer = 343
        'Dim Conta As Integer = 863141
        'Dim Saldo As Double = 100

        Dim ContaCorrente1 As New ContaCorrente

        ContaCorrente1.Titular = "João Azevedo"
        ContaCorrente1.Agencia = 343
        ContaCorrente1.Conta = 863141
        ContaCorrente1.Saldo = Val(Txt_Saldo.Text)

        Dim vIncremento As Double = Val(Txt_Incremento.Text)

        MsgBox(
            "Nome do Titular: " + ContaCorrente1.Titular + ". Saldo: R$" + ContaCorrente1.Saldo.ToString,
            MsgBoxStyle.Information,
            "Informação"
       )

        ContaCorrente1.Saldo += vIncremento

        MsgBox(
            "Foi adicionado R$" + vIncremento.ToString + " no seu saldo! Seu saldo atual é de R$" + ContaCorrente1.Saldo.ToString,
            MsgBoxStyle.Information,
            "Saldo Foi Adicionado"
        )
    End Sub

    Private Sub Btn_Acao2_Click(sender As Object, e As EventArgs) Handles Btn_Acao2.Click
        Dim ContaCorrente2 As New ContaCorrente

        ContaCorrente2.Titular = "Ana Maria"

        MsgBox(
            "Nome do Titular: " + ContaCorrente2.Titular + ". Saldo: R$" + ContaCorrente2.Saldo.ToString,
            MsgBoxStyle.Information,
            "Informação"
        )
    End Sub

    Private Sub Btn_ValRef_Click(sender As Object, e As EventArgs) Handles Btn_ValRef.Click
        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox("Valor da Idade: " + idade.ToString + ". Idade 2: " + idade2.ToString)

        idade = 30

        MsgBox("Valor da Idade: " + idade.ToString + ". Idade 2: " + idade2.ToString)

        Dim Conta1 As New ContaCorrente()
        Dim Conta2 As New ContaCorrente()

        Conta1.Titular = "Conta 1"
        Conta1.Agencia = 863
        Conta1.Conta = 863368

        Conta2 = Conta1

        MsgBox("Valor conta1: " + Conta1.Saldo.ToString + " valor da conta2: " + Conta2.Saldo.ToString)

        Conta1.Saldo = 300

        MsgBox("Valor conta1: " + Conta1.Saldo.ToString + " valor da conta2: " + Conta2.Saldo.ToString)
    End Sub
End Class
