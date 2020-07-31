Public Class ExemploInterface
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Exemplo de Interface"
        Btn_Interface.Text = "Clique aqui!"
    End Sub

    Private Sub Btn_Interface_Click(sender As Object, e As EventArgs) Handles Btn_Interface.Click
        Dim vK As New Imovel

        MsgBox(vK.AbrirPorta(New Casa))
        MsgBox(vK.AbrirPorta(New Predio))
    End Sub
End Class
