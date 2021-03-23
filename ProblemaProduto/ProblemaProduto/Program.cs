using System;
using System.Globalization;
namespace ProblemaProduto {
    class Program {
        static void Main(string[] args) {
            
            //criacao de variaveis auxiliares, string nome, double preco etc
            //substituem a instanciação (a.nome, a.produto)
            Console.WriteLine("Entre os dados do produto");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());


            // dps de serem inseridas as variaveis auxiliares, AI SIM, podemos
            //instanciar o produto

            Produto A = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + A);

            Console.WriteLine();

            Console.WriteLine("Informe o numero de produtos a ser adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            A.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + A);

            Console.WriteLine("Informe o numero de produtos a ser removidos: ");
            int qtd = int.Parse(Console.ReadLine());
            A.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + A);
        }
    }
}
