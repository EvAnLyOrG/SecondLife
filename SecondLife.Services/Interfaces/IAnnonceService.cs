using Microsoft.AspNetCore.JsonPatch;
using SecondLife.Model.Entities;
using System.Collections.Generic;

namespace SecondLife.Services.Services
{
    public interface IAnnonceService : IService<Annonce>
    {
    }

    public interface IService<T> where T : class
    {
        public List<T> List();
        T Get(in int id);
        T Add(T annonce);
        T Patch(in int id, JsonPatchDocument<T> jsonPatch);
        T Remove(T annonce);
    }
}