using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HumanResourcesManagmentSystem.Models;
namespace HumanResourcesManagmentSystem.DBconnection
{
    public static class DatabaseConnection
    {
        public static string ConnectionStrings = "Data Source=DESKTOP-LU90HPM;Initial Catalog=HumanResurceDB;Integrated Security=True";

        public static void ConnectToDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionStrings);
            sqlConnection.Open();
            System.Console.WriteLine("Ugurla qosuldu !");
            sqlConnection.Close();
        }

       
    }
   
}
