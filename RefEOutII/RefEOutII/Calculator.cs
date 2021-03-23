using System;
using System.Collections.Generic;
using System.Text;

namespace RefEOutII {
    class Calculator {
        //modificador out faz com q o parametro seja uma referencia viavel
        //para a variavel original, mas nao exige que a variavel original seja iniciada


        //variavel result é o parametro de SAIDA
        //OUT RESULT sera uma referencia ao TRIPLE instanciado em main
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
