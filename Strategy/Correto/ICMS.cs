namespace JefersonDeSouza.DesignerPatterns.Strategy.Correto
{
    class ICMS : IImposto
    {
        public decimal Calcular(TemplateMethod.Correto.Exemplo01.Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
    }
}
