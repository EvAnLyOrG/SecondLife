using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
namespace SecondLife.Services.Validators
{
    public class UserRatingValidator : GenericValidator<UserRating>, IValidator<UserRating>
    {
        public UserRatingValidator(IRepository<UserRating> repo) : base(repo)
        {

        }
    }
}
