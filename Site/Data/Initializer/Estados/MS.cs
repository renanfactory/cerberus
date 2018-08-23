using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class MS
    {
        private readonly ApplicationDbContext _context;

        public MS(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: MS
            //----------------------------------------------------

            // cidade: Água Clara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2228,
                Nome = "Água Clara",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Alcinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2229,
                Nome = "Alcinópolis",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Amambaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2230,
                Nome = "Amambaí",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Anastácio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2231,
                Nome = "Anastácio",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Anaurilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2232,
                Nome = "Anaurilândia",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Angélica
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2233,
                Nome = "Angélica",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Antônio João
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2234,
                Nome = "Antônio João",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Aparecida do Taboado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2235,
                Nome = "Aparecida do Taboado",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Aquidauana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2236,
                Nome = "Aquidauana",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Aral Moreira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2237,
                Nome = "Aral Moreira",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Bandeirantes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2238,
                Nome = "Bandeirantes",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Bataguaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2239,
                Nome = "Bataguaçu",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Bataiporã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2240,
                Nome = "Bataiporã",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Bela Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2241,
                Nome = "Bela Vista",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Bodoquena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2242,
                Nome = "Bodoquena",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Bonito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2243,
                Nome = "Bonito",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Brasilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2244,
                Nome = "Brasilândia",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Caarapó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2245,
                Nome = "Caarapó",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Camapuã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2246,
                Nome = "Camapuã",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Campo Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2247,
                Nome = "Campo Grande",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Caracol
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2248,
                Nome = "Caracol",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Cassilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2249,
                Nome = "Cassilândia",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Chapadão do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2250,
                Nome = "Chapadão do Sul",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Corguinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2251,
                Nome = "Corguinho",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Coronel Sapucaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2252,
                Nome = "Coronel Sapucaia",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Corumbá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2253,
                Nome = "Corumbá",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Costa Rica
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2254,
                Nome = "Costa Rica",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Coxim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2255,
                Nome = "Coxim",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Deodápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2256,
                Nome = "Deodápolis",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Dois Irmãos do Buriti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2257,
                Nome = "Dois Irmãos do Buriti",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Douradina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2258,
                Nome = "Douradina",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Dourados
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2259,
                Nome = "Dourados",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Eldorado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2260,
                Nome = "Eldorado",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Fátima do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2261,
                Nome = "Fátima do Sul",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Figueirão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2262,
                Nome = "Figueirão",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Glória de Dourados
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2263,
                Nome = "Glória de Dourados",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Guia Lopes da Laguna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2264,
                Nome = "Guia Lopes da Laguna",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Iguatemi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2265,
                Nome = "Iguatemi",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Inocência
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2266,
                Nome = "Inocência",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Itaporã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2267,
                Nome = "Itaporã",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Itaquiraí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2268,
                Nome = "Itaquiraí",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Ivinhema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2269,
                Nome = "Ivinhema",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Japorã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2270,
                Nome = "Japorã",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Jaraguari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2271,
                Nome = "Jaraguari",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Jardim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2272,
                Nome = "Jardim",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Jateí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2273,
                Nome = "Jateí",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Juti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2274,
                Nome = "Juti",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Ladário
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2275,
                Nome = "Ladário",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Laguna Carapã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2276,
                Nome = "Laguna Carapã",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Maracaju
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2277,
                Nome = "Maracaju",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Miranda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2278,
                Nome = "Miranda",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Mundo Novo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2279,
                Nome = "Mundo Novo",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Naviraí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2280,
                Nome = "Naviraí",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Nioaque
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2281,
                Nome = "Nioaque",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Nova Alvorada do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2282,
                Nome = "Nova Alvorada do Sul",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Nova Andradina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2283,
                Nome = "Nova Andradina",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Novo Horizonte do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2284,
                Nome = "Novo Horizonte do Sul",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Paranaíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2285,
                Nome = "Paranaíba",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Paranhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2286,
                Nome = "Paranhos",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Pedro Gomes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2287,
                Nome = "Pedro Gomes",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Ponta Porã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2288,
                Nome = "Ponta Porã",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Porto Murtinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2289,
                Nome = "Porto Murtinho",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Ribas do Rio Pardo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2290,
                Nome = "Ribas do Rio Pardo",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Rio Brilhante
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2291,
                Nome = "Rio Brilhante",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Rio Negro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2292,
                Nome = "Rio Negro",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Rio Verde de Mato Grosso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2293,
                Nome = "Rio Verde de Mato Grosso",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Rochedo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2294,
                Nome = "Rochedo",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Santa Rita do Pardo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2295,
                Nome = "Santa Rita do Pardo",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: São Gabriel do Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2296,
                Nome = "São Gabriel do Oeste",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Selvíria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2297,
                Nome = "Selvíria",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Sete Quedas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2298,
                Nome = "Sete Quedas",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Sidrolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2299,
                Nome = "Sidrolândia",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Sonora
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2300,
                Nome = "Sonora",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Tacuru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2301,
                Nome = "Tacuru",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Taquarussu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2302,
                Nome = "Taquarussu",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Terenos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2303,
                Nome = "Terenos",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Três Lagoas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2304,
                Nome = "Três Lagoas",
                Situacao = "Ativo",
                UF = "MS"
            });

            // cidade: Vicentina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2305,
                Nome = "Vicentina",
                Situacao = "Ativo",
                UF = "MS"
            });


            await _context.SaveChangesAsync();
        }
    }
}
