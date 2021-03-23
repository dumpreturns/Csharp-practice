using System;
using System.Globalization;
namespace CondicionalTernaria {
    class Program {
        static void Main(string[] args) {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Este if else pode ser SUBSTITUIDO por uma unica linha
            // if (preco < 20.0) {
            //    desconto = preco * 0.1;
            //  }
            // else {
            //     desconto = preco * 0.05;
            // }


            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);
        }
    }
}
