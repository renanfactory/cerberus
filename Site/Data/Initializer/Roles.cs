using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Site.Data.Initializer
{
    public class RolesInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesInitializer(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task InitializeAsync()
        {
            // Creates Roles.
            await _roleManager.CreateAsync(new IdentityRole("administrator"));
            await _roleManager.CreateAsync(new IdentityRole("user"));
        }
    }
}
