using System.Data;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02
{
    public static class ConversorDeDataSetUsuario 
    {
        public static DataSetEntity ConverterDataSet(DataSet dataSet)
        {
            var dataSetEntity = new DataSetEntity();
            new DataSetUsuario().Converter(dataSet, dataSetEntity);
            new DataSetContato().Converter(dataSet, dataSetEntity);
            new DataSetEndereco().Converter(dataSet, dataSetEntity);

            return dataSetEntity;
        }
    }
}
