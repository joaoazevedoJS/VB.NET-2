Imports _2___ByteBank.ByteBank

Public Class Frm_Principal_02

    Dim ContaDaGabriela As New ContaCorrente
    Dim ContaDoBruno As New ContaCorrente
    'Dim Gabriela As New Cliente()
    Dim Bruno As New Cliente()

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "2 - ByteBank"
        Lbl_Principal_02.Text = "2 - ByteBank"

        ' Inicialização dos textos para Gabriela

        Lbl_Valor_Gabriela.Text = "Valor a ser depositado/sacado"
        Btm_Sacar_Gabriela.Text = "Efetuar Saque"
        Btm_Depositar_Gabriela.Text = "Efetuar Depósito"
        Lbl_Saldo_Gabriela.Text = "Novo Saldo"
        Lbl_Resultado_Gabriela.Text = "Resultado do saque"
        Lbl_SaldoAtual_Gabriela.Text = "Saldo Atual"
        Grp_Gabriela.Text = "Gabriela"
        Btm_Transferir_Gabriela.Text = "Efetuar Transferencia"
        Txt_SaldoAtual_Gabriela.ReadOnly = True
        Txt_Saldo_Gabriela.ReadOnly = True
        Txt_Resultado_Gabriela.ReadOnly = True
        Txt_Extrato_Gabriela.ReadOnly = True
        Lbl_Nome_Gabriela.Text = "Nome"
        Btm_Nome_Gabriela.Text = "..."

        ' Inicialização dos textos para Bruno

        Lbl_Valor_Bruno.Text = "Valor a ser depositado/sacado"
        Btm_Sacar_Bruno.Text = "Efetuar Saque"
        Btm_Depositar_Bruno.Text = "Efetuar Depósito"
        Lbl_Saldo_Bruno.Text = "Novo Saldo"
        Lbl_Resultado_Bruno.Text = "Resultado do saque"
        Lbl_SaldoAtual_Bruno.Text = "Saldo Atual"
        Btm_Transferir_Bruno.Text = "Efetuar Transferencia"
        Grp_Bruno.Text = "Bruno"
        Txt_SaldoAtual_Bruno.ReadOnly = True
        Txt_Saldo_Bruno.ReadOnly = True
        Txt_Resultado_Bruno.ReadOnly = True
        Txt_Extrato_Bruno.ReadOnly = True
        Txt_Extrato_Gabriela.ReadOnly = True
        Lbl_Nome_Bruno.Text = "Nome"
        Btm_Nome_Bruno.Text = "..."

        ' Inicializar os dados da classe da Gabriela

        'Gabriela.Nome = "Gabriela"
        'Gabriela.CPF = "123456789"
        'Gabriela.Profissao = "Analista de Sistemas"
        'Gabriela.Cidade = "Rio de Janeiro"

        'ContaDaGabriela.Titular = Gabriela

        'ContaDaGabriela.Titular = New Cliente()

        ContaDaGabriela.Titular = New Cliente()
        ContaDaGabriela.Titular.Nome = "Gabriela"
        ContaDaGabriela.Titular.CPF = "123456789"
        ContaDaGabriela.Titular.Profissao = "Analista de Sistemas"
        ContaDaGabriela.Titular.Cidade = "Rio de Janeiro"

        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        Lbl_BemVindo_Gabriela.Text = "Bem Vindo " + ContaDaGabriela.Titular.Nome + " Agência: " + ContaDaGabriela.Agencia.ToString +
            " Conta Corrente: " + ContaDaGabriela.Conta.ToString
        Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString

        ' Inicializar os dados da classe do Bruno

        Bruno.Nome = "Bruno"
        Bruno.CPF = "987654321"
        Bruno.Profissao = "Advogado"
        Bruno.Cidade = "São Paulo"

        ContaDoBruno.Titular = Bruno
        ContaDoBruno.Agencia = 863
        ContaDoBruno.Conta = 863224

        Lbl_BemVindo_Bruno.Text = "Bem Vindo " + ContaDoBruno.Titular.Nome + " Agência: " + ContaDoBruno.Agencia.ToString +
            " Conta Corrente: " + ContaDoBruno.Conta.ToString
        Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString

    End Sub

    Private Sub Btm_Depositar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Gabriela.Click

        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Gabriela.Text)
        ContaDaGabriela.Depositar(ValorDepositar)

        Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
        Txt_Resultado_Gabriela.Text = "Depósito efetuado com sucesso"
        Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
        ContaDaGabriela.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString +
                " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
        Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato

    End Sub

    Private Sub Btm_Sacar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoSaque As Boolean = ContaDaGabriela.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Gabriela.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Resultado_Gabriela.Text = "Saque efetuado com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            ContaDaGabriela.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString +
                " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato

        End If
    End Sub

    Private Sub Btm_Transferir_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoTransferencia As Boolean = ContaDaGabriela.Transferir(ValorTransferir, ContaDoBruno)

        If RetornoTransferencia = False Then
            Txt_Resultado_Gabriela.Text = "Transferencia não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            Txt_Resultado_Gabriela.Text = "Transferencia efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato

        End If
    End Sub

    Private Sub Btm_Depositar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Bruno.Text)
        ContaDoBruno.Depositar(ValorDepositar)

        Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString
        Txt_Resultado_Bruno.Text = "Depósito efetuado com sucesso"
        Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text
        ContaDoBruno.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString +
                " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf
        Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub Btm_Sacar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Bruno.Text)
        Dim RetornoSaque As Boolean = ContaDoBruno.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Bruno.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString
            Txt_Resultado_Bruno.Text = "Saque efetuado com sucesso"
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text
            ContaDoBruno.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString +
                " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato

        End If
    End Sub

    Private Sub Btm_Transferir_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Bruno.Text)
        Dim RetornoTransferencia As Boolean = ContaDoBruno.Transferir(ValorTransferir, ContaDaGabriela)

        If RetornoTransferencia = False Then
            Txt_Resultado_Bruno.Text = "Transferencia não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            Txt_Resultado_Bruno.Text = "Transferencia efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato

        End If
    End Sub

    Private Sub Btm_Nome_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Nome_Gabriela.Click

        Dim vNome As String = Txt_Nome_Gabriela.Text
        ContaDaGabriela.Titular.Nome = vNome
        Lbl_BemVindo_Gabriela.Text = "Bem Vindo " + ContaDaGabriela.Titular.Nome + " Agência: " + ContaDaGabriela.Agencia.ToString +
            " Conta Corrente: " + ContaDaGabriela.Conta.ToString


    End Sub

    Private Sub Btm_Nome_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Nome_Bruno.Click
        Dim vNome As String = Txt_Nome_Bruno.Text
        Bruno.Nome = vNome
        Lbl_BemVindo_Bruno.Text = "Bem Vindo " + ContaDoBruno.Titular.Nome + " Agência: " + ContaDoBruno.Agencia.ToString +
           " Conta Corrente: " + ContaDoBruno.Conta.ToString

    End Sub
End Class
