using System;
using System.Data.SqlClient;

namespace HighSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            new Program().CreateTable();
            //new Program().InsertRecord();
            //new Program().DisplayData();
            //new Program().DeleteData();
            Console.ReadKey();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(@"data source=.\SQLEXPRESS; database=Student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public void InsertRecord()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(@"data source=.\SQLEXPRESS; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student (id, name, email, join_date) values ('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);

                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public void DisplayData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(@"data source=.\SQLEXPRESS; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from student", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    // Displaying Record  
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public void DeleteData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(@"data source=.\SQLEXPRESS; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("delete from student where id = '101'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}