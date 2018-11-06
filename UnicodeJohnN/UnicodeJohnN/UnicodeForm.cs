/*
 * Created by: John Ngundeng
 * Created on: November 5 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program shows the unicode number for each capital letter.
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

namespace UnicodeJohnN
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables 
            string letters;
            int counter;

            // clear the items in the list box 
            this.lstNumbers.Items.Clear();

            for (counter = 65; counter <= 90; counter++)
            {
                letters = Char.ConvertFromUtf32(counter);

                this.lstNumbers.Items.Add(letters +" -->  " + counter);
            }

        }
    }
}
