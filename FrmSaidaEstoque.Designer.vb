<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaidaEstoque
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
        Me.GB_saida = New System.Windows.Forms.GroupBox()
        Me.Bt_regsaida = New System.Windows.Forms.Button()
        Me.LB_OBS = New System.Windows.Forms.Label()
        Me.TX_Observacao = New System.Windows.Forms.TextBox()
        Me.TX_QTD = New System.Windows.Forms.TextBox()
        Me.LB_QTD = New System.Windows.Forms.Label()
        Me.CB_Produto = New System.Windows.Forms.ComboBox()
        Me.LB_produto = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GB_saida.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_saida
        '
        Me.GB_saida.Controls.Add(Me.Bt_regsaida)
        Me.GB_saida.Controls.Add(Me.LB_OBS)
        Me.GB_saida.Controls.Add(Me.TX_Observacao)
        Me.GB_saida.Controls.Add(Me.TX_QTD)
        Me.GB_saida.Controls.Add(Me.LB_QTD)
        Me.GB_saida.Controls.Add(Me.CB_Produto)
        Me.GB_saida.Controls.Add(Me.LB_produto)
        Me.GB_saida.Location = New System.Drawing.Point(19, 17)
        Me.GB_saida.Name = "GB_saida"
        Me.GB_saida.Size = New System.Drawing.Size(577, 235)
        Me.GB_saida.TabIndex = 0
        Me.GB_saida.TabStop = False
        Me.GB_saida.Text = "Saida de Produtos"
        '
        'Bt_regsaida
        '
        Me.Bt_regsaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_regsaida.ForeColor = System.Drawing.Color.SteelBlue
        Me.Bt_regsaida.Location = New System.Drawing.Point(469, 185)
        Me.Bt_regsaida.Name = "Bt_regsaida"
        Me.Bt_regsaida.Size = New System.Drawing.Size(102, 44)
        Me.Bt_regsaida.TabIndex = 6
        Me.Bt_regsaida.Text = "Registrar Saida"
        Me.Bt_regsaida.UseVisualStyleBackColor = True
        '
        'LB_OBS
        '
        Me.LB_OBS.AutoSize = True
        Me.LB_OBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_OBS.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_OBS.Location = New System.Drawing.Point(7, 130)
        Me.LB_OBS.Name = "LB_OBS"
        Me.LB_OBS.Size = New System.Drawing.Size(75, 13)
        Me.LB_OBS.TabIndex = 5
        Me.LB_OBS.Text = "Observação"
        '
        'TX_Observacao
        '
        Me.TX_Observacao.Location = New System.Drawing.Point(10, 146)
        Me.TX_Observacao.Multiline = True
        Me.TX_Observacao.Name = "TX_Observacao"
        Me.TX_Observacao.Size = New System.Drawing.Size(370, 75)
        Me.TX_Observacao.TabIndex = 4
        '
        'TX_QTD
        '
        Me.TX_QTD.Location = New System.Drawing.Point(145, 46)
        Me.TX_QTD.Name = "TX_QTD"
        Me.TX_QTD.Size = New System.Drawing.Size(34, 20)
        Me.TX_QTD.TabIndex = 3
        '
        'LB_QTD
        '
        Me.LB_QTD.AutoSize = True
        Me.LB_QTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_QTD.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_QTD.Location = New System.Drawing.Point(142, 29)
        Me.LB_QTD.Name = "LB_QTD"
        Me.LB_QTD.Size = New System.Drawing.Size(37, 13)
        Me.LB_QTD.TabIndex = 2
        Me.LB_QTD.Text = "QTD:"
        '
        'CB_Produto
        '
        Me.CB_Produto.FormattingEnabled = True
        Me.CB_Produto.Location = New System.Drawing.Point(10, 46)
        Me.CB_Produto.Name = "CB_Produto"
        Me.CB_Produto.Size = New System.Drawing.Size(121, 21)
        Me.CB_Produto.TabIndex = 1
        '
        'LB_produto
        '
        Me.LB_produto.AutoSize = True
        Me.LB_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_produto.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_produto.Location = New System.Drawing.Point(7, 29)
        Me.LB_produto.Name = "LB_produto"
        Me.LB_produto.Size = New System.Drawing.Size(51, 13)
        Me.LB_produto.TabIndex = 0
        Me.LB_produto.Text = "Produto"
        '
        'FrmSaidaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GB_saida)
        Me.Name = "FrmSaidaEstoque"
        Me.Text = "FrmSaidaEstoque"
        Me.GB_saida.ResumeLayout(False)
        Me.GB_saida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_saida As GroupBox
    Friend WithEvents LB_produto As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Bt_regsaida As Button
    Friend WithEvents LB_OBS As Label
    Friend WithEvents TX_Observacao As TextBox
    Friend WithEvents TX_QTD As TextBox
    Friend WithEvents LB_QTD As Label
    Friend WithEvents CB_Produto As ComboBox
End Class
