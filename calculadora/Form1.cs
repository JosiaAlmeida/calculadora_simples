using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_Soma_CheckedChanged(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txt_Valor1.Text);
            double v2 = Convert.ToDouble(txt_Valor2.Text);
            txtResultado.Text = calc(v1, v2, '+').ToString();
            desativeCheckbox();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            desativeCheckbox();
        }

        private void rb_Sub_CheckedChanged(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txt_Valor1.Text);
            double v2 = Convert.ToDouble(txt_Valor2.Text);
            txtResultado.Text = calc(v1, v2, '-').ToString();
            desativeCheckbox();
        }
        private void rb_Div_CheckedChanged(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txt_Valor1.Text);
            double v2 = Convert.ToDouble(txt_Valor2.Text);
            txtResultado.Text = calc(v1, v2, '/').ToString();
            desativeCheckbox();
        }
        private void rb_Mult_CheckedChanged(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txt_Valor1.Text);
            double v2 = Convert.ToDouble(txt_Valor2.Text);
            txtResultado.Text = calc(v1, v2, '*').ToString();
            desativeCheckbox();

        }
        private double calc(double v1, double v2, char operador)
        {
            switch (operador)
            {
                case '+': return v1 + v2;
                case '-': return v1 - v2;
                case '*': return v1 * v2;
                default: return v1 / v2;
            }
        }
        private void desativeCheckbox()
        {
            rb_Div.Checked = false;
            rb_Mult.Checked = false;
            rb_Soma.Checked = false;
            rb_Sub.Checked = false;
        }
    }
}
