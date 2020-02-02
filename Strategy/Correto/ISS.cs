namespace JefersonDeSouza.DesignerPatterns.Strategy.Correto
{
    class ISS : IImposto
    {
        public decimal Calcular(TemplateMethod.Correto.Exemplo01.Orcamento orcamento)
        {
            return orcamento.Valor * 0.05M;
        }
    }
}
