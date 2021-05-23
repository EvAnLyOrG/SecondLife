using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> All();
        T One(int id);
        T Add(T annonce);
        T Remove(T annonce);
        T Update(T annonce);
        bool Exists(T annonce);
    }
}
