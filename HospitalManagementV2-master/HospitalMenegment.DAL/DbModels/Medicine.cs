using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.DbModels
{
    public class Medicine:BaseEntity
    {
        public string medicine_name { get; set; }
        public string medicine_company { get; set; }
        public string medicine_composition { get; set; }
        public string medicine_cost { get; set; }
        public string medicine_type { get; set; }
        public string medicine_dose { get; set; }
        public string medicine_description { get; set; }
    }
}
