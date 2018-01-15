using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model {
    class ContaCorrente : Conta {

        public override double Saca(double valor) {
            base.Saldo -= valor;
            return valor;
        }

        public ContaCorrente(int num, Cliente titular, double saldo) :
            base(num, titular, saldo) {

        }

    }
}
