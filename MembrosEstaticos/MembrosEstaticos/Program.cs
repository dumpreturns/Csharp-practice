using System;
using System.Globalization;
namespace MembrosEstaticos {
    class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferencia: " +circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " +volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: " +Pi.ToString("F2", CultureInfo.InvariantCulture));
        }


        //static double é declarado fora do main. MEMBRO ESTATICO NAO PODE OCUPAR FUNCAO ESTATICA!
        static double Circunferencia (double r) { //raio que chega como parametro na funcao NAO SE REFERE a variavel declarada anteriormente. Por isso coloquei R ao inves de raio
            return 2.0 * Pi * r;
        }

        static double Volume (double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
