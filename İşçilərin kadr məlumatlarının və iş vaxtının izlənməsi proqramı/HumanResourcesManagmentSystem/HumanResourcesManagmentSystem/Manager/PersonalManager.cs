using System;
using System.Collections.Generic;
using HumanResourcesManagmentSystem.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourcesManagmentSystem.DBconnection;
using HumanResourcesManagmentSystem.Models;

namespace HumanResourcesManagmentSystem.Manager
{
    public class PersonalManager
    {
        public static void AddEmployee()
        {
            Personal personal = new Personal();
            Console.Write("İşcinin nömrəsin daxil edin: ");
            personal.EmployeeNumber =int.Parse(Console.ReadLine());
            Console.Write("İşcinin adın daxil edin: ");
            personal.FirstName = Console.ReadLine();
            Console.Write("İşcinin soyadın daxil edin: ");
            personal.LastName = Console.ReadLine();
            Console.Write("İşə giriş tarixin daxil edin: ");
            string dateOfEmployment = Console.ReadLine();
            personal.DateOfEmployment = DateTime.Parse(dateOfEmployment);
            Console.Write("İşcinin adresin daxil edin: ");
            personal.Adress = Console.ReadLine();
            Console.Write("İşcinin vəzifəsin daxil edin: ");
            personal.Position = Console.ReadLine();
            Console.WriteLine("Əmək haqqı əmsalın daxil edin");
            personal.SalaryRate = decimal.Parse(Console.ReadLine());
            UpdateService updateService = new UpdateService();
            updateService.AddEmployeeInfoToDB(personal);
        }
      0
        
    }
}

