using System;
using System.Windows.Forms;
using Caelum.CaixaEletronico;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Usuarios;

namespace AluraForm {
    public partial class CadastroDeConta : Form {

        private Form2 form;

        public CadastroDeConta(Form2 form) {
            this.form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            try {

                int numero = Convert.ToInt32(contaNumero.Text);
                String titular = contaTitular.Text;
                double saldo = Convert.ToDouble(contaSaldo.Text);
                contaNumero.Text = "";
                contaTitular.Text = "";
                contaSaldo.Text = "";

                Conta conta = new Conta(numero, new Cliente(titular), saldo);
                this.form.addConta(conta);

                MessageBox.Show("Conta adicionada.");

            } catch (FormatException) {
                MessageBox.Show("Um dos valores não esta dentro dos padrões.");
            }

        }

    }
}
