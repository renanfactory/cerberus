using System;

namespace Site.Data.Entities {
    public interface IPessoa {
        string CPF { get; set; }
        DateTime DataNascimento { get; set; }
    }
}