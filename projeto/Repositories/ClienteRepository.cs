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
                        // CORREÇÃO AQUI: Passando os valores direto no construtor exigido pela classe
                        var cliente = new Cliente(reader["nome"].ToString(), reader["contato"].ToString());

                        // Agora colocamos o ID nele
                        cliente.Id = Convert.ToInt32(reader["id"]);

                        lista.Add(cliente);
                    }
                }
            }
            return lista;
        }
        


    }
}