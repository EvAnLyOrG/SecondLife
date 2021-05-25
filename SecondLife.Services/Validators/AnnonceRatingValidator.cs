using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;

namespace SecondLife.Services.Validators
{
    public class AnnonceRatingValidator : GenericValidator<AnnonceRating>, IValidator<AnnonceRating>
    {
        public AnnonceRatingValidator(IRepository<AnnonceRating> repo) : base(repo)
        {

        }
    }
}
