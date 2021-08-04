using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebConfigApp
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            /*Direct ADO connection
            SqlConnection con = new SqlConnection(@"Data Source = OMAR\OMARSQL; Initial Catalog=BooksDB; 
                                                         Integrated Security=True");*/

            SqlConnection con = new SqlConnection(CS);
            con.Open();


            

            SqlCommand SQLCMD = new SqlCommand("select * from Titles",con);
            GridView1.DataSource = SQLCMD.ExecuteReader();
            GridView1.DataBind();

        }
    }
}