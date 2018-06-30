using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Utils {
    public partial class Collections : Form {

        public Collections() {
            InitializeComponent();
        }

        private void List_Click(object sender, EventArgs e) {

            List<string> lista = new List<string>();

            lista.Add("Nome1");
            lista.Add("Nome2");

            MessageBox.Show("Item 2: " + lista[1]);
            MessageBox.Show("Count: " + lista.Count);
            MessageBox.Show("Contains \"Nome1\": " + lista.Contains("Nome1"));

            lista.Remove("Nome2");
            lista.RemoveAt(0);

            foreach (var item in lista) {
                MessageBox.Show("Iterando\n" + "Valor: " + item);
            }

        }

        private void HashSet_Click(object sender, EventArgs e) {

            // HashSet possui um algoritmo eficiante que
            // não permite a adição de objetos iguais.
            HashSet<string> conjunto = new HashSet<string>();
            // Para que funcione corretamente, os métodos
            // GetHashCode() e Equals() precisam estar
            // corretamente implementados nesta classe.

            string nome = "Nome1";
            conjunto.Add(nome);
            conjunto.Add(nome);

            MessageBox.Show("Count: " + conjunto.Count);
            // Não é possível acessar os elementos
            // utilizando a mesma notação de Array
            // (conjunto[0] funciona).

            conjunto.Clear();

        }

        private void SortedSet_Click(object sender, EventArgs e) {

            // SortedSet possui o mesmo efeito de HashSet,
            // porém mantem os elementos em ordem crescente.
            SortedSet<string> palavras = new SortedSet<string>();
            palavras.Add("Xenoblade");
            palavras.Add("Americano");
            palavras.Add("Camelo");

            foreach (string palavra in palavras) {
                MessageBox.Show(palavra);
            }

        }

        private void Dictionary_Click(object sender, EventArgs e) {

            // Dicionário armazenam valores de acordo com uma certa chave.
            // int - chave; string - valor;
            Dictionary<int, string> dicionario = new Dictionary<int, string>();

            dicionario.Add(70, "Hello World.");
            dicionario.Add(15, "If-Else");

            // Assim é possível recuperar um elemento utilizando a chave.
            MessageBox.Show("Chave 15 = " + dicionario[15]);

            // É possível recuperar a variável que armazena tanto
            // a chave quanto o valor referente a ela.
            foreach(KeyValuePair<int, string> i in dicionario) {
                MessageBox.Show("Iterando\n"
                    + "Chave: " + i.Key + "\n"
                    +  "Valor: " + i.Value);
            }

            // Há também a classe SortedDictionary que funciona da mesma
            // maneira, porém com os elementos ordenados.

        }

    }
}
