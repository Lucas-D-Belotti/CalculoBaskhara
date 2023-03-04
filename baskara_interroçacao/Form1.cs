using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baskara_interroçacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, D;

            string s = "▲", l = "2";

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            D = Math.Pow(b, Convert.ToInt32(l)) - 4 * a * c;

            Delta.Text = s + " = " + Convert.ToString(D);

            if (D < 0)
            {
                resulX1.Text = "Não existe raiz dentro do conjunto dos REAIS";
                ResulX2.Text = "Não existe raiz dentro do conjunto dos REAIS";
            }
            else
            {

                resulX1.Text = "X1 = " + Convert.ToString((-(b) + Math.Sqrt(D)) / (2 * a));
                ResulX2.Text = "X2 = " + Convert.ToString((-(b) - Math.Sqrt(D)) / (2 * a));
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";

            Delta.Text = "▲ = ?";

            resulX1.Text = "X1 = ?";
            ResulX2.Text = "X2 = ?";

            txtA.Focus();
        }
    }
}
