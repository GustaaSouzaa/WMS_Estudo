Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmSaidaEstoque
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyWmsConnection").ConnectionString

    Private Sub FrmSaidaEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProdutos()
    End Sub

    Private Sub CarregarProdutos()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT id,  nome FROM Produtos"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                CB_Produto.DataSource = dt
                CB_Produto.DisplayMember = "nome"
                CB_Produto.ValueMember = "id"
                CB_Produto.SelectedIndex = -1

            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar as ruas" & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCamposSaida() As Boolean
        ' Valida Produto Selecionado
        If CB_Produto.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um produto para registrar a saída.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CB_Produto.Focus()
            Return False
        End If

        ' Valida Quantidade (Número Inteiro Positivo)
        Dim quantidadeDigitada As Integer
        If Not Integer.TryParse(TX_QTD.Text, quantidadeDigitada) Then
            MessageBox.Show("A quantidade informada não é um número inteiro válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_QTD.Focus()
            TX_QTD.SelectAll()
            Return False
        ElseIf quantidadeDigitada <= 0 Then
            MessageBox.Show("A quantidade a sair deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_QTD.Focus()
            TX_QTD.SelectAll()
            Return False
        End If

        ' Se chegou aqui, as validações básicas passaram
        Return True
    End Function

    Private Sub BTN_RegistrarSaida_Click(sender As Object, e As EventArgs) Handles Bt_regsaida.Click

        If Not ValidarCamposSaida() Then
            Return
        End If


        Dim produtoId As Integer = Convert.ToInt32(CB_Produto.SelectedValue)
        Dim quantidadeSaindo As Integer = Convert.ToInt32(TX_QTD.Text)
        Dim observacao As String = TX_Observacao.Text

        Dim conn As MySqlConnection = Nothing
        Dim transacao As MySqlTransaction = Nothing

        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()

            Dim sqlVerificaSaldo As String = "SELECT quantidade FROM produtos WHERE id = @id FOR UPDATE;" ' "FOR UPDATE" trava a linha
            Dim cmdVerificaSaldo As New MySqlCommand(sqlVerificaSaldo, conn)
            cmdVerificaSaldo.Parameters.AddWithValue("@id", produtoId)

            Dim saldoAtualObj As Object = cmdVerificaSaldo.ExecuteScalar()

            If saldoAtualObj Is Nothing OrElse IsDBNull(saldoAtualObj) Then
                MessageBox.Show("Produto não encontrado no cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim saldoAtual As Integer = Convert.ToInt32(saldoAtualObj)

            If saldoAtual < quantidadeSaindo Then
                MessageBox.Show($"Saldo insuficiente para este produto.{vbCrLf}Saldo atual: {saldoAtual}{vbCrLf}Quantidade solicitada: {quantidadeSaindo}", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            transacao = conn.BeginTransaction()

            Dim sqlUpdate As String = "UPDATE produtos SET quantidade = quantidade - @quantidade WHERE id = @id;"
            Dim cmdUpdateProduto As New MySqlCommand(sqlUpdate, conn)
            cmdUpdateProduto.Transaction = transacao
            cmdUpdateProduto.Parameters.AddWithValue("@quantidade", quantidadeSaindo)
            cmdUpdateProduto.Parameters.AddWithValue("@id", produtoId)
            cmdUpdateProduto.ExecuteNonQuery()

            Dim sqlInsertMov As String = "INSERT INTO movimentacoes (data_hora, tipo, produto_id, quantidade, endereco_id, observacao) VALUES (@data_hora, 'SAIDA', @produto_id, @quantidade, @endereco_id, @observacao);"
            Dim cmdInsertMov As New MySqlCommand(sqlInsertMov, conn)
            cmdInsertMov.Transaction = transacao
            cmdInsertMov.Parameters.AddWithValue("@data_hora", DateTime.Now)
            cmdInsertMov.Parameters.AddWithValue("@produto_id", produtoId)
            cmdInsertMov.Parameters.AddWithValue("@quantidade", quantidadeSaindo)

            cmdInsertMov.Parameters.AddWithValue("@endereco_id", DBNull.Value)
            cmdInsertMov.Parameters.AddWithValue("@observacao", observacao)
            cmdInsertMov.ExecuteNonQuery()

            transacao.Commit()
            MessageBox.Show("Saída registrada com sucesso!")

            LimparCamposSaida()

        Catch ex As Exception
            Try
                If transacao IsNot Nothing Then
                    transacao.Rollback()
                    MessageBox.Show("Erro ao registrar saída. A operação foi desfeita." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Erro ao registrar saída." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch rollbackEx As Exception
                MessageBox.Show("Erro crítico ao registrar saída e ao tentar desfazer a operação." & vbCrLf & "Erro Original: " & ex.Message & vbCrLf & "Erro no Rollback: " & rollbackEx.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub LimparCamposSaida()
        CB_Produto.SelectedIndex = -1
        TX_QTD.Clear()
        TX_Observacao.Clear()
        CB_Produto.Focus()
    End Sub
End Class