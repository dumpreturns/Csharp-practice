using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {
            //cochetes separado por virgulas informa que é um arranjo
            //bidimensional

            //a instanciacao se da por new + tipo do arranjo + linhas e colunas
            double[,] mat = new double[2, 3];

            //qtd de elementos da matriz
            Console.WriteLine(mat.Length);

            //informa a primeira dimensao, ou seja, a qtd de linhas
            Console.WriteLine(mat.Rank);

            //dimensao zero da matriz possui tamanho dois, qtd de linhas
            Console.WriteLine(mat.GetLength(0));

            //qtd de colunas da matriz
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
