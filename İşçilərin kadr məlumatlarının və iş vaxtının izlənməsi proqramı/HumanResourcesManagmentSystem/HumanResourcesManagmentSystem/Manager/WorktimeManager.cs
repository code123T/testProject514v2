using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourcesManagmentSystem.Models;
using HumanResourcesManagmentSystem.Services;

namespace HumanResourcesManagmentSystem.Manager
{
    public static class WorktimeManager
    {
        public static void AddEmployeeWorkTime()
        {
            Worktime worktime = new Worktime();
            Console.WriteLine("İşçinin nömrəsin daxil edin: ");
            worktime.EmployeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Gün No daxil edin: ");
            worktime.DayOfMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Giriş vaxtın qeyd edin: ");
            worktime.TimeOfEntry = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Çıxış vaxtın qeyd edin: ");
            worktime.TimeOfExit = DateTime.Parse(Console.ReadLine());
            UpdateService updateService = new UpdateService();
            updateService.AddWorktimeInfoToDB(worktime);
        }
    }
}
