using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Data;
using Site.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.Admin
{
    public class UsuariosModel : PageModel
    {
        private ApplicationDbContext ApplicationDbContext;

        public UsuariosModel(ApplicationDbContext _ApplicationDbContext)
        {
            ApplicationDbContext = _ApplicationDbContext;
            Usuarios = new List<ApplicationUser>();
        }

        [BindProperty]
        public List<ApplicationUser> Usuarios { get; set; }

        public void OnGet()
        {
            Usuarios = ApplicationDbContext.Users.ToList();
        }


    }
}