using System;
using System.Collections.Generic;
using System.Linq;
using SecondLife.Model;

namespace SecondLife.Repositories.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly SalesDbContext _context;

        public GenericRepository(SalesDbContext context)
        {
            _context = context;
        }

        public T Add(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public List<T> All()
        {
            return _context.Set<T>().ToList();
        }

        public T Remove(T obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
            return obj;
        }

        public bool Exists(T obj)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Equals(obj)) != null;
        }

        public T One(int id)
        {
            return _context.Set<T>().FirstOrDefault();
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
