using System;

namespace ExercicioClasse {
    class Program {
        static void Main(string[] args) {

            

            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();


            Console.WriteLine("Informe o nome da Primeira pessoa: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da Primeira pessoa: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da Segunda pessoa: ");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da Segunda pessoa: ");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade) {
                Console.WriteLine("A pessoa mais velha eh: {0}", a.Nome);
            }
            else if (b.Idade > a.Idade){
                Console.WriteLine("A pessoa mais velha eh: {0}", b.Nome);
            }
            else {
                Console.WriteLine("As duas pessoas possuem a mesma idade");
            }
        }
    }
}
