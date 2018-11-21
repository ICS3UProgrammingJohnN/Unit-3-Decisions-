/*
 * Created by: John Ngundeng
 * Created on: November 5, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program Changes the colour of objects when clicked
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

namespace ForEachJohnN
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Blue;
            }
        }

        private void lblChangeColor_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Goldenrod;

                if (aControlObject.GetType() == typeof(Button))
                {
                    aControlObject.BackColor = Color.Red;
                }
                if (aControlObject.GetType() == typeof(GroupBox))
                {
                    aControlObject.BackColor = Color.Purple;
                }
            }
        }

        private void grbGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
