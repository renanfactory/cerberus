using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Data;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;

namespace Site.Pages.Administrador.Usuarios
{
    public class UsuarioEditarModel : PageModel
    {
        private ApplicationDbContext ApplicationDbContext;

        public UsuarioEditarModel(ApplicationDbContext _ApplicationDbContext)
        {
            ApplicationDbContext = _ApplicationDbContext;
        }


        [BindProperty]
        public InputModel Input { get; set; }

        public void OnGet(string id)
        {
            ViewData["Id"] = id;
            var item = ApplicationDbContext.Users.Find(id);

            Input = new InputModel()
            {
                Id = id,
                Email = item.Email,
                Nome = item.Nome,
                Sobrenome = item.Sobrenome,
                Bloqueado = item.Situacao.Equals("Bloqueado"),
                HorarioEntrada = item.HorarioEntrada,
                HorarioSaida = item.HorarioSaida,
                DataNascimento = item.DataNascimento.ToString("dd/MM/yyyy"),
                CPF = item.CPF
            };
        }

        public IActionResult OnPost()
        {
            var id = Input.Id;
            var item = ApplicationDbContext.Users.Find(id);
            var MyCultureInfo = new CultureInfo ("pt-BR");

            item.Nome = Input.Nome;
            item.Sobrenome = Input.Sobrenome;
            item.Email = Input.Email;
            item.Situacao = Input.Bloqueado ? "Bloqueado" : "Ativo";
            item.HorarioEntrada = Input.HorarioEntrada;
            item.HorarioSaida = Input.HorarioSaida;
            item.CPF = Input.CPF;
            item.DataNascimento = DateTime.Parse (Input.DataNascimento, MyCultureInfo);

            ApplicationDbContext.SaveChanges();

            return new OkResult();
        }

        public class InputModel
        {
            public string Id { get;set;}

            [Required]
            [Display(Name = "Nome", Prompt = "Nome")]
            public string Nome { get; set; }

            [Required]
            [Display(Name = "Sobrenome", Prompt = "Sobrenome")]
            public string Sobrenome { get; set; }

            [Required]
            [Display(Name = "Email", Prompt = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Horario de entrada", Prompt = "Ex: 09:00")]
            public string HorarioEntrada { get; set; }

            [Required]
            [Display(Name = "Horario de saida", Prompt = "Ex: 18:00")]
            public string HorarioSaida { get; set; }

            [Required]
            [Display (Name = "Data Nascimento", Prompt = "Ex: 01/01/1990")]
            public string DataNascimento { get; set; }

            [Required]
            [Display (Name = "CPF", Prompt = "Ex: 999.999.999-99")]
            public string CPF { get; set; }

            [Required]
            [Display(Name = "Bloqueado?")]
            public bool Bloqueado { get; set; }
        }
    }
}