using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1, v2;
            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);
            MessageBox.Show("A soma é: " + (v1 + v2));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int v1, v2;
            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);
            MessageBox.Show("A subtração é: " + (v1 - v2));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int v1, v2;
            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);
            MessageBox.Show("A multiplicação é: " + (v1 * v2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int v1, v2;
            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);
            MessageBox.Show("A divisão é: " + (v1 / v2));
        }
    }
}
