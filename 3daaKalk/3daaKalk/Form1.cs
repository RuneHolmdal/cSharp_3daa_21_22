using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3daaKalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        string tall1 = "";
        string tall2 = "";
        string regneOp = ""; //"+", "-" ("pluss", "minus")
        private void btnPluss_Click(object sender, EventArgs e)
        {
            tall1 = tbDisplay.Text;
            tbDisplay.Text = "";
            regneOp = btnPluss.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            tall1 = tbDisplay.Text;
            tbDisplay.Text = "";
            regneOp = btnMinus.Text;
        }


        private void btnErlik_Click(object sender, EventArgs e)
        {
            tall2 = tbDisplay.Text;
            int t1 = Convert.ToInt32(tall1);
            int t2 = Convert.ToInt32(tall2);
            int r = 0;
            // - --> int s = t1 - t2;
            if (regneOp == "+")
                r = t1 + t2;
            else if (regneOp == "-")
                r = t1 - t2;
            string resultat = Convert.ToString(r);
            tbDisplay.Text = resultat;
        }

        private void btSlett_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
            tall1 = "";
            tall2 = "";
        }

    }
}
