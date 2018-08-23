using Microsoft.AspNetCore.Identity;
using Site.Data.Entities;
using Site.Services;
using System.Linq;
using System.Threading.Tasks;
using Site.Data.Initializer;
using Site.Data.Initializer.Domains;
using Site.Data.Entities.Domains;

namespace Site.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return; // Db has been seeded.
            }

            // Creates Roles.
            var _roleInitializer = new RolesInitializer(_roleManager);
            await _roleInitializer.InitializeAsync();

            // Seeds an admin user.
            var _UsuariosInitializer = new UsuariosInitializer(_userManager);
            await _UsuariosInitializer.InitializeAsync();

            // Seeds estados
            var _EstadosInitializer = new EstadosInitializer(context);
            await _EstadosInitializer.InitializeAsync();


            // Seed Dominios
            var _TiposTelefoneInitializer = new TipoTelefoneInitializer(context);
            await _TiposTelefoneInitializer.InitializeAsync();

            var _RamoDeAtividadeInitializer = new RamoDeAtividadeInitializer(context);
            await _RamoDeAtividadeInitializer.InitializeAsync();
        }
    }
}
