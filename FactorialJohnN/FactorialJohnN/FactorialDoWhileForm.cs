/*
 * Created by: John Ngundeng
 * Created on: November 1 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program gets the factorial of a number picked by the user
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

namespace FactorialJohnN
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare locall variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user 
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the counter by the next incremented number until it reaches the user's number
            do
            {
                // increment the counter by 1
                factorialCounter = factorialCounter + 1;

                // list the counter number in the listbox for the user to see
                this.lstFactorialNumbers.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialCounter < factorialNumber);

            // convert the factorialAnswer to a string and insert it into the label
            this.lblFactoralAnswer.Text = this.txtNumber.Text + " ! = " + Convert.ToString(factorialAnswer); 
        }
    }
}
