using System;

namespace Ejemplo3
{
    public partial class Form1 : Form
    {
        double num;
        double acumulador = 0;
        int contador = 0;
        double[] valores = new double[100];
        double prom;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            valores[contador] = Convert.ToDouble(tbIngreso.Text);
            contador++;


            tbIngreso.Clear();

        }

        private void btnMProm_Click_1(object sender, EventArgs e)
        {
            acumulador = 0;
            for (int i = 0; i <= contador; i++)
            {
                acumulador += valores[i];
            }

            prom = acumulador / contador;

            lbPromedio.Text = $"{prom}";
            tbProm.Text = $"Promedio:{prom}";
        }
    }
}
