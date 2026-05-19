using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    class PatientE : UsersE
    {
        public int PatientID { get; set; }
        public int UserID { get; set; }  
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string MedicalHistory { get; set; }
        public DateTime CreatedAt { get; set; }
        public PatientE()
        {
            PatientID = 0;
            UserID = 0;
            Name = "";
            DateOfBirth = DateTime.Today;
            Gender = "";
            Phone = "";
            Email = "";
            Address = "";
            BloodGroup = "";
            MedicalHistory = "";
            CreatedAt = DateTime.Now;
        }
    }
}
