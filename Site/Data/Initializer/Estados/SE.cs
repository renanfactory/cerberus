using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class SE
    {
        private readonly ApplicationDbContext _context;

        public SE(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: SE
            //----------------------------------------------------

            // cidade: Amparo de São Francisco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4731,
                Nome = "Amparo de São Francisco",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Aquidabã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4732,
                Nome = "Aquidabã",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Aracaju
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4733,
                Nome = "Aracaju",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Arauá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4734,
                Nome = "Arauá",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Areia Branca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4735,
                Nome = "Areia Branca",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Barra dos Coqueiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4736,
                Nome = "Barra dos Coqueiros",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Boquim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4737,
                Nome = "Boquim",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Brejo Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4738,
                Nome = "Brejo Grande",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Campo do Brito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4739,
                Nome = "Campo do Brito",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Canhoba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4740,
                Nome = "Canhoba",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Canindé de São Francisco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4741,
                Nome = "Canindé de São Francisco",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Capela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4742,
                Nome = "Capela",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Carira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4743,
                Nome = "Carira",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Carmópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4744,
                Nome = "Carmópolis",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Cedro de São João
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4745,
                Nome = "Cedro de São João",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Cristinápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4746,
                Nome = "Cristinápolis",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Cumbe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4747,
                Nome = "Cumbe",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Divina Pastora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4748,
                Nome = "Divina Pastora",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Estância
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4749,
                Nome = "Estância",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Feira Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4750,
                Nome = "Feira Nova",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Frei Paulo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4751,
                Nome = "Frei Paulo",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Gararu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4752,
                Nome = "Gararu",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: General Maynard
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4753,
                Nome = "General Maynard",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Gracho Cardoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4754,
                Nome = "Gracho Cardoso",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Ilha das Flores
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4755,
                Nome = "Ilha das Flores",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Indiaroba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4756,
                Nome = "Indiaroba",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Itabaiana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4757,
                Nome = "Itabaiana",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Itabaianinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4758,
                Nome = "Itabaianinha",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Itabi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4759,
                Nome = "Itabi",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Itaporanga d Ajuda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4760,
                Nome = "Itaporanga d Ajuda",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Japaratuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4761,
                Nome = "Japaratuba",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Japoatã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4762,
                Nome = "Japoatã",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Lagarto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4763,
                Nome = "Lagarto",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Laranjeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4764,
                Nome = "Laranjeiras",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Macambira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4765,
                Nome = "Macambira",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Malhada dos Bois
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4766,
                Nome = "Malhada dos Bois",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Malhador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4767,
                Nome = "Malhador",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Maruim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4768,
                Nome = "Maruim",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Moita Bonita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4769,
                Nome = "Moita Bonita",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Monte Alegre de Sergipe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4770,
                Nome = "Monte Alegre de Sergipe",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Muribeca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4771,
                Nome = "Muribeca",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Neópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4772,
                Nome = "Neópolis",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Nossa Senhora Aparecida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4773,
                Nome = "Nossa Senhora Aparecida",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Nossa Senhora da Glória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4774,
                Nome = "Nossa Senhora da Glória",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Nossa Senhora das Dores
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4775,
                Nome = "Nossa Senhora das Dores",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Nossa Senhora de Lourdes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4776,
                Nome = "Nossa Senhora de Lourdes",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Nossa Senhora do Socorro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4777,
                Nome = "Nossa Senhora do Socorro",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Pacatuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4778,
                Nome = "Pacatuba",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Pedra Mole
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4779,
                Nome = "Pedra Mole",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Pedrinhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4780,
                Nome = "Pedrinhas",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Pinhão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4781,
                Nome = "Pinhão",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Pirambu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4782,
                Nome = "Pirambu",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Poço Redondo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4783,
                Nome = "Poço Redondo",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Poço Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4784,
                Nome = "Poço Verde",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Porto da Folha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4785,
                Nome = "Porto da Folha",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Propriá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4786,
                Nome = "Propriá",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Riachão do Dantas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4787,
                Nome = "Riachão do Dantas",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Riachuelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4788,
                Nome = "Riachuelo",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Ribeirópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4789,
                Nome = "Ribeirópolis",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Rosário do Catete
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4790,
                Nome = "Rosário do Catete",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Salgado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4791,
                Nome = "Salgado",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Santa Luzia do Itanhy
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4792,
                Nome = "Santa Luzia do Itanhy",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Santa Rosa de Lima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4793,
                Nome = "Santa Rosa de Lima",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Santana do São Francisco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4794,
                Nome = "Santana do São Francisco",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Santo Amaro das Brotas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4795,
                Nome = "Santo Amaro das Brotas",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: São Cristóvão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4796,
                Nome = "São Cristóvão",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: São Domingos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4797,
                Nome = "São Domingos",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: São Francisco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4798,
                Nome = "São Francisco",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: São Miguel do Aleixo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4799,
                Nome = "São Miguel do Aleixo",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Simão Dias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4800,
                Nome = "Simão Dias",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Siriri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4801,
                Nome = "Siriri",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Telha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4802,
                Nome = "Telha",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Tobias Barreto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4803,
                Nome = "Tobias Barreto",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Tomar do Geru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4804,
                Nome = "Tomar do Geru",
                Situacao = "Ativo",
                UF = "SE"
            });

            // cidade: Umbaúba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4805,
                Nome = "Umbaúba",
                Situacao = "Ativo",
                UF = "SE"
            });


            await _context.SaveChangesAsync();
        }
    }
}
