using Microsoft.EntityFrameworkCore;
using SecondLife.Model.Entities;

namespace SecondLife.Model
{
    public class SalesDbContext : DbContext
    {
        public DbSet<Annonce> Annonces { get; set; }
        public DbSet<User> User { get; set; }


        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {

        }
    }
}
