using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.DbModels
{
    public class Appointment:BaseEntity
    {
        public int appointment_number { get; set; }
        public string appointment_type { get; set; }
        public DateTime appointment_date { get; set; }
        public string appointment_description { get; set; }
        public int DoctorId { get; set; }
    }
}
