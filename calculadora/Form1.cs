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
            txtResultado.Text= soma(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
        }
        private double soma(double valor1, double valor2)
        {
            return valor1 + valor2;
            desativeCheckbox();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            desativeCheckbox();
        }

        private void rb_Sub_CheckedChanged(object sender, EventArgs e)
        {
            txtResultado.Text = sub(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
            desativeCheckbox();
        }
        private double sub(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        private void rb_Div_CheckedChanged(object sender, EventArgs e)
        {
            txtResultado.Text = div(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
            desativeCheckbox();
        }
        private double div(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        private void rb_Mult_CheckedChanged(object sender, EventArgs e)
        {
            txtResultado.Text = mult(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
            desativeCheckbox();

        }

        private double mult(double valor1, double valor2)
        {
            return valor1 * valor2;
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
