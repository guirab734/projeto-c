using System;
using System.Data.SQLite;

namespace projeto.Data
{
    public static class DatabaseConnection
    {
        // O banco será um arquivo chamado "locacao.db" criado na pasta do seu programa
        private static string connectionString = "Data Source=locacao.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // Esse método cria a tabela automaticamente se ela não existir
        public static void InicializarBanco()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS clientes (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome TEXT NOT NULL,
                        contato TEXT NOT NULL
                    );";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}