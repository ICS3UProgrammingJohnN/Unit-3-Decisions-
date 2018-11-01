/*
 * Created by: John Ngundeng
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program loads a progress bar
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

namespace DoWhileJohnN
{
    public partial class frmDoWhile : Form
    {
        public frmDoWhile()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare variables and constants
            const int MAX_PROGRESS_BAR_VALUE = 100;
            int valueOfProgressBar = 0;

            // increment the value of the progress bar by 5
            do
            {
                this.prbProgressBar.Value = valueOfProgressBar;
                valueOfProgressBar = valueOfProgressBar + 5;
                this.Refresh();
            } while (valueOfProgressBar <= MAX_PROGRESS_BAR_VALUE);
        }
    }
}
