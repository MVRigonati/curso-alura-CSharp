using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskaraAlura {
    class Program {

        static void Main(string[] args) {

            int a = Convert.ToInt32( args[0] );
            int b = Convert.ToInt32( args[1] );
            int c = Convert.ToInt32( args[2] );

            Console.WriteLine( "A = " + a );
            Console.WriteLine( "B = " + b );
            Console.WriteLine( "C = " + c );
            Console.WriteLine();

            int delta = b*b - (4 * a * c);
            Console.WriteLine( "Delta = " + delta);
            Console.WriteLine();

            if (delta > 0) {

                double resultadoA = ( -b + Math.Sqrt(delta) ) / (2 * a);
                double resultadoB = ( -b - Math.Sqrt(delta) ) / (2 * a);
                Console.WriteLine( "X' = " + resultadoA );
                Console.WriteLine( "X'' = " + resultadoB );

            }

        }

    }
}