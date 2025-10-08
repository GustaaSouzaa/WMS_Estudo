Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub BT_Salvar_Click(sender As Object, e As EventArgs) Handles BT_Salvar.Click
        If String.IsNullOrEmpty(TX_ProdutoId.Text) Then
            Dim connectionString As String = "Server=127.0.0.1;Database=estoque_wms;Uid=root;Pwd=;"

            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Dim sql As String = "INSERT INTO produtos (nome, data_cadastro) VALUES (@nome, @data_cadastro);"
                    Dim cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@nome", TX_NomeProduto.Text)
                    cmd.Parameters.AddWithValue("@data_cadastro", DateTime.Now)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Produto cadastrado com sucesso!")

                    TX_NomeProduto.Clear()
                    TX_NomeProduto.Focus()
                    CarregarProdutos()
                End Using
            Catch ex As Exception
                MessageBox.Show("Falha ao cadastrar o produto." & vbCrLf & "Erro: " & ex.Message)
            End Try

        Else
            Dim connectionString As String = "Server=127.0.0.1;Database=estoque_wms;Uid=root;Pwd=;"

            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "UPDATE produtos SET nome = @nome WHERE id = @id;"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nome", TX_NomeProduto.Text)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_ProdutoId.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Produto atualizado com sucesso!")
                    TX_ProdutoId.Clear()
                    TX_NomeProduto.Clear()
                    TX_NomeProduto.Focus()
                    CarregarProdutos()
                End Using
            Catch ex As Exception
                MessageBox.Show("Falha ao atualizar o produto." & vbCrLf & "Erro: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub CarregarProdutos()
        Dim connectionString As String = "Server=127.0.0.1;Database=estoque_wms;Uid=root;Pwd=;"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT ID, nome, data_cadastro FROM produtos ORDER BY id;"

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
        TX_NomeProduto.Focus()
    End Sub

    Private Sub DG_Produtos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Produtos.CellClick
        If e.RowIndex >= 0 Then

            Dim linhaSelecionada As DataGridViewRow = DG_Produtos.Rows(e.RowIndex)

            TX_NomeProduto.Text = linhaSelecionada.Cells("nome").Value.ToString()
            TX_ProdutoId.Text = linhaSelecionada.Cells("ID").Value.ToString()


        End If
    End Sub

    Private Sub BT_Excluir_Click(sender As Object, e As EventArgs) Handles BT_Excluir.Click
        If String.IsNullOrEmpty(TX_ProdutoId.Text) Then
            MessageBox.Show("Selecione um produto para excluir.")
            Return
        End If

        If MessageBox.Show("Tem certeza que desea excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Dim connectionString As String = "Server=127.0.0.1;Database=estoque_wms;Uid=root;Pwd=;"

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
End Class