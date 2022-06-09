using System;
using System.Data.SqlClient;


namespace Dataset_Example
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            //string query = "Create Database ComputerShop";
            //SqlCommand cmd = new SqlCommand(query, con);
            //try
            //{
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("Database Created Successfully");
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine("Error Generated. Details: " + e.ToString());
            //}
            //finally
            //{
            //    con.Close();
            //}


            //string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True";
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            //string DBname = "ComputerShop";
            //if (! Checks.CheckDatabaseExists(con, DBname))
            //{

            //    //string query =
            //    //@"Create Database ComputerShop;

            //    //CREATE TABLE dbo.Products
            //    //(
            //    //    ID int IDENTITY(1,1) NOT NULL,
            //    //    Name nvarchar(50) NULL,
            //    //    Price nvarchar(50) NULL,
            //    //    Date datetime NULL,
            //    //    CONSTRAINT pk_id PRIMARY KEY (ID)
            //    //);

            //    //INSERT INTO Products (Name,Price,Date) VALUES('LED Screen','$120','27 January 2017');
            //    //INSERT INTO Products (Name,Price,Date) VALUES('USB Keyboard','$20','27 May 2017')
            //    //";
            //    string query = 
            //        @"CREATE TABLE dbo.Products
            //        (
            //            ID int IDENTITY(1,1) NOT NULL,
            //            Name nvarchar(50) NULL,
            //            Price nvarchar(50) NULL,
            //            Date datetime NULL,
            //            CONSTRAINT pk_id PRIMARY KEY (ID)
            //        );";

            //    SqlCommand DBcmd = new SqlCommand(query, con);
            //    con.Open();
            //    DBcmd.ExecuteNonQuery();
            //    con.Close();
            //}

            // if (! Checks.CheckDatabaseData(con))
            //try
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("Create Database ComputerShop", con);
            //    cmd.ExecuteNonQuery();
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("oops: database could not be created");
            //    throw;
            //}
            //finally
            //{
            //    con.Close();
            //}
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}