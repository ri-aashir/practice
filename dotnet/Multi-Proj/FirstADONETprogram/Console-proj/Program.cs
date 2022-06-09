using System;
using System.Data.SqlClient;
using System.Configuration;

namespace FirstADONETProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // var ConString = ConfigurationManager.ConnectionStrings["StudentConn"].ConnectionString;
            string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Student";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
        }
    }
}