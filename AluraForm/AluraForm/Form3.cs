using Caelum.CaixaEletronico.Usuarios;
using System.Windows.Forms;

namespace AluraForm {
    public partial class Form3 : Form {

        public Form3() {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e) {

            Cliente cliente = new Cliente("Marcus");
            cliente.RG = "53.689.712-8";

            Cliente cliente2 = new Cliente("Marcus");
            cliente2.RG = "53.689.712-8";

            MessageBox.Show("Testando método \"Equals()\" da classe cliente:\n" + cliente.Equals(cliente2));
            MessageBox.Show("Testando método \"toString()\" da classe cliente:\n" + cliente.ToString());

        }

    }
}
