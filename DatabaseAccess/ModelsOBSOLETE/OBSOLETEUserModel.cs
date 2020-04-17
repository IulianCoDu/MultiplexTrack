using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Models
{
    public class OBSOLETEUserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string user { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public OBSOLETEUserModel(int userId, string firstName, string lastName, string User, string password, string email)
        {
            Id = userId;
            FirstName = firstName;
            LastName = lastName;
            user = User;
            Password = password;
            Email = email;
        }
    }
}
