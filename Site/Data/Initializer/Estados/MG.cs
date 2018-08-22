using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class MG
    {
        private readonly ApplicationDbContext _context;

        public MG(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: MG
            //----------------------------------------------------

            // cidade: Abadia dos Dourados
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1375,
                Nome = "Abadia dos Dourados",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Abaeté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1376,
                Nome = "Abaeté",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Abre Campo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1377,
                Nome = "Abre Campo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Acaiaca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1378,
                Nome = "Acaiaca",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Açucena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1379,
                Nome = "Açucena",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Água Boa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1380,
                Nome = "Água Boa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Água Comprida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1381,
                Nome = "Água Comprida",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Aguanil
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1382,
                Nome = "Aguanil",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Águas Formosas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1383,
                Nome = "Águas Formosas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Águas Vermelhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1384,
                Nome = "Águas Vermelhas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Aimorés
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1385,
                Nome = "Aimorés",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Aiuruoca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1386,
                Nome = "Aiuruoca",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alagoa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1387,
                Nome = "Alagoa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Albertina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1388,
                Nome = "Albertina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Além Paraíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1389,
                Nome = "Além Paraíba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alfenas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1390,
                Nome = "Alfenas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alfredo Vasconcelos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1391,
                Nome = "Alfredo Vasconcelos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Almenara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1392,
                Nome = "Almenara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alpercata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1393,
                Nome = "Alpercata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alpinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1394,
                Nome = "Alpinópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alterosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1395,
                Nome = "Alterosa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alto Caparaó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1396,
                Nome = "Alto Caparaó",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alto Jequitibá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1397,
                Nome = "Alto Jequitibá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alto Rio Doce
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1398,
                Nome = "Alto Rio Doce",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alvarenga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1399,
                Nome = "Alvarenga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alvinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1400,
                Nome = "Alvinópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Alvorada de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1401,
                Nome = "Alvorada de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Amparo do Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1402,
                Nome = "Amparo do Serra",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Andradas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1403,
                Nome = "Andradas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Andrelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1404,
                Nome = "Andrelândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Angelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1405,
                Nome = "Angelândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Antônio Carlos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1406,
                Nome = "Antônio Carlos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Antônio Dias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1407,
                Nome = "Antônio Dias",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Antônio Prado de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1408,
                Nome = "Antônio Prado de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Araçaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1409,
                Nome = "Araçaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Aracitaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1410,
                Nome = "Aracitaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Araçuaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1411,
                Nome = "Araçuaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Araguari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1412,
                Nome = "Araguari",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Arantina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1413,
                Nome = "Arantina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Araponga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1414,
                Nome = "Araponga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Araporã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1415,
                Nome = "Araporã",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Arapuá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1416,
                Nome = "Arapuá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Araújos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1417,
                Nome = "Araújos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Araxá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1418,
                Nome = "Araxá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Arceburgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1419,
                Nome = "Arceburgo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Arcos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1420,
                Nome = "Arcos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Areado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1421,
                Nome = "Areado",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Argirita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1422,
                Nome = "Argirita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Aricanduva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1423,
                Nome = "Aricanduva",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Arinos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1424,
                Nome = "Arinos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Astolfo Dutra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1425,
                Nome = "Astolfo Dutra",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ataléia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1426,
                Nome = "Ataléia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Augusto de Lima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1427,
                Nome = "Augusto de Lima",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Baependi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1428,
                Nome = "Baependi",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Baldim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1429,
                Nome = "Baldim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bambuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1430,
                Nome = "Bambuí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bandeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1431,
                Nome = "Bandeira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bandeira do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1432,
                Nome = "Bandeira do Sul",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Barão de Cocais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1433,
                Nome = "Barão de Cocais",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Barão de Monte Alto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1434,
                Nome = "Barão de Monte Alto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Barbacena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1435,
                Nome = "Barbacena",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Barra Longa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1436,
                Nome = "Barra Longa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Barroso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1437,
                Nome = "Barroso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bela Vista de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1438,
                Nome = "Bela Vista de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Belmiro Braga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1439,
                Nome = "Belmiro Braga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Belo Horizonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1440,
                Nome = "Belo Horizonte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Belo Oriente
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1441,
                Nome = "Belo Oriente",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Belo Vale
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1442,
                Nome = "Belo Vale",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Berilo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1443,
                Nome = "Berilo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Berizal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1444,
                Nome = "Berizal",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bertópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1445,
                Nome = "Bertópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Betim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1446,
                Nome = "Betim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bias Fortes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1447,
                Nome = "Bias Fortes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bicas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1448,
                Nome = "Bicas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Biquinhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1449,
                Nome = "Biquinhas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Boa Esperança
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1450,
                Nome = "Boa Esperança",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bocaina de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1451,
                Nome = "Bocaina de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bocaiúva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1452,
                Nome = "Bocaiúva",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bom Despacho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1453,
                Nome = "Bom Despacho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bom Jardim de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1454,
                Nome = "Bom Jardim de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bom Jesus da Penha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1455,
                Nome = "Bom Jesus da Penha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bom Jesus do Amparo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1456,
                Nome = "Bom Jesus do Amparo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bom Jesus do Galho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1457,
                Nome = "Bom Jesus do Galho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bom Repouso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1458,
                Nome = "Bom Repouso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bom Sucesso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1459,
                Nome = "Bom Sucesso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bonfim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1460,
                Nome = "Bonfim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bonfinópolis de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1461,
                Nome = "Bonfinópolis de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bonito de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1462,
                Nome = "Bonito de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Borda da Mata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1463,
                Nome = "Borda da Mata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Botelhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1464,
                Nome = "Botelhos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Botumirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1465,
                Nome = "Botumirim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Brás Pires
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1466,
                Nome = "Brás Pires",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Brasilândia de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1467,
                Nome = "Brasilândia de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Brasília de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1468,
                Nome = "Brasília de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Brasópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1469,
                Nome = "Brasópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Braúnas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1470,
                Nome = "Braúnas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Brumadinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1471,
                Nome = "Brumadinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bueno Brandão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1472,
                Nome = "Bueno Brandão",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Buenópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1473,
                Nome = "Buenópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Bugre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1474,
                Nome = "Bugre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Buritis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1475,
                Nome = "Buritis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Buritizeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1476,
                Nome = "Buritizeiro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cabeceira Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1477,
                Nome = "Cabeceira Grande",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cabo Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1478,
                Nome = "Cabo Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cachoeira da Prata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1479,
                Nome = "Cachoeira da Prata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cachoeira de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1480,
                Nome = "Cachoeira de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cachoeira de Pajeú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1481,
                Nome = "Cachoeira de Pajeú",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cachoeira Dourada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1482,
                Nome = "Cachoeira Dourada",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caetanópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1483,
                Nome = "Caetanópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caeté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1484,
                Nome = "Caeté",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caiana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1485,
                Nome = "Caiana",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cajuri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1486,
                Nome = "Cajuri",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caldas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1487,
                Nome = "Caldas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Camacho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1488,
                Nome = "Camacho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Camanducaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1489,
                Nome = "Camanducaia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cambuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1490,
                Nome = "Cambuí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cambuquira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1491,
                Nome = "Cambuquira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campanário
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1492,
                Nome = "Campanário",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campanha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1493,
                Nome = "Campanha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campestre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1494,
                Nome = "Campestre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campina Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1495,
                Nome = "Campina Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campo Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1496,
                Nome = "Campo Azul",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campo Belo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1497,
                Nome = "Campo Belo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campo do Meio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1498,
                Nome = "Campo do Meio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campo Florido
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1499,
                Nome = "Campo Florido",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campos Altos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1500,
                Nome = "Campos Altos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Campos Gerais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1501,
                Nome = "Campos Gerais",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cana Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1502,
                Nome = "Cana Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Canaã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1503,
                Nome = "Canaã",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Canápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1504,
                Nome = "Canápolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Candeias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1505,
                Nome = "Candeias",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cantagalo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1506,
                Nome = "Cantagalo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caparaó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1507,
                Nome = "Caparaó",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capela Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1508,
                Nome = "Capela Nova",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capelinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1509,
                Nome = "Capelinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capetinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1510,
                Nome = "Capetinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capim Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1511,
                Nome = "Capim Branco",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1512,
                Nome = "Capinópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capitão Andrade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1513,
                Nome = "Capitão Andrade",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capitão Enéas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1514,
                Nome = "Capitão Enéas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Capitólio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1515,
                Nome = "Capitólio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caputira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1516,
                Nome = "Caputira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1517,
                Nome = "Caraí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caranaíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1518,
                Nome = "Caranaíba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carandaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1519,
                Nome = "Carandaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carangola
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1520,
                Nome = "Carangola",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caratinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1521,
                Nome = "Caratinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carbonita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1522,
                Nome = "Carbonita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Careaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1523,
                Nome = "Careaçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carlos Chagas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1524,
                Nome = "Carlos Chagas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmésia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1525,
                Nome = "Carmésia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmo da Cachoeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1526,
                Nome = "Carmo da Cachoeira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmo da Mata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1527,
                Nome = "Carmo da Mata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmo de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1528,
                Nome = "Carmo de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmo do Cajuru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1529,
                Nome = "Carmo do Cajuru",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmo do Paranaíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1530,
                Nome = "Carmo do Paranaíba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmo do Rio Claro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1531,
                Nome = "Carmo do Rio Claro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carmópolis de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1532,
                Nome = "Carmópolis de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carneirinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1533,
                Nome = "Carneirinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carrancas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1534,
                Nome = "Carrancas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carvalhópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1535,
                Nome = "Carvalhópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Carvalhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1536,
                Nome = "Carvalhos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Casa Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1537,
                Nome = "Casa Grande",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cascalho Rico
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1538,
                Nome = "Cascalho Rico",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cássia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1539,
                Nome = "Cássia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cataguases
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1540,
                Nome = "Cataguases",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Catas Altas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1541,
                Nome = "Catas Altas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Catas Altas da Noruega
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1542,
                Nome = "Catas Altas da Noruega",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Catuji
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1543,
                Nome = "Catuji",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Catuti
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1544,
                Nome = "Catuti",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Caxambu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1545,
                Nome = "Caxambu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cedro do Abaeté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1546,
                Nome = "Cedro do Abaeté",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Central de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1547,
                Nome = "Central de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Centralina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1548,
                Nome = "Centralina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Chácara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1549,
                Nome = "Chácara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Chalé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1550,
                Nome = "Chalé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Chapada do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1551,
                Nome = "Chapada do Norte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Chapada Gaúcha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1552,
                Nome = "Chapada Gaúcha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Chiador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1553,
                Nome = "Chiador",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cipotânea
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1554,
                Nome = "Cipotânea",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Claraval
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1555,
                Nome = "Claraval",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Claro dos Poções
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1556,
                Nome = "Claro dos Poções",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cláudio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1557,
                Nome = "Cláudio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coimbra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1558,
                Nome = "Coimbra",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coluna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1559,
                Nome = "Coluna",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Comendador Gomes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1560,
                Nome = "Comendador Gomes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Comercinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1561,
                Nome = "Comercinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição da Aparecida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1562,
                Nome = "Conceição da Aparecida",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição da Barra de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1563,
                Nome = "Conceição da Barra de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição das Alagoas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1564,
                Nome = "Conceição das Alagoas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição das Pedras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1565,
                Nome = "Conceição das Pedras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição de Ipanema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1566,
                Nome = "Conceição de Ipanema",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição do Mato Dentro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1567,
                Nome = "Conceição do Mato Dentro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição do Pará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1568,
                Nome = "Conceição do Pará",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição do Rio Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1569,
                Nome = "Conceição do Rio Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conceição dos Ouros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1570,
                Nome = "Conceição dos Ouros",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cônego Marinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1571,
                Nome = "Cônego Marinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Confins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1572,
                Nome = "Confins",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Congonhal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1573,
                Nome = "Congonhal",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Congonhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1574,
                Nome = "Congonhas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Congonhas do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1575,
                Nome = "Congonhas do Norte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conquista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1576,
                Nome = "Conquista",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conselheiro Lafaiete
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1577,
                Nome = "Conselheiro Lafaiete",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Conselheiro Pena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1578,
                Nome = "Conselheiro Pena",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Consolação
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1579,
                Nome = "Consolação",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Contagem
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1580,
                Nome = "Contagem",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coqueiral
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1581,
                Nome = "Coqueiral",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coração de Jesus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1582,
                Nome = "Coração de Jesus",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cordisburgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1583,
                Nome = "Cordisburgo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cordislândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1584,
                Nome = "Cordislândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Corinto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1585,
                Nome = "Corinto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coroaci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1586,
                Nome = "Coroaci",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coromandel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1587,
                Nome = "Coromandel",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coronel Fabriciano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1588,
                Nome = "Coronel Fabriciano",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coronel Murta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1589,
                Nome = "Coronel Murta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coronel Pacheco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1590,
                Nome = "Coronel Pacheco",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Coronel Xavier Chaves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1591,
                Nome = "Coronel Xavier Chaves",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Córrego Danta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1592,
                Nome = "Córrego Danta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Córrego do Bom Jesus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1593,
                Nome = "Córrego do Bom Jesus",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Córrego Fundo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1594,
                Nome = "Córrego Fundo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Córrego Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1595,
                Nome = "Córrego Novo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Couto de Magalhães de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1596,
                Nome = "Couto de Magalhães de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Crisólita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1597,
                Nome = "Crisólita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cristais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1598,
                Nome = "Cristais",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cristália
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1599,
                Nome = "Cristália",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cristiano Otoni
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1600,
                Nome = "Cristiano Otoni",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cristina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1601,
                Nome = "Cristina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Crucilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1602,
                Nome = "Crucilândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cruzeiro da Fortaleza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1603,
                Nome = "Cruzeiro da Fortaleza",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cruzília
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1604,
                Nome = "Cruzília",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Cuparaque
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1605,
                Nome = "Cuparaque",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Curral de Dentro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1606,
                Nome = "Curral de Dentro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Curvelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1607,
                Nome = "Curvelo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Datas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1608,
                Nome = "Datas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Delfim Moreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1609,
                Nome = "Delfim Moreira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Delfinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1610,
                Nome = "Delfinópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Delta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1611,
                Nome = "Delta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Descoberto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1612,
                Nome = "Descoberto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Desterro de Entre Rios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1613,
                Nome = "Desterro de Entre Rios",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Desterro do Melo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1614,
                Nome = "Desterro do Melo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Diamantina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1615,
                Nome = "Diamantina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Diogo de Vasconcelos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1616,
                Nome = "Diogo de Vasconcelos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dionísio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1617,
                Nome = "Dionísio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divinésia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1618,
                Nome = "Divinésia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1619,
                Nome = "Divino",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divino das Laranjeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1620,
                Nome = "Divino das Laranjeiras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divinolândia de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1621,
                Nome = "Divinolândia de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1622,
                Nome = "Divinópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divisa Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1623,
                Nome = "Divisa Alegre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divisa Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1624,
                Nome = "Divisa Nova",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Divisópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1625,
                Nome = "Divisópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dom Bosco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1626,
                Nome = "Dom Bosco",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dom Cavati
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1627,
                Nome = "Dom Cavati",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dom Joaquim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1628,
                Nome = "Dom Joaquim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dom Silvério
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1629,
                Nome = "Dom Silvério",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dom Viçoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1630,
                Nome = "Dom Viçoso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dona Eusébia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1631,
                Nome = "Dona Eusébia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dores de Campos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1632,
                Nome = "Dores de Campos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dores de Guanhães
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1633,
                Nome = "Dores de Guanhães",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dores do Indaiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1634,
                Nome = "Dores do Indaiá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Dores do Turvo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1635,
                Nome = "Dores do Turvo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Doresópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1636,
                Nome = "Doresópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Douradoquara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1637,
                Nome = "Douradoquara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Durandé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1638,
                Nome = "Durandé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Elói Mendes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1639,
                Nome = "Elói Mendes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Engenheiro Caldas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1640,
                Nome = "Engenheiro Caldas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Engenheiro Navarro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1641,
                Nome = "Engenheiro Navarro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Entre Folhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1642,
                Nome = "Entre Folhas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Entre Rios de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1643,
                Nome = "Entre Rios de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ervália
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1644,
                Nome = "Ervália",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Esmeraldas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1645,
                Nome = "Esmeraldas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Espera Feliz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1646,
                Nome = "Espera Feliz",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Espinosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1647,
                Nome = "Espinosa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Espírito Santo do Dourado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1648,
                Nome = "Espírito Santo do Dourado",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Estiva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1649,
                Nome = "Estiva",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Estrela Dalva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1650,
                Nome = "Estrela Dalva",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Estrela do Indaiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1651,
                Nome = "Estrela do Indaiá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Estrela do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1652,
                Nome = "Estrela do Sul",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Eugenópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1653,
                Nome = "Eugenópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ewbank da Câmara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1654,
                Nome = "Ewbank da Câmara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Extrema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1655,
                Nome = "Extrema",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1656,
                Nome = "Fama",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Faria Lemos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1657,
                Nome = "Faria Lemos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Felício dos Santos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1658,
                Nome = "Felício dos Santos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Felisburgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1659,
                Nome = "Felisburgo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Felixlândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1660,
                Nome = "Felixlândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fernandes Tourinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1661,
                Nome = "Fernandes Tourinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ferros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1662,
                Nome = "Ferros",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fervedouro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1663,
                Nome = "Fervedouro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Florestal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1664,
                Nome = "Florestal",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Formiga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1665,
                Nome = "Formiga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Formoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1666,
                Nome = "Formoso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fortaleza de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1667,
                Nome = "Fortaleza de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fortuna de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1668,
                Nome = "Fortuna de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Francisco Badaró
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1669,
                Nome = "Francisco Badaró",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Francisco Dumont
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1670,
                Nome = "Francisco Dumont",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Francisco Sá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1671,
                Nome = "Francisco Sá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Franciscópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1672,
                Nome = "Franciscópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Frei Gaspar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1673,
                Nome = "Frei Gaspar",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Frei Inocêncio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1674,
                Nome = "Frei Inocêncio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Frei Lagonegro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1675,
                Nome = "Frei Lagonegro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fronteira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1676,
                Nome = "Fronteira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fronteira dos Vales
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1677,
                Nome = "Fronteira dos Vales",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Fruta de Leite
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1678,
                Nome = "Fruta de Leite",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Frutal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1679,
                Nome = "Frutal",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Funilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1680,
                Nome = "Funilândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Galiléia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1681,
                Nome = "Galiléia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Gameleiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1682,
                Nome = "Gameleiras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Glaucilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1683,
                Nome = "Glaucilândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Goiabeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1684,
                Nome = "Goiabeira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Goianá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1685,
                Nome = "Goianá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Gonçalves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1686,
                Nome = "Gonçalves",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Gonzaga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1687,
                Nome = "Gonzaga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Gouvêia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1688,
                Nome = "Gouvêia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Governador Valadares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1689,
                Nome = "Governador Valadares",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Grão Mogol
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1690,
                Nome = "Grão Mogol",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Grupiara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1691,
                Nome = "Grupiara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guanhães
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1692,
                Nome = "Guanhães",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guapé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1693,
                Nome = "Guapé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guaraciaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1694,
                Nome = "Guaraciaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guaraciama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1695,
                Nome = "Guaraciama",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guaranésia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1696,
                Nome = "Guaranésia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guarani
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1697,
                Nome = "Guarani",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guarará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1698,
                Nome = "Guarará",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guarda Mor
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1699,
                Nome = "Guarda Mor",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guaxupé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1700,
                Nome = "Guaxupé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guidoval
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1701,
                Nome = "Guidoval",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guimarânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1702,
                Nome = "Guimarânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Guiricema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1703,
                Nome = "Guiricema",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Gurinhatã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1704,
                Nome = "Gurinhatã",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Heliodora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1705,
                Nome = "Heliodora",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Iapu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1706,
                Nome = "Iapu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibertioga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1707,
                Nome = "Ibertioga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1708,
                Nome = "Ibiá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibiaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1709,
                Nome = "Ibiaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibiracatu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1710,
                Nome = "Ibiracatu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibiraci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1711,
                Nome = "Ibiraci",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibirité
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1712,
                Nome = "Ibirité",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibitiúra de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1713,
                Nome = "Ibitiúra de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ibituruna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1714,
                Nome = "Ibituruna",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Icaraí de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1715,
                Nome = "Icaraí de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Igarapé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1716,
                Nome = "Igarapé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Igaratinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1717,
                Nome = "Igaratinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Iguatama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1718,
                Nome = "Iguatama",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ijaci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1719,
                Nome = "Ijaci",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ilicínea
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1720,
                Nome = "Ilicínea",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Imbé de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1721,
                Nome = "Imbé de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Inconfidentes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1722,
                Nome = "Inconfidentes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Indaiabira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1723,
                Nome = "Indaiabira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Indianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1724,
                Nome = "Indianópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ingaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1725,
                Nome = "Ingaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Inhapim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1726,
                Nome = "Inhapim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Inhaúma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1727,
                Nome = "Inhaúma",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Inimutaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1728,
                Nome = "Inimutaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ipaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1729,
                Nome = "Ipaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ipanema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1730,
                Nome = "Ipanema",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ipatinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1731,
                Nome = "Ipatinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ipiaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1732,
                Nome = "Ipiaçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ipuiúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1733,
                Nome = "Ipuiúna",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Iraí de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1734,
                Nome = "Iraí de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itabira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1735,
                Nome = "Itabira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itabirinha de Mantena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1736,
                Nome = "Itabirinha de Mantena",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itabirito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1737,
                Nome = "Itabirito",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itacambira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1738,
                Nome = "Itacambira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itacarambi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1739,
                Nome = "Itacarambi",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itaguara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1740,
                Nome = "Itaguara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itaipé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1741,
                Nome = "Itaipé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itajubá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1742,
                Nome = "Itajubá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itamarandiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1743,
                Nome = "Itamarandiba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itamarati de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1744,
                Nome = "Itamarati de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itambacuri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1745,
                Nome = "Itambacuri",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itambé do Mato Dentro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1746,
                Nome = "Itambé do Mato Dentro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itamogi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1747,
                Nome = "Itamogi",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itamonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1748,
                Nome = "Itamonte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itanhandu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1749,
                Nome = "Itanhandu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itanhomi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1750,
                Nome = "Itanhomi",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itaobim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1751,
                Nome = "Itaobim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itapagipe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1752,
                Nome = "Itapagipe",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itapecerica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1753,
                Nome = "Itapecerica",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itapeva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1754,
                Nome = "Itapeva",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itatiaiuçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1755,
                Nome = "Itatiaiuçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itaú de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1756,
                Nome = "Itaú de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itaúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1757,
                Nome = "Itaúna",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itaverava
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1758,
                Nome = "Itaverava",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1759,
                Nome = "Itinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itueta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1760,
                Nome = "Itueta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ituiutaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1761,
                Nome = "Ituiutaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itumirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1762,
                Nome = "Itumirim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Iturama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1763,
                Nome = "Iturama",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Itutinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1764,
                Nome = "Itutinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jaboticatubas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1765,
                Nome = "Jaboticatubas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jacinto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1766,
                Nome = "Jacinto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jacuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1767,
                Nome = "Jacuí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jacutinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1768,
                Nome = "Jacutinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jaguaraçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1769,
                Nome = "Jaguaraçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jaíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1770,
                Nome = "Jaíba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jampruca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1771,
                Nome = "Jampruca",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Janaúba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1772,
                Nome = "Janaúba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Januária
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1773,
                Nome = "Januária",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Japaraíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1774,
                Nome = "Japaraíba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Japonvar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1775,
                Nome = "Japonvar",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jeceaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1776,
                Nome = "Jeceaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jenipapo de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1777,
                Nome = "Jenipapo de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jequeri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1778,
                Nome = "Jequeri",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jequitaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1779,
                Nome = "Jequitaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jequitibá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1780,
                Nome = "Jequitibá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jequitinhonha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1781,
                Nome = "Jequitinhonha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jesuânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1782,
                Nome = "Jesuânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Joaíma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1783,
                Nome = "Joaíma",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Joanésia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1784,
                Nome = "Joanésia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: João Monlevade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1785,
                Nome = "João Monlevade",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: João Pinheiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1786,
                Nome = "João Pinheiro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Joaquim Felício
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1787,
                Nome = "Joaquim Felício",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Jordânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1788,
                Nome = "Jordânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: José Gonçalves de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1789,
                Nome = "José Gonçalves de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: José Raydan
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1790,
                Nome = "José Raydan",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Josenópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1791,
                Nome = "Josenópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Juatuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1792,
                Nome = "Juatuba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Juiz de Fora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1793,
                Nome = "Juiz de Fora",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Juramento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1794,
                Nome = "Juramento",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Juruaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1795,
                Nome = "Juruaia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Juvenília
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1796,
                Nome = "Juvenília",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ladainha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1797,
                Nome = "Ladainha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lagamar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1798,
                Nome = "Lagamar",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lagoa da Prata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1799,
                Nome = "Lagoa da Prata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lagoa dos Patos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1800,
                Nome = "Lagoa dos Patos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lagoa Dourada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1801,
                Nome = "Lagoa Dourada",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lagoa Formosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1802,
                Nome = "Lagoa Formosa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lagoa Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1803,
                Nome = "Lagoa Grande",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lagoa Santa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1804,
                Nome = "Lagoa Santa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lajinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1805,
                Nome = "Lajinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lambari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1806,
                Nome = "Lambari",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lamim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1807,
                Nome = "Lamim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Laranjal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1808,
                Nome = "Laranjal",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lassance
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1809,
                Nome = "Lassance",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lavras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1810,
                Nome = "Lavras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Leandro Ferreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1811,
                Nome = "Leandro Ferreira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Leme do Prado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1812,
                Nome = "Leme do Prado",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Leopoldina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1813,
                Nome = "Leopoldina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Liberdade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1814,
                Nome = "Liberdade",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lima Duarte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1815,
                Nome = "Lima Duarte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Limeira do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1816,
                Nome = "Limeira do Oeste",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Lontra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1817,
                Nome = "Lontra",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Luisburgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1818,
                Nome = "Luisburgo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Luislândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1819,
                Nome = "Luislândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Luminárias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1820,
                Nome = "Luminárias",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Luz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1821,
                Nome = "Luz",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Machacalis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1822,
                Nome = "Machacalis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Machado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1823,
                Nome = "Machado",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Madre de Deus de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1824,
                Nome = "Madre de Deus de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Malacacheta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1825,
                Nome = "Malacacheta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mamonas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1826,
                Nome = "Mamonas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Manga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1827,
                Nome = "Manga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Manhuaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1828,
                Nome = "Manhuaçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Manhumirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1829,
                Nome = "Manhumirim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mantena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1830,
                Nome = "Mantena",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mar de Espanha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1831,
                Nome = "Mar de Espanha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Maravilhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1832,
                Nome = "Maravilhas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Maria da Fé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1833,
                Nome = "Maria da Fé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mariana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1834,
                Nome = "Mariana",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Marilac
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1835,
                Nome = "Marilac",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mário Campos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1836,
                Nome = "Mário Campos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Maripá de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1837,
                Nome = "Maripá de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Marliéria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1838,
                Nome = "Marliéria",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Marmelópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1839,
                Nome = "Marmelópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Martinho Campos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1840,
                Nome = "Martinho Campos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Martins Soares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1841,
                Nome = "Martins Soares",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mata Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1842,
                Nome = "Mata Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Materlândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1843,
                Nome = "Materlândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mateus Leme
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1844,
                Nome = "Mateus Leme",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Matias Barbosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1845,
                Nome = "Matias Barbosa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Matias Cardoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1846,
                Nome = "Matias Cardoso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Matias Lobato
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1847,
                Nome = "Matias Lobato",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Matipó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1848,
                Nome = "Matipó",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mato Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1849,
                Nome = "Mato Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Matozinhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1850,
                Nome = "Matozinhos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Matutina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1851,
                Nome = "Matutina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Medeiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1852,
                Nome = "Medeiros",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Medina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1853,
                Nome = "Medina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mendes Pimentel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1854,
                Nome = "Mendes Pimentel",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mercês
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1855,
                Nome = "Mercês",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mesquita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1856,
                Nome = "Mesquita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Minas Novas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1857,
                Nome = "Minas Novas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Minduri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1858,
                Nome = "Minduri",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mirabela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1859,
                Nome = "Mirabela",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Miradouro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1860,
                Nome = "Miradouro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Miraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1861,
                Nome = "Miraí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Miravânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1862,
                Nome = "Miravânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Moeda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1863,
                Nome = "Moeda",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Moema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1864,
                Nome = "Moema",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monjolos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1865,
                Nome = "Monjolos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monsenhor Paulo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1866,
                Nome = "Monsenhor Paulo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Montalvânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1867,
                Nome = "Montalvânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monte Alegre de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1868,
                Nome = "Monte Alegre de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monte Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1869,
                Nome = "Monte Azul",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monte Belo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1870,
                Nome = "Monte Belo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monte Carmelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1871,
                Nome = "Monte Carmelo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monte Formoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1872,
                Nome = "Monte Formoso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monte Santo de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1873,
                Nome = "Monte Santo de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Monte Sião
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1874,
                Nome = "Monte Sião",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Montes Claros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1875,
                Nome = "Montes Claros",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Montezuma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1876,
                Nome = "Montezuma",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Morada Nova de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1877,
                Nome = "Morada Nova de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Morro da Garça
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1878,
                Nome = "Morro da Garça",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Morro do Pilar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1879,
                Nome = "Morro do Pilar",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Munhoz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1880,
                Nome = "Munhoz",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Muriaé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1881,
                Nome = "Muriaé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Mutum
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1882,
                Nome = "Mutum",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Muzambinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1883,
                Nome = "Muzambinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nacip Raydan
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1884,
                Nome = "Nacip Raydan",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nanuque
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1885,
                Nome = "Nanuque",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Naque
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1886,
                Nome = "Naque",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Natalândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1887,
                Nome = "Natalândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Natércia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1888,
                Nome = "Natércia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nazareno
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1889,
                Nome = "Nazareno",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nepomuceno
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1890,
                Nome = "Nepomuceno",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ninheira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1891,
                Nome = "Ninheira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Belém
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1892,
                Nome = "Nova Belém",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Era
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1893,
                Nome = "Nova Era",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Lima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1894,
                Nome = "Nova Lima",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Módica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1895,
                Nome = "Nova Módica",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Ponte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1896,
                Nome = "Nova Ponte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Porteirinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1897,
                Nome = "Nova Porteirinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Resende
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1898,
                Nome = "Nova Resende",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova Serrana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1899,
                Nome = "Nova Serrana",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Nova União
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1900,
                Nome = "Nova União",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Novo Cruzeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1901,
                Nome = "Novo Cruzeiro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Novo Oriente de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1902,
                Nome = "Novo Oriente de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Novorizonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1903,
                Nome = "Novorizonte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Olaria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1904,
                Nome = "Olaria",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Olhos d Água
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1905,
                Nome = "Olhos d Água",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Olímpio Noronha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1906,
                Nome = "Olímpio Noronha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Oliveira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1907,
                Nome = "Oliveira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Oliveira Fortes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1908,
                Nome = "Oliveira Fortes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Onça de Pitangui
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1909,
                Nome = "Onça de Pitangui",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Oratórios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1910,
                Nome = "Oratórios",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Orizânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1911,
                Nome = "Orizânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ouro Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1912,
                Nome = "Ouro Branco",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ouro Fino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1913,
                Nome = "Ouro Fino",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ouro Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1914,
                Nome = "Ouro Preto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ouro Verde de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1915,
                Nome = "Ouro Verde de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Padre Carvalho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1916,
                Nome = "Padre Carvalho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Padre Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1917,
                Nome = "Padre Paraíso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pai Pedro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1918,
                Nome = "Pai Pedro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paineiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1919,
                Nome = "Paineiras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pains
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1920,
                Nome = "Pains",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paiva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1921,
                Nome = "Paiva",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Palma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1922,
                Nome = "Palma",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Palmópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1923,
                Nome = "Palmópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Papagaios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1924,
                Nome = "Papagaios",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pará de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1925,
                Nome = "Pará de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paracatu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1926,
                Nome = "Paracatu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paraguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1927,
                Nome = "Paraguaçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paraisópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1928,
                Nome = "Paraisópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paraopeba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1929,
                Nome = "Paraopeba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Passa Tempo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1930,
                Nome = "Passa Tempo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Passabém
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1931,
                Nome = "Passabém",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Passa Quatro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1932,
                Nome = "Passa Quatro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Passa Vinte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1933,
                Nome = "Passa Vinte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Passos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1934,
                Nome = "Passos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Patis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1935,
                Nome = "Patis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Patos de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1936,
                Nome = "Patos de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Patrocínio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1937,
                Nome = "Patrocínio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Patrocínio do Muriaé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1938,
                Nome = "Patrocínio do Muriaé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paula Cândido
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1939,
                Nome = "Paula Cândido",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Paulistas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1940,
                Nome = "Paulistas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pavão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1941,
                Nome = "Pavão",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Peçanha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1942,
                Nome = "Peçanha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedra Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1943,
                Nome = "Pedra Azul",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedra Bonita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1944,
                Nome = "Pedra Bonita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedra do Anta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1945,
                Nome = "Pedra do Anta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedra do Indaiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1946,
                Nome = "Pedra do Indaiá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedra Dourada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1947,
                Nome = "Pedra Dourada",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedralva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1948,
                Nome = "Pedralva",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedras de Maria da Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1949,
                Nome = "Pedras de Maria da Cruz",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedrinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1950,
                Nome = "Pedrinópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedro Leopoldo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1951,
                Nome = "Pedro Leopoldo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pedro Teixeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1952,
                Nome = "Pedro Teixeira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pequeri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1953,
                Nome = "Pequeri",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pequi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1954,
                Nome = "Pequi",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Perdigão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1955,
                Nome = "Perdigão",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Perdizes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1956,
                Nome = "Perdizes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Perdões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1957,
                Nome = "Perdões",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Periquito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1958,
                Nome = "Periquito",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pescador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1959,
                Nome = "Pescador",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piau
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1960,
                Nome = "Piau",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piedade de Caratinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1961,
                Nome = "Piedade de Caratinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piedade de Ponte Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1962,
                Nome = "Piedade de Ponte Nova",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piedade do Rio Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1963,
                Nome = "Piedade do Rio Grande",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piedade dos Gerais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1964,
                Nome = "Piedade dos Gerais",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pimenta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1965,
                Nome = "Pimenta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pingo d Água
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1966,
                Nome = "Pingo d Água",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pintópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1967,
                Nome = "Pintópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piracema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1968,
                Nome = "Piracema",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pirajuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1969,
                Nome = "Pirajuba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piranga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1970,
                Nome = "Piranga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piranguçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1971,
                Nome = "Piranguçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piranguinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1972,
                Nome = "Piranguinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pirapetinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1973,
                Nome = "Pirapetinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pirapora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1974,
                Nome = "Pirapora",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piraúba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1975,
                Nome = "Piraúba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pitangui
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1976,
                Nome = "Pitangui",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Piumhi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1977,
                Nome = "Piumhi",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Planura
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1978,
                Nome = "Planura",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Poço Fundo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1979,
                Nome = "Poço Fundo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Poços de Caldas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1980,
                Nome = "Poços de Caldas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pocrane
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1981,
                Nome = "Pocrane",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pompéu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1982,
                Nome = "Pompéu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ponte Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1983,
                Nome = "Ponte Nova",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ponto Chique
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1984,
                Nome = "Ponto Chique",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ponto dos Volantes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1985,
                Nome = "Ponto dos Volantes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Porteirinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1986,
                Nome = "Porteirinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Porto Firme
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1987,
                Nome = "Porto Firme",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Poté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1988,
                Nome = "Poté",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pouso Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1989,
                Nome = "Pouso Alegre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pouso Alto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1990,
                Nome = "Pouso Alto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Prados
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1991,
                Nome = "Prados",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Prata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1992,
                Nome = "Prata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pratápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1993,
                Nome = "Pratápolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Pratinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1994,
                Nome = "Pratinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Presidente Bernardes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1995,
                Nome = "Presidente Bernardes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Presidente Juscelino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1996,
                Nome = "Presidente Juscelino",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Presidente Kubitschek
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1997,
                Nome = "Presidente Kubitschek",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Presidente Olegário
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1998,
                Nome = "Presidente Olegário",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Prudente de Morais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1999,
                Nome = "Prudente de Morais",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Quartel Geral
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2000,
                Nome = "Quartel Geral",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Queluzito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2001,
                Nome = "Queluzito",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Raposos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2002,
                Nome = "Raposos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Raul Soares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2003,
                Nome = "Raul Soares",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Recreio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2004,
                Nome = "Recreio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Reduto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2005,
                Nome = "Reduto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Resende Costa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2006,
                Nome = "Resende Costa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Resplendor
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2007,
                Nome = "Resplendor",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ressaquinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2008,
                Nome = "Ressaquinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Riachinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2009,
                Nome = "Riachinho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Riacho dos Machados
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2010,
                Nome = "Riacho dos Machados",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ribeirão das Neves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2011,
                Nome = "Ribeirão das Neves",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ribeirão Vermelho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2012,
                Nome = "Ribeirão Vermelho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Acima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2013,
                Nome = "Rio Acima",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Casca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2014,
                Nome = "Rio Casca",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio do Prado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2015,
                Nome = "Rio do Prado",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Doce
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2016,
                Nome = "Rio Doce",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Espera
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2017,
                Nome = "Rio Espera",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Manso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2018,
                Nome = "Rio Manso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2019,
                Nome = "Rio Novo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Paranaíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2020,
                Nome = "Rio Paranaíba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Pardo de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2021,
                Nome = "Rio Pardo de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Piracicaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2022,
                Nome = "Rio Piracicaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Pomba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2023,
                Nome = "Rio Pomba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2024,
                Nome = "Rio Preto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rio Vermelho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2025,
                Nome = "Rio Vermelho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ritápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2026,
                Nome = "Ritápolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rochedo de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2027,
                Nome = "Rochedo de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rodeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2028,
                Nome = "Rodeiro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Romaria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2029,
                Nome = "Romaria",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rosário da Limeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2030,
                Nome = "Rosário da Limeira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rubelita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2031,
                Nome = "Rubelita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Rubim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2032,
                Nome = "Rubim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sabará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2033,
                Nome = "Sabará",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sabinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2034,
                Nome = "Sabinópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sacramento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2035,
                Nome = "Sacramento",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Salinas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2036,
                Nome = "Salinas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Salto da Divisa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2037,
                Nome = "Salto da Divisa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Bárbara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2038,
                Nome = "Santa Bárbara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Bárbara do Leste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2039,
                Nome = "Santa Bárbara do Leste",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Bárbara do Monte Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2040,
                Nome = "Santa Bárbara do Monte Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Bárbara do Tugúrio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2041,
                Nome = "Santa Bárbara do Tugúrio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Cruz de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2042,
                Nome = "Santa Cruz de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Cruz de Salinas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2043,
                Nome = "Santa Cruz de Salinas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Cruz do Escalvado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2044,
                Nome = "Santa Cruz do Escalvado",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Efigênia de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2045,
                Nome = "Santa Efigênia de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Fé de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2046,
                Nome = "Santa Fé de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Helena de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2047,
                Nome = "Santa Helena de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Juliana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2048,
                Nome = "Santa Juliana",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Luzia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2049,
                Nome = "Santa Luzia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Margarida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2050,
                Nome = "Santa Margarida",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Maria de Itabira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2051,
                Nome = "Santa Maria de Itabira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Maria do Salto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2052,
                Nome = "Santa Maria do Salto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Maria do Suaçuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2053,
                Nome = "Santa Maria do Suaçuí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Rita de Caldas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2054,
                Nome = "Santa Rita de Caldas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Rita de Ibitipoca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2055,
                Nome = "Santa Rita de Ibitipoca",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Rita de Jacutinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2056,
                Nome = "Santa Rita de Jacutinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Rita de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2057,
                Nome = "Santa Rita de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Rita do Itueto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2058,
                Nome = "Santa Rita do Itueto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Rita do Sapucaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2059,
                Nome = "Santa Rita do Sapucaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Rosa da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2060,
                Nome = "Santa Rosa da Serra",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santa Vitória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2061,
                Nome = "Santa Vitória",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana da Vargem
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2062,
                Nome = "Santana da Vargem",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana de Cataguases
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2063,
                Nome = "Santana de Cataguases",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana de Pirapama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2064,
                Nome = "Santana de Pirapama",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana do Deserto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2065,
                Nome = "Santana do Deserto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana do Garambéu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2066,
                Nome = "Santana do Garambéu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana do Jacaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2067,
                Nome = "Santana do Jacaré",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana do Manhuaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2068,
                Nome = "Santana do Manhuaçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana do Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2069,
                Nome = "Santana do Paraíso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana do Riacho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2070,
                Nome = "Santana do Riacho",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santana dos Montes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2071,
                Nome = "Santana dos Montes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Amparo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2072,
                Nome = "Santo Antônio do Amparo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Aventureiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2073,
                Nome = "Santo Antônio do Aventureiro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Grama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2074,
                Nome = "Santo Antônio do Grama",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Itambé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2075,
                Nome = "Santo Antônio do Itambé",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Jacinto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2076,
                Nome = "Santo Antônio do Jacinto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Monte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2077,
                Nome = "Santo Antônio do Monte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Retiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2078,
                Nome = "Santo Antônio do Retiro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Antônio do Rio Abaixo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2079,
                Nome = "Santo Antônio do Rio Abaixo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santo Hipólito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2080,
                Nome = "Santo Hipólito",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Santos Dumont
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2081,
                Nome = "Santos Dumont",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Bento Abade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2082,
                Nome = "São Bento Abade",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Brás do Suaçuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2083,
                Nome = "São Brás do Suaçuí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Domingos das Dores
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2084,
                Nome = "São Domingos das Dores",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Domingos do Prata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2085,
                Nome = "São Domingos do Prata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Félix de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2086,
                Nome = "São Félix de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Francisco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2087,
                Nome = "São Francisco",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Francisco de Paula
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2088,
                Nome = "São Francisco de Paula",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Francisco de Sales
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2089,
                Nome = "São Francisco de Sales",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Francisco do Glória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2090,
                Nome = "São Francisco do Glória",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Geraldo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2091,
                Nome = "São Geraldo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Geraldo da Piedade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2092,
                Nome = "São Geraldo da Piedade",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Geraldo do Baixio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2093,
                Nome = "São Geraldo do Baixio",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Gonçalo do Abaeté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2094,
                Nome = "São Gonçalo do Abaeté",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Gonçalo do Pará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2095,
                Nome = "São Gonçalo do Pará",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Gonçalo do Rio Abaixo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2096,
                Nome = "São Gonçalo do Rio Abaixo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Gonçalo do Rio Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2097,
                Nome = "São Gonçalo do Rio Preto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Gonçalo do Sapucaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2098,
                Nome = "São Gonçalo do Sapucaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Gotardo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2099,
                Nome = "São Gotardo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João Batista do Glória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2100,
                Nome = "São João Batista do Glória",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João da Lagoa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2101,
                Nome = "São João da Lagoa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João da Mata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2102,
                Nome = "São João da Mata",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João da Ponte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2103,
                Nome = "São João da Ponte",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2104,
                Nome = "São João das Missões",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João del Rei
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2105,
                Nome = "São João del Rei",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João do Manhuaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2106,
                Nome = "São João do Manhuaçu",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João do Manteninha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2107,
                Nome = "São João do Manteninha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João do Oriente
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2108,
                Nome = "São João do Oriente",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João do Pacuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2109,
                Nome = "São João do Pacuí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João do Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2110,
                Nome = "São João do Paraíso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João Evangelista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2111,
                Nome = "São João Evangelista",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São João Nepomuceno
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2112,
                Nome = "São João Nepomuceno",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Joaquim de Bicas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2113,
                Nome = "São Joaquim de Bicas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José da Barra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2114,
                Nome = "São José da Barra",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José da Lapa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2115,
                Nome = "São José da Lapa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José da Safira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2116,
                Nome = "São José da Safira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José da Varginha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2117,
                Nome = "São José da Varginha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José do Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2118,
                Nome = "São José do Alegre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José do Divino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2119,
                Nome = "São José do Divino",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José do Goiabal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2120,
                Nome = "São José do Goiabal",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José do Jacuri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2121,
                Nome = "São José do Jacuri",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São José do Mantimento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2122,
                Nome = "São José do Mantimento",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Lourenço
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2123,
                Nome = "São Lourenço",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Miguel do Anta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2124,
                Nome = "São Miguel do Anta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Pedro da União
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2125,
                Nome = "São Pedro da União",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Pedro do Suaçuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2126,
                Nome = "São Pedro do Suaçuí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Pedro dos Ferros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2127,
                Nome = "São Pedro dos Ferros",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Romão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2128,
                Nome = "São Romão",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Roque de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2129,
                Nome = "São Roque de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião da Bela Vista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2130,
                Nome = "São Sebastião da Bela Vista",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião da Vargem Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2131,
                Nome = "São Sebastião da Vargem Alegre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião do Anta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2132,
                Nome = "São Sebastião do Anta",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião do Maranhão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2133,
                Nome = "São Sebastião do Maranhão",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2134,
                Nome = "São Sebastião do Oeste",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião do Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2135,
                Nome = "São Sebastião do Paraíso",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião do Rio Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2136,
                Nome = "São Sebastião do Rio Preto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Sebastião do Rio Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2137,
                Nome = "São Sebastião do Rio Verde",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Tiago
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2138,
                Nome = "São Tiago",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Tomás de Aquino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2139,
                Nome = "São Tomás de Aquino",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Tomé das Letras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2140,
                Nome = "São Tomé das Letras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: São Vicente de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2141,
                Nome = "São Vicente de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sapucaí Mirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2142,
                Nome = "Sapucaí Mirim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sardoá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2143,
                Nome = "Sardoá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sarzedo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2144,
                Nome = "Sarzedo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sem Peixe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2145,
                Nome = "Sem Peixe",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senador Amaral
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2146,
                Nome = "Senador Amaral",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senador Cortes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2147,
                Nome = "Senador Cortes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senador Firmino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2148,
                Nome = "Senador Firmino",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senador José Bento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2149,
                Nome = "Senador José Bento",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senador Modestino Gonçalves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2150,
                Nome = "Senador Modestino Gonçalves",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senhora de Oliveira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2151,
                Nome = "Senhora de Oliveira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senhora do Porto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2152,
                Nome = "Senhora do Porto",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Senhora dos Remédios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2153,
                Nome = "Senhora dos Remédios",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sericita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2154,
                Nome = "Sericita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Seritinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2155,
                Nome = "Seritinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serra Azul de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2156,
                Nome = "Serra Azul de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serra da Saudade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2157,
                Nome = "Serra da Saudade",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serra do Salitre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2158,
                Nome = "Serra do Salitre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serra dos Aimorés
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2159,
                Nome = "Serra dos Aimorés",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serrania
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2160,
                Nome = "Serrania",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serranópolis de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2161,
                Nome = "Serranópolis de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serranos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2162,
                Nome = "Serranos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Serro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2163,
                Nome = "Serro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sete Lagoas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2164,
                Nome = "Sete Lagoas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Setubinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2165,
                Nome = "Setubinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Silveirânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2166,
                Nome = "Silveirânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Silvianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2167,
                Nome = "Silvianópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Simão Pereira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2168,
                Nome = "Simão Pereira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Simonésia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2169,
                Nome = "Simonésia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Sobrália
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2170,
                Nome = "Sobrália",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Soledade de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2171,
                Nome = "Soledade de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tabuleiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2172,
                Nome = "Tabuleiro",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Taiobeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2173,
                Nome = "Taiobeiras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Taparuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2174,
                Nome = "Taparuba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tapira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2175,
                Nome = "Tapira",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tapiraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2176,
                Nome = "Tapiraí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Taquaraçu de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2177,
                Nome = "Taquaraçu de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tarumirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2178,
                Nome = "Tarumirim",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Teixeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2179,
                Nome = "Teixeiras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Teófilo Otoni
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2180,
                Nome = "Teófilo Otoni",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Timóteo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2181,
                Nome = "Timóteo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tiradentes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2182,
                Nome = "Tiradentes",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2183,
                Nome = "Tiros",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tocantins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2184,
                Nome = "Tocantins",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tocos do Moji
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2185,
                Nome = "Tocos do Moji",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Toledo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2186,
                Nome = "Toledo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tombos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2187,
                Nome = "Tombos",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Três Corações
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2188,
                Nome = "Três Corações",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Três Marias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2189,
                Nome = "Três Marias",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Três Pontas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2190,
                Nome = "Três Pontas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tumiritinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2191,
                Nome = "Tumiritinga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Tupaciguara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2192,
                Nome = "Tupaciguara",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Turmalina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2193,
                Nome = "Turmalina",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Turvolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2194,
                Nome = "Turvolândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ubá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2195,
                Nome = "Ubá",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ubaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2196,
                Nome = "Ubaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Ubaporanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2197,
                Nome = "Ubaporanga",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Uberaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2198,
                Nome = "Uberaba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Uberlândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2199,
                Nome = "Uberlândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Umburatiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2200,
                Nome = "Umburatiba",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Unaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2201,
                Nome = "Unaí",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: União de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2202,
                Nome = "União de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Uruana de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2203,
                Nome = "Uruana de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Urucânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2204,
                Nome = "Urucânia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Urucuia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2205,
                Nome = "Urucuia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Vargem Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2206,
                Nome = "Vargem Alegre",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Vargem Bonita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2207,
                Nome = "Vargem Bonita",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Vargem Grande do Rio Pardo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2208,
                Nome = "Vargem Grande do Rio Pardo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Varginha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2209,
                Nome = "Varginha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Varjão de Minas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2210,
                Nome = "Varjão de Minas",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Várzea da Palma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2211,
                Nome = "Várzea da Palma",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Varzelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2212,
                Nome = "Varzelândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Vazante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2213,
                Nome = "Vazante",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Verdelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2214,
                Nome = "Verdelândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Veredinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2215,
                Nome = "Veredinha",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Veríssimo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2216,
                Nome = "Veríssimo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Vermelho Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2217,
                Nome = "Vermelho Novo",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Vespasiano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2218,
                Nome = "Vespasiano",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Viçosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2219,
                Nome = "Viçosa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Vieiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2220,
                Nome = "Vieiras",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Virgem da Lapa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2221,
                Nome = "Virgem da Lapa",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Virgínia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2222,
                Nome = "Virgínia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Virginópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2223,
                Nome = "Virginópolis",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Virgolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2224,
                Nome = "Virgolândia",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Visconde do Rio Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2225,
                Nome = "Visconde do Rio Branco",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Volta Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2226,
                Nome = "Volta Grande",
                Situacao = "Ativo",
                UF = "MG"
            });

            // cidade: Wenceslau Braz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2227,
                Nome = "Wenceslau Braz",
                Situacao = "Ativo",
                UF = "MG"
            });


            await _context.SaveChangesAsync();
        }
    }
}
