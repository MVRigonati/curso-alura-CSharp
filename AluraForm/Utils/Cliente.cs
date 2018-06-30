using System;

namespace Caelum.CaixaEletronico.Usuarios {
    public class Cliente {

        public String Nome { get; set; }
        public String RG { get; set; }
        public String Endereco { get; set; }
        public int Idade { get; set; }

        public Cliente(String nome) {
            this.Nome = nome;
        }

        public Cliente(String nome, int idade) {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Cliente (String nome, String rg, String endereco) {
            this.Nome = nome;
            this.RG = rg;
            this.Endereco = endereco;
        }

        public override bool Equals(object obj) {

            Cliente parametro = (Cliente) obj;
            return this.RG.Equals( parametro.RG );

        }

        public override string ToString() {
            return "Cliente - Nome: " + this.Nome + " / RG: " + this.RG;
        }

        public bool IsMaiorDeIdade() {
            return (this.Idade >= 18);
        }

    }
}
