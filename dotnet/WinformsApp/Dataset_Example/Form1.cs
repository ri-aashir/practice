using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dataset_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetData_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
            string Query = "SELECT * FROM Student";

            SqlDataAdapter adapter = new SqlDataAdapter(Query, ConString);
            DataSet set = new DataSet();

            adapter.Fill(set, "tudent");
            dataGridView2.DataSource = set.Tables["tudent"];

        }
    }
}