using System;
using System.Collections.Generic;
using System.Data.SQLite;
using projeto.Models;
using projeto.Data;

namespace projeto.Repositories
{
    public class UsuarioRepository
    {
        // Cadastra um novo usuário. A senha chega aqui já em TEXTO PURO
        // (digitada pelo Admin na tela) e é transformada em hash AQUI,
        // antes de qualquer gravação — nunca guardamos a senha original.
        public void Salvar(Usuario usuario, string senhaTextoPuro)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(senhaTextoPuro);

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO usuarios (nome, login, senha_hash, papel_id)
                    VALUES (@nome, @login, @hash, @papelId)";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@login", usuario.Login);
                    cmd.Parameters.AddWithValue("@hash", hash);
                    cmd.Parameters.AddWithValue("@papelId", usuario.PapelId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Busca um usuário pelo login (usado na hora de autenticar)
        public Usuario BuscarPorLogin(string login)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT u.id, u.nome, u.login, u.senha_hash, u.papel_id, p.nome AS nome_papel
                    FROM usuarios u
                    INNER JOIN papeis p ON p.id = u.papel_id
                    WHERE u.login = @login";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Login = reader["login"].ToString(),
                                SenhaHash = reader["senha_hash"].ToString(),
                                PapelId = Convert.ToInt32(reader["papel_id"]),
                                NomePapel = reader["nome_papel"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Usuario> ObterTodos()
        {
            var lista = new List<Usuario>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT u.id, u.nome, u.login, u.senha_hash, u.papel_id, p.nome AS nome_papel
                    FROM usuarios u
                    INNER JOIN papeis p ON p.id = u.papel_id";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Usuario
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Login = reader["login"].ToString(),
                            SenhaHash = reader["senha_hash"].ToString(),
                            PapelId = Convert.ToInt32(reader["papel_id"]),
                            NomePapel = reader["nome_papel"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        // Confere se a senha digitada bate com o hash guardado.
        public bool ValidarSenha(string senhaDigitada, string hashGuardado)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, hashGuardado);
        }

        // Busca os 3 papéis fixos do sistema, para popular o ComboBox
        public List<Papel> ObterPapeis()
        {
            var lista = new List<Papel>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id, nome FROM papeis";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Papel
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        // Verifica se já existe algum usuário com esse login
        public bool LoginJaExiste(string login)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM usuarios WHERE login = @login";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}