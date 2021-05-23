using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.JsonPatch;

namespace SecondLife.Services.Interfaces
{
    public interface IService<T> where T : class
    {
        public List<T> List();
        T Get(in int id);
        T Add(T annonce);
        T Patch(in int id, JsonPatchDocument<T> jsonPatch);
        T Remove(T annonce);
    }
}
