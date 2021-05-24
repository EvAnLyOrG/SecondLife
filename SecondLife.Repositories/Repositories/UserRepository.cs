using SecondLife.Model;
using SecondLife.Model.Entities;

namespace SecondLife.Repositories.Repositories
{
    public class UserRepository : GenericRepository<User>, IRepository<User>
    {
        public UserRepository(SalesDbContext context) : base(context) { }
    }
}
