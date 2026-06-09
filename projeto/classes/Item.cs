using System;

namespace ControleLocacao
{
    public class Item
    {
        public string Nome { get; set; }
        public decimal ValorDiario { get; set; }

        public Item(string nome, decimal valorDiario)
        {
            Nome = nome;
            ValorDiario = valorDiario;
        }
    }
}