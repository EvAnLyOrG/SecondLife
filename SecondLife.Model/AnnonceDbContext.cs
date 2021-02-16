using Microsoft.EntityFrameworkCore;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Model
{
    public class AnnonceDbContext : DbContext
    {
        public DbSet<Annonce> Annonces { get; set; }

        public AnnonceDbContext(DbContextOptions<AnnonceDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "server=localhost;port=3306;database=secondlife;uid=SecondLifeAPI;password=password;TreatTinyAsBoolean=false");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
