using System;

namespace projeto.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ItemId { get; set; }
        public string NomeCliente { get; set; }
        public string NomeItem { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Ativa { get; set; }

        public Locacao(Cliente cliente, Item item, DateTime dataRetirada, DateTime dataPrevistaDevolucao)
        {
            ClienteId = cliente.Id;
            ItemId = item.Id;
            NomeCliente = cliente.Nome;
            NomeItem = item.Nome;
            DataRetirada = dataRetirada;
            DataPrevistaDevolucao = dataPrevistaDevolucao;
            Ativa = true;
            ValorTotal = CalcularValorTotal(item.ValorDiario, dataRetirada, dataPrevistaDevolucao);
        }

        public Locacao()
        {
        }

        private static decimal CalcularValorTotal(decimal valorDiario, DateTime retirada, DateTime devolucaoPrevista)
        {
            TimeSpan diferenca = devolucaoPrevista.Date - retirada.Date;
            int dias = diferenca.Days;
            if (dias <= 0) dias = 1;

            return dias * valorDiario;
        }

        public void RegistrarDevolucao()
        {
            Ativa = false;
        }

        public override string ToString()
        {
            return $"{NomeCliente} -> {NomeItem} (Total: R$ {ValorTotal:N2})";
        }
    }
}