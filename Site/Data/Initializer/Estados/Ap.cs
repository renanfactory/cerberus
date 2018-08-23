using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class AP
    {
        private readonly ApplicationDbContext _context;

        public AP(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: AP
            //----------------------------------------------------

            // cidade: Amapá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 187,
                Nome = "Amapá",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Amapari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 188,
                Nome = "Amapari",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Calçoene
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 189,
                Nome = "Calçoene",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Cutias
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 190,
                Nome = "Cutias",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Ferreira Gomes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 191,
                Nome = "Ferreira Gomes",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Itaubal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 192,
                Nome = "Itaubal",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Laranjal do Jari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 193,
                Nome = "Laranjal do Jari",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Macapá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 194,
                Nome = "Macapá",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Mazagão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 195,
                Nome = "Mazagão",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Oiapoque
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 196,
                Nome = "Oiapoque",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Porto Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 197,
                Nome = "Porto Grande",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Pracuúba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 198,
                Nome = "Pracuúba",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Santana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 199,
                Nome = "Santana",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Serra do Navio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 200,
                Nome = "Serra do Navio",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Tartarugalzinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 201,
                Nome = "Tartarugalzinho",
                Situacao = "Ativo",
                UF = "AP"
            });

            // cidade: Vitória do Jari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 202,
                Nome = "Vitória do Jari",
                Situacao = "Ativo",
                UF = "AP"
            });


            await _context.SaveChangesAsync();
        }
    }
}
