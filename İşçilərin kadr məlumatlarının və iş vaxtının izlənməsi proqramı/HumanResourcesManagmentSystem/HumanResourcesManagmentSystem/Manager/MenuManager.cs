using System;
using HumanResourcesManagmentSystem.WarningMessages;
using HumanResourcesManagmentSystem.SystemContentData.MenuContent;
using HumanResourcesManagmentSystem.Models;
using HumanResourcesManagmentSystem.Manager;

namespace HumanResourcesManagmentSystem.Services
{
    public static class MenuManager
    {
        public static void Open()
        {
            appOpenService.AppOpen();
        }
        public static void Menu()
        {
            
            bool isContiune = true;
            do
            {
                MenuContent.MainMenu();
                Console.Write("Daxil et: ");
                int choiceResult = int.Parse(Console.ReadLine());
                switch (choiceResult)
                {
                    case 1:
                        QuestionMenu();
                        isContiune = false;

                        break;
                    case 2:
                        UpdateMenu();
                        isContiune = false;

                        break;
                    case 3:
                        WorktimeManager.AddEmployeeWorkTime();
                        break;
                    case 4:
                        Environment.Exit(0);
                        isContiune = false;
                        break;
                    default:
                        Console.WriteLine(WarningMessage.wrongValueMessage);
                        isContiune = true;
                        break;
                }
            } while (isContiune);
            
        }
        public static void QuestionMenu()
        {
            bool isContiune = true;
            
            do
            {
                MenuContent.QuestionMenuContents();
                Console.Write("Daxil et: ");
                int questionChoiceResult = int.Parse(Console.ReadLine());
                int employeeNumber;
                switch (questionChoiceResult)
                {
                    case 1:
                        Console.Write("İşçinin nömrəsin daxil edin: ");
                        employeeNumber = int.Parse(Console.ReadLine());
                        QuestionService questionService = new QuestionService();
                        questionService.GetEmployeeInfo(employeeNumber);
                        isContiune = false;
                        break;
                    case 2:
                        Console.Write("İşçinin nömrəsin daxil edin: ");
                        employeeNumber = int.Parse(Console.ReadLine());

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Menu();
                        break;
                    case 8:
                        Environment.Exit(0);
                        isContiune = false;
                        break;
                    default:
                        Console.WriteLine(WarningMessage.wrongValueMessage);
                        isContiune = true;
                        break;
                }
            } while (isContiune);
        }
        public static void UpdateMenu()
        {
            bool isContiune = true;
            do
            {
                MenuContent.UpdateMenuContents();
                Console.Write("Daxil et: ");
                int updateChoiceResult = int.Parse(Console.ReadLine());
                switch (updateChoiceResult)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Menu();
                        break;
                    case 7:
                        Environment.Exit(0);
                        isContiune = false;
                        break;
                    default:
                        Console.WriteLine(WarningMessage.wrongValueMessage);
                        isContiune = true;
                        break;
                }
            } while (isContiune);
        }
    }
}
