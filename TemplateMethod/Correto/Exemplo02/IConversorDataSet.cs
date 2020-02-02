using System.Data;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02
{
    public interface IConversorDataSet
    {
        void Converter(DataSet dataSet, DataSetEntity dataSetEntity);
    }
}