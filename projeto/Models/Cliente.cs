using System;

namespace projeto.Models
{
    public class Cliente
    {
        public int Id { get; set; } // O banco vai usar isso para identificar cada cliente
        public string Nome { get; set; }
        public string Contato { get; set; }

        public Cliente(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }
    }
}