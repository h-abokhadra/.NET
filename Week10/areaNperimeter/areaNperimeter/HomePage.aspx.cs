using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace areaNperimeter
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Area   A = W * L
            if (RadioButton1.Checked)
            {
                TextBox3.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text));
            }


            //Perimeter    P = 2(w + L)
            if (RadioButton2.Checked)
            {
                TextBox3.Text = Convert.ToString(2 * (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text)));
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}