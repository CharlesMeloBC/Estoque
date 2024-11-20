﻿using Estoque.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<ItemModel> Item { get; set; }
    }
}