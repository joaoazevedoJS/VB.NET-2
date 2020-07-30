Public Class Frm_Principal_02
    Dim ContaCorrente1 As New ContaCorrente
    Dim ContaCorrente2 As New ContaCorrente
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Inicializar dados da classe

        ContaCorrente1.Titular = "João Azevedo"
        ContaCorrente1.Agencia = 863
        ContaCorrente1.Conta = 863410
        ContaCorrente1.Saldo = 150

        ContaCorrente2.Titular = "Ana Paula"
        ContaCorrente2.Agencia =
        ContaCorrente2.Conta = 104368
        ContaCorrente2.Saldo = 245

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Formulario 02"
        Group_Cliente1.Text = ""
        Group_Cliente2.Text = ""

        ' Inicilização  dos textos para cliente 1
        Lbl_Principal_02_C1.Text = ContaCorrente1.Titular

        Lbl_Valor_C1.Text = "Valor"
        Btn_Sacar_C1.Text = "Efetuar Saque"
        Btn_Depositar_C1.Text = "Depositar"
        Btn_Transferir_C1.Text = "Transferir"
        Lbl_Saldo_C1.Text = "Novo Saldo"
        Lbl_Resultado_C1.Text = "Resultado do saque"
        Lbl_SaldoAtual_C1.Text = "Saldo Atual"

        Txt_SaldoAtual_C1.ReadOnly = True
        Txt_Saldo_C1.ReadOnly = True
        Txt_Resultado_C1.ReadOnly = True
        Txt_Extrato_C1.ReadOnly = True

         Txt_SaldoAtual_C1.Text = ContaCorrente1.Saldo.ToString

        ' Inicilização  dos textos para cliente 2

        Lbl_Principal_02_C2.Text = ContaCorrente2.Titular

        Lbl_Valor_C2.Text = "Valor"
        Btn_Sacar_C2.Text = "Efetuar Saque"
        Btn_Depositar_C2.Text = "Depositar"
        Btn_Transferir_C2.Text = "Transferir"
        Lbl_Saldo_C2.Text = "Novo Saldo"
        Lbl_Resultado_C2.Text = "Resultado do saque"
        Lbl_SaldoAtual_C2.Text = "Saldo Atual"

        Txt_SaldoAtual_C2.ReadOnly = True
        Txt_Saldo_C2.ReadOnly = True
        Txt_Resultado_C2.ReadOnly = True
        Txt_Extrato_C2.ReadOnly = True

        Txt_SaldoAtual_C2.Text = ContaCorrente2.Saldo.ToString
    End Sub

    Private Sub Btn_Sacar_Click(sender As Object, e As EventArgs) Handles Btn_Sacar_C1.Click

        Txt_Resultado_C1.Text = ""
        Txt_Saldo_C1.Text = ""

        Dim valorSacar As Double = Val(Txt_Valor_C1.Text)

        Dim Saque As Boolean = ContaCorrente1.Sacar(valorSacar)

        If Saque = False Then
            Txt_Resultado_C1.Text = "Seu saldo não é o suficiente"
        Else
            Txt_Saldo_C1.Text = ContaCorrente1.Saldo.ToString
            Txt_SaldoAtual_C1.Text = ContaCorrente1.Saldo.ToString
            Txt_Resultado_C1.Text = "Saque Efetuado com Sucesso"

            ContaCorrente1.Extrato += Now.ToString +
                " Saque de " + valorSacar.ToString +
                " Saldo " + ContaCorrente1.Saldo.ToString + vbCrLf

            Txt_Extrato_C1.Text = ContaCorrente1.Extrato
        End If
    End Sub

    Private Sub Btn_Depositar_Click(sender As Object, e As EventArgs) Handles Btn_Depositar_C1.Click
        Txt_Resultado_C1.Text = ""
        Txt_Saldo_C1.Text = ""

        Dim valorDepositar As Double = Val(Txt_Valor_C1.Text)

        If valorDepositar > 0 Then
            ContaCorrente1.Depositar(valorDepositar)

            Txt_Resultado_C1.Text = "Depositado com Sucesso"
            Txt_SaldoAtual_C1.Text = ContaCorrente1.Saldo.ToString

            ContaCorrente1.Extrato += Now.ToString +
                " Saque de " + valorDepositar.ToString +
                " Saldo " + ContaCorrente1.Saldo.ToString + vbCrLf

            Txt_Extrato_C1.Text = ContaCorrente1.Extrato
        Else
            Txt_Resultado_C1.Text = "Só Pode efetuar valores acima de R$0"
        End If
    End Sub

    Private Sub Btn_Sacar_C2_Click(sender As Object, e As EventArgs) Handles Btn_Sacar_C2.Click
        Txt_Resultado_C2.Text = ""
        Txt_Saldo_C2.Text = ""

        Dim valorSacar As Double = Val(Txt_Valor_C2.Text)

        Dim Saque As Boolean = ContaCorrente2.Sacar(valorSacar)

        If Saque = False Then
            Txt_Resultado_C2.Text = "Seu saldo não é o suficiente"
        Else
            Txt_Saldo_C2.Text = ContaCorrente2.Saldo.ToString
            Txt_SaldoAtual_C2.Text = ContaCorrente2.Saldo.ToString
            Txt_Resultado_C2.Text = "Saque Efetuado com Sucesso"

            ContaCorrente2.Extrato += Now.ToString +
                " Saque de " + valorSacar.ToString +
                " Saldo " + ContaCorrente2.Saldo.ToString + vbCrLf

            Txt_Extrato_C2.Text = ContaCorrente2.Extrato
        End If
    End Sub

    Private Sub Btn_Depositar_C2_Click(sender As Object, e As EventArgs) Handles Btn_Depositar_C2.Click
        Txt_Resultado_C2.Text = ""
        Txt_Saldo_C2.Text = ""

        Dim valorDepositar As Double = Val(Txt_Valor_C2.Text)

        If valorDepositar > 0 Then
            ContaCorrente2.Depositar(valorDepositar)

            Txt_Resultado_C2.Text = "Depositado com Sucesso"
            Txt_SaldoAtual_C2.Text = ContaCorrente2.Saldo.ToString

            ContaCorrente2.Extrato += Now.ToString +
                " Saque de " + valorDepositar.ToString +
                " Saldo " + ContaCorrente2.Saldo.ToString + vbCrLf

            Txt_Extrato_C2.Text = ContaCorrente2.Extrato
        Else
            Txt_Resultado_C2.Text = "Só Pode efetuar valores acima de R$0"
        End If
    End Sub

    Private Sub Btn_Transferir_C1_Click(sender As Object, e As EventArgs) Handles Btn_Transferir_C1.Click
        Txt_Resultado_C1.Text = ""
        Txt_Saldo_C1.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_C1.Text)
        Dim RetornoTransferir As Boolean = ContaCorrente1.Transferir(ValorTransferir, ContaCorrente2)

        If RetornoTransferir = False Then
            Txt_Resultado_C1.Text = "Seu saldo não é o suficiente"
        Else
            Txt_Saldo_C1.Text = ContaCorrente1.Saldo.ToString
            Txt_Saldo_C2.Text = ContaCorrente2.Saldo.ToString
            Txt_SaldoAtual_C1.Text = ContaCorrente1.Saldo.ToString
            Txt_SaldoAtual_C2.Text = ContaCorrente2.Saldo.ToString

            Txt_Resultado_C1.Text = "Transferido com sucesso"

            ContaCorrente1.Extrato += Now.ToString +
                " Você tranferiu R$" + ValorTransferir.ToString +
                " Saldo Atual R$" + ContaCorrente1.Saldo.ToString + vbCrLf

            ContaCorrente2.Extrato += Now.ToString +
                " Foi transferido R$" + ValorTransferir.ToString +
                " Saldo Atual R$" + ContaCorrente2.Saldo.ToString + vbCrLf

            Txt_Extrato_C1.Text = ContaCorrente1.Extrato
            Txt_Extrato_C2.Text = ContaCorrente2.Extrato
        End If
    End Sub

    Private Sub Btn_Transferir_C2_Click(sender As Object, e As EventArgs) Handles Btn_Transferir_C2.Click
        Txt_Resultado_C2.Text = ""
        Txt_Saldo_C2.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_C2.Text)
        Dim RetornoTransferir As Boolean = ContaCorrente2.Transferir(ValorTransferir, ContaCorrente1)

        If RetornoTransferir = False Then
            Txt_Resultado_C2.Text = "Seu saldo não é o suficiente"
        Else
            Txt_Saldo_C2.Text = ContaCorrente2.Saldo.ToString
            Txt_Saldo_C1.Text = ContaCorrente1.Saldo.ToString
            Txt_SaldoAtual_C2.Text = ContaCorrente2.Saldo.ToString
            Txt_SaldoAtual_C1.Text = ContaCorrente1.Saldo.ToString

            Txt_Resultado_C2.Text = "Transferido com sucesso"

            ContaCorrente2.Extrato += Now.ToString +
                " Você tranferiu R$" + ValorTransferir.ToString +
                " Saldo Atual R$" + ContaCorrente2.Saldo.ToString + vbCrLf

            ContaCorrente1.Extrato += Now.ToString +
                " Foi transferido R$" + ValorTransferir.ToString +
                " Saldo Atual R$" + ContaCorrente1.Saldo.ToString + vbCrLf

            Txt_Extrato_C2.Text = ContaCorrente2.Extrato
            Txt_Extrato_C1.Text = ContaCorrente1.Extrato
        End If
    End Sub
End Class