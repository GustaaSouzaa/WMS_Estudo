Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmCadastroCategoria
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyWmsConnection").ConnectionString

    Private Sub FrmCadastroCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregargrid()
    End Sub

    Private Sub carregargrid()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT id, nome FROM categoria ORDER BY nome;"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DG_Categoria.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar categorias." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(TX_NomeCategoria.Text) Then
            MessageBox.Show("O nome da categoria é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_NomeCategoria.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub BT_Salvar_Click(sender As Object, e As EventArgs) Handles BT_Salvar.Click
        If Not ValidarCampos() Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As MySqlCommand

                If String.IsNullOrEmpty(TX_idCategoria.Text) Then
                    Dim sql As String = "INSERT INTO categoria (nome) VALUES (@nome);"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nome", TX_NomeCategoria.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria cadastrada com sucesso!")
                Else
                    Dim sql As String = "UPDATE categoria SET nome = @nome WHERE id = @id;"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_idCategoria.Text))
                    cmd.Parameters.AddWithValue("@nome", TX_NomeCategoria.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria atualizada com sucesso!")
                End If
            End Using

            BT_Limpar_Click(Nothing, Nothing)
            carregargrid()

        Catch ex As Exception
            ' Tratamento de erro especial para nome duplicado (UNIQUE)
            If ex.Message.Contains("Duplicate entry") Then
                MessageBox.Show("Já existe uma categoria com este nome. Por favor, escolha outro.", "Nome Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TX_NomeCategoria.Focus()
                TX_NomeCategoria.SelectAll()
            Else
                MessageBox.Show("Falha ao salvar a categoria." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub BT_Limpar_Click(sender As Object, e As EventArgs) Handles BT_Limpar.Click
        TX_idCategoria.Clear()
        TX_NomeCategoria.Clear()
        TX_NomeCategoria.Focus()
    End Sub

    Private Sub BT_excluir_Click(sender As Object, e As EventArgs) Handles BT_excluir.Click
        If String.IsNullOrEmpty(TX_idCategoria.Text) Then
            MessageBox.Show("Selecione uma categoria para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "DELETE FROM categoria WHERE id = @id;"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_idCategoria.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria excluída com sucesso!")
                End Using

                BT_Limpar_Click(Nothing, Nothing)
                carregargrid()
            Catch ex As Exception
                MessageBox.Show("Falha ao excluir a categoria." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DG_Categoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Categoria.CellClick
        If e.RowIndex >= 0 Then
            Dim linha As DataGridViewRow = DG_Categoria.Rows(e.RowIndex)
            TX_idCategoria.Text = linha.Cells("id").Value.ToString()
            TX_NomeCategoria.Text = linha.Cells("nome").Value.ToString()
        End If
    End Sub

End Class