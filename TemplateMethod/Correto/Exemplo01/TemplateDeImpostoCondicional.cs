using System;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo01
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (DeveUserMaximaTaxacao(orcamento))
            {
                return CalcularMaximaTaxacao(orcamento);
            }
            else
            {
                return CalcularMinimaTaxacao(orcamento);
            }
        }

        protected abstract decimal CalcularMinimaTaxacao(Orcamento orcamento);

        protected abstract decimal CalcularMaximaTaxacao(Orcamento orcamento);

        protected abstract bool DeveUserMaximaTaxacao(Orcamento orcamento);
    }
}
