using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;

namespace SecondLife.Services.Validators
{
    public class AnnonceValidator : GenericValidator<Annonce>, IValidator<Annonce>
    {
        private IRepository<User> _repoUser;
        public AnnonceValidator(IRepository<Annonce> repo, IRepository<User> repoUser) : base(repo)
        {
            _repoUser = repoUser;
        }
    }
}
