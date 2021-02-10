using BakedinHeaven.BusinessService;
using BakedinHeaven.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakedinHeaven1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;

        }

        [HttpGet]

        public List<User> GetUsers()
        {

            return _userService.GetUsers();
        }
        [HttpPost]
        public void AddUser(User newUser)
        {
            _userService.AddUser(newUser);
        }
    }
}
