using System;
using System.Globalization;
namespace Encapsulamento_Get_e_Set {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);


            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            
        }
    }
}