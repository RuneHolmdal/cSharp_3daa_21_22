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

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btnKomma_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Text.Contains(","))
                tbDisplay.Text = tbDisplay.Text + ",";
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

        private void btnGange_Click(object sender, EventArgs e)
        {
            tall1 = tbDisplay.Text;
            tbDisplay.Text = "";
            regneOp = btnGange.Text;
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            tall1 = tbDisplay.Text;
            tbDisplay.Text = "";
            regneOp = btnDele.Text;
        }

        private void btnErlik_Click(object sender, EventArgs e)
        {
            bool feil = false;

            tall2 = tbDisplay.Text;
            decimal t1 = Convert.ToDecimal(tall1);
            decimal t2 = Convert.ToDecimal(tall2);
            decimal r = 0;
            // - --> int s = t1 - t2;
            if (regneOp == "+")
                r = t1 + t2;
            else if (regneOp == "-")
                r = t1 - t2;
            else if (regneOp == "*")
                r = t1 * t2;
            else if (regneOp == "/")
                if (t2 == 0)
                    feil = true;
                else
                    r = t1 / t2;
            string resultat = Convert.ToString(r);

            if (!feil)
                tbDisplay.Text = resultat;
            else
                tbDisplay.Text = "Kan ikke dele på null!!!";

            // En linje med kommentar

            /* Ett område med kommentar
             * 
             * 
             avsluttes her --> */


            /* Alternativ måte å skrive dte samme på, som er mye brukt.
            if (feil)
                tbDisplay.Text = "Kan ikke dele på null!!!";
            else
                tbDisplay.Text = resultat;
            */
        }

        private void btSlett_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
            tall1 = "";
            tall2 = "";
        }

        private void btnSlettTilbake_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length > 0)
                tbDisplay.Text = tbDisplay.Text.Remove(tbDisplay.Text.Length - 1);
        }

        private void btnPlussMinus_Click(object sender, EventArgs e)
        {
            decimal dt = Convert.ToDecimal(tbDisplay.Text);
            dt = dt * -1;
            tbDisplay.Text = Convert.ToString(dt);
        }

        private void btn2Potens_Click(object sender, EventArgs e)
        {
            double dt = Convert.ToDouble(tbDisplay.Text);
            //dt = dt * dt;
            dt = Math.Pow(dt, 2);
            tbDisplay.Text = Convert.ToString(dt);
        }
    }
}
