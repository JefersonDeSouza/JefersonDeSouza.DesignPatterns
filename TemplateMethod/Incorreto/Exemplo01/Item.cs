namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Incorreto.Exemplo01
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