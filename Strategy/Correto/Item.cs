namespace JefersonDeSouza.DesignerPatterns.Strategy.Correto
{
    public class Item
    {
        public string Nome { get; }
        public decimal Valor { get; }

        public Item(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}