using System;

namespace Site.Data.Entities
{
    public class Cidade : IBaseEntity<int>
    {
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
