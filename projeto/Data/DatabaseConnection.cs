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

        // Esse método cria as tabelas automaticamente se elas não existirem
        public static void InicializarBanco()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sqlClientes = @"
                    CREATE TABLE IF NOT EXISTS clientes (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome TEXT NOT NULL,
                        contato TEXT NOT NULL
                    );";

                string sqlItens = @"
                    CREATE TABLE IF NOT EXISTS itens (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome TEXT NOT NULL,
                        valor_diario REAL NOT NULL,
                        componentes TEXT
                    );";

                string sqlLocacoes = @"
                    CREATE TABLE IF NOT EXISTS locacoes (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        cliente_id INTEGER NOT NULL,
                        item_id INTEGER NOT NULL,
                        data_retirada TEXT NOT NULL,
                        data_prevista_devolucao TEXT NOT NULL,
                        valor_total REAL NOT NULL,
                        ativa INTEGER NOT NULL DEFAULT 1,
                        FOREIGN KEY (cliente_id) REFERENCES clientes(id),
                        FOREIGN KEY (item_id) REFERENCES itens(id)
                    );";

                string sqlPapeis = @"
                    CREATE TABLE IF NOT EXISTS papeis (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome TEXT NOT NULL UNIQUE
                    );";

                string sqlUsuarios = @"
                    CREATE TABLE IF NOT EXISTS usuarios (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome TEXT NOT NULL,
                        login TEXT NOT NULL UNIQUE,
                        senha_hash TEXT NOT NULL,
                        papel_id INTEGER NOT NULL,
                        FOREIGN KEY (papel_id) REFERENCES papeis(id)
                    );";

                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = sqlClientes;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = sqlItens;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = sqlLocacoes;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = sqlPapeis;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = sqlUsuarios;
                    cmd.ExecuteNonQuery();

                    // Popula os 3 papéis fixos do sistema (só insere se ainda não existirem)
                    cmd.CommandText = @"
                        INSERT OR IGNORE INTO papeis (nome) VALUES
                            ('Visualizador'), ('Operador'), ('Admin');";
                    cmd.ExecuteNonQuery();

                    // Garante que existe pelo menos 1 admin pra conseguir entrar no sistema
                    cmd.CommandText = "SELECT COUNT(*) FROM usuarios;";
                    long totalUsuarios = (long)cmd.ExecuteScalar();

                    if (totalUsuarios == 0)
                    {
                        // Senha inicial: "admin123" — já cadastrada como hash BCrypt, nunca em texto puro
                        string hashInicial = BCrypt.Net.BCrypt.HashPassword("admin123");

                        cmd.CommandText = @"
                            INSERT INTO usuarios (nome, login, senha_hash, papel_id)
                            SELECT 'Administrador', 'admin', @hash, id FROM papeis WHERE nome = 'Admin';";
                        cmd.Parameters.AddWithValue("@hash", hashInicial);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}