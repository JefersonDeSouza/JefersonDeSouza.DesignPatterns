using System.Collections.Generic;

namespace JefersonDeSouza.DesignerPatterns.TemplateMethod.Incorreto.Exemplo02
{
    public class DataSetEntity
    {
        public DataSetEntity()
        {
            Usuario = new Usuario();
            Contatos = new List<Contato>();
            Enderecos = new List<Endereco>();
        }
        public Usuario Usuario { get; set; }
        public List<Contato> Contatos { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}