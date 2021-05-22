using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Repositories.Repositories;

namespace SecondLife.Services.Validators
{
    class GenericValidator<T> : IValidator<T> where T : class
    {
        protected readonly IRepository<T> _repo;

        public GenericValidator(IRepository<T> repo)
        {
            _repo = repo;
        }
    }
}
