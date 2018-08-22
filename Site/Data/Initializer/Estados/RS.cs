using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class RS
    {
        private readonly ApplicationDbContext _context;

        public RS(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
         // Estado: RS
         //----------------------------------------------------

            // cidade: Aceguá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3944,
                Nome = "Aceguá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Água Santa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3945,
                Nome = "Água Santa",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Agudo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3946,
                Nome = "Agudo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ajuricaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3947,
                Nome = "Ajuricaba",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Alecrim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3948,
                Nome = "Alecrim",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Alegrete
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3949,
                Nome = "Alegrete",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Alegria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3950,
                Nome = "Alegria",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Almirante Tamandaré do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3951,
                Nome = "Almirante Tamandaré do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Alpestre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3952,
                Nome = "Alpestre",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Alto Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3953,
                Nome = "Alto Alegre",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Alto Feliz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3954,
                Nome = "Alto Feliz",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Alvorada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3955,
                Nome = "Alvorada",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Amaral Ferrador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3956,
                Nome = "Amaral Ferrador",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ametista do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3957,
                Nome = "Ametista do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: André da Rocha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3958,
                Nome = "André da Rocha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Anta Gorda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3959,
                Nome = "Anta Gorda",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Antônio Prado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3960,
                Nome = "Antônio Prado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arambaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3961,
                Nome = "Arambaré",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Araricá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3962,
                Nome = "Araricá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Aratiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3963,
                Nome = "Aratiba",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arroio do Meio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3964,
                Nome = "Arroio do Meio",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arroio do Padre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3965,
                Nome = "Arroio do Padre",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arroio do Sal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3966,
                Nome = "Arroio do Sal",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arroio do Tigre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3967,
                Nome = "Arroio do Tigre",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arroio dos Ratos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3968,
                Nome = "Arroio dos Ratos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arroio Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3969,
                Nome = "Arroio Grande",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Arvorezinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3970,
                Nome = "Arvorezinha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Augusto Pestana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3971,
                Nome = "Augusto Pestana",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Áurea
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3972,
                Nome = "Áurea",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bagé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3973,
                Nome = "Bagé",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Balneário Pinhal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3974,
                Nome = "Balneário Pinhal",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3975,
                Nome = "Barão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barão de Cotegipe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3976,
                Nome = "Barão de Cotegipe",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barão do Triunfo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3977,
                Nome = "Barão do Triunfo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barra do Guarita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3978,
                Nome = "Barra do Guarita",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barra do Quaraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3979,
                Nome = "Barra do Quaraí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barra do Ribeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3980,
                Nome = "Barra do Ribeiro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barra do Rio Azul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3981,
                Nome = "Barra do Rio Azul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barra Funda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3982,
                Nome = "Barra Funda",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barracão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3983,
                Nome = "Barracão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Barros Cassal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3984,
                Nome = "Barros Cassal",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Benjamin Constant do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3985,
                Nome = "Benjamin Constant do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bento Gonçalves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3986,
                Nome = "Bento Gonçalves",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Boa Vista das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3987,
                Nome = "Boa Vista das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Boa Vista do Buricá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3988,
                Nome = "Boa Vista do Buricá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Boa Vista do Incra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3989,
                Nome = "Boa Vista do Incra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Boa Vista do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3990,
                Nome = "Boa Vista do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bom Jesus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3991,
                Nome = "Bom Jesus",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bom Princípio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3992,
                Nome = "Bom Princípio",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bom Progresso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3993,
                Nome = "Bom Progresso",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bom Retiro do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3994,
                Nome = "Bom Retiro do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Boqueirão do Leão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3995,
                Nome = "Boqueirão do Leão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bossoroca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3996,
                Nome = "Bossoroca",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Bozano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3997,
                Nome = "Bozano",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Braga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3998,
                Nome = "Braga",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Brochier
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3999,
                Nome = "Brochier",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Butiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4000,
                Nome = "Butiá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Caçapava do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4001,
                Nome = "Caçapava do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cacequi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4002,
                Nome = "Cacequi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cachoeira do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4003,
                Nome = "Cachoeira do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cachoeirinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4004,
                Nome = "Cachoeirinha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cacique Doble
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4005,
                Nome = "Cacique Doble",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Caibaté
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4006,
                Nome = "Caibaté",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Caiçara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4007,
                Nome = "Caiçara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Camaquã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4008,
                Nome = "Camaquã",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Camargo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4009,
                Nome = "Camargo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cambará do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4010,
                Nome = "Cambará do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Campestre da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4011,
                Nome = "Campestre da Serra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Campina das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4012,
                Nome = "Campina das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Campinas do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4013,
                Nome = "Campinas do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Campo Bom
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4014,
                Nome = "Campo Bom",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Campo Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4015,
                Nome = "Campo Novo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Campos Borges
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4016,
                Nome = "Campos Borges",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Candelária
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4017,
                Nome = "Candelária",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cândido Godói
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4018,
                Nome = "Cândido Godói",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Candiota
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4019,
                Nome = "Candiota",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Canela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4020,
                Nome = "Canela",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Canguçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4021,
                Nome = "Canguçu",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Canoas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4022,
                Nome = "Canoas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Canudos do Vale
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4023,
                Nome = "Canudos do Vale",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Capão Bonito do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4024,
                Nome = "Capão Bonito do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Capão da Canoa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4025,
                Nome = "Capão da Canoa",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Capão do Cipó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4026,
                Nome = "Capão do Cipó",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Capão do Leão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4027,
                Nome = "Capão do Leão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Capela de Santana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4028,
                Nome = "Capela de Santana",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Capitão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4029,
                Nome = "Capitão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Capivari do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4030,
                Nome = "Capivari do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Caraá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4031,
                Nome = "Caraá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Carazinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4032,
                Nome = "Carazinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Carlos Barbosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4033,
                Nome = "Carlos Barbosa",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Carlos Gomes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4034,
                Nome = "Carlos Gomes",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Casca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4035,
                Nome = "Casca",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Caseiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4036,
                Nome = "Caseiros",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Catuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4037,
                Nome = "Catuípe",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Caxias do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4038,
                Nome = "Caxias do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Centenário
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4039,
                Nome = "Centenário",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cerrito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4040,
                Nome = "Cerrito",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cerro Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4041,
                Nome = "Cerro Branco",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cerro Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4042,
                Nome = "Cerro Grande",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cerro Grande do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4043,
                Nome = "Cerro Grande do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cerro Largo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4044,
                Nome = "Cerro Largo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Chapada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4045,
                Nome = "Chapada",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Charqueadas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4046,
                Nome = "Charqueadas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Charrua
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4047,
                Nome = "Charrua",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Chiapeta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4048,
                Nome = "Chiapeta",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Chuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4049,
                Nome = "Chuí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Chuvisca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4050,
                Nome = "Chuvisca",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cidreira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4051,
                Nome = "Cidreira",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ciríaco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4052,
                Nome = "Ciríaco",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Colinas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4053,
                Nome = "Colinas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Colorado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4054,
                Nome = "Colorado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Condor
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4055,
                Nome = "Condor",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Constantina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4056,
                Nome = "Constantina",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Coqueiro Baixo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4057,
                Nome = "Coqueiro Baixo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Coqueiros do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4058,
                Nome = "Coqueiros do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Coronel Barros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4059,
                Nome = "Coronel Barros",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Coronel Bicaco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4060,
                Nome = "Coronel Bicaco",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Coronel Pilar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4061,
                Nome = "Coronel Pilar",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cotiporã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4062,
                Nome = "Cotiporã",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Coxilha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4063,
                Nome = "Coxilha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Crissiumal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4064,
                Nome = "Crissiumal",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cristal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4065,
                Nome = "Cristal",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cristal do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4066,
                Nome = "Cristal do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cruz Alta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4067,
                Nome = "Cruz Alta",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cruzaltense
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4068,
                Nome = "Cruzaltense",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Cruzeiro do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4069,
                Nome = "Cruzeiro do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: David Canabarro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4070,
                Nome = "David Canabarro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Derrubadas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4071,
                Nome = "Derrubadas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dezesseis de Novembro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4072,
                Nome = "Dezesseis de Novembro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dilermando de Aguiar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4073,
                Nome = "Dilermando de Aguiar",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dois Irmãos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4074,
                Nome = "Dois Irmãos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dois Irmãos das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4075,
                Nome = "Dois Irmãos das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dois Lajeados
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4076,
                Nome = "Dois Lajeados",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dom Feliciano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4077,
                Nome = "Dom Feliciano",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dom Pedrito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4078,
                Nome = "Dom Pedrito",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dom Pedro de Alcântara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4079,
                Nome = "Dom Pedro de Alcântara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Dona Francisca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4080,
                Nome = "Dona Francisca",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Doutor Maurício Cardoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4081,
                Nome = "Doutor Maurício Cardoso",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Doutor Ricardo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4082,
                Nome = "Doutor Ricardo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Eldorado do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4083,
                Nome = "Eldorado do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Encantado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4084,
                Nome = "Encantado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Encruzilhada do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4085,
                Nome = "Encruzilhada do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Engenho Velho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4086,
                Nome = "Engenho Velho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Entre Ijuís
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4087,
                Nome = "Entre Ijuís",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Entre Rios do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4088,
                Nome = "Entre Rios do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Erebango
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4089,
                Nome = "Erebango",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Erechim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4090,
                Nome = "Erechim",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ernestina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4091,
                Nome = "Ernestina",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Erval Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4092,
                Nome = "Erval Grande",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Erval Seco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4093,
                Nome = "Erval Seco",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Esmeralda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4094,
                Nome = "Esmeralda",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Esperança do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4095,
                Nome = "Esperança do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Espumoso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4096,
                Nome = "Espumoso",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Estação
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4097,
                Nome = "Estação",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Estância Velha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4098,
                Nome = "Estância Velha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Esteio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4099,
                Nome = "Esteio",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Estrela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4100,
                Nome = "Estrela",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Estrela Velha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4101,
                Nome = "Estrela Velha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Eugênio de Castro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4102,
                Nome = "Eugênio de Castro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Fagundes Varela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4103,
                Nome = "Fagundes Varela",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Farroupilha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4104,
                Nome = "Farroupilha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Faxinal do Soturno
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4105,
                Nome = "Faxinal do Soturno",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Faxinalzinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4106,
                Nome = "Faxinalzinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Fazenda Vilanova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4107,
                Nome = "Fazenda Vilanova",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Feliz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4108,
                Nome = "Feliz",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Flores da Cunha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4109,
                Nome = "Flores da Cunha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Floriano Peixoto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4110,
                Nome = "Floriano Peixoto",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Fontoura Xavier
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4111,
                Nome = "Fontoura Xavier",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Formigueiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4112,
                Nome = "Formigueiro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Forquetinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4113,
                Nome = "Forquetinha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Fortaleza dos Valos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4114,
                Nome = "Fortaleza dos Valos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Frederico Westphalen
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4115,
                Nome = "Frederico Westphalen",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Garibaldi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4116,
                Nome = "Garibaldi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Garruchos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4117,
                Nome = "Garruchos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Gaurama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4118,
                Nome = "Gaurama",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: General Câmara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4119,
                Nome = "General Câmara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Gentil
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4120,
                Nome = "Gentil",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Getúlio Vargas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4121,
                Nome = "Getúlio Vargas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Giruá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4122,
                Nome = "Giruá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Glorinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4123,
                Nome = "Glorinha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Gramado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4124,
                Nome = "Gramado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Gramado dos Loureiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4125,
                Nome = "Gramado dos Loureiros",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Gramado Xavier
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4126,
                Nome = "Gramado Xavier",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Gravataí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4127,
                Nome = "Gravataí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Guabiju
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4128,
                Nome = "Guabiju",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Guaíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4129,
                Nome = "Guaíba",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Guaporé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4130,
                Nome = "Guaporé",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Guarani das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4131,
                Nome = "Guarani das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Harmonia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4132,
                Nome = "Harmonia",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Herveiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4133,
                Nome = "Herveiras",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Horizontina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4134,
                Nome = "Horizontina",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Hulha Negra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4135,
                Nome = "Hulha Negra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Humaitá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4136,
                Nome = "Humaitá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ibarama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4137,
                Nome = "Ibarama",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ibiaçá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4138,
                Nome = "Ibiaçá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ibiraiaras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4139,
                Nome = "Ibiraiaras",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ibirapuitã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4140,
                Nome = "Ibirapuitã",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ibirubá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4141,
                Nome = "Ibirubá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Igrejinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4142,
                Nome = "Igrejinha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ijuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4143,
                Nome = "Ijuí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ilópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4144,
                Nome = "Ilópolis",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Imbé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4145,
                Nome = "Imbé",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Imigrante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4146,
                Nome = "Imigrante",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Independência
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4147,
                Nome = "Independência",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Inhacorá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4148,
                Nome = "Inhacorá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ipê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4149,
                Nome = "Ipê",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ipiranga do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4150,
                Nome = "Ipiranga do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Iraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4151,
                Nome = "Iraí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Itaara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4152,
                Nome = "Itaara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Itacurubi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4153,
                Nome = "Itacurubi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Itapuca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4154,
                Nome = "Itapuca",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Itaqui
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4155,
                Nome = "Itaqui",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Itati
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4156,
                Nome = "Itati",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Itatiba do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4157,
                Nome = "Itatiba do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ivorá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4158,
                Nome = "Ivorá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ivoti
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4159,
                Nome = "Ivoti",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jaboticaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4160,
                Nome = "Jaboticaba",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jacuizinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4161,
                Nome = "Jacuizinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jacutinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4162,
                Nome = "Jacutinga",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jaguarão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4163,
                Nome = "Jaguarão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jaguari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4164,
                Nome = "Jaguari",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jaquirana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4165,
                Nome = "Jaquirana",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4166,
                Nome = "Jari",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Jóia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4167,
                Nome = "Jóia",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Júlio de Castilhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4168,
                Nome = "Júlio de Castilhos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lagoa Bonita do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4169,
                Nome = "Lagoa Bonita do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lagoa dos Três Cantos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4170,
                Nome = "Lagoa dos Três Cantos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lagoa Vermelha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4171,
                Nome = "Lagoa Vermelha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lagoão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4172,
                Nome = "Lagoão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lajeado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4173,
                Nome = "Lajeado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lajeado do Bugre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4174,
                Nome = "Lajeado do Bugre",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lavras do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4175,
                Nome = "Lavras do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Liberato Salzano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4176,
                Nome = "Liberato Salzano",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Lindolfo Collor
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4177,
                Nome = "Lindolfo Collor",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Linha Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4178,
                Nome = "Linha Nova",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Maçambara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4179,
                Nome = "Maçambara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Machadinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4180,
                Nome = "Machadinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mampituba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4181,
                Nome = "Mampituba",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Manoel Viana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4182,
                Nome = "Manoel Viana",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Maquiné
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4183,
                Nome = "Maquiné",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Maratá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4184,
                Nome = "Maratá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Marau
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4185,
                Nome = "Marau",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Marcelino Ramos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4186,
                Nome = "Marcelino Ramos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mariana Pimentel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4187,
                Nome = "Mariana Pimentel",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mariano Moro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4188,
                Nome = "Mariano Moro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Marques de Souza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4189,
                Nome = "Marques de Souza",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4190,
                Nome = "Mata",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mato Castelhano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4191,
                Nome = "Mato Castelhano",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mato Leitão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4192,
                Nome = "Mato Leitão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mato Queimado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4193,
                Nome = "Mato Queimado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Maximiliano de Almeida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4194,
                Nome = "Maximiliano de Almeida",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Minas do Leão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4195,
                Nome = "Minas do Leão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Miraguaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4196,
                Nome = "Miraguaí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Montauri
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4197,
                Nome = "Montauri",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Monte Alegre dos Campos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4198,
                Nome = "Monte Alegre dos Campos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Monte Belo do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4199,
                Nome = "Monte Belo do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Montenegro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4200,
                Nome = "Montenegro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mormaço
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4201,
                Nome = "Mormaço",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Morrinhos do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4202,
                Nome = "Morrinhos do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Morro Redondo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4203,
                Nome = "Morro Redondo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Morro Reuter
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4204,
                Nome = "Morro Reuter",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Mostardas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4205,
                Nome = "Mostardas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Muçum
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4206,
                Nome = "Muçum",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Muitos Capões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4207,
                Nome = "Muitos Capões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Muliterno
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4208,
                Nome = "Muliterno",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Não Me Toque
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4209,
                Nome = "Não Me Toque",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nicolau Vergueiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4210,
                Nome = "Nicolau Vergueiro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nonoai
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4211,
                Nome = "Nonoai",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Alvorada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4212,
                Nome = "Nova Alvorada",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Araçá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4213,
                Nome = "Nova Araçá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Bassano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4214,
                Nome = "Nova Bassano",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Boa Vista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4215,
                Nome = "Nova Boa Vista",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Bréscia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4216,
                Nome = "Nova Bréscia",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Candelária
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4217,
                Nome = "Nova Candelária",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Esperança do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4218,
                Nome = "Nova Esperança do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Hartz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4219,
                Nome = "Nova Hartz",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Pádua
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4220,
                Nome = "Nova Pádua",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Palma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4221,
                Nome = "Nova Palma",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Petrópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4222,
                Nome = "Nova Petrópolis",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Prata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4223,
                Nome = "Nova Prata",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Ramada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4224,
                Nome = "Nova Ramada",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Roma do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4225,
                Nome = "Nova Roma do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Nova Santa Rita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4226,
                Nome = "Nova Santa Rita",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Novo Barreiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4227,
                Nome = "Novo Barreiro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Novo Cabrais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4228,
                Nome = "Novo Cabrais",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Novo Hamburgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4229,
                Nome = "Novo Hamburgo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Novo Machado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4230,
                Nome = "Novo Machado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Novo Tiradentes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4231,
                Nome = "Novo Tiradentes",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Novo Xingu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4232,
                Nome = "Novo Xingu",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Osório
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4233,
                Nome = "Osório",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Paim Filho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4234,
                Nome = "Paim Filho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Palmares do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4235,
                Nome = "Palmares do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Palmeira das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4236,
                Nome = "Palmeira das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Palmitinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4237,
                Nome = "Palmitinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Panambi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4238,
                Nome = "Panambi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pântano Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4239,
                Nome = "Pântano Grande",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Paraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4240,
                Nome = "Paraí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Paraíso do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4241,
                Nome = "Paraíso do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pareci Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4242,
                Nome = "Pareci Novo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Parobé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4243,
                Nome = "Parobé",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Passa Sete
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4244,
                Nome = "Passa Sete",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Passo do Sobrado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4245,
                Nome = "Passo do Sobrado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Passo Fundo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4246,
                Nome = "Passo Fundo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Paulo Bento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4247,
                Nome = "Paulo Bento",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Paverama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4248,
                Nome = "Paverama",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pedras Altas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4249,
                Nome = "Pedras Altas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pedro Osório
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4250,
                Nome = "Pedro Osório",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pejuçara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4251,
                Nome = "Pejuçara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pelotas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4252,
                Nome = "Pelotas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Picada Café
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4253,
                Nome = "Picada Café",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pinhal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4254,
                Nome = "Pinhal",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pinhal da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4255,
                Nome = "Pinhal da Serra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pinhal Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4256,
                Nome = "Pinhal Grande",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pinheirinho do Vale
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4257,
                Nome = "Pinheirinho do Vale",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pinheiro Machado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4258,
                Nome = "Pinheiro Machado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pirapó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4259,
                Nome = "Pirapó",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Piratini
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4260,
                Nome = "Piratini",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Planalto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4261,
                Nome = "Planalto",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Poço das Antas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4262,
                Nome = "Poço das Antas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pontão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4263,
                Nome = "Pontão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ponte Preta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4264,
                Nome = "Ponte Preta",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Portão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4265,
                Nome = "Portão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Porto Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4266,
                Nome = "Porto Alegre",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Porto Lucena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4267,
                Nome = "Porto Lucena",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Porto Mauá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4268,
                Nome = "Porto Mauá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Porto Vera Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4269,
                Nome = "Porto Vera Cruz",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Porto Xavier
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4270,
                Nome = "Porto Xavier",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Pouso Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4271,
                Nome = "Pouso Novo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Presidente Lucena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4272,
                Nome = "Presidente Lucena",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Progresso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4273,
                Nome = "Progresso",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Protásio Alves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4274,
                Nome = "Protásio Alves",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Putinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4275,
                Nome = "Putinga",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Quaraí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4276,
                Nome = "Quaraí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Quatro Irmãos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4277,
                Nome = "Quatro Irmãos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Quevedos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4278,
                Nome = "Quevedos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Quinze de Novembro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4279,
                Nome = "Quinze de Novembro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Redentora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4280,
                Nome = "Redentora",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Relvado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4281,
                Nome = "Relvado",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Restinga Seca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4282,
                Nome = "Restinga Seca",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rio dos Índios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4283,
                Nome = "Rio dos Índios",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rio Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4284,
                Nome = "Rio Grande",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rio Pardo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4285,
                Nome = "Rio Pardo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Riozinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4286,
                Nome = "Riozinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Roca Sales
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4287,
                Nome = "Roca Sales",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rodeio Bonito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4288,
                Nome = "Rodeio Bonito",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rolador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4289,
                Nome = "Rolador",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rolante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4290,
                Nome = "Rolante",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ronda Alta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4291,
                Nome = "Ronda Alta",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rondinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4292,
                Nome = "Rondinha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Roque Gonzales
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4293,
                Nome = "Roque Gonzales",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Rosário do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4294,
                Nome = "Rosário do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sagrada Família
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4295,
                Nome = "Sagrada Família",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Saldanha Marinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4296,
                Nome = "Saldanha Marinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Salto do Jacuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4297,
                Nome = "Salto do Jacuí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Salvador das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4298,
                Nome = "Salvador das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Salvador do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4299,
                Nome = "Salvador do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sananduva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4300,
                Nome = "Sananduva",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Bárbara do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4301,
                Nome = "Santa Bárbara do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Cecília do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4302,
                Nome = "Santa Cecília do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Clara do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4303,
                Nome = "Santa Clara do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Cruz do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4304,
                Nome = "Santa Cruz do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Margarida do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4305,
                Nome = "Santa Margarida do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Maria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4306,
                Nome = "Santa Maria",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Maria do Herval
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4307,
                Nome = "Santa Maria do Herval",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Rosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4308,
                Nome = "Santa Rosa",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Tereza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4309,
                Nome = "Santa Tereza",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santa Vitória do Palmar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4310,
                Nome = "Santa Vitória do Palmar",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santana da Boa Vista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4311,
                Nome = "Santana da Boa Vista",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santana do Livramento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4312,
                Nome = "Santana do Livramento",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santiago
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4313,
                Nome = "Santiago",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Ângelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4314,
                Nome = "Santo Ângelo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Antônio da Patrulha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4315,
                Nome = "Santo Antônio da Patrulha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Antônio das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4316,
                Nome = "Santo Antônio das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Antônio do Palma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4317,
                Nome = "Santo Antônio do Palma",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Antônio do Planalto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4318,
                Nome = "Santo Antônio do Planalto",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Augusto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4319,
                Nome = "Santo Augusto",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Cristo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4320,
                Nome = "Santo Cristo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Santo Expedito do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4321,
                Nome = "Santo Expedito do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Borja
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4322,
                Nome = "São Borja",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Domingos do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4323,
                Nome = "São Domingos do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Francisco de Assis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4324,
                Nome = "São Francisco de Assis",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Francisco de Paula
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4325,
                Nome = "São Francisco de Paula",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Gabriel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4326,
                Nome = "São Gabriel",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Jerônimo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4327,
                Nome = "São Jerônimo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São João da Urtiga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4328,
                Nome = "São João da Urtiga",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São João do Polêsine
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4329,
                Nome = "São João do Polêsine",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Jorge
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4330,
                Nome = "São Jorge",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4331,
                Nome = "São José das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José do Herval
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4332,
                Nome = "São José do Herval",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José do Hortêncio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4333,
                Nome = "São José do Hortêncio",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José do Inhacorá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4334,
                Nome = "São José do Inhacorá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4335,
                Nome = "São José do Norte",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José do Ouro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4336,
                Nome = "São José do Ouro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4337,
                Nome = "São José do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São José dos Ausentes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4338,
                Nome = "São José dos Ausentes",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Leopoldo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4339,
                Nome = "São Leopoldo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Lourenço do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4340,
                Nome = "São Lourenço do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Luiz Gonzaga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4341,
                Nome = "São Luiz Gonzaga",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Marcos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4342,
                Nome = "São Marcos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Martinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4343,
                Nome = "São Martinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Martinho da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4344,
                Nome = "São Martinho da Serra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Miguel das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4345,
                Nome = "São Miguel das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Nicolau
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4346,
                Nome = "São Nicolau",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Paulo das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4347,
                Nome = "São Paulo das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Pedro da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4348,
                Nome = "São Pedro da Serra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Pedro das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4349,
                Nome = "São Pedro das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Pedro do Butiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4350,
                Nome = "São Pedro do Butiá",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Pedro do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4351,
                Nome = "São Pedro do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Sebastião do Caí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4352,
                Nome = "São Sebastião do Caí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Sepé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4353,
                Nome = "São Sepé",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Valentim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4354,
                Nome = "São Valentim",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Valentim do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4355,
                Nome = "São Valentim do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Valério do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4356,
                Nome = "São Valério do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Vendelino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4357,
                Nome = "São Vendelino",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: São Vicente do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4358,
                Nome = "São Vicente do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sapiranga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4359,
                Nome = "Sapiranga",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sapucaia do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4360,
                Nome = "Sapucaia do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sarandi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4361,
                Nome = "Sarandi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Seberi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4362,
                Nome = "Seberi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sede Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4363,
                Nome = "Sede Nova",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Segredo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4364,
                Nome = "Segredo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Selbach
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4365,
                Nome = "Selbach",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Senador Salgado Filho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4366,
                Nome = "Senador Salgado Filho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sentinela do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4367,
                Nome = "Sentinela do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Serafina Corrêa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4368,
                Nome = "Serafina Corrêa",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sério
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4369,
                Nome = "Sério",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sertão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4370,
                Nome = "Sertão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sertão Santana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4371,
                Nome = "Sertão Santana",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sete de Setembro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4372,
                Nome = "Sete de Setembro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Severiano de Almeida
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4373,
                Nome = "Severiano de Almeida",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Silveira Martins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4374,
                Nome = "Silveira Martins",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sinimbu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4375,
                Nome = "Sinimbu",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Sobradinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4376,
                Nome = "Sobradinho",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Soledade
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4377,
                Nome = "Soledade",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tabaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4378,
                Nome = "Tabaí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tapejara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4379,
                Nome = "Tapejara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tapera
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4380,
                Nome = "Tapera",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tapes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4381,
                Nome = "Tapes",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Taquara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4382,
                Nome = "Taquara",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Taquari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4383,
                Nome = "Taquari",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Taquaruçu do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4384,
                Nome = "Taquaruçu do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tavares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4385,
                Nome = "Tavares",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tenente Portela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4386,
                Nome = "Tenente Portela",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Terra de Areia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4387,
                Nome = "Terra de Areia",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Teutônia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4388,
                Nome = "Teutônia",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tio Hugo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4389,
                Nome = "Tio Hugo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tiradentes do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4390,
                Nome = "Tiradentes do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Toropi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4391,
                Nome = "Toropi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Torres
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4392,
                Nome = "Torres",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tramandaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4393,
                Nome = "Tramandaí",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Travesseiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4394,
                Nome = "Travesseiro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Três Arroios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4395,
                Nome = "Três Arroios",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Três Cachoeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4396,
                Nome = "Três Cachoeiras",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Três Coroas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4397,
                Nome = "Três Coroas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Três de Maio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4398,
                Nome = "Três de Maio",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Três Forquilhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4399,
                Nome = "Três Forquilhas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Três Palmeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4400,
                Nome = "Três Palmeiras",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Três Passos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4401,
                Nome = "Três Passos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Trindade do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4402,
                Nome = "Trindade do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Triunfo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4403,
                Nome = "Triunfo",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tucunduva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4404,
                Nome = "Tucunduva",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tunas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4405,
                Nome = "Tunas",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tupanci do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4406,
                Nome = "Tupanci do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tupanciretã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4407,
                Nome = "Tupanciretã",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tupandi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4408,
                Nome = "Tupandi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Tuparendi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4409,
                Nome = "Tuparendi",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Turuçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4410,
                Nome = "Turuçu",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Ubiretama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4411,
                Nome = "Ubiretama",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: União da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4412,
                Nome = "União da Serra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Unistalda
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4413,
                Nome = "Unistalda",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Uruguaiana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4414,
                Nome = "Uruguaiana",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vacaria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4415,
                Nome = "Vacaria",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vale do Sol
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4416,
                Nome = "Vale do Sol",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vale Real
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4417,
                Nome = "Vale Real",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vale Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4418,
                Nome = "Vale Verde",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vanini
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4419,
                Nome = "Vanini",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Venâncio Aires
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4420,
                Nome = "Venâncio Aires",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vera Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4421,
                Nome = "Vera Cruz",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Veranópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4422,
                Nome = "Veranópolis",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vespasiano Correa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4423,
                Nome = "Vespasiano Correa",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Viadutos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4424,
                Nome = "Viadutos",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Viamão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4425,
                Nome = "Viamão",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vicente Dutra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4426,
                Nome = "Vicente Dutra",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Victor Graeff
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4427,
                Nome = "Victor Graeff",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vila Flores
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4428,
                Nome = "Vila Flores",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vila Lângaro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4429,
                Nome = "Vila Lângaro",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vila Maria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4430,
                Nome = "Vila Maria",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vila Nova do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4431,
                Nome = "Vila Nova do Sul",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vista Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4432,
                Nome = "Vista Alegre",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vista Alegre do Prata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4433,
                Nome = "Vista Alegre do Prata",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vista Gaúcha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4434,
                Nome = "Vista Gaúcha",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Vitória das Missões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4435,
                Nome = "Vitória das Missões",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Westfalia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4436,
                Nome = "Westfalia",
                Situacao = "Ativo",
                UF = "RS"
            });

            // cidade: Xangri lá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4437,
                Nome = "Xangri lá",
                Situacao = "Ativo",
                UF = "RS"
            });


            await _context.SaveChangesAsync();
        }
    }
}
