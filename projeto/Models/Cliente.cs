namespace projeto.Models
{
    public class Cliente
    {
        // Adicione esta propriedade para o ID do banco de dados
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Contato { get; set; }

        // O construtor que você já usa para criar novos clientes
        public Cliente(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }
        public override string ToString()
        {
            return this.Nome;
        }
    }

}