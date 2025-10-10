Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmCadastroProduto
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyWmsConnection").ConnectionString
    Private Sub BT_Salvar_Click(sender As Object, e As EventArgs) Handles BT_Salvar.Click

        If Not ValidarCampos() Then
            Return
        End If

        If String.IsNullOrEmpty(TX_ProdutoId.Text) Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Dim sql As String = "INSERT INTO produtos (nome, quantidade, preco_custo, data_cadastro) VALUES (@nome, @quantidade, @preco_custo, @data_cadastro);"
                    Dim cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@nome", TX_NomeProduto.Text)
                    cmd.Parameters.AddWithValue("@data_cadastro", DateTime.Now)
                    cmd.Parameters.AddWithValue("@quantidade", If(String.IsNullOrWhiteSpace(TX_QTD.Text), 0, Convert.ToInt32(TX_QTD.Text)))
                    cmd.Parameters.AddWithValue("@preco_custo", If(String.IsNullOrWhiteSpace(TX_Preco.Text), 0D, Convert.ToDecimal(TX_Preco.Text)))

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Produto cadastrado com sucesso!")

                    BT_Limpar_Click(Nothing, Nothing)
                    CarregarProdutos()
                End Using
            Catch ex As Exception
                MessageBox.Show("Falha ao cadastrar o produto." & vbCrLf & "Erro: " & ex.Message)
            End Try

        Else
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Dim sql As String = "UPDATE produtos SET nome = @nome, quantidade = @quantidade, preco_custo = @preco_custo WHERE id = @id;"
                    Dim cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@nome", TX_NomeProduto.Text)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_ProdutoId.Text))
                    cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(TX_QTD.Text))
                    cmd.Parameters.AddWithValue("@preco_custo", Convert.ToDecimal(TX_Preco.Text))

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Produto atualizado com sucesso!")

                    BT_Limpar_Click(Nothing, Nothing)
                    CarregarProdutos()
                End Using
            Catch ex As Exception
                MessageBox.Show("Falha ao atualizar o produto." & vbCrLf & "Erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub CarregarProdutos()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT ID, nome, quantidade, preco_custo, data_cadastro FROM produtos ORDER BY id;"

                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                DG_Produtos.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar os produtos." & vbCrLf & "Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProdutos()
    End Sub



    Private Sub BT_Limpar_Click(sender As Object, e As EventArgs) Handles BT_Limpar.Click
        TX_ProdutoId.Clear()
        TX_NomeProduto.Clear()
        TX_QTD.Clear()
        TX_Preco.Clear()
        TX_NomeProduto.Focus()
    End Sub

    Private Sub DG_Produtos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Produtos.CellClick
        If e.RowIndex >= 0 Then

            Dim linhaSelecionada As DataGridViewRow = DG_Produtos.Rows(e.RowIndex)

            TX_NomeProduto.Text = linhaSelecionada.Cells("nome").Value.ToString()
            TX_ProdutoId.Text = linhaSelecionada.Cells("ID").Value.ToString()
            TX_QTD.Text = linhaSelecionada.Cells("quantidade").Value.ToString()
            TX_Preco.Text = linhaSelecionada.Cells("preco_custo").Value.ToString()


        End If
    End Sub

    Private Sub BT_Excluir_Click(sender As Object, e As EventArgs) Handles BT_Excluir.Click
        If String.IsNullOrEmpty(TX_ProdutoId.Text) Then
            MessageBox.Show("Selecione um produto para excluir.")
            Return
        End If

        If MessageBox.Show("Tem certeza que desea excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then



            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "DELETE FROM produtos WHERE id = @id;"
                    Dim cmd As New MySqlCommand(sql, conn)


                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_ProdutoId.Text))

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Produto excluído com sucesso!")

                End Using

            Catch ex As Exception
                MessageBox.Show("Falha ao excluir o produto." & vbCrLf & "Erro: " & ex.Message)
            End Try

            BT_Limpar_Click(Nothing, Nothing)
            CarregarProdutos()
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(TX_NomeProduto.Text) Then
            MessageBox.Show("O nome do produto não pode estar vazio.")
            TX_NomeProduto.Focus()
            Return False
        End If
        Return True
    End Function
End Class