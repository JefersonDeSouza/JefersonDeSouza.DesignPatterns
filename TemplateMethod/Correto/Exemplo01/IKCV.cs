namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo01
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        protected override decimal CalcularMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07M;
        }

        protected override decimal CalcularMinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05M;
        }

        protected override bool DeveUserMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }
    }
}
