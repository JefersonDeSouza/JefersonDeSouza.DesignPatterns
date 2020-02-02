namespace JefersonDeSouza.DesignerPatterns.Strategy.Correto
{
    class CalculadoraDeImposto
    {
        public decimal Calcular(TemplateMethod.Correto.Exemplo01.Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
