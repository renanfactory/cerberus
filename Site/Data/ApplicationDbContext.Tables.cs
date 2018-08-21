using Microsoft.EntityFrameworkCore;
using Site.Data.Entities;

namespace Site.Data
{
    public partial class ApplicationDbContext
    {

        public DbSet<GrupoEconomico> GruposEconomicos { get;set;}

    }
}
