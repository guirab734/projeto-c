using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorDiario { get; set; }
        public List<string> Componentes { get; set; }

        public Item(string nome, decimal valorDiario)
        {
            Nome = nome;
            ValorDiario = valorDiario;
            Componentes = new List<string>();
        }

        public string ComponentesParaTexto()
        {
            return string.Join(",", Componentes);
        }

        public static List<string> TextoParaComponentes(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return new List<string>();

            return texto.Split(',')
                         .Select(p => p.Trim())
                         .Where(p => !string.IsNullOrEmpty(p))
                         .ToList();
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}