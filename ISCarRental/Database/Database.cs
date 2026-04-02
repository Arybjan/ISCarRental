using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace ISCarRental
{
    public static class Database
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["CarRentalDb"].ConnectionString;

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, params OleDbParameter[] parameters)
        {
            DataTable table = new DataTable();

            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        public static int ExecuteNonQuery(string query, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string query, params OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = GetConnection())
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}