<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GB_Produto = New System.Windows.Forms.GroupBox()
        Me.LB_Nome = New System.Windows.Forms.Label()
        Me.TX_NomeProduto = New System.Windows.Forms.TextBox()
        Me.BT_Cadastrar = New System.Windows.Forms.Button()
        Me.GB_Produto.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Produto
        '
        Me.GB_Produto.Controls.Add(Me.TX_NomeProduto)
        Me.GB_Produto.Controls.Add(Me.LB_Nome)
        Me.GB_Produto.Location = New System.Drawing.Point(10, 21)
        Me.GB_Produto.Name = "GB_Produto"
        Me.GB_Produto.Size = New System.Drawing.Size(403, 77)
        Me.GB_Produto.TabIndex = 0
        Me.GB_Produto.TabStop = False
        Me.GB_Produto.Text = "Cadastro de Produto"
        '
        'LB_Nome
        '
        Me.LB_Nome.AutoSize = True
        Me.LB_Nome.ForeColor = System.Drawing.Color.DarkBlue
        Me.LB_Nome.Location = New System.Drawing.Point(7, 20)
        Me.LB_Nome.Name = "LB_Nome"
        Me.LB_Nome.Size = New System.Drawing.Size(38, 13)
        Me.LB_Nome.TabIndex = 0
        Me.LB_Nome.Text = "Nome:"
        '
        'TX_NomeProduto
        '
        Me.TX_NomeProduto.Location = New System.Drawing.Point(50, 17)
        Me.TX_NomeProduto.Name = "TX_NomeProduto"
        Me.TX_NomeProduto.Size = New System.Drawing.Size(217, 20)
        Me.TX_NomeProduto.TabIndex = 1
        '
        'BT_Cadastrar
        '
        Me.BT_Cadastrar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BT_Cadastrar.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.BT_Cadastrar.Location = New System.Drawing.Point(677, 389)
        Me.BT_Cadastrar.Name = "BT_Cadastrar"
        Me.BT_Cadastrar.Size = New System.Drawing.Size(111, 49)
        Me.BT_Cadastrar.TabIndex = 1
        Me.BT_Cadastrar.Text = "Cadastrar"
        Me.BT_Cadastrar.UseMnemonic = False
        Me.BT_Cadastrar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BT_Cadastrar)
        Me.Controls.Add(Me.GB_Produto)
        Me.Name = "Form1"
        Me.Text = "Cadastro de  Produtos"
        Me.GB_Produto.ResumeLayout(False)
        Me.GB_Produto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_Produto As GroupBox
    Friend WithEvents TX_NomeProduto As TextBox
    Friend WithEvents LB_Nome As Label
    Friend WithEvents BT_Cadastrar As Button
End Class
