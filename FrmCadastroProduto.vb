Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmCadastroProduto
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyWmsConnection").ConnectionString

    Private Sub FrmCadastroProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProdutos()
        CarregarRuas()
    End Sub

    Private Sub CarregarRuas()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT DISTINCT rua FROM enderecos ORDER BY rua;"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                CB_Rua.DataSource = dt
                CB_Rua.DisplayMember = "rua"
                CB_Rua.ValueMember = "rua"
                CB_Rua.SelectedIndex = -1 ' Limpa a seleção inicial
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar as ruas." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregarModulos(ByVal ruaSelecionada As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT DISTINCT modulo FROM enderecos WHERE rua = @rua ORDER BY modulo;"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@rua", ruaSelecionada)

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                CB_modulo.DataSource = dt
                CB_modulo.DisplayMember = "modulo"
                CB_modulo.ValueMember = "modulo"
                CB_modulo.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar os módulos." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregarNiveis(ByVal ruaSelecionada As String, ByVal moduloSelecionado As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT DISTINCT nivel FROM enderecos WHERE rua = @rua AND modulo = @modulo ORDER BY nivel;"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@rua", ruaSelecionada)
                cmd.Parameters.AddWithValue("@modulo", moduloSelecionado)

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                CB_nivel.DataSource = dt
                CB_nivel.DisplayMember = "nivel"
                CB_nivel.ValueMember = "nivel"
                CB_nivel.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar os níveis." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregarApartamentos(ByVal ruaSelecionada As String, ByVal moduloSelecionado As Integer, ByVal nivelSelecionado As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT DISTINCT apartamento FROM enderecos WHERE rua = @rua AND modulo = @modulo AND nivel = @nivel ORDER BY apartamento;"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@rua", ruaSelecionada)
                cmd.Parameters.AddWithValue("@modulo", moduloSelecionado)
                cmd.Parameters.AddWithValue("@nivel", nivelSelecionado)

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                CB_apto.DataSource = dt
                CB_apto.DisplayMember = "apartamento"
                CB_apto.ValueMember = "apartamento"
                CB_apto.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar os apartamentos." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CB_Rua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Rua.SelectedIndexChanged
        If CB_Rua.SelectedValue Is Nothing Then Return

        CB_modulo.DataSource = Nothing
        CB_nivel.DataSource = Nothing
        CB_apto.DataSource = Nothing

        Dim rua As String = CB_Rua.SelectedValue.ToString()
        CarregarModulos(rua)
    End Sub

    Private Sub CB_modulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_modulo.SelectedIndexChanged
        If CB_Rua.SelectedValue Is Nothing OrElse CB_modulo.SelectedValue Is Nothing Then Return

        CB_nivel.DataSource = Nothing
        CB_apto.DataSource = Nothing

        Dim rua As String = CB_Rua.SelectedValue.ToString()
        Dim drvModulo As DataRowView = CType(CB_modulo.SelectedItem, DataRowView)
        Dim modulo As Integer = Convert.ToInt32(drvModulo("modulo"))
        CarregarNiveis(rua, modulo)
    End Sub

    Private Sub CB_nivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_nivel.SelectedIndexChanged
        If CB_Rua.SelectedValue Is Nothing OrElse CB_modulo.SelectedValue Is Nothing OrElse CB_nivel.SelectedValue Is Nothing Then Return

        CB_apto.DataSource = Nothing

        Dim rua As String = CB_Rua.SelectedValue.ToString()

        Dim drvModulo As DataRowView = CType(CB_modulo.SelectedItem, DataRowView)
        Dim modulo As Integer = Convert.ToInt32(drvModulo("modulo"))

        Dim drvNivel As DataRowView = CType(CB_nivel.SelectedItem, DataRowView)
        Dim nivel As Integer = Convert.ToInt32(drvNivel("nivel"))

        CarregarApartamentos(rua, modulo, nivel)
    End Sub

    Private Sub CarregarProdutos()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT ID, nome, quantidade, preco_custo, data_cadastro, endereco_id FROM produtos ORDER BY id;"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DG_Produtos.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar os produtos." & vbCrLf & "Erro: " & ex.Message)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(TX_NomeProduto.Text) Then
            MessageBox.Show("O nome do produto não pode estar vazio.")
            TX_NomeProduto.Focus()
            Return False
        End If

        Dim qtd As Integer
        If Not Integer.TryParse(TX_QTD.Text, qtd) OrElse qtd < 0 Then
            MessageBox.Show("A quantidade deve ser um número inteiro não negativo.")
            TX_QTD.Focus()
            Return False
        End If

        Dim preco As Decimal
        If Not Decimal.TryParse(TX_Preco.Text, preco) OrElse preco < 0D Then
            MessageBox.Show("O preço deve ser um número decimal não negativo.")
            TX_Preco.Focus()
            Return False
        End If



        Return True
    End Function

    Private Sub BT_Salvar_Click(sender As Object, e As EventArgs) Handles BT_Salvar.Click
        If Not ValidarCampos() Then
            Return
        End If

        Dim enderecoid As Integer? = ObterIdEndereco()

        If CB_apto.SelectedItem IsNot Nothing AndAlso Not enderecoid.HasValue Then
            MessageBox.Show("O endereço completo selecionado não foi encontrado no cadastro")
            Return
        End If
        If String.IsNullOrEmpty(TX_ProdutoId.Text) Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "INSERT INTO produtos (nome, quantidade, preco_custo, data_cadastro, endereco_id) VALUES (@nome, @quantidade, @preco_custo, @data_cadastro, @endereco_id);"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nome", TX_NomeProduto.Text)
                    cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(TX_QTD.Text))
                    cmd.Parameters.AddWithValue("@preco_custo", Convert.ToDecimal(TX_Preco.Text))
                    cmd.Parameters.AddWithValue("@data_cadastro", DateTime.Now)
                    cmd.Parameters.AddWithValue("@endereco_id", If(enderecoid.HasValue, enderecoid.Value, DBNull.Value))

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
                    Dim sql As String = "UPDATE produtos SET nome = @nome, quantidade = @quantidade, preco_custo = @preco_custo, endereco_id = @endereco_id WHERE id = @id;"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_ProdutoId.Text))
                    cmd.Parameters.AddWithValue("@nome", TX_NomeProduto.Text)
                    cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(TX_QTD.Text))
                    cmd.Parameters.AddWithValue("@preco_custo", Convert.ToDecimal(TX_Preco.Text))
                    cmd.Parameters.AddWithValue("@endereco_id", If(enderecoid.HasValue, enderecoid.Value, DBNull.Value))
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
                    BT_Limpar_Click(Nothing, Nothing)
                    CarregarProdutos()
                End Using
            Catch ex As Exception
                MessageBox.Show("Falha ao excluir o produto." & vbCrLf & "Erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BT_Limpar_Click(sender As Object, e As EventArgs) Handles BT_Limpar.Click
        TX_ProdutoId.Clear()
        TX_NomeProduto.Clear()
        TX_QTD.Clear()
        TX_Preco.Clear()
        CB_Rua.SelectedIndex = -1
        CB_modulo.DataSource = Nothing
        CB_nivel.DataSource = Nothing
        CB_apto.DataSource = Nothing
        TX_NomeProduto.Focus()
    End Sub

    Private Sub DG_Produtos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Produtos.CellClick
        If e.RowIndex >= 0 Then
            Dim linhaSelecionada As DataGridViewRow = DG_Produtos.Rows(e.RowIndex)
            TX_ProdutoId.Text = linhaSelecionada.Cells("ID").Value.ToString()
            TX_NomeProduto.Text = linhaSelecionada.Cells("nome").Value.ToString()
            TX_QTD.Text = linhaSelecionada.Cells("quantidade").Value.ToString()
            TX_Preco.Text = linhaSelecionada.Cells("preco_custo").Value.ToString()

            If Not IsDBNull(linhaSelecionada.Cells("endereco_id").Value) Then
                Dim idDoEndereco As Integer = Convert.ToInt32(linhaSelecionada.Cells("endereco_id").Value)

                carregarEnderecoNosCombos(idDoEndereco)
            Else
                BT_Limpar_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub carregarEnderecoNosCombos(idDoEndereco As Integer)
        Try
            ' --- ETAPA 1: DESLIGAMOS OS "ALARMES" (EVENTOS) ---
            RemoveHandler CB_Rua.SelectedIndexChanged, AddressOf CB_Rua_SelectedIndexChanged
            RemoveHandler CB_modulo.SelectedIndexChanged, AddressOf CB_modulo_SelectedIndexChanged
            RemoveHandler CB_nivel.SelectedIndexChanged, AddressOf CB_nivel_SelectedIndexChanged

            ' --- ETAPA 2: BUSCAMOS OS DADOS DO ENDEREÇO COMPLETO ---
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim sql As String = "SELECT rua, modulo, nivel, apartamento FROM enderecos WHERE id = @id LIMIT 1;"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", idDoEndereco)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Pegamos todos os valores do banco primeiro
                        Dim rua As String = reader("rua").ToString()
                        Dim modulo As Integer = Convert.ToInt32(reader("modulo"))
                        Dim nivel As Integer = Convert.ToInt32(reader("nivel"))
                        Dim apartamento As Integer = Convert.ToInt32(reader("apartamento"))

                        ' --- ETAPA 3: EXECUTAMOS A CASCATA MANUALMENTE E NA ORDEM CERTA ---
                        ' 1. Define a Rua (não dispara evento)
                        CB_Rua.SelectedValue = rua

                        ' 2. Carrega os Módulos e DEPOIS define o valor
                        CarregarModulos(rua)
                        CB_modulo.SelectedValue = modulo

                        ' 3. Carrega os Níveis e DEPOIS define o valor
                        CarregarNiveis(rua, modulo)
                        CB_nivel.SelectedValue = nivel

                        ' 4. Carrega os Apartamentos e DEPOIS define o valor
                        CarregarApartamentos(rua, modulo, nivel)
                        CB_apto.SelectedValue = apartamento
                    Else
                        MessageBox.Show("Endereço associado ao produto não encontrado no cadastro.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Ocorreu uma falha ao carregar o endereço do produto." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' --- ETAPA 4: RELIGAMOS OS "ALARMES" (EVENTOS) ---
            ' O bloco Finally garante que isso aconteça MESMO SE ocorrer um erro.
            AddHandler CB_Rua.SelectedIndexChanged, AddressOf CB_Rua_SelectedIndexChanged
            AddHandler CB_modulo.SelectedIndexChanged, AddressOf CB_modulo_SelectedIndexChanged
            AddHandler CB_nivel.SelectedIndexChanged, AddressOf CB_nivel_SelectedIndexChanged
        End Try
    End Sub

    Private Function ObterIdEndereco() As Integer?
        If CB_Rua.SelectedItem IsNot Nothing AndAlso
            CB_modulo.SelectedItem IsNot Nothing AndAlso
            CB_nivel.SelectedItem IsNot Nothing AndAlso
            CB_apto.SelectedItem IsNot Nothing Then

            Dim rua As String = CB_Rua.SelectedValue.ToString()

            Dim drvModulo As DataRowView = CType(CB_modulo.SelectedItem, DataRowView)
            Dim modulo As Integer = Convert.ToInt32(drvModulo("modulo"))

            Dim drvNivel As DataRowView = CType(CB_nivel.SelectedItem, DataRowView)
            Dim nivel As Integer = Convert.ToInt32(drvNivel("nivel"))

            Dim drvApto As DataRowView = CType(CB_apto.SelectedItem, DataRowView)
            Dim apartamento As Integer = Convert.ToInt32(drvApto("apartamento"))

            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "SELECT id FROM enderecos WHERE rua = @rua AND modulo = @modulo AND nivel = @nivel AND apartamento = @apartamento LIMIT 1;"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rua", rua)
                    cmd.Parameters.AddWithValue("@modulo", modulo)
                    cmd.Parameters.AddWithValue("@nivel", nivel)
                    cmd.Parameters.AddWithValue("@apartamento", apartamento)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return Convert.ToInt32(result)
                    Else
                        MessageBox.Show("Endereço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return Nothing
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Falha ao obter o ID do endereço." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End If

        Return Nothing
    End Function
End Class