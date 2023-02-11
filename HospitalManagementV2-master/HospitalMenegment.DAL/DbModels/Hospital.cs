using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.DbModels
{
    public class Hospital : BaseEntity
    {
        public string hospital_name { get; set; }
        public string hospital_place { get; set; }
        public string hospital_type { get; set; }
        public string hospital_description { get; set; }
        public string hospital_address { get; set; }
    }
}
