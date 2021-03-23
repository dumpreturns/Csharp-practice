using System;

namespace MatrizesII {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe N (numero de elementos da matriz quadrada)");
            int n = int.Parse(Console.ReadLine());


            int[,] mat = new int[n, n];

            //percorre linhas
            for (int i = 0; i < n; i++) {

                //split para, a cada ' espaco ' armazenar o valor na String
                //armazena dados da primeira linha, e de suas 3 colunas
                string[] values = Console.ReadLine().Split(' ');

                //percorre colunas
                for (int j = 0; j < n; j++) {
                    //int.Parse converte string para o int
                    //iniciado por 0, j preenche a primeira coluna
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i=0; i<n; i++) {
                //qdo indice coluna for igual indice linha:
                Console.Write(mat[i, i] + " ");

            }
            Console.WriteLine();
            int cont = 0;
            for (int i=0; i<n; i++) {

                for (int j=0; j<n; j++) {

                    if (mat[i, j] < 0) { 
                        cont++;
                    }
                }
            }
            Console.WriteLine("qtd de numeros negativos: " + cont);
        }
    }
}
