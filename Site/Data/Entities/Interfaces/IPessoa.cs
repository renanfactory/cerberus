using System;

namespace Site.Data.Entities.Interfaces
{
    public interface IPessoa
    {
        string CPF { get; set; }
        string RG { get; set; }
        DateTime DataNascimento { get; set; }
    }
}