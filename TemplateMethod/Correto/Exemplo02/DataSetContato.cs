using System;
using System.Data;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02
{
    public class DataSetContato : TemplateDeDataSetCondicional
    {
        protected override void PopularDadaset(DataSet dataSet, DataSetEntity dataSetEntity)
        {
        }

        protected override void PopularListaDataSet(DataSet dataSet, DataSetEntity dataSetEntity)
        {
            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                dataSetEntity.Contatos.Add(new Contato(Convert.ToInt64(row["CodContato"])));
            }
        }

        protected override bool VerificarSeDevoPopularUmaLista(DataSet dataSet)
        {
            return dataSet.Tables[1] != null && dataSet.Tables[1].Rows.Count > 0;
        }
    }
}
