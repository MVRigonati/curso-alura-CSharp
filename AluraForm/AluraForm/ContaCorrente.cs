using Caelum.CaixaEletronico.Usuarios;

namespace Caelum.CaixaEletronico.Contas {
    class ContaCorrente : Conta {

        public ContaCorrente(int num, Cliente titular, double saldo)
            : base(num, titular, saldo) {

        }

    }
}
