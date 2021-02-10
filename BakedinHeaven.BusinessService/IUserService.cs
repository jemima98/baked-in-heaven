using BakedinHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.BusinessService
{
    public interface IUserService
    {
        List<User> GetUsers();
        void AddUser(User newUser);
    }
}
