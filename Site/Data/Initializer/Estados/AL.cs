using System;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class AL
    {
        private readonly ApplicationDbContext _context;

        public AL(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: AL
            //----------------------------------------------------

            // cidade: Água Branca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 23,
                Nome = "Água Branca",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Anadia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 24,
                Nome = "Anadia",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Arapiraca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 25,
                Nome = "Arapiraca",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Atalaia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 26,
                Nome = "Atalaia",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Barra de Santo Antônio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 27,
                Nome = "Barra de Santo Antônio",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Barra de São Miguel
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 28,
                Nome = "Barra de São Miguel",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Batalha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 29,
                Nome = "Batalha",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Belém
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 30,
                Nome = "Belém",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Belo Monte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 31,
                Nome = "Belo Monte",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Boca da Mata
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 32,
                Nome = "Boca da Mata",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Branquinha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 33,
                Nome = "Branquinha",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Cacimbinhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 34,
                Nome = "Cacimbinhas",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Cajueiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 35,
                Nome = "Cajueiro",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Campestre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 36,
                Nome = "Campestre",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Campo Alegre
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 37,
                Nome = "Campo Alegre",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Campo Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 38,
                Nome = "Campo Grande",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Canapi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 39,
                Nome = "Canapi",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Capela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 40,
                Nome = "Capela",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Carneiros
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 41,
                Nome = "Carneiros",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Chã Preta
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 42,
                Nome = "Chã Preta",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Coité do Nóia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 43,
                Nome = "Coité do Nóia",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Colônia Leopoldina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 44,
                Nome = "Colônia Leopoldina",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Coqueiro Seco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 45,
                Nome = "Coqueiro Seco",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Coruripe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 46,
                Nome = "Coruripe",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Craíbas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 47,
                Nome = "Craíbas",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Delmiro Gouveia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 48,
                Nome = "Delmiro Gouveia",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Dois Riachos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 49,
                Nome = "Dois Riachos",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Estrela de Alagoas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 50,
                Nome = "Estrela de Alagoas",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Feira Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 51,
                Nome = "Feira Grande",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Feliz Deserto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 52,
                Nome = "Feliz Deserto",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Flexeiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 53,
                Nome = "Flexeiras",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Girau do Ponciano
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 54,
                Nome = "Girau do Ponciano",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Ibateguara
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 55,
                Nome = "Ibateguara",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Igaci
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 56,
                Nome = "Igaci",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Igreja Nova
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 57,
                Nome = "Igreja Nova",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Inhapi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 58,
                Nome = "Inhapi",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Jacaré dos Homens
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 59,
                Nome = "Jacaré dos Homens",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Jacuípe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 60,
                Nome = "Jacuípe",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Japaratinga
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 61,
                Nome = "Japaratinga",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Jaramataia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 62,
                Nome = "Jaramataia",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Jequiá da Praia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 63,
                Nome = "Jequiá da Praia",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Joaquim Gomes
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 64,
                Nome = "Joaquim Gomes",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Jundiá
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 65,
                Nome = "Jundiá",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Junqueiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 66,
                Nome = "Junqueiro",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Lagoa da Canoa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 67,
                Nome = "Lagoa da Canoa",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Limoeiro de Anadia
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 68,
                Nome = "Limoeiro de Anadia",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Maceió
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 69,
                Nome = "Maceió",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Major Isidoro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 70,
                Nome = "Major Isidoro",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Mar Vermelho
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 71,
                Nome = "Mar Vermelho",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Maragogi
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 72,
                Nome = "Maragogi",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Maravilha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 73,
                Nome = "Maravilha",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Marechal Deodoro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 74,
                Nome = "Marechal Deodoro",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Maribondo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 75,
                Nome = "Maribondo",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Mata Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 76,
                Nome = "Mata Grande",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Matriz de Camaragibe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 77,
                Nome = "Matriz de Camaragibe",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Messias
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 78,
                Nome = "Messias",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Minador do Negrão
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 79,
                Nome = "Minador do Negrão",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Monteirópolis
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 80,
                Nome = "Monteirópolis",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Murici
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 81,
                Nome = "Murici",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Novo Lino
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 82,
                Nome = "Novo Lino",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Olho d Água das Flores
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 83,
                Nome = "Olho d Água das Flores",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Olho d Água do Casado
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 84,
                Nome = "Olho d Água do Casado",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Olho d Água Grande
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 85,
                Nome = "Olho d Água Grande",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Olivença
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 86,
                Nome = "Olivença",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Ouro Branco
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 87,
                Nome = "Ouro Branco",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Palestina
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 88,
                Nome = "Palestina",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Palmeira dos Índios
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 89,
                Nome = "Palmeira dos Índios",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Pão de Açúcar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 90,
                Nome = "Pão de Açúcar",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Pariconha
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 91,
                Nome = "Pariconha",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Paripueira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 92,
                Nome = "Paripueira",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Passo de Camaragibe
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 93,
                Nome = "Passo de Camaragibe",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Paulo Jacinto
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 94,
                Nome = "Paulo Jacinto",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Penedo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 95,
                Nome = "Penedo",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Piaçabuçu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 96,
                Nome = "Piaçabuçu",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Pilar
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 97,
                Nome = "Pilar",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Pindoba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 98,
                Nome = "Pindoba",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Piranhas
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 99,
                Nome = "Piranhas",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Poço das Trincheiras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 100,
                Nome = "Poço das Trincheiras",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Porto Calvo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 101,
                Nome = "Porto Calvo",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Porto de Pedras
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 102,
                Nome = "Porto de Pedras",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Porto Real do Colégio
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 103,
                Nome = "Porto Real do Colégio",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Quebrângulo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 104,
                Nome = "Quebrângulo",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Rio Largo
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 105,
                Nome = "Rio Largo",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Roteiro
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 106,
                Nome = "Roteiro",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Santa Luzia do Norte
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 107,
                Nome = "Santa Luzia do Norte",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Santana do Ipanema
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 108,
                Nome = "Santana do Ipanema",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Santana do Mundaú
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 109,
                Nome = "Santana do Mundaú",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: São Brás
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 110,
                Nome = "São Brás",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: São José da Lage
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 111,
                Nome = "São José da Lage",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: São José da Tapera
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 112,
                Nome = "São José da Tapera",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: São Luís do Quitunde
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 113,
                Nome = "São Luís do Quitunde",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: São Miguel dos Campos
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 114,
                Nome = "São Miguel dos Campos",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: São Miguel dos Milagres
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 115,
                Nome = "São Miguel dos Milagres",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: São Sebastião
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 116,
                Nome = "São Sebastião",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Satuba
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 117,
                Nome = "Satuba",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Senador Rui Palmeira
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 118,
                Nome = "Senador Rui Palmeira",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Tanque d Arca
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 119,
                Nome = "Tanque d Arca",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Taquarana
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 120,
                Nome = "Taquarana",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Teotônio Vilela
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 121,
                Nome = "Teotônio Vilela",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Traipu
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 122,
                Nome = "Traipu",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: União dos Palmares
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 123,
                Nome = "União dos Palmares",
                Situacao = "Ativo",
                UF = "AL"
            });

            // cidade: Viçosa
            _context.Cidades.Add(new Entities.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 124,
                Nome = "Viçosa",
                Situacao = "Ativo",
                UF = "AL"
            });



            await _context.SaveChangesAsync();
        }
    }
}
