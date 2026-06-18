using System;
using System.Collections.Generic;
using System.Data.SQLite;
using projeto.Models;
using projeto.Data;

namespace projeto.Repositories
{
    public class ItemRepository
    {
        public void Salvar(Item item)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO itens (nome, valor_diario, componentes) VALUES (@nome, @valorDiario, @componentes)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", item.Nome);
                    cmd.Parameters.AddWithValue("@valorDiario", item.ValorDiario);
                    cmd.Parameters.AddWithValue("@componentes", item.ComponentesParaTexto());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Item> ObterTodos()
        {
            var lista = new List<Item>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id, nome, valor_diario, componentes FROM itens";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal valorDiario = Convert.ToDecimal(reader["valor_diario"]);
                        var item = new Item(reader["nome"].ToString(), valorDiario);
                        item.Id = Convert.ToInt32(reader["id"]);

                        string componentesTexto = reader["componentes"]?.ToString();
                        item.Componentes = Item.TextoParaComponentes(componentesTexto);

                        lista.Add(item);
                    }
                }
            }
            return lista;
        }

        public void Atualizar(Item item)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE itens SET nome = @nome, valor_diario = @valorDiario WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", item.Nome);
                    cmd.Parameters.AddWithValue("@valorDiario", item.ValorDiario);
                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int itemId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM itens WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", itemId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarComponentes(Item item)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE itens SET componentes = @componentes WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@componentes", item.ComponentesParaTexto());
                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Verifica se o item tem QUALQUER locação no histórico (ativa ou já devolvida)
        public bool TemHistoricoDeLocacoes(int itemId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM locacoes WHERE item_id = @itemId";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}