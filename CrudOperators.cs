using Microsoft.Data.Sqlite;
using System;

namespace CodingTracker_ConsoleApp
{
	 class CrudOperators
	{
		// Insert or Create data to database
		string connectionString = @"Data Source=CodingTracker.db";
		public void Create()
		{

		}

		// View or Read data from database
		public void Read()
		{
			using (var connection = new SqliteConnection(connectionString))
			{
				connection.Open();
				var trackerCmd = connection.CreateCommand();
				trackerCmd.CommandText = @"SELECT * FROM coding_tracker";
				trackerCmd.ExecuteNonQuery();
				connection.Close();
			}
		}
	}
}
