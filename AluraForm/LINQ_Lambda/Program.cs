using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lambda {
    class Program {

        private static List<int> lista;

        static void Main(string[] args) {

            lista = new List<int>();

            lista.Add(6);
            lista.Add(7);
            lista.Add(8);

            // LINQ();
            // Lambda();
            TestesExtras();

        }

        public static void LINQ() {

            Console.WriteLine("--- LINQ ---");

            // Funciona igual um forEach onde:
            // "from valor" diz qual será o nome da variável temporária
            // "in lista" de onde esta variável será retirada
            // "valor.Length > 3" é a condição e
            // "select valor" diz o será armazenado na nova lista.
            var filtradas = from valor in lista
                            where valor > 6
                            select valor;

            Console.WriteLine(filtradas.Sum());
            Console.Read();

        }

        public static void Lambda() {

            Console.WriteLine("--- Lambda ---");

            // O Lambda (=>) é uma declaração de função anonima,
            // aqui declaramos uma função para executar
            // para cada elemento da lista (ForEach),
            int result = lista.Sum(i => i * 2);
            // i = Argumento (Os argumentos são definidos pelo método
            // que utilizará esta função);
            // O que está depois do Lambda é a função que
            // nesse caso será o retorno para cada elemento a lista.

            Console.WriteLine("Soma = " + result);
            // Ao invés de criar uma classe e
            // implementar uma interface apenas para isso,
            // a função já está sendo implementada aqui.

            Console.Read();

        }

        public static void TestesExtras() {

            Console.WriteLine("--- TestesExtras ---");

            // Cria um objeto anônimo com os atributos "Valor" e "ValorComJuros".
            var quantidade = from num in lista select new { Valor = num, ValorComJuros = num * 1.3f };

            // Métodos que podem ser utilizados também.
            List<int> listaComElementosMenoresQue5_Ordenados =
                (lista.Where(num => num < 5).OrderByDescending(num => num)).ToList<int>();

            // Cria uma lista com os itens ordenados
            // de acordo com o elemento após a palavra "orderby".
            List<int> listaOrdenada = (from num in lista orderby num select num).ToList<int>();
            Console.Write("Lista ordenada = ");
            listaOrdenada.ForEach(item => Console.Write(item + ", "));
            
            Console.Read();

        }

    }
}
