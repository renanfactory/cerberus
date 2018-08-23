using System;
using Microsoft.AspNetCore.Identity;
using Site.Data.Entities.Interfaces;

namespace Site.Data.Entities
{
    public class ApplicationUser : IdentityUser, IPessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string HorarioEntrada { get; set; }
        public string HorarioSaida { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
    }
}
