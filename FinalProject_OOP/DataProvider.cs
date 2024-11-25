using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_OOP
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=DINHKHOA;Initial Catalog=COFFEE;Integrated Security=True;Trust Server Certificate=True";
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
            
    }
}
