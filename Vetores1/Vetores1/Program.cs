using System;
using System.Globalization;

namespace Vetores1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe a quantidade de alturas q deseja inserir: ");
            int n = int.Parse(Console.ReadLine());

            //criando vetor, de acordo com seu tipo (double [])
            // = new double[n] (n elementos)
            double[] vect = new double[n];
            Console.WriteLine("Insira as N alturas: ");
            for (int i = 0; i < n; i++) {
                //dado que ira se alocar na posicao I, recebe dados
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            //Cada elemento inserido no vetor sera somado
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }
            //a media é igual a soma dos vetors pela qtd de elementos inseridos
            double avg = sum / n;

            Console.WriteLine("Altura media = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
