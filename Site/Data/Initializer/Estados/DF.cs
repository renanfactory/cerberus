using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class DF
    {
        private readonly ApplicationDbContext _context;

        public DF(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: DF
            //----------------------------------------------------

            // cidade: Águas Claras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 804,
                Nome = "Águas Claras",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Brasília
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 805,
                Nome = "Brasília",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Brazlândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 806,
                Nome = "Brazlândia",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Candangolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 807,
                Nome = "Candangolândia",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Ceilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 808,
                Nome = "Ceilândia",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Cruzeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 809,
                Nome = "Cruzeiro",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Gama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 810,
                Nome = "Gama",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Guará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 811,
                Nome = "Guará",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Itapoã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 812,
                Nome = "Itapoã",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Jardim Botânico
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 813,
                Nome = "Jardim Botânico",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Lago Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 814,
                Nome = "Lago Norte",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Lago Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 815,
                Nome = "Lago Sul",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Núcleo Bandeirante
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 816,
                Nome = "Núcleo Bandeirante",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Paranoá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 817,
                Nome = "Paranoá",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Park Way
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 818,
                Nome = "Park Way",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Planaltina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 819,
                Nome = "Planaltina",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Recanto das Emas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 820,
                Nome = "Recanto das Emas",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Riacho Fundo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 821,
                Nome = "Riacho Fundo",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Riacho Fundo II
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 822,
                Nome = "Riacho Fundo II",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Samambaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 823,
                Nome = "Samambaia",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Santa Maria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 824,
                Nome = "Santa Maria",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: São Sebastião
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 825,
                Nome = "São Sebastião",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: SCIA
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 826,
                Nome = "SCIA",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: SIA
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 827,
                Nome = "SIA",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Sobradinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 828,
                Nome = "Sobradinho",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Sobradinho II
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 829,
                Nome = "Sobradinho II",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Sudoeste e Octogonal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 830,
                Nome = "Sudoeste e Octogonal",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Taguatinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 831,
                Nome = "Taguatinga",
                Situacao = "Ativo",
                UF = "DF"
            });

            // cidade: Varjão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 832,
                Nome = "Varjão",
                Situacao = "Ativo",
                UF = "DF"
            });


            await _context.SaveChangesAsync();
        }
    }
}
