<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroProduto
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
        Me.TX_ProdutoId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_NomeProduto = New System.Windows.Forms.TextBox()
        Me.LB_Nome = New System.Windows.Forms.Label()
        Me.BT_Salvar = New System.Windows.Forms.Button()
        Me.DG_Produtos = New System.Windows.Forms.DataGridView()
        Me.BT_Limpar = New System.Windows.Forms.Button()
        Me.BT_Excluir = New System.Windows.Forms.Button()
        Me.GB_Produto.SuspendLayout()
        CType(Me.DG_Produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Produto
        '
        Me.GB_Produto.Controls.Add(Me.TX_ProdutoId)
        Me.GB_Produto.Controls.Add(Me.Label1)
        Me.GB_Produto.Controls.Add(Me.TX_NomeProduto)
        Me.GB_Produto.Controls.Add(Me.LB_Nome)
        Me.GB_Produto.Location = New System.Drawing.Point(10, 21)
        Me.GB_Produto.Name = "GB_Produto"
        Me.GB_Produto.Size = New System.Drawing.Size(403, 77)
        Me.GB_Produto.TabIndex = 0
        Me.GB_Produto.TabStop = False
        Me.GB_Produto.Text = "Cadastro de Produto"
        '
        'TX_ProdutoId
        '
        Me.TX_ProdutoId.Enabled = False
        Me.TX_ProdutoId.Location = New System.Drawing.Point(300, 17)
        Me.TX_ProdutoId.Name = "TX_ProdutoId"
        Me.TX_ProdutoId.Size = New System.Drawing.Size(51, 20)
        Me.TX_ProdutoId.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(273, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID:"
        '
        'TX_NomeProduto
        '
        Me.TX_NomeProduto.Location = New System.Drawing.Point(50, 17)
        Me.TX_NomeProduto.Name = "TX_NomeProduto"
        Me.TX_NomeProduto.Size = New System.Drawing.Size(217, 20)
        Me.TX_NomeProduto.TabIndex = 1
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
        'BT_Salvar
        '
        Me.BT_Salvar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BT_Salvar.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.BT_Salvar.Location = New System.Drawing.Point(643, 38)
        Me.BT_Salvar.Name = "BT_Salvar"
        Me.BT_Salvar.Size = New System.Drawing.Size(111, 49)
        Me.BT_Salvar.TabIndex = 1
        Me.BT_Salvar.Text = "Salvar"
        Me.BT_Salvar.UseMnemonic = False
        Me.BT_Salvar.UseVisualStyleBackColor = False
        '
        'DG_Produtos
        '
        Me.DG_Produtos.AllowUserToAddRows = False
        Me.DG_Produtos.AllowUserToDeleteRows = False
        Me.DG_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Produtos.Location = New System.Drawing.Point(10, 218)
        Me.DG_Produtos.Name = "DG_Produtos"
        Me.DG_Produtos.Size = New System.Drawing.Size(778, 220)
        Me.DG_Produtos.TabIndex = 2
        '
        'BT_Limpar
        '
        Me.BT_Limpar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BT_Limpar.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.BT_Limpar.Location = New System.Drawing.Point(657, 93)
        Me.BT_Limpar.Name = "BT_Limpar"
        Me.BT_Limpar.Size = New System.Drawing.Size(83, 32)
        Me.BT_Limpar.TabIndex = 3
        Me.BT_Limpar.Text = "Novo / Limpar"
        Me.BT_Limpar.UseMnemonic = False
        Me.BT_Limpar.UseVisualStyleBackColor = False
        '
        'BT_Excluir
        '
        Me.BT_Excluir.BackColor = System.Drawing.Color.MistyRose
        Me.BT_Excluir.ForeColor = System.Drawing.Color.OrangeRed
        Me.BT_Excluir.Location = New System.Drawing.Point(10, 189)
        Me.BT_Excluir.Name = "BT_Excluir"
        Me.BT_Excluir.Size = New System.Drawing.Size(80, 23)
        Me.BT_Excluir.TabIndex = 4
        Me.BT_Excluir.Text = "Excluir"
        Me.BT_Excluir.UseMnemonic = False
        Me.BT_Excluir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BT_Excluir)
        Me.Controls.Add(Me.BT_Limpar)
        Me.Controls.Add(Me.DG_Produtos)
        Me.Controls.Add(Me.BT_Salvar)
        Me.Controls.Add(Me.GB_Produto)
        Me.Name = "Form1"
        Me.Text = "Cadastro de  Produtos"
        Me.GB_Produto.ResumeLayout(False)
        Me.GB_Produto.PerformLayout()
        CType(Me.DG_Produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_Produto As GroupBox
    Friend WithEvents TX_NomeProduto As TextBox
    Friend WithEvents LB_Nome As Label
    Friend WithEvents BT_Salvar As Button
    Friend WithEvents DG_Produtos As DataGridView
    Friend WithEvents TX_ProdutoId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_Limpar As Button
    Friend WithEvents BT_Excluir As Button
End Class
