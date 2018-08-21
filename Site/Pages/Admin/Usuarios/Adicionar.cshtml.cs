using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Site.Data.Entities;
using Site.Extensions;
using Site.Services;

namespace Site.Pages.Admin.Usuarios
{
    public class AdicionarUsuarioModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<AdicionarUsuarioModel> _logger;
        private readonly IEmailSender _emailSender;

        public AdicionarUsuarioModel(UserManager<ApplicationUser> userManager,
            ILogger<AdicionarUsuarioModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            var MyCultureInfo = new CultureInfo("pt-BR");

            // Seeds an admin user.
            var user = new ApplicationUser
            {
                Nome = Input.Nome,
                Sobrenome = Input.Sobrenome,
                AccessFailedCount = 0,
                Email = Input.Email,
                EmailConfirmed = true,
                LockoutEnabled = true,
                NormalizedEmail = Input.Email.ToUpperInvariant(),
                NormalizedUserName = Input.Email.ToUpperInvariant(),
                TwoFactorEnabled = false,
                UserName = Input.Email,
                Situacao = "Ativo",
                HorarioEntrada = Input.HorarioEntrada,
                HorarioSaida = Input.HorarioSaida,
                CPF = Input.CPF,
                DataNascimento = DateTime.Parse(Input.DataNascimento, MyCultureInfo)
            };

            var password = HelperExtensions.GeneratePassword(3, 2, 2, 1);

            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");


                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                await _emailSender.SendEmailConfirmationAsync(Input.Email, password, callbackUrl);

                var adminUser = await _userManager.FindByNameAsync(user.UserName);
                // Assigns the administrator role.
                await _userManager.AddToRoleAsync(adminUser, "user");
                // Assigns claims.
                var claims = new List<Claim> {
                    new Claim (type: JwtClaimTypes.GivenName, value: user.Nome),
                    new Claim (type: JwtClaimTypes.FamilyName, value: user.Sobrenome),
                    new Claim (type: JwtClaimTypes.BirthDate, value: user.DataNascimento.ToString ("dd/MM/yyyy"))
                };
                await _userManager.AddClaimsAsync(adminUser, claims);
            }

            return RedirectToPage("../Usuarios");
        }

        public class InputModel
        {
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
            [Display(Name = "Data Nascimento", Prompt = "Ex: 01/01/1990")]
            public string DataNascimento { get; set; }

            [Required]
            [Display(Name = "CPF", Prompt = "Ex: 999.999.999-99")]
            public string CPF { get; set; }
        }
    }
}