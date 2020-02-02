using System.Data;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02
{
    public abstract class TemplateDeDataSetCondicional : IConversorDataSet
    {
        public void Converter(DataSet dataSet, DataSetEntity dataSetEntity)
        {          

            if(VerificarSeDevoPopularUmaLista(dataSet))
            {
                PopularListaDataSet(dataSet, dataSetEntity);
            }
            else
            {
                PopularDadaset(dataSet, dataSetEntity);
            }            
        }

        protected abstract bool VerificarSeDevoPopularUmaLista(DataSet dataSet);

        protected abstract void PopularDadaset(DataSet dataSet, DataSetEntity dataSetEntity);

        protected abstract void PopularListaDataSet(DataSet dataSet, DataSetEntity dataSetEntity);
    }
}
