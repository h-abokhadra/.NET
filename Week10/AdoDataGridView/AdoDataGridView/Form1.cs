using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connection with the backend
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = OMAR\OMARSQL; Initial Catalog = BooksDB; 
                                                          Integrated Security = True";
            //Open up the connection
            con.Open();


            //Query the data
            //SP SQL command
            SqlDataAdapter SQLCMD = new SqlDataAdapter("spGetTitleTwoPar", con);
            SQLCMD.SelectCommand.CommandType = CommandType.StoredProcedure;
            SQLCMD.SelectCommand.Parameters.Add("@EditionNumber", SqlDbType.VarChar).Value =textBox1.Text;
            SQLCMD.SelectCommand.Parameters.Add("@Copyright", SqlDbType.VarChar).Value = textBox2.Text;

            DataTable DT = new DataTable();
            SQLCMD.Fill(DT);

            //Present the data in a Data Grid View
            dataGridView1.DataSource = DT;
        }
    }
}
