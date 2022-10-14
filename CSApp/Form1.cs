using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Loaditem();
        }

        private void Loaditem()
        {
            String connectSTR = "Data Source=./;Initial Catalog=CSProject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectSTR);
            SqlCommand command = new SqlCommand("SELECT * FROM Test", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Name"].ToString());
            }
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = command;
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //testView.DataSource = table;
            connection.Close();
        }
    }
}
