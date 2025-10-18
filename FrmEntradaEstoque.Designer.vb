<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntradaEstoque
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_RegistrarEntrada = New System.Windows.Forms.Button()
        Me.TX_observacao = New System.Windows.Forms.TextBox()
        Me.TX_QuantidadeEntrada = New System.Windows.Forms.TextBox()
        Me.CB_EnderecoDestino = New System.Windows.Forms.ComboBox()
        Me.CB_Produto = New System.Windows.Forms.ComboBox()
        Me.LB_Observacao = New System.Windows.Forms.Label()
        Me.LB_enderecoDestino = New System.Windows.Forms.Label()
        Me.LB_Quantidade = New System.Windows.Forms.Label()
        Me.LB_Produto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_RegistrarEntrada)
        Me.GroupBox1.Controls.Add(Me.TX_observacao)
        Me.GroupBox1.Controls.Add(Me.TX_QuantidadeEntrada)
        Me.GroupBox1.Controls.Add(Me.CB_EnderecoDestino)
        Me.GroupBox1.Controls.Add(Me.CB_Produto)
        Me.GroupBox1.Controls.Add(Me.LB_Observacao)
        Me.GroupBox1.Controls.Add(Me.LB_enderecoDestino)
        Me.GroupBox1.Controls.Add(Me.LB_Quantidade)
        Me.GroupBox1.Controls.Add(Me.LB_Produto)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BT_RegistrarEntrada
        '
        Me.BT_RegistrarEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RegistrarEntrada.ForeColor = System.Drawing.Color.SteelBlue
        Me.BT_RegistrarEntrada.Location = New System.Drawing.Point(544, 165)
        Me.BT_RegistrarEntrada.Name = "BT_RegistrarEntrada"
        Me.BT_RegistrarEntrada.Size = New System.Drawing.Size(128, 49)
        Me.BT_RegistrarEntrada.TabIndex = 8
        Me.BT_RegistrarEntrada.Text = "Registrar Entrada"
        Me.BT_RegistrarEntrada.UseVisualStyleBackColor = True
        '
        'TX_observacao
        '
        Me.TX_observacao.Location = New System.Drawing.Point(10, 123)
        Me.TX_observacao.Multiline = True
        Me.TX_observacao.Name = "TX_observacao"
        Me.TX_observacao.Size = New System.Drawing.Size(294, 91)
        Me.TX_observacao.TabIndex = 7
        '
        'TX_QuantidadeEntrada
        '
        Me.TX_QuantidadeEntrada.Location = New System.Drawing.Point(157, 37)
        Me.TX_QuantidadeEntrada.Name = "TX_QuantidadeEntrada"
        Me.TX_QuantidadeEntrada.Size = New System.Drawing.Size(47, 20)
        Me.TX_QuantidadeEntrada.TabIndex = 6
        '
        'CB_EnderecoDestino
        '
        Me.CB_EnderecoDestino.FormattingEnabled = True
        Me.CB_EnderecoDestino.Location = New System.Drawing.Point(10, 83)
        Me.CB_EnderecoDestino.Name = "CB_EnderecoDestino"
        Me.CB_EnderecoDestino.Size = New System.Drawing.Size(178, 21)
        Me.CB_EnderecoDestino.TabIndex = 5
        '
        'CB_Produto
        '
        Me.CB_Produto.FormattingEnabled = True
        Me.CB_Produto.Location = New System.Drawing.Point(10, 36)
        Me.CB_Produto.Name = "CB_Produto"
        Me.CB_Produto.Size = New System.Drawing.Size(141, 21)
        Me.CB_Produto.TabIndex = 4
        '
        'LB_Observacao
        '
        Me.LB_Observacao.AutoSize = True
        Me.LB_Observacao.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_Observacao.Location = New System.Drawing.Point(7, 107)
        Me.LB_Observacao.Name = "LB_Observacao"
        Me.LB_Observacao.Size = New System.Drawing.Size(68, 13)
        Me.LB_Observacao.TabIndex = 3
        Me.LB_Observacao.Text = "Observação:"
        '
        'LB_enderecoDestino
        '
        Me.LB_enderecoDestino.AutoSize = True
        Me.LB_enderecoDestino.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_enderecoDestino.Location = New System.Drawing.Point(7, 67)
        Me.LB_enderecoDestino.Name = "LB_enderecoDestino"
        Me.LB_enderecoDestino.Size = New System.Drawing.Size(92, 13)
        Me.LB_enderecoDestino.TabIndex = 2
        Me.LB_enderecoDestino.Text = "Endereço Destino"
        '
        'LB_Quantidade
        '
        Me.LB_Quantidade.AutoSize = True
        Me.LB_Quantidade.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_Quantidade.Location = New System.Drawing.Point(158, 20)
        Me.LB_Quantidade.Name = "LB_Quantidade"
        Me.LB_Quantidade.Size = New System.Drawing.Size(30, 13)
        Me.LB_Quantidade.TabIndex = 1
        Me.LB_Quantidade.Text = "QTD"
        '
        'LB_Produto
        '
        Me.LB_Produto.AutoSize = True
        Me.LB_Produto.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_Produto.Location = New System.Drawing.Point(7, 20)
        Me.LB_Produto.Name = "LB_Produto"
        Me.LB_Produto.Size = New System.Drawing.Size(44, 13)
        Me.LB_Produto.TabIndex = 0
        Me.LB_Produto.Text = "Produto"
        '
        'FrmEntradaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEntradaEstoque"
        Me.Text = "Entrada de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_Observacao As Label
    Friend WithEvents LB_enderecoDestino As Label
    Friend WithEvents LB_Quantidade As Label
    Friend WithEvents LB_Produto As Label
    Friend WithEvents BT_RegistrarEntrada As Button
    Friend WithEvents TX_observacao As TextBox
    Friend WithEvents TX_QuantidadeEntrada As TextBox
    Friend WithEvents CB_EnderecoDestino As ComboBox
    Friend WithEvents CB_Produto As ComboBox
End Class
