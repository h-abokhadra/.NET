using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Circle.Checked)
            {
                textBox1.Text = "Circle was Checked";
            }

            if (Rectangle.Checked)
            {
                textBox1.Text = "Rectangle was Checked";
            }

            if (Triangle.Checked)
            {
                textBox1.Text = "Triangle was Checked";
            }

            if (Square.Checked)
            {
                textBox1.Text = "Square was Checked";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
