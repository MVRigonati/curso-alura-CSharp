using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImpostoAlura {
    class Program {

        static void Main(string[] args) {

            double valorNotaFiscal = Convert.ToDouble(args[0]);
            double imposto;

            if (valorNotaFiscal < 1000.0) {
                imposto = 0.02;
            } else if (valorNotaFiscal < 3000.0) {
                imposto = 0.025;
            } else if (valorNotaFiscal < 7000.0) {
                imposto = 0.028;
            } else {
                imposto = 0.03;
            }

            Console.WriteLine( "O imposto será de " + (imposto * 100) + "%" );

        }

    }
}
