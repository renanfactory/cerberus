using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class SP
    {
        private readonly ApplicationDbContext _context;

        public SP(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: SP
            //----------------------------------------------------

            // cidade: Adamantina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4806,
                Nome = "Adamantina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Adolfo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4807,
                Nome = "Adolfo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Aguaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4808,
                Nome = "Aguaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Águas da Prata
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4809,
                Nome = "Águas da Prata",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Águas de Lindóia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4810,
                Nome = "Águas de Lindóia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Águas de Santa Bárbara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4811,
                Nome = "Águas de Santa Bárbara",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Águas de São Pedro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4812,
                Nome = "Águas de São Pedro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Agudos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4813,
                Nome = "Agudos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Alambari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4814,
                Nome = "Alambari",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Alfredo Marcondes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4815,
                Nome = "Alfredo Marcondes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Altair
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4816,
                Nome = "Altair",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Altinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4817,
                Nome = "Altinópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Alto Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4818,
                Nome = "Alto Alegre",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Alumínio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4819,
                Nome = "Alumínio",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Álvares Florence
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4820,
                Nome = "Álvares Florence",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Álvares Machado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4821,
                Nome = "Álvares Machado",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Álvaro de Carvalho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4822,
                Nome = "Álvaro de Carvalho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Alvinlândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4823,
                Nome = "Alvinlândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Americana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4824,
                Nome = "Americana",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Américo Brasiliense
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4825,
                Nome = "Américo Brasiliense",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Américo de Campos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4826,
                Nome = "Américo de Campos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Amparo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4827,
                Nome = "Amparo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Analândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4828,
                Nome = "Analândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Andradina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4829,
                Nome = "Andradina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Angatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4830,
                Nome = "Angatuba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Anhembi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4831,
                Nome = "Anhembi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Anhumas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4832,
                Nome = "Anhumas",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Aparecida
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4833,
                Nome = "Aparecida",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Aparecida D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4834,
                Nome = "Aparecida D Oeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Apiaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4835,
                Nome = "Apiaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Araçariguama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4836,
                Nome = "Araçariguama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Araçatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4837,
                Nome = "Araçatuba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Araçoiaba da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4838,
                Nome = "Araçoiaba da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Aramina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4839,
                Nome = "Aramina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Arandu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4840,
                Nome = "Arandu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Arapeí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4841,
                Nome = "Arapeí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Araraquara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4842,
                Nome = "Araraquara",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Araras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4843,
                Nome = "Araras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Arco Íris
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4844,
                Nome = "Arco Íris",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Arealva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4845,
                Nome = "Arealva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Areias
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4846,
                Nome = "Areias",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Areiópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4847,
                Nome = "Areiópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ariranha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4848,
                Nome = "Ariranha",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Artur Nogueira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4849,
                Nome = "Artur Nogueira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Arujá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4850,
                Nome = "Arujá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Aspásia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4851,
                Nome = "Aspásia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Assis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4852,
                Nome = "Assis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Atibaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4853,
                Nome = "Atibaia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Auriflama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4854,
                Nome = "Auriflama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Avaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4855,
                Nome = "Avaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Avanhandava
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4856,
                Nome = "Avanhandava",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Avaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4857,
                Nome = "Avaré",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bady Bassitt
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4858,
                Nome = "Bady Bassitt",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Balbinos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4859,
                Nome = "Balbinos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bálsamo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4860,
                Nome = "Bálsamo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bananal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4861,
                Nome = "Bananal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barão de Antonina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4862,
                Nome = "Barão de Antonina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barbosa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4863,
                Nome = "Barbosa",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bariri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4864,
                Nome = "Bariri",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barra Bonita
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4865,
                Nome = "Barra Bonita",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barra do Chapéu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4866,
                Nome = "Barra do Chapéu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barra do Turvo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4867,
                Nome = "Barra do Turvo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barretos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4868,
                Nome = "Barretos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barrinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4869,
                Nome = "Barrinha",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Barueri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4870,
                Nome = "Barueri",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bastos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4871,
                Nome = "Bastos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Batatais
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4872,
                Nome = "Batatais",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bauru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4873,
                Nome = "Bauru",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bebedouro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4874,
                Nome = "Bebedouro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bento de Abreu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4875,
                Nome = "Bento de Abreu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bernardino de Campos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4876,
                Nome = "Bernardino de Campos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bertioga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4877,
                Nome = "Bertioga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bilac
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4878,
                Nome = "Bilac",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Birigüi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4879,
                Nome = "Birigüi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Biritiba Mirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4880,
                Nome = "Biritiba Mirim",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Boa Esperança do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4881,
                Nome = "Boa Esperança do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bocaina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4882,
                Nome = "Bocaina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bofete
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4883,
                Nome = "Bofete",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Boituva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4884,
                Nome = "Boituva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bom Jesus dos Perdões
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4885,
                Nome = "Bom Jesus dos Perdões",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bom Sucesso de Itararé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4886,
                Nome = "Bom Sucesso de Itararé",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Borá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4887,
                Nome = "Borá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Boracéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4888,
                Nome = "Boracéia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Borborema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4889,
                Nome = "Borborema",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Borebi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4890,
                Nome = "Borebi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Botucatu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4891,
                Nome = "Botucatu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Bragança Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4892,
                Nome = "Bragança Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Braúna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4893,
                Nome = "Braúna",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Brejo Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4894,
                Nome = "Brejo Alegre",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Brodósqui
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4895,
                Nome = "Brodósqui",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Brotas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4896,
                Nome = "Brotas",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Buri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4897,
                Nome = "Buri",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Buritama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4898,
                Nome = "Buritama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Buritizal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4899,
                Nome = "Buritizal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cabrália Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4900,
                Nome = "Cabrália Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cabreúva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4901,
                Nome = "Cabreúva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Caçapava
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4902,
                Nome = "Caçapava",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cachoeira Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4903,
                Nome = "Cachoeira Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Caconde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4904,
                Nome = "Caconde",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cafelândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4905,
                Nome = "Cafelândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Caiabu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4906,
                Nome = "Caiabu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Caieiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4907,
                Nome = "Caieiras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Caiuá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4908,
                Nome = "Caiuá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cajamar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4909,
                Nome = "Cajamar",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cajati
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4910,
                Nome = "Cajati",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cajobi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4911,
                Nome = "Cajobi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cajuru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4912,
                Nome = "Cajuru",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Campina do Monte Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4913,
                Nome = "Campina do Monte Alegre",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Campinas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4914,
                Nome = "Campinas",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Campo Limpo Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4915,
                Nome = "Campo Limpo Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Campos do Jordão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4916,
                Nome = "Campos do Jordão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Campos Novos Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4917,
                Nome = "Campos Novos Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cananéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4918,
                Nome = "Cananéia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Canas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4919,
                Nome = "Canas",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cândido Mota
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4920,
                Nome = "Cândido Mota",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cândido Rodrigues
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4921,
                Nome = "Cândido Rodrigues",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Canitar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4922,
                Nome = "Canitar",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Capão Bonito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4923,
                Nome = "Capão Bonito",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Capela do Alto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4924,
                Nome = "Capela do Alto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Capivari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4925,
                Nome = "Capivari",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Caraguatatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4926,
                Nome = "Caraguatatuba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Carapicuíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4927,
                Nome = "Carapicuíba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cardoso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4928,
                Nome = "Cardoso",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Casa Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4929,
                Nome = "Casa Branca",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cássia dos Coqueiros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4930,
                Nome = "Cássia dos Coqueiros",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Castilho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4931,
                Nome = "Castilho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Catanduva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4932,
                Nome = "Catanduva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Catiguá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4933,
                Nome = "Catiguá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cedral
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4934,
                Nome = "Cedral",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cerqueira César
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4935,
                Nome = "Cerqueira César",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cerquilho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4936,
                Nome = "Cerquilho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cesário Lange
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4937,
                Nome = "Cesário Lange",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Charqueada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4938,
                Nome = "Charqueada",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Chavantes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4939,
                Nome = "Chavantes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Clementina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4940,
                Nome = "Clementina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Colina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4941,
                Nome = "Colina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Colômbia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4942,
                Nome = "Colômbia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Conchal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4943,
                Nome = "Conchal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Conchas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4944,
                Nome = "Conchas",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cordeirópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4945,
                Nome = "Cordeirópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Coroados
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4946,
                Nome = "Coroados",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Coronel Macedo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4947,
                Nome = "Coronel Macedo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Corumbataí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4948,
                Nome = "Corumbataí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cosmópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4949,
                Nome = "Cosmópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cosmorama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4950,
                Nome = "Cosmorama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cotia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4951,
                Nome = "Cotia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cravinhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4952,
                Nome = "Cravinhos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cristais Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4953,
                Nome = "Cristais Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cruzália
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4954,
                Nome = "Cruzália",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cruzeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4955,
                Nome = "Cruzeiro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cubatão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4956,
                Nome = "Cubatão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Cunha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4957,
                Nome = "Cunha",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Descalvado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4958,
                Nome = "Descalvado",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Diadema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4959,
                Nome = "Diadema",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Dirce Reis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4960,
                Nome = "Dirce Reis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Divinolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4961,
                Nome = "Divinolândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Dobrada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4962,
                Nome = "Dobrada",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Dois Córregos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4963,
                Nome = "Dois Córregos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Dolcinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4964,
                Nome = "Dolcinópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Dourado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4965,
                Nome = "Dourado",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Dracena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4966,
                Nome = "Dracena",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Duartina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4967,
                Nome = "Duartina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Dumont
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4968,
                Nome = "Dumont",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Echaporã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4969,
                Nome = "Echaporã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Eldorado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4970,
                Nome = "Eldorado",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Elias Fausto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4971,
                Nome = "Elias Fausto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Elisiário
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4972,
                Nome = "Elisiário",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Embaúba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4973,
                Nome = "Embaúba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Embu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4974,
                Nome = "Embu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Embu Guaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4975,
                Nome = "Embu Guaçu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Emilianópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4976,
                Nome = "Emilianópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Engenheiro Coelho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4977,
                Nome = "Engenheiro Coelho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Espírito Santo do Pinhal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4978,
                Nome = "Espírito Santo do Pinhal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Espírito Santo do Turvo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4979,
                Nome = "Espírito Santo do Turvo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Estiva Gerbi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4980,
                Nome = "Estiva Gerbi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Estrela do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4981,
                Nome = "Estrela do Norte",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Estrela D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4982,
                Nome = "Estrela D Oeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Euclides da Cunha Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4983,
                Nome = "Euclides da Cunha Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Fartura
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4984,
                Nome = "Fartura",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Fernando Prestes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4985,
                Nome = "Fernando Prestes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Fernandópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4986,
                Nome = "Fernandópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Fernão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4987,
                Nome = "Fernão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ferraz de Vasconcelos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4988,
                Nome = "Ferraz de Vasconcelos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Flora Rica
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4989,
                Nome = "Flora Rica",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Floreal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4990,
                Nome = "Floreal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Flórida Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4991,
                Nome = "Flórida Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Florínia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4992,
                Nome = "Florínia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Franca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4993,
                Nome = "Franca",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Francisco Morato
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4994,
                Nome = "Francisco Morato",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Franco da Rocha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4995,
                Nome = "Franco da Rocha",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Gabriel Monteiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4996,
                Nome = "Gabriel Monteiro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Gália
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4997,
                Nome = "Gália",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Garça
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4998,
                Nome = "Garça",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Gastão Vidigal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 4999,
                Nome = "Gastão Vidigal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Gavião Peixoto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5000,
                Nome = "Gavião Peixoto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: General Salgado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5001,
                Nome = "General Salgado",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Getulina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5002,
                Nome = "Getulina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Glicério
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5003,
                Nome = "Glicério",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guaiçara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5004,
                Nome = "Guaiçara",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guaimbê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5005,
                Nome = "Guaimbê",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guaíra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5006,
                Nome = "Guaíra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guapiaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5007,
                Nome = "Guapiaçu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guapiara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5008,
                Nome = "Guapiara",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5009,
                Nome = "Guará",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guaraçaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5010,
                Nome = "Guaraçaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guaraci
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5011,
                Nome = "Guaraci",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guarani D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5012,
                Nome = "Guarani D Oeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guarantã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5013,
                Nome = "Guarantã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guararapes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5014,
                Nome = "Guararapes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guararema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5015,
                Nome = "Guararema",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guaratinguetá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5016,
                Nome = "Guaratinguetá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guareí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5017,
                Nome = "Guareí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guariba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5018,
                Nome = "Guariba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guarujá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5019,
                Nome = "Guarujá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guarulhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5020,
                Nome = "Guarulhos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guatapará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5021,
                Nome = "Guatapará",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Guzolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5022,
                Nome = "Guzolândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Herculândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5023,
                Nome = "Herculândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Holambra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5024,
                Nome = "Holambra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Hortolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5025,
                Nome = "Hortolândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iacanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5026,
                Nome = "Iacanga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iacri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5027,
                Nome = "Iacri",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iaras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5028,
                Nome = "Iaras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ibaté
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5029,
                Nome = "Ibaté",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ibirá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5030,
                Nome = "Ibirá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ibirarema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5031,
                Nome = "Ibirarema",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ibitinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5032,
                Nome = "Ibitinga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ibiúna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5033,
                Nome = "Ibiúna",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Icém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5034,
                Nome = "Icém",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iepê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5035,
                Nome = "Iepê",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Igaraçu do Tietê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5036,
                Nome = "Igaraçu do Tietê",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Igarapava
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5037,
                Nome = "Igarapava",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Igaratá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5038,
                Nome = "Igaratá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iguape
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5039,
                Nome = "Iguape",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ilha Comprida
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5040,
                Nome = "Ilha Comprida",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ilha Solteira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5041,
                Nome = "Ilha Solteira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ilhabela
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5042,
                Nome = "Ilhabela",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Indaiatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5043,
                Nome = "Indaiatuba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Indiana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5044,
                Nome = "Indiana",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Indiaporã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5045,
                Nome = "Indiaporã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Inúbia Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5046,
                Nome = "Inúbia Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ipaussu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5047,
                Nome = "Ipaussu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iperó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5048,
                Nome = "Iperó",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ipeúna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5049,
                Nome = "Ipeúna",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ipiguá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5050,
                Nome = "Ipiguá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iporanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5051,
                Nome = "Iporanga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ipuã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5052,
                Nome = "Ipuã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Iracemápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5053,
                Nome = "Iracemápolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Irapuã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5054,
                Nome = "Irapuã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Irapuru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5055,
                Nome = "Irapuru",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itaberá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5056,
                Nome = "Itaberá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5057,
                Nome = "Itaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itajobi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5058,
                Nome = "Itajobi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itaju
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5059,
                Nome = "Itaju",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itanhaém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5060,
                Nome = "Itanhaém",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itaóca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5061,
                Nome = "Itaóca",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapecerica da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5062,
                Nome = "Itapecerica da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapetininga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5063,
                Nome = "Itapetininga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapeva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5064,
                Nome = "Itapeva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapevi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5065,
                Nome = "Itapevi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5066,
                Nome = "Itapira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapirapuã Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5067,
                Nome = "Itapirapuã Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5068,
                Nome = "Itápolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itaporanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5069,
                Nome = "Itaporanga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5070,
                Nome = "Itapuí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itapura
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5071,
                Nome = "Itapura",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itaquaquecetuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5072,
                Nome = "Itaquaquecetuba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itararé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5073,
                Nome = "Itararé",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itariri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5074,
                Nome = "Itariri",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itatiba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5075,
                Nome = "Itatiba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itatinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5076,
                Nome = "Itatinga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itirapina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5077,
                Nome = "Itirapina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itirapuã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5078,
                Nome = "Itirapuã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itobi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5079,
                Nome = "Itobi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5080,
                Nome = "Itu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Itupeva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5081,
                Nome = "Itupeva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ituverava
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5082,
                Nome = "Ituverava",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jaborandi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5083,
                Nome = "Jaborandi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jaboticabal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5084,
                Nome = "Jaboticabal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jacareí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5085,
                Nome = "Jacareí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jaci
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5086,
                Nome = "Jaci",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jacupiranga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5087,
                Nome = "Jacupiranga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jaguariúna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5088,
                Nome = "Jaguariúna",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jales
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5089,
                Nome = "Jales",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jambeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5090,
                Nome = "Jambeiro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jandira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5091,
                Nome = "Jandira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jardinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5092,
                Nome = "Jardinópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jarinu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5093,
                Nome = "Jarinu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5094,
                Nome = "Jaú",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jeriquara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5095,
                Nome = "Jeriquara",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Joanópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5096,
                Nome = "Joanópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: João Ramalho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5097,
                Nome = "João Ramalho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: José Bonifácio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5098,
                Nome = "José Bonifácio",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Júlio Mesquita
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5099,
                Nome = "Júlio Mesquita",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jumirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5100,
                Nome = "Jumirim",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Jundiaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5101,
                Nome = "Jundiaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Junqueirópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5102,
                Nome = "Junqueirópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Juquiá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5103,
                Nome = "Juquiá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Juquitiba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5104,
                Nome = "Juquitiba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lagoinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5105,
                Nome = "Lagoinha",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Laranjal Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5106,
                Nome = "Laranjal Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lavínia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5107,
                Nome = "Lavínia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lavrinhas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5108,
                Nome = "Lavrinhas",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Leme
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5109,
                Nome = "Leme",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lençóis Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5110,
                Nome = "Lençóis Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Limeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5111,
                Nome = "Limeira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lindóia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5112,
                Nome = "Lindóia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lins
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5113,
                Nome = "Lins",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lorena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5114,
                Nome = "Lorena",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lourdes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5115,
                Nome = "Lourdes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Louveira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5116,
                Nome = "Louveira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lucélia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5117,
                Nome = "Lucélia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lucianópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5118,
                Nome = "Lucianópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Luís Antônio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5119,
                Nome = "Luís Antônio",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Luisiânia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5120,
                Nome = "Luisiânia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lupércio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5121,
                Nome = "Lupércio",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Lutécia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5122,
                Nome = "Lutécia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Macatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5123,
                Nome = "Macatuba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Macaubal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5124,
                Nome = "Macaubal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Macedônia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5125,
                Nome = "Macedônia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Magda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5126,
                Nome = "Magda",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mairinque
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5127,
                Nome = "Mairinque",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mairiporã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5128,
                Nome = "Mairiporã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Manduri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5129,
                Nome = "Manduri",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Marabá Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5130,
                Nome = "Marabá Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Maracaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5131,
                Nome = "Maracaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Marapoama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5132,
                Nome = "Marapoama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mariápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5133,
                Nome = "Mariápolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Marília
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5134,
                Nome = "Marília",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Marinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5135,
                Nome = "Marinópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Martinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5136,
                Nome = "Martinópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Matão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5137,
                Nome = "Matão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mauá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5138,
                Nome = "Mauá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mendonça
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5139,
                Nome = "Mendonça",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Meridiano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5140,
                Nome = "Meridiano",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mesópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5141,
                Nome = "Mesópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Miguelópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5142,
                Nome = "Miguelópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mineiros do Tietê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5143,
                Nome = "Mineiros do Tietê",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mira Estrela
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5144,
                Nome = "Mira Estrela",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Miracatu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5145,
                Nome = "Miracatu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mirandópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5146,
                Nome = "Mirandópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mirante do Paranapanema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5147,
                Nome = "Mirante do Paranapanema",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mirassol
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5148,
                Nome = "Mirassol",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mirassolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5149,
                Nome = "Mirassolândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mococa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5150,
                Nome = "Mococa",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mogi das Cruzes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5151,
                Nome = "Mogi das Cruzes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mogi Guaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5152,
                Nome = "Mogi Guaçu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mogi Mirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5153,
                Nome = "Mogi Mirim",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mombuca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5154,
                Nome = "Mombuca",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monções
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5155,
                Nome = "Monções",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Mongaguá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5156,
                Nome = "Mongaguá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monte Alegre do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5157,
                Nome = "Monte Alegre do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monte Alto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5158,
                Nome = "Monte Alto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monte Aprazível
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5159,
                Nome = "Monte Aprazível",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monte Azul Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5160,
                Nome = "Monte Azul Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monte Castelo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5161,
                Nome = "Monte Castelo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monte Mor
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5162,
                Nome = "Monte Mor",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Monteiro Lobato
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5163,
                Nome = "Monteiro Lobato",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Morro Agudo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5164,
                Nome = "Morro Agudo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Morungaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5165,
                Nome = "Morungaba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Motuca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5166,
                Nome = "Motuca",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Murutinga do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5167,
                Nome = "Murutinga do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nantes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5168,
                Nome = "Nantes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Narandiba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5169,
                Nome = "Narandiba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Natividade da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5170,
                Nome = "Natividade da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nazaré Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5171,
                Nome = "Nazaré Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Neves Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5172,
                Nome = "Neves Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nhandeara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5173,
                Nome = "Nhandeara",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nipoã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5174,
                Nome = "Nipoã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Aliança
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5175,
                Nome = "Nova Aliança",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Campina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5176,
                Nome = "Nova Campina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Canaã Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5177,
                Nome = "Nova Canaã Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Castilho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5178,
                Nome = "Nova Castilho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Europa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5179,
                Nome = "Nova Europa",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Granada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5180,
                Nome = "Nova Granada",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Guataporanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5181,
                Nome = "Nova Guataporanga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Independência
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5182,
                Nome = "Nova Independência",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Luzitânia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5183,
                Nome = "Nova Luzitânia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nova Odessa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5184,
                Nome = "Nova Odessa",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Novais
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5185,
                Nome = "Novais",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Novo Horizonte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5186,
                Nome = "Novo Horizonte",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Nuporanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5187,
                Nome = "Nuporanga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ocauçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5188,
                Nome = "Ocauçu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Óleo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5189,
                Nome = "Óleo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Olímpia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5190,
                Nome = "Olímpia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Onda Verde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5191,
                Nome = "Onda Verde",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Oriente
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5192,
                Nome = "Oriente",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Orindiúva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5193,
                Nome = "Orindiúva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Orlândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5194,
                Nome = "Orlândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Osasco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5195,
                Nome = "Osasco",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Oscar Bressane
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5196,
                Nome = "Oscar Bressane",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Osvaldo Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5197,
                Nome = "Osvaldo Cruz",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ourinhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5198,
                Nome = "Ourinhos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ouro Verde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5199,
                Nome = "Ouro Verde",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ouroeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5200,
                Nome = "Ouroeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pacaembu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5201,
                Nome = "Pacaembu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Palestina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5202,
                Nome = "Palestina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Palmares Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5203,
                Nome = "Palmares Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Palmeira D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5204,
                Nome = "Palmeira D Oeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Palmital
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5205,
                Nome = "Palmital",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Panorama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5206,
                Nome = "Panorama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paraguaçu Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5207,
                Nome = "Paraguaçu Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paraibuna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5208,
                Nome = "Paraibuna",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paraíso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5209,
                Nome = "Paraíso",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paranapanema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5210,
                Nome = "Paranapanema",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paranapuã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5211,
                Nome = "Paranapuã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Parapuã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5212,
                Nome = "Parapuã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pardinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5213,
                Nome = "Pardinho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pariquera Açu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5214,
                Nome = "Pariquera Açu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Parisi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5215,
                Nome = "Parisi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Patrocínio Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5216,
                Nome = "Patrocínio Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paulicéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5217,
                Nome = "Paulicéia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paulínia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5218,
                Nome = "Paulínia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paulistânia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5219,
                Nome = "Paulistânia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Paulo de Faria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5220,
                Nome = "Paulo de Faria",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pederneiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5221,
                Nome = "Pederneiras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pedra Bela
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5222,
                Nome = "Pedra Bela",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pedranópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5223,
                Nome = "Pedranópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pedregulho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5224,
                Nome = "Pedregulho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pedreira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5225,
                Nome = "Pedreira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pedrinhas Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5226,
                Nome = "Pedrinhas Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pedro de Toledo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5227,
                Nome = "Pedro de Toledo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Penápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5228,
                Nome = "Penápolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pereira Barreto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5229,
                Nome = "Pereira Barreto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pereiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5230,
                Nome = "Pereiras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Peruíbe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5231,
                Nome = "Peruíbe",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piacatu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5232,
                Nome = "Piacatu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piedade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5233,
                Nome = "Piedade",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pilar do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5234,
                Nome = "Pilar do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pindamonhangaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5235,
                Nome = "Pindamonhangaba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pindorama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5236,
                Nome = "Pindorama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pinhalzinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5237,
                Nome = "Pinhalzinho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piquerobi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5238,
                Nome = "Piquerobi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piquete
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5239,
                Nome = "Piquete",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piracaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5240,
                Nome = "Piracaia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piracicaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5241,
                Nome = "Piracicaba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piraju
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5242,
                Nome = "Piraju",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pirajuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5243,
                Nome = "Pirajuí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pirangi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5244,
                Nome = "Pirangi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pirapora do Bom Jesus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5245,
                Nome = "Pirapora do Bom Jesus",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pirapozinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5246,
                Nome = "Pirapozinho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pirassununga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5247,
                Nome = "Pirassununga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Piratininga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5248,
                Nome = "Piratininga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pitangueiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5249,
                Nome = "Pitangueiras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Planalto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5250,
                Nome = "Planalto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Platina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5251,
                Nome = "Platina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Poá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5252,
                Nome = "Poá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Poloni
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5253,
                Nome = "Poloni",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pompéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5254,
                Nome = "Pompéia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pongaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5255,
                Nome = "Pongaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pontal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5256,
                Nome = "Pontal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pontalinda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5257,
                Nome = "Pontalinda",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pontes Gestal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5258,
                Nome = "Pontes Gestal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Populina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5259,
                Nome = "Populina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Porangaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5260,
                Nome = "Porangaba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Porto Feliz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5261,
                Nome = "Porto Feliz",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Porto Ferreira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5262,
                Nome = "Porto Ferreira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Potim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5263,
                Nome = "Potim",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Potirendaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5264,
                Nome = "Potirendaba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pracinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5265,
                Nome = "Pracinha",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pradópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5266,
                Nome = "Pradópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Praia Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5267,
                Nome = "Praia Grande",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Pratânia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5268,
                Nome = "Pratânia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Presidente Alves
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5269,
                Nome = "Presidente Alves",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Presidente Bernardes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5270,
                Nome = "Presidente Bernardes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Presidente Epitácio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5271,
                Nome = "Presidente Epitácio",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Presidente Prudente
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5272,
                Nome = "Presidente Prudente",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Presidente Venceslau
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5273,
                Nome = "Presidente Venceslau",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Promissão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5274,
                Nome = "Promissão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Quadra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5275,
                Nome = "Quadra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Quatá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5276,
                Nome = "Quatá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Queiroz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5277,
                Nome = "Queiroz",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Queluz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5278,
                Nome = "Queluz",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Quintana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5279,
                Nome = "Quintana",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rafard
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5280,
                Nome = "Rafard",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rancharia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5281,
                Nome = "Rancharia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Redenção da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5282,
                Nome = "Redenção da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Regente Feijó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5283,
                Nome = "Regente Feijó",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Reginópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5284,
                Nome = "Reginópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Registro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5285,
                Nome = "Registro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Restinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5286,
                Nome = "Restinga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5287,
                Nome = "Ribeira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão Bonito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5288,
                Nome = "Ribeirão Bonito",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão Branco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5289,
                Nome = "Ribeirão Branco",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão Corrente
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5290,
                Nome = "Ribeirão Corrente",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5291,
                Nome = "Ribeirão do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão dos Índios
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5292,
                Nome = "Ribeirão dos Índios",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5293,
                Nome = "Ribeirão Grande",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão Pires
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5294,
                Nome = "Ribeirão Pires",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ribeirão Preto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5295,
                Nome = "Ribeirão Preto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rifaina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5296,
                Nome = "Rifaina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rincão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5297,
                Nome = "Rincão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rinópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5298,
                Nome = "Rinópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rio Claro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5299,
                Nome = "Rio Claro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rio das Pedras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5300,
                Nome = "Rio das Pedras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rio Grande da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5301,
                Nome = "Rio Grande da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Riolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5302,
                Nome = "Riolândia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Riversul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5303,
                Nome = "Riversul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rosana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5304,
                Nome = "Rosana",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Roseira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5305,
                Nome = "Roseira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rubiácea
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5306,
                Nome = "Rubiácea",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Rubinéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5307,
                Nome = "Rubinéia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sabino
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5308,
                Nome = "Sabino",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sagres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5309,
                Nome = "Sagres",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sales
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5310,
                Nome = "Sales",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sales Oliveira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5311,
                Nome = "Sales Oliveira",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Salesópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5312,
                Nome = "Salesópolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Salmourão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5313,
                Nome = "Salmourão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Saltinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5314,
                Nome = "Saltinho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Salto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5315,
                Nome = "Salto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Salto de Pirapora
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5316,
                Nome = "Salto de Pirapora",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Salto Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5317,
                Nome = "Salto Grande",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sandovalina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5318,
                Nome = "Sandovalina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Adélia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5319,
                Nome = "Santa Adélia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Albertina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5320,
                Nome = "Santa Albertina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Bárbara D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5321,
                Nome = "Santa Bárbara D Oeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5322,
                Nome = "Santa Branca",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Clara D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5323,
                Nome = "Santa Clara D Oeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Cruz da Conceição
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5324,
                Nome = "Santa Cruz da Conceição",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Cruz da Esperança
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5325,
                Nome = "Santa Cruz da Esperança",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Cruz das Palmeiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5326,
                Nome = "Santa Cruz das Palmeiras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Cruz do Rio Pardo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5327,
                Nome = "Santa Cruz do Rio Pardo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Ernestina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5328,
                Nome = "Santa Ernestina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Fé do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5329,
                Nome = "Santa Fé do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Gertrudes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5330,
                Nome = "Santa Gertrudes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Isabel
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5331,
                Nome = "Santa Isabel",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Lúcia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5332,
                Nome = "Santa Lúcia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Maria da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5333,
                Nome = "Santa Maria da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Mercedes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5334,
                Nome = "Santa Mercedes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Rita do Passa Quatro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5335,
                Nome = "Santa Rita do Passa Quatro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Rita D Oeste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5336,
                Nome = "Santa Rita D Oeste",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Rosa de Viterbo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5337,
                Nome = "Santa Rosa de Viterbo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santa Salete
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5338,
                Nome = "Santa Salete",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santana da Ponte Pensa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5339,
                Nome = "Santana da Ponte Pensa",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santana de Parnaíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5340,
                Nome = "Santana de Parnaíba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo Anastácio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5341,
                Nome = "Santo Anastácio",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo André
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5342,
                Nome = "Santo André",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo Antônio da Alegria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5343,
                Nome = "Santo Antônio da Alegria",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo Antônio de Posse
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5344,
                Nome = "Santo Antônio de Posse",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo Antônio do Aracanguá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5345,
                Nome = "Santo Antônio do Aracanguá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo Antônio do Jardim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5346,
                Nome = "Santo Antônio do Jardim",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo Antônio do Pinhal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5347,
                Nome = "Santo Antônio do Pinhal",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santo Expedito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5348,
                Nome = "Santo Expedito",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santópolis do Aguapeí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5349,
                Nome = "Santópolis do Aguapeí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Santos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5350,
                Nome = "Santos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Bento do Sapucaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5351,
                Nome = "São Bento do Sapucaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Bernardo do Campo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5352,
                Nome = "São Bernardo do Campo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Caetano do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5353,
                Nome = "São Caetano do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Carlos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5354,
                Nome = "São Carlos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Francisco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5355,
                Nome = "São Francisco",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São João da Boa Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5356,
                Nome = "São João da Boa Vista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São João das Duas Pontes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5357,
                Nome = "São João das Duas Pontes",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São João de Iracema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5358,
                Nome = "São João de Iracema",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São João do Pau D Alho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5359,
                Nome = "São João do Pau D Alho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Joaquim da Barra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5360,
                Nome = "São Joaquim da Barra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São José da Bela Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5361,
                Nome = "São José da Bela Vista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São José do Barreiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5362,
                Nome = "São José do Barreiro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São José do Rio Pardo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5363,
                Nome = "São José do Rio Pardo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São José do Rio Preto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5364,
                Nome = "São José do Rio Preto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São José dos Campos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5365,
                Nome = "São José dos Campos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Lourenço da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5366,
                Nome = "São Lourenço da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Luís do Paraitinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5367,
                Nome = "São Luís do Paraitinga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Manuel
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5368,
                Nome = "São Manuel",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Miguel Arcanjo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5369,
                Nome = "São Miguel Arcanjo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Paulo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5370,
                Nome = "São Paulo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Pedro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5371,
                Nome = "São Pedro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Pedro do Turvo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5372,
                Nome = "São Pedro do Turvo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Roque
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5373,
                Nome = "São Roque",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Sebastião
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5374,
                Nome = "São Sebastião",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Sebastião da Grama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5375,
                Nome = "São Sebastião da Grama",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Simão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5376,
                Nome = "São Simão",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: São Vicente
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5377,
                Nome = "São Vicente",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sarapuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5378,
                Nome = "Sarapuí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sarutaiá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5379,
                Nome = "Sarutaiá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sebastianópolis do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5380,
                Nome = "Sebastianópolis do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Serra Azul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5381,
                Nome = "Serra Azul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Serra Negra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5382,
                Nome = "Serra Negra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Serrana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5383,
                Nome = "Serrana",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sertãozinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5384,
                Nome = "Sertãozinho",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sete Barras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5385,
                Nome = "Sete Barras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Severínia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5386,
                Nome = "Severínia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Silveiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5387,
                Nome = "Silveiras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Socorro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5388,
                Nome = "Socorro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sorocaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5389,
                Nome = "Sorocaba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sud Mennucci
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5390,
                Nome = "Sud Mennucci",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Sumaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5391,
                Nome = "Sumaré",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Suzanápolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5392,
                Nome = "Suzanápolis",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Suzano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5393,
                Nome = "Suzano",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tabapuã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5394,
                Nome = "Tabapuã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tabatinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5395,
                Nome = "Tabatinga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taboão da Serra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5396,
                Nome = "Taboão da Serra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taciba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5397,
                Nome = "Taciba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taguaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5398,
                Nome = "Taguaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taiaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5399,
                Nome = "Taiaçu",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taiúva
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5400,
                Nome = "Taiúva",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tambaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5401,
                Nome = "Tambaú",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tanabi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5402,
                Nome = "Tanabi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tapiraí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5403,
                Nome = "Tapiraí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tapiratiba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5404,
                Nome = "Tapiratiba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taquaral
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5405,
                Nome = "Taquaral",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taquaritinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5406,
                Nome = "Taquaritinga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taquarituba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5407,
                Nome = "Taquarituba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taquarivaí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5408,
                Nome = "Taquarivaí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tarabai
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5409,
                Nome = "Tarabai",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tarumã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5410,
                Nome = "Tarumã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tatuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5411,
                Nome = "Tatuí",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Taubaté
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5412,
                Nome = "Taubaté",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tejupá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5413,
                Nome = "Tejupá",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Teodoro Sampaio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5414,
                Nome = "Teodoro Sampaio",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Terra Roxa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5415,
                Nome = "Terra Roxa",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tietê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5416,
                Nome = "Tietê",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Timburi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5417,
                Nome = "Timburi",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Torre de Pedra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5418,
                Nome = "Torre de Pedra",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Torrinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5419,
                Nome = "Torrinha",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Trabiju
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5420,
                Nome = "Trabiju",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tremembé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5421,
                Nome = "Tremembé",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Três Fronteiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5422,
                Nome = "Três Fronteiras",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tuiuti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5423,
                Nome = "Tuiuti",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tupã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5424,
                Nome = "Tupã",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Tupi Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5425,
                Nome = "Tupi Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Turiúba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5426,
                Nome = "Turiúba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Turmalina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5427,
                Nome = "Turmalina",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ubarana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5428,
                Nome = "Ubarana",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ubatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5429,
                Nome = "Ubatuba",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Ubirajara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5430,
                Nome = "Ubirajara",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Uchoa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5431,
                Nome = "Uchoa",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: União Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5432,
                Nome = "União Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Urânia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5433,
                Nome = "Urânia",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Uru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5434,
                Nome = "Uru",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Urupês
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5435,
                Nome = "Urupês",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Valentim Gentil
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5436,
                Nome = "Valentim Gentil",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Valinhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5437,
                Nome = "Valinhos",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Valparaíso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5438,
                Nome = "Valparaíso",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Vargem
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5439,
                Nome = "Vargem",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Vargem Grande do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5440,
                Nome = "Vargem Grande do Sul",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Vargem Grande Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5441,
                Nome = "Vargem Grande Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Várzea Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5442,
                Nome = "Várzea Paulista",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Vera Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5443,
                Nome = "Vera Cruz",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Vinhedo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5444,
                Nome = "Vinhedo",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Viradouro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5445,
                Nome = "Viradouro",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Vista Alegre do Alto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5446,
                Nome = "Vista Alegre do Alto",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Vitória Brasil
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5447,
                Nome = "Vitória Brasil",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Votorantim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5448,
                Nome = "Votorantim",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Votuporanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5449,
                Nome = "Votuporanga",
                Situacao = "Ativo",
                UF = "SP"
            });

            // cidade: Zacarias
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 5450,
                Nome = "Zacarias",
                Situacao = "Ativo",
                UF = "SP"
            });

            await _context.SaveChangesAsync();
        }
    }
}
