<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Btn_Click = New System.Windows.Forms.Button()
        Me.Btn_Heranca = New System.Windows.Forms.Button()
        Me.Btn_ClasseBase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btn_Click
        '
        Me.Btn_Click.Location = New System.Drawing.Point(12, 81)
        Me.Btn_Click.Name = "Btn_Click"
        Me.Btn_Click.Size = New System.Drawing.Size(140, 26)
        Me.Btn_Click.TabIndex = 1
        Me.Btn_Click.Text = "Button1"
        Me.Btn_Click.UseVisualStyleBackColor = True
        '
        'Btn_Heranca
        '
        Me.Btn_Heranca.Location = New System.Drawing.Point(176, 81)
        Me.Btn_Heranca.Name = "Btn_Heranca"
        Me.Btn_Heranca.Size = New System.Drawing.Size(219, 26)
        Me.Btn_Heranca.TabIndex = 2
        Me.Btn_Heranca.Text = "Button1"
        Me.Btn_Heranca.UseVisualStyleBackColor = True
        '
        'Btn_ClasseBase
        '
        Me.Btn_ClasseBase.Location = New System.Drawing.Point(12, 114)
        Me.Btn_ClasseBase.Name = "Btn_ClasseBase"
        Me.Btn_ClasseBase.Size = New System.Drawing.Size(140, 22)
        Me.Btn_ClasseBase.TabIndex = 3
        Me.Btn_ClasseBase.Text = "Button1"
        Me.Btn_ClasseBase.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_ClasseBase)
        Me.Controls.Add(Me.Btn_Heranca)
        Me.Controls.Add(Me.Btn_Click)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Click As Button
    Friend WithEvents Btn_Heranca As Button
    Friend WithEvents Btn_ClasseBase As Button
End Class
