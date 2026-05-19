using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    class ReceptionistE : UsersE
    {
        public int ReceptionistID { get; set; }
        public int UserID { get; set; }
        public int DepartmentID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfDateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Shift { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }

    }
}
