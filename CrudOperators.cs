using Microsoft.Data.Sqlite;
using System;

namespace CodingTracker_ConsoleApp
{
	 public class CrudOperators : MainMenu
	{
		// Insert or Create data to database
		string connectionString = @"Data Source=CodingTracker.db";
		public void Create()
		{
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var trackerCmd = connection.CreateCommand();

                trackerCmd.CommandText =
                    $"INSERT INTO coding_tracker VALUES ();


				trackerCmd.ExecuteNonQuery();

                connection.Close();
            }
        }

		// View or Read data from database (Like RetrieveView Method in Habit Tracker)
		public void Read()
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				var trackerCmd = connection.CreateCommand();
				trackerCmd.CommandText = @"SELECT * FROM coding_tracker";
				
				SqliteDataReader reader = trackerCmd.ExecuteReader();

				if (reader.HasRows)
				{

				}
			}
		}
	}
}
