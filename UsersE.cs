using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    class UsersE
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public UsersE()
        {
            UserID = 0;
            Username = string.Empty;
            Password = string.Empty;
            Role = "Patient";
            Status = 0;
            CreatedAt = DateTime.Now;
        }
    }
}
