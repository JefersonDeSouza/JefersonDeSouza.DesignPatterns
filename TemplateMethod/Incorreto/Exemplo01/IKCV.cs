namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Incorreto.Exemplo01
{
    public class IKCV : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07M;
            }
            else
            {
                return orcamento.Valor * 0.05M;
            }
        }
    }
}
