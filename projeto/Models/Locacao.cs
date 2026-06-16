using System;


namespace projeto.Models
{
    public class Locacao
    {
        public Cliente Cliente { get; set; }
        public Item Item { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public decimal ValorTotal { get; private set; }
        public bool Ativa { get; private set; }

        public Locacao(Cliente cliente, Item item, DateTime dataRetirada, DateTime dataPrevistaDevolucao)
        {
            Cliente = cliente;
            Item = item;
            DataRetirada = dataRetirada;
            DataPrevistaDevolucao = dataPrevistaDevolucao;
            Ativa = true;
            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
            TimeSpan diferenca = DataPrevistaDevolucao.Date - DataRetirada.Date;
            int dias = diferenca.Days;
            if (dias <= 0) dias = 1;

            ValorTotal = dias * Item.ValorDiario;
        }

        public void RegistrarDevolucao()
        {
            Ativa = false;
        }

        public override string ToString()
        {
            
            return $"{this.Cliente.Nome} -> {this.Item.Nome}";
        }

    }
}