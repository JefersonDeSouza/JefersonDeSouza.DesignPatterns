using System;
using System.Data;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02
{
    public class DataSetUsuario : TemplateDeDataSetCondicional
    {
        protected override void PopularDadaset(DataSet dataSet, DataSetEntity dataSetEntity)
        {
            dataSetEntity.Usuario = new Usuario(Convert.ToInt64(dataSet.Tables[0].Rows[0]["CodUsuario"]));            
        }

        protected override void PopularListaDataSet(DataSet dataSet, DataSetEntity dataSetEntity)
        {             
        }

        protected override bool VerificarSeDevoPopularUmaLista(DataSet dataSet)
        {
            return dataSet.Tables[0] != null && dataSet.Tables[0].Rows.Count > 1;
        }
    }
}
