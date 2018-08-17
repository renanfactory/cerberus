using Microsoft.AspNetCore.Identity;

namespace Site.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string HorarioEntrada { get; set; }
        public string HorarioSaida { get; set; }


        public string Situacao { get; set; }
    }
}
