using Site.Data.Entities.Interfaces;
using System;

namespace Site.Data.Entities.Domains
{
    public class TipoTelefone : IBaseEntity<int>
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        public string Nome { get; set; }
    }
}
