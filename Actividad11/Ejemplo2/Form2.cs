namespace Ejemplo2
{
    public partial class Form2 : Form
    { 
        
        double acumulador=0;
        double num;
        int contador=0;


        public Form2()
        {
            
            InitializeComponent();
        }

       private void btnRegistrar_Click(object sender, EventArgs e)
        {

           


            num= Convert.ToDouble(tbIngreso.Text);
            acumulador += num;
            contador++;


           tbIngreso.Clear();
            tbProm.Text += $"-{num}" ;


        }

        private void btnMProm_Click(object sender, EventArgs e)
        {
            double prom = acumulador / contador;

            lbPromedio.Text = $"{prom}";
            tbProm.Text =$"Promedio:{prom}  Cont:{contador}";

            contador = 0;
            acumulador = 0;

        }
    }
}
