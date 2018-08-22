using Microsoft.EntityFrameworkCore;

namespace Cep
{
    public class CepDbContext : DbContext
    {
        public CepDbContext(DbContextOptions<CepDbContext> options)
            : base(options) { }

        public DbSet<CepEntity> Ceps { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            var CepEntityBuilder = builder.Entity<CepEntity>();

            CepEntityBuilder.ToTable("cep");
            CepEntityBuilder.HasKey(c => c.Cep);
            CepEntityBuilder.Property(cep => cep.Cep).HasColumnName("cep");
            CepEntityBuilder.Property(cep => cep.Uf).HasColumnName("uf");
            CepEntityBuilder.Property(cep => cep.Cidade).HasColumnName("cidade");
            CepEntityBuilder.Property(cep => cep.Logradouro).HasColumnName("logradouro");
            CepEntityBuilder.Property(cep => cep.TipoLogradouro).HasColumnName("tipo_logradouro");
            CepEntityBuilder.Property(cep => cep.Bairro).HasColumnName("bairro");
        }
    }
}
