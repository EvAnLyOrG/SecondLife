using Microsoft.AspNetCore.JsonPatch;
using SecondLife.Model.Entities;
using System.Collections.Generic;

namespace SecondLife.Services.Services
{
    public interface IAnnonceService : IService<Annonce>
    {
        Annonce Patch(int id, JsonPatchDocument<Annonce> document);
        bool Delete(int id);
    }

    public interface IService<T> where T : class
    {
        public List<T> List();
        T Get(in int id);
        T Add(T film);
    }
}