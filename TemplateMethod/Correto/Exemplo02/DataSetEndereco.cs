using System;
using System.Data;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02
{
    public class DataSetEndereco : TemplateDeDataSetCondicional
    {
        protected override void PopularDadaset(DataSet dataSet, DataSetEntity dataSetEntity)
        {            
        }

        protected override void PopularListaDataSet(DataSet dataSet, DataSetEntity dataSetEntity)
        {            
            foreach (DataRow row in dataSet.Tables[2].Rows)
            {
                dataSetEntity.Enderecos.Add(new Endereco(Convert.ToInt64(row["CodEndereco"])));
            }
        }

        protected override bool VerificarSeDevoPopularUmaLista(DataSet dataSet)
        {
            return dataSet.Tables[2] != null && dataSet.Tables[2].Rows.Count > 0;
        }
    }
}
