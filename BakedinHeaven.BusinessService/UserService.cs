using BakedinHeaven.DataAccess.Entities;
using BakedinHeaven.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedinHeaven.BusinessService
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users = _userRepository.GetAllUsers();
            return users.ToList();
        }

        public void AddUser(User newUser)
        {
            List<User> data = new List<User>();
            data = _userRepository.GetAllUsers();


            foreach (var Element in data)
            {
                if (Element.Username == newUser.Username)
                {
                    break;
                    // " with same name already exists";
                }
                else
                {
                    _userRepository.Add(newUser);
                }

            }
        }
    }
}
