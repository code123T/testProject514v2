using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManagmentSystem.Models
{
    public class Personal:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string Adress { get; set; }
        public string Position { get; set; }
        public decimal SalaryRate { get; set; }
        public int? WorkingMinutesInMonth { get; set; }
    }
}
