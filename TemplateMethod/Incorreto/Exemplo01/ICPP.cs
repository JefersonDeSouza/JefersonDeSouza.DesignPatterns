using System.Linq;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Incorreto.Exemplo01
{
    public class ICPP : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && VerificarSeExisteItemDoOrcamentoMaiorQueCemReais(orcamento))
            {
                return orcamento.Valor * 1;
            }
            else
            {
                return orcamento.Valor * 0.06M;
            }
        }

        private bool VerificarSeExisteItemDoOrcamentoMaiorQueCemReais(Orcamento orcamento)
        {
            return orcamento?.Itens?.Any(i => i.Valor > 100) ?? false;
        }
    }
}
