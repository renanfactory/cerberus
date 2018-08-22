using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class SC
    {
        private readonly ApplicationDbContext _context;

        public SC(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: SC
            //----------------------------------------------------

            // cidade: Abdon Batista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4438,
                Nome = "Abdon Batista",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Abelardo Luz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4439,
                Nome = "Abelardo Luz",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Agrolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4440,
                Nome = "Agrolândia",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Agronômica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4441,
                Nome = "Agronômica",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Água Doce
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4442,
                Nome = "Água Doce",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Águas de Chapecó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4443,
                Nome = "Águas de Chapecó",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Águas Frias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4444,
                Nome = "Águas Frias",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Águas Mornas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4445,
                Nome = "Águas Mornas",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Alfredo Wagner
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4446,
                Nome = "Alfredo Wagner",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Alto Bela Vista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4447,
                Nome = "Alto Bela Vista",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Anchieta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4448,
                Nome = "Anchieta",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Angelina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4449,
                Nome = "Angelina",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Anita Garibaldi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4450,
                Nome = "Anita Garibaldi",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Anitápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4451,
                Nome = "Anitápolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Antônio Carlos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4452,
                Nome = "Antônio Carlos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Apiúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4453,
                Nome = "Apiúna",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Arabutã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4454,
                Nome = "Arabutã",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Araquari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4455,
                Nome = "Araquari",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Araranguá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4456,
                Nome = "Araranguá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Armazém
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4457,
                Nome = "Armazém",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Arroio Trinta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4458,
                Nome = "Arroio Trinta",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Arvoredo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4459,
                Nome = "Arvoredo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ascurra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4460,
                Nome = "Ascurra",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Atalanta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4461,
                Nome = "Atalanta",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Aurora
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4462,
                Nome = "Aurora",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Balneário Arroio do Silva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4463,
                Nome = "Balneário Arroio do Silva",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Balneário Barra do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4464,
                Nome = "Balneário Barra do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Balneário Camboriú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4465,
                Nome = "Balneário Camboriú",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Balneário Gaivota
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4466,
                Nome = "Balneário Gaivota",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bandeirante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4467,
                Nome = "Bandeirante",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Barra Bonita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4468,
                Nome = "Barra Bonita",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Barra Velha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4469,
                Nome = "Barra Velha",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bela Vista do Toldo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4470,
                Nome = "Bela Vista do Toldo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Belmonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4471,
                Nome = "Belmonte",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Benedito Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4472,
                Nome = "Benedito Novo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Biguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4473,
                Nome = "Biguaçu",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Blumenau
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4474,
                Nome = "Blumenau",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bocaina do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4475,
                Nome = "Bocaina do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bom Jardim da Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4476,
                Nome = "Bom Jardim da Serra",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bom Jesus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4477,
                Nome = "Bom Jesus",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bom Jesus do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4478,
                Nome = "Bom Jesus do Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bom Retiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4479,
                Nome = "Bom Retiro",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Bombinhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4480,
                Nome = "Bombinhas",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Botuverá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4481,
                Nome = "Botuverá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Braço do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4482,
                Nome = "Braço do Norte",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Braço do Trombudo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4483,
                Nome = "Braço do Trombudo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Brunópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4484,
                Nome = "Brunópolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Brusque
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4485,
                Nome = "Brusque",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Caçador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4486,
                Nome = "Caçador",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Caibi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4487,
                Nome = "Caibi",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Calmon
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4488,
                Nome = "Calmon",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Camboriú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4489,
                Nome = "Camboriú",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Campo Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4490,
                Nome = "Campo Alegre",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Campo Belo do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4491,
                Nome = "Campo Belo do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Campo Erê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4492,
                Nome = "Campo Erê",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Campos Novos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4493,
                Nome = "Campos Novos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Canelinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4494,
                Nome = "Canelinha",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Canoinhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4495,
                Nome = "Canoinhas",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Capão Alto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4496,
                Nome = "Capão Alto",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Capinzal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4497,
                Nome = "Capinzal",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Capivari de Baixo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4498,
                Nome = "Capivari de Baixo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Catanduvas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4499,
                Nome = "Catanduvas",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Caxambu do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4500,
                Nome = "Caxambu do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Celso Ramos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4501,
                Nome = "Celso Ramos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Cerro Negro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4502,
                Nome = "Cerro Negro",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Chapadão do Lageado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4503,
                Nome = "Chapadão do Lageado",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Chapecó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4504,
                Nome = "Chapecó",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Cocal do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4505,
                Nome = "Cocal do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Concórdia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4506,
                Nome = "Concórdia",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Cordilheira Alta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4507,
                Nome = "Cordilheira Alta",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Coronel Freitas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4508,
                Nome = "Coronel Freitas",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Coronel Martins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4509,
                Nome = "Coronel Martins",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Correia Pinto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4510,
                Nome = "Correia Pinto",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Corupá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4511,
                Nome = "Corupá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Criciúma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4512,
                Nome = "Criciúma",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Cunha Porã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4513,
                Nome = "Cunha Porã",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Cunhataí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4514,
                Nome = "Cunhataí",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Curitibanos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4515,
                Nome = "Curitibanos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Descanso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4516,
                Nome = "Descanso",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Dionísio Cerqueira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4517,
                Nome = "Dionísio Cerqueira",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Dona Emma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4518,
                Nome = "Dona Emma",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Doutor Pedrinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4519,
                Nome = "Doutor Pedrinho",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Entre Rios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4520,
                Nome = "Entre Rios",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ermo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4521,
                Nome = "Ermo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Erval Velho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4522,
                Nome = "Erval Velho",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Faxinal dos Guedes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4523,
                Nome = "Faxinal dos Guedes",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Flor do Sertão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4524,
                Nome = "Flor do Sertão",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Florianópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4525,
                Nome = "Florianópolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Formosa do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4526,
                Nome = "Formosa do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Forquilhinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4527,
                Nome = "Forquilhinha",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Fraiburgo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4528,
                Nome = "Fraiburgo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Frei Rogério
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4529,
                Nome = "Frei Rogério",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Galvão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4530,
                Nome = "Galvão",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Garopaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4531,
                Nome = "Garopaba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Garuva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4532,
                Nome = "Garuva",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Gaspar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4533,
                Nome = "Gaspar",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Governador Celso Ramos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4534,
                Nome = "Governador Celso Ramos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Grão Pará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4535,
                Nome = "Grão Pará",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Gravatal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4536,
                Nome = "Gravatal",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Guabiruba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4537,
                Nome = "Guabiruba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Guaraciaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4538,
                Nome = "Guaraciaba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Guaramirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4539,
                Nome = "Guaramirim",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Guarujá do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4540,
                Nome = "Guarujá do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Guatambu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4541,
                Nome = "Guatambu",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Herval d Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4542,
                Nome = "Herval d Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ibiam
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4543,
                Nome = "Ibiam",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ibicaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4544,
                Nome = "Ibicaré",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ibirama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4545,
                Nome = "Ibirama",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Içara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4546,
                Nome = "Içara",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ilhota
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4547,
                Nome = "Ilhota",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Imaruí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4548,
                Nome = "Imaruí",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Imbituba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4549,
                Nome = "Imbituba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Imbuia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4550,
                Nome = "Imbuia",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Indaial
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4551,
                Nome = "Indaial",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Iomerê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4552,
                Nome = "Iomerê",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ipira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4553,
                Nome = "Ipira",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Iporã do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4554,
                Nome = "Iporã do Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ipuaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4555,
                Nome = "Ipuaçu",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ipumirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4556,
                Nome = "Ipumirim",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Iraceminha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4557,
                Nome = "Iraceminha",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Irani
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4558,
                Nome = "Irani",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Irati
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4559,
                Nome = "Irati",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Irineópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4560,
                Nome = "Irineópolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Itá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4561,
                Nome = "Itá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Itaiópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4562,
                Nome = "Itaiópolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Itajaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4563,
                Nome = "Itajaí",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Itapema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4564,
                Nome = "Itapema",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Itapiranga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4565,
                Nome = "Itapiranga",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Itapoá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4566,
                Nome = "Itapoá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ituporanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4567,
                Nome = "Ituporanga",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Jaborá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4568,
                Nome = "Jaborá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Jacinto Machado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4569,
                Nome = "Jacinto Machado",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Jaguaruna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4570,
                Nome = "Jaguaruna",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Jaraguá do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4571,
                Nome = "Jaraguá do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Jardinópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4572,
                Nome = "Jardinópolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Joaçaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4573,
                Nome = "Joaçaba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Joinville
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4574,
                Nome = "Joinville",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: José Boiteux
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4575,
                Nome = "José Boiteux",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Jupiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4576,
                Nome = "Jupiá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Lacerdópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4577,
                Nome = "Lacerdópolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Lages
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4578,
                Nome = "Lages",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Laguna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4579,
                Nome = "Laguna",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Lajeado Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4580,
                Nome = "Lajeado Grande",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Laurentino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4581,
                Nome = "Laurentino",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Lauro Müller
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4582,
                Nome = "Lauro Müller",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Lebon Régis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4583,
                Nome = "Lebon Régis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Leoberto Leal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4584,
                Nome = "Leoberto Leal",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Lindóia do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4585,
                Nome = "Lindóia do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Lontras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4586,
                Nome = "Lontras",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Luís Alves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4587,
                Nome = "Luís Alves",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Luzerna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4588,
                Nome = "Luzerna",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Macieira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4589,
                Nome = "Macieira",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Mafra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4590,
                Nome = "Mafra",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Major Gercino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4591,
                Nome = "Major Gercino",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Major Vieira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4592,
                Nome = "Major Vieira",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Maracajá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4593,
                Nome = "Maracajá",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Maravilha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4594,
                Nome = "Maravilha",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Marema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4595,
                Nome = "Marema",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Massaranduba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4596,
                Nome = "Massaranduba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Matos Costa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4597,
                Nome = "Matos Costa",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Meleiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4598,
                Nome = "Meleiro",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Mirim Doce
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4599,
                Nome = "Mirim Doce",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Modelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4600,
                Nome = "Modelo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Mondaí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4601,
                Nome = "Mondaí",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Monte Carlo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4602,
                Nome = "Monte Carlo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Monte Castelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4603,
                Nome = "Monte Castelo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Morro da Fumaça
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4604,
                Nome = "Morro da Fumaça",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Morro Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4605,
                Nome = "Morro Grande",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Navegantes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4606,
                Nome = "Navegantes",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Nova Erechim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4607,
                Nome = "Nova Erechim",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Nova Itaberaba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4608,
                Nome = "Nova Itaberaba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Nova Trento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4609,
                Nome = "Nova Trento",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Nova Veneza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4610,
                Nome = "Nova Veneza",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Novo Horizonte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4611,
                Nome = "Novo Horizonte",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Orleans
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4612,
                Nome = "Orleans",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Otacílio Costa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4613,
                Nome = "Otacílio Costa",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ouro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4614,
                Nome = "Ouro",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ouro Verde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4615,
                Nome = "Ouro Verde",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Paial
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4616,
                Nome = "Paial",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Painel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4617,
                Nome = "Painel",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Palhoça
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4618,
                Nome = "Palhoça",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Palma Sola
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4619,
                Nome = "Palma Sola",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Palmeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4620,
                Nome = "Palmeira",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Palmitos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4621,
                Nome = "Palmitos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Papanduva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4622,
                Nome = "Papanduva",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Paraíso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4623,
                Nome = "Paraíso",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Passo de Torres
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4624,
                Nome = "Passo de Torres",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Passos Maia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4625,
                Nome = "Passos Maia",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Paulo Lopes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4626,
                Nome = "Paulo Lopes",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Pedras Grandes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4627,
                Nome = "Pedras Grandes",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Penha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4628,
                Nome = "Penha",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Peritiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4629,
                Nome = "Peritiba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Petrolândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4630,
                Nome = "Petrolândia",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Piçarras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4631,
                Nome = "Piçarras",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Pinhalzinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4632,
                Nome = "Pinhalzinho",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Pinheiro Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4633,
                Nome = "Pinheiro Preto",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Piratuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4634,
                Nome = "Piratuba",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Planalto Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4635,
                Nome = "Planalto Alegre",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Pomerode
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4636,
                Nome = "Pomerode",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ponte Alta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4637,
                Nome = "Ponte Alta",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ponte Alta do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4638,
                Nome = "Ponte Alta do Norte",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Ponte Serrada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4639,
                Nome = "Ponte Serrada",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Porto Belo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4640,
                Nome = "Porto Belo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Porto União
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4641,
                Nome = "Porto União",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Pouso Redondo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4642,
                Nome = "Pouso Redondo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Praia Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4643,
                Nome = "Praia Grande",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Presidente Castelo Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4644,
                Nome = "Presidente Castelo Branco",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Presidente Getúlio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4645,
                Nome = "Presidente Getúlio",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Presidente Nereu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4646,
                Nome = "Presidente Nereu",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Princesa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4647,
                Nome = "Princesa",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Quilombo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4648,
                Nome = "Quilombo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rancho Queimado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4649,
                Nome = "Rancho Queimado",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio das Antas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4650,
                Nome = "Rio das Antas",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio do Campo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4651,
                Nome = "Rio do Campo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4652,
                Nome = "Rio do Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4653,
                Nome = "Rio do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio dos Cedros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4654,
                Nome = "Rio dos Cedros",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio Fortuna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4655,
                Nome = "Rio Fortuna",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio Negrinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4656,
                Nome = "Rio Negrinho",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rio Rufino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4657,
                Nome = "Rio Rufino",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Riqueza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4658,
                Nome = "Riqueza",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Rodeio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4659,
                Nome = "Rodeio",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Romelândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4660,
                Nome = "Romelândia",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Salete
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4661,
                Nome = "Salete",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Saltinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4662,
                Nome = "Saltinho",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Salto Veloso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4663,
                Nome = "Salto Veloso",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Sangão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4664,
                Nome = "Sangão",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santa Cecília
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4665,
                Nome = "Santa Cecília",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santa Helena
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4666,
                Nome = "Santa Helena",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santa Rosa de Lima
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4667,
                Nome = "Santa Rosa de Lima",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santa Rosa do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4668,
                Nome = "Santa Rosa do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santa Terezinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4669,
                Nome = "Santa Terezinha",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santa Terezinha do Progresso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4670,
                Nome = "Santa Terezinha do Progresso",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santiago do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4671,
                Nome = "Santiago do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Santo Amaro da Imperatriz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4672,
                Nome = "Santo Amaro da Imperatriz",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Bento do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4673,
                Nome = "São Bento do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Bernardino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4674,
                Nome = "São Bernardino",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Bonifácio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4675,
                Nome = "São Bonifácio",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Carlos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4676,
                Nome = "São Carlos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Cristóvão  do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4677,
                Nome = "São Cristóvão  do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Domingos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4678,
                Nome = "São Domingos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Francisco do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4679,
                Nome = "São Francisco do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São João Batista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4680,
                Nome = "São João Batista",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São João do Itaperiú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4681,
                Nome = "São João do Itaperiú",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São João do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4682,
                Nome = "São João do Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São João do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4683,
                Nome = "São João do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Joaquim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4684,
                Nome = "São Joaquim",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São José
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4685,
                Nome = "São José",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São José do Cedro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4686,
                Nome = "São José do Cedro",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São José do Cerrito
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4687,
                Nome = "São José do Cerrito",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Lourenço do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4688,
                Nome = "São Lourenço do Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Ludgero
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4689,
                Nome = "São Ludgero",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Martinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4690,
                Nome = "São Martinho",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Miguel da Boa Vista
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4691,
                Nome = "São Miguel da Boa Vista",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Miguel do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4692,
                Nome = "São Miguel do Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: São Pedro de Alcântara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4693,
                Nome = "São Pedro de Alcântara",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Saudades
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4694,
                Nome = "Saudades",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Schroeder
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4695,
                Nome = "Schroeder",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Seara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4696,
                Nome = "Seara",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Serra Alta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4697,
                Nome = "Serra Alta",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Siderópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4698,
                Nome = "Siderópolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Sombrio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4699,
                Nome = "Sombrio",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Sul Brasil
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4700,
                Nome = "Sul Brasil",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Taió
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4701,
                Nome = "Taió",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Tangará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4702,
                Nome = "Tangará",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Tigrinhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4703,
                Nome = "Tigrinhos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Tijucas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4704,
                Nome = "Tijucas",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Timbé do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4705,
                Nome = "Timbé do Sul",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Timbó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4706,
                Nome = "Timbó",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Timbó Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4707,
                Nome = "Timbó Grande",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Três Barras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4708,
                Nome = "Três Barras",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Treviso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4709,
                Nome = "Treviso",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Treze de Maio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4710,
                Nome = "Treze de Maio",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Treze Tílias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4711,
                Nome = "Treze Tílias",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Trombudo Central
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4712,
                Nome = "Trombudo Central",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Tubarão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4713,
                Nome = "Tubarão",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Tunápolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4714,
                Nome = "Tunápolis",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Turvo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4715,
                Nome = "Turvo",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: União do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4716,
                Nome = "União do Oeste",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Urubici
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4717,
                Nome = "Urubici",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Urupema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4718,
                Nome = "Urupema",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Urussanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4719,
                Nome = "Urussanga",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Vargeão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4720,
                Nome = "Vargeão",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Vargem
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4721,
                Nome = "Vargem",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Vargem Bonita
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4722,
                Nome = "Vargem Bonita",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Vidal Ramos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4723,
                Nome = "Vidal Ramos",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Videira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4724,
                Nome = "Videira",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Vitor Meireles
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4725,
                Nome = "Vitor Meireles",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Witmarsum
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4726,
                Nome = "Witmarsum",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Xanxerê
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4727,
                Nome = "Xanxerê",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Xavantina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4728,
                Nome = "Xavantina",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Xaxim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4729,
                Nome = "Xaxim",
                Situacao = "Ativo",
                UF = "SC"
            });

            // cidade: Zortéa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4730,
                Nome = "Zortéa",
                Situacao = "Ativo",
                UF = "SC"
            });


            await _context.SaveChangesAsync();
        }
    }
}
