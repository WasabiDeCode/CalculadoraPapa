using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2;
            double porc;
            Valor1 = Convert.ToDouble(textBox1.Text);
            Valor2 = Convert.ToDouble(textBox2.Text);
            porc = (100 / Valor1) * Valor2;
            label4.Text = Convert.ToString(porc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "0.0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2;
            double porc;
            Valor1 = Convert.ToDouble(textBox3.Text);
            Valor2 = Convert.ToDouble(textBox4.Text);
            porc = (Valor2 / 100) * Valor1;
            label7.Text = Convert.ToString(porc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            label7.Text = "0.0";
        }
    }
}
