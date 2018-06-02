using System;
using System.Windows.Forms;
using Caelum.CaixaEletronico.Contas;
using Caelum.CaixaEletronico.Usuarios;
using Caelum.CaixaEletronico.Exceptions;
using System.Collections.Generic;
using System.Collections;
using AluraForm;

namespace Caelum.CaixaEletronico {
    public partial class Form2 : Form {

        private List<Conta> contas { get; set; }

        private Conta ContaSelecionada {

            get {
                return this.contas[contasCombo.SelectedIndex];
            }

        }

        private Conta ContaTranferenciaSelecionada {

            get {
                return this.contas[tranferenciaCombo.SelectedIndex];
            }

        }

        public Form2() {
            this.contas = new List<Conta>();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

            contas.Add( new Conta(100, new Cliente("Marcus"), 2000.0) );
            contas.Add( new Conta(101, new Cliente("Vinicius"), 1200.0) );

            foreach (Conta conta in this.contas) {
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

            } catch (FormatException) {
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

                MessageBox.Show("Dinheiro Liberado.");

            } catch (FormatException) {
                MessageBox.Show("Valor não esta dentro dos padrões, digite um numero.");
                valorBox.Text = "";

            } catch (ArgumentException) {
                MessageBox.Show("Não é permitido valores menores que 0.");

            } catch (SaldoInsuficienteException) {
                MessageBox.Show("Saldo insuficiente.");

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

            } catch (FormatException) {
                MessageBox.Show("Valor não esta dentro dos padrões, digite um numero.");
                valorBox.Text = "";
            } catch (IndexOutOfRangeException) {
                MessageBox.Show("Algum dos campos de conta não está preenchido.");
            }

        }

        public void addConta(Conta conta) {

            this.contas.Add(conta);
            contasCombo.Items.Add(conta.TitularNome);
            tranferenciaCombo.Items.Add(conta.TitularNome);

        }

        private void addNewConta_Click(object sender, EventArgs e) {
            new CadastroDeConta(this).ShowDialog();
        }
    }
}
