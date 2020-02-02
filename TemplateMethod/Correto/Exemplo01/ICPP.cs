using System.Linq;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo01
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        protected override decimal CalcularMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 1;
        }

        protected override decimal CalcularMinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }

        protected override bool DeveUserMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && VerificarSeExisteItemDoOrcamentoMaiorQueCemReais(orcamento);
        }

        private bool VerificarSeExisteItemDoOrcamentoMaiorQueCemReais(Orcamento orcamento)
        {
            return orcamento?.Itens?.Any(i => i.Valor > 100) ?? false;
        }
    }
}
