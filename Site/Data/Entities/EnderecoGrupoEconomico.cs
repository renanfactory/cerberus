using Site.Data.Entities.Interfaces;
using System;

namespace Site.Data.Entities
{
    public class EnderecoGrupoEconomico : IBaseEntity<int>, IEndereco
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public int Cidade { get; set; }
        public bool Principal { get; set; }
    }
}
