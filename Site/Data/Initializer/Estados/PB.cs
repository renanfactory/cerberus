using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Initializer.Estados
{
    public class PB
    {
        private readonly ApplicationDbContext _context;

        public PB(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitializeAsync()
        {
            // Estado: PB
            //----------------------------------------------------

            // cidade: Água Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2590,
                Nome = "Água Branca",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Aguiar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2591,
                Nome = "Aguiar",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Alagoa Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2592,
                Nome = "Alagoa Grande",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Alagoa Nova
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2593,
                Nome = "Alagoa Nova",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Alagoinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2594,
                Nome = "Alagoinha",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Alcantil
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2595,
                Nome = "Alcantil",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Algodão de Jandaíra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2596,
                Nome = "Algodão de Jandaíra",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Alhandra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2597,
                Nome = "Alhandra",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Amparo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2598,
                Nome = "Amparo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Aparecida
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2599,
                Nome = "Aparecida",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Araçagi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2600,
                Nome = "Araçagi",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Arara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2601,
                Nome = "Arara",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Araruna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2602,
                Nome = "Araruna",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Areia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2603,
                Nome = "Areia",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Areia de Baraúnas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2604,
                Nome = "Areia de Baraúnas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Areial
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2605,
                Nome = "Areial",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Aroeiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2606,
                Nome = "Aroeiras",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Assunção
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2607,
                Nome = "Assunção",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Baía da Traição
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2608,
                Nome = "Baía da Traição",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Bananeiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2609,
                Nome = "Bananeiras",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Baraúna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2610,
                Nome = "Baraúna",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Barra de Santa Rosa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2611,
                Nome = "Barra de Santa Rosa",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Barra de Santana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2612,
                Nome = "Barra de Santana",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Barra de São Miguel
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2613,
                Nome = "Barra de São Miguel",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Bayeux
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2614,
                Nome = "Bayeux",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Belém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2615,
                Nome = "Belém",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Belém do Brejo do Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2616,
                Nome = "Belém do Brejo do Cruz",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Bernardino Batista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2617,
                Nome = "Bernardino Batista",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Boa Ventura
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2618,
                Nome = "Boa Ventura",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Boa Vista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2619,
                Nome = "Boa Vista",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Bom Jesus
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2620,
                Nome = "Bom Jesus",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Bom Sucesso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2621,
                Nome = "Bom Sucesso",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Bonito de Santa Fé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2622,
                Nome = "Bonito de Santa Fé",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Boqueirão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2623,
                Nome = "Boqueirão",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Borborema
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2624,
                Nome = "Borborema",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Brejo do Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2625,
                Nome = "Brejo do Cruz",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Brejo dos Santos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2626,
                Nome = "Brejo dos Santos",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Caaporã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2627,
                Nome = "Caaporã",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cabaceiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2628,
                Nome = "Cabaceiras",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cabedelo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2629,
                Nome = "Cabedelo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cachoeira dos Índios
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2630,
                Nome = "Cachoeira dos Índios",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cacimba de Areia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2631,
                Nome = "Cacimba de Areia",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cacimba de Dentro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2632,
                Nome = "Cacimba de Dentro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cacimbas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2633,
                Nome = "Cacimbas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Caiçara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2634,
                Nome = "Caiçara",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cajazeiras
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2635,
                Nome = "Cajazeiras",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cajazeirinhas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2636,
                Nome = "Cajazeirinhas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Caldas Brandão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2637,
                Nome = "Caldas Brandão",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Camalaú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2638,
                Nome = "Camalaú",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Campina Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2639,
                Nome = "Campina Grande",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Capim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2640,
                Nome = "Capim",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Caraúbas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2641,
                Nome = "Caraúbas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Carrapateira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2642,
                Nome = "Carrapateira",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Casserengue
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2643,
                Nome = "Casserengue",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Catingueira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2644,
                Nome = "Catingueira",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Catolé do Rocha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2645,
                Nome = "Catolé do Rocha",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Caturité
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2646,
                Nome = "Caturité",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Conceição
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2647,
                Nome = "Conceição",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Condado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2648,
                Nome = "Condado",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Conde
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2649,
                Nome = "Conde",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Congo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2650,
                Nome = "Congo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Coremas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2651,
                Nome = "Coremas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Coxixola
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2652,
                Nome = "Coxixola",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cruz do Espírito Santo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2653,
                Nome = "Cruz do Espírito Santo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cubati
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2654,
                Nome = "Cubati",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cuité
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2655,
                Nome = "Cuité",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cuité de Mamanguape
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2656,
                Nome = "Cuité de Mamanguape",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Cuitegi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2657,
                Nome = "Cuitegi",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Curral de Cima
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2658,
                Nome = "Curral de Cima",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Curral Velho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2659,
                Nome = "Curral Velho",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Damião
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2660,
                Nome = "Damião",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Desterro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2661,
                Nome = "Desterro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Diamante
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2662,
                Nome = "Diamante",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Dona Inês
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2663,
                Nome = "Dona Inês",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Duas Estradas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2664,
                Nome = "Duas Estradas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Emas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2665,
                Nome = "Emas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Esperança
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2666,
                Nome = "Esperança",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Fagundes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2667,
                Nome = "Fagundes",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Frei Martinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2668,
                Nome = "Frei Martinho",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Gado Bravo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2669,
                Nome = "Gado Bravo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Guarabira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2670,
                Nome = "Guarabira",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Gurinhém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2671,
                Nome = "Gurinhém",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Gurjão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2672,
                Nome = "Gurjão",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Ibiara
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2673,
                Nome = "Ibiara",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Igaraci
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2674,
                Nome = "Igaraci",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Imaculada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2675,
                Nome = "Imaculada",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Ingá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2676,
                Nome = "Ingá",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Itabaiana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2677,
                Nome = "Itabaiana",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Itaporanga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2678,
                Nome = "Itaporanga",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Itapororoca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2679,
                Nome = "Itapororoca",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Itatuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2680,
                Nome = "Itatuba",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Jacaraú
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2681,
                Nome = "Jacaraú",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Jericó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2682,
                Nome = "Jericó",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: João Pessoa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2683,
                Nome = "João Pessoa",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Juarez Távora
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2684,
                Nome = "Juarez Távora",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Juazeirinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2685,
                Nome = "Juazeirinho",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Junco do Seridó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2686,
                Nome = "Junco do Seridó",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Juripiranga
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2687,
                Nome = "Juripiranga",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Juru
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2688,
                Nome = "Juru",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Lagoa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2689,
                Nome = "Lagoa",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Lagoa de Dentro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2690,
                Nome = "Lagoa de Dentro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Lagoa Seca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2691,
                Nome = "Lagoa Seca",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Lastro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2692,
                Nome = "Lastro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Livramento
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2693,
                Nome = "Livramento",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Logradouro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2694,
                Nome = "Logradouro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Lucena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2695,
                Nome = "Lucena",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Mãe d Água
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2696,
                Nome = "Mãe d Água",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Malta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2697,
                Nome = "Malta",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Mamanguape
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2698,
                Nome = "Mamanguape",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Manaíra
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2699,
                Nome = "Manaíra",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Marcação
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2700,
                Nome = "Marcação",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Mari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2701,
                Nome = "Mari",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Marizópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2702,
                Nome = "Marizópolis",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Massaranduba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2703,
                Nome = "Massaranduba",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Mataraca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2704,
                Nome = "Mataraca",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Matinhas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2705,
                Nome = "Matinhas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Mato Grosso
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2706,
                Nome = "Mato Grosso",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Maturéia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2707,
                Nome = "Maturéia",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Mogeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2708,
                Nome = "Mogeiro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Montadas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2709,
                Nome = "Montadas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Monte Horebe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2710,
                Nome = "Monte Horebe",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Monteiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2711,
                Nome = "Monteiro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Mulungu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2712,
                Nome = "Mulungu",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Natuba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2713,
                Nome = "Natuba",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Nazarezinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2714,
                Nome = "Nazarezinho",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Nova Floresta
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2715,
                Nome = "Nova Floresta",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Nova Olinda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2716,
                Nome = "Nova Olinda",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Nova Palmeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2717,
                Nome = "Nova Palmeira",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Olho d Água
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2718,
                Nome = "Olho d Água",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Olivedos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2719,
                Nome = "Olivedos",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Ouro Velho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2720,
                Nome = "Ouro Velho",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Parari
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2721,
                Nome = "Parari",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Passagem
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2722,
                Nome = "Passagem",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Patos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2723,
                Nome = "Patos",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Paulista
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2724,
                Nome = "Paulista",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pedra Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2725,
                Nome = "Pedra Branca",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pedra Lavrada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2726,
                Nome = "Pedra Lavrada",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pedras de Fogo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2727,
                Nome = "Pedras de Fogo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Piancó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2728,
                Nome = "Piancó",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Picuí
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2729,
                Nome = "Picuí",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pilar
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2730,
                Nome = "Pilar",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pilões
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2731,
                Nome = "Pilões",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pilõezinhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2732,
                Nome = "Pilõezinhos",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pirpirituba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2733,
                Nome = "Pirpirituba",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pitimbu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2734,
                Nome = "Pitimbu",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pocinhos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2735,
                Nome = "Pocinhos",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Poço Dantas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2736,
                Nome = "Poço Dantas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Poço de José de Moura
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2737,
                Nome = "Poço de José de Moura",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Pombal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2738,
                Nome = "Pombal",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Prata
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2739,
                Nome = "Prata",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Princesa Isabel
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2740,
                Nome = "Princesa Isabel",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Puxinanã
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2741,
                Nome = "Puxinanã",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Queimadas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2742,
                Nome = "Queimadas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Quixaba
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2743,
                Nome = "Quixaba",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Remígio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2744,
                Nome = "Remígio",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Retiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2745,
                Nome = "Retiro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Riachão
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2746,
                Nome = "Riachão",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Riachão do Bacamarte
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2747,
                Nome = "Riachão do Bacamarte",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Riachão do Poço
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2748,
                Nome = "Riachão do Poço",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Riacho de Santo Antônio
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2749,
                Nome = "Riacho de Santo Antônio",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Riacho dos Cavalos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2750,
                Nome = "Riacho dos Cavalos",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Rio Tinto
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2751,
                Nome = "Rio Tinto",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Salgadinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2752,
                Nome = "Salgadinho",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Salgado de São Félix
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2753,
                Nome = "Salgado de São Félix",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santa Cecília
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2754,
                Nome = "Santa Cecília",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santa Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2755,
                Nome = "Santa Cruz",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santa Helena
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2756,
                Nome = "Santa Helena",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santa Inês
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2757,
                Nome = "Santa Inês",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santa Luzia
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2758,
                Nome = "Santa Luzia",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santa Rita
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2759,
                Nome = "Santa Rita",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santa Teresinha
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2760,
                Nome = "Santa Teresinha",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santana de Mangueira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2761,
                Nome = "Santana de Mangueira",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santana dos Garrotes
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2762,
                Nome = "Santana dos Garrotes",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santarém
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2763,
                Nome = "Santarém",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Santo André
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2764,
                Nome = "Santo André",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Bento
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2765,
                Nome = "São Bento",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Bento de Pombal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2766,
                Nome = "São Bento de Pombal",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Domingos de Pombal
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2767,
                Nome = "São Domingos de Pombal",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Domingos do Cariri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2768,
                Nome = "São Domingos do Cariri",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Francisco
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2769,
                Nome = "São Francisco",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São João do Cariri
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2770,
                Nome = "São João do Cariri",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São João do Rio do Peixe
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2771,
                Nome = "São João do Rio do Peixe",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São João do Tigre
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2772,
                Nome = "São João do Tigre",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José da Lagoa Tapada
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2773,
                Nome = "São José da Lagoa Tapada",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José de Caiana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2774,
                Nome = "São José de Caiana",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José de Espinharas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2775,
                Nome = "São José de Espinharas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José de Piranhas
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2776,
                Nome = "São José de Piranhas",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José de Princesa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2777,
                Nome = "São José de Princesa",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José do Bonfim
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2778,
                Nome = "São José do Bonfim",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José do Brejo do Cruz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2779,
                Nome = "São José do Brejo do Cruz",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José do Sabugi
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2780,
                Nome = "São José do Sabugi",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José dos Cordeiros
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2781,
                Nome = "São José dos Cordeiros",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São José dos Ramos
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2782,
                Nome = "São José dos Ramos",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Mamede
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2783,
                Nome = "São Mamede",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Miguel de Taipu
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2784,
                Nome = "São Miguel de Taipu",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Sebastião de Lagoa de Roça
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2785,
                Nome = "São Sebastião de Lagoa de Roça",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Sebastião do Umbuzeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2786,
                Nome = "São Sebastião do Umbuzeiro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: São Vicente do Seridó
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2787,
                Nome = "São Vicente do Seridó",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Sapé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2788,
                Nome = "Sapé",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Serra Branca
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2789,
                Nome = "Serra Branca",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Serra da Raiz
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2790,
                Nome = "Serra da Raiz",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Serra Grande
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2791,
                Nome = "Serra Grande",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Serra Redonda
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2792,
                Nome = "Serra Redonda",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Serraria
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2793,
                Nome = "Serraria",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Sertãozinho
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2794,
                Nome = "Sertãozinho",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Sobrado
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2795,
                Nome = "Sobrado",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Solânea
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2796,
                Nome = "Solânea",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Soledade
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2797,
                Nome = "Soledade",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Sossêgo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2798,
                Nome = "Sossêgo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Sousa
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2799,
                Nome = "Sousa",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Sumé
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2800,
                Nome = "Sumé",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Tacima
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2801,
                Nome = "Tacima",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Taperoá
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2802,
                Nome = "Taperoá",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Tavares
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2803,
                Nome = "Tavares",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Teixeira
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2804,
                Nome = "Teixeira",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Tenório
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2805,
                Nome = "Tenório",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Triunfo
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2806,
                Nome = "Triunfo",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Uiraúna
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2807,
                Nome = "Uiraúna",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Umbuzeiro
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2808,
                Nome = "Umbuzeiro",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Várzea
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2809,
                Nome = "Várzea",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Vieirópolis
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2810,
                Nome = "Vieirópolis",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Vista Serrana
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2811,
                Nome = "Vista Serrana",
                Situacao = "Ativo",
                UF = "PB"
            });

            // cidade: Zabelê
            _context.Cidades.Add(new Entities.Domains.Cidade()
            {
                DataCriacao = DateTime.Now,
                Id = 2812,
                Nome = "Zabelê",
                Situacao = "Ativo",
                UF = "PB"
            });


            await _context.SaveChangesAsync();
        }
    }
}
