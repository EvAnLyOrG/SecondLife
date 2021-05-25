using SecondLife.Model;
using SecondLife.Model.Entities;

namespace SecondLife.Repositories.Repositories
{
    public class AnnonceRepository : GenericRepository<Annonce>, IRepository<Annonce>
    {

        public AnnonceRepository(SalesDbContext context) : base(context)
        {
        }

    } 
}
