Public Class FrmPrincipal
    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click

        For Each frm As Form In Me.MdiChildren
            If frm.GetType() Is GetType(FrmCadastroProduto) Then
                frm.Activate()
                Return

            End If
        Next


        Dim novoform As New FrmCadastroProduto()
        novoform.MdiParent = Me
        novoform.Show()
    End Sub
End Class