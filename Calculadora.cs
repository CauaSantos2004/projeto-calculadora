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
            //Valida��o de Campos do N�mero1 e N�mero2

            //A linha abaixo verifica se o campo "Numero1" est� vazio ou cont�m apenas espa�os em branco.
            if (string.IsNullOrWhiteSpace(txtNumero1.Text)) //poderia ser tambem esse c�digo: if (string.IsNullOrWhiteSpace(txtNumero1.Text)) ||  if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                //Nessa linha, se o Campo Numero 1 estiver vazio, exibe uma mensagem de alerta ao us�ario
                MessageBox.Show("Por favor, Preencha o campo Numero 1.");
                txtNumero1.Focus();//Coloca o cursor de volta no campo txtNumero1, para o usu�rio digitar algo. 
                return; //Sai do m�todo aqui mesmo, para n�o continuar com a soma se o campo estiver vazio.
            }

            /*
             A linha abaixo erifica se o que foi digitado no campo "N�mero 1" � um n�mero,
             Se o usu�rio digitar letras, s�mbolos ou deixar o valor incorreto,
             exibe uma mensagem de erro e interrompe o c�lculo.
             */
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 1 somente com n�mero.");
                return;

            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                //Nessa linha, se o Campo Numero 2 estiver vazio, exibe uma mensagem de alerta
                MessageBox.Show("Por favor, preencha o campo N�mero 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 2 somente com n�mero.");
            }

            //Converte o double (numero digitado pelo usuario) para string(texto)
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("Por favor, Preencha o campo N�mero 1.");
                txtNumero1.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 1 somente com n�mero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo N�mero 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 2 somente com n�mero.");
            }

            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("Por favor, Preencha o campo N�mero 1.");
                txtNumero1.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 1 somente com n�mero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo N�mero 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 2 somente com n�mero.");
                return;
            }

            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("Por favor, Preencha o campo N�mero 1.");
                txtNumero1.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 1 somente com n�mero.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo N�mero 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo N�mero 1 somente com n�mero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo N�mero 2.");
                txtNumero2.Focus();
                return;
            }
        }
    }
}

