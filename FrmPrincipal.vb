Public Class FrmPrincipal

    Private Sub AbrirFormularioFilho(Of T As {Form, New})()
        For Each frm As Form In Me.MdiChildren
            If frm.GetType() Is GetType(T) Then
                frm.Activate()
                Return
            End If
        Next
        Dim novoform As New T()
        novoform.MdiParent = Me
        novoform.Show()

    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        AbrirFormularioFilho(Of FrmCadastroProduto)()
    End Sub

    Private Sub EndereçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndereçosToolStripMenuItem.Click
        AbrirFormularioFilho(Of FrmCadEndereco)()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        AbrirFormularioFilho(Of FrmCadastroCategoria)()

    End Sub

    Private Sub EntradaDeEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeEstoqueToolStripMenuItem.Click
        AbrirFormularioFilho(Of FrmEntradaEstoque)()
    End Sub

    Private Sub SaidaDeEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaidaDeEstoqueToolStripMenuItem.Click
        AbrirFormularioFilho(Of FrmSaidaEstoque)()
    End Sub

    Private Sub HistóricoDeMovimentaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoDeMovimentaçõesToolStripMenuItem.Click
        AbrirFormularioFilho(Of FrmConsultaMovimentacoes)()
    End Sub
End Class