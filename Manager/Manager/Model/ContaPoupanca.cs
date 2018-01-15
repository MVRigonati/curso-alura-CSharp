using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model {
    class ContaPoupanca : Conta, InterfaceTributavel {

        public ContaPoupanca(int num, Cliente titular, double saldo)
            : base(num, titular, saldo) {

        }

        override public double Saca(double valor) {
            base.Saldo -= valor + 0.1;
            return valor;
        }

        override public void Deposita(double valor) {

            if (valor > 0) {
                base.Saldo += valor + 0.1;
            }

        }

        public double CalculaTributo() {
            return base.Saldo * 0.02;
        }

    }
}