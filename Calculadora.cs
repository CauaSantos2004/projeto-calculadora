namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Verifica os Campos de entrada estão preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            //Converte o double (numero digitado pelo usuario) para string(texto)
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 - numero2).ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
