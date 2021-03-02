econdLife.Model;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly AnnonceDbContext _context;

        public CityRepository(CityDbContext context)
        {
            _context = context;
        }

        public List<Annonce> All()
        {
            return _context.Citys.ToList();
        }

        public City One()
        {
            return _context.Citys.FirstOrDefault();
        }

        public City Add(City city)
        {
            _context.Add(city);
            _context.SaveChanges();
            return city;
        }

        public bool Exists(City city)
        {
            var dbCity = _context.Citys.FirstOrDefault(x => x.Title == annonce.Title);
            return dbCity != null;
        }

        public void Update(City updatedObject)
        {
            _context.Attach(updatedObject);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            if (obj == null) return false;

            _context.Citys.Remove(obj);
            _context.SaveChanges();
            return Get(id) == null;
        }

        public City Get(int id)
        {
            return _context.Citys.FirstOrDefault(x => x.Id == id);
        }
    }
}
