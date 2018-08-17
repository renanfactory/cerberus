using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Site.Data.Entities;
using Site.Extensions;

namespace Site.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<ApplicationUser> signInManager, ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "E-mail", Prompt = "E-mail")]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Senha", Prompt = "Senha")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    var user = await _signInManager.UserManager.FindByEmailAsync(Input.Email);

                    var horaEntrada = user.HorarioEntrada.Split(":").Select(c => Convert.ToInt32(c)).ToList();
                    var horaSaida = user.HorarioSaida.Split(":").Select(c => Convert.ToInt32(c)).ToList();

                    var dtHoraEntrada = DateTime.Today.AddHours(horaEntrada[0]).AddMinutes(horaEntrada[1]);
                    if (horaEntrada.Count > 2) dtHoraEntrada = dtHoraEntrada.AddSeconds(horaEntrada[2]);

                    var dtHoraSaida = DateTime.Today.AddHours(horaSaida[0]).AddMinutes(horaSaida[1]);
                    if (horaSaida.Count > 2) dtHoraSaida = dtHoraSaida.AddSeconds(horaSaida[2]);

                    if (DateTime.Now.Between(dtHoraEntrada, dtHoraSaida))
                    {
                        _logger.LogInformation("User logged in.");
                        return LocalRedirect(Url.GetLocalUrl(returnUrl));
                    }
                    else
                    {
                        await _signInManager.SignOutAsync();
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return Page();
                    }
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}