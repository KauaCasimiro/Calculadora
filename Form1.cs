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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void soma_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;

            n1 = double.Parse(n1Tb.Text);
            n2 = double.Parse(n2Tb.Text);

            resul = n1 + n2;

            saidaLb.Text = resul.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;

            n1 = double.Parse(n1Tb.Text);
            n2 = double.Parse(n2Tb.Text);

            resul = n1 - n2;

            saidaLb.Text = resul.ToString();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;

            n1 = double.Parse(n1Tb.Text);
            n2 = double.Parse(n2Tb.Text);

            resul = n1 * n2;

            saidaLb.Text = resul.ToString();
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;

            n1 = double.Parse(n1Tb.Text);
            n2 = double.Parse(n2Tb.Text);

            resul = n1 / n2;

            saidaLb.Text = resul.ToString();
        }

        private void seno_Click(object sender, EventArgs e)
        {
            double n1, seno;

            n1 = double.Parse(n1Tb.Text);

            seno = Math.Sin(n1 * (Math.PI / 180));

            saidaLb.Text = seno.ToString();
        }

        private void cosseno_Click(object sender, EventArgs e)
        {
            double n1, cos;

            n1 = double.Parse(n1Tb.Text);

            cos = Math.Cos(n1 * (Math.PI / 180));

            saidaLb.Text = cos.ToString();
        }

        private void tangente_Click(object sender, EventArgs e)
        {
            double n1, tangente;

            n1 = double.Parse(n1Tb.Text);

            tangente = Math.Tan(n1 * (Math.PI / 180));

            saidaLb.Text = tangente.ToString();
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            double n1, n2, potencia;

            n1 = double.Parse(n1Tb.Text);
            n2 = double.Parse(n2Tb.Text);

            potencia = Math.Pow(n1, n2);

            saidaLb.Text = potencia.ToString();
        }

        private void n1Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, raiz;

            n1 = double.Parse(n1Tb.Text);

            if (n1 < 0)
            {
                MessageBox.Show("Valor inválido");
            }

            else
            {
                raiz = Math.Sqrt(n1);

                saidaLb.Text = raiz.ToString();
            }
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            double n1, n2, porcentagem;

            n1 = double.Parse(n1Tb.Text);
            n2 = double.Parse(n2Tb.Text);

            porcentagem = (n1 * (n2/100));

            saidaLb.Text = porcentagem.ToString();
        }
    }
}
