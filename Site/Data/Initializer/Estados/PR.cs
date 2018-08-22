using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class PR
    {
        private readonly ApplicationDbContext _context;

        public PR(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: PR
            //----------------------------------------------------

            // cidade: Abatiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3220,
                Nome = "Abatiá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Adrianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3221,
                Nome = "Adrianópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Agudos do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3222,
                Nome = "Agudos do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Almirante Tamandaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3223,
                Nome = "Almirante Tamandaré",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Altamira do Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3224,
                Nome = "Altamira do Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Alto Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3225,
                Nome = "Alto Paraíso",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Alto Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3226,
                Nome = "Alto Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Alto Piquiri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3227,
                Nome = "Alto Piquiri",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Altônia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3228,
                Nome = "Altônia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Alvorada do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3229,
                Nome = "Alvorada do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Amaporã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3230,
                Nome = "Amaporã",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ampére
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3231,
                Nome = "Ampére",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Anahy
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3232,
                Nome = "Anahy",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Andirá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3233,
                Nome = "Andirá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ângulo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3234,
                Nome = "Ângulo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Antonina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3235,
                Nome = "Antonina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Antônio Olinto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3236,
                Nome = "Antônio Olinto",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Apucarana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3237,
                Nome = "Apucarana",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Arapongas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3238,
                Nome = "Arapongas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Arapoti
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3239,
                Nome = "Arapoti",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Arapuã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3240,
                Nome = "Arapuã",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Araruna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3241,
                Nome = "Araruna",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Araucária
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3242,
                Nome = "Araucária",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ariranha do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3243,
                Nome = "Ariranha do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Assaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3244,
                Nome = "Assaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Assis Chateaubriand
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3245,
                Nome = "Assis Chateaubriand",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Astorga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3246,
                Nome = "Astorga",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Atalaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3247,
                Nome = "Atalaia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Balsa Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3248,
                Nome = "Balsa Nova",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bandeirantes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3249,
                Nome = "Bandeirantes",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Barbosa Ferraz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3250,
                Nome = "Barbosa Ferraz",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Barra do Jacaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3251,
                Nome = "Barra do Jacaré",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Barracão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3252,
                Nome = "Barracão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bela Vista da Caroba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3253,
                Nome = "Bela Vista da Caroba",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bela Vista do Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3254,
                Nome = "Bela Vista do Paraíso",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bituruna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3255,
                Nome = "Bituruna",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Boa Esperança
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3256,
                Nome = "Boa Esperança",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Boa Esperança do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3257,
                Nome = "Boa Esperança do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Boa Ventura de São Roque
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3258,
                Nome = "Boa Ventura de São Roque",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Boa Vista da Aparecida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3259,
                Nome = "Boa Vista da Aparecida",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bocaiúva do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3260,
                Nome = "Bocaiúva do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bom Jesus do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3261,
                Nome = "Bom Jesus do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bom Sucesso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3262,
                Nome = "Bom Sucesso",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Bom Sucesso do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3263,
                Nome = "Bom Sucesso do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Borrazópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3264,
                Nome = "Borrazópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Braganey
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3265,
                Nome = "Braganey",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Brasilândia do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3266,
                Nome = "Brasilândia do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cafeara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3267,
                Nome = "Cafeara",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cafelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3268,
                Nome = "Cafelândia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cafezal do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3269,
                Nome = "Cafezal do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Califórnia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3270,
                Nome = "Califórnia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cambará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3271,
                Nome = "Cambará",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cambé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3272,
                Nome = "Cambé",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cambira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3273,
                Nome = "Cambira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campina da Lagoa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3274,
                Nome = "Campina da Lagoa",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campina do Simão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3275,
                Nome = "Campina do Simão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campina Grande do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3276,
                Nome = "Campina Grande do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campo Bonito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3277,
                Nome = "Campo Bonito",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campo do Tenente
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3278,
                Nome = "Campo do Tenente",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campo Largo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3279,
                Nome = "Campo Largo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campo Magro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3280,
                Nome = "Campo Magro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Campo Mourão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3281,
                Nome = "Campo Mourão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cândido de Abreu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3282,
                Nome = "Cândido de Abreu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Candói
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3283,
                Nome = "Candói",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cantagalo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3284,
                Nome = "Cantagalo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Capanema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3285,
                Nome = "Capanema",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Capitão Leônidas Marques
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3286,
                Nome = "Capitão Leônidas Marques",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Carambeí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3287,
                Nome = "Carambeí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Carlópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3288,
                Nome = "Carlópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cascavel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3289,
                Nome = "Cascavel",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Castro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3290,
                Nome = "Castro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Catanduvas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3291,
                Nome = "Catanduvas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Centenário do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3292,
                Nome = "Centenário do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cerro Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3293,
                Nome = "Cerro Azul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Céu Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3294,
                Nome = "Céu Azul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Chopinzinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3295,
                Nome = "Chopinzinho",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cianorte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3296,
                Nome = "Cianorte",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cidade Gaúcha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3297,
                Nome = "Cidade Gaúcha",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Clevelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3298,
                Nome = "Clevelândia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Colombo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3299,
                Nome = "Colombo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Colorado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3300,
                Nome = "Colorado",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Congonhinhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3301,
                Nome = "Congonhinhas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Conselheiro Mairinck
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3302,
                Nome = "Conselheiro Mairinck",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Contenda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3303,
                Nome = "Contenda",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Corbélia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3304,
                Nome = "Corbélia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cornélio Procópio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3305,
                Nome = "Cornélio Procópio",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Coronel Domingos Soares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3306,
                Nome = "Coronel Domingos Soares",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Coronel Vivida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3307,
                Nome = "Coronel Vivida",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Corumbataí do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3308,
                Nome = "Corumbataí do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cruz Machado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3309,
                Nome = "Cruz Machado",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cruzeiro do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3310,
                Nome = "Cruzeiro do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cruzeiro do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3311,
                Nome = "Cruzeiro do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cruzeiro do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3312,
                Nome = "Cruzeiro do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Cruzmaltina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3313,
                Nome = "Cruzmaltina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Curitiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3314,
                Nome = "Curitiba",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Curiúva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3315,
                Nome = "Curiúva",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Diamante do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3316,
                Nome = "Diamante do Norte",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Diamante do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3317,
                Nome = "Diamante do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Diamante d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3318,
                Nome = "Diamante d Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Dois Vizinhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3319,
                Nome = "Dois Vizinhos",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Douradina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3320,
                Nome = "Douradina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Doutor Camargo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3321,
                Nome = "Doutor Camargo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Doutor Ulysses
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3322,
                Nome = "Doutor Ulysses",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Enéas Marques
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3323,
                Nome = "Enéas Marques",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Engenheiro Beltrão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3324,
                Nome = "Engenheiro Beltrão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Entre Rios do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3325,
                Nome = "Entre Rios do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Esperança Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3326,
                Nome = "Esperança Nova",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Espigão Alto do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3327,
                Nome = "Espigão Alto do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Farol
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3328,
                Nome = "Farol",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Faxinal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3329,
                Nome = "Faxinal",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Fazenda Rio Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3330,
                Nome = "Fazenda Rio Grande",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Fênix
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3331,
                Nome = "Fênix",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Fernandes Pinheiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3332,
                Nome = "Fernandes Pinheiro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Figueira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3333,
                Nome = "Figueira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Flor da Serra do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3334,
                Nome = "Flor da Serra do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Floraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3335,
                Nome = "Floraí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Floresta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3336,
                Nome = "Floresta",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Florestópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3337,
                Nome = "Florestópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Flórida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3338,
                Nome = "Flórida",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Formosa do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3339,
                Nome = "Formosa do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Foz do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3340,
                Nome = "Foz do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Foz do Jordão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3341,
                Nome = "Foz do Jordão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Francisco Alves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3342,
                Nome = "Francisco Alves",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Francisco Beltrão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3343,
                Nome = "Francisco Beltrão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: General Carneiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3344,
                Nome = "General Carneiro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Godoy Moreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3345,
                Nome = "Godoy Moreira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Goioerê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3346,
                Nome = "Goioerê",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Goioxim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3347,
                Nome = "Goioxim",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Grandes Rios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3348,
                Nome = "Grandes Rios",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guaíra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3349,
                Nome = "Guaíra",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guairaçá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3350,
                Nome = "Guairaçá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guamiranga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3351,
                Nome = "Guamiranga",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guapirama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3352,
                Nome = "Guapirama",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guaporema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3353,
                Nome = "Guaporema",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guaraci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3354,
                Nome = "Guaraci",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guaraniaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3355,
                Nome = "Guaraniaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guarapuava
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3356,
                Nome = "Guarapuava",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guaraqueçaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3357,
                Nome = "Guaraqueçaba",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Guaratuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3358,
                Nome = "Guaratuba",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Honório Serpa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3359,
                Nome = "Honório Serpa",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ibaiti
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3360,
                Nome = "Ibaiti",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ibema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3361,
                Nome = "Ibema",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ibiporã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3362,
                Nome = "Ibiporã",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Icaraíma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3363,
                Nome = "Icaraíma",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Iguaraçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3364,
                Nome = "Iguaraçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Iguatu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3365,
                Nome = "Iguatu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Imbaú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3366,
                Nome = "Imbaú",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Imbituva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3367,
                Nome = "Imbituva",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Inácio Martins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3368,
                Nome = "Inácio Martins",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Inajá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3369,
                Nome = "Inajá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Indianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3370,
                Nome = "Indianópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ipiranga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3371,
                Nome = "Ipiranga",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Iporã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3372,
                Nome = "Iporã",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Iracema do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3373,
                Nome = "Iracema do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Irati
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3374,
                Nome = "Irati",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Iretama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3375,
                Nome = "Iretama",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Itaguajé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3376,
                Nome = "Itaguajé",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Itaipulândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3377,
                Nome = "Itaipulândia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Itambaracá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3378,
                Nome = "Itambaracá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Itambé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3379,
                Nome = "Itambé",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Itapejara d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3380,
                Nome = "Itapejara d Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Itaperuçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3381,
                Nome = "Itaperuçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Itaúna do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3382,
                Nome = "Itaúna do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3383,
                Nome = "Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ivaiporã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3384,
                Nome = "Ivaiporã",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ivaté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3385,
                Nome = "Ivaté",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ivatuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3386,
                Nome = "Ivatuba",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jaboti
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3387,
                Nome = "Jaboti",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jacarezinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3388,
                Nome = "Jacarezinho",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jaguapitã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3389,
                Nome = "Jaguapitã",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jaguariaíva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3390,
                Nome = "Jaguariaíva",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jandaia do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3391,
                Nome = "Jandaia do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Janiópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3392,
                Nome = "Janiópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Japira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3393,
                Nome = "Japira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Japurá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3394,
                Nome = "Japurá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jardim Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3395,
                Nome = "Jardim Alegre",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jardim Olinda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3396,
                Nome = "Jardim Olinda",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jataizinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3397,
                Nome = "Jataizinho",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jesuítas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3398,
                Nome = "Jesuítas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Joaquim Távora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3399,
                Nome = "Joaquim Távora",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jundiaí do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3400,
                Nome = "Jundiaí do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Juranda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3401,
                Nome = "Juranda",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Jussara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3402,
                Nome = "Jussara",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Kaloré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3403,
                Nome = "Kaloré",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Lapa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3404,
                Nome = "Lapa",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Laranjal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3405,
                Nome = "Laranjal",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Laranjeiras do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3406,
                Nome = "Laranjeiras do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Leópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3407,
                Nome = "Leópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Lidianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3408,
                Nome = "Lidianópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Lindoeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3409,
                Nome = "Lindoeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Loanda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3410,
                Nome = "Loanda",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Lobato
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3411,
                Nome = "Lobato",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Londrina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3412,
                Nome = "Londrina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Luisiana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3413,
                Nome = "Luisiana",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Lunardelli
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3414,
                Nome = "Lunardelli",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Lupionópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3415,
                Nome = "Lupionópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mallet
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3416,
                Nome = "Mallet",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mamborê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3417,
                Nome = "Mamborê",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mandaguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3418,
                Nome = "Mandaguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mandaguari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3419,
                Nome = "Mandaguari",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mandirituba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3420,
                Nome = "Mandirituba",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Manfrinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3421,
                Nome = "Manfrinópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mangueirinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3422,
                Nome = "Mangueirinha",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Manoel Ribas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3423,
                Nome = "Manoel Ribas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Marechal Cândido Rondon
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3424,
                Nome = "Marechal Cândido Rondon",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Maria Helena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3425,
                Nome = "Maria Helena",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Marialva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3426,
                Nome = "Marialva",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Marilândia do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3427,
                Nome = "Marilândia do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Marilena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3428,
                Nome = "Marilena",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mariluz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3429,
                Nome = "Mariluz",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Maringá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3430,
                Nome = "Maringá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mariópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3431,
                Nome = "Mariópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Maripá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3432,
                Nome = "Maripá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Marmeleiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3433,
                Nome = "Marmeleiro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Marquinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3434,
                Nome = "Marquinho",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Marumbi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3435,
                Nome = "Marumbi",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Matelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3436,
                Nome = "Matelândia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Matinhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3437,
                Nome = "Matinhos",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mato Rico
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3438,
                Nome = "Mato Rico",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mauá da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3439,
                Nome = "Mauá da Serra",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Medianeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3440,
                Nome = "Medianeira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mercedes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3441,
                Nome = "Mercedes",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Mirador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3442,
                Nome = "Mirador",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Miraselva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3443,
                Nome = "Miraselva",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Missal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3444,
                Nome = "Missal",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Moreira Sales
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3445,
                Nome = "Moreira Sales",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Morretes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3446,
                Nome = "Morretes",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Munhoz de Melo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3447,
                Nome = "Munhoz de Melo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nossa Senhora das Graças
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3448,
                Nome = "Nossa Senhora das Graças",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Aliança do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3449,
                Nome = "Nova Aliança do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova América da Colina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3450,
                Nome = "Nova América da Colina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Aurora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3451,
                Nome = "Nova Aurora",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Cantu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3452,
                Nome = "Nova Cantu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Esperança
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3453,
                Nome = "Nova Esperança",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Esperança do Sudoeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3454,
                Nome = "Nova Esperança do Sudoeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Fátima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3455,
                Nome = "Nova Fátima",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Laranjeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3456,
                Nome = "Nova Laranjeiras",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Londrina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3457,
                Nome = "Nova Londrina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Olímpia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3458,
                Nome = "Nova Olímpia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Prata do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3459,
                Nome = "Nova Prata do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Santa Bárbara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3460,
                Nome = "Nova Santa Bárbara",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Santa Rosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3461,
                Nome = "Nova Santa Rosa",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Nova Tebas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3462,
                Nome = "Nova Tebas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Novo Itacolomi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3463,
                Nome = "Novo Itacolomi",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ortigueira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3464,
                Nome = "Ortigueira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ourizona
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3465,
                Nome = "Ourizona",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ouro Verde do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3466,
                Nome = "Ouro Verde do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paiçandu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3467,
                Nome = "Paiçandu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Palmas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3468,
                Nome = "Palmas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Palmeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3469,
                Nome = "Palmeira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Palmital
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3470,
                Nome = "Palmital",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Palotina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3471,
                Nome = "Palotina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paraíso do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3472,
                Nome = "Paraíso do Norte",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paranacity
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3473,
                Nome = "Paranacity",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paranaguá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3474,
                Nome = "Paranaguá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paranapoema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3475,
                Nome = "Paranapoema",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paranavaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3476,
                Nome = "Paranavaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pato Bragado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3477,
                Nome = "Pato Bragado",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pato Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3478,
                Nome = "Pato Branco",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paula Freitas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3479,
                Nome = "Paula Freitas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Paulo Frontin
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3480,
                Nome = "Paulo Frontin",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Peabiru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3481,
                Nome = "Peabiru",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Perobal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3482,
                Nome = "Perobal",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pérola
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3483,
                Nome = "Pérola",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pérola d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3484,
                Nome = "Pérola d Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Piên
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3485,
                Nome = "Piên",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pinhais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3486,
                Nome = "Pinhais",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pinhal de São Bento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3487,
                Nome = "Pinhal de São Bento",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pinhalão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3488,
                Nome = "Pinhalão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pinhão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3489,
                Nome = "Pinhão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Piraí do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3490,
                Nome = "Piraí do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Piraquara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3491,
                Nome = "Piraquara",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pitanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3492,
                Nome = "Pitanga",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pitangueiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3493,
                Nome = "Pitangueiras",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Planaltina do Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3494,
                Nome = "Planaltina do Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Planalto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3495,
                Nome = "Planalto",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ponta Grossa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3496,
                Nome = "Ponta Grossa",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pontal do Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3497,
                Nome = "Pontal do Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Porecatu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3498,
                Nome = "Porecatu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Porto Amazonas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3499,
                Nome = "Porto Amazonas",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Porto Barreiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3500,
                Nome = "Porto Barreiro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Porto Rico
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3501,
                Nome = "Porto Rico",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Porto Vitória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3502,
                Nome = "Porto Vitória",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Prado Ferreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3503,
                Nome = "Prado Ferreira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Pranchita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3504,
                Nome = "Pranchita",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Presidente Castelo Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3505,
                Nome = "Presidente Castelo Branco",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Primeiro de Maio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3506,
                Nome = "Primeiro de Maio",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Prudentópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3507,
                Nome = "Prudentópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Quarto Centenário
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3508,
                Nome = "Quarto Centenário",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Quatiguá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3509,
                Nome = "Quatiguá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Quatro Barras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3510,
                Nome = "Quatro Barras",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Quatro Pontes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3511,
                Nome = "Quatro Pontes",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Quedas do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3512,
                Nome = "Quedas do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Querência do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3513,
                Nome = "Querência do Norte",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Quinta do Sol
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3514,
                Nome = "Quinta do Sol",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Quitandinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3515,
                Nome = "Quitandinha",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ramilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3516,
                Nome = "Ramilândia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rancho Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3517,
                Nome = "Rancho Alegre",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rancho Alegre D Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3518,
                Nome = "Rancho Alegre D Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Realeza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3519,
                Nome = "Realeza",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rebouças
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3520,
                Nome = "Rebouças",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Renascença
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3521,
                Nome = "Renascença",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Reserva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3522,
                Nome = "Reserva",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Reserva do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3523,
                Nome = "Reserva do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ribeirão Claro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3524,
                Nome = "Ribeirão Claro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ribeirão do Pinhal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3525,
                Nome = "Ribeirão do Pinhal",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rio Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3526,
                Nome = "Rio Azul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rio Bom
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3527,
                Nome = "Rio Bom",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rio Bonito do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3528,
                Nome = "Rio Bonito do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rio Branco do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3529,
                Nome = "Rio Branco do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rio Branco do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3530,
                Nome = "Rio Branco do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rio Negro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3531,
                Nome = "Rio Negro",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3532,
                Nome = "Rolândia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Roncador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3533,
                Nome = "Roncador",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rondon
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3534,
                Nome = "Rondon",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Rosário do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3535,
                Nome = "Rosário do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Sabáudia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3536,
                Nome = "Sabáudia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Salgado Filho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3537,
                Nome = "Salgado Filho",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Salto do Itararé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3538,
                Nome = "Salto do Itararé",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Salto do Lontra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3539,
                Nome = "Salto do Lontra",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Amélia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3540,
                Nome = "Santa Amélia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Cecília do Pavão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3541,
                Nome = "Santa Cecília do Pavão",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Cruz de Monte Castelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3542,
                Nome = "Santa Cruz de Monte Castelo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Fé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3543,
                Nome = "Santa Fé",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Helena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3544,
                Nome = "Santa Helena",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Inês
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3545,
                Nome = "Santa Inês",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Isabel do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3546,
                Nome = "Santa Isabel do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Izabel do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3547,
                Nome = "Santa Izabel do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Lúcia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3548,
                Nome = "Santa Lúcia",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Maria do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3549,
                Nome = "Santa Maria do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Mariana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3550,
                Nome = "Santa Mariana",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Mônica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3551,
                Nome = "Santa Mônica",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Tereza do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3552,
                Nome = "Santa Tereza do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santa Terezinha de Itaipu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3553,
                Nome = "Santa Terezinha de Itaipu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santana do Itararé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3554,
                Nome = "Santana do Itararé",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santo Antônio da Platina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3555,
                Nome = "Santo Antônio da Platina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santo Antônio do Caiuá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3556,
                Nome = "Santo Antônio do Caiuá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santo Antônio do Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3557,
                Nome = "Santo Antônio do Paraíso",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santo Antônio do Sudoeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3558,
                Nome = "Santo Antônio do Sudoeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Santo Inácio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3559,
                Nome = "Santo Inácio",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Carlos do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3560,
                Nome = "São Carlos do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Jerônimo da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3561,
                Nome = "São Jerônimo da Serra",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São João
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3562,
                Nome = "São João",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São João do Caiuá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3563,
                Nome = "São João do Caiuá",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São João do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3564,
                Nome = "São João do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São João do Triunfo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3565,
                Nome = "São João do Triunfo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Jorge do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3566,
                Nome = "São Jorge do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Jorge do Patrocínio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3567,
                Nome = "São Jorge do Patrocínio",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Jorge d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3568,
                Nome = "São Jorge d Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São José da Boa Vista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3569,
                Nome = "São José da Boa Vista",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São José das Palmeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3570,
                Nome = "São José das Palmeiras",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São José dos Pinhais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3571,
                Nome = "São José dos Pinhais",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Manoel do Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3572,
                Nome = "São Manoel do Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Mateus do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3573,
                Nome = "São Mateus do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Miguel do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3574,
                Nome = "São Miguel do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Pedro do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3575,
                Nome = "São Pedro do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Pedro do Ivaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3576,
                Nome = "São Pedro do Ivaí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Pedro do Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3577,
                Nome = "São Pedro do Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Sebastião da Amoreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3578,
                Nome = "São Sebastião da Amoreira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: São Tomé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3579,
                Nome = "São Tomé",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Sapopema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3580,
                Nome = "Sapopema",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Sarandi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3581,
                Nome = "Sarandi",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Saudade do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3582,
                Nome = "Saudade do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Sengés
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3583,
                Nome = "Sengés",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Serranópolis do Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3584,
                Nome = "Serranópolis do Iguaçu",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Sertaneja
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3585,
                Nome = "Sertaneja",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Sertanópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3586,
                Nome = "Sertanópolis",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Siqueira Campos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3587,
                Nome = "Siqueira Campos",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Sulina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3588,
                Nome = "Sulina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tamarana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3589,
                Nome = "Tamarana",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tamboara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3590,
                Nome = "Tamboara",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tapejara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3591,
                Nome = "Tapejara",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tapira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3592,
                Nome = "Tapira",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Teixeira Soares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3593,
                Nome = "Teixeira Soares",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Telêmaco Borba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3594,
                Nome = "Telêmaco Borba",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Terra Boa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3595,
                Nome = "Terra Boa",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Terra Rica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3596,
                Nome = "Terra Rica",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Terra Roxa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3597,
                Nome = "Terra Roxa",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tibagi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3598,
                Nome = "Tibagi",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tijucas do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3599,
                Nome = "Tijucas do Sul",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Toledo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3600,
                Nome = "Toledo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tomazina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3601,
                Nome = "Tomazina",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Três Barras do Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3602,
                Nome = "Três Barras do Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tunas do Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3603,
                Nome = "Tunas do Paraná",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tuneiras do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3604,
                Nome = "Tuneiras do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Tupãssi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3605,
                Nome = "Tupãssi",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Turvo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3606,
                Nome = "Turvo",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ubiratã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3607,
                Nome = "Ubiratã",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Umuarama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3608,
                Nome = "Umuarama",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: União da Vitória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3609,
                Nome = "União da Vitória",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Uniflor
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3610,
                Nome = "Uniflor",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Uraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3611,
                Nome = "Uraí",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Ventania
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3612,
                Nome = "Ventania",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Vera Cruz do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3613,
                Nome = "Vera Cruz do Oeste",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Verê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3614,
                Nome = "Verê",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Virmond
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3615,
                Nome = "Virmond",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Vitorino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3616,
                Nome = "Vitorino",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Wenceslau Braz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3617,
                Nome = "Wenceslau Braz",
                Situacao = "Ativo",
                UF = "PR"
            });

            // cidade: Xambrê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3618,
                Nome = "Xambrê",
                Situacao = "Ativo",
                UF = "PR"
            });


            await _context.SaveChangesAsync();
        }
    }
}
