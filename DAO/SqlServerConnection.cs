using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System;

namespace DAO
{
    public class SqlServerConnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection connection;
        /// <constructor>
        /// Initialise Connection
        /// </constructor>
        public SqlServerConnection()
        {
            myAdapter = new SqlDataAdapter();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);
        }
        /// <method>
        /// Open Database Connection if Closed or Broken
        /// </method>
        /// <returns></returns>
        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            { connection.Open(); }
            return connection;
        }
        /// <summary>
        /// Insert Query
        /// </summary>
        /// <param name="_query"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public bool executeInsertQuery(string _query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = _query;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(sqlParameters);
                myAdapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.WriteLine($"Error - Connection.executeInsertQuery - Query: {_query}" +
                    $"\nException: {e.StackTrace}");
                return false;
            }
            return true;
        }
        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                //
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }


        public static SqlConnection KetNoiToiCSDL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
