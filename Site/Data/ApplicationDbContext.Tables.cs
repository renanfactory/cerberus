using Microsoft.EntityFrameworkCore;
using Site.Data.Entities;
using Site.Data.Entities.Domains;

namespace Site.Data
{
    public partial class ApplicationDbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<UF> Estados { get; set; }
        public DbSet<GrupoEconomico> GruposEconomicos { get;set; }
        public DbSet<TipoTelefone> TiposdeTelefone { get; set; }
        public DbSet<RamoDeAtividade> RamosDeAtividades { get; set; }
    }
}
