Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmCadEndereco
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyWmsConnection").ConnectionString

    Private Sub FrmCadEndereco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarEnderecos()
    End Sub

    Private Sub CarregarEnderecos()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "SELECT id, rua, modulo, nivel, apartamento, descricao FROM enderecos ORDER BY rua, modulo, nivel, apartamento;"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DG_endereco.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar os endereços." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos(ByRef rua As String, ByRef modulo As Integer, ByRef nivel As Integer, ByRef apartamento As Integer, ByRef descricao As String) As Boolean
        If String.IsNullOrWhiteSpace(TX_rua.Text) Then
            MessageBox.Show("O campo 'Rua' é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_rua.Focus()
            Return False
        End If

        If Not Integer.TryParse(TX_modulo.Text, modulo) OrElse modulo < 0 Then
            MessageBox.Show("O campo 'Módulo' deve ser um número inteiro não negativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_modulo.Focus()
            Return False
        End If

        If Not Integer.TryParse(TX_nivel.Text, nivel) OrElse nivel < 0 Then
            MessageBox.Show("O campo 'Nível' deve ser um número inteiro não negativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_nivel.Focus()
            Return False
        End If

        If Not Integer.TryParse(TX_apto.Text, apartamento) OrElse apartamento < 0 Then
            MessageBox.Show("O campo 'Apartamento' deve ser um número inteiro não negativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TX_apto.Focus()
            Return False
        End If

        rua = TX_rua.Text
        descricao = TX_desc.Text
        Return True
    End Function

    Private Sub BT_Salvar_Click(sender As Object, e As EventArgs) Handles BT_Salvar.Click
        Dim ruaValida As String = ""
        Dim moduloValido As Integer = 0
        Dim nivelValido As Integer = 0
        Dim aptoValido As Integer = 0
        Dim descValida As String = ""

        If Not ValidarCampos(ruaValida, moduloValido, nivelValido, aptoValido, descValida) Then
            Return
        End If

        Try
            If String.IsNullOrEmpty(TX_EnderecoID.Text) Then
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "INSERT INTO enderecos (rua, modulo, nivel, apartamento, descricao) VALUES (@rua, @modulo, @nivel, @apartamento, @descricao);"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rua", ruaValida)
                    cmd.Parameters.AddWithValue("@modulo", moduloValido)
                    cmd.Parameters.AddWithValue("@nivel", nivelValido)
                    cmd.Parameters.AddWithValue("@apartamento", aptoValido)
                    cmd.Parameters.AddWithValue("@descricao", descValida)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Endereço cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Else
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "UPDATE enderecos SET rua = @rua, modulo = @modulo, nivel = @nivel, apartamento = @apartamento, descricao = @descricao WHERE id = @id;"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_EnderecoID.Text))
                    cmd.Parameters.AddWithValue("@rua", ruaValida)
                    cmd.Parameters.AddWithValue("@modulo", moduloValido)
                    cmd.Parameters.AddWithValue("@nivel", nivelValido)
                    cmd.Parameters.AddWithValue("@apartamento", aptoValido)
                    cmd.Parameters.AddWithValue("@descricao", descValida)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Endereço atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End If

            BT_Limpar_Click(Nothing, Nothing)
            CarregarEnderecos()
        Catch ex As Exception
            MessageBox.Show("Ocorreu uma falha ao salvar o endereço." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BT_Limpar_Click(sender As Object, e As EventArgs) Handles BT_Limpar.Click
        TX_EnderecoID.Clear()
        TX_rua.Clear()
        TX_modulo.Clear()
        TX_nivel.Clear()
        TX_apto.Clear()
        TX_desc.Clear()
        TX_rua.Focus()
    End Sub

    Private Sub DGV_Enderecos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_endereco.CellClick
        If e.RowIndex >= 0 Then
            Dim linha As DataGridViewRow = DG_endereco.Rows(e.RowIndex)
            TX_EnderecoID.Text = linha.Cells("id").Value.ToString()
            TX_rua.Text = linha.Cells("rua").Value.ToString()
            TX_modulo.Text = linha.Cells("modulo").Value.ToString()
            TX_nivel.Text = linha.Cells("nivel").Value.ToString()
            TX_apto.Text = linha.Cells("apartamento").Value.ToString()
            TX_desc.Text = linha.Cells("descricao").Value.ToString()
        End If
    End Sub

    Private Sub BT_Excluir_Click(sender As Object, e As EventArgs) Handles BT_Excluir.Click
        If String.IsNullOrEmpty(TX_EnderecoID.Text) Then
            MessageBox.Show("Por favor, selecione um endereço da lista para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Tem certeza que deseja excluir permanentemente este endereço?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "DELETE FROM enderecos WHERE id = @id;"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TX_EnderecoID.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Endereço excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                BT_Limpar_Click(Nothing, Nothing)
                CarregarEnderecos()
            Catch ex As Exception
                MessageBox.Show("Falha ao excluir o endereço." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class