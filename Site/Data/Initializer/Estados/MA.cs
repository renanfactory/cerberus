using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class MA
    {
        private readonly ApplicationDbContext _context;

        public MA(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: MA
            //----------------------------------------------------

            // cidade: Açailândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1157,
                Nome = "Açailândia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Afonso Cunha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1158,
                Nome = "Afonso Cunha",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Água Doce do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1159,
                Nome = "Água Doce do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Alcântara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1160,
                Nome = "Alcântara",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Aldeias Altas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1161,
                Nome = "Aldeias Altas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Altamira do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1162,
                Nome = "Altamira do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Alto Alegre do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1163,
                Nome = "Alto Alegre do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Alto Alegre do Pindaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1164,
                Nome = "Alto Alegre do Pindaré",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Alto Parnaíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1165,
                Nome = "Alto Parnaíba",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Amapá do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1166,
                Nome = "Amapá do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Amarante do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1167,
                Nome = "Amarante do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Anajatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1168,
                Nome = "Anajatuba",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Anapurus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1169,
                Nome = "Anapurus",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Apicum Açu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1170,
                Nome = "Apicum Açu",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Araguanã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1171,
                Nome = "Araguanã",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Araioses
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1172,
                Nome = "Araioses",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Arame
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1173,
                Nome = "Arame",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Arari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1174,
                Nome = "Arari",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Axixá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1175,
                Nome = "Axixá",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bacabal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1176,
                Nome = "Bacabal",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bacabeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1177,
                Nome = "Bacabeira",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bacuri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1178,
                Nome = "Bacuri",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bacurituba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1179,
                Nome = "Bacurituba",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Balsas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1180,
                Nome = "Balsas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Barão de Grajaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1181,
                Nome = "Barão de Grajaú",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Barra do Corda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1182,
                Nome = "Barra do Corda",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Barreirinhas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1183,
                Nome = "Barreirinhas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bela Vista do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1184,
                Nome = "Bela Vista do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Belágua
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1185,
                Nome = "Belágua",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Benedito Leite
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1186,
                Nome = "Benedito Leite",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bequimão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1187,
                Nome = "Bequimão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bernardo do Mearim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1188,
                Nome = "Bernardo do Mearim",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Boa Vista do Gurupi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1189,
                Nome = "Boa Vista do Gurupi",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bom Jardim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1190,
                Nome = "Bom Jardim",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bom Jesus das Selvas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1191,
                Nome = "Bom Jesus das Selvas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Bom Lugar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1192,
                Nome = "Bom Lugar",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Brejo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1193,
                Nome = "Brejo",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Brejo de Areia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1194,
                Nome = "Brejo de Areia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Buriti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1195,
                Nome = "Buriti",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Buriti Bravo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1196,
                Nome = "Buriti Bravo",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Buriticupu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1197,
                Nome = "Buriticupu",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Buritirana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1198,
                Nome = "Buritirana",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cachoeira Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1199,
                Nome = "Cachoeira Grande",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cajapió
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1200,
                Nome = "Cajapió",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cajari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1201,
                Nome = "Cajari",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Campestre do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1202,
                Nome = "Campestre do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cândido Mendes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1203,
                Nome = "Cândido Mendes",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cantanhede
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1204,
                Nome = "Cantanhede",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Capinzal do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1205,
                Nome = "Capinzal do Norte",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Carolina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1206,
                Nome = "Carolina",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Carutapera
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1207,
                Nome = "Carutapera",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Caxias
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1208,
                Nome = "Caxias",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cedral
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1209,
                Nome = "Cedral",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Central do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1210,
                Nome = "Central do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Centro do Guilherme
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1211,
                Nome = "Centro do Guilherme",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Centro Novo do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1212,
                Nome = "Centro Novo do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Chapadinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1213,
                Nome = "Chapadinha",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cidelândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1214,
                Nome = "Cidelândia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Codó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1215,
                Nome = "Codó",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Coelho Neto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1216,
                Nome = "Coelho Neto",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Colinas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1217,
                Nome = "Colinas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Conceição do Lago Açu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1218,
                Nome = "Conceição do Lago Açu",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Coroatá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1219,
                Nome = "Coroatá",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Cururupu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1220,
                Nome = "Cururupu",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Davinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1221,
                Nome = "Davinópolis",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Dom Pedro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1222,
                Nome = "Dom Pedro",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Duque Bacelar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1223,
                Nome = "Duque Bacelar",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Esperantinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1224,
                Nome = "Esperantinópolis",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Estreito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1225,
                Nome = "Estreito",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Feira Nova do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1226,
                Nome = "Feira Nova do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Fernando Falcão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1227,
                Nome = "Fernando Falcão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Formosa da Serra Negra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1228,
                Nome = "Formosa da Serra Negra",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Fortaleza dos Nogueiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1229,
                Nome = "Fortaleza dos Nogueiras",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Fortuna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1230,
                Nome = "Fortuna",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Godofredo Viana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1231,
                Nome = "Godofredo Viana",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Goiás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1232,
                Nome = "Goiás",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Gonçalves Dias
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1233,
                Nome = "Gonçalves Dias",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Governador Archer
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1234,
                Nome = "Governador Archer",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Governador Edison Lobão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1235,
                Nome = "Governador Edison Lobão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Governador Eugênio Barros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1236,
                Nome = "Governador Eugênio Barros",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Governador Luiz Rocha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1237,
                Nome = "Governador Luiz Rocha",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Governador Newton Bello
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1238,
                Nome = "Governador Newton Bello",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Governador Nunes Freire
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1239,
                Nome = "Governador Nunes Freire",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Graça Aranha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1240,
                Nome = "Graça Aranha",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Grajaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1241,
                Nome = "Grajaú",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Guimarães
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1242,
                Nome = "Guimarães",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Humberto de Campos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1243,
                Nome = "Humberto de Campos",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Icatu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1244,
                Nome = "Icatu",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Igarapé do Meio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1245,
                Nome = "Igarapé do Meio",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Igarapé Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1246,
                Nome = "Igarapé Grande",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Imperatriz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1247,
                Nome = "Imperatriz",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Itaipava do Grajaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1248,
                Nome = "Itaipava do Grajaú",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Itapecuru Mirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1249,
                Nome = "Itapecuru Mirim",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Itinga do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1250,
                Nome = "Itinga do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Jatobá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1251,
                Nome = "Jatobá",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Jenipapo dos Vieiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1252,
                Nome = "Jenipapo dos Vieiras",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: João Lisboa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1253,
                Nome = "João Lisboa",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Joselândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1254,
                Nome = "Joselândia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Junco do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1255,
                Nome = "Junco do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lago da Pedra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1256,
                Nome = "Lago da Pedra",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lago do Junco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1257,
                Nome = "Lago do Junco",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lago dos Rodrigues
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1258,
                Nome = "Lago dos Rodrigues",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lago Verde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1259,
                Nome = "Lago Verde",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lagoa do Mato
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1260,
                Nome = "Lagoa do Mato",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lagoa Grande do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1261,
                Nome = "Lagoa Grande do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lajeado Novo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1262,
                Nome = "Lajeado Novo",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Lima Campos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1263,
                Nome = "Lima Campos",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Loreto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1264,
                Nome = "Loreto",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Luís Domingues
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1265,
                Nome = "Luís Domingues",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Magalhães de Almeida
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1266,
                Nome = "Magalhães de Almeida",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Maracaçumé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1267,
                Nome = "Maracaçumé",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Marajá do Sena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1268,
                Nome = "Marajá do Sena",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Maranhãozinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1269,
                Nome = "Maranhãozinho",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Mata Roma
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1270,
                Nome = "Mata Roma",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Matinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1271,
                Nome = "Matinha",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Matões
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1272,
                Nome = "Matões",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Matões do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1273,
                Nome = "Matões do Norte",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Milagres do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1274,
                Nome = "Milagres do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Mirador
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1275,
                Nome = "Mirador",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Miranda do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1276,
                Nome = "Miranda do Norte",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Mirinzal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1277,
                Nome = "Mirinzal",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Monção
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1278,
                Nome = "Monção",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Montes Altos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1279,
                Nome = "Montes Altos",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Morros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1280,
                Nome = "Morros",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Nina Rodrigues
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1281,
                Nome = "Nina Rodrigues",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Nova Colinas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1282,
                Nome = "Nova Colinas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Nova Iorque
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1283,
                Nome = "Nova Iorque",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Nova Olinda do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1284,
                Nome = "Nova Olinda do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Olho d Água das Cunhãs
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1285,
                Nome = "Olho d Água das Cunhãs",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Olinda Nova do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1286,
                Nome = "Olinda Nova do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Paço do Lumiar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1287,
                Nome = "Paço do Lumiar",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Palmeirândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1288,
                Nome = "Palmeirândia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Paraibano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1289,
                Nome = "Paraibano",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Parnarama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1290,
                Nome = "Parnarama",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Passagem Franca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1291,
                Nome = "Passagem Franca",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Pastos Bons
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1292,
                Nome = "Pastos Bons",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Paulino Neves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1293,
                Nome = "Paulino Neves",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Paulo Ramos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1294,
                Nome = "Paulo Ramos",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Pedreiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1295,
                Nome = "Pedreiras",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Pedro do Rosário
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1296,
                Nome = "Pedro do Rosário",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Penalva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1297,
                Nome = "Penalva",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Peri Mirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1298,
                Nome = "Peri Mirim",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Peritoró
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1299,
                Nome = "Peritoró",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Pindaré Mirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1300,
                Nome = "Pindaré Mirim",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Pinheiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1301,
                Nome = "Pinheiro",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Pio XII
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1302,
                Nome = "Pio XII",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Pirapemas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1303,
                Nome = "Pirapemas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Poção de Pedras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1304,
                Nome = "Poção de Pedras",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Porto Franco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1305,
                Nome = "Porto Franco",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Porto Rico do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1306,
                Nome = "Porto Rico do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Presidente Dutra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1307,
                Nome = "Presidente Dutra",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Presidente Juscelino
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1308,
                Nome = "Presidente Juscelino",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Presidente Médici
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1309,
                Nome = "Presidente Médici",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Presidente Sarney
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1310,
                Nome = "Presidente Sarney",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Presidente Vargas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1311,
                Nome = "Presidente Vargas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Primeira Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1312,
                Nome = "Primeira Cruz",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Raposa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1313,
                Nome = "Raposa",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Riachão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1314,
                Nome = "Riachão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Ribamar Fiquene
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1315,
                Nome = "Ribamar Fiquene",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Rosário
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1316,
                Nome = "Rosário",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Sambaíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1317,
                Nome = "Sambaíba",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santa Filomena do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1318,
                Nome = "Santa Filomena do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santa Helena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1319,
                Nome = "Santa Helena",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santa Inês
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1320,
                Nome = "Santa Inês",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santa Luzia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1321,
                Nome = "Santa Luzia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santa Luzia do Paruá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1322,
                Nome = "Santa Luzia do Paruá",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santa Quitéria do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1323,
                Nome = "Santa Quitéria do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santa Rita
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1324,
                Nome = "Santa Rita",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santana do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1325,
                Nome = "Santana do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santo Amaro do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1326,
                Nome = "Santo Amaro do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Santo Antônio dos Lopes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1327,
                Nome = "Santo Antônio dos Lopes",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Benedito do Rio Preto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1328,
                Nome = "São Benedito do Rio Preto",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Bento
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1329,
                Nome = "São Bento",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Bernardo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1330,
                Nome = "São Bernardo",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Domingos do Azeitão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1331,
                Nome = "São Domingos do Azeitão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Domingos do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1332,
                Nome = "São Domingos do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Félix de Balsas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1333,
                Nome = "São Félix de Balsas",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Francisco do Brejão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1334,
                Nome = "São Francisco do Brejão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Francisco do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1335,
                Nome = "São Francisco do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São João Batista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1336,
                Nome = "São João Batista",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São João do Caru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1337,
                Nome = "São João do Caru",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São João do Paraíso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1338,
                Nome = "São João do Paraíso",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São João do Soter
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1339,
                Nome = "São João do Soter",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São João dos Patos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1340,
                Nome = "São João dos Patos",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São José de Ribamar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1341,
                Nome = "São José de Ribamar",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São José dos Basílios
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1342,
                Nome = "São José dos Basílios",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Luís
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1343,
                Nome = "São Luís",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Luís Gonzaga do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1344,
                Nome = "São Luís Gonzaga do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Mateus do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1345,
                Nome = "São Mateus do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Pedro da Água Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1346,
                Nome = "São Pedro da Água Branca",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Pedro dos Crentes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1347,
                Nome = "São Pedro dos Crentes",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Raimundo das Mangabeiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1348,
                Nome = "São Raimundo das Mangabeiras",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Raimundo do Doca Bezerra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1349,
                Nome = "São Raimundo do Doca Bezerra",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Roberto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1350,
                Nome = "São Roberto",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: São Vicente Ferrer
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1351,
                Nome = "São Vicente Ferrer",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Satubinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1352,
                Nome = "Satubinha",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Senador Alexandre Costa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1353,
                Nome = "Senador Alexandre Costa",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Senador La Rocque
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1354,
                Nome = "Senador La Rocque",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Serrano do Maranhão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1355,
                Nome = "Serrano do Maranhão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Sítio Novo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1356,
                Nome = "Sítio Novo",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Sucupira do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1357,
                Nome = "Sucupira do Norte",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Sucupira do Riachão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1358,
                Nome = "Sucupira do Riachão",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Tasso Fragoso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1359,
                Nome = "Tasso Fragoso",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Timbiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1360,
                Nome = "Timbiras",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Timon
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1361,
                Nome = "Timon",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Trizidela do Vale
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1362,
                Nome = "Trizidela do Vale",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Tufilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1363,
                Nome = "Tufilândia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Tuntum
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1364,
                Nome = "Tuntum",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Turiaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1365,
                Nome = "Turiaçu",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Turilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1366,
                Nome = "Turilândia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Tutóia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1367,
                Nome = "Tutóia",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Urbano Santos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1368,
                Nome = "Urbano Santos",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Vargem Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1369,
                Nome = "Vargem Grande",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Viana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1370,
                Nome = "Viana",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Vila Nova dos Martírios
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1371,
                Nome = "Vila Nova dos Martírios",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Vitória do Mearim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1372,
                Nome = "Vitória do Mearim",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Vitorino Freire
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1373,
                Nome = "Vitorino Freire",
                Situacao = "Ativo",
                UF = "MA"
            });

            // cidade: Zé Doca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 1374,
                Nome = "Zé Doca",
                Situacao = "Ativo",
                UF = "MA"
            });


            await _context.SaveChangesAsync();
        }
    }
}
