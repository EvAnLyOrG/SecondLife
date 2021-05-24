using SecondLife.Model;
using SecondLife.Model.Entities;

namespace SecondLife.Repositories.Repositories
{
    public class AnnonceRepository : GenericRepository<Annonce>, IRepository<Annonce>
    {
        private readonly SalesDbContext _context;

        public AnnonceRepository(SalesDbContext context) : base(context)
        {
            _context = context;
        }

    } 
}
