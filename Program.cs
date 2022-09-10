using System;
using Microsoft.Data.Sqlite;

namespace CodingTracker_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome UI
            Console.WriteLine("Coding Tracker Console App");
            Console.WriteLine("Track your coding hours and be productive!");
            Console.ReadLine();

            // Database Creation
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

            // CRUD Operations Class

        }

    }
}

