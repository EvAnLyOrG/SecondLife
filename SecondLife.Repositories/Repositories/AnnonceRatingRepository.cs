using SecondLife.Model;
using SecondLife.Model.Entities;

namespace SecondLife.Repositories.Repositories
{
    public class AnnonceRatingRepository: GenericRepository<AnnonceRating>, IRepository<AnnonceRating>
    {
        public AnnonceRatingRepository(SalesDbContext context) : base(context)
        {
        }
    }
}
