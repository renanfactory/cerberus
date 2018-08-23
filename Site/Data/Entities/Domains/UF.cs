using Site.Data.Entities.Interfaces;
using System;

namespace Site.Data.Entities.Domains
{
    public class UF : IBaseEntity<string>
    {
        public string Id { get; set; }
        public string UnidadeFederativa { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
    }
}
