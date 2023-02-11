using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.DbModels
{
    public class Patient:BaseEntity
    {
        public string patient_Name { get; set; }
        public string patient_mobile { get; set; }
        public string patient_email { get; set; }
        public string patient_username { get; set; }
        public string patient_password { get; set; }
        public string patient_address { get; set; }
        public string patient_blood_group { get; set; }
    }
}
