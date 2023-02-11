using System;
using HumanResourcesManagmentSystem.Services;
using HumanResourcesManagmentSystem.Manager;
using HumanResourcesManagmentSystem.Models;
using System.Collections.Generic;

namespace HumanResourcesManagmentSystem
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            MenuManager.Open();
            MenuManager.Menu();
            //QuestionService questionService = new QuestionService();
            //questionService.EmployeeInfo(44);
            //PersonalManager.AddEmployee();
            //List<Personal> personals = new List<Personal>();
            //personals.Add(personal);
            //foreach (var item in personals)
            //{
            //    Console.Write(item.Id + " " + item.EmployeeNumber + " " + item.FirstName
            //        + " " + item.LastName + " " + item.DateOfEmployment + " " + item.Adress
            //        + " " + item.Position + " " + item.SalaryRate + " " + item.WorkingMinutesInMonth + "");
            //}

        }
    }
    

}
