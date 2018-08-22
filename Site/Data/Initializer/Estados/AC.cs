using System;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class AC
    {
        private readonly ApplicationDbContext _context;

        public AC(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: AC
            //----------------------------------------------------

            // cidade: Acrelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1,
                Nome = "Acrelândia",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Assis Brasil
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2,
                Nome = "Assis Brasil",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Brasiléia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3,
                Nome = "Brasiléia",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Bujari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4,
                Nome = "Bujari",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Capixaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5,
                Nome = "Capixaba",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Cruzeiro do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 6,
                Nome = "Cruzeiro do Sul",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Epitaciolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 7,
                Nome = "Epitaciolândia",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Feijó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 8,
                Nome = "Feijó",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Jordão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 9,
                Nome = "Jordão",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Mâncio Lima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 10,
                Nome = "Mâncio Lima",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Manoel Urbano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 11,
                Nome = "Manoel Urbano",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Marechal Thaumaturgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 12,
                Nome = "Marechal Thaumaturgo",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Plácido de Castro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 13,
                Nome = "Plácido de Castro",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Porto Acre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 14,
                Nome = "Porto Acre",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Porto Walter
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 15,
                Nome = "Porto Walter",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Rio Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 16,
                Nome = "Rio Branco",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Rodrigues Alves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 17,
                Nome = "Rodrigues Alves",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Santa Rosa do Purus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 18,
                Nome = "Santa Rosa do Purus",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Sena Madureira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 19,
                Nome = "Sena Madureira",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Senador Guiomard
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 20,
                Nome = "Senador Guiomard",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Tarauacá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 21,
                Nome = "Tarauacá",
                Situacao = "Ativo",
                UF = "AC"
            });

            // cidade: Xapuri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 22,
                Nome = "Xapuri",
                Situacao = "Ativo",
                UF = "AC"
            });

            await _context.SaveChangesAsync();
        }
    }
}
