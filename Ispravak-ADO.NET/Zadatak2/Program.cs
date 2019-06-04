using System;
using System.Data;
using System.Data.SqlClient;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceKurs = "P-K3-OOP";
            var targetKurs = "P-K4-ISA";

            using (SqlConnection connection = new SqlConnection(
                    "Data Source=CMTLAB2019\\SQLEXPRESS;" +
                    "Integrated Security=SSPI;" +
                    "Initial Catalog=CMT"))
            using (DataSet dataSet = new DataSet())
            {
                var selectPolaznik = "SELECT * FROM polaznik p;";
                var selectPohadja = "SELECT * FROM pohadja po;";
                var selectKurs = "SELECT * FROM kurs k;";

                using (SqlDataAdapter polaznikAdapter = new SqlDataAdapter(selectPolaznik, connection),
                    pohadjaAdapter = new SqlDataAdapter(selectPohadja, connection),
                    kursAdapter = new SqlDataAdapter(selectKurs, connection))
                {
                    var insertPohadja = "INSERT pohadja (polaznikId, kursId) VALUES (@polaznikId, @kursId);";
                    var insertPohadjaCommand = new SqlCommand(insertPohadja, connection);
                    var parameter = insertPohadjaCommand.Parameters.Add("@polaznikId", SqlDbType.Int);
                    parameter.SourceColumn = "polaznikId";
                    parameter = insertPohadjaCommand.Parameters.Add("@kursId", SqlDbType.Int);
                    parameter.SourceColumn = "kursId";

                    polaznikAdapter.Fill(dataSet, "Polaznik");
                    pohadjaAdapter.Fill(dataSet, "Pohadja");
                    pohadjaAdapter.InsertCommand = insertPohadjaCommand;
                    kursAdapter.Fill(dataSet, "Kurs");

                    // Uzimanje ID kurs-a sa imenom sourceKurs, targetKurs
                    var row = dataSet.Tables["Kurs"].Select($"naziv = \'{sourceKurs}\'")[0];
                    var sourceKursId = row["kursId"];
                    row = dataSet.Tables["Kurs"].Select($"naziv = \'{targetKurs}\'")[0];
                    var targetKursId = row["kursId"];

                    // Polaznici koji idu na kurs
                    var polazniciIds = dataSet.Tables["Pohadja"].Select($"kursId = {sourceKursId}");
                    Console.WriteLine($"Ucenici koji pohadjaju kurs {sourceKurs} : ");
                    foreach (var polaznikId in polazniciIds)
                    {
                        // ISPIS
                        var polaznik = dataSet.Tables["Polaznik"].Select($"polaznikId = {polaznikId["polaznikId"]}")[0];
                        Console.WriteLine("{0} {1}", polaznik["Ime"], polaznik["Prezime"]);

                        // DODAVANJE
                        var noviPolaznik = dataSet.Tables["Pohadja"].NewRow();
                        noviPolaznik["polaznikId"] = polaznikId["polaznikId"];
                        noviPolaznik["kursId"] = targetKursId;
                        dataSet.Tables["Pohadja"].Rows.Add(noviPolaznik);
                        Console.WriteLine($"Korisnik je upisan na kurs {targetKurs}");
                    }

                    pohadjaAdapter.Update(dataSet.Tables["Pohadja"]);    
                }
                Console.ReadKey();
            }
        }
    }
}
