

namespace MembroEstaticoDois {
    class Calculadora {
       public double Pi = 3.14;
        public double Circunferencia(double r) { //raio que chega como parametro na funcao NAO SE REFERE a variavel declarada anteriormente. Por isso coloquei R ao inves de raio
            return 2.0 * Pi * r;
        }

        public double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
