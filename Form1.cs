namespace testando_solo
{
    public partial class Form1 : Form
    {
        private Conta p = new Conta();
        private ContaPoupanca novo = new ContaPoupanca();
        public Form1()
        {
            InitializeComponent();
        }

        private void Formulario(object sender, EventArgs e)
        {
            this.novo.Titular = "Pedro";
            this.novo.Saldo = 2000;
            this.novo.ContaNumero = 3212;
            textoTitular.Text = this.novo.Titular;
            textoSaldo.Text = Convert.ToString(this.novo.Saldo);
            textoConta.Text = Convert.ToString(this.novo.ContaNumero);
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double valorAdd = Convert.ToDouble(textoDeposito.Text);
            this.novo.Deposita(valorAdd);
            textoSaldo.Text = Convert.ToString(this.novo.Saldo);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double valorAdd = Convert.ToDouble(textoSaque.Text);
            bool ver = this.novo.Saca(valorAdd);
            textoSaldo.Text = Convert.ToString(this.novo.Saldo);
            if (ver)
            {
                MessageBox.Show("Saldo Efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }
    }
}