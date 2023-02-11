using HumanResourcesManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourcesManagmentSystem.DBconnection;
using ConsoleTables;
namespace HumanResourcesManagmentSystem.Services
{
    public   class QuestionService : IQuestionService
    {
        public  void GetEmployeeInfo(int employeeNumber)
        {

            SqlDataReader sqlDataReader;
            SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.ConnectionStrings);
            sqlConnection.Open();
            string readyQuery = $"select *from [dbo].[tblPersonal] where EmployeeNumber={employeeNumber}";
            SqlCommand sqlCommand = new SqlCommand(readyQuery, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            Personal personal = new Personal();
            while (sqlDataReader.Read())
            {
                personal.Id = (int)sqlDataReader.GetValue(0);
                personal.EmployeeNumber = (int)sqlDataReader.GetValue(1);
                personal.FirstName = sqlDataReader.GetValue(2).ToString();
                personal.LastName = sqlDataReader.GetValue(3).ToString();
                personal.DateOfEmployment = Convert.ToDateTime(sqlDataReader.GetValue(4));
                personal.Adress = sqlDataReader.GetValue(5).ToString();
                personal.Position = sqlDataReader.GetValue(6).ToString();
                personal.SalaryRate = (decimal)sqlDataReader.GetValue(7);
                personal.WorkingMinutesInMonth = (int)sqlDataReader.GetValue(8);
            }
            if (personal.FirstName!=null)
            {
                var table = new ConsoleTable("Per NO", "Ad", "Soyad", "İşə Gir Tarixi", "Ünvanı", "Əmək haqqı əmsalı");
                table.AddRow(personal.EmployeeNumber, personal.FirstName, personal.LastName, personal.DateOfEmployment.ToString(), personal.Adress, personal.SalaryRate);
                table.Write();
                sqlConnection.Close();
            }
            else
            {
                Console.WriteLine("Qeyd olunan işçi nömrəsi sistemdə mövcud deyil !");
            }
        }


        public void GetEmployeeAndWorktimeIn(int employeeNumber)
        {
            SqlDataReader sqlDataReader;
            SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.ConnectionStrings);
            sqlConnection.Open();
            string readyQuery = $"select * from [dbo].[tblPersonal] join [dbo].[tblWorktime] on [dbo].[tblPersonal].EmployeeNumber=[dbo].[tblWorktime].EmployeeNumber where [tblPersonal].EmployeeNumber={ employeeNumber}";
            SqlCommand sqlCommand = new SqlCommand(readyQuery, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            Personal personal = new Personal();
            Worktime worktime = new Worktime();
            while (sqlDataReader.Read())
            {
                personal.EmployeeNumber = (int)sqlDataReader.GetValue(1);
                personal.FirstName = sqlDataReader.GetValue(2).ToString();
                personal.LastName = sqlDataReader.GetValue(3).ToString();
                personal.WorkingMinutesInMonth = (int)sqlDataReader.GetValue(8);
                worktime.DayOfMonth = (int)sqlDataReader.GetValue(11);
                worktime.TimeOfEntry=(int)sqlDataReader.GetValue(12);
            }
            if (personal.FirstName != null)
            {
                var table = new ConsoleTable("Per NO", "Ad", "Soyad", "Süre", "Ücret", "Gün No","Gir saatı","Çıxış saatı");
                table.AddRow(personal.EmployeeNumber, personal.FirstName, personal.LastName, personal.DateOfEmployment.ToString(), personal.Adress, personal.SalaryRate);
                table.Write();
                sqlConnection.Close();
            }
            else
            {
                Console.WriteLine("Qeyd olunan işçi nömrəsi sistemdə mövcud deyil !");
            }
        }
    }

    public  interface IQuestionService
    {
        void GetEmployeeInfo(int employeeNumber);
        void GetEmployeeAndWorktimeIn(int employeeNumber);
    }
}
