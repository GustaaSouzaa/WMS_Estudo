Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub BT_Cadastrar_Click(sender As Object, e As EventArgs) Handles BT_Cadastrar.Click
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
End Class