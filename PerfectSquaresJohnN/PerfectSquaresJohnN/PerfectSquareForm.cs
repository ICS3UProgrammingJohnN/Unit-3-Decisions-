/*
 * Created by: John Ngundeng
 * Created on: October 24, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares 
 * This program 
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

namespace PerfectSquaresJohnN
{
    public partial class frmPerfectSquare : Form
    {
        public frmPerfectSquare()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int endingValue;
            int value;
            double squareRootAsDouble;
            int squareRootAsInteger;

            // set the initial values
            value = 1;

            // clear all items from the list box 
            this.lstPerfectSquares.Items.Clear();

            // get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            // continue stating any perfect squares between the minimum value and the user's selected end value
            while (value <= endingValue)
            {
                // take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an interger 
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // the only way for both the decimal and the integer to be equal is if the the value was a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
                value = value + 1;

                
            }
        }
    }
}
