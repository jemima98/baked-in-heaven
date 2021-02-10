using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.DataAccess.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

    }
}