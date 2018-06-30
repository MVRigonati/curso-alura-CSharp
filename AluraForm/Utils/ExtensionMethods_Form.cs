using System;
using System.Windows.Forms;
using Utils.ExtensionMethods;
// Importante lembrar que é necessário importar a classe
// mesmo fazendo um extension method.

namespace Utils {
    public partial class ExtensionMethods_Form : Form {

        public ExtensionMethods_Form() {
            InitializeComponent();
        }

        private void ExtensionMethods_Load(object sender, EventArgs e) {

            // Com o extension method podemos adicionar métodos a classes
            // já existentes do C#.
            MessageBox.Show("Conta".ToPlural());
            // Importante lembrar que se a classe original, nesse caso string,
            // vier a implementar um método com o mesmo nome algum dia,
            // o compilador dará prioridade para o método nativo
            // e não o que foi criado aqui.

        }

    }
}
