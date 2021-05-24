using SecondLife.Repositories.Repositories;

namespace SecondLife.Services.Validators
{
    public class GenericValidator<T> : IValidator<T> where T : class
    {
        protected readonly IRepository<T> _repo;

        public GenericValidator(IRepository<T> repo)
        {
            _repo = repo;
        }

        public bool CanAdd(T obj)
        {
            return true;
        }

        public bool CanEdit(T obj)
        {
            return true;
        }

        public bool CanDelete(T obj)
        {
            return true;
        }
        public bool CanGet(T obj)
        {
            return true;
        }
    }
}
