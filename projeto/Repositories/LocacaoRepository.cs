using System;
using System.Collections.Generic;
using System.Data.SQLite;
using projeto.Models;
using projeto.Data;

namespace projeto.Repositories
{
    public class LocacaoRepository
    {
        public void Salvar(Locacao locacao)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO locacoes (cliente_id, item_id, data_retirada, data_prevista_devolucao, valor_total, ativa)
                    VALUES (@clienteId, @itemId, @dataRetirada, @dataDevolucao, @valorTotal, @ativa)";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@clienteId", locacao.ClienteId);
                    cmd.Parameters.AddWithValue("@itemId", locacao.ItemId);
                    cmd.Parameters.AddWithValue("@dataRetirada", locacao.DataRetirada.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dataDevolucao", locacao.DataPrevistaDevolucao.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@valorTotal", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@ativa", locacao.Ativa ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Locacao> ObterTodas()
        {
            var lista = new List<Locacao>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT l.id, l.cliente_id, l.item_id, l.data_retirada,
                           l.data_prevista_devolucao, l.valor_total, l.ativa,
                           c.nome AS nome_cliente, i.nome AS nome_item
                    FROM locacoes l
                    INNER JOIN clientes c ON c.id = l.cliente_id
                    INNER JOIN itens i ON i.id = l.item_id";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearLocacao(reader));
                    }
                }
            }
            return lista;
        }

        public List<Locacao> ObterAtivas()
        {
            var lista = new List<Locacao>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT l.id, l.cliente_id, l.item_id, l.data_retirada,
                           l.data_prevista_devolucao, l.valor_total, l.ativa,
                           c.nome AS nome_cliente, i.nome AS nome_item
                    FROM locacoes l
                    INNER JOIN clientes c ON c.id = l.cliente_id
                    INNER JOIN itens i ON i.id = l.item_id
                    WHERE l.ativa = 1";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearLocacao(reader));
                    }
                }
            }
            return lista;
        }

        public void RegistrarDevolucao(int locacaoId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE locacoes SET ativa = 0 WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", locacaoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int locacaoId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM locacoes WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", locacaoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ItemEstaAlugado(int itemId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM locacoes WHERE item_id = @itemId AND ativa = 1";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private Locacao MapearLocacao(SQLiteDataReader reader)
        {
            return new Locacao
            {
                Id = Convert.ToInt32(reader["id"]),
                ClienteId = Convert.ToInt32(reader["cliente_id"]),
                ItemId = Convert.ToInt32(reader["item_id"]),
                NomeCliente = reader["nome_cliente"].ToString(),
                NomeItem = reader["nome_item"].ToString(),
                DataRetirada = DateTime.Parse(reader["data_retirada"].ToString()),
                DataPrevistaDevolucao = DateTime.Parse(reader["data_prevista_devolucao"].ToString()),
                ValorTotal = Convert.ToDecimal(reader["valor_total"]),
                Ativa = Convert.ToInt32(reader["ativa"]) == 1
            };
        }
    }
}