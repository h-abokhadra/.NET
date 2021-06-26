using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This program is for creating a tic tac toe game using forms, Author: Hoda Abokhadra, June 2021.

namespace Hoda_Abokhadra
{
    public partial class Form1 : Form
    {
        //for counting the moves
        int counter;
        //True is for the 1st player turn while false would be for the 2nd player turn.
        bool turnStatus = true; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turnStatus) //if true the turn would be for the 1st player
            {
                button.Text = "X";
            }
            else //if false the turn would be for the 2nd player
            {
                button.Text = "O";
            }

            turnStatus = !turnStatus; //For switching the turnStatus
            button.Enabled = false;
            counter++;

            winnerCheck();
        }

        private void winnerCheck()
        {
            bool winner = false;
            //Checking the rows wins
            if((x1.Text == x2.Text)&&(x2.Text == x3.Text) && (!x1.Enabled)) //1st row - Disable the button after the win
            {
                winner = true;

            }
           else if ((y1.Text == y2.Text) && (y2.Text == y3.Text) && (!y1.Enabled)) //2nd row
            {
                winner = true;

            }
            else if ((z1.Text == z2.Text) && (z2.Text == z3.Text) && (!z1.Enabled)) //3rd row
            {
                winner = true;

            }

            //Checking the columns wins
            else if ((x1.Text == y1.Text) && (y1.Text == z1.Text) && (!x1.Enabled)) //1st column - Disable the button after the win
            {
                winner = true;

            }
            else if ((x2.Text == y2.Text) && (y2.Text == z2.Text) && (!x2.Enabled)) //2nd column
            {
                winner = true;

            }
            else if ((x3.Text == y3.Text) && (y3.Text == z3.Text) && (!x3.Enabled)) //3rd column
            {
                winner = true;

            }

            //Checking the diagonal

            else if ((x1.Text == y2.Text) && (y2.Text == z3.Text) && (!x1.Enabled)) //1st diagonal
            {
                winner = true;

            }
            else if ((x3.Text == y2.Text) && (y2.Text == z1.Text) && (!x3.Enabled)) //second diagonal
            {
                winner = true;

            }
            if (winner)
            {
                DisableButton();

                String winnerIs = "";

                if (turnStatus)

                    winnerIs = "O";
                
                else
                
                    winnerIs = "X";
                

                MessageBox.Show(winnerIs + " IS THE WINNER!"); //Displaying the winner
            }

            else
            {
                if(counter == 9) //checking the draw status;
                    MessageBox.Show("It's a draw!");
            }

        }
        //A method for disableing the buttons
        private void DisableButton()
        {

            foreach (Control control in Controls)
            {

                Button button = (Button)control;
                button.Enabled = false;
            }
        }

    }
}
