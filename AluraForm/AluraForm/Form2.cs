using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraForm {
    public partial class Form2 : Form {

        private Conta[] Contas { get; set; }

        private Conta ContaSelecionada {

            get {
                return this.Contas[contasCombo.SelectedIndex];
            }

        }

        private Conta ContaTranferenciaSelecionada {

            get {
                return this.Contas[tranferenciaCombo.SelectedIndex];
            }

        }

        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

            Contas = new Conta[2];

            Contas[0] = new Conta(100, new Cliente("Marcus"), 2000.0);
            Contas[1] = new Conta(101, new Cliente("Vinicius"), 1200.0);

            foreach (Conta conta in this.Contas) {
                contasCombo.Items.Add(conta.TitularNome);
                tranferenciaCombo.Items.Add(conta.TitularNome);
            }

        }

        private void contasCombo_SelectedIndexChanged(object sender, EventArgs e) {

            Conta contaSelecionada = ContaSelecionada;

            titularBox.Text = contaSelecionada.TitularNome;
            numeroBox.Text = Convert.ToString(contaSelecionada.Numero);
            saldoBox.Text = Convert.ToString(contaSelecionada.Saldo);

        }

        private void button1_Click(object sender, EventArgs e) {

            try {

                double valor = Convert.ToDouble(valorBox.Text);
                ContaSelecionada.Deposita(valor);
                saldoBox.Text = Convert.ToString(ContaSelecionada.Saldo);
                valorBox.Text = "";

            } catch (FormatException ex) {
                MessageBox.Show("Valor não esta dentro dos padrões, digite um numero.");
                valorBox.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e) {

            try {

                double valor = Convert.ToDouble(valorBox.Text);
                ContaSelecionada.Saca(valor);
                saldoBox.Text = Convert.ToString(ContaSelecionada.Saldo);
                valorBox.Text = "";

            } catch (FormatException ex) {
                MessageBox.Show("Valor não esta dentro dos padrões, digite um numero.");
                valorBox.Text = "";
            }

        }

        private void button3_Click(object sender, EventArgs e) {

            try {

                if (ContaSelecionada != ContaTranferenciaSelecionada) {

                    double valor = Convert.ToDouble(valorTransfereBox.Text);
                    ContaSelecionada.Transfere(valor, ContaTranferenciaSelecionada);
                    valorTransfereBox.Text = "";
                    saldoBox.Text = Convert.ToString(ContaSelecionada.Saldo);

                } else {
                    MessageBox.Show("Você não pode fazer uma transferencia para a mesma conta.");
                }

            } catch (FormatException ex) {
                MessageBox.Show("Valor não esta dentro dos padrões, digite um numero.");
                valorBox.Text = "";
            } catch (IndexOutOfRangeException ex) {
                MessageBox.Show("Algum dos campos de conta não está preenchido.");
            }

        }
    }
}
