using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Manager.Model;

namespace Manager {
    class Program {

        static void Main(string[] args) {

            Conta conta1 = new ContaCorrente(001, new Cliente("Marcus Vinicius Rigonati"), 600.0);
            ContaPoupanca conta2 = new ContaPoupanca(002, new Cliente("Estranho"), 1200.0);

            conta2.Deposita( 1200.0 );

            Console.WriteLine("Tributo Conta2: " + conta2.CalculaTributo());
            Console.WriteLine("Saldo Conta2: " + conta2.Saldo);
            Console.WriteLine("Numero total de contas: " + Conta.NumTotalConta);

            Console.WriteLine("\nAperte qualquer tecla para terminar...");
            Console.ReadKey();

        }

    }
}
