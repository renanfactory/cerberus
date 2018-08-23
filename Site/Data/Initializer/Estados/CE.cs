using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class CE
    {
        private readonly ApplicationDbContext _context;

        public CE(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: CE
            //----------------------------------------------------

            // cidade: Abaiara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 620,
                Nome = "Abaiara",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Acarapé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 621,
                Nome = "Acarapé",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Acaraú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 622,
                Nome = "Acaraú",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Acopiara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 623,
                Nome = "Acopiara",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Aiuaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 624,
                Nome = "Aiuaba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Alcântaras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 625,
                Nome = "Alcântaras",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Altaneira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 626,
                Nome = "Altaneira",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Alto Santo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 627,
                Nome = "Alto Santo",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Amontada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 628,
                Nome = "Amontada",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Antonina do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 629,
                Nome = "Antonina do Norte",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Apuiarés
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 630,
                Nome = "Apuiarés",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Aquiraz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 631,
                Nome = "Aquiraz",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Aracati
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 632,
                Nome = "Aracati",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Aracoiaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 633,
                Nome = "Aracoiaba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ararendá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 634,
                Nome = "Ararendá",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Araripe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 635,
                Nome = "Araripe",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Aratuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 636,
                Nome = "Aratuba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Arneiroz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 637,
                Nome = "Arneiroz",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Assaré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 638,
                Nome = "Assaré",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Aurora
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 639,
                Nome = "Aurora",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Baixio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 640,
                Nome = "Baixio",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Banabuiú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 641,
                Nome = "Banabuiú",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Barbalha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 642,
                Nome = "Barbalha",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Barreira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 643,
                Nome = "Barreira",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Barro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 644,
                Nome = "Barro",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Barroquinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 645,
                Nome = "Barroquinha",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Baturité
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 646,
                Nome = "Baturité",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Beberibe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 647,
                Nome = "Beberibe",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Bela Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 648,
                Nome = "Bela Cruz",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Boa Viagem
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 649,
                Nome = "Boa Viagem",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Brejo Santo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 650,
                Nome = "Brejo Santo",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Camocim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 651,
                Nome = "Camocim",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Campos Sales
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 652,
                Nome = "Campos Sales",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Canindé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 653,
                Nome = "Canindé",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Capistrano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 654,
                Nome = "Capistrano",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Caridade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 655,
                Nome = "Caridade",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Cariré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 656,
                Nome = "Cariré",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Caririaçu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 657,
                Nome = "Caririaçu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Cariús
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 658,
                Nome = "Cariús",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Carnaubal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 659,
                Nome = "Carnaubal",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Cascavel
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 660,
                Nome = "Cascavel",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Catarina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 661,
                Nome = "Catarina",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Caucaia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 662,
                Nome = "Caucaia",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Cedro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 663,
                Nome = "Cedro",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Chaval
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 664,
                Nome = "Chaval",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Choró
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 665,
                Nome = "Choró",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Chorozinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 666,
                Nome = "Chorozinho",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Coreaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 667,
                Nome = "Coreaú",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Crateús
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 668,
                Nome = "Crateús",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Crato
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 669,
                Nome = "Crato",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Croatá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 670,
                Nome = "Croatá",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 671,
                Nome = "Cruz",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Deputado Irapuan Pinheiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 672,
                Nome = "Deputado Irapuan Pinheiro",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ererê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 673,
                Nome = "Ererê",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Eusébio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 674,
                Nome = "Eusébio",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Farias Brito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 675,
                Nome = "Farias Brito",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Forquilha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 676,
                Nome = "Forquilha",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Fortaleza
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 677,
                Nome = "Fortaleza",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Fortim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 678,
                Nome = "Fortim",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Frecheirinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 679,
                Nome = "Frecheirinha",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: General Sampaio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 680,
                Nome = "General Sampaio",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Graça
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 681,
                Nome = "Graça",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Granja
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 682,
                Nome = "Granja",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Granjeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 683,
                Nome = "Granjeiro",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Groaíras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 684,
                Nome = "Groaíras",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Guaiúba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 685,
                Nome = "Guaiúba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Guaraciaba do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 686,
                Nome = "Guaraciaba do Norte",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Guaramiranga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 687,
                Nome = "Guaramiranga",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Hidrolândia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 688,
                Nome = "Hidrolândia",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Horizonte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 689,
                Nome = "Horizonte",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ibaretama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 690,
                Nome = "Ibaretama",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ibiapina
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 691,
                Nome = "Ibiapina",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ibicuitinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 692,
                Nome = "Ibicuitinga",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Icapuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 693,
                Nome = "Icapuí",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Icó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 694,
                Nome = "Icó",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Iguatu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 695,
                Nome = "Iguatu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Independência
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 696,
                Nome = "Independência",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ipaporanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 697,
                Nome = "Ipaporanga",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ipaumirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 698,
                Nome = "Ipaumirim",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ipu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 699,
                Nome = "Ipu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ipueiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 700,
                Nome = "Ipueiras",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Iracema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 701,
                Nome = "Iracema",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Irauçuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 702,
                Nome = "Irauçuba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Itaiçaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 703,
                Nome = "Itaiçaba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Itaitinga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 704,
                Nome = "Itaitinga",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Itapagé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 705,
                Nome = "Itapagé",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Itapipoca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 706,
                Nome = "Itapipoca",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Itapiúna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 707,
                Nome = "Itapiúna",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Itarema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 708,
                Nome = "Itarema",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Itatira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 709,
                Nome = "Itatira",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jaguaretama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 710,
                Nome = "Jaguaretama",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jaguaribara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 711,
                Nome = "Jaguaribara",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jaguaribe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 712,
                Nome = "Jaguaribe",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jaguaruana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 713,
                Nome = "Jaguaruana",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jardim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 714,
                Nome = "Jardim",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jati
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 715,
                Nome = "Jati",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jijoca de Jericoacoara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 716,
                Nome = "Jijoca de Jericoacoara",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Juazeiro do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 717,
                Nome = "Juazeiro do Norte",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Jucás
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 718,
                Nome = "Jucás",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Lavras da Mangabeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 719,
                Nome = "Lavras da Mangabeira",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Limoeiro do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 720,
                Nome = "Limoeiro do Norte",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Madalena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 721,
                Nome = "Madalena",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Maracanaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 722,
                Nome = "Maracanaú",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Maranguape
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 723,
                Nome = "Maranguape",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Marco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 724,
                Nome = "Marco",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Martinópole
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 725,
                Nome = "Martinópole",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Massapê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 726,
                Nome = "Massapê",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Mauriti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 727,
                Nome = "Mauriti",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Meruoca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 728,
                Nome = "Meruoca",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Milagres
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 729,
                Nome = "Milagres",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Milhã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 730,
                Nome = "Milhã",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Miraíma
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 731,
                Nome = "Miraíma",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Missão Velha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 732,
                Nome = "Missão Velha",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Mombaça
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 733,
                Nome = "Mombaça",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Monsenhor Tabosa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 734,
                Nome = "Monsenhor Tabosa",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Morada Nova
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 735,
                Nome = "Morada Nova",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Moraújo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 736,
                Nome = "Moraújo",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Morrinhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 737,
                Nome = "Morrinhos",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Mucambo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 738,
                Nome = "Mucambo",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Mulungu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 739,
                Nome = "Mulungu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Nova Olinda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 740,
                Nome = "Nova Olinda",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Nova Russas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 741,
                Nome = "Nova Russas",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Novo Oriente
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 742,
                Nome = "Novo Oriente",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ocara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 743,
                Nome = "Ocara",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Orós
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 744,
                Nome = "Orós",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pacajus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 745,
                Nome = "Pacajus",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pacatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 746,
                Nome = "Pacatuba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pacoti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 747,
                Nome = "Pacoti",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pacujá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 748,
                Nome = "Pacujá",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Palhano
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 749,
                Nome = "Palhano",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Palmácia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 750,
                Nome = "Palmácia",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Paracuru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 751,
                Nome = "Paracuru",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Paraipaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 752,
                Nome = "Paraipaba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Parambu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 753,
                Nome = "Parambu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Paramoti
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 754,
                Nome = "Paramoti",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pedra Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 755,
                Nome = "Pedra Branca",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Penaforte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 756,
                Nome = "Penaforte",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pentecoste
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 757,
                Nome = "Pentecoste",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pereiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 758,
                Nome = "Pereiro",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pindoretama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 759,
                Nome = "Pindoretama",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Piquet Carneiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 760,
                Nome = "Piquet Carneiro",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Pires Ferreira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 761,
                Nome = "Pires Ferreira",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Poranga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 762,
                Nome = "Poranga",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Porteiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 763,
                Nome = "Porteiras",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Potengi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 764,
                Nome = "Potengi",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Potiretama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 765,
                Nome = "Potiretama",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Quiterianópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 766,
                Nome = "Quiterianópolis",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Quixadá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 767,
                Nome = "Quixadá",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Quixelô
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 768,
                Nome = "Quixelô",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Quixeramobim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 769,
                Nome = "Quixeramobim",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Quixeré
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 770,
                Nome = "Quixeré",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Redenção
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 771,
                Nome = "Redenção",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Reriutaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 772,
                Nome = "Reriutaba",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Russas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 773,
                Nome = "Russas",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Saboeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 774,
                Nome = "Saboeiro",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Salitre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 775,
                Nome = "Salitre",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Santa Quitéria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 776,
                Nome = "Santa Quitéria",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Santana do Acaraú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 777,
                Nome = "Santana do Acaraú",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Santana do Cariri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 778,
                Nome = "Santana do Cariri",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: São Benedito
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 779,
                Nome = "São Benedito",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: São Gonçalo do Amarante
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 780,
                Nome = "São Gonçalo do Amarante",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: São João do Jaguaribe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 781,
                Nome = "São João do Jaguaribe",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: São Luís do Curu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 782,
                Nome = "São Luís do Curu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Senador Catunda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 783,
                Nome = "Senador Catunda",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Senador Pompeu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 784,
                Nome = "Senador Pompeu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Senador Sá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 785,
                Nome = "Senador Sá",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Sobral
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 786,
                Nome = "Sobral",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Solonópole
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 787,
                Nome = "Solonópole",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Tabuleiro do Norte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 788,
                Nome = "Tabuleiro do Norte",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Tamboril
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 789,
                Nome = "Tamboril",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Tarrafas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 790,
                Nome = "Tarrafas",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Tauá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 791,
                Nome = "Tauá",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Tejuçuoca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 792,
                Nome = "Tejuçuoca",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Tianguá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 793,
                Nome = "Tianguá",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Trairi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 794,
                Nome = "Trairi",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Tururu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 795,
                Nome = "Tururu",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Ubajara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 796,
                Nome = "Ubajara",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Umari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 797,
                Nome = "Umari",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Umirim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 798,
                Nome = "Umirim",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Uruburetama
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 799,
                Nome = "Uruburetama",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Uruoca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 800,
                Nome = "Uruoca",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Varjota
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 801,
                Nome = "Varjota",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Várzea Alegre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 802,
                Nome = "Várzea Alegre",
                Situacao = "Ativo",
                UF = "CE"
            });

            // cidade: Viçosa do Ceará
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 803,
                Nome = "Viçosa do Ceará",
                Situacao = "Ativo",
                UF = "CE"
            });


            await _context.SaveChangesAsync();
        }
    }
}
