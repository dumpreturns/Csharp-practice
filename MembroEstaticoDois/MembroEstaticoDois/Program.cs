using System;
using System.Globalization;
namespace MembroEstaticoDois {
    class Program {

        
        static void Main(string[] args) {

            //entende-se que, independente do objeto, o resultado dará o mesmo (membro estatico)
            Calculadora c = new Calculadora();


            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = c.Circunferencia(raio);
            double volume = c.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: " + c.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }




    }
}