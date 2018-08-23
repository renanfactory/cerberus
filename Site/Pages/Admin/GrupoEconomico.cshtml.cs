using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.Admin
{
    public class GrupoEconomicoModel : PageModel
    {
        private ApplicationDbContext _ApplicationDbContext;

        public GrupoEconomicoModel(ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext = ApplicationDbContext;
        }

        [BindProperty]
        public List<GrupoEconomicoItem> GruposEconomicos { get; set; }

        public class GrupoEconomicoItem
        {
            public GrupoEconomicoItem(Data.Entities.GrupoEconomico item)
            {
                Id = item.Id;
                Situacao = item.Situacao;
                CNPJ = item.CNPJ;
                Nome = item.Nome;
                NomeFantasia = item.NomeFantasia;
                var endereco = item.Enderecos.FirstOrDefault(c => c.Principal);
                UF = endereco != null ? endereco.UF : "";
            }

            public Guid Id { get; set; }
            public string Situacao { get; set; }
            public string CNPJ { get; set; }
            public string Nome { get; set; }
            public string NomeFantasia { get; set; }
            public string UF { get; set; }
        }

        public void OnGet()
        {
            GruposEconomicos = _ApplicationDbContext.GruposEconomicos
                                                    .Include(e => e.Enderecos)
                                                    .Select(e => new GrupoEconomicoItem(e))
                                                    .ToList();
        }
    }
}