using System;
using System.Data.SqlClient;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
                    "Data Source=CMTLAB2019\\SQLEXPRESS;" +
                    "Integrated Security=SSPI;" +
                    "Initial Catalog=CMT"))
                {
                    connection.Open();

                    var query = "SELECT ime, prezime, razred, s.naziv as skola FROM polaznik p\n" +
                                    "INNER JOIN (SELECT * FROM pohadja WHERE ocena > 3) po ON p.polaznikId = po.polaznikId\n" +
                                    "INNER JOIN (SELECT * FROM Kurs WHERE naziv = \'P-K4-ISA\') k ON k.kursId = po.kursId\n" +
                                    "INNER JOIN skola s ON p.skolaId = s.skolaId\n" +
                                    "ORDER BY p.ime, p.prezime ASC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            Console.WriteLine("Redni broj | {0} | {1} | {2} | {3} |", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                            Console.WriteLine();
                            int i = 1;
                            while (reader.Read())
                            {
                                Console.WriteLine("{4} | {0} | {1} | {2} | {3} |", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), i);
                                i++;
                            }
                            Console.WriteLine();
                        }
                    }
                    Console.ReadKey();
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
