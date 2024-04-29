using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager.Models.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role role { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public enum Role
        {
            Admin, User, Business
        }
    }
}
