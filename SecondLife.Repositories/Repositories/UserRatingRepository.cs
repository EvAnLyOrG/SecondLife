using SecondLife.Model;
using SecondLife.Model.Entities;

namespace SecondLife.Repositories.Repositories
{
    public class UserRatingRepository : GenericRepository<UserRating>, IRepository<UserRating>
    {
        public UserRatingRepository(SalesDbContext context) : base(context) { }
    }
}
