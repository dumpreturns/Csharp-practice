using System;
using System.Collections.Generic;

namespace Lists2 {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            //list.add para adicionar elementos à lista
            //lembrando: add adiciona elementos AO FINAL da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("João");
            list.Add("Gustavo");
            list.Add("Ana");

            //list.insert nos permite adicionar um elemento a qlqr posição que quisermos
            list.Insert(2, "Pedro");


            //lembrando laço foreach: tipo | apelido | nome 
            foreach(string obj in list) {
                Console.WriteLine(obj);
            }
            //para mostrar a qtd de elementos da lista:
            Console.WriteLine(list.Count);

            //para encontrar primeiro nome que comecece com a leta 'A'

            //list.Find exige um PREDICADO

            //Precidaco é uma funcao que ira retornar verdadeiro ou falso
            //de acordo com a logica aplicada
            //string s1 = list.Find(Test);
            // Console.WriteLine("First 'a': " + s1);



            //Funcao LAMBDA, substituindo forma anterior
            //c# infere que X é string, logo o primeiro caractere de x for
            //igual a A, imprime
            
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //procurar a POSICAO que satisfaça predicado

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posicao q comece com A: " +pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posicao q comece com A: " + pos2);


            //filtrar lista
            //cria-se uma nova lista com os parametros desejados
            //nomes de 5 caracteres:
            List<string> listfiltrada = list.FindAll(x => x.Length == 5);
            foreach(string obj in listfiltrada) {
                Console.WriteLine(obj);
            }

            //remover elementos da lista

            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //remover elementos de acordo com predicado
            list.RemoveAll(x => x[0] =='M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //remover de acordo com a posicao
            list.RemoveAt(2);

            //remover elementos de uma determinada faixa

            //a partir do elemento de indice 2, remover 2
            list.RemoveRange(2, 2);
        }


        //logica aplicada: Bool 'test' ira retornar uma string 's', na 
        //primeira ocorrencia [0] em que aparecer um 'A'


        //FUNCAO LAMBDA ANULA A NECESSIDADE DE LOGICA ABAIXO
       // static bool Test(string s) {
        //    return s[0] == 'A';
        //}
    }
}
