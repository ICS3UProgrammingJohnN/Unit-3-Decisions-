/*
 * Created by: John Ngundeng
 * Created on: October 18, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program tells the user the prize they get 
 * with a different amount of boxes sold
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

namespace ChocoBoxesJohnN
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
            // Hiding the reward from the user
            lblPrize.Hide();
        }

        private void btnPrize_Click(object sender, EventArgs e)
        {
            // delcaring variable 
            double prize;

            // converting the textbox into an interger
            prize = double.Parse(txtChocolateBoxes.Text);

            // Displays the users prize for the amount they have sold
            if (prize > 20 )
            {
                lblPrize.Text = "You have won a prize!";
                lblPrize.Show();
            }
            else if(prize < 10)
            {
                lblPrize.Text = "You got an honorable mention.";
                lblPrize.Show();
            }
            else
            {
                lblPrize.Text = "You got a small prize.";
                lblPrize.Show();
            }
        }
    }
}
