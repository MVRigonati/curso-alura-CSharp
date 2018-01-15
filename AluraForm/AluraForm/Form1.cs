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
    public partial class Form1 : Form {

        Conta conta1;

        public Form1() {

            InitializeComponent();
            conta1 = new Conta(1, new Cliente("Victor", 20), 250.0);

            titularBox.Text = conta1.TitularNome;
            saldoBox.Text = Convert.ToString(conta1.Saldo);
            numeroBox.Text = Convert.ToString(conta1.Numero);

        }

        private void titularText_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            try {

                double valor = Convert.ToDouble(valorBox.Text);
                conta1.Deposita(valor);
                atualizaSaldo();
                valorBox.Text = "";

            } catch (FormatException ex) {
                MessageBox.Show("Valor não esta dentro dos padrões, digite um numero.");
                valorBox.Text = "";
            }

        }

        private void atualizaSaldo() {
            saldoBox.Text = Convert.ToString(conta1.Saldo);
        }

        private void button2_Click(object sender, EventArgs e) {

            try {

                double valor = Convert.ToDouble(valorBox.Text);
                conta1.Saca(valor);
                atualizaSaldo();
                valorBox.Text = "";

            } catch (FormatException ex) {
                MessageBox.Show("Valor não esta dentro dos padrões, digite um numero.");
                valorBox.Text = "";
            }

        }
    }
}
