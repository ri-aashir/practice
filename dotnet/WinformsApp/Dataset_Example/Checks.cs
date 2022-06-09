using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dataset_Example
{
    internal static class Checks
    {
        public static bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName)
        {
            string sqlCreateDBQuery;
            bool result = false;

            try
            {
                // tmpConn = new SqlConnection("server=(local)\\SQLEXPRESS;Trusted_Connection=yes");
                tmpConn = new SqlConnection(@".\SQLEXPRESS;Trusted_Connection=yes");

                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name  = '{0}'", databaseName);
        
                using (tmpConn)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                    {
                        tmpConn.Open();

                        object resultObj = sqlCmd.ExecuteScalar();

                        int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }

                        tmpConn.Close();

                        result = (databaseID > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public static bool CheckDatabaseData(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select * from ComputerShop", con);
            bool ans = false;

            try
            {
                con.Open();
                if (cmd.ExecuteReader() != null) ans = true;
            }
            finally
            {
                //ans = false;
                con.Close();
            }

            return ans;
        }
    }
}
