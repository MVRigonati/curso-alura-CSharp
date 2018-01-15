using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model {
    class Cliente {

        public String Nome { get; set; }
        private String RG { get; set; }
        private String Endereco { get; set; }
        private int Idade { get; set; }

        public Cliente(String nome) {
            this.Nome = nome;
        }

        public Cliente (String nome, String rg, String endereco) {
            this.Nome = nome;
            this.RG = rg;
            this.Endereco = endereco;
        }

        public bool IsMaiorDeIdade() {
            return (this.Idade >= 18);
        }

    }
}
