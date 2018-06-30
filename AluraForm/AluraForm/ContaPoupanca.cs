using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico.Contas {
    class ContaPoupanca : Conta {

        public ContaPoupanca(int num, Cliente titular, double saldo)
            : base(num, titular, saldo) {
            
        }

    }
}
