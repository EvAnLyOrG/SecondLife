using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public T Add(T annonce)
        {
            _context.Add(annonce);
            _context.SaveChanges();
            return annonce;
        }

        public List<T> All()
        {
            return _context.Set<T>().ToList();
        }

        public T Remove(T annonce)
        {
            _context.Remove(annonce);
            _context.SaveChanges();
            return annonce;
        }

        public bool Exists(T annonce)
        {
            throw new NotImplementedException();
        }

        public T One(int id)
        {
            return _context.Set<T>().FirstOrDefault();
        }

        public T Update(T annonce)
        {
            throw new NotImplementedException();
        }
    }
}
