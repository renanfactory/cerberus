using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Cep;
using System;
using System.Globalization;
using System.Collections.Generic;
using Site.Data.Entities;
using System.Threading.Tasks;

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
            var itens = _context.Cidades
                                .Where(e => e.UF == uf)
                                .Select(c => new ItemPrefeituraModel() { id = c.Id, nome = c.Nome })
                                .ToList();

            if (!itens.Any()) return new NoContentResult();
            itens.Insert(0, new ItemPrefeituraModel { id = 0, nome = "(Selecione)" });
            return new JsonResult(itens);
        }

        public IActionResult OnGetFilterCep(string cep)
        {
            if (string.IsNullOrEmpty(cep))
            {
                return new NotFoundResult();
            }
            var Item = _cepdbContext.Ceps.Where(e => e.Cep == cep.Replace("-", "")).FirstOrDefault();
            if (Item != null)
            {
                return new JsonResult(Item);
            }
            return new NotFoundResult();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (ModelState.IsValid)
            //{
            //    var MyCultureInfo = new CultureInfo("pt-BR");

            //    var Item = new Data.Entities.GrupoEconomico
            //    {
            //        CNPJ = Input.CNPJ,
            //        InscricaoMunicipal = Input.InscricaoEstadual,
            //        DataFundacao = DateTime.Parse(Input.DataFundacao, MyCultureInfo),
            //        Nome = Input.Nome,
            //        NomeFantasia = Input.NomeFantasia,
            //        Situacao = "Ativo",
            //        Telefones = new List<TelefoneGrupoEconomico>
            //            {
            //                new TelefoneGrupoEconomico
            //                {
            //                    CodigoPais = Input.DDI,
            //                    CodigoRegiao = Input.CodigoRegiao,
            //                    Numero = Input.NumeroTelefone,
            //                    Ramal = Input.Ramal,
            //                    TipoTelefone = _context.TiposdeTelefone.FirstOrDefault(c => c.Nome == "Comercial"),
            //                    DataCriacao = DateTime.Now,
            //                    Situacao = "Ativo",
            //                    Principal = true
            //                }
            //            },
            //        Enderecos = new List<EnderecoGrupoEconomico>
            //            {
            //                new EnderecoGrupoEconomico
            //                {
            //                    Cep = Input.CEP,
            //                    Logradouro = Input.Logradouro,
            //                    Cidade = Input.CodigoMunicipio,
            //                    Complemento = Input.Complemento,
            //                    Numero = Input.Numero,
            //                    UF = Input.UF,
            //                    DataCriacao = DateTime.Now,
            //                    Situacao = "Ativo",
            //                    Principal = true
            //                }
            //            }
            //    };

            //    await _context.GruposEconomicos.AddAsync(Item);
            //    await _context.SaveChangesAsync();

            //    return RedirectToPage("../GrupoEconomico");
            //}
            Update();
            return Page();
        }

        private void Update()
        {
            ViewData["Estados"] = _context.Estados
                                          .Where(e => e.Situacao == "Ativo")
                                          .OrderBy(e => e.UnidadeFederativa)
                                          .Select(e => new ItemUFModel { sigla = e.Id, nome = e.UnidadeFederativa })
                                          .ToArray();

            ViewData["RamosDeAtividades"] = _context.RamosDeAtividades
                                   .Where(e => e.Situacao == "Ativo")
                                   .Select(e => new ItemRamoAtividade { id = e.Id , nome = e.Nome })
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
            [Display(Name = "Ramos de atividades", Prompt = "Ramos de atividades")]
            public string[] RamoAtividade { get; set; }

            [Required]
            [Display(Name = "Nome fantasia", Prompt = "Nome fantasia")]
            public string NomeFantasia { get; set; }

            [Required]
            [Display(Name = "Código de país", Prompt = "Ex: +055")]
            public string DDI { get; set; }

            [Required]
            [Display(Name = "Código de região", Prompt = "Ex: (011)")]
            public string CodigoRegiao { get; set; }

            [Required]
            [Display(Name = "Número de telefone", Prompt = "Ex: 9999-9999")]
            public string NumeroTelefone { get; set; }

            [Display(Name = "Ramal", Prompt = "Ex: 0011")]
            public string Ramal { get; set; }

            [Required]
            [MaxLength(length: 9)]
            [Display(Name = "CEP", Prompt = "Ex: 99999-999")]
            public string CEP { get; set; }

            [Required]
            [Display(Name = "Logradouro", Prompt = "Logradouro...")]
            public string Logradouro { get; set; }

            [Required]
            [Display(Name = "Numero", Prompt = "Numero...")]
            public string Numero { get; set; }

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
    public class ItemUFModel
    {
        public string sigla { get; set; }
        public string nome { get; set; }
    }

    public class ItemPrefeituraModel
    {
        public int id { get; set; }
        public string nome { get; set; }
    }
    public class ItemRamoAtividade
    {
        public int id { get; set; }
        public string nome { get; set; }
    }
}