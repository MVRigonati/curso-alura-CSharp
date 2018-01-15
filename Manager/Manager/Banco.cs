using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Manager.Model;

namespace Manager {

    class Banco {

        public Conta[] Contas { get; private set; }
        private int Ponteiro { get; set; }

        public Banco(int num) {
            this.Contas = new Conta[num];
            this.Ponteiro = 0;
        }

        public void Adiciona(Conta conta) {

            if (this.Ponteiro < this.Contas.Length) {
                this.Contas[this.Ponteiro] = conta;
                this.Ponteiro++;
            }

        }

    }

}