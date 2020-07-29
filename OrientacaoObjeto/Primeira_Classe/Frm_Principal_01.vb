Public Class frm_principal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Primeira Classe"
        Lbl_Principal.Text = "Hello World!"
        Btn_Acao.Text = "Clique aqui!"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Acao.Click
        Dim Titular As String = "João Azevedo"
        Dim Agencia As Integer = 343
        Dim Conta As Integer = 863141
        Dim Saldo As Double = 100
    End Sub
End Class
