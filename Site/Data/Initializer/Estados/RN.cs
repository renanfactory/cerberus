using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class RN
    {
        private readonly ApplicationDbContext _context;

        public RN(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: RN
            //----------------------------------------------------

            // cidade: Acari
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3711,
                Nome = "Acari",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Açu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3712,
                Nome = "Açu",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Afonso Bezerra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3713,
                Nome = "Afonso Bezerra",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Água Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3714,
                Nome = "Água Nova",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Alexandria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3715,
                Nome = "Alexandria",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Almino Afonso
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3716,
                Nome = "Almino Afonso",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Alto do Rodrigues
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3717,
                Nome = "Alto do Rodrigues",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Angicos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3718,
                Nome = "Angicos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Antônio Martins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3719,
                Nome = "Antônio Martins",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Apodi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3720,
                Nome = "Apodi",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Areia Branca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3721,
                Nome = "Areia Branca",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Arês
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3722,
                Nome = "Arês",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Baía Formosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3723,
                Nome = "Baía Formosa",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Baraúna
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3724,
                Nome = "Baraúna",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Barcelona
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3725,
                Nome = "Barcelona",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Bento Fernandes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3726,
                Nome = "Bento Fernandes",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Bodo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3727,
                Nome = "Bodo",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Bom Jesus
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3728,
                Nome = "Bom Jesus",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Brejinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3729,
                Nome = "Brejinho",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Caiçara do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3730,
                Nome = "Caiçara do Norte",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Caiçara do Rio do Vento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3731,
                Nome = "Caiçara do Rio do Vento",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Caicó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3732,
                Nome = "Caicó",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Campo Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3733,
                Nome = "Campo Grande",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Campo Redondo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3734,
                Nome = "Campo Redondo",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Canguaretama
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3735,
                Nome = "Canguaretama",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Carnaúba dos Dantas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3736,
                Nome = "Carnaúba dos Dantas",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Carnaubais
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3737,
                Nome = "Carnaubais",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Ceará Mirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3738,
                Nome = "Ceará Mirim",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Cerro Corá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3739,
                Nome = "Cerro Corá",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Coronel Ezequiel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3740,
                Nome = "Coronel Ezequiel",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Coronel João Pessoa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3741,
                Nome = "Coronel João Pessoa",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Cruzeta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3742,
                Nome = "Cruzeta",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Currais Novos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3743,
                Nome = "Currais Novos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Doutor Severiano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3744,
                Nome = "Doutor Severiano",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Encanto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3745,
                Nome = "Encanto",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Equador
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3746,
                Nome = "Equador",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Espírito Santo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3747,
                Nome = "Espírito Santo",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Extremoz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3748,
                Nome = "Extremoz",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Felipe Guerra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3749,
                Nome = "Felipe Guerra",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Fernando Pedroza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3750,
                Nome = "Fernando Pedroza",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Florânia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3751,
                Nome = "Florânia",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Francisco Dantas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3752,
                Nome = "Francisco Dantas",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Frutuoso Gomes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3753,
                Nome = "Frutuoso Gomes",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Galinhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3754,
                Nome = "Galinhos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Goianinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3755,
                Nome = "Goianinha",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Governador Dix Sept Rosado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3756,
                Nome = "Governador Dix Sept Rosado",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Grossos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3757,
                Nome = "Grossos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Guamaré
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3758,
                Nome = "Guamaré",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Ielmo Marinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3759,
                Nome = "Ielmo Marinho",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Ipanguaçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3760,
                Nome = "Ipanguaçu",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Ipueira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3761,
                Nome = "Ipueira",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Itajá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3762,
                Nome = "Itajá",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Itaú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3763,
                Nome = "Itaú",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Jaçanã
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3764,
                Nome = "Jaçanã",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Jandaíra
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3765,
                Nome = "Jandaíra",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Janduís
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3766,
                Nome = "Janduís",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Januário Cicco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3767,
                Nome = "Januário Cicco",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Japi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3768,
                Nome = "Japi",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Jardim de Angicos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3769,
                Nome = "Jardim de Angicos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Jardim de Piranhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3770,
                Nome = "Jardim de Piranhas",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Jardim do Seridó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3771,
                Nome = "Jardim do Seridó",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: João Câmara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3772,
                Nome = "João Câmara",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: João Dias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3773,
                Nome = "João Dias",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: José da Penha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3774,
                Nome = "José da Penha",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Jucurutu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3775,
                Nome = "Jucurutu",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Jundiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3776,
                Nome = "Jundiá",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lagoa d Anta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3777,
                Nome = "Lagoa d Anta",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lagoa de Pedras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3778,
                Nome = "Lagoa de Pedras",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lagoa de Velhos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3779,
                Nome = "Lagoa de Velhos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lagoa Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3780,
                Nome = "Lagoa Nova",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lagoa Salgada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3781,
                Nome = "Lagoa Salgada",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lajes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3782,
                Nome = "Lajes",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lajes Pintadas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3783,
                Nome = "Lajes Pintadas",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Lucrécia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3784,
                Nome = "Lucrécia",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Luís Gomes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3785,
                Nome = "Luís Gomes",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Macaíba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3786,
                Nome = "Macaíba",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Macau
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3787,
                Nome = "Macau",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Major Sales
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3788,
                Nome = "Major Sales",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Marcelino Vieira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3789,
                Nome = "Marcelino Vieira",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Martins
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3790,
                Nome = "Martins",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Maxaranguape
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3791,
                Nome = "Maxaranguape",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Messias Targino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3792,
                Nome = "Messias Targino",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Montanhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3793,
                Nome = "Montanhas",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Monte Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3794,
                Nome = "Monte Alegre",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Monte das Gameleiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3795,
                Nome = "Monte das Gameleiras",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Mossoró
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3796,
                Nome = "Mossoró",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Natal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3797,
                Nome = "Natal",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Nísia Floresta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3798,
                Nome = "Nísia Floresta",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Nova Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3799,
                Nome = "Nova Cruz",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Olho d Água do Borges
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3800,
                Nome = "Olho d Água do Borges",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Ouro Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3801,
                Nome = "Ouro Branco",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Paraná
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3802,
                Nome = "Paraná",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Paraú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3803,
                Nome = "Paraú",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Parazinho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3804,
                Nome = "Parazinho",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Parelhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3805,
                Nome = "Parelhas",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Parnamirim
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3806,
                Nome = "Parnamirim",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Passa e Fica
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3807,
                Nome = "Passa e Fica",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Passagem
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3808,
                Nome = "Passagem",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Patu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3809,
                Nome = "Patu",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pau dos Ferros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3810,
                Nome = "Pau dos Ferros",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pedra Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3811,
                Nome = "Pedra Grande",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pedra Preta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3812,
                Nome = "Pedra Preta",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pedro Avelino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3813,
                Nome = "Pedro Avelino",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pedro Velho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3814,
                Nome = "Pedro Velho",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pendências
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3815,
                Nome = "Pendências",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pilões
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3816,
                Nome = "Pilões",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Poço Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3817,
                Nome = "Poço Branco",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Portalegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3818,
                Nome = "Portalegre",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Porto do Mangue
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3819,
                Nome = "Porto do Mangue",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Pureza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3820,
                Nome = "Pureza",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Rafael Fernandes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3821,
                Nome = "Rafael Fernandes",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Rafael Godeiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3822,
                Nome = "Rafael Godeiro",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Riacho da Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3823,
                Nome = "Riacho da Cruz",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Riacho de Santana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3824,
                Nome = "Riacho de Santana",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Riachuelo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3825,
                Nome = "Riachuelo",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Rio do Fogo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3826,
                Nome = "Rio do Fogo",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Rodolfo Fernandes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3827,
                Nome = "Rodolfo Fernandes",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Ruy Barbosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3828,
                Nome = "Ruy Barbosa",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Santa Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3829,
                Nome = "Santa Cruz",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Santa Maria
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3830,
                Nome = "Santa Maria",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Santana do Matos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3831,
                Nome = "Santana do Matos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Santana do Seridó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3832,
                Nome = "Santana do Seridó",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Santo Antônio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3833,
                Nome = "Santo Antônio",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Bento do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3834,
                Nome = "São Bento do Norte",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Bento do Trairi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3835,
                Nome = "São Bento do Trairi",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Fernando
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3836,
                Nome = "São Fernando",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Francisco do Oeste
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3837,
                Nome = "São Francisco do Oeste",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Gonçalo do Amarante
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3838,
                Nome = "São Gonçalo do Amarante",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São João do Sabugi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3839,
                Nome = "São João do Sabugi",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São José de Mipibu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3840,
                Nome = "São José de Mipibu",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São José do Campestre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3841,
                Nome = "São José do Campestre",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São José do Seridó
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3842,
                Nome = "São José do Seridó",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Miguel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3843,
                Nome = "São Miguel",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Miguel de Touros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3844,
                Nome = "São Miguel de Touros",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Paulo do Potengi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3845,
                Nome = "São Paulo do Potengi",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Pedro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3846,
                Nome = "São Pedro",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Rafael
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3847,
                Nome = "São Rafael",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Tomé
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3848,
                Nome = "São Tomé",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: São Vicente
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3849,
                Nome = "São Vicente",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Senador Elói de Souza
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3850,
                Nome = "Senador Elói de Souza",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Senador Georgino Avelino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3851,
                Nome = "Senador Georgino Avelino",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Serra Caiada
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3852,
                Nome = "Serra Caiada",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Serra de São Bento
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3853,
                Nome = "Serra de São Bento",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Serra do Mel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3854,
                Nome = "Serra do Mel",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Serra Negra do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3855,
                Nome = "Serra Negra do Norte",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Serrinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3856,
                Nome = "Serrinha",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Serrinha dos Pintos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3857,
                Nome = "Serrinha dos Pintos",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Severiano Melo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3858,
                Nome = "Severiano Melo",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Sítio Novo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3859,
                Nome = "Sítio Novo",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Taboleiro Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3860,
                Nome = "Taboleiro Grande",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Taipu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3861,
                Nome = "Taipu",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Tangará
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3862,
                Nome = "Tangará",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Tenente Ananias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3863,
                Nome = "Tenente Ananias",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Tenente Laurentino Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3864,
                Nome = "Tenente Laurentino Cruz",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Tibau
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3865,
                Nome = "Tibau",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Tibau do Sul
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3866,
                Nome = "Tibau do Sul",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Timbaúba dos Batistas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3867,
                Nome = "Timbaúba dos Batistas",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Touros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3868,
                Nome = "Touros",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Triunfo Potiguar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3869,
                Nome = "Triunfo Potiguar",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Umarizal
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3870,
                Nome = "Umarizal",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Upanema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3871,
                Nome = "Upanema",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Várzea
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3872,
                Nome = "Várzea",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Venha Ver
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3873,
                Nome = "Venha Ver",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Vera Cruz
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3874,
                Nome = "Vera Cruz",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Viçosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3875,
                Nome = "Viçosa",
                Situacao = "Ativo",
                UF = "RN"
            });

            // cidade: Vila Flor
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 3876,
                Nome = "Vila Flor",
                Situacao = "Ativo",
                UF = "RN"
            });

            await _context.SaveChangesAsync();
        }
    }
}
