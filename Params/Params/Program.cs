using System;

namespace Params {
    class Program {
        static void Main(string[] args) {
            //gracas ao params, nao é necessario instanciar o vetor
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
