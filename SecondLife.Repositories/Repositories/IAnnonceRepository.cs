using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public interface IAnnonceRepository : IRepository<Annonce>
    {

    }

    public interface IRepository<T>
    {
        List<T> All();
        T One(int id);
        T Add(T annonce);
        T Remove(T annonce);
        T Update(T annonce);
        bool Exists(T annonce);
    }
}
