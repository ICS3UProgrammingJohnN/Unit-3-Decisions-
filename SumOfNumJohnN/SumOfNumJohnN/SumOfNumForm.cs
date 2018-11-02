/*
 * Created by: John Ngundeng
 * Created on: November 2 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Factorial with for loop 
 * This program adds all the numbers less than the number that the 
 * users inputs to give you the sum of numbers
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

namespace SumOfNumJohnN
{
    public partial class frmSumOfNum : Form
    {
        public frmSumOfNum()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare locall variables
            Double sumAnswer;
            Double sumNumber;
            int sumCounter;

            // clear the items from the listbox
            this.lstSumNumbers.Items.Clear();

            // initialize the final answer to 0
            sumAnswer = 0;

            // get the number from the user 
            sumNumber = Convert.ToDouble(this.txtSum.Text);

            for (sumCounter = 1; sumCounter <= sumNumber; sumCounter ++)
            {

                // list the counter number in the listbox for the user to see
                this.lstSumNumbers.Items.Add(sumCounter);

                //Add the counter to the answer
                sumAnswer = sumAnswer + sumCounter;

            }

            // convert the Answer to a string and insert it into the label
            this.lblSumAnswer.Text = this.txtSum.Text + " = " + Convert.ToString(sumAnswer);
        }
    }
}
