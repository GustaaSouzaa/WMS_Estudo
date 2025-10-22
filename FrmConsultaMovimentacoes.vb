Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class FrmConsultaMovimentacoes
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("MyWmsConnection").ConnectionString

    Private Sub FrmConsultaMovimentacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarMovimentacoes()
    End Sub

    Private Sub CarregarMovimentacoes()
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim sql As String = "
                SELECT
                    m.id AS MovID, m.data_hora AS DataHora, m.tipo AS Tipo,
                    p.nome AS Produto, m.quantidade AS Quantidade,
                    CONCAT(e.rua, '-', e.modulo, '-', e.nivel, '-', e.apartamento) AS Endereco,
                    m.observacao AS Observacao
                FROM
                    movimentacoes AS m
                LEFT JOIN
                    produtos AS p ON m.produto_id = p.id
                LEFT JOIN
                    enderecos AS e ON m.endereco_id = e.id
                ORDER BY
                    m.data_hora DESC;"

                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DGV_Movimentacoes.DataSource = dt

            End Using
        Catch ex As Exception
            MessageBox.Show("Falha ao carregar o histórico de movimentações." & vbCrLf & "Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class