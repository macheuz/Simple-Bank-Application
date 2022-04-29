namespace testando_solo
{
    public partial class Form1 : Form
    {
        private Account[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Formulario(object sender, EventArgs e)
        {
            contas = new Account[3];
            this.contas[0] = new Account();
            this.contas[0].Titular = ("Victor");
            this.contas[0].ContaNumero = 1;
            this.contas[1] = new Account();
            this.contas[1].Titular = ("Mauricio");
            this.contas[1].ContaNumero = 2;
            this.contas[2] = new Account();
            this.contas[2].Titular = ("Osni");
            this.contas[2].ContaNumero = 3;
            
            foreach (Account conta in contas)
            {
                comboContas.Items.Add(conta.Titular);
            }

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
    }
}