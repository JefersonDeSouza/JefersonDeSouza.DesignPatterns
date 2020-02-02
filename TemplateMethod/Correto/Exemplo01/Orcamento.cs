using JefersonDeSouza.DesignerPatterns.Strategy.Correto;
using System.Collections.Generic;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo01
{
    public class Orcamento
    {
        public decimal Valor { get; }
        public List<Item> Itens { get; set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }
    }
}
