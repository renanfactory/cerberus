using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class RJ
    {
        private readonly ApplicationDbContext _context;

        public RJ(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: RJ
            //----------------------------------------------------

            // cidade: Angra dos Reis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3619,
                Nome = "Angra dos Reis",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Aperibé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3620,
                Nome = "Aperibé",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Araruama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3621,
                Nome = "Araruama",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Areal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3622,
                Nome = "Areal",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Armação dos Búzios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3623,
                Nome = "Armação dos Búzios",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Arraial do Cabo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3624,
                Nome = "Arraial do Cabo",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Barra do Piraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3625,
                Nome = "Barra do Piraí",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Barra Mansa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3626,
                Nome = "Barra Mansa",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Belford Roxo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3627,
                Nome = "Belford Roxo",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Bom Jardim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3628,
                Nome = "Bom Jardim",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Bom Jesus do Itabapoana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3629,
                Nome = "Bom Jesus do Itabapoana",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Cabo Frio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3630,
                Nome = "Cabo Frio",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Cachoeiras de Macacu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3631,
                Nome = "Cachoeiras de Macacu",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Cambuci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3632,
                Nome = "Cambuci",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Campos dos Goytacazes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3633,
                Nome = "Campos dos Goytacazes",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Cantagalo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3634,
                Nome = "Cantagalo",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Carapebus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3635,
                Nome = "Carapebus",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Cardoso Moreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3636,
                Nome = "Cardoso Moreira",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Carmo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3637,
                Nome = "Carmo",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Casimiro de Abreu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3638,
                Nome = "Casimiro de Abreu",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Comendador Levy Gasparian
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3639,
                Nome = "Comendador Levy Gasparian",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Conceição de Macabu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3640,
                Nome = "Conceição de Macabu",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Cordeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3641,
                Nome = "Cordeiro",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Duas Barras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3642,
                Nome = "Duas Barras",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Duque de Caxias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3643,
                Nome = "Duque de Caxias",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Engenheiro Paulo de Frontin
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3644,
                Nome = "Engenheiro Paulo de Frontin",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Guapimirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3645,
                Nome = "Guapimirim",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Iguaba Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3646,
                Nome = "Iguaba Grande",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Itaboraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3647,
                Nome = "Itaboraí",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Itaguaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3648,
                Nome = "Itaguaí",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Italva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3649,
                Nome = "Italva",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Itaocara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3650,
                Nome = "Itaocara",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Itaperuna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3651,
                Nome = "Itaperuna",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Itatiaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3652,
                Nome = "Itatiaia",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Japeri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3653,
                Nome = "Japeri",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Laje do Muriaé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3654,
                Nome = "Laje do Muriaé",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Macaé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3655,
                Nome = "Macaé",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Macuco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3656,
                Nome = "Macuco",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Magé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3657,
                Nome = "Magé",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Mangaratiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3658,
                Nome = "Mangaratiba",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Maricá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3659,
                Nome = "Maricá",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Mendes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3660,
                Nome = "Mendes",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Mesquita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3661,
                Nome = "Mesquita",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Miguel Pereira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3662,
                Nome = "Miguel Pereira",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Miracema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3663,
                Nome = "Miracema",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Natividade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3664,
                Nome = "Natividade",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Nilópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3665,
                Nome = "Nilópolis",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Niterói
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3666,
                Nome = "Niterói",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Nova Friburgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3667,
                Nome = "Nova Friburgo",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Nova Iguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3668,
                Nome = "Nova Iguaçu",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Paracambi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3669,
                Nome = "Paracambi",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Paraíba do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3670,
                Nome = "Paraíba do Sul",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Parati
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3671,
                Nome = "Parati",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Pati do Alferes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3672,
                Nome = "Pati do Alferes",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Petrópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3673,
                Nome = "Petrópolis",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Pinheiral
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3674,
                Nome = "Pinheiral",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Piraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3675,
                Nome = "Piraí",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Porciúncula
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3676,
                Nome = "Porciúncula",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Porto Real
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3677,
                Nome = "Porto Real",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Quatis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3678,
                Nome = "Quatis",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Queimados
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3679,
                Nome = "Queimados",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Quissamã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3680,
                Nome = "Quissamã",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Resende
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3681,
                Nome = "Resende",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Rio Bonito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3682,
                Nome = "Rio Bonito",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Rio Claro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3683,
                Nome = "Rio Claro",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Rio das Flores
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3684,
                Nome = "Rio das Flores",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Rio das Ostras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3685,
                Nome = "Rio das Ostras",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Rio de Janeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3686,
                Nome = "Rio de Janeiro",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Santa Maria Madalena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3687,
                Nome = "Santa Maria Madalena",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Santo Antônio de Pádua
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3688,
                Nome = "Santo Antônio de Pádua",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São Fidélis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3689,
                Nome = "São Fidélis",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São Francisco de Itabapoana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3690,
                Nome = "São Francisco de Itabapoana",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São Gonçalo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3691,
                Nome = "São Gonçalo",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São João da Barra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3692,
                Nome = "São João da Barra",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São João de Meriti
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3693,
                Nome = "São João de Meriti",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São José de Ubá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3694,
                Nome = "São José de Ubá",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São José do Vale do Rio Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3695,
                Nome = "São José do Vale do Rio Preto",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São Pedro da Aldeia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3696,
                Nome = "São Pedro da Aldeia",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: São Sebastião do Alto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3697,
                Nome = "São Sebastião do Alto",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Sapucaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3698,
                Nome = "Sapucaia",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Saquarema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3699,
                Nome = "Saquarema",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Seropédica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3700,
                Nome = "Seropédica",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Silva Jardim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3701,
                Nome = "Silva Jardim",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Sumidouro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3702,
                Nome = "Sumidouro",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Tanguá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3703,
                Nome = "Tanguá",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Teresópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3704,
                Nome = "Teresópolis",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Trajano de Moraes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3705,
                Nome = "Trajano de Moraes",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Três Rios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3706,
                Nome = "Três Rios",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Valença
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3707,
                Nome = "Valença",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Varre Sai
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3708,
                Nome = "Varre Sai",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Vassouras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3709,
                Nome = "Vassouras",
                Situacao = "Ativo",
                UF = "RJ"
            });

            // cidade: Volta Redonda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3710,
                Nome = "Volta Redonda",
                Situacao = "Ativo",
                UF = "RJ"
            });


            await _context.SaveChangesAsync();
        }
    }
}
