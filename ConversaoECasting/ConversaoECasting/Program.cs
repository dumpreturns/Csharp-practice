using System;

namespace ConversaoECasting {
    class Program {
        static void Main(string[] args) {
            float x = 4.5f;
            double y = x;

            //isso é possível, ja que 4 bytes de Float cabem nos 8 bytes de double!

            //é uma "conversão implicita" de float para double!


            double a;
            float b;
            a = 5.1;
            b = (float)a;

            //isso é CASTING, ou "conversao explicita", o programador se assegura do risco
            //de perda de dados na conversao de Double para float!

            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            //double resultado = c/d;
            //ele ira retornar 2 e nao 2.5, ja que, por ser uma divisao de inteiros, ele ira
            //entender que deve-se descartar o 0.5
            //para isso, usa-se o CASTING novamente

            double resultado = (double)c / d;

            Console.WriteLine(resultado);
        }
    }
}
