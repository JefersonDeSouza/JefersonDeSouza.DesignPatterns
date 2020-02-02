using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Incorreto.Exemplo02
{
    public class DataSetResult
    {
        public void MapearDataSet()
        {
            using (SqlConnection con = new SqlConnection($@"Server=DESKTOP-OIA04BE\SQLEXPRESS;Database=Curso_Design_Patterns;Trusted_Connection=True;"))
            {
                //using (SqlDataAdapter adp = new SqlDataAdapter("P_CURSO_DP_EXEMPLO_DATA_SET", con))
                //{
                //    DataSet ds = new DataSet();
                //    adp.Fill(ds);

                //    var dataSetEntity = ConverteDataSet.Converter(ds);
                //}                
                con.Open();
                using (SqlCommand command = new SqlCommand("P_CURSO_DP_EXEMPLO_DATA_SET", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.HasRows)
                        {
                            Console.WriteLine("\t{0}\t{1}", reader.GetName(0),
                                reader.GetName(1));

                            while (reader.Read())
                            {
                                Console.WriteLine("\t{0}\t{1}", reader.GetInt64(0),
                                    reader.GetString(1));
                            }
                            reader.NextResult();
                        }
                    }
                }
            }
        }
    }
}
