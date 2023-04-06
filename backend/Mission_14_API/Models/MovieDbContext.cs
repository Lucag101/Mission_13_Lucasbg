﻿using Microsoft.EntityFrameworkCore;

namespace Mission_14_API.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options) : base(options) { }
        public DbSet<MovieCollection> Movies { get; set; }
    }
}
