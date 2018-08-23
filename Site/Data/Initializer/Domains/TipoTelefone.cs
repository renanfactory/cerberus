using System;

namespace Site.Data.Initializer.Domains
{
    public class TipoTelefoneInitializer
    {
        private readonly ApplicationDbContext _context;

        public TipoTelefoneInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task InitializeAsync()
        {
            await _context.TiposdeTelefone.AddAsync(new Entities.Domains.TipoTelefone
            {
                DataCriacao = DateTime.Now,
                Situacao = "Ativo",
                Nome = "Residencial"
            });
            await _context.TiposdeTelefone.AddAsync(new Entities.Domains.TipoTelefone
            {
                DataCriacao = DateTime.Now,
                Situacao = "Ativo",
                Nome = "Comercial"
            });
            await _context.TiposdeTelefone.AddAsync(new Entities.Domains.TipoTelefone
            {
                DataCriacao = DateTime.Now,
                Situacao = "Ativo",
                Nome = "Celular"
            });

            await _context.SaveChangesAsync();
        }
    }
}
