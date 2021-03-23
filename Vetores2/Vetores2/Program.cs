using System;
using System.Globalization;

namespace Vetores2 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            //vetor de Produtos, colocando a palavra Product com [] pois é um vetor
            // = new Product[n] pois vetor tem quantidade igual a N

            //nota-se que: ISSO É UM VETOR TIPO CLASSE, nao struct
            //sendo assim, cada posicao, atualmente, esta valendo NULO
            //e posteriormente ira apontar para os elementos Name e Price
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                //AGORA SIM, ele é Instanciado, e inserido os valores de acordo com as
                //variaveis auxiliares
                //metodo construtor

                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i<n; i++) {
                sum += vect[i].Price;
                //posicao no vetor, referindo-se ao preço
            }

            double avg = sum / n;

            Console.WriteLine("Preco medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
