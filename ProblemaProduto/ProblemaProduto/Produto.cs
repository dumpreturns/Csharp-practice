using System.Globalization;

namespace ProblemaProduto {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //construtor leva mesmo nome da classe, atributos aparecem em minusculo
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        //sobrecarga
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        //opcao para instanciar como Produto p = new Produto();
        public Produto() {


        }
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
    }
}
