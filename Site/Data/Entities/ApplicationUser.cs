﻿using Microsoft.AspNetCore.Identity;

namespace Site.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
