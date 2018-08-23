using Site.Data.Entities.Domains;
using System;

namespace Site.Data.Initializer.Domains
{
    public class RamoDeAtividadeInitializer
    {
        private readonly ApplicationDbContext _context;

        public RamoDeAtividadeInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task InitializeAsync()
        {
            await _context.RamosDeAtividades.AddAsync(new RamoDeAtividade
            {
                DataCriacao = DateTime.Now,
                Situacao = "Ativo",
                Nome = "Indústria"
            });
            await _context.RamosDeAtividades.AddAsync(new RamoDeAtividade
            {
                DataCriacao = DateTime.Now,
                Situacao = "Ativo",
                Nome = "Comércio"
            });
            await _context.RamosDeAtividades.AddAsync(new RamoDeAtividade
            {
                DataCriacao = DateTime.Now,
                Situacao = "Ativo",
                Nome = "Prestação de serviços"
            });

            await _context.SaveChangesAsync();
        }
    }
}
