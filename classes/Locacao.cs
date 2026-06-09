using System;
using WinControlelLocacao;

namespace ControleLocacao
{
    public class Locacao
    {
        // propriedades
        public Cliente Cliente { get; set; }
        public Item Item { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }

        // atributos
        public decimal ValorTotal { get; private set; }
        public bool Ativa { get; private set; }

        public Locacao(Cliente cliente, Item item, DateTime dataRetirada, DateTime dataPrevistaDevolucao)
        {
            Cliente = cliente;
            Item = item;
            DataRetirada = dataRetirada;
            DataPrevistaDevolucao = dataPrevistaDevolucao;
            Ativa = true; // Toda locação inicia ativa por padrão
            CalcularValorTotal();
        }

        // calcular o valor total
        private void CalcularValorTotal()
        {
            TimeSpan diferenca = DataPrevistaDevolucao.Date - DataRetirada.Date;
            int dias = diferenca.Days;

            // Evita que o sistema calcule 0 ou dias negativos se as datas forem iguais ou invertidas
            if (dias <= 0)
            {
                dias = 1;
            }

            ValorTotal = dias * Item.ValorDiario;
        }

        // Método público para mudar o estado interno do objeto quando o item voltar
        public void RegistrarDevolucao()
        {
            Ativa = false;
        }
    }
}