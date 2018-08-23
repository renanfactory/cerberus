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
            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "AC",
                UnidadeFederativa = "Acre",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await new Estados.AC(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "AL",
                UnidadeFederativa = "Alagoas",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.AL(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "AM",
                UnidadeFederativa = "Amazonas",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });

            await new Estados.AM(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "Ap",
                UnidadeFederativa = "Amapá",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.AP(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "BA",
                UnidadeFederativa = "Bahia",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.BA(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "CE",
                UnidadeFederativa = "Ceará",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.CE(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "DF",
                UnidadeFederativa = "Distrito Federal",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.DF(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "ES",
                UnidadeFederativa = "Espírito Santo",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.ES(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "GO",
                UnidadeFederativa = "Goiás",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.GO(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "MA",
                UnidadeFederativa = "Maranhão",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.MA(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "MG",
                UnidadeFederativa = "Minas Gerais",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.MG(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "MS",
                UnidadeFederativa = "Mato Grosso do Sul",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.MS(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "MT",
                UnidadeFederativa = "Mato Grosso",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.MT(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "PA",
                UnidadeFederativa = "Pará",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.PA(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "PB",
                UnidadeFederativa = "Paraíba",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.PB(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "PE",
                UnidadeFederativa = "Pernambuco",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.PE(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "PI",
                UnidadeFederativa = "Piauí",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.PI(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "PR",
                UnidadeFederativa = "Paraná",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.PR(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "RJ",
                UnidadeFederativa = "Rio de Janeiro",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.RJ(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "RN",
                UnidadeFederativa = "Rio Grande do Norte",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.RN(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "RO",
                UnidadeFederativa = "Rondônia",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.RO(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "RR",
                UnidadeFederativa = "Roraima",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.RR(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "RS",
                UnidadeFederativa = "Rio Grande do Sul",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.RS(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "SC",
                UnidadeFederativa = "Santa Catarina",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.SC(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "SE",
                UnidadeFederativa = "Sergipe",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.SE(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "SP",
                UnidadeFederativa = "São Paulo",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.SP(_context).InitializeAsync();

            await _context.Estados.AddAsync(new Entities.Domains.UF()
            {
                Id = "TO",
                UnidadeFederativa = "Tocantins",
                DataCriacao = DateTime.Now,
                Situacao = "Ativo"
            });
            await new Estados.TO(_context).InitializeAsync();
        }
    }
}
