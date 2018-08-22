using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Site.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Site.Data.Initializer
{
    public class UsuariosInitializer
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsuariosInitializer(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }

        public async Task InitializeAsync()
        {
            var user = new ApplicationUser
            {
                Nome = "Admin",
                Sobrenome = "Cerberus",
                AccessFailedCount = 0,
                Email = "admin@gmail.com",
                EmailConfirmed = false,
                LockoutEnabled = true,
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                TwoFactorEnabled = false,
                UserName = "admin@gmail.com",
                Situacao = "Ativo",
                HorarioEntrada = "00:00",
                HorarioSaida = "23:59:59",
                DataNascimento = DateTime.Now,
                CPF = "999.999.999-99"
            };

            var result = await _userManager.CreateAsync(user, "Admin01*");

            if (result.Succeeded)
            {
                var adminUser = await _userManager.FindByNameAsync(user.UserName);
                // Assigns the administrator role.
                await _userManager.AddToRoleAsync(adminUser, "administrator");
                // Assigns claims.
                var claims = new List<Claim> {
                    new Claim(type: JwtClaimTypes.GivenName, value: user.Nome),
                    new Claim(type: JwtClaimTypes.FamilyName, value: user.Sobrenome),
                };
                await _userManager.AddClaimsAsync(adminUser, claims);
            }
        }
    }
}
