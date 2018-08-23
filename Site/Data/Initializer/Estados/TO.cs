using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class TO
    {
        private readonly ApplicationDbContext _context;

        public TO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: TO
            //----------------------------------------------------

            // cidade: Abreulândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5451,
                Nome = "Abreulândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Aguiarnópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5452,
                Nome = "Aguiarnópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Aliança do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5453,
                Nome = "Aliança do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Almas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5454,
                Nome = "Almas",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Alvorada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5455,
                Nome = "Alvorada",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Ananás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5456,
                Nome = "Ananás",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Angico
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5457,
                Nome = "Angico",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Aparecida do Rio Negro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5458,
                Nome = "Aparecida do Rio Negro",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Aragominas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5459,
                Nome = "Aragominas",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Araguacema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5460,
                Nome = "Araguacema",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Araguaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5461,
                Nome = "Araguaçu",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Araguaína
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5462,
                Nome = "Araguaína",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Araguanã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5463,
                Nome = "Araguanã",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Araguatins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5464,
                Nome = "Araguatins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Arapoema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5465,
                Nome = "Arapoema",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Arraias
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5466,
                Nome = "Arraias",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Augustinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5467,
                Nome = "Augustinópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Aurora do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5468,
                Nome = "Aurora do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Axixá do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5469,
                Nome = "Axixá do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Babaçulândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5470,
                Nome = "Babaçulândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Bandeirantes do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5471,
                Nome = "Bandeirantes do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Barra do Ouro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5472,
                Nome = "Barra do Ouro",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Barrolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5473,
                Nome = "Barrolândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Bernardo Sayão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5474,
                Nome = "Bernardo Sayão",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Bom Jesus do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5475,
                Nome = "Bom Jesus do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Brasilândia do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5476,
                Nome = "Brasilândia do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Brejinho de Nazaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5477,
                Nome = "Brejinho de Nazaré",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Buriti do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5478,
                Nome = "Buriti do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Cachoeirinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5479,
                Nome = "Cachoeirinha",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Campos Lindos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5480,
                Nome = "Campos Lindos",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Cariri do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5481,
                Nome = "Cariri do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Carmolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5482,
                Nome = "Carmolândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Carrasco Bonito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5483,
                Nome = "Carrasco Bonito",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Caseara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5484,
                Nome = "Caseara",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Centenário
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5485,
                Nome = "Centenário",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Chapada da Natividade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5486,
                Nome = "Chapada da Natividade",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Chapada de Areia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5487,
                Nome = "Chapada de Areia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Colinas do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5488,
                Nome = "Colinas do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Colméia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5489,
                Nome = "Colméia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Combinado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5490,
                Nome = "Combinado",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Conceição  do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5491,
                Nome = "Conceição  do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Couto de Magalhães
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5492,
                Nome = "Couto de Magalhães",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Cristalândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5493,
                Nome = "Cristalândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Crixás do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5494,
                Nome = "Crixás do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Darcinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5495,
                Nome = "Darcinópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Dianópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5496,
                Nome = "Dianópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Divinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5497,
                Nome = "Divinópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Dois Irmãos do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5498,
                Nome = "Dois Irmãos do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Dueré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5499,
                Nome = "Dueré",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Esperantina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5500,
                Nome = "Esperantina",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Fátima
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5501,
                Nome = "Fátima",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Figueirópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5502,
                Nome = "Figueirópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Filadélfia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5503,
                Nome = "Filadélfia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Formoso do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5504,
                Nome = "Formoso do Araguaia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Fortaleza do Tabocão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5505,
                Nome = "Fortaleza do Tabocão",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Goianorte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5506,
                Nome = "Goianorte",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Goiatins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5507,
                Nome = "Goiatins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Guaraí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5508,
                Nome = "Guaraí",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Gurupi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5509,
                Nome = "Gurupi",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Ipueiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5510,
                Nome = "Ipueiras",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Itacajá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5511,
                Nome = "Itacajá",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Itaguatins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5512,
                Nome = "Itaguatins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Itapiratins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5513,
                Nome = "Itapiratins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Itaporã do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5514,
                Nome = "Itaporã do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Jaú do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5515,
                Nome = "Jaú do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Juarina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5516,
                Nome = "Juarina",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Lagoa da Confusão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5517,
                Nome = "Lagoa da Confusão",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Lagoa do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5518,
                Nome = "Lagoa do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Lajeado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5519,
                Nome = "Lajeado",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Lavandeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5520,
                Nome = "Lavandeira",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Lizarda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5521,
                Nome = "Lizarda",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Luzinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5522,
                Nome = "Luzinópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Marianópolis do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5523,
                Nome = "Marianópolis do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Mateiros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5524,
                Nome = "Mateiros",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Maurilândia do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5525,
                Nome = "Maurilândia do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Miracema do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5526,
                Nome = "Miracema do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Miranorte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5527,
                Nome = "Miranorte",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Monte do Carmo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5528,
                Nome = "Monte do Carmo",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Monte Santo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5529,
                Nome = "Monte Santo",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Muricilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5530,
                Nome = "Muricilândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Natividade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5531,
                Nome = "Natividade",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Nazaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5532,
                Nome = "Nazaré",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Nova Olinda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5533,
                Nome = "Nova Olinda",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Nova Rosalândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5534,
                Nome = "Nova Rosalândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Novo Acordo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5535,
                Nome = "Novo Acordo",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Novo Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5536,
                Nome = "Novo Alegre",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Novo Jardim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5537,
                Nome = "Novo Jardim",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Oliveira de Fátima
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5538,
                Nome = "Oliveira de Fátima",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Palmas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5539,
                Nome = "Palmas",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Palmeirante
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5540,
                Nome = "Palmeirante",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Palmeiras do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5541,
                Nome = "Palmeiras do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Palmeirópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5542,
                Nome = "Palmeirópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Paraíso do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5543,
                Nome = "Paraíso do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Paranã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5544,
                Nome = "Paranã",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Pau D Arco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5545,
                Nome = "Pau D Arco",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Pedro Afonso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5546,
                Nome = "Pedro Afonso",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Peixe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5547,
                Nome = "Peixe",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Pequizeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5548,
                Nome = "Pequizeiro",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Pindorama do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5549,
                Nome = "Pindorama do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Piraquê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5550,
                Nome = "Piraquê",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Pium
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5551,
                Nome = "Pium",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Ponte Alta do Bom Jesus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5552,
                Nome = "Ponte Alta do Bom Jesus",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Ponte Alta do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5553,
                Nome = "Ponte Alta do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Porto Alegre do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5554,
                Nome = "Porto Alegre do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Porto Nacional
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5555,
                Nome = "Porto Nacional",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Praia Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5556,
                Nome = "Praia Norte",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Presidente Kennedy
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5557,
                Nome = "Presidente Kennedy",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Pugmil
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5558,
                Nome = "Pugmil",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Recursolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5559,
                Nome = "Recursolândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Riachinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5560,
                Nome = "Riachinho",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Rio da Conceição
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5561,
                Nome = "Rio da Conceição",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Rio dos Bois
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5562,
                Nome = "Rio dos Bois",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Rio Sono
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5563,
                Nome = "Rio Sono",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Sampaio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5564,
                Nome = "Sampaio",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Sandolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5565,
                Nome = "Sandolândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Santa Fé do Araguaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5566,
                Nome = "Santa Fé do Araguaia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Santa Maria do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5567,
                Nome = "Santa Maria do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Santa Rita do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5568,
                Nome = "Santa Rita do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Santa Rosa do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5569,
                Nome = "Santa Rosa do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Santa Tereza do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5570,
                Nome = "Santa Tereza do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Santa Terezinha do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5571,
                Nome = "Santa Terezinha do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: São Bento do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5572,
                Nome = "São Bento do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: São Félix do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5573,
                Nome = "São Félix do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: São Miguel do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5574,
                Nome = "São Miguel do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: São Salvador do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5575,
                Nome = "São Salvador do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: São Sebastião do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5576,
                Nome = "São Sebastião do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: São Valério da Natividade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5577,
                Nome = "São Valério da Natividade",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Silvanópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5578,
                Nome = "Silvanópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Sítio Novo do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5579,
                Nome = "Sítio Novo do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Sucupira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5580,
                Nome = "Sucupira",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Taguatinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5581,
                Nome = "Taguatinga",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Taipas do Tocantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5582,
                Nome = "Taipas do Tocantins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Talismã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5583,
                Nome = "Talismã",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Taquarussu do Porto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5584,
                Nome = "Taquarussu do Porto",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Tocantínia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5585,
                Nome = "Tocantínia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Tocantinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5586,
                Nome = "Tocantinópolis",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Tupirama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5587,
                Nome = "Tupirama",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Tupiratins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5588,
                Nome = "Tupiratins",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Wanderlândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5589,
                Nome = "Wanderlândia",
                Situacao = "Ativo",
                UF = "TO"
            });

            // cidade: Xambioá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5590,
                Nome = "Xambioá",
                Situacao = "Ativo",
                UF = "TO"
            });


            await _context.SaveChangesAsync();
        }
    }
}
