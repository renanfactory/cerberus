using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class PI
    {
        private readonly ApplicationDbContext _context;

        public PI(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: PI
            //----------------------------------------------------

            // cidade: Acauã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2998,
                Nome = "Acauã",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Agricolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2999,
                Nome = "Agricolândia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Água Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3000,
                Nome = "Água Branca",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Alagoinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3001,
                Nome = "Alagoinha",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Alegrete do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3002,
                Nome = "Alegrete do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Alto Longá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3003,
                Nome = "Alto Longá",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Altos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3004,
                Nome = "Altos",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Alvorada do Gurguéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3005,
                Nome = "Alvorada do Gurguéia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Amarante
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3006,
                Nome = "Amarante",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Angical do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3007,
                Nome = "Angical do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Anísio de Abreu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3008,
                Nome = "Anísio de Abreu",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Antônio Almeida
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3009,
                Nome = "Antônio Almeida",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Aroazes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3010,
                Nome = "Aroazes",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Arraial
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3011,
                Nome = "Arraial",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Assunção do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3012,
                Nome = "Assunção do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Avelino Lopes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3013,
                Nome = "Avelino Lopes",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Baixa Grande do Ribeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3014,
                Nome = "Baixa Grande do Ribeiro",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Barra D Alcântara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3015,
                Nome = "Barra D Alcântara",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Barras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3016,
                Nome = "Barras",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Barreiras do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3017,
                Nome = "Barreiras do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Barro Duro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3018,
                Nome = "Barro Duro",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Batalha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3019,
                Nome = "Batalha",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Bela Vista do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3020,
                Nome = "Bela Vista do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Belém do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3021,
                Nome = "Belém do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Beneditinos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3022,
                Nome = "Beneditinos",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Bertolínia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3023,
                Nome = "Bertolínia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Betânia do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3024,
                Nome = "Betânia do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Boa Hora
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3025,
                Nome = "Boa Hora",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Bocaina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3026,
                Nome = "Bocaina",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Bom Jesus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3027,
                Nome = "Bom Jesus",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Bom Princípio do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3028,
                Nome = "Bom Princípio do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Bonfim do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3029,
                Nome = "Bonfim do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Boqueirão do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3030,
                Nome = "Boqueirão do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Brasileira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3031,
                Nome = "Brasileira",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Brejo do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3032,
                Nome = "Brejo do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Buriti dos Lopes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3033,
                Nome = "Buriti dos Lopes",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Buriti dos Montes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3034,
                Nome = "Buriti dos Montes",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cabeceiras do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3035,
                Nome = "Cabeceiras do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cajazeiras do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3036,
                Nome = "Cajazeiras do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cajueiro da Praia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3037,
                Nome = "Cajueiro da Praia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Caldeirão Grande do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3038,
                Nome = "Caldeirão Grande do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Campinas do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3039,
                Nome = "Campinas do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Campo Alegre do Fidalgo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3040,
                Nome = "Campo Alegre do Fidalgo",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Campo Grande do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3041,
                Nome = "Campo Grande do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Campo Largo do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3042,
                Nome = "Campo Largo do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Campo Maior
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3043,
                Nome = "Campo Maior",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Canavieira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3044,
                Nome = "Canavieira",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Canto do Buriti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3045,
                Nome = "Canto do Buriti",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Capitão de Campos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3046,
                Nome = "Capitão de Campos",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Capitão Gervásio Oliveira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3047,
                Nome = "Capitão Gervásio Oliveira",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Caracol
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3048,
                Nome = "Caracol",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Caraúbas do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3049,
                Nome = "Caraúbas do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Caridade do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3050,
                Nome = "Caridade do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Castelo do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3051,
                Nome = "Castelo do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Caxingó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3052,
                Nome = "Caxingó",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cocal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3053,
                Nome = "Cocal",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cocal de Telha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3054,
                Nome = "Cocal de Telha",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cocal dos Alves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3055,
                Nome = "Cocal dos Alves",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Coivaras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3056,
                Nome = "Coivaras",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Colônia do Gurguéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3057,
                Nome = "Colônia do Gurguéia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Colônia do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3058,
                Nome = "Colônia do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Conceição do Canindé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3059,
                Nome = "Conceição do Canindé",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Coronel José Dias
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3060,
                Nome = "Coronel José Dias",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Corrente
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3061,
                Nome = "Corrente",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cristalândia do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3062,
                Nome = "Cristalândia do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Cristino Castro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3063,
                Nome = "Cristino Castro",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Curimatá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3064,
                Nome = "Curimatá",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Currais
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3065,
                Nome = "Currais",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Curral Novo do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3066,
                Nome = "Curral Novo do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Curralinhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3067,
                Nome = "Curralinhos",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Demerval Lobão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3068,
                Nome = "Demerval Lobão",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Dirceu Arcoverde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3069,
                Nome = "Dirceu Arcoverde",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Dom Expedito Lopes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3070,
                Nome = "Dom Expedito Lopes",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Dom Inocêncio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3071,
                Nome = "Dom Inocêncio",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Domingos Mourão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3072,
                Nome = "Domingos Mourão",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Elesbão Veloso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3073,
                Nome = "Elesbão Veloso",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Eliseu Martins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3074,
                Nome = "Eliseu Martins",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Esperantina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3075,
                Nome = "Esperantina",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Fartura do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3076,
                Nome = "Fartura do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Flores do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3077,
                Nome = "Flores do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Floresta do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3078,
                Nome = "Floresta do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Floriano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3079,
                Nome = "Floriano",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Francinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3080,
                Nome = "Francinópolis",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Francisco Ayres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3081,
                Nome = "Francisco Ayres",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Francisco Macedo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3082,
                Nome = "Francisco Macedo",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Francisco Santos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3083,
                Nome = "Francisco Santos",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Fronteiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3084,
                Nome = "Fronteiras",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Geminiano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3085,
                Nome = "Geminiano",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Gilbués
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3086,
                Nome = "Gilbués",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Guadalupe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3087,
                Nome = "Guadalupe",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Guaribas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3088,
                Nome = "Guaribas",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Hugo Napoleão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3089,
                Nome = "Hugo Napoleão",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Ilha Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3090,
                Nome = "Ilha Grande",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Inhuma
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3091,
                Nome = "Inhuma",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Ipiranga do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3092,
                Nome = "Ipiranga do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Isaías Coelho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3093,
                Nome = "Isaías Coelho",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Itainópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3094,
                Nome = "Itainópolis",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Itaueira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3095,
                Nome = "Itaueira",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Jacobina do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3096,
                Nome = "Jacobina do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Jaicós
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3097,
                Nome = "Jaicós",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Jardim do Mulato
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3098,
                Nome = "Jardim do Mulato",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Jatobá do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3099,
                Nome = "Jatobá do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Jerumenha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3100,
                Nome = "Jerumenha",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: João Costa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3101,
                Nome = "João Costa",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Joaquim Pires
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3102,
                Nome = "Joaquim Pires",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Joca Marques
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3103,
                Nome = "Joca Marques",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: José de Freitas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3104,
                Nome = "José de Freitas",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Juazeiro do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3105,
                Nome = "Juazeiro do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Júlio Borges
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3106,
                Nome = "Júlio Borges",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Jurema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3107,
                Nome = "Jurema",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Lagoa Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3108,
                Nome = "Lagoa Alegre",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Lagoa de São Francisco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3109,
                Nome = "Lagoa de São Francisco",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Lagoa do Barro do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3110,
                Nome = "Lagoa do Barro do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Lagoa do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3111,
                Nome = "Lagoa do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Lagoa do Sítio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3112,
                Nome = "Lagoa do Sítio",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Lagoinha do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3113,
                Nome = "Lagoinha do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Landri Sales
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3114,
                Nome = "Landri Sales",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Luís Correia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3115,
                Nome = "Luís Correia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Luzilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3116,
                Nome = "Luzilândia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Madeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3117,
                Nome = "Madeiro",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Manoel Emídio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3118,
                Nome = "Manoel Emídio",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Marcolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3119,
                Nome = "Marcolândia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Marcos Parente
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3120,
                Nome = "Marcos Parente",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Massapê do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3121,
                Nome = "Massapê do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Matias Olímpio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3122,
                Nome = "Matias Olímpio",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Miguel Alves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3123,
                Nome = "Miguel Alves",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Miguel Leão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3124,
                Nome = "Miguel Leão",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Milton Brandão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3125,
                Nome = "Milton Brandão",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Monsenhor Gil
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3126,
                Nome = "Monsenhor Gil",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Monsenhor Hipólito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3127,
                Nome = "Monsenhor Hipólito",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Monte Alegre do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3128,
                Nome = "Monte Alegre do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Morro Cabeça no Tempo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3129,
                Nome = "Morro Cabeça no Tempo",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Morro do Chapéu do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3130,
                Nome = "Morro do Chapéu do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Murici dos Portelas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3131,
                Nome = "Murici dos Portelas",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Nazaré do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3132,
                Nome = "Nazaré do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Nossa Senhora de Nazaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3133,
                Nome = "Nossa Senhora de Nazaré",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Nossa Senhora dos Remédios
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3134,
                Nome = "Nossa Senhora dos Remédios",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Nova Santa Rita
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3135,
                Nome = "Nova Santa Rita",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Novo Oriente do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3136,
                Nome = "Novo Oriente do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Novo Santo Antônio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3137,
                Nome = "Novo Santo Antônio",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Oeiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3138,
                Nome = "Oeiras",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Olho d Água do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3139,
                Nome = "Olho d Água do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Padre Marcos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3140,
                Nome = "Padre Marcos",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Paes Landim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3141,
                Nome = "Paes Landim",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Pajeú do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3142,
                Nome = "Pajeú do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Palmeira do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3143,
                Nome = "Palmeira do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Palmeirais
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3144,
                Nome = "Palmeirais",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Paquetá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3145,
                Nome = "Paquetá",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Parnaguá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3146,
                Nome = "Parnaguá",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Parnaíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3147,
                Nome = "Parnaíba",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Passagem Franca do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3148,
                Nome = "Passagem Franca do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Patos do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3149,
                Nome = "Patos do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Pau D Arco do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3150,
                Nome = "Pau D Arco do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Paulistana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3151,
                Nome = "Paulistana",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Pavussu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3152,
                Nome = "Pavussu",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Pedro II
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3153,
                Nome = "Pedro II",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Pedro Laurentino
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3154,
                Nome = "Pedro Laurentino",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Picos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3155,
                Nome = "Picos",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Pimenteiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3156,
                Nome = "Pimenteiras",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Pio IX
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3157,
                Nome = "Pio IX",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Piracuruca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3158,
                Nome = "Piracuruca",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Piripiri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3159,
                Nome = "Piripiri",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Porto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3160,
                Nome = "Porto",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Porto Alegre do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3161,
                Nome = "Porto Alegre do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Prata do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3162,
                Nome = "Prata do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Queimada Nova
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3163,
                Nome = "Queimada Nova",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Redenção do Gurguéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3164,
                Nome = "Redenção do Gurguéia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Regeneração
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3165,
                Nome = "Regeneração",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Riacho Frio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3166,
                Nome = "Riacho Frio",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Ribeira do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3167,
                Nome = "Ribeira do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Ribeiro Gonçalves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3168,
                Nome = "Ribeiro Gonçalves",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Rio Grande do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3169,
                Nome = "Rio Grande do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santa Cruz do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3170,
                Nome = "Santa Cruz do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santa Cruz dos Milagres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3171,
                Nome = "Santa Cruz dos Milagres",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santa Filomena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3172,
                Nome = "Santa Filomena",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santa Luz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3173,
                Nome = "Santa Luz",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santa Rosa do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3174,
                Nome = "Santa Rosa do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santana do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3175,
                Nome = "Santana do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santo Antônio de Lisboa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3176,
                Nome = "Santo Antônio de Lisboa",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santo Antônio dos Milagres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3177,
                Nome = "Santo Antônio dos Milagres",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Santo Inácio do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3178,
                Nome = "Santo Inácio do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Braz do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3179,
                Nome = "São Braz do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Félix do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3180,
                Nome = "São Félix do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Francisco de Assis do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3181,
                Nome = "São Francisco de Assis do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Francisco do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3182,
                Nome = "São Francisco do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Gonçalo do Gurguéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3183,
                Nome = "São Gonçalo do Gurguéia",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Gonçalo do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3184,
                Nome = "São Gonçalo do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São João da Canabrava
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3185,
                Nome = "São João da Canabrava",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São João da Fronteira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3186,
                Nome = "São João da Fronteira",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São João da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3187,
                Nome = "São João da Serra",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São João da Varjota
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3188,
                Nome = "São João da Varjota",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São João do Arraial
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3189,
                Nome = "São João do Arraial",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São João do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3190,
                Nome = "São João do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São José do Divino
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3191,
                Nome = "São José do Divino",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São José do Peixe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3192,
                Nome = "São José do Peixe",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São José do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3193,
                Nome = "São José do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Julião
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3194,
                Nome = "São Julião",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Lourenço do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3195,
                Nome = "São Lourenço do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Luís do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3196,
                Nome = "São Luís do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Miguel da Baixa Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3197,
                Nome = "São Miguel da Baixa Grande",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Miguel do Fidalgo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3198,
                Nome = "São Miguel do Fidalgo",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Miguel do Tapuio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3199,
                Nome = "São Miguel do Tapuio",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Pedro do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3200,
                Nome = "São Pedro do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: São Raimundo Nonato
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3201,
                Nome = "São Raimundo Nonato",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Sebastião Barros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3202,
                Nome = "Sebastião Barros",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Sebastião Leal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3203,
                Nome = "Sebastião Leal",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Sigefredo Pacheco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3204,
                Nome = "Sigefredo Pacheco",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Simões
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3205,
                Nome = "Simões",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Simplício Mendes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3206,
                Nome = "Simplício Mendes",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Socorro do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3207,
                Nome = "Socorro do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Sussuapara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3208,
                Nome = "Sussuapara",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Tamboril do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3209,
                Nome = "Tamboril do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Tanque do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3210,
                Nome = "Tanque do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Teresina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3211,
                Nome = "Teresina",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: União
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3212,
                Nome = "União",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Uruçuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3213,
                Nome = "Uruçuí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Valença do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3214,
                Nome = "Valença do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Várzea Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3215,
                Nome = "Várzea Branca",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Várzea Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3216,
                Nome = "Várzea Grande",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Vera Mendes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3217,
                Nome = "Vera Mendes",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Vila Nova do Piauí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3218,
                Nome = "Vila Nova do Piauí",
                Situacao = "Ativo",
                UF = "PI"
            });

            // cidade: Wall Ferraz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3219,
                Nome = "Wall Ferraz",
                Situacao = "Ativo",
                UF = "PI"
            });

            await _context.SaveChangesAsync();
        }
    }
}
