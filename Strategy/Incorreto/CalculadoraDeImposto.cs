namespace JefersonDeSouza.DesignerPatterns.Strategy.Incorreto
{
    class CalculadoraDeImposto
    {
        public decimal Calcular(TemplateMethod.Incorreto.Exemplo01.Orcamento orcamento, string imposto)
        {
            if ("ISS".Equals(imposto))
                return orcamento.Valor * 0.05M;
            else if ("ICMS".Equals(imposto))
                return orcamento.Valor * 0.06M;

            return 0;
        }
    }
}
