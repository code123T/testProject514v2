using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.DbModels
{
    public class Nurse:BaseEntity
    {
        public string nurse_name { get; set; }
        public int nurse_duty_hour { get; set; }
        public string nurse_mobile { get; set; }
        public string nurse_email { get; set; }
        public string nurse_username { get; set; }
        public string nurse_password { get; set; }
        public string nurse_address { get; set; }
    }
}
