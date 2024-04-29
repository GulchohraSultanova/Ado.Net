using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccessLayer
{
    public class EmployeeDB
    {
       readonly string connection = "Server=GULCHOHRA\\SQLEXPRESS;Database=EmployeeApp;Trusted_connection=true;Integrated security=true;";
       SqlConnection sqlConnection;
        public EmployeeDB()
        {
            sqlConnection = new SqlConnection(connection);
        }
        public int NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            int result= cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
            
        }
        public DataTable Query(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(query,sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close ();
            return dataTable;

        }

    }
}
