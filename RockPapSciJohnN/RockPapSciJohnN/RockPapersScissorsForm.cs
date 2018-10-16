/*
 * Created by: John Ngundeng
 * Created on: october 16, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program alows you to play rock paper scissors with the computer.
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

namespace RockPapSciJohnN
{
    public partial class frmRockPapersScissors : Form
    {
        // declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPapersScissors()
        {
            InitializeComponent();
            // create the random number generator object
            randomNumberGenerator = new Random();

            // hiding the labels
            lblOutcome.Hide();
        }

        private void radComPaper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblOutcome_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // delcare local variables and constants 
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            // hiding the labels
            lblOutcome.Show();

            // get user's selection, if there is no selection set it to 0 
            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
                this.picPlayerChoice.Image = Properties.Resources.rock; 
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
                this.picPlayerChoice.Image = Properties.Resources.paper;
            }
            else if (radPlayerScissors.Checked == true)
            {
                playerChoice = SCISSORS;
                this.picPlayerChoice.Image = Properties.Resources.scissors;
            }
            else
            {
                playerChoice = 0;
            }

            // randomly generate a number between 1 and 3,representing rock paper and scissors
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set radio button for computers choice
            if (computerChoice == ROCK)
            {
                this.radComRock.Checked = true;
                this.picComChoice.Image = Properties.Resources.rock;
            }
            else if (computerChoice == PAPER)
            {
                this.radComPaper.Checked = true;
                this.picComChoice.Image = Properties.Resources.paper;
            }
            else
            {
                this.radComScissors.Checked = true;
                this.picComChoice.Image = Properties.Resources.scissors;
            }

            // comparing results between the the two outcomes
            if (playerChoice == ROCK)
                if (computerChoice == ROCK)
                {
                    lblOutcome.Text = "It's a draw";
                }
                else if (computerChoice == PAPER)
                {
                    lblOutcome.Text = "Computer wins";
                }
                else
                {
                    lblOutcome.Text = "You win";
                }
            else if (playerChoice == PAPER)
                if (computerChoice == PAPER)
                {
                    lblOutcome.Text = "It's a draw";
                }
                else if (computerChoice == SCISSORS)
                {
                    lblOutcome.Text = "Computer wins";
                }
                else
                {
                    lblOutcome.Text = "You win";
                }
            else if (playerChoice == SCISSORS)
                if (computerChoice == SCISSORS)
                {
                    lblOutcome.Text = "It's a draw";
                }
                else if (computerChoice == ROCK)
                {
                    lblOutcome.Text = "Computer wins";
                }
                else
                {
                    lblOutcome.Text = "You win";
                }
            else
            {
                lblOutcome.Text = "Please make a choice";
            }
        }    
    }
}
