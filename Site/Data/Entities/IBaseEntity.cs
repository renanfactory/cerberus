using System;

namespace Site.Data.Entities
{
    public interface IBaseEntity
    {
        DateTime DataCriacao {get;set;}
        string Situacao { get; set; }
    }
}