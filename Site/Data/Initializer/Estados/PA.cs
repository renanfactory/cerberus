using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class PA
    {
        private readonly ApplicationDbContext _context;

        public PA(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: PA
            //----------------------------------------------------

            // cidade: Abaetetuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2447,
                Nome = "Abaetetuba",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Abel Figueiredo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2448,
                Nome = "Abel Figueiredo",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Acará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2449,
                Nome = "Acará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Afuá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2450,
                Nome = "Afuá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Água Azul do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2451,
                Nome = "Água Azul do Norte",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Alenquer
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2452,
                Nome = "Alenquer",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Almeirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2453,
                Nome = "Almeirim",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Altamira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2454,
                Nome = "Altamira",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Anajás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2455,
                Nome = "Anajás",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Ananindeua
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2456,
                Nome = "Ananindeua",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Anapu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2457,
                Nome = "Anapu",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Augusto Corrêa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2458,
                Nome = "Augusto Corrêa",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Aurora do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2459,
                Nome = "Aurora do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Aveiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2460,
                Nome = "Aveiro",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Bagre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2461,
                Nome = "Bagre",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Baião
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2462,
                Nome = "Baião",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Bannach
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2463,
                Nome = "Bannach",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Barcarena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2464,
                Nome = "Barcarena",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Belém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2465,
                Nome = "Belém",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Belterra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2466,
                Nome = "Belterra",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Benevides
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2467,
                Nome = "Benevides",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Bom Jesus do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2468,
                Nome = "Bom Jesus do Tocantins",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Bonito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2469,
                Nome = "Bonito",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Bragança
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2470,
                Nome = "Bragança",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Brasil Novo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2471,
                Nome = "Brasil Novo",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Brejo Grande do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2472,
                Nome = "Brejo Grande do Araguaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Breu Branco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2473,
                Nome = "Breu Branco",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Breves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2474,
                Nome = "Breves",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Bujaru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2475,
                Nome = "Bujaru",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Cachoeira do Arari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2476,
                Nome = "Cachoeira do Arari",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Cachoeira do Piriá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2477,
                Nome = "Cachoeira do Piriá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Cametá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2478,
                Nome = "Cametá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Canaã dos Carajás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2479,
                Nome = "Canaã dos Carajás",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Capanema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2480,
                Nome = "Capanema",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Capitão Poço
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2481,
                Nome = "Capitão Poço",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Castanhal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2482,
                Nome = "Castanhal",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Chaves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2483,
                Nome = "Chaves",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Colares
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2484,
                Nome = "Colares",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Conceição do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2485,
                Nome = "Conceição do Araguaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Concórdia do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2486,
                Nome = "Concórdia do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Cumaru do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2487,
                Nome = "Cumaru do Norte",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Curionópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2488,
                Nome = "Curionópolis",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Curralinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2489,
                Nome = "Curralinho",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Curuá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2490,
                Nome = "Curuá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Curuçá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2491,
                Nome = "Curuçá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Dom Eliseu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2492,
                Nome = "Dom Eliseu",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Eldorado dos Carajás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2493,
                Nome = "Eldorado dos Carajás",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Faro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2494,
                Nome = "Faro",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Floresta do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2495,
                Nome = "Floresta do Araguaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Garrafão do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2496,
                Nome = "Garrafão do Norte",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Goianésia do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2497,
                Nome = "Goianésia do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Gurupá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2498,
                Nome = "Gurupá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Igarapé Açu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2499,
                Nome = "Igarapé Açu",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Igarapé Mirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2500,
                Nome = "Igarapé Mirim",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Inhangapi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2501,
                Nome = "Inhangapi",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Ipixuna do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2502,
                Nome = "Ipixuna do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Irituia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2503,
                Nome = "Irituia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Itaituba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2504,
                Nome = "Itaituba",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Itupiranga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2505,
                Nome = "Itupiranga",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Jacareacanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2506,
                Nome = "Jacareacanga",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Jacundá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2507,
                Nome = "Jacundá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Juruti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2508,
                Nome = "Juruti",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Limoeiro do Ajuru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2509,
                Nome = "Limoeiro do Ajuru",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Mãe do Rio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2510,
                Nome = "Mãe do Rio",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Magalhães Barata
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2511,
                Nome = "Magalhães Barata",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Marabá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2512,
                Nome = "Marabá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Maracanã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2513,
                Nome = "Maracanã",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Marapanim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2514,
                Nome = "Marapanim",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Marituba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2515,
                Nome = "Marituba",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Medicilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2516,
                Nome = "Medicilândia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Melgaço
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2517,
                Nome = "Melgaço",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Mocajuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2518,
                Nome = "Mocajuba",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Moju
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2519,
                Nome = "Moju",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Monte Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2520,
                Nome = "Monte Alegre",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Muaná
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2521,
                Nome = "Muaná",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Nova Esperança do Piriá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2522,
                Nome = "Nova Esperança do Piriá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Nova Ipixuna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2523,
                Nome = "Nova Ipixuna",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Nova Timboteua
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2524,
                Nome = "Nova Timboteua",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Novo Progresso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2525,
                Nome = "Novo Progresso",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Novo Repartimento
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2526,
                Nome = "Novo Repartimento",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Óbidos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2527,
                Nome = "Óbidos",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Oeiras do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2528,
                Nome = "Oeiras do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Oriximiná
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2529,
                Nome = "Oriximiná",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Ourém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2530,
                Nome = "Ourém",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Ourilândia do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2531,
                Nome = "Ourilândia do Norte",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Pacajá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2532,
                Nome = "Pacajá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Palestina do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2533,
                Nome = "Palestina do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Paragominas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2534,
                Nome = "Paragominas",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Parauapebas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2535,
                Nome = "Parauapebas",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Pau D Arco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2536,
                Nome = "Pau D Arco",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Peixe Boi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2537,
                Nome = "Peixe Boi",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Piçarra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2538,
                Nome = "Piçarra",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Placas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2539,
                Nome = "Placas",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Ponta de Pedras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2540,
                Nome = "Ponta de Pedras",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Portel
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2541,
                Nome = "Portel",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Porto de Moz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2542,
                Nome = "Porto de Moz",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Prainha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2543,
                Nome = "Prainha",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Primavera
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2544,
                Nome = "Primavera",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Quatipuru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2545,
                Nome = "Quatipuru",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Redenção
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2546,
                Nome = "Redenção",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Rio Maria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2547,
                Nome = "Rio Maria",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Rondon do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2548,
                Nome = "Rondon do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Rurópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2549,
                Nome = "Rurópolis",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Salinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2550,
                Nome = "Salinópolis",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Salvaterra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2551,
                Nome = "Salvaterra",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santa Bárbara do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2552,
                Nome = "Santa Bárbara do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santa Cruz do Arari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2553,
                Nome = "Santa Cruz do Arari",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santa Isabel do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2554,
                Nome = "Santa Isabel do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santa Luzia do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2555,
                Nome = "Santa Luzia do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santa Maria das Barreiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2556,
                Nome = "Santa Maria das Barreiras",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santa Maria do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2557,
                Nome = "Santa Maria do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santana do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2558,
                Nome = "Santana do Araguaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santarém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2559,
                Nome = "Santarém",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santarém Novo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2560,
                Nome = "Santarém Novo",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Santo Antônio do Tauá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2561,
                Nome = "Santo Antônio do Tauá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Caetano de Odivelas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2562,
                Nome = "São Caetano de Odivelas",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Domingos do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2563,
                Nome = "São Domingos do Araguaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Domingos do Capim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2564,
                Nome = "São Domingos do Capim",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Félix do Xingu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2565,
                Nome = "São Félix do Xingu",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Francisco do Pará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2566,
                Nome = "São Francisco do Pará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Geraldo do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2567,
                Nome = "São Geraldo do Araguaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São João da Ponta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2568,
                Nome = "São João da Ponta",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São João de Pirabas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2569,
                Nome = "São João de Pirabas",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São João do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2570,
                Nome = "São João do Araguaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Miguel do Guamá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2571,
                Nome = "São Miguel do Guamá",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: São Sebastião da Boa Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2572,
                Nome = "São Sebastião da Boa Vista",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Sapucaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2573,
                Nome = "Sapucaia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Senador José Porfírio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2574,
                Nome = "Senador José Porfírio",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Soure
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2575,
                Nome = "Soure",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Tailândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2576,
                Nome = "Tailândia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Terra Alta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2577,
                Nome = "Terra Alta",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Terra Santa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2578,
                Nome = "Terra Santa",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Tomé Açu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2579,
                Nome = "Tomé Açu",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Tracuateua
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2580,
                Nome = "Tracuateua",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Trairão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2581,
                Nome = "Trairão",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Tucumã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2582,
                Nome = "Tucumã",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Tucuruí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2583,
                Nome = "Tucuruí",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Ulianópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2584,
                Nome = "Ulianópolis",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Uruará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2585,
                Nome = "Uruará",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Vigia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2586,
                Nome = "Vigia",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Viseu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2587,
                Nome = "Viseu",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Vitória do Xingu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2588,
                Nome = "Vitória do Xingu",
                Situacao = "Ativo",
                UF = "PA"
            });

            // cidade: Xinguara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2589,
                Nome = "Xinguara",
                Situacao = "Ativo",
                UF = "PA"
            });


            await _context.SaveChangesAsync();
        }
    }
}
