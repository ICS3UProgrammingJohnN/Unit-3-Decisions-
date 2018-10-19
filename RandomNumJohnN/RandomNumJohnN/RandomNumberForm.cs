/*
 * Created by: John Ngundeng
 * Created on: October 19, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program makes you guess the random number between 1 and 10
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

namespace RandomNumJohnN
{
    public partial class frmRandomNumber : Form
    {
        // declare global variables and constants
        int correctGuess;
        Random randomNumberGenerator = new Random();
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;

        public frmRandomNumber()
        {
            InitializeComponent();
            //hiding the labels and the pictures
            lblAnswer.Hide();
            picAnswer.Hide();

            // generate the random number
            correctGuess = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare user guess
            int userGuess;

            // get guess from the textbox
            userGuess = int.Parse(txtGuess.Text);

            // Displays to the user weather the guess was correct or not
            if (userGuess == correctGuess)
            {
                this.picAnswer.Image = Properties.Resources.checkmark;
                lblAnswer.Text = "your guess was right!";
                lblAnswer.Show();
                picAnswer.Show();
            }
            else
            {
                this.picAnswer.Image = Properties.Resources.red_x;
                lblAnswer.Text = "your guess was wrong.";
                lblAnswer.Show();
                picAnswer.Show();
            }
        }
    }
}
