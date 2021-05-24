using System.Collections.Generic;

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
