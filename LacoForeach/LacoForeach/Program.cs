using System;

namespace LacoForeach {
    class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //forma anterior, com laço FOR:
            //for (int i=0; i<vect.Length; i++){
            //  Console.WriteLine(vect[i]);
            //}


            //forma simplificada com FOREACH
            //note que na abertura de (), insere-se o tipo do dado, neste caso, string
            //obj é o APELIDO, in vect, refere-se ao conjunto analisado
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
