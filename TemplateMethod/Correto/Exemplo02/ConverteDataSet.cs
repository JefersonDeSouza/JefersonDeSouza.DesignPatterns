using System;
using System.Data;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Correto.Exemplo02
{
    public static class ConverteDataSet
    {
        public static DataSetEntity Converter(DataSet ds)
        {
            var dataSetEntity = new DataSetEntity();

            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataSetEntity.Usuario.CodUsuario = Convert.ToInt64(row["CodUsuario"]);
                }
            }

            if (ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    dataSetEntity.Contatos.Add(new Contato(Convert.ToInt64(row["CodContato"])));
                }
            }

            if (ds.Tables[2] != null && ds.Tables[2].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[2].Rows)
                {
                    dataSetEntity.Enderecos.Add(new Endereco(Convert.ToInt64(row["CodEndereco"])));
                }
            }

            return dataSetEntity;
        }
    }
}
