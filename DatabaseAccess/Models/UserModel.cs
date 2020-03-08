using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserModel(int userId, string firstName, string lastName, string password, string email)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
        }
    }
}
