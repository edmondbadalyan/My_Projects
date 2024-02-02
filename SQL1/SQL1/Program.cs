using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\.;Integrated Security=True");
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText ="select * from songs";

            IDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

            }










        }
    }
}
