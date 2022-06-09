//namespace WinForms_proj
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WinForms_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
            var ConString = ConfigurationManager.ConnectionStrings["StudentConn"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Student";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label1.Text = reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
            }
        }
    }
}