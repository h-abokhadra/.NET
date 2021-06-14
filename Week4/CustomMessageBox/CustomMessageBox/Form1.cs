using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons ButtonType  { set; get; }
        private MessageBoxIcon IconType { set; get; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("This is your custom Message","Custom MessageBox", ButtonType, IconType);

            if (result == DialogResult.OK)
            {
                label1.Text = "The user have pressed Ok Button";
            }

        }

        private void ButtonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender==Ok)
            {
                ButtonType = MessageBoxButtons.OK;
            }
            else if(sender==OkCancel)
            {
                ButtonType = MessageBoxButtons.OKCancel;
            }
            else if(sender==YesNo)
            {
                ButtonType = MessageBoxButtons.YesNo;
            }
        }

        private void IconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == Error)
            {
                IconType = MessageBoxIcon.Error;
            }
            else if (sender == Information)
            {
                IconType = MessageBoxIcon.Information;
            }
        }
    }
}
