using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class ES
    {
        private readonly ApplicationDbContext _context;

        public ES(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: ES
            //----------------------------------------------------

            // cidade: Afonso Cláudio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 833,
                Nome = "Afonso Cláudio",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Água Doce do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 834,
                Nome = "Água Doce do Norte",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Águia Branca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 835,
                Nome = "Águia Branca",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 836,
                Nome = "Alegre",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Alfredo Chaves
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 837,
                Nome = "Alfredo Chaves",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Alto Rio Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 838,
                Nome = "Alto Rio Novo",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Anchieta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 839,
                Nome = "Anchieta",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Apiacá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 840,
                Nome = "Apiacá",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Aracruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 841,
                Nome = "Aracruz",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Atílio Vivacqua
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 842,
                Nome = "Atílio Vivacqua",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Baixo Guandu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 843,
                Nome = "Baixo Guandu",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Barra de São Francisco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 844,
                Nome = "Barra de São Francisco",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Boa Esperança
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 845,
                Nome = "Boa Esperança",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Bom Jesus do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 846,
                Nome = "Bom Jesus do Norte",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Brejetuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 847,
                Nome = "Brejetuba",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Cachoeiro de Itapemirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 848,
                Nome = "Cachoeiro de Itapemirim",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Cariacica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 849,
                Nome = "Cariacica",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Castelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 850,
                Nome = "Castelo",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Colatina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 851,
                Nome = "Colatina",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Conceição da Barra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 852,
                Nome = "Conceição da Barra",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Conceição do Castelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 853,
                Nome = "Conceição do Castelo",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Divino de São Lourenço
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 854,
                Nome = "Divino de São Lourenço",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Domingos Martins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 855,
                Nome = "Domingos Martins",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Dores do Rio Preto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 856,
                Nome = "Dores do Rio Preto",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Ecoporanga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 857,
                Nome = "Ecoporanga",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Fundão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 858,
                Nome = "Fundão",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Governador Lindenberg
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 859,
                Nome = "Governador Lindenberg",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Guaçuí
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 860,
                Nome = "Guaçuí",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Guarapari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 861,
                Nome = "Guarapari",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Ibatiba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 862,
                Nome = "Ibatiba",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Ibiraçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 863,
                Nome = "Ibiraçu",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Ibitirama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 864,
                Nome = "Ibitirama",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Iconha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 865,
                Nome = "Iconha",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Irupi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 866,
                Nome = "Irupi",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Itaguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 867,
                Nome = "Itaguaçu",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Itapemirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 868,
                Nome = "Itapemirim",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Itarana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 869,
                Nome = "Itarana",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Iúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 870,
                Nome = "Iúna",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Jaguaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 871,
                Nome = "Jaguaré",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Jerônimo Monteiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 872,
                Nome = "Jerônimo Monteiro",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: João Neiva
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 873,
                Nome = "João Neiva",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Laranja da Terra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 874,
                Nome = "Laranja da Terra",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Linhares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 875,
                Nome = "Linhares",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Mantenópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 876,
                Nome = "Mantenópolis",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Marataízes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 877,
                Nome = "Marataízes",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Marechal Floriano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 878,
                Nome = "Marechal Floriano",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Marilândia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 879,
                Nome = "Marilândia",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Mimoso do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 880,
                Nome = "Mimoso do Sul",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Montanha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 881,
                Nome = "Montanha",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Mucurici
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 882,
                Nome = "Mucurici",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Muniz Freire
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 883,
                Nome = "Muniz Freire",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Muqui
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 884,
                Nome = "Muqui",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Nova Venécia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 885,
                Nome = "Nova Venécia",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Pancas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 886,
                Nome = "Pancas",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Pedro Canário
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 887,
                Nome = "Pedro Canário",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Pinheiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 888,
                Nome = "Pinheiros",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Piúma
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 889,
                Nome = "Piúma",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Ponto Belo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 890,
                Nome = "Ponto Belo",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Presidente Kennedy
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 891,
                Nome = "Presidente Kennedy",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Rio Bananal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 892,
                Nome = "Rio Bananal",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Rio Novo do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 893,
                Nome = "Rio Novo do Sul",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Santa Leopoldina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 894,
                Nome = "Santa Leopoldina",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Santa Maria de Jetibá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 895,
                Nome = "Santa Maria de Jetibá",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Santa Teresa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 896,
                Nome = "Santa Teresa",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: São Domingos do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 897,
                Nome = "São Domingos do Norte",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: São Gabriel da Palha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 898,
                Nome = "São Gabriel da Palha",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: São José do Calçado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 899,
                Nome = "São José do Calçado",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: São Mateus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 900,
                Nome = "São Mateus",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: São Roque do Canaã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 901,
                Nome = "São Roque do Canaã",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Serra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 902,
                Nome = "Serra",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Sooretama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 903,
                Nome = "Sooretama",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Vargem Alta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 904,
                Nome = "Vargem Alta",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Venda Nova do Imigrante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 905,
                Nome = "Venda Nova do Imigrante",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Viana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 906,
                Nome = "Viana",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Vila Pavão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 907,
                Nome = "Vila Pavão",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Vila Valério
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 908,
                Nome = "Vila Valério",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Vila Velha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 909,
                Nome = "Vila Velha",
                Situacao = "Ativo",
                UF = "ES"
            });

            // cidade: Vitória
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 910,
                Nome = "Vitória",
                Situacao = "Ativo",
                UF = "ES"
            });


            await _context.SaveChangesAsync();
        }
    }
}
