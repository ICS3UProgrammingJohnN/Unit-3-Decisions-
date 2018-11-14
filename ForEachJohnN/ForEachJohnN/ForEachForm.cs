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

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Goldenrod;
                }
            }
        }
    }
}
