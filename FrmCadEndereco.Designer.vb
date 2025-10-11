<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadEndereco
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
        Me.TX_EnderecoID = New System.Windows.Forms.TextBox()
        Me.LB_ID = New System.Windows.Forms.Label()
        Me.LB_rua = New System.Windows.Forms.Label()
        Me.TX_rua = New System.Windows.Forms.TextBox()
        Me.LB_Modulo = New System.Windows.Forms.Label()
        Me.TX_modulo = New System.Windows.Forms.TextBox()
        Me.LB_nivel = New System.Windows.Forms.Label()
        Me.TX_nivel = New System.Windows.Forms.TextBox()
        Me.LB_Apto = New System.Windows.Forms.Label()
        Me.TX_apto = New System.Windows.Forms.TextBox()
        Me.LB_desc = New System.Windows.Forms.Label()
        Me.TX_desc = New System.Windows.Forms.TextBox()
        Me.BT_Salvar = New System.Windows.Forms.Button()
        Me.BT_Limpar = New System.Windows.Forms.Button()
        Me.BT_Excluir = New System.Windows.Forms.Button()
        Me.DG_endereco = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_endereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_Excluir)
        Me.GroupBox1.Controls.Add(Me.BT_Limpar)
        Me.GroupBox1.Controls.Add(Me.BT_Salvar)
        Me.GroupBox1.Controls.Add(Me.LB_desc)
        Me.GroupBox1.Controls.Add(Me.TX_desc)
        Me.GroupBox1.Controls.Add(Me.LB_Apto)
        Me.GroupBox1.Controls.Add(Me.TX_apto)
        Me.GroupBox1.Controls.Add(Me.LB_nivel)
        Me.GroupBox1.Controls.Add(Me.TX_nivel)
        Me.GroupBox1.Controls.Add(Me.LB_Modulo)
        Me.GroupBox1.Controls.Add(Me.TX_modulo)
        Me.GroupBox1.Controls.Add(Me.LB_rua)
        Me.GroupBox1.Controls.Add(Me.TX_rua)
        Me.GroupBox1.Controls.Add(Me.LB_ID)
        Me.GroupBox1.Controls.Add(Me.TX_EnderecoID)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro de Endereço"
        '
        'TX_EnderecoID
        '
        Me.TX_EnderecoID.Enabled = False
        Me.TX_EnderecoID.Location = New System.Drawing.Point(7, 35)
        Me.TX_EnderecoID.Name = "TX_EnderecoID"
        Me.TX_EnderecoID.Size = New System.Drawing.Size(42, 20)
        Me.TX_EnderecoID.TabIndex = 0
        '
        'LB_ID
        '
        Me.LB_ID.AutoSize = True
        Me.LB_ID.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_ID.Location = New System.Drawing.Point(9, 20)
        Me.LB_ID.Name = "LB_ID"
        Me.LB_ID.Size = New System.Drawing.Size(18, 13)
        Me.LB_ID.TabIndex = 1
        Me.LB_ID.Text = "ID"
        '
        'LB_rua
        '
        Me.LB_rua.AutoSize = True
        Me.LB_rua.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_rua.Location = New System.Drawing.Point(67, 20)
        Me.LB_rua.Name = "LB_rua"
        Me.LB_rua.Size = New System.Drawing.Size(27, 13)
        Me.LB_rua.TabIndex = 3
        Me.LB_rua.Text = "Rua"
        '
        'TX_rua
        '
        Me.TX_rua.Location = New System.Drawing.Point(65, 35)
        Me.TX_rua.Name = "TX_rua"
        Me.TX_rua.Size = New System.Drawing.Size(42, 20)
        Me.TX_rua.TabIndex = 2
        '
        'LB_Modulo
        '
        Me.LB_Modulo.AutoSize = True
        Me.LB_Modulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_Modulo.Location = New System.Drawing.Point(122, 20)
        Me.LB_Modulo.Name = "LB_Modulo"
        Me.LB_Modulo.Size = New System.Drawing.Size(42, 13)
        Me.LB_Modulo.TabIndex = 5
        Me.LB_Modulo.Text = "Módulo"
        '
        'TX_modulo
        '
        Me.TX_modulo.Location = New System.Drawing.Point(122, 35)
        Me.TX_modulo.Name = "TX_modulo"
        Me.TX_modulo.Size = New System.Drawing.Size(42, 20)
        Me.TX_modulo.TabIndex = 4
        '
        'LB_nivel
        '
        Me.LB_nivel.AutoSize = True
        Me.LB_nivel.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_nivel.Location = New System.Drawing.Point(179, 20)
        Me.LB_nivel.Name = "LB_nivel"
        Me.LB_nivel.Size = New System.Drawing.Size(33, 13)
        Me.LB_nivel.TabIndex = 7
        Me.LB_nivel.Text = "Nível"
        '
        'TX_nivel
        '
        Me.TX_nivel.Location = New System.Drawing.Point(179, 35)
        Me.TX_nivel.Name = "TX_nivel"
        Me.TX_nivel.Size = New System.Drawing.Size(42, 20)
        Me.TX_nivel.TabIndex = 6
        '
        'LB_Apto
        '
        Me.LB_Apto.AutoSize = True
        Me.LB_Apto.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_Apto.Location = New System.Drawing.Point(235, 20)
        Me.LB_Apto.Name = "LB_Apto"
        Me.LB_Apto.Size = New System.Drawing.Size(33, 13)
        Me.LB_Apto.TabIndex = 9
        Me.LB_Apto.Text = "Nível"
        '
        'TX_apto
        '
        Me.TX_apto.Location = New System.Drawing.Point(235, 35)
        Me.TX_apto.Name = "TX_apto"
        Me.TX_apto.Size = New System.Drawing.Size(42, 20)
        Me.TX_apto.TabIndex = 8
        '
        'LB_desc
        '
        Me.LB_desc.AutoSize = True
        Me.LB_desc.ForeColor = System.Drawing.Color.SteelBlue
        Me.LB_desc.Location = New System.Drawing.Point(7, 80)
        Me.LB_desc.Name = "LB_desc"
        Me.LB_desc.Size = New System.Drawing.Size(55, 13)
        Me.LB_desc.TabIndex = 11
        Me.LB_desc.Text = "Descrição"
        '
        'TX_desc
        '
        Me.TX_desc.Location = New System.Drawing.Point(7, 95)
        Me.TX_desc.Name = "TX_desc"
        Me.TX_desc.Size = New System.Drawing.Size(174, 20)
        Me.TX_desc.TabIndex = 10
        '
        'BT_Salvar
        '
        Me.BT_Salvar.Location = New System.Drawing.Point(347, 170)
        Me.BT_Salvar.Name = "BT_Salvar"
        Me.BT_Salvar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Salvar.TabIndex = 12
        Me.BT_Salvar.Text = "Salvar"
        Me.BT_Salvar.UseVisualStyleBackColor = True
        '
        'BT_Limpar
        '
        Me.BT_Limpar.Location = New System.Drawing.Point(496, 170)
        Me.BT_Limpar.Name = "BT_Limpar"
        Me.BT_Limpar.Size = New System.Drawing.Size(75, 23)
        Me.BT_Limpar.TabIndex = 13
        Me.BT_Limpar.Text = "Limpar"
        Me.BT_Limpar.UseVisualStyleBackColor = True
        '
        'BT_Excluir
        '
        Me.BT_Excluir.Location = New System.Drawing.Point(421, 170)
        Me.BT_Excluir.Name = "BT_Excluir"
        Me.BT_Excluir.Size = New System.Drawing.Size(75, 23)
        Me.BT_Excluir.TabIndex = 14
        Me.BT_Excluir.Text = "Excluir"
        Me.BT_Excluir.UseVisualStyleBackColor = True
        '
        'DG_endereco
        '
        Me.DG_endereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_endereco.Location = New System.Drawing.Point(13, 241)
        Me.DG_endereco.Name = "DG_endereco"
        Me.DG_endereco.Size = New System.Drawing.Size(775, 197)
        Me.DG_endereco.TabIndex = 1
        '
        'FrmCadEndereco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DG_endereco)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCadEndereco"
        Me.Text = "FrmCadEndereco"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_endereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_Modulo As Label
    Friend WithEvents TX_modulo As TextBox
    Friend WithEvents LB_rua As Label
    Friend WithEvents TX_rua As TextBox
    Friend WithEvents LB_ID As Label
    Friend WithEvents TX_EnderecoID As TextBox
    Friend WithEvents BT_Excluir As Button
    Friend WithEvents BT_Limpar As Button
    Friend WithEvents BT_Salvar As Button
    Friend WithEvents LB_desc As Label
    Friend WithEvents TX_desc As TextBox
    Friend WithEvents LB_Apto As Label
    Friend WithEvents TX_apto As TextBox
    Friend WithEvents LB_nivel As Label
    Friend WithEvents TX_nivel As TextBox
    Friend WithEvents DG_endereco As DataGridView
End Class
