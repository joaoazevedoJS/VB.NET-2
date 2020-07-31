<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExemploInterface
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Interface = New System.Windows.Forms.Label()
        Me.Btn_Interface = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Interface
        '
        Me.Lbl_Interface.AutoSize = True
        Me.Lbl_Interface.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_Interface.Name = "Lbl_Interface"
        Me.Lbl_Interface.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Interface.TabIndex = 0
        Me.Lbl_Interface.Text = "Label1"
        '
        'Btn_Interface
        '
        Me.Btn_Interface.Location = New System.Drawing.Point(16, 50)
        Me.Btn_Interface.Name = "Btn_Interface"
        Me.Btn_Interface.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Interface.TabIndex = 1
        Me.Btn_Interface.Text = "Button1"
        Me.Btn_Interface.UseVisualStyleBackColor = True
        '
        'ExemploInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 185)
        Me.Controls.Add(Me.Btn_Interface)
        Me.Controls.Add(Me.Lbl_Interface)
        Me.Name = "ExemploInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Interface As Label
    Friend WithEvents Btn_Interface As Button
End Class
