using System;
using System.Data.SqlClient;

namespace ado_testiranje
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Data Source = 192.168.0.16;" +
                                   "User id=SA;" +
                                   "Password=Trackshittaz10!;";
            sql.Open();
            
            
            sql.Close();
            Console.WriteLine("Connection closed!");
            Console.ReadKey();
        }
    }
}