﻿using InventoryBeginners.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryBeginners.Data
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<Movie> Movies { get; set; }
    }
}
