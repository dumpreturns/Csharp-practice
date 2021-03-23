namespace Params {
    class Calculator {
        

        //funcao sum ira trabalhar com vetor numbers
        //params informa que ira receber uma quantidade VARIAVEL de parametros
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
