using System;

namespace Site.Data.Entities
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime DataCriacao { get; set; }
        string Situacao { get; set; }
    }
}