using System;

namespace Site.Data.Entities
{
    public class UF : IBaseEntity<string>
    {
        public string Id { get; set; }
        public string UnidadeFederativa { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
    }
}
