using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class AM
    {
        private readonly ApplicationDbContext _context;

        public AM(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: AM
            //----------------------------------------------------

            // cidade: Alvarães
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 125,
                Nome = "Alvarães",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Amaturá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 126,
                Nome = "Amaturá",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Anamã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 127,
                Nome = "Anamã",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Anori
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 128,
                Nome = "Anori",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Apuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 129,
                Nome = "Apuí",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Atalaia do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 130,
                Nome = "Atalaia do Norte",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Autazes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 131,
                Nome = "Autazes",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Barcelos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 132,
                Nome = "Barcelos",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Barreirinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 133,
                Nome = "Barreirinha",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Benjamin Constant
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 134,
                Nome = "Benjamin Constant",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Beruri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 135,
                Nome = "Beruri",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Boa Vista do Ramos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 136,
                Nome = "Boa Vista do Ramos",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Boca do Acre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 137,
                Nome = "Boca do Acre",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Borba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 138,
                Nome = "Borba",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Caapiranga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 139,
                Nome = "Caapiranga",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Canutama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 140,
                Nome = "Canutama",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Carauari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 141,
                Nome = "Carauari",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Careiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 142,
                Nome = "Careiro",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Careiro da Várzea
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 143,
                Nome = "Careiro da Várzea",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Coari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 144,
                Nome = "Coari",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Codajás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 145,
                Nome = "Codajás",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Eirunepé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 146,
                Nome = "Eirunepé",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Envira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 147,
                Nome = "Envira",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Fonte Nova
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 148,
                Nome = "Fonte Nova",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Guajará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 149,
                Nome = "Guajará",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Humaitá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 150,
                Nome = "Humaitá",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Ipixuna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 151,
                Nome = "Ipixuna",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Iranduba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 152,
                Nome = "Iranduba",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Itacoatiara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 153,
                Nome = "Itacoatiara",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Itamarati
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 154,
                Nome = "Itamarati",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Itapiranga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 155,
                Nome = "Itapiranga",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Japurá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 156,
                Nome = "Japurá",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Juruá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 157,
                Nome = "Juruá",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Jutaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 158,
                Nome = "Jutaí",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Lábrea
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 159,
                Nome = "Lábrea",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Manacapuru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 160,
                Nome = "Manacapuru",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Manaquiri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 161,
                Nome = "Manaquiri",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Manaus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 162,
                Nome = "Manaus",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Manicoré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 163,
                Nome = "Manicoré",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Maraã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 164,
                Nome = "Maraã",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Maués
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 165,
                Nome = "Maués",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Nhamundá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 166,
                Nome = "Nhamundá",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Nova Olinda do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 167,
                Nome = "Nova Olinda do Norte",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Novo Airão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 168,
                Nome = "Novo Airão",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Novo Aripuanã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 169,
                Nome = "Novo Aripuanã",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Parintins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 170,
                Nome = "Parintins",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Pauini
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 171,
                Nome = "Pauini",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Presidente Figueiredo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 172,
                Nome = "Presidente Figueiredo",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Rio Preto da Eva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 173,
                Nome = "Rio Preto da Eva",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Santa Isabel do Rio Negro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 174,
                Nome = "Santa Isabel do Rio Negro",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Santo Antônio do Içá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 175,
                Nome = "Santo Antônio do Içá",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: São Gabriel da Cachoeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 176,
                Nome = "São Gabriel da Cachoeira",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: São Paulo de Olivença
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 177,
                Nome = "São Paulo de Olivença",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: São Sebastião do Uatumã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 178,
                Nome = "São Sebastião do Uatumã",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Silves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 179,
                Nome = "Silves",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Tabatinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 180,
                Nome = "Tabatinga",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Tapauá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 181,
                Nome = "Tapauá",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Tefé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 182,
                Nome = "Tefé",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Tonantins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 183,
                Nome = "Tonantins",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Uarini
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 184,
                Nome = "Uarini",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Urucará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 185,
                Nome = "Urucará",
                Situacao = "Ativo",
                UF = "AM"
            });

            // cidade: Urucurituba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 186,
                Nome = "Urucurituba",
                Situacao = "Ativo",
                UF = "AM"
            });

            await _context.SaveChangesAsync();
        }
    }
}
