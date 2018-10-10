/*
     * Created by: John Ngundeng
     * Created on: October 10, 2018
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Guessing Game
     * This program makes the user guess the right number
    */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGameJohnN
{
    public partial class frmGuessGame : Form
    {
        public frmGuessGame()
        {
            InitializeComponent();
            // Hiding the labels and picture
            lblAnswer.Hide();
            picAnswer.Hide();            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare variables
            int userGuess;
            const int CORRECTNUMBER = 3;

            // Get guess from the textbox
            userGuess = int.Parse(txtGuess.Text);

            // if the guess i
            if (userGuess == CORRECTNUMBER)
            {
                this.picAnswer.Image = Properties.Resources.checkmark;
                lblAnswer.Text = "Your guess was right!.";
                lblAnswer.Show();
                picAnswer.Show();
            }
            else
            {
                this.picAnswer.Image = Properties.Resources.red_x;
                lblAnswer.Text = "Your guess was wrong.";
                lblAnswer.Show();
                picAnswer.Show();
            }
        }
    }
}
