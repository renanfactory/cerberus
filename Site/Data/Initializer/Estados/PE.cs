using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class PE
    {
        private readonly ApplicationDbContext _context;

        public PE(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: PE
            //----------------------------------------------------

            // cidade: Abreu e Lima
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2813,
                Nome = "Abreu e Lima",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Afogados da Ingazeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2814,
                Nome = "Afogados da Ingazeira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Afrânio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2815,
                Nome = "Afrânio",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Agrestina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2816,
                Nome = "Agrestina",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Água Preta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2817,
                Nome = "Água Preta",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Águas Belas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2818,
                Nome = "Águas Belas",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Alagoinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2819,
                Nome = "Alagoinha",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Aliança
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2820,
                Nome = "Aliança",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Altinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2821,
                Nome = "Altinho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Amaraji
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2822,
                Nome = "Amaraji",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Angelim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2823,
                Nome = "Angelim",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Aracoiaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2824,
                Nome = "Aracoiaba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Araripina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2825,
                Nome = "Araripina",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Arcoverde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2826,
                Nome = "Arcoverde",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Barra de Guabiraba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2827,
                Nome = "Barra de Guabiraba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Barreiros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2828,
                Nome = "Barreiros",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Belém de Maria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2829,
                Nome = "Belém de Maria",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Belém de São Francisco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2830,
                Nome = "Belém de São Francisco",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Belo Jardim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2831,
                Nome = "Belo Jardim",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Betânia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2832,
                Nome = "Betânia",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Bezerros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2833,
                Nome = "Bezerros",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Bodocó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2834,
                Nome = "Bodocó",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Bom Conselho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2835,
                Nome = "Bom Conselho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Bom Jardim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2836,
                Nome = "Bom Jardim",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Bonito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2837,
                Nome = "Bonito",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Brejão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2838,
                Nome = "Brejão",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Brejinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2839,
                Nome = "Brejinho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Brejo da Madre de Deus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2840,
                Nome = "Brejo da Madre de Deus",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Buenos Aires
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2841,
                Nome = "Buenos Aires",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Buíque
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2842,
                Nome = "Buíque",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Cabo de Santo Agostinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2843,
                Nome = "Cabo de Santo Agostinho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Cabrobó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2844,
                Nome = "Cabrobó",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Cachoeirinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2845,
                Nome = "Cachoeirinha",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Caetés
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2846,
                Nome = "Caetés",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Calçado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2847,
                Nome = "Calçado",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Calumbi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2848,
                Nome = "Calumbi",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Camaragibe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2849,
                Nome = "Camaragibe",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Camocim de São Félix
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2850,
                Nome = "Camocim de São Félix",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Camutanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2851,
                Nome = "Camutanga",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Canhotinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2852,
                Nome = "Canhotinho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Capoeiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2853,
                Nome = "Capoeiras",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Carnaíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2854,
                Nome = "Carnaíba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Carnaubeira da Penha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2855,
                Nome = "Carnaubeira da Penha",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Carpina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2856,
                Nome = "Carpina",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Caruaru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2857,
                Nome = "Caruaru",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Casinhas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2858,
                Nome = "Casinhas",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Catende
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2859,
                Nome = "Catende",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Cedro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2860,
                Nome = "Cedro",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Chã de Alegria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2861,
                Nome = "Chã de Alegria",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Chã Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2862,
                Nome = "Chã Grande",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Condado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2863,
                Nome = "Condado",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Correntes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2864,
                Nome = "Correntes",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Cortês
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2865,
                Nome = "Cortês",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Cumaru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2866,
                Nome = "Cumaru",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Cupira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2867,
                Nome = "Cupira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Custódia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2868,
                Nome = "Custódia",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Dormentes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2869,
                Nome = "Dormentes",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Escada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2870,
                Nome = "Escada",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Exu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2871,
                Nome = "Exu",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Feira Nova
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2872,
                Nome = "Feira Nova",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Fernando de Noronha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2873,
                Nome = "Fernando de Noronha",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ferreiros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2874,
                Nome = "Ferreiros",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Flores
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2875,
                Nome = "Flores",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Floresta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2876,
                Nome = "Floresta",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Frei Miguelinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2877,
                Nome = "Frei Miguelinho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Gameleira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2878,
                Nome = "Gameleira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Garanhuns
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2879,
                Nome = "Garanhuns",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Glória do Goitá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2880,
                Nome = "Glória do Goitá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Goiana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2881,
                Nome = "Goiana",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Granito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2882,
                Nome = "Granito",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Gravatá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2883,
                Nome = "Gravatá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Iati
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2884,
                Nome = "Iati",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ibimirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2885,
                Nome = "Ibimirim",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ibirajuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2886,
                Nome = "Ibirajuba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Igarassu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2887,
                Nome = "Igarassu",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Iguaraci
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2888,
                Nome = "Iguaraci",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Inajá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2889,
                Nome = "Inajá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ingazeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2890,
                Nome = "Ingazeira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ipojuca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2891,
                Nome = "Ipojuca",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ipubi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2892,
                Nome = "Ipubi",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Itacuruba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2893,
                Nome = "Itacuruba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Itaíba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2894,
                Nome = "Itaíba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Itamaracá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2895,
                Nome = "Itamaracá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Itambé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2896,
                Nome = "Itambé",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Itapetim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2897,
                Nome = "Itapetim",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Itapissuma
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2898,
                Nome = "Itapissuma",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Itaquitinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2899,
                Nome = "Itaquitinga",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Jaboatão dos Guararapes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2900,
                Nome = "Jaboatão dos Guararapes",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Jaqueira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2901,
                Nome = "Jaqueira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Jataúba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2902,
                Nome = "Jataúba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Jatobá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2903,
                Nome = "Jatobá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: João Alfredo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2904,
                Nome = "João Alfredo",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Joaquim Nabuco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2905,
                Nome = "Joaquim Nabuco",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Jucati
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2906,
                Nome = "Jucati",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Jupi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2907,
                Nome = "Jupi",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Jurema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2908,
                Nome = "Jurema",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Lagoa do Carro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2909,
                Nome = "Lagoa do Carro",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Lagoa do Itaenga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2910,
                Nome = "Lagoa do Itaenga",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Lagoa do Ouro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2911,
                Nome = "Lagoa do Ouro",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Lagoa dos Gatos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2912,
                Nome = "Lagoa dos Gatos",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Lagoa Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2913,
                Nome = "Lagoa Grande",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Lajedo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2914,
                Nome = "Lajedo",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Limoeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2915,
                Nome = "Limoeiro",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Macaparana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2916,
                Nome = "Macaparana",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Machados
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2917,
                Nome = "Machados",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Manari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2918,
                Nome = "Manari",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Maraial
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2919,
                Nome = "Maraial",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Mirandiba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2920,
                Nome = "Mirandiba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Moreilândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2921,
                Nome = "Moreilândia",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Moreno
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2922,
                Nome = "Moreno",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Nazaré da Mata
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2923,
                Nome = "Nazaré da Mata",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Olinda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2924,
                Nome = "Olinda",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Orobó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2925,
                Nome = "Orobó",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Orocó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2926,
                Nome = "Orocó",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ouricuri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2927,
                Nome = "Ouricuri",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Palmares
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2928,
                Nome = "Palmares",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Palmeirina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2929,
                Nome = "Palmeirina",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Panelas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2930,
                Nome = "Panelas",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Paranatama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2931,
                Nome = "Paranatama",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Parnamirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2932,
                Nome = "Parnamirim",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Passira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2933,
                Nome = "Passira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Paudalho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2934,
                Nome = "Paudalho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2935,
                Nome = "Paulista",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Pedra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2936,
                Nome = "Pedra",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Pesqueira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2937,
                Nome = "Pesqueira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Petrolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2938,
                Nome = "Petrolândia",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Petrolina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2939,
                Nome = "Petrolina",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Poção
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2940,
                Nome = "Poção",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Pombos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2941,
                Nome = "Pombos",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Primavera
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2942,
                Nome = "Primavera",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Quipapá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2943,
                Nome = "Quipapá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Quixabá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2944,
                Nome = "Quixabá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Recife
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2945,
                Nome = "Recife",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Riacho das Almas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2946,
                Nome = "Riacho das Almas",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Ribeirão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2947,
                Nome = "Ribeirão",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Rio Formoso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2948,
                Nome = "Rio Formoso",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Sairé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2949,
                Nome = "Sairé",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Salgadinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2950,
                Nome = "Salgadinho",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Salgueiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2951,
                Nome = "Salgueiro",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Saloá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2952,
                Nome = "Saloá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Sanharó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2953,
                Nome = "Sanharó",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Santa Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2954,
                Nome = "Santa Cruz",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Santa Cruz da Baixa Verde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2955,
                Nome = "Santa Cruz da Baixa Verde",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Santa Cruz do Capibaribe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2956,
                Nome = "Santa Cruz do Capibaribe",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Santa Filomena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2957,
                Nome = "Santa Filomena",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Santa Maria da Boa Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2958,
                Nome = "Santa Maria da Boa Vista",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Santa Maria do Cambucá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2959,
                Nome = "Santa Maria do Cambucá",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Santa Terezinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2960,
                Nome = "Santa Terezinha",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São Benedito do Sul
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2961,
                Nome = "São Benedito do Sul",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São Bento do Una
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2962,
                Nome = "São Bento do Una",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São Caetano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2963,
                Nome = "São Caetano",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São João
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2964,
                Nome = "São João",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São Joaquim do Monte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2965,
                Nome = "São Joaquim do Monte",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São José da Coroa Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2966,
                Nome = "São José da Coroa Grande",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São José do Belmonte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2967,
                Nome = "São José do Belmonte",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São José do Egito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2968,
                Nome = "São José do Egito",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São Lourenço da Mata
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2969,
                Nome = "São Lourenço da Mata",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: São Vicente Ferrer
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2970,
                Nome = "São Vicente Ferrer",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Serra Talhada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2971,
                Nome = "Serra Talhada",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Serrita
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2972,
                Nome = "Serrita",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Sertânia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2973,
                Nome = "Sertânia",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Sirinhaém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2974,
                Nome = "Sirinhaém",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Solidão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2975,
                Nome = "Solidão",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Surubim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2976,
                Nome = "Surubim",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Tabira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2977,
                Nome = "Tabira",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Tacaimbó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2978,
                Nome = "Tacaimbó",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Tacaratu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2979,
                Nome = "Tacaratu",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Tamandaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2980,
                Nome = "Tamandaré",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Taquaritinga do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2981,
                Nome = "Taquaritinga do Norte",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Terezinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2982,
                Nome = "Terezinha",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Terra Nova
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2983,
                Nome = "Terra Nova",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Timbaúba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2984,
                Nome = "Timbaúba",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Toritama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2985,
                Nome = "Toritama",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Tracunhaém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2986,
                Nome = "Tracunhaém",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Trindade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2987,
                Nome = "Trindade",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Triunfo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2988,
                Nome = "Triunfo",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Tupanatinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2989,
                Nome = "Tupanatinga",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Tuparetama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2990,
                Nome = "Tuparetama",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Venturosa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2991,
                Nome = "Venturosa",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Verdejante
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2992,
                Nome = "Verdejante",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Vertente do Lério
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2993,
                Nome = "Vertente do Lério",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Vertentes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2994,
                Nome = "Vertentes",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Vicência
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2995,
                Nome = "Vicência",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Vitória de Santo Antão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2996,
                Nome = "Vitória de Santo Antão",
                Situacao = "Ativo",
                UF = "PE"
            });

            // cidade: Xexéu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2997,
                Nome = "Xexéu",
                Situacao = "Ativo",
                UF = "PE"
            });


            await _context.SaveChangesAsync();
        }
    }
}
