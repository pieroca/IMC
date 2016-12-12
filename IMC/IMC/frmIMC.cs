using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(maskedTextBox1.Text);
            b = Convert.ToDouble(maskedTextBox2.Text);
            if (b == 0)
            {
                textBox3.Text = "Ingrese un Valor distinto a cero (0)";
            }
            else
            {
                c = a / (b * b);
                textBox3.Text = "IMC: "+c.ToString();

                if (c >= 18.5 && c <= 24.9)
                {
                    textBox1.Text = "RIESGO: PROMEDIO";
                }else
                    if(c >= 25 && c <= 29.9)
                {
                    textBox1.Text = "RIESGO: AUMENTADO";
                }else
                    if(c >= 30 && c <= 34.9)
                {
                    textBox1.Text = "RIESGO: MODERADO";
                }else
                    if(c >= 35 && c <= 39.9)
                {
                    textBox1.Text = "RIESGO: SEVERO";
                }else
                    if(c >= 40)
                {
                    textBox1.Text = "RIESGO: MUY SEVERO";
                }
            }

        }
    }
}
