using JefersonDeSouza.DesignerPatterns.Strategy.Correto;
using JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02;
using JefersonDeSouza.DesignerPatterns.TemplateMethod.Incorreto.Exemplo02;
using System;
using Orcamento = JefersonDeSouza.DesignerPatterns.TemplateMethod.Incorreto.Exemplo01.Orcamento;

namespace JefersonDeSouza.DesignerPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestarCalculadoraDeImpostoIncorreto();
            //TestarCalculadoraDeImpostoCorreto();
            //TestarMapeadorDeDataSetIncoreto();
            TestarMapeadorDeDataSetCorreto();
            Console.ReadLine();
        }

        static void TestarCalculadoraDeImpostoIncorreto()
        {
            var orcamento = new Orcamento(500.0M);
            var imposto = new Strategy.Incorreto.CalculadoraDeImposto();

            Console.WriteLine(imposto.Calcular(orcamento, "ISS"));
            Console.WriteLine(imposto.Calcular(orcamento, "ICMS"));
            Console.WriteLine(imposto.Calcular(orcamento, "INSS"));
        }

        static void TestarCalculadoraDeImpostoCorreto()
        {
            var orcamento = new TemplateMethod.Correto.Exemplo01.Orcamento(500.0M);
            var calculadoraDeImposto = new Strategy.Correto.CalculadoraDeImposto();

            Console.WriteLine(calculadoraDeImposto.Calcular(orcamento, new ISS()));
            Console.WriteLine(calculadoraDeImposto.Calcular(orcamento, new ICMS()));         
        }

        static void TestarMapeadorDeDataSetIncoreto()
        {
            new TemplateMethod.Incorreto.Exemplo02.DataSetResult().MapearDataSet();
        }

        static void TestarMapeadorDeDataSetCorreto()
        {
            new TemplateMethod.Correto.Exemplo02.DataSetResult().MapearDataSet();
        }
    }
}
