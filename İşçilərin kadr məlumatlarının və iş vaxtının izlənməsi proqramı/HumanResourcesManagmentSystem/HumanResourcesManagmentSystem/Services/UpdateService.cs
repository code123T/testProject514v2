using HumanResourcesManagmentSystem.Models;
using HumanResourcesManagmentSystem.DBconnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumanResourcesManagmentSystem.Services
{
    public class UpdateService : IUpdateService
    {
        public void AddEmployeeInfoToDB(Personal personal)
        {
            SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.ConnectionStrings);
            sqlConnection.Open();
            string addEmployeeQuery = "insert into tblPersonal (EmployeeNumber,FirstName,LastName,DateOfEmployment,Adress,Position,SalaryRate) values(@EmployeeNumber,@FirstName,@LastName,@DateOfEmployment,@Adress,@Position,@SalaryRate)";
            SqlCommand sqlCommand = new SqlCommand(addEmployeeQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@EmployeeNumber",personal.EmployeeNumber);
            sqlCommand.Parameters.AddWithValue("@FirstName", personal.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", personal.LastName);
            sqlCommand.Parameters.AddWithValue("@DateOfEmployment", personal.DateOfEmployment);
            sqlCommand.Parameters.AddWithValue("@Adress", personal.Adress);
            sqlCommand.Parameters.AddWithValue("@Position", personal.Position);
            sqlCommand.Parameters.AddWithValue("@SalaryRate", personal.SalaryRate);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void AddWorktimeInfoToDB(Worktime worktime)
        {
            SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.ConnectionStrings);
            sqlConnection.Open();
            string addWorktimeQuery = "insert into tblWorktime (EmployeeNumber,DayOfMonth,TimeOfEntry,TimeOfExit) values(@EmployeeNumber,@DayOfMonth,@TimeOfEntry,@TimeOfExit)";
            SqlCommand sqlCommand = new SqlCommand(addWorktimeQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@EmployeeNumber",worktime.EmployeeNumber);
            sqlCommand.Parameters.AddWithValue("@DayOfMonth",worktime.DayOfMonth);
            sqlCommand.Parameters.AddWithValue("@TimeOfEntry",worktime.TimeOfEntry);
            sqlCommand.Parameters.AddWithValue("@TimeOfExit",worktime.TimeOfExit);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }

    public interface IUpdateService
    {
        void AddEmployeeInfoToDB(Personal personal);
        void AddWorktimeInfoToDB(Worktime worktime);
    }
}
