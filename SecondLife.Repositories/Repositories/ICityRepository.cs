using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public interface ICityRepository
    {
        List<Annonce> All();
        City One();
        City Add(City city);
        bool Exists(City city);
        void Update(City updatedObject);
        bool Delete(int id);
        City Get(int id);
    }

    public interface <T>
    {
        List<T> all();
    }
}
