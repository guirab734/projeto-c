namespace projeto.Models
{
    public class Papel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome; // Faz o ComboBox mostrar o nome do papel
        }
    }
}