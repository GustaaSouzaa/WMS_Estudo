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
End Class