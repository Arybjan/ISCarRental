using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCarRental
{
	public static class Database
	{
		// Строка подключения к Access
		private static string connectionString =
			@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\CarRental.accdb; ";

		// Получение подключения
		public static OleDbConnection GetConnection()
		{
			return new OleDbConnection(connectionString);
		}

		// Метод для SELECT запросов
		public static DataTable ExecuteQuery(string query, params OleDbParameter[] parameters)
		{
			DataTable table = new DataTable();

			using (OleDbConnection conn = GetConnection())
			{
				conn.Open();

				using (OleDbCommand cmd = new OleDbCommand(query, conn))
				{
					if (parameters != null)
						cmd.Parameters.AddRange(parameters);

					using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
					{
						adapter.Fill(table);
					}
				}
			}

			return table;
		}

		// Метод для INSERT UPDATE DELETE
		public static int ExecuteNonQuery(string query, params OleDbParameter[] parameters)
		{
			using (OleDbConnection conn = GetConnection())
			{
				conn.Open();

				using (OleDbCommand cmd = new OleDbCommand(query, conn))
				{
					if (parameters != null)
						cmd.Parameters.AddRange(parameters);

					return cmd.ExecuteNonQuery();
				}
			}
		}

		// Метод для получения одного значения (COUNT, SUM и т.д.)
		public static object ExecuteScalar(string query, params OleDbParameter[] parameters)
		{
			using (OleDbConnection conn = GetConnection())
			{
				conn.Open();

				using (OleDbCommand cmd = new OleDbCommand(query, conn))
				{
					if (parameters != null)
						cmd.Parameters.AddRange(parameters);

					return cmd.ExecuteScalar();
				}
			}
		}
	}
}