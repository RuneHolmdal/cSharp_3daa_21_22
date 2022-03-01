using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bondesjakk_3daa_21_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool spiller = true; // true = spiller 1 og false = spiller 2
        private void btn0_0_Click(object sender, EventArgs e)
        {

        }

        private void btnSpill_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Text == "")
            {
                if (spiller)
                    b.Text = "X";
                else
                    b.Text = "O";
                spiller = !spiller;
                //spiller != spiller; alternativ måte til linjen over
                if (spiller)
                    label1.Text = "Spiller 1";
                else
                    label1.Text = "Spiller 2";
            }
        }
    }
}
