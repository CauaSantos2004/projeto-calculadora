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
            //Validação de Campos do Número1 e Número2

            //A linha abaixo verifica se o campo "Numero1" está vazio ou contém apenas espaços em branco.
            if (string.IsNullOrWhiteSpace(txtNumero1.Text)) //poderia ser tambem esse código: if (string.IsNullOrWhiteSpace(txtNumero1.Text)) ||  if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                //Nessa linha, se o Campo Numero 1 estiver vazio, exibe uma mensagem de alerta ao usúario
                MessageBox.Show("Por favor, Preencha o campo Numero 1.");
                txtNumero1.Focus();//Coloca o cursor de volta no campo txtNumero1, para o usuário digitar algo. 
                return; //Sai do método aqui mesmo, para não continuar com a soma se o campo estiver vazio.
            }

            /*
             A linha abaixo erifica se o que foi digitado no campo "Número 1" é um número,
             Se o usuário digitar letras, símbolos ou deixar o valor incorreto,
             exibe uma mensagem de erro e interrompe o cálculo.
             */
            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;

            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                //Nessa linha, se o Campo Numero 2 estiver vazio, exibe uma mensagem de alerta
                MessageBox.Show("Por favor, preencha o campo Número 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 2 somente com número.");
            }

            //Converte o double (numero digitado pelo usuario) para string(texto)
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("Por favor, Preencha o campo Número 1.");
                txtNumero1.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Número 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 2 somente com número.");
            }

            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("Por favor, Preencha o campo Número 1.");
                txtNumero1.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Número 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 2 somente com número.");
                return;
            }

            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text))
            {
                MessageBox.Show("Por favor, Preencha o campo Número 1.");
                txtNumero1.Focus();
                return;
            }

            if (!double.TryParse(txtNumero1.Text, out double numero1))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Número 2.");
                txtNumero2.Focus();
                return;
            }

            if (!double.TryParse(txtNumero2.Text, out double numero2))
            {
                MessageBox.Show("Por favor, Preencha o Campo Número 1 somente com número.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Número 2.");
                txtNumero2.Focus();
                return;
            }
        }
    }
}

