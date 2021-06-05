using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button event control with Click evnt
        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                label1.Text="Button 1 was clicked";
                textBox1.Text = "Button 1 was clicked";
            }

            if (sender == button2)
            {
                label1.Text = "Button 2 was clicked";
                textBox1.Text = "Button 2 was clicked";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Do Nothing
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form 1 was clicked");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello world";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
