using System;
using System.Collections.Generic;

namespace projeto.Models
{
    public class Item
    {
        public string Nome { get; set; }
        public decimal ValorDiario { get; set; }

        // Armazena a lista de peças do setup de hardware
        public List<string> Componentes { get; set; }

        public Item(string nome, decimal valorDiario)
        {
            Nome = nome;
            ValorDiario = valorDiario;
            Componentes = new List<string>();
        }
    }
}