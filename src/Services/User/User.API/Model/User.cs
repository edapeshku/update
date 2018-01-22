using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace eSupport.Services.User.API.Model
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Active { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int UpdatedBy { get; set; }

        public DateTime DeletedAt { get; set; }

        public int DeletedBy { get; set; }
    }
}