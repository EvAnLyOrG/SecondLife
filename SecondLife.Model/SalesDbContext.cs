using Microsoft.EntityFrameworkCore;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Model
{
    public class SalesDbContext : DbContext
    {
        public DbSet<Annonce> Annonces { get; set; }

        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {

        }
    }
}
