using System;
using System.Collections.Generic;
using System.Data.SQLite;
using projeto.Models;
using projeto.Data;

namespace projeto.Repositories
{
    public class ClienteRepository
    {
        public void Salvar(Cliente cliente)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO clientes (nome, contato) VALUES (@nome, @contato)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@contato", cliente.Contato);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> ObterTodos()
        {
            var lista = new List<Cliente>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id, nome, contato FROM clientes";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cliente = new Cliente(reader["nome"].ToString(), reader["contato"].ToString());
                        cliente.Id = Convert.ToInt32(reader["id"]);
                        lista.Add(cliente);
                    }
                }
            }
            return lista;
        }

        public void Atualizar(Cliente cliente)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE clientes SET nome = @nome, contato = @contato WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@contato", cliente.Contato);
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int clienteId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM clientes WHERE id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Verifica se o cliente tem QUALQUER locação no histórico (ativa ou já
        // devolvida). Mantemos o histórico de locações sempre, então um cliente
        // que já alugou alguma vez não pode ser excluído — só editado.
        public bool TemHistoricoDeLocacoes(int clienteId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM locacoes WHERE cliente_id = @clienteId";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}