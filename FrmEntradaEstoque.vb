Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Transactions
Imports MySql.Data.MySqlClient

Public Class FrmEntradaEstoque
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyWmsConnection").ConnectionString

    Private Sub FrmEntradaEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carregar dados iniciais ou configurar controles, se necessário
        CarregarProdutos()
        CarregarEnderecos()

    End Sub

    Private Sub CarregarProdutos()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT id, nome FROM Produtos"
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

    Private Sub CarregarEnderecos()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT ID, CONCAT(rua,'-', modulo, '-', nivel, '-', apartamento) AS endereco_completo FROM enderecos ORDER BY rua, modulo, nivel, apartamento;"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                CB_EnderecoDestino.DataSource = dt
                CB_EnderecoDestino.DisplayMember = "endereco_completo"
                CB_EnderecoDestino.ValueMember = "id"
                CB_EnderecoDestino.SelectedIndex = -1

            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar os endereços." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ValidarCampos() As Boolean
        If CB_Produto.SelectedIndex = -1 Then
            MessageBox.Show("Informe um produto para registrar entrada!")
            CB_Produto.Focus()
            Return False
        End If

        If CB_EnderecoDestino.SelectedIndex = -1 Then
            MessageBox.Show("Informe um endereço destino para registrar entrada!")
            CB_EnderecoDestino.Focus()
            Return False
        End If

        Dim quantidadeDigitada As Integer
        If Not Integer.TryParse(TX_QuantidadeEntrada.Text, quantidadeDigitada) Then
            MessageBox.Show("A quantidade informada não é um número inteiro válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_QuantidadeEntrada.Focus()
            TX_QuantidadeEntrada.SelectAll()
            Return False
        ElseIf quantidadeDigitada <= 0 Then
            MessageBox.Show("A quantidade deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_QuantidadeEntrada.Focus()
            TX_QuantidadeEntrada.SelectAll()
            Return False
        End If

        Return True


    End Function

    Private Sub BT_RegistrarEntrada_Click(sender As Object, e As EventArgs) Handles BT_RegistrarEntrada.Click
        If Not ValidarCampos() Then
            Return
        End If

        Dim produtoId As Integer = Convert.ToInt32(CB_Produto.SelectedValue)
        Dim quantidadeEntrada As Integer = Convert.ToInt32(TX_QuantidadeEntrada.Text)
        Dim enderecoDestinoId As Integer = Convert.ToInt32(CB_EnderecoDestino.SelectedValue)
        Dim observacao As String = TX_observacao.Text

        Dim conn As MySqlConnection = Nothing
        Dim transacao As MySqlTransaction = Nothing


        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()

            transacao = conn.BeginTransaction()

            Dim sqlUpdate As String = "UPDATE produtos SET quantidade = quantidade + @quantidade WHERE id = @id;"
            Dim cmdUpdateProduto As New MySqlCommand(sqlUpdate, conn)
            cmdUpdateProduto.Transaction = transacao ' Associa à transação
            cmdUpdateProduto.Parameters.AddWithValue("@quantidade", quantidadeEntrada)
            cmdUpdateProduto.Parameters.AddWithValue("@id", produtoId)
            cmdUpdateProduto.ExecuteNonQuery()

            Dim sqlInsertMov As String = "INSERT INTO movimentacoes (data_hora, tipo, produto_id, quantidade, endereco_id, observacao) VALUES (@data_hora, 'ENTRADA', @produto_id, @quantidade, @endereco_id, @observacao);"
            Dim cmdInsertMov As New MySqlCommand(sqlInsertMov, conn)
            cmdInsertMov.Transaction = transacao
            cmdInsertMov.Parameters.AddWithValue("@data_hora", DateTime.Now)
            cmdInsertMov.Parameters.AddWithValue("@produto_id", produtoId)
            cmdInsertMov.Parameters.AddWithValue("@quantidade", quantidadeEntrada)
            cmdInsertMov.Parameters.AddWithValue("@endereco_id", enderecoDestinoId)
            cmdInsertMov.Parameters.AddWithValue("@observacao", observacao)
            cmdInsertMov.ExecuteNonQuery()

            transacao.Commit()
            MessageBox.Show("Entrada registrada com sucesso!")

            LimparCamposEntrada()

        Catch ex As Exception
            Try
                If transacao IsNot Nothing Then
                    transacao.Rollback()
                    MessageBox.Show("Erro ao registrar entrada. A operação foi desfeita." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Erro ao registrar entrada." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch rollbackEx As Exception
                MessageBox.Show("Erro crítico ao registrar entrada e ao tentar desfazer a operação." & vbCrLf & "Erro Original: " & ex.Message & vbCrLf & "Erro no Rollback: " & rollbackEx.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub LimparCamposEntrada()

    End Sub

    Private Sub CB_Produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Produto.SelectedIndexChanged

    End Sub
End Class