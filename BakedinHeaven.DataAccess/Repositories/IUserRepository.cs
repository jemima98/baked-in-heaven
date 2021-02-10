using BakedinHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.DataAccess.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        void Add(User userEntity);
    }
}
