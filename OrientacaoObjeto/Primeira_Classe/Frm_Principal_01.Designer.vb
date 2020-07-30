<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal_01
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btn_Acao1 = New System.Windows.Forms.Button()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        Me.Lbl_Incremento = New System.Windows.Forms.Label()
        Me.Txt_Saldo = New System.Windows.Forms.TextBox()
        Me.Txt_Incremento = New System.Windows.Forms.TextBox()
        Me.Btn_Acao2 = New System.Windows.Forms.Button()
        Me.Btn_ValRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Principal.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(130, 51)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Texto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Btn_Acao1
        '
        Me.Btn_Acao1.BackColor = System.Drawing.SystemColors.InfoText
        Me.Btn_Acao1.ForeColor = System.Drawing.SystemColors.Menu
        Me.Btn_Acao1.Location = New System.Drawing.Point(32, 158)
        Me.Btn_Acao1.Name = "Btn_Acao1"
        Me.Btn_Acao1.Size = New System.Drawing.Size(223, 36)
        Me.Btn_Acao1.TabIndex = 1
        Me.Btn_Acao1.Text = "Button1"
        Me.Btn_Acao1.UseVisualStyleBackColor = False
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.AutoSize = True
        Me.Lbl_Saldo.Location = New System.Drawing.Point(18, 104)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Saldo.TabIndex = 2
        Me.Lbl_Saldo.Text = "Label1"
        '
        'Lbl_Incremento
        '
        Me.Lbl_Incremento.AutoSize = True
        Me.Lbl_Incremento.Location = New System.Drawing.Point(173, 104)
        Me.Lbl_Incremento.Name = "Lbl_Incremento"
        Me.Lbl_Incremento.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Incremento.TabIndex = 3
        Me.Lbl_Incremento.Text = "Label2"
        '
        'Txt_Saldo
        '
        Me.Txt_Saldo.Location = New System.Drawing.Point(21, 120)
        Me.Txt_Saldo.Name = "Txt_Saldo"
        Me.Txt_Saldo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Saldo.TabIndex = 4
        '
        'Txt_Incremento
        '
        Me.Txt_Incremento.Location = New System.Drawing.Point(176, 120)
        Me.Txt_Incremento.Name = "Txt_Incremento"
        Me.Txt_Incremento.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Incremento.TabIndex = 5
        '
        'Btn_Acao2
        '
        Me.Btn_Acao2.BackColor = System.Drawing.SystemColors.InfoText
        Me.Btn_Acao2.ForeColor = System.Drawing.SystemColors.Menu
        Me.Btn_Acao2.Location = New System.Drawing.Point(357, 158)
        Me.Btn_Acao2.Name = "Btn_Acao2"
        Me.Btn_Acao2.Size = New System.Drawing.Size(223, 36)
        Me.Btn_Acao2.TabIndex = 7
        Me.Btn_Acao2.Text = "Button1"
        Me.Btn_Acao2.UseVisualStyleBackColor = False
        '
        'Btn_ValRef
        '
        Me.Btn_ValRef.BackColor = System.Drawing.SystemColors.InfoText
        Me.Btn_ValRef.ForeColor = System.Drawing.SystemColors.Menu
        Me.Btn_ValRef.Location = New System.Drawing.Point(186, 222)
        Me.Btn_ValRef.Name = "Btn_ValRef"
        Me.Btn_ValRef.Size = New System.Drawing.Size(223, 36)
        Me.Btn_ValRef.TabIndex = 8
        Me.Btn_ValRef.Text = "Button1"
        Me.Btn_ValRef.UseVisualStyleBackColor = False
        '
        'frm_principal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 295)
        Me.Controls.Add(Me.Btn_ValRef)
        Me.Controls.Add(Me.Btn_Acao2)
        Me.Controls.Add(Me.Txt_Incremento)
        Me.Controls.Add(Me.Txt_Saldo)
        Me.Controls.Add(Me.Lbl_Incremento)
        Me.Controls.Add(Me.Lbl_Saldo)
        Me.Controls.Add(Me.Btn_Acao1)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "frm_principal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conta Corrente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Acao1 As Button
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Lbl_Incremento As Label
    Friend WithEvents Txt_Saldo As TextBox
    Friend WithEvents Txt_Incremento As TextBox
    Friend WithEvents Btn_Acao2 As Button
    Friend WithEvents Btn_ValRef As Button
End Class
