using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float total = 0;
        float valor1 = 0;
        float valor2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "0";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + ",";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "/";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "*";
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "-";
        }

        private void somar_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "+";
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            if (resultado.Text.Contains('/'))
            {
                String[] valores = resultado.Text.Split('/');
                valor1 = Convert.ToSingle(valores[0]);
                valor2 = Convert.ToSingle(valores[1]);
                total = valor1 / valor2;
            }
            else if (resultado.Text.Contains('*'))
            {
                String[] valores = resultado.Text.Split('*');
                valor1 = Convert.ToSingle(valores[0]);
                valor2 = Convert.ToSingle(valores[1]);
                total = valor1 * valor2;
            }
            else if (resultado.Text.Contains('-'))
            {
                String[] valores = resultado.Text.Split('-');
                valor1 = Convert.ToSingle(valores[0]);
                valor2 = Convert.ToSingle(valores[1]);
                total = valor1 - valor2;
            }
            else
            {
                String[] valores = resultado.Text.Split('+');
                valor1 = Convert.ToSingle(valores[0]);
                valor2 = Convert.ToSingle(valores[1]);
                total = valor1 + valor2;
            }
            resultado.Text = Convert.ToString(total);
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
        }
    }
}
