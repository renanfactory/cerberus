using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class MT
    {
        private readonly ApplicationDbContext _context;

        public MT(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: MT
            //----------------------------------------------------

            // cidade: Acorizal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2306,
                Nome = "Acorizal",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Água Boa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2307,
                Nome = "Água Boa",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Alta Floresta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2308,
                Nome = "Alta Floresta",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Alto Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2309,
                Nome = "Alto Araguaia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Alto da Boa Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2310,
                Nome = "Alto da Boa Vista",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Alto Garças
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2311,
                Nome = "Alto Garças",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Alto Paraguai
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2312,
                Nome = "Alto Paraguai",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Alto Taquari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2313,
                Nome = "Alto Taquari",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Apiacás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2314,
                Nome = "Apiacás",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Araguaiana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2315,
                Nome = "Araguaiana",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Araguainha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2316,
                Nome = "Araguainha",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Araputanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2317,
                Nome = "Araputanga",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Arenápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2318,
                Nome = "Arenápolis",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Aripuanã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2319,
                Nome = "Aripuanã",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Barão de Melgaço
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2320,
                Nome = "Barão de Melgaço",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Barra do Bugres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2321,
                Nome = "Barra do Bugres",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Barra do Garças
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2322,
                Nome = "Barra do Garças",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Bom Jesus do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2323,
                Nome = "Bom Jesus do Araguaia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Brasnorte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2324,
                Nome = "Brasnorte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Cáceres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2325,
                Nome = "Cáceres",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Campinápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2326,
                Nome = "Campinápolis",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Campo Novo do Parecis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2327,
                Nome = "Campo Novo do Parecis",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Campo Verde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2328,
                Nome = "Campo Verde",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Campos de Júlio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2329,
                Nome = "Campos de Júlio",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Canabrava do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2330,
                Nome = "Canabrava do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Canarana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2331,
                Nome = "Canarana",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Carlinda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2332,
                Nome = "Carlinda",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Castanheira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2333,
                Nome = "Castanheira",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Chapada dos Guimarães
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2334,
                Nome = "Chapada dos Guimarães",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Cláudia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2335,
                Nome = "Cláudia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Cocalinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2336,
                Nome = "Cocalinho",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Colíder
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2337,
                Nome = "Colíder",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Colniza
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2338,
                Nome = "Colniza",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Comodoro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2339,
                Nome = "Comodoro",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Confresa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2340,
                Nome = "Confresa",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Conquista D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2341,
                Nome = "Conquista D Oeste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Cotriguaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2342,
                Nome = "Cotriguaçu",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Cuiabá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2343,
                Nome = "Cuiabá",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Curvelândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2344,
                Nome = "Curvelândia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Denise
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2345,
                Nome = "Denise",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Diamantino
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2346,
                Nome = "Diamantino",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Dom Aquino
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2347,
                Nome = "Dom Aquino",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Feliz Natal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2348,
                Nome = "Feliz Natal",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Figueirópolis D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2349,
                Nome = "Figueirópolis D Oeste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Gaúcha do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2350,
                Nome = "Gaúcha do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: General Carneiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2351,
                Nome = "General Carneiro",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Glória D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2352,
                Nome = "Glória D Oeste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Guarantã do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2353,
                Nome = "Guarantã do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Guiratinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2354,
                Nome = "Guiratinga",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Indiavaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2355,
                Nome = "Indiavaí",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Ipiranga do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2356,
                Nome = "Ipiranga do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Itanhangá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2357,
                Nome = "Itanhangá",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Itaúba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2358,
                Nome = "Itaúba",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Itiquira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2359,
                Nome = "Itiquira",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Jaciara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2360,
                Nome = "Jaciara",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Jangada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2361,
                Nome = "Jangada",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Jauru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2362,
                Nome = "Jauru",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Juara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2363,
                Nome = "Juara",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Juína
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2364,
                Nome = "Juína",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Juruena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2365,
                Nome = "Juruena",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Juscimeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2366,
                Nome = "Juscimeira",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Lambari D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2367,
                Nome = "Lambari D Oeste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Lucas do Rio Verde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2368,
                Nome = "Lucas do Rio Verde",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Luciara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2369,
                Nome = "Luciara",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Marcelândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2370,
                Nome = "Marcelândia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Matupá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2371,
                Nome = "Matupá",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Mirassol d Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2372,
                Nome = "Mirassol d Oeste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nobres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2373,
                Nome = "Nobres",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nortelândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2374,
                Nome = "Nortelândia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nossa Senhora do Livramento
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2375,
                Nome = "Nossa Senhora do Livramento",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Bandeirantes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2376,
                Nome = "Nova Bandeirantes",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Brasilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2377,
                Nome = "Nova Brasilândia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Canaã do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2378,
                Nome = "Nova Canaã do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Guarita
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2379,
                Nome = "Nova Guarita",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Lacerda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2380,
                Nome = "Nova Lacerda",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Marilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2381,
                Nome = "Nova Marilândia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Maringá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2382,
                Nome = "Nova Maringá",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Monte Verde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2383,
                Nome = "Nova Monte Verde",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Mutum
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2384,
                Nome = "Nova Mutum",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Nazaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2385,
                Nome = "Nova Nazaré",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Olímpia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2386,
                Nome = "Nova Olímpia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Santa Helena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2387,
                Nome = "Nova Santa Helena",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Ubiratã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2388,
                Nome = "Nova Ubiratã",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Nova Xavantina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2389,
                Nome = "Nova Xavantina",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Novo Horizonte do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2390,
                Nome = "Novo Horizonte do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Novo Mundo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2391,
                Nome = "Novo Mundo",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Novo Santo Antônio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2392,
                Nome = "Novo Santo Antônio",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Novo São Joaquim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2393,
                Nome = "Novo São Joaquim",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Paranaíta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2394,
                Nome = "Paranaíta",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Paranatinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2395,
                Nome = "Paranatinga",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Pedra Preta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2396,
                Nome = "Pedra Preta",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Peixoto de Azevedo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2397,
                Nome = "Peixoto de Azevedo",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Planalto da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2398,
                Nome = "Planalto da Serra",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Poconé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2399,
                Nome = "Poconé",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Pontal do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2400,
                Nome = "Pontal do Araguaia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Ponte Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2401,
                Nome = "Ponte Branca",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Pontes e Lacerda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2402,
                Nome = "Pontes e Lacerda",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Porto Alegre do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2403,
                Nome = "Porto Alegre do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Porto dos Gaúchos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2404,
                Nome = "Porto dos Gaúchos",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Porto Esperidião
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2405,
                Nome = "Porto Esperidião",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Porto Estrela
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2406,
                Nome = "Porto Estrela",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Poxoréo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2407,
                Nome = "Poxoréo",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Primavera do Leste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2408,
                Nome = "Primavera do Leste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Querência
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2409,
                Nome = "Querência",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Reserva do Cabaçal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2410,
                Nome = "Reserva do Cabaçal",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Ribeirão Cascalheira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2411,
                Nome = "Ribeirão Cascalheira",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Ribeirãozinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2412,
                Nome = "Ribeirãozinho",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Rio Branco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2413,
                Nome = "Rio Branco",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Rondolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2414,
                Nome = "Rondolândia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Rondonópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2415,
                Nome = "Rondonópolis",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Rosário Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2416,
                Nome = "Rosário Oeste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Salto do Céu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2417,
                Nome = "Salto do Céu",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Santa Carmem
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2418,
                Nome = "Santa Carmem",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Santa Cruz do Xingu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2419,
                Nome = "Santa Cruz do Xingu",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Santa Rita do Trivelato
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2420,
                Nome = "Santa Rita do Trivelato",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Santa Terezinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2421,
                Nome = "Santa Terezinha",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Santo Afonso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2422,
                Nome = "Santo Afonso",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Santo Antônio do Leste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2423,
                Nome = "Santo Antônio do Leste",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Santo Antônio do Leverger
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2424,
                Nome = "Santo Antônio do Leverger",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: São Félix do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2425,
                Nome = "São Félix do Araguaia",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: São José do Povo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2426,
                Nome = "São José do Povo",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: São José do Rio Claro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2427,
                Nome = "São José do Rio Claro",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: São José do Xingu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2428,
                Nome = "São José do Xingu",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: São José dos Quatro Marcos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2429,
                Nome = "São José dos Quatro Marcos",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: São Pedro da Cipa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2430,
                Nome = "São Pedro da Cipa",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Sapezal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2431,
                Nome = "Sapezal",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Serra Nova Dourada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2432,
                Nome = "Serra Nova Dourada",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Sinop
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2433,
                Nome = "Sinop",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Sorriso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2434,
                Nome = "Sorriso",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Tabaporã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2435,
                Nome = "Tabaporã",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Tangará da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2436,
                Nome = "Tangará da Serra",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Tapurah
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2437,
                Nome = "Tapurah",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Terra Nova do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2438,
                Nome = "Terra Nova do Norte",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Tesouro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2439,
                Nome = "Tesouro",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Torixoréu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2440,
                Nome = "Torixoréu",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: União do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2441,
                Nome = "União do Sul",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Vale de São Domingos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2442,
                Nome = "Vale de São Domingos",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Várzea Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2443,
                Nome = "Várzea Grande",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Vera
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2444,
                Nome = "Vera",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Vila Bela da Santíssima Trindade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2445,
                Nome = "Vila Bela da Santíssima Trindade",
                Situacao = "Ativo",
                UF = "MT"
            });

            // cidade: Vila Rica
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2446,
                Nome = "Vila Rica",
                Situacao = "Ativo",
                UF = "MT"
            });


            await _context.SaveChangesAsync();
        }
    }
}
