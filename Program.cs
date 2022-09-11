using System;
using Microsoft.Data.Sqlite;

namespace CodingTracker_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Database Creation (can include in CrudOperators class i think if not work)
            using (var connection = new SqliteConnection(@"Data Source=CodingTracker.db"))
            {
                connection.Open();
                var trackerCmd = connection.CreateCommand();

                trackerCmd.CommandText = @"CREATE TABLE IF NOT EXISTS coding_time (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Date TEXT,
                                            StartTime TEXT,
                                            EndTime TEXT,
                                            TotalDuration TEXT
                                            )";
                trackerCmd.ExecuteNonQuery();
                connection.Close();
            }

            // Welcome UI
            Console.WriteLine("Coding Tracker Console App");
            Console.WriteLine("Track your coding hours and be productive!");
            Console.ReadLine();

            // Call Main Menu


            // Call CRUD Operations Class


            // Table Visualization Engine (Calling ConsoleTableExt)


            // Calling Validation of Data 


        }

    }
}

