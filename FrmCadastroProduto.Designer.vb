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
        Me.TX_Preco = New System.Windows.Forms.TextBox()
        Me.LB_Preço = New System.Windows.Forms.Label()
        Me.TX_QTD = New System.Windows.Forms.TextBox()
        Me.LB_Quantidadde = New System.Windows.Forms.Label()
        Me.TX_ProdutoId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_NomeProduto = New System.Windows.Forms.TextBox()
        Me.LB_Nome = New System.Windows.Forms.Label()
        Me.BT_Salvar = New System.Windows.Forms.Button()
        Me.DG_Produtos = New System.Windows.Forms.DataGridView()
        Me.BT_Limpar = New System.Windows.Forms.Button()
        Me.BT_Excluir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_apto = New System.Windows.Forms.Label()
        Me.CB_apto = New System.Windows.Forms.ComboBox()
        Me.LB_nivel = New System.Windows.Forms.Label()
        Me.CB_nivel = New System.Windows.Forms.ComboBox()
        Me.LB_modulo = New System.Windows.Forms.Label()
        Me.CB_modulo = New System.Windows.Forms.ComboBox()
        Me.LB_Rua = New System.Windows.Forms.Label()
        Me.CB_Rua = New System.Windows.Forms.ComboBox()
        Me.GB_Produto.SuspendLayout()
        CType(Me.DG_Produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Produto
        '
        Me.GB_Produto.Controls.Add(Me.TX_Preco)
        Me.GB_Produto.Controls.Add(Me.LB_Preço)
        Me.GB_Produto.Controls.Add(Me.TX_QTD)
        Me.GB_Produto.Controls.Add(Me.LB_Quantidadde)
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
        'TX_Preco
        '
        Me.TX_Preco.Location = New System.Drawing.Point(170, 48)
        Me.TX_Preco.Name = "TX_Preco"
        Me.TX_Preco.Size = New System.Drawing.Size(60, 20)
        Me.TX_Preco.TabIndex = 7
        '
        'LB_Preço
        '
        Me.LB_Preço.AutoSize = True
        Me.LB_Preço.ForeColor = System.Drawing.Color.DarkBlue
        Me.LB_Preço.Location = New System.Drawing.Point(126, 48)
        Me.LB_Preço.Name = "LB_Preço"
        Me.LB_Preço.Size = New System.Drawing.Size(38, 13)
        Me.LB_Preço.TabIndex = 6
        Me.LB_Preço.Text = "Preço:"
        Me.LB_Preço.UseMnemonic = False
        '
        'TX_QTD
        '
        Me.TX_QTD.Location = New System.Drawing.Point(50, 45)
        Me.TX_QTD.Name = "TX_QTD"
        Me.TX_QTD.Size = New System.Drawing.Size(60, 20)
        Me.TX_QTD.TabIndex = 5
        '
        'LB_Quantidadde
        '
        Me.LB_Quantidadde.AutoSize = True
        Me.LB_Quantidadde.ForeColor = System.Drawing.Color.DarkBlue
        Me.LB_Quantidadde.Location = New System.Drawing.Point(6, 48)
        Me.LB_Quantidadde.Name = "LB_Quantidadde"
        Me.LB_Quantidadde.Size = New System.Drawing.Size(33, 13)
        Me.LB_Quantidadde.TabIndex = 4
        Me.LB_Quantidadde.Text = "QTD:"
        Me.LB_Quantidadde.UseMnemonic = False
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
        Me.BT_Salvar.Location = New System.Drawing.Point(571, 180)
        Me.BT_Salvar.Name = "BT_Salvar"
        Me.BT_Salvar.Size = New System.Drawing.Size(69, 25)
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
        Me.BT_Limpar.Location = New System.Drawing.Point(715, 180)
        Me.BT_Limpar.Name = "BT_Limpar"
        Me.BT_Limpar.Size = New System.Drawing.Size(65, 24)
        Me.BT_Limpar.TabIndex = 3
        Me.BT_Limpar.Text = "Novo"
        Me.BT_Limpar.UseMnemonic = False
        Me.BT_Limpar.UseVisualStyleBackColor = False
        '
        'BT_Excluir
        '
        Me.BT_Excluir.BackColor = System.Drawing.Color.MistyRose
        Me.BT_Excluir.ForeColor = System.Drawing.Color.OrangeRed
        Me.BT_Excluir.Location = New System.Drawing.Point(646, 181)
        Me.BT_Excluir.Name = "BT_Excluir"
        Me.BT_Excluir.Size = New System.Drawing.Size(63, 23)
        Me.BT_Excluir.TabIndex = 4
        Me.BT_Excluir.Text = "Excluir"
        Me.BT_Excluir.UseMnemonic = False
        Me.BT_Excluir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_apto)
        Me.GroupBox1.Controls.Add(Me.CB_apto)
        Me.GroupBox1.Controls.Add(Me.LB_nivel)
        Me.GroupBox1.Controls.Add(Me.CB_nivel)
        Me.GroupBox1.Controls.Add(Me.LB_modulo)
        Me.GroupBox1.Controls.Add(Me.CB_modulo)
        Me.GroupBox1.Controls.Add(Me.LB_Rua)
        Me.GroupBox1.Controls.Add(Me.CB_Rua)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 78)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endereço Estoque"
        '
        'LB_apto
        '
        Me.LB_apto.AutoSize = True
        Me.LB_apto.ForeColor = System.Drawing.Color.DarkBlue
        Me.LB_apto.Location = New System.Drawing.Point(195, 35)
        Me.LB_apto.Name = "LB_apto"
        Me.LB_apto.Size = New System.Drawing.Size(32, 13)
        Me.LB_apto.TabIndex = 14
        Me.LB_apto.Text = "Apto:"
        Me.LB_apto.UseMnemonic = False
        '
        'CB_apto
        '
        Me.CB_apto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_apto.FormattingEnabled = True
        Me.CB_apto.Location = New System.Drawing.Point(193, 51)
        Me.CB_apto.Name = "CB_apto"
        Me.CB_apto.Size = New System.Drawing.Size(55, 21)
        Me.CB_apto.TabIndex = 13
        '
        'LB_nivel
        '
        Me.LB_nivel.AutoSize = True
        Me.LB_nivel.ForeColor = System.Drawing.Color.DarkBlue
        Me.LB_nivel.Location = New System.Drawing.Point(134, 35)
        Me.LB_nivel.Name = "LB_nivel"
        Me.LB_nivel.Size = New System.Drawing.Size(36, 13)
        Me.LB_nivel.TabIndex = 12
        Me.LB_nivel.Text = "Nível:"
        Me.LB_nivel.UseMnemonic = False
        '
        'CB_nivel
        '
        Me.CB_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_nivel.FormattingEnabled = True
        Me.CB_nivel.Location = New System.Drawing.Point(132, 51)
        Me.CB_nivel.Name = "CB_nivel"
        Me.CB_nivel.Size = New System.Drawing.Size(55, 21)
        Me.CB_nivel.TabIndex = 11
        '
        'LB_modulo
        '
        Me.LB_modulo.AutoSize = True
        Me.LB_modulo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LB_modulo.Location = New System.Drawing.Point(73, 35)
        Me.LB_modulo.Name = "LB_modulo"
        Me.LB_modulo.Size = New System.Drawing.Size(45, 13)
        Me.LB_modulo.TabIndex = 10
        Me.LB_modulo.Text = "Módulo:"
        Me.LB_modulo.UseMnemonic = False
        '
        'CB_modulo
        '
        Me.CB_modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_modulo.FormattingEnabled = True
        Me.CB_modulo.Location = New System.Drawing.Point(71, 51)
        Me.CB_modulo.Name = "CB_modulo"
        Me.CB_modulo.Size = New System.Drawing.Size(55, 21)
        Me.CB_modulo.TabIndex = 9
        '
        'LB_Rua
        '
        Me.LB_Rua.AutoSize = True
        Me.LB_Rua.ForeColor = System.Drawing.Color.DarkBlue
        Me.LB_Rua.Location = New System.Drawing.Point(12, 35)
        Me.LB_Rua.Name = "LB_Rua"
        Me.LB_Rua.Size = New System.Drawing.Size(27, 13)
        Me.LB_Rua.TabIndex = 8
        Me.LB_Rua.Text = "Rua"
        Me.LB_Rua.UseMnemonic = False
        '
        'CB_Rua
        '
        Me.CB_Rua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Rua.FormattingEnabled = True
        Me.CB_Rua.Location = New System.Drawing.Point(10, 51)
        Me.CB_Rua.Name = "CB_Rua"
        Me.CB_Rua.Size = New System.Drawing.Size(55, 21)
        Me.CB_Rua.TabIndex = 0
        '
        'FrmCadastroProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BT_Excluir)
        Me.Controls.Add(Me.BT_Limpar)
        Me.Controls.Add(Me.DG_Produtos)
        Me.Controls.Add(Me.BT_Salvar)
        Me.Controls.Add(Me.GB_Produto)
        Me.Name = "FrmCadastroProduto"
        Me.Text = "Cadastro de  Produtos"
        Me.GB_Produto.ResumeLayout(False)
        Me.GB_Produto.PerformLayout()
        CType(Me.DG_Produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents TX_QTD As TextBox
    Friend WithEvents LB_Quantidadde As Label
    Friend WithEvents LB_Preço As Label
    Friend WithEvents TX_Preco As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_Rua As ComboBox
    Friend WithEvents LB_Rua As Label
    Friend WithEvents LB_apto As Label
    Friend WithEvents CB_apto As ComboBox
    Friend WithEvents LB_nivel As Label
    Friend WithEvents CB_nivel As ComboBox
    Friend WithEvents LB_modulo As Label
    Friend WithEvents CB_modulo As ComboBox
End Class
