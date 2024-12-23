﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Teste_API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Produto> Produtos { get; set; }

    }
}
