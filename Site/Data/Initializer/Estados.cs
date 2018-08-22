using System;

namespace Site.Data.Initializer
{
    public class EstadosInitializer
    {
        private readonly ApplicationDbContext _context;

        public EstadosInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task InitializeAsync()
        {
            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "AC",
                UnidadeFederativa = "Acre",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "AL",
                UnidadeFederativa = "Alagoas",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "AM",
                UnidadeFederativa = "Amazonas",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "Ap",
                UnidadeFederativa = "Amapá",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "BA",
                UnidadeFederativa = "Bahia",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "CE",
                UnidadeFederativa = "Ceará",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "DF",
                UnidadeFederativa = "Distrito Federal",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "ES",
                UnidadeFederativa = "Espírito Santo",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "GO",
                UnidadeFederativa = "Goiás",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "MA",
                UnidadeFederativa = "Maranhão",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "MG",
                UnidadeFederativa = "Minas Gerais",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "MS",
                UnidadeFederativa = "Mato Grosso do Sul",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "MT",
                UnidadeFederativa = "Mato Grosso",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "PA",
                UnidadeFederativa = "Pará",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "PB",
                UnidadeFederativa = "Paraíba",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "PE",
                UnidadeFederativa = "Pernambuco",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "PI",
                UnidadeFederativa = "Piauí",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "PR",
                UnidadeFederativa = "Paraná",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "RJ",
                UnidadeFederativa = "Rio de Janeiro",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "RN",
                UnidadeFederativa = "Rio Grande do Norte",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "RO",
                UnidadeFederativa = "Rondônia",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "RR",
                UnidadeFederativa = "Roraima",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "RS",
                UnidadeFederativa = "Rio Grande do Sul",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "SC",
                UnidadeFederativa = "Santa Catarina",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "SE",
                UnidadeFederativa = "Sergipe",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "SP",
                UnidadeFederativa = "São Paulo",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.Estados.AddAsync(new Entities.UF()
            {
                Id = "TO",
                UnidadeFederativa = "Tocantins",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await _context.SaveChangesAsync();
        }
    }
}
