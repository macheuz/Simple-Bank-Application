namespace testando_solo
{
    public partial class Form1 : Form
    {
        private Account[] contas;
        private int numeroDeContas;
        public Form1()
        {
            InitializeComponent();
        }
        public void AdicionaConta(Account conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("Titular: " + conta.Titular);
        }

        private void Formulario(object sender, EventArgs e)
        {
            contas = new Account[30];
            Account c1 = new Account();
            c1.Titular = "Victor";
            c1.ContaNumero = 1;
            this.AdicionaConta(c1);

            Account c2 = new Account();
            c2.Titular = "Marcos";
            c2.ContaNumero = 2;
            this.AdicionaConta(c2);

            Account c3 = new Account();
            c1.Titular = "Luana";
            c1.ContaNumero = 3;
            this.AdicionaConta(c3);
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex; ;
            double valorAdd = Convert.ToDouble(textoDeposito.Text);
            this.contas[indice].Deposita(valorAdd);
            textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            double valorAdd = Convert.ToDouble(textoSaque.Text);
            bool ver = this.contas[indice].Saca(valorAdd);
            this.contas[indice].Saca(valorAdd);
            textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
            if (ver)
            {
                MessageBox.Show("Saque Efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }


        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            textoTitular.Text = this.contas[indice].Titular;
            textoConta.Text = Convert.ToString(this.contas[indice].ContaNumero);
            textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog(); 
        }
    }
}