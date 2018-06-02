using System;
using Caelum.CaixaEletronico.Usuarios;
using Caelum.CaixaEletronico.Exceptions;

namespace Caelum.CaixaEletronico.Contas {
    public class Conta {

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public int Agencia { get; set; }
        public Cliente Titular { private get; set; }

        public String TitularNome {
            get {
                return this.Titular.Nome;
            }
        }

        public Conta(int num, Cliente titular, double saldo) {
            this.Numero = num;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public double Saca(double valor) {

            double limite = valor;

            if (valor < 0) {
                throw new ArgumentException();

            } else if (valor > this.Saldo) {
                throw new SaldoInsuficienteException();

            }

            if ( !this.Titular.IsMaiorDeIdade() ) {
                limite = 200.0;
            }

            if ( this.IsSaqueValid(valor, limite) ) {
                Saldo -= valor;
                return valor;
            }
            return 0;

        }

        private bool IsSaqueValid(double valor, double limite) {
            return (this.Saldo >= valor && valor >= 0 && valor <= limite);
        }

        public void Deposita(double valor) {

            if (valor > 0) {
                this.Saldo += valor;
            }

        }

        public bool Transfere(double valor, Conta destino) {

            try {
                destino.Deposita( this.Saca(valor) );
                return true;
            } catch (NullReferenceException ex) {
                return false;
            }

        }

    }
}