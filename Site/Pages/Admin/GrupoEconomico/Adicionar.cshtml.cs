using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Cerberus.Extensions;
using System.Collections.Generic;
using Cep;

namespace Site.Pages.Admin.GrupoEconomico
{
    public class AdicionarGrupoEconomicoModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly CepDbContext _cepdbContext;

        public AdicionarGrupoEconomicoModel(ApplicationDbContext context, CepDbContext cepdbContext)
        {
            _context = context;
            _cepdbContext = cepdbContext;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public void OnGet()
        {
            Update();
        }

        public IActionResult OnGetCidadeList(string uf)
        {
            var itens = _context.Cidades.Where(e => e.UF == uf).ToList();
            if (itens.Any()) return new NotFoundResult();

            itens.Insert(0, new Data.Entities.Cidade { Id = 0, Nome = "(Selecione)" });

            return new JsonResult(itens);
        }

        public IActionResult OnGetFilterCep(string cep)
        {
            var Item = _cepdbContext.Ceps.Where(e => e.Cep == cep.Replace("-", "")).FirstOrDefault();
            if (Item != null)
            {
                return new JsonResult(Item);
            }
            return new NotFoundResult();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {






                return RedirectToPage("../GrupoEconomico");
            }
            Update();
            return Page();
        }

        private void Update()
        {
            ViewData["Estados"] = _context.Estados
                                                  .Where(e => e.Situacao == "Ativo")
                                                  .OrderBy(c => c.UnidadeFederativa)
                                                  .Select(c => new ItemUF { sigla = c.Id, nome = c.UnidadeFederativa })
                                                  .ToArray();
        }

        public class InputModel
        {
            [Required]
            [Display(Name = "CNPJ", Prompt = "Ex: 99.999.999/9999-99")]
            public string CNPJ { get; set; }

            [Required]
            [Display(Name = "Data de fundação", Prompt = "Ex: 99/99/9999")]
            public string DataFundacao { get; set; }

            [Required]
            [Display(Name = "Nome", Prompt = "Nome")]
            public string Nome { get; set; }

            [Required]
            [Display(Name = "Nome fantasia", Prompt = "Nome fantasia")]
            public string NomeFantasia { get; set; }

            [Required]
            [Display(Name = "CEP", Prompt = "Ex: 99999-999")]
            public string CEP { get; set; }

            [Required]
            [Display(Name = "Logradouro", Prompt = "Logradouro...")]
            public string Logradouro { get; set; }

            [Required]
            [Display(Name = "Numero", Prompt = "Numero...")]
            public string Numero { get; set; }

            [Required]
            [Display(Name = "Complemento", Prompt = "Complemento...")]
            public string Complemento { get; set; }

            [Required]
            [Display(Name = "UF", Prompt = "UF")]
            public string UF { get; set; }

            [Required]
            [Display(Name = "Cidade", Prompt = "Cidade")]
            public int CodigoMunicipio { get; set; }

            [Required]
            [Display(Name = "Inscrição estadual", Prompt = "Inscrição estadual")]
            public string InscricaoEstadual { get; set; }
        }
    }
    public class ItemUF
    {
        public string sigla { get; set; }
        public string nome { get; set; }
    }
}