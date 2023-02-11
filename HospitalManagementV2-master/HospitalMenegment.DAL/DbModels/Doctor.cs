using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.DbModels
{
    public class Doctor:BaseEntity
    {
        public string doctor_name { get; set; }
        public string doctor_speciast { get; set; }
        public string doctor_mobile { get; set; }
        public string doctor_email { get; set; }
        public string doctor_username { get; set; }
        public string doctor_password { get; set; }
        public string doctor_address { get; set; }

    }
}
