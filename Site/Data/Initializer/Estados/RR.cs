using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class RR
    {
        private readonly ApplicationDbContext _context;

        public RR(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: RR
            //----------------------------------------------------

            // cidade: Alto Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3929,
                Nome = "Alto Alegre",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Amajari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3930,
                Nome = "Amajari",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Boa Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3931,
                Nome = "Boa Vista",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Bonfim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3932,
                Nome = "Bonfim",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Cantá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3933,
                Nome = "Cantá",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Caracaraí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3934,
                Nome = "Caracaraí",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Caroebe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3935,
                Nome = "Caroebe",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Iracema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3936,
                Nome = "Iracema",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Mucajaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3937,
                Nome = "Mucajaí",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Normandia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3938,
                Nome = "Normandia",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Pacaraima
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3939,
                Nome = "Pacaraima",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Rorainópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3940,
                Nome = "Rorainópolis",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: São João da Baliza
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3941,
                Nome = "São João da Baliza",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: São Luís
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3942,
                Nome = "São Luís",
                Situacao = "Ativo",
                UF = "RR"
            });

            // cidade: Uiramutã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3943,
                Nome = "Uiramutã",
                Situacao = "Ativo",
                UF = "RR"
            });


            await _context.SaveChangesAsync();
        }
    }
}
