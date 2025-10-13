<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroCategoria
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
        Me.Cadastro = New System.Windows.Forms.GroupBox()
        Me.TX_idCategoria = New System.Windows.Forms.TextBox()
        Me.TX_NomeCategoria = New System.Windows.Forms.TextBox()
        Me.LB_Nomecategoria = New System.Windows.Forms.Label()
        Me.LB_Id = New System.Windows.Forms.Label()
        Me.DG_Categoria = New System.Windows.Forms.DataGridView()
        Me.BT_Salvar = New System.Windows.Forms.Button()
        Me.BT_excluir = New System.Windows.Forms.Button()
        Me.BT_Limpar = New System.Windows.Forms.Button()
        Me.Cadastro.SuspendLayout()
        CType(Me.DG_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cadastro
        '
        Me.Cadastro.Controls.Add(Me.TX_idCategoria)
        Me.Cadastro.Controls.Add(Me.TX_NomeCategoria)
        Me.Cadastro.Controls.Add(Me.LB_Nomecategoria)
        Me.Cadastro.Controls.Add(Me.LB_Id)
        Me.Cadastro.Location = New System.Drawing.Point(13, 12)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Size = New System.Drawing.Size(245, 127)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.TabStop = False
        Me.Cadastro.Text = "Cadastro"
        '
        'TX_idCategoria
        '
        Me.TX_idCategoria.Enabled = False
        Me.TX_idCategoria.Location = New System.Drawing.Point(9, 31)
        Me.TX_idCategoria.Name = "TX_idCategoria"
        Me.TX_idCategoria.Size = New System.Drawing.Size(35, 20)
        Me.TX_idCategoria.TabIndex = 3
        '
        'TX_NomeCategoria
        '
        Me.TX_NomeCategoria.Location = New System.Drawing.Point(6, 77)
        Me.TX_NomeCategoria.Name = "TX_NomeCategoria"
        Me.TX_NomeCategoria.Size = New System.Drawing.Size(159, 20)
        Me.TX_NomeCategoria.TabIndex = 2
        '
        'LB_Nomecategoria
        '
        Me.LB_Nomecategoria.AutoSize = True
        Me.LB_Nomecategoria.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_Nomecategoria.Location = New System.Drawing.Point(6, 61)
        Me.LB_Nomecategoria.Name = "LB_Nomecategoria"
        Me.LB_Nomecategoria.Size = New System.Drawing.Size(38, 13)
        Me.LB_Nomecategoria.TabIndex = 1
        Me.LB_Nomecategoria.Text = "Nome:"
        '
        'LB_Id
        '
        Me.LB_Id.AutoSize = True
        Me.LB_Id.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_Id.Location = New System.Drawing.Point(6, 16)
        Me.LB_Id.Name = "LB_Id"
        Me.LB_Id.Size = New System.Drawing.Size(21, 13)
        Me.LB_Id.TabIndex = 0
        Me.LB_Id.Text = "ID:"
        '
        'DG_Categoria
        '
        Me.DG_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Categoria.Location = New System.Drawing.Point(13, 197)
        Me.DG_Categoria.Name = "DG_Categoria"
        Me.DG_Categoria.Size = New System.Drawing.Size(775, 241)
        Me.DG_Categoria.TabIndex = 1
        '
        'BT_Salvar
        '
        Me.BT_Salvar.ForeColor = System.Drawing.Color.SteelBlue
        Me.BT_Salvar.Location = New System.Drawing.Point(556, 168)
        Me.BT_Salvar.Name = "BT_Salvar"
        Me.BT_Salvar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Salvar.TabIndex = 2
        Me.BT_Salvar.Text = "Salvar"
        Me.BT_Salvar.UseVisualStyleBackColor = True
        '
        'BT_excluir
        '
        Me.BT_excluir.ForeColor = System.Drawing.Color.SteelBlue
        Me.BT_excluir.Location = New System.Drawing.Point(637, 168)
        Me.BT_excluir.Name = "BT_excluir"
        Me.BT_excluir.Size = New System.Drawing.Size(75, 23)
        Me.BT_excluir.TabIndex = 3
        Me.BT_excluir.Text = "Excluir"
        Me.BT_excluir.UseVisualStyleBackColor = True
        '
        'BT_Limpar
        '
        Me.BT_Limpar.ForeColor = System.Drawing.Color.SteelBlue
        Me.BT_Limpar.Location = New System.Drawing.Point(718, 168)
        Me.BT_Limpar.Name = "BT_Limpar"
        Me.BT_Limpar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Limpar.TabIndex = 4
        Me.BT_Limpar.Text = "Limpar"
        Me.BT_Limpar.UseVisualStyleBackColor = True
        '
        'FrmCadastroCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BT_Limpar)
        Me.Controls.Add(Me.BT_excluir)
        Me.Controls.Add(Me.BT_Salvar)
        Me.Controls.Add(Me.DG_Categoria)
        Me.Controls.Add(Me.Cadastro)
        Me.Name = "FrmCadastroCategoria"
        Me.Text = "Categoria"
        Me.Cadastro.ResumeLayout(False)
        Me.Cadastro.PerformLayout()
        CType(Me.DG_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cadastro As GroupBox
    Friend WithEvents LB_Nomecategoria As Label
    Friend WithEvents LB_Id As Label
    Friend WithEvents DG_Categoria As DataGridView
    Friend WithEvents TX_NomeCategoria As TextBox
    Friend WithEvents TX_idCategoria As TextBox
    Friend WithEvents BT_Salvar As Button
    Friend WithEvents BT_excluir As Button
    Friend WithEvents BT_Limpar As Button
End Class
