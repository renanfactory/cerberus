using Site.Data.Entities.Domains;
using Site.Data.Entities.Interfaces;
using System;

namespace Site.Data.Entities
{
    public class TelefoneGrupoEconomico : IBaseEntity<int>, ITelefone
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        public string CodigoPais { get; set; }
        public string CodigoRegiao { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public string Ramal { get; set; }
        public bool Principal { get; set; }
    }
}
