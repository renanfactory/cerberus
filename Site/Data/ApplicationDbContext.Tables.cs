﻿using Microsoft.EntityFrameworkCore;
using Site.Data.Entities;

namespace Site.Data
{
    public partial class ApplicationDbContext
    {
        public DbSet<UF> Estados { get; set; }
        public DbSet<GrupoEconomico> GruposEconomicos { get;set;}
    }
}
