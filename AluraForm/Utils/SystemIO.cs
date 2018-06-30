using System;
using System.Windows.Forms;
using System.IO;

namespace Utils {
    public partial class SystemIO : Form {

        private static string fileName = "Texto.txt";

        public SystemIO() {
            InitializeComponent();
        }

        private void SalvarButtom_Click(object sender, EventArgs e) {

            using ( StreamWriter writer = new StreamWriter(
                File.Open(fileName, FileMode.Create)) ) {
                
                writer.Write(textBox.Text);
                writer.Close();

                MessageBox.Show("Texto Salvo Com sucesso!");

            }

        }

        private void SystemIO_Load(object sender, EventArgs e) {

            if (!File.Exists(fileName)) {
                File.Create(fileName);
            }

            using ( StreamReader reader = new StreamReader(
                File.Open(fileName, FileMode.Open)) ) {
                textBox.Text = reader.ReadToEnd();
            }

        }

    }
}
