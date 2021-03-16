using SecondLife.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AnnonceDbContext _context;

        public Repository(AnnonceDbContext context)
        {
            _context = context;
        }

        public T Add(T annonce)
        {
            throw new NotImplementedException();
        }

        public List<T> All(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(condition).ToList();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(T annonce)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public T One(Expression<Func<T, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public T One(Expression<Func<T, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public void Update(T updatedObject)
        {
            throw new NotImplementedException();
        }
    }
}
