using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class GO
    {
        private readonly ApplicationDbContext _context;

        public GO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: GO
            //----------------------------------------------------

            // cidade: Abadia de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 911,
                Nome = "Abadia de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Abadiânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 912,
                Nome = "Abadiânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Acreúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 913,
                Nome = "Acreúna",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Adelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 914,
                Nome = "Adelândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Água Fria de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 915,
                Nome = "Água Fria de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Água Limpa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 916,
                Nome = "Água Limpa",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Águas Lindas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 917,
                Nome = "Águas Lindas",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Alexânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 918,
                Nome = "Alexânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aloândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 919,
                Nome = "Aloândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Alto Horizonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 920,
                Nome = "Alto Horizonte",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Alto Paraíso de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 921,
                Nome = "Alto Paraíso de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Alvorada do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 922,
                Nome = "Alvorada do Norte",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Amaralina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 923,
                Nome = "Amaralina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Americano do Brasil
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 924,
                Nome = "Americano do Brasil",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Amorinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 925,
                Nome = "Amorinópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Anápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 926,
                Nome = "Anápolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Anhangüera
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 927,
                Nome = "Anhangüera",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Anicuns
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 928,
                Nome = "Anicuns",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aparecida de Goiânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 929,
                Nome = "Aparecida de Goiânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aparecida do Rio Doce
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 930,
                Nome = "Aparecida do Rio Doce",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aporé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 931,
                Nome = "Aporé",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Araçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 932,
                Nome = "Araçu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aragarças
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 933,
                Nome = "Aragarças",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aragoiânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 934,
                Nome = "Aragoiânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Araguapaz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 935,
                Nome = "Araguapaz",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Arenópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 936,
                Nome = "Arenópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aruanã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 937,
                Nome = "Aruanã",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Aurilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 938,
                Nome = "Aurilândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Avelinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 939,
                Nome = "Avelinópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Baliza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 940,
                Nome = "Baliza",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Barro Alto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 941,
                Nome = "Barro Alto",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Bela Vista de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 942,
                Nome = "Bela Vista de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Bom Jardim de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 943,
                Nome = "Bom Jardim de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Bom Jesus de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 944,
                Nome = "Bom Jesus de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Bonfinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 945,
                Nome = "Bonfinópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Bonópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 946,
                Nome = "Bonópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Brazabrantes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 947,
                Nome = "Brazabrantes",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Britânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 948,
                Nome = "Britânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Buriti Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 949,
                Nome = "Buriti Alegre",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Buriti de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 950,
                Nome = "Buriti de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Buritinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 951,
                Nome = "Buritinópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cabeceiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 952,
                Nome = "Cabeceiras",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cachoeira Alta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 953,
                Nome = "Cachoeira Alta",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cachoeira de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 954,
                Nome = "Cachoeira de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cachoeira Dourada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 955,
                Nome = "Cachoeira Dourada",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Caçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 956,
                Nome = "Caçu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Caiapônia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 957,
                Nome = "Caiapônia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Caldas Novas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 958,
                Nome = "Caldas Novas",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Caldazinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 959,
                Nome = "Caldazinha",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Campestre de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 960,
                Nome = "Campestre de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Campinaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 961,
                Nome = "Campinaçu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Campinorte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 962,
                Nome = "Campinorte",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Campo Alegre de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 963,
                Nome = "Campo Alegre de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Campo Limpo de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 964,
                Nome = "Campo Limpo de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Campos Belos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 965,
                Nome = "Campos Belos",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Campos Verdes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 966,
                Nome = "Campos Verdes",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Carmo do Rio Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 967,
                Nome = "Carmo do Rio Verde",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Castelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 968,
                Nome = "Castelândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Catalão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 969,
                Nome = "Catalão",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Caturaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 970,
                Nome = "Caturaí",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cavalcante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 971,
                Nome = "Cavalcante",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Ceres
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 972,
                Nome = "Ceres",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cezarina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 973,
                Nome = "Cezarina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Chapadão do Céu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 974,
                Nome = "Chapadão do Céu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cidade Ocidental
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 975,
                Nome = "Cidade Ocidental",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cocalzinho de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 976,
                Nome = "Cocalzinho de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Colinas do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 977,
                Nome = "Colinas do Sul",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Córrego do Ouro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 978,
                Nome = "Córrego do Ouro",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Corumbá de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 979,
                Nome = "Corumbá de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Corumbaíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 980,
                Nome = "Corumbaíba",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cristalina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 981,
                Nome = "Cristalina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cristianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 982,
                Nome = "Cristianópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Crixás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 983,
                Nome = "Crixás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cromínia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 984,
                Nome = "Cromínia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Cumari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 985,
                Nome = "Cumari",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Damianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 986,
                Nome = "Damianópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Damolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 987,
                Nome = "Damolândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Davinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 988,
                Nome = "Davinópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Diorama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 989,
                Nome = "Diorama",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Divinópolis de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 990,
                Nome = "Divinópolis de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Doverlândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 991,
                Nome = "Doverlândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Edealina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 992,
                Nome = "Edealina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Edéia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 993,
                Nome = "Edéia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Estrela do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 994,
                Nome = "Estrela do Norte",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Faina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 995,
                Nome = "Faina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Fazenda Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 996,
                Nome = "Fazenda Nova",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Firminópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 997,
                Nome = "Firminópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Flores de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 998,
                Nome = "Flores de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Formosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 999,
                Nome = "Formosa",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Formoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1000,
                Nome = "Formoso",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Gameleira de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1001,
                Nome = "Gameleira de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Goianápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1002,
                Nome = "Goianápolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Goiandira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1003,
                Nome = "Goiandira",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Goianésia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1004,
                Nome = "Goianésia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Goiânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1005,
                Nome = "Goiânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Goianira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1006,
                Nome = "Goianira",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1007,
                Nome = "Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Goiatuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1008,
                Nome = "Goiatuba",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Gouvelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1009,
                Nome = "Gouvelândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Guapó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1010,
                Nome = "Guapó",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Guaraíta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1011,
                Nome = "Guaraíta",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Guarani de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1012,
                Nome = "Guarani de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Guarinos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1013,
                Nome = "Guarinos",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Heitoraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1014,
                Nome = "Heitoraí",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Hidrolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1015,
                Nome = "Hidrolândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Hidrolina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1016,
                Nome = "Hidrolina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Iaciara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1017,
                Nome = "Iaciara",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Inaciolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1018,
                Nome = "Inaciolândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Indiara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1019,
                Nome = "Indiara",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Inhumas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1020,
                Nome = "Inhumas",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Ipameri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1021,
                Nome = "Ipameri",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Ipiranga de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1022,
                Nome = "Ipiranga de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Iporá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1023,
                Nome = "Iporá",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Israelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1024,
                Nome = "Israelândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itaberaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1025,
                Nome = "Itaberaí",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itaguari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1026,
                Nome = "Itaguari",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itaguaru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1027,
                Nome = "Itaguaru",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itajá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1028,
                Nome = "Itajá",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itapaci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1029,
                Nome = "Itapaci",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itapirapuã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1030,
                Nome = "Itapirapuã",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itapuranga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1031,
                Nome = "Itapuranga",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itarumã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1032,
                Nome = "Itarumã",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itauçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1033,
                Nome = "Itauçu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Itumbiara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1034,
                Nome = "Itumbiara",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Ivolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1035,
                Nome = "Ivolândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Jandaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1036,
                Nome = "Jandaia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Jaraguá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1037,
                Nome = "Jaraguá",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Jataí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1038,
                Nome = "Jataí",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Jaupaci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1039,
                Nome = "Jaupaci",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Jesúpolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1040,
                Nome = "Jesúpolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Joviânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1041,
                Nome = "Joviânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Jussara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1042,
                Nome = "Jussara",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Lagoa Santa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1043,
                Nome = "Lagoa Santa",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Leopoldo de Bulhões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1044,
                Nome = "Leopoldo de Bulhões",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Luziânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1045,
                Nome = "Luziânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mairipotaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1046,
                Nome = "Mairipotaba",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mambaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1047,
                Nome = "Mambaí",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mara Rosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1048,
                Nome = "Mara Rosa",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Marzagão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1049,
                Nome = "Marzagão",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Matrinchã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1050,
                Nome = "Matrinchã",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Maurilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1051,
                Nome = "Maurilândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mimoso de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1052,
                Nome = "Mimoso de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Minaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1053,
                Nome = "Minaçu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mineiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1054,
                Nome = "Mineiros",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Moiporá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1055,
                Nome = "Moiporá",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Monte Alegre de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1056,
                Nome = "Monte Alegre de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Montes Claros de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1057,
                Nome = "Montes Claros de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Montividiu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1058,
                Nome = "Montividiu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Montividiu do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1059,
                Nome = "Montividiu do Norte",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Morrinhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1060,
                Nome = "Morrinhos",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Morro Agudo de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1061,
                Nome = "Morro Agudo de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mossâmedes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1062,
                Nome = "Mossâmedes",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mozarlândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1063,
                Nome = "Mozarlândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mundo Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1064,
                Nome = "Mundo Novo",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Mutunópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1065,
                Nome = "Mutunópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nazário
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1066,
                Nome = "Nazário",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nerópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1067,
                Nome = "Nerópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Niquelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1068,
                Nome = "Niquelândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nova América
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1069,
                Nome = "Nova América",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nova Aurora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1070,
                Nome = "Nova Aurora",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nova Crixás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1071,
                Nome = "Nova Crixás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nova Glória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1072,
                Nome = "Nova Glória",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nova Iguaçu de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1073,
                Nome = "Nova Iguaçu de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nova Roma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1074,
                Nome = "Nova Roma",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Nova Veneza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1075,
                Nome = "Nova Veneza",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Novo Brasil
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1076,
                Nome = "Novo Brasil",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Novo Gama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1077,
                Nome = "Novo Gama",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Novo Planalto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1078,
                Nome = "Novo Planalto",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Orizona
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1079,
                Nome = "Orizona",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Ouro Verde de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1080,
                Nome = "Ouro Verde de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Ouvidor
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1081,
                Nome = "Ouvidor",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Padre Bernardo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1082,
                Nome = "Padre Bernardo",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Palestina de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1083,
                Nome = "Palestina de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Palmeiras de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1084,
                Nome = "Palmeiras de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Palmelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1085,
                Nome = "Palmelo",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Palminópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1086,
                Nome = "Palminópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Panamá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1087,
                Nome = "Panamá",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Paranaiguara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1088,
                Nome = "Paranaiguara",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Paraúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1089,
                Nome = "Paraúna",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Perolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1090,
                Nome = "Perolândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Petrolina de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1091,
                Nome = "Petrolina de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Pilar de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1092,
                Nome = "Pilar de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Piracanjuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1093,
                Nome = "Piracanjuba",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Piranhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1094,
                Nome = "Piranhas",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Pirenópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1095,
                Nome = "Pirenópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Pires do Rio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1096,
                Nome = "Pires do Rio",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Planaltina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1097,
                Nome = "Planaltina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Pontalina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1098,
                Nome = "Pontalina",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Porangatu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1099,
                Nome = "Porangatu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Porteirão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1100,
                Nome = "Porteirão",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Portelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1101,
                Nome = "Portelândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Posse
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1102,
                Nome = "Posse",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Professor Jamil Safady
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1103,
                Nome = "Professor Jamil Safady",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Quirinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1104,
                Nome = "Quirinópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Rialma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1105,
                Nome = "Rialma",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Rianápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1106,
                Nome = "Rianápolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Rio Quente
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1107,
                Nome = "Rio Quente",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Rio Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1108,
                Nome = "Rio Verde",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Rubiataba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1109,
                Nome = "Rubiataba",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Sanclerlândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1110,
                Nome = "Sanclerlândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Bárbara de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1111,
                Nome = "Santa Bárbara de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Cruz de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1112,
                Nome = "Santa Cruz de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Fé de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1113,
                Nome = "Santa Fé de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Helena de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1114,
                Nome = "Santa Helena de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Isabel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1115,
                Nome = "Santa Isabel",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Rita do Araguaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1116,
                Nome = "Santa Rita do Araguaia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Rita do Novo Destino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1117,
                Nome = "Santa Rita do Novo Destino",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Rosa de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1118,
                Nome = "Santa Rosa de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Tereza de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1119,
                Nome = "Santa Tereza de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santa Terezinha de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1120,
                Nome = "Santa Terezinha de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santo Antônio da Barra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1121,
                Nome = "Santo Antônio da Barra",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santo Antônio de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1122,
                Nome = "Santo Antônio de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Santo Antônio do Descoberto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1123,
                Nome = "Santo Antônio do Descoberto",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Domingos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1124,
                Nome = "São Domingos",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Francisco de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1125,
                Nome = "São Francisco de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São João da Paraúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1126,
                Nome = "São João da Paraúna",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São João d Aliança
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1127,
                Nome = "São João d Aliança",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Luís de Montes Belos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1128,
                Nome = "São Luís de Montes Belos",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Luís do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1129,
                Nome = "São Luís do Norte",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Miguel do Araguaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1130,
                Nome = "São Miguel do Araguaia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Miguel do Passa Quatro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1131,
                Nome = "São Miguel do Passa Quatro",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Patrício
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1132,
                Nome = "São Patrício",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: São Simão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1133,
                Nome = "São Simão",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Senador Canedo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1134,
                Nome = "Senador Canedo",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Serranópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1135,
                Nome = "Serranópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Silvânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1136,
                Nome = "Silvânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Simolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1137,
                Nome = "Simolândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Sítio d Abadia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1138,
                Nome = "Sítio d Abadia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Taquaral de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1139,
                Nome = "Taquaral de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Teresina de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1140,
                Nome = "Teresina de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Terezópolis de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1141,
                Nome = "Terezópolis de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Três Ranchos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1142,
                Nome = "Três Ranchos",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Trindade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1143,
                Nome = "Trindade",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Trombas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1144,
                Nome = "Trombas",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Turvânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1145,
                Nome = "Turvânia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Turvelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1146,
                Nome = "Turvelândia",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Uirapuru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1147,
                Nome = "Uirapuru",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Uruaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1148,
                Nome = "Uruaçu",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Uruana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1149,
                Nome = "Uruana",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Urutaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1150,
                Nome = "Urutaí",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Valparaíso de Goiás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1151,
                Nome = "Valparaíso de Goiás",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Varjão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1152,
                Nome = "Varjão",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Vianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1153,
                Nome = "Vianópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Vicentinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1154,
                Nome = "Vicentinópolis",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Vila Boa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1155,
                Nome = "Vila Boa",
                Situacao = "Ativo",
                UF = "GO"
            });

            // cidade: Vila Propício
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1156,
                Nome = "Vila Propício",
                Situacao = "Ativo",
                UF = "GO"
            });



            await _context.SaveChangesAsync();
        }
    }
}
