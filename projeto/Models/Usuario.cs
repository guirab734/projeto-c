using System;

namespace projeto.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string SenhaHash { get; set; }
        public int PapelId { get; set; }

        // Preenchido pelo Repository via JOIN, só para exibição
        public string NomePapel { get; set; }

        public override string ToString()
        {
            return $"{Nome} ({NomePapel})";
        }
    }
}