using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class RO
    {
        private readonly ApplicationDbContext _context;

        public RO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: RO
            //----------------------------------------------------

            // cidade: Alta Floresta D Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3877,
                Nome = "Alta Floresta D Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Alto Alegre dos Parecis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3878,
                Nome = "Alto Alegre dos Parecis",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Alto Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3879,
                Nome = "Alto Paraíso",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Alvorada D Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3880,
                Nome = "Alvorada D Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Ariquemes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3881,
                Nome = "Ariquemes",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Buritis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3882,
                Nome = "Buritis",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Cabixi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3883,
                Nome = "Cabixi",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Cacaulândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3884,
                Nome = "Cacaulândia",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Cacoal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3885,
                Nome = "Cacoal",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Campo Novo de Rondônia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3886,
                Nome = "Campo Novo de Rondônia",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Candeias do Jamari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3887,
                Nome = "Candeias do Jamari",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Castanheiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3888,
                Nome = "Castanheiras",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Cerejeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3889,
                Nome = "Cerejeiras",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Chupinguaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3890,
                Nome = "Chupinguaia",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Colorado do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3891,
                Nome = "Colorado do Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Corumbiara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3892,
                Nome = "Corumbiara",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Costa Marques
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3893,
                Nome = "Costa Marques",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Cujubim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3894,
                Nome = "Cujubim",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Espigão d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3895,
                Nome = "Espigão d Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Governador Jorge Teixeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3896,
                Nome = "Governador Jorge Teixeira",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: GuajaráMirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3897,
                Nome = "GuajaráMirim",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Itapuã do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3898,
                Nome = "Itapuã do Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Jaru
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3899,
                Nome = "Jaru",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Ji Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3900,
                Nome = "Ji Paraná",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Machadinho d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3901,
                Nome = "Machadinho d Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Ministro Andreazza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3902,
                Nome = "Ministro Andreazza",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Mirante da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3903,
                Nome = "Mirante da Serra",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Monte Negro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3904,
                Nome = "Monte Negro",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Nova Brasilândia D Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3905,
                Nome = "Nova Brasilândia D Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Nova Mamoré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3906,
                Nome = "Nova Mamoré",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Nova União
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3907,
                Nome = "Nova União",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Novo Horizonte do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3908,
                Nome = "Novo Horizonte do Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Ouro Preto do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3909,
                Nome = "Ouro Preto do Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Parecis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3910,
                Nome = "Parecis",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Pimenta Bueno
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3911,
                Nome = "Pimenta Bueno",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Pimenteiras do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3912,
                Nome = "Pimenteiras do Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Porto Velho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3913,
                Nome = "Porto Velho",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Presidente Médici
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3914,
                Nome = "Presidente Médici",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Primavera de Rondônia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3915,
                Nome = "Primavera de Rondônia",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Rio Crespo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3916,
                Nome = "Rio Crespo",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Rolim de Moura
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3917,
                Nome = "Rolim de Moura",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Santa Luzia d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3918,
                Nome = "Santa Luzia d Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: São Felipe D Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3919,
                Nome = "São Felipe D Oeste",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: São Francisco do Guaporé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3920,
                Nome = "São Francisco do Guaporé",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: São Miguel do Guaporé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3921,
                Nome = "São Miguel do Guaporé",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Seringueiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3922,
                Nome = "Seringueiras",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Teixeirópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3923,
                Nome = "Teixeirópolis",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Theobroma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3924,
                Nome = "Theobroma",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Urupá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3925,
                Nome = "Urupá",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Vale do Anari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3926,
                Nome = "Vale do Anari",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Vale do Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3927,
                Nome = "Vale do Paraíso",
                Situacao = "Ativo",
                UF = "RO"
            });

            // cidade: Vilhena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3928,
                Nome = "Vilhena",
                Situacao = "Ativo",
                UF = "RO"
            });

            await _context.SaveChangesAsync();
        }
    }
}
