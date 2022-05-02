using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testando_solo
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Account novaConta = new ContaPoupanca();
            novaConta.Titular = textoTitular.Text;
            novaConta.ContaNumero = Convert.ToInt32(textoNumero.Text);
            this.formPrincipal.AdicionaConta(novaConta);
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {

        }
    }
}
