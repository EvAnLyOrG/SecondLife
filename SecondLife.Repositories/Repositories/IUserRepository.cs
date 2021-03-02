using SecondLife.Model.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public interface IUserRepository
    {

        IEnumerable GetUsers();
        User GetUsersByID(int usersId);
        void InsertUsers(User users);
        void DeleteUsers(int usersId);
        void UpdateUsers(User users);
        void Save();
    }

    
}
