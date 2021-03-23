using System;
using System.Globalization;
namespace date {
    class Program {
        static void Main(string[] args) {

            //datetime.now mostrara a data atual do sistema
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            //qtd de ticks (100 nano secs) q se passaram desde 01/01 da era comum
            //informacoes da data, corretamente formatada, vem dos Ticks
            Console.WriteLine(d1.Ticks);

            //sobrecarga permite imprimir a data desejada
            DateTime d2 = new DateTime(2021, 03, 22);
            Console.WriteLine(d2);


            //sobrecarga que permite a inserção de data e horario
            DateTime d3 = new DateTime(2021, 03, 22, 20, 15, 45);
            Console.WriteLine(d3);


            //inclui milisecs, mas nao ira imprimir pelo padrao de string impresso
            DateTime d4 = new DateTime(2021, 03, 22, 20, 15, 45, 500);
            Console.WriteLine(d4);

            //data com horario zerado (00:00)
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            //data com horario de Greenwich (global)
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            //usando parse para formatacao
            //a formatacao abaixo é utilizada por banco de dados
            //c# ja é programado para aceitá-la
            DateTime d7 = DateTime.Parse("2000-08-15");
            //agr com horario
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

            //padrao BR é aceito
            DateTime d9 = DateTime.Parse("15/06/2002");


            //utilizando ParseExact para formatacao
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-DD", CultureInfo.InvariantCulture);
        }
    }
}
