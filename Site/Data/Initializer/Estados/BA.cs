using System;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class BA
    {
        private readonly ApplicationDbContext _context;

        public BA(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: BA
            //----------------------------------------------------

            // cidade: Abaíra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 203,
                Nome = "Abaíra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Abaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 204,
                Nome = "Abaré",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Acajutiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 205,
                Nome = "Acajutiba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Adustina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 206,
                Nome = "Adustina",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Água Fria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 207,
                Nome = "Água Fria",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Aiquara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 208,
                Nome = "Aiquara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Alagoinhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 209,
                Nome = "Alagoinhas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Alcobaça
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 210,
                Nome = "Alcobaça",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Almadina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 211,
                Nome = "Almadina",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Amargosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 212,
                Nome = "Amargosa",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Amélia Rodrigues
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 213,
                Nome = "Amélia Rodrigues",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: América Dourada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 214,
                Nome = "América Dourada",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Anagé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 215,
                Nome = "Anagé",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Andaraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 216,
                Nome = "Andaraí",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Andorinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 217,
                Nome = "Andorinha",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Angical
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 218,
                Nome = "Angical",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Anguera
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 219,
                Nome = "Anguera",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Antas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 220,
                Nome = "Antas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Antônio Cardoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 221,
                Nome = "Antônio Cardoso",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Antônio Gonçalves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 222,
                Nome = "Antônio Gonçalves",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Aporá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 223,
                Nome = "Aporá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Apuarema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 224,
                Nome = "Apuarema",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Araças
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 225,
                Nome = "Araças",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Aracatu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 226,
                Nome = "Aracatu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Araci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 227,
                Nome = "Araci",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Aramari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 228,
                Nome = "Aramari",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Arataca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 229,
                Nome = "Arataca",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Aratuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 230,
                Nome = "Aratuípe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Aurelino Leal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 231,
                Nome = "Aurelino Leal",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Baianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 232,
                Nome = "Baianópolis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Baixa Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 233,
                Nome = "Baixa Grande",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Banzaê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 234,
                Nome = "Banzaê",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 235,
                Nome = "Barra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barra da Estiva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 236,
                Nome = "Barra da Estiva",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barra do Choça
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 237,
                Nome = "Barra do Choça",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barra do Mendes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 238,
                Nome = "Barra do Mendes",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barra do Rocha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 239,
                Nome = "Barra do Rocha",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barreiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 240,
                Nome = "Barreiras",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barro Alto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 241,
                Nome = "Barro Alto",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Barrocas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 242,
                Nome = "Barrocas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Belmonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 243,
                Nome = "Belmonte",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Belo Campo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 244,
                Nome = "Belo Campo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Biritinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 245,
                Nome = "Biritinga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Boa Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 246,
                Nome = "Boa Nova",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Boa Vista do Tupim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 247,
                Nome = "Boa Vista do Tupim",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Bom Jesus da Lapa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 248,
                Nome = "Bom Jesus da Lapa",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Bom Jesus da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 249,
                Nome = "Bom Jesus da Serra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Boninal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 250,
                Nome = "Boninal",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Bonito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 251,
                Nome = "Bonito",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Boquira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 252,
                Nome = "Boquira",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Botuporã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 253,
                Nome = "Botuporã",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Brejões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 254,
                Nome = "Brejões",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Brejolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 255,
                Nome = "Brejolândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Brotas de Macaúbas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 256,
                Nome = "Brotas de Macaúbas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Brumado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 257,
                Nome = "Brumado",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Buerarema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 258,
                Nome = "Buerarema",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Buritirama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 259,
                Nome = "Buritirama",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caatiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 260,
                Nome = "Caatiba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cabaceiras do Paraguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 261,
                Nome = "Cabaceiras do Paraguaçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cachoeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 262,
                Nome = "Cachoeira",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caculé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 263,
                Nome = "Caculé",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caém
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 264,
                Nome = "Caém",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caetanos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 265,
                Nome = "Caetanos",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caetité
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 266,
                Nome = "Caetité",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cafarnaum
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 267,
                Nome = "Cafarnaum",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cairu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 268,
                Nome = "Cairu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caldeirão Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 269,
                Nome = "Caldeirão Grande",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Camacan
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 270,
                Nome = "Camacan",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Camaçari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 271,
                Nome = "Camaçari",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Camamu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 272,
                Nome = "Camamu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Campo Alegre de Lourdes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 273,
                Nome = "Campo Alegre de Lourdes",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Campo Formoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 274,
                Nome = "Campo Formoso",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Canápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 275,
                Nome = "Canápolis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Canarana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 276,
                Nome = "Canarana",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Canavieiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 277,
                Nome = "Canavieiras",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Candeal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 278,
                Nome = "Candeal",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Candeias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 279,
                Nome = "Candeias",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Candiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 280,
                Nome = "Candiba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cândido Sales
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 281,
                Nome = "Cândido Sales",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cansanção
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 282,
                Nome = "Cansanção",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Canudos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 283,
                Nome = "Canudos",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Capela do Alto Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 284,
                Nome = "Capela do Alto Alegre",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Capim Grosso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 285,
                Nome = "Capim Grosso",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caraíbas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 286,
                Nome = "Caraíbas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caravelas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 287,
                Nome = "Caravelas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cardeal da Silva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 288,
                Nome = "Cardeal da Silva",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Carinhanha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 289,
                Nome = "Carinhanha",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Casa Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 290,
                Nome = "Casa Nova",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Castro Alves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 291,
                Nome = "Castro Alves",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Catolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 292,
                Nome = "Catolândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Catu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 293,
                Nome = "Catu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Caturama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 294,
                Nome = "Caturama",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Central
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 295,
                Nome = "Central",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Chorrochó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 296,
                Nome = "Chorrochó",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cícero Dantas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 297,
                Nome = "Cícero Dantas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cipó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 298,
                Nome = "Cipó",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Coaraci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 299,
                Nome = "Coaraci",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cocos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 300,
                Nome = "Cocos",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Conceição da Feira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 301,
                Nome = "Conceição da Feira",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Conceição do Almeida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 302,
                Nome = "Conceição do Almeida",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Conceição do Coité
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 303,
                Nome = "Conceição do Coité",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Conceição do Jacuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 304,
                Nome = "Conceição do Jacuípe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Conde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 305,
                Nome = "Conde",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Condeúba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 306,
                Nome = "Condeúba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Contendas do Sincorá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 307,
                Nome = "Contendas do Sincorá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Coração de Maria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 308,
                Nome = "Coração de Maria",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cordeiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 309,
                Nome = "Cordeiros",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Coribe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 310,
                Nome = "Coribe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Coronel João Sá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 311,
                Nome = "Coronel João Sá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Correntina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 312,
                Nome = "Correntina",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cotegipe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 313,
                Nome = "Cotegipe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cravolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 314,
                Nome = "Cravolândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Crisópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 315,
                Nome = "Crisópolis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cristópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 316,
                Nome = "Cristópolis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Cruz das Almas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 317,
                Nome = "Cruz das Almas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Curaçá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 318,
                Nome = "Curaçá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Dário Meira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 319,
                Nome = "Dário Meira",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Dias d Ávila
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 320,
                Nome = "Dias d Ávila",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Dom Basílio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 321,
                Nome = "Dom Basílio",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Dom Macedo Costa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 322,
                Nome = "Dom Macedo Costa",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Elísio Medrado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 323,
                Nome = "Elísio Medrado",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Encruzilhada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 324,
                Nome = "Encruzilhada",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Entre Rios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 325,
                Nome = "Entre Rios",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Érico Cardoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 326,
                Nome = "Érico Cardoso",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Esplanada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 327,
                Nome = "Esplanada",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Euclides da Cunha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 328,
                Nome = "Euclides da Cunha",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Eunápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 329,
                Nome = "Eunápolis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Fátima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 330,
                Nome = "Fátima",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Feira da Mata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 331,
                Nome = "Feira da Mata",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Feira de Santana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 332,
                Nome = "Feira de Santana",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Filadélfia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 333,
                Nome = "Filadélfia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Firmino Alves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 334,
                Nome = "Firmino Alves",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Floresta Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 335,
                Nome = "Floresta Azul",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Formosa do Rio Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 336,
                Nome = "Formosa do Rio Preto",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Gandu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 337,
                Nome = "Gandu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Gavião
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 338,
                Nome = "Gavião",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Gentio do Ouro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 339,
                Nome = "Gentio do Ouro",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Glória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 340,
                Nome = "Glória",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Gongogi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 341,
                Nome = "Gongogi",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Governador Lomanto Júnior
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 342,
                Nome = "Governador Lomanto Júnior",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Governador Mangabeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 343,
                Nome = "Governador Mangabeira",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Guajeru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 344,
                Nome = "Guajeru",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Guanambi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 345,
                Nome = "Guanambi",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Guaratinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 346,
                Nome = "Guaratinga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Heliópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 347,
                Nome = "Heliópolis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Iaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 348,
                Nome = "Iaçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibiassucê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 349,
                Nome = "Ibiassucê",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibicaraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 350,
                Nome = "Ibicaraí",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibicoara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 351,
                Nome = "Ibicoara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibicuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 352,
                Nome = "Ibicuí",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibipeba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 353,
                Nome = "Ibipeba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibipitanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 354,
                Nome = "Ibipitanga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibiquera
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 355,
                Nome = "Ibiquera",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibirapitanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 356,
                Nome = "Ibirapitanga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibirapuã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 357,
                Nome = "Ibirapuã",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibirataia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 358,
                Nome = "Ibirataia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibitiara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 359,
                Nome = "Ibitiara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibititá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 360,
                Nome = "Ibititá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ibotirama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 361,
                Nome = "Ibotirama",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ichu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 362,
                Nome = "Ichu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Igaporá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 363,
                Nome = "Igaporá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Igrapiúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 364,
                Nome = "Igrapiúna",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Iguaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 365,
                Nome = "Iguaí",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ilhéus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 366,
                Nome = "Ilhéus",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Inhambupe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 367,
                Nome = "Inhambupe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ipecaetá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 368,
                Nome = "Ipecaetá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ipiaú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 369,
                Nome = "Ipiaú",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ipirá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 370,
                Nome = "Ipirá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ipupiara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 371,
                Nome = "Ipupiara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Irajuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 372,
                Nome = "Irajuba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Iramaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 373,
                Nome = "Iramaia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Iraquara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 374,
                Nome = "Iraquara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Irará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 375,
                Nome = "Irará",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Irecê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 376,
                Nome = "Irecê",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itabela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 377,
                Nome = "Itabela",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itaberaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 378,
                Nome = "Itaberaba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itabuna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 379,
                Nome = "Itabuna",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itacaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 380,
                Nome = "Itacaré",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itaeté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 381,
                Nome = "Itaeté",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itagi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 382,
                Nome = "Itagi",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itagibá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 383,
                Nome = "Itagibá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itagimirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 384,
                Nome = "Itagimirim",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itaguaçu da Bahia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 385,
                Nome = "Itaguaçu da Bahia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itaju do Colônia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 386,
                Nome = "Itaju do Colônia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itajuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 387,
                Nome = "Itajuípe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itamaraju
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 388,
                Nome = "Itamaraju",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itamari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 389,
                Nome = "Itamari",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itambé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 390,
                Nome = "Itambé",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itanagra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 391,
                Nome = "Itanagra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itanhém
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 392,
                Nome = "Itanhém",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itaparica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 393,
                Nome = "Itaparica",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itapé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 394,
                Nome = "Itapé",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itapebi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 395,
                Nome = "Itapebi",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itapetinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 396,
                Nome = "Itapetinga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itapicuru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 397,
                Nome = "Itapicuru",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itapitanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 398,
                Nome = "Itapitanga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itaquara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 399,
                Nome = "Itaquara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itarantim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 400,
                Nome = "Itarantim",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itatim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 401,
                Nome = "Itatim",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itiruçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 402,
                Nome = "Itiruçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itiúba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 403,
                Nome = "Itiúba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Itororó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 404,
                Nome = "Itororó",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ituaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 405,
                Nome = "Ituaçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ituberá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 406,
                Nome = "Ituberá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Iuiú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 407,
                Nome = "Iuiú",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jaborandi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 408,
                Nome = "Jaborandi",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jacaraci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 409,
                Nome = "Jacaraci",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jacobina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 410,
                Nome = "Jacobina",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jaguaquara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 411,
                Nome = "Jaguaquara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jaguarari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 412,
                Nome = "Jaguarari",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jaguaripe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 413,
                Nome = "Jaguaripe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jandaíra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 414,
                Nome = "Jandaíra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jequié
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 415,
                Nome = "Jequié",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jeremoabo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 416,
                Nome = "Jeremoabo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jiquiriçá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 417,
                Nome = "Jiquiriçá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jitaúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 418,
                Nome = "Jitaúna",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: João Dourado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 419,
                Nome = "João Dourado",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Juazeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 420,
                Nome = "Juazeiro",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jucuruçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 421,
                Nome = "Jucuruçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jussara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 422,
                Nome = "Jussara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jussari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 423,
                Nome = "Jussari",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Jussiape
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 424,
                Nome = "Jussiape",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lafaiete Coutinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 425,
                Nome = "Lafaiete Coutinho",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lagoa Real
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 426,
                Nome = "Lagoa Real",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Laje
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 427,
                Nome = "Laje",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lajedão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 428,
                Nome = "Lajedão",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lajedinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 429,
                Nome = "Lajedinho",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lajedo do Tabocal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 430,
                Nome = "Lajedo do Tabocal",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lamarão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 431,
                Nome = "Lamarão",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lapão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 432,
                Nome = "Lapão",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lauro de Freitas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 433,
                Nome = "Lauro de Freitas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Lençóis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 434,
                Nome = "Lençóis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Licínio de Almeida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 435,
                Nome = "Licínio de Almeida",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Livramento de Nossa Senhora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 436,
                Nome = "Livramento de Nossa Senhora",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Luís Eduardo Magalhães
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 437,
                Nome = "Luís Eduardo Magalhães",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Macajuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 438,
                Nome = "Macajuba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Macarani
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 439,
                Nome = "Macarani",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Macaúbas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 440,
                Nome = "Macaúbas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Macururé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 441,
                Nome = "Macururé",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Madre de Deus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 442,
                Nome = "Madre de Deus",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Maetinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 443,
                Nome = "Maetinga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Maiquinique
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 444,
                Nome = "Maiquinique",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mairi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 445,
                Nome = "Mairi",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Malhada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 446,
                Nome = "Malhada",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Malhada de Pedras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 447,
                Nome = "Malhada de Pedras",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Manoel Vitorino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 448,
                Nome = "Manoel Vitorino",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mansidão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 449,
                Nome = "Mansidão",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Maracás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 450,
                Nome = "Maracás",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Maragogipe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 451,
                Nome = "Maragogipe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Maraú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 452,
                Nome = "Maraú",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Marcionílio Souza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 453,
                Nome = "Marcionílio Souza",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mascote
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 454,
                Nome = "Mascote",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mata de São João
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 455,
                Nome = "Mata de São João",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Matina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 456,
                Nome = "Matina",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Medeiros Neto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 457,
                Nome = "Medeiros Neto",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Miguel Calmon
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 458,
                Nome = "Miguel Calmon",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Milagres
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 459,
                Nome = "Milagres",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mirangaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 460,
                Nome = "Mirangaba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mirante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 461,
                Nome = "Mirante",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Monte Santo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 462,
                Nome = "Monte Santo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Morpará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 463,
                Nome = "Morpará",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Morro do Chapéu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 464,
                Nome = "Morro do Chapéu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mortugaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 465,
                Nome = "Mortugaba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mucugê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 466,
                Nome = "Mucugê",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mucuri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 467,
                Nome = "Mucuri",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mulungu do Morro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 468,
                Nome = "Mulungu do Morro",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mundo Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 469,
                Nome = "Mundo Novo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Muniz Ferreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 470,
                Nome = "Muniz Ferreira",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Muquém de São Francisco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 471,
                Nome = "Muquém de São Francisco",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Muritiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 472,
                Nome = "Muritiba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Mutuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 473,
                Nome = "Mutuípe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nazaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 474,
                Nome = "Nazaré",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nilo Peçanha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 475,
                Nome = "Nilo Peçanha",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nordestina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 476,
                Nome = "Nordestina",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nova Canaã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 477,
                Nome = "Nova Canaã",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nova Fátima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 478,
                Nome = "Nova Fátima",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nova Ibiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 479,
                Nome = "Nova Ibiá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nova Itarana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 480,
                Nome = "Nova Itarana",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nova Redenção
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 481,
                Nome = "Nova Redenção",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nova Soure
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 482,
                Nome = "Nova Soure",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Nova Viçosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 483,
                Nome = "Nova Viçosa",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Novo Horizonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 484,
                Nome = "Novo Horizonte",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Novo Triunfo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 485,
                Nome = "Novo Triunfo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Olindina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 486,
                Nome = "Olindina",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Oliveira dos Brejinhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 487,
                Nome = "Oliveira dos Brejinhos",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ouriçangas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 488,
                Nome = "Ouriçangas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ourolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 489,
                Nome = "Ourolândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Palmas de Monte Alto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 490,
                Nome = "Palmas de Monte Alto",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Palmeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 491,
                Nome = "Palmeiras",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Paramirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 492,
                Nome = "Paramirim",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Paratinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 493,
                Nome = "Paratinga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Paripiranga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 494,
                Nome = "Paripiranga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pau Brasil
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 495,
                Nome = "Pau Brasil",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Paulo Afonso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 496,
                Nome = "Paulo Afonso",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pé de Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 497,
                Nome = "Pé de Serra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pedrão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 498,
                Nome = "Pedrão",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pedro Alexandre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 499,
                Nome = "Pedro Alexandre",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Piatã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 500,
                Nome = "Piatã",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pilão Arcado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 501,
                Nome = "Pilão Arcado",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pindaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 502,
                Nome = "Pindaí",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pindobaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 503,
                Nome = "Pindobaçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pintadas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 504,
                Nome = "Pintadas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Piraí do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 505,
                Nome = "Piraí do Norte",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Piripá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 506,
                Nome = "Piripá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Piritiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 507,
                Nome = "Piritiba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Planaltino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 508,
                Nome = "Planaltino",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Planalto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 509,
                Nome = "Planalto",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Poções
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 510,
                Nome = "Poções",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Pojuca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 511,
                Nome = "Pojuca",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ponto Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 512,
                Nome = "Ponto Novo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Porto Seguro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 513,
                Nome = "Porto Seguro",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Potiraguá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 514,
                Nome = "Potiraguá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Prado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 515,
                Nome = "Prado",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Presidente Dutra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 516,
                Nome = "Presidente Dutra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Presidente Jânio Quadros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 517,
                Nome = "Presidente Jânio Quadros",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Presidente Tancredo Neves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 518,
                Nome = "Presidente Tancredo Neves",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Queimadas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 519,
                Nome = "Queimadas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Quijingue
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 520,
                Nome = "Quijingue",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Quixabeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 521,
                Nome = "Quixabeira",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Rafael Jambeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 522,
                Nome = "Rafael Jambeiro",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Remanso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 523,
                Nome = "Remanso",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Retirolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 524,
                Nome = "Retirolândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Riachão das Neves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 525,
                Nome = "Riachão das Neves",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Riachão do Jacuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 526,
                Nome = "Riachão do Jacuípe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Riacho de Santana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 527,
                Nome = "Riacho de Santana",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ribeira do Amparo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 528,
                Nome = "Ribeira do Amparo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ribeira do Pombal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 529,
                Nome = "Ribeira do Pombal",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ribeirão do Largo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 530,
                Nome = "Ribeirão do Largo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Rio de Contas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 531,
                Nome = "Rio de Contas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Rio do Antônio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 532,
                Nome = "Rio do Antônio",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Rio do Pires
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 533,
                Nome = "Rio do Pires",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Rio Real
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 534,
                Nome = "Rio Real",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Rodelas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 535,
                Nome = "Rodelas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ruy Barbosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 536,
                Nome = "Ruy Barbosa",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Salinas da Margarida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 537,
                Nome = "Salinas da Margarida",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Salvador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 538,
                Nome = "Salvador",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Bárbara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 539,
                Nome = "Santa Bárbara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Brígida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 540,
                Nome = "Santa Brígida",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Cruz Cabrália
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 541,
                Nome = "Santa Cruz Cabrália",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Cruz da Vitória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 542,
                Nome = "Santa Cruz da Vitória",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Inês
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 543,
                Nome = "Santa Inês",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Luzia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 544,
                Nome = "Santa Luzia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Maria da Vitória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 545,
                Nome = "Santa Maria da Vitória",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Rita de Cássia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 546,
                Nome = "Santa Rita de Cássia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santa Teresinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 547,
                Nome = "Santa Teresinha",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santaluz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 548,
                Nome = "Santaluz",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 549,
                Nome = "Santana",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santanópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 550,
                Nome = "Santanópolis",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santo Amaro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 551,
                Nome = "Santo Amaro",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santo Antônio de Jesus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 552,
                Nome = "Santo Antônio de Jesus",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Santo Estêvão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 553,
                Nome = "Santo Estêvão",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Desidério
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 554,
                Nome = "São Desidério",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Domingos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 555,
                Nome = "São Domingos",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Felipe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 556,
                Nome = "São Felipe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Félix
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 557,
                Nome = "São Félix",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Félix do Coribe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 558,
                Nome = "São Félix do Coribe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Francisco do Conde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 559,
                Nome = "São Francisco do Conde",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Gabriel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 560,
                Nome = "São Gabriel",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Gonçalo dos Campos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 561,
                Nome = "São Gonçalo dos Campos",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São José da Vitória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 562,
                Nome = "São José da Vitória",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São José do Jacuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 563,
                Nome = "São José do Jacuípe",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Miguel das Matas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 564,
                Nome = "São Miguel das Matas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: São Sebastião do Passé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 565,
                Nome = "São Sebastião do Passé",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Sapeaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 566,
                Nome = "Sapeaçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Sátiro Dias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 567,
                Nome = "Sátiro Dias",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Saubara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 568,
                Nome = "Saubara",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Saúde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 569,
                Nome = "Saúde",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Seabra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 570,
                Nome = "Seabra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Sebastião Laranjeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 571,
                Nome = "Sebastião Laranjeiras",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Senhor do Bonfim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 572,
                Nome = "Senhor do Bonfim",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Sento Sé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 573,
                Nome = "Sento Sé",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Serra do Ramalho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 574,
                Nome = "Serra do Ramalho",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Serra Dourada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 575,
                Nome = "Serra Dourada",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Serra Preta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 576,
                Nome = "Serra Preta",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Serrinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 577,
                Nome = "Serrinha",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Serrolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 578,
                Nome = "Serrolândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Simões Filho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 579,
                Nome = "Simões Filho",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Sítio do Mato
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 580,
                Nome = "Sítio do Mato",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Sítio do Quinto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 581,
                Nome = "Sítio do Quinto",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Sobradinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 582,
                Nome = "Sobradinho",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Souto Soares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 583,
                Nome = "Souto Soares",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Tabocas do Brejo Velho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 584,
                Nome = "Tabocas do Brejo Velho",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Tanhaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 585,
                Nome = "Tanhaçu",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Tanque Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 586,
                Nome = "Tanque Novo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Tanquinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 587,
                Nome = "Tanquinho",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Taperoá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 588,
                Nome = "Taperoá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Tapiramutá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 589,
                Nome = "Tapiramutá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Teixeira de Freitas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 590,
                Nome = "Teixeira de Freitas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Teodoro Sampaio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 591,
                Nome = "Teodoro Sampaio",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Teofilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 592,
                Nome = "Teofilândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Teolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 593,
                Nome = "Teolândia",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Terra Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 594,
                Nome = "Terra Nova",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Tremedal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 595,
                Nome = "Tremedal",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Tucano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 596,
                Nome = "Tucano",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Uauá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 597,
                Nome = "Uauá",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ubaíra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 598,
                Nome = "Ubaíra",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ubaitaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 599,
                Nome = "Ubaitaba",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Ubatã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 600,
                Nome = "Ubatã",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Uibaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 601,
                Nome = "Uibaí",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Umburanas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 602,
                Nome = "Umburanas",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Una
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 603,
                Nome = "Una",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Urandi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 604,
                Nome = "Urandi",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Uruçuca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 605,
                Nome = "Uruçuca",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Utinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 606,
                Nome = "Utinga",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Valença
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 607,
                Nome = "Valença",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Valente
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 608,
                Nome = "Valente",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Várzea da Roça
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 609,
                Nome = "Várzea da Roça",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Várzea do Poço
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 610,
                Nome = "Várzea do Poço",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Várzea Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 611,
                Nome = "Várzea Nova",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Varzedo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 612,
                Nome = "Varzedo",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Vera Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 613,
                Nome = "Vera Cruz",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Vereda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 614,
                Nome = "Vereda",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Vitória da Conquista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 615,
                Nome = "Vitória da Conquista",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Wagner
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 616,
                Nome = "Wagner",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Wanderley
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 617,
                Nome = "Wanderley",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Wenceslau Guimarães
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 618,
                Nome = "Wenceslau Guimarães",
                Situacao = "Ativo",
                UF = "BA"
            });

            // cidade: Xique Xique
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 619,
                Nome = "Xique Xique",
                Situacao = "Ativo",
                UF = "BA"
            });


            await _context.SaveChangesAsync();
        }
    }
}
