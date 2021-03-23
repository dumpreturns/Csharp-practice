using System.Globalization;


namespace Encapsulamento_Get_e_Set {
    class Produto {

        //quando utilizamos private, declaramos os atributos com _ e letras
        //minusculasq
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {


        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        public string GetNome() {
            return _nome;
        }


        //utlizando Set para garantir seguranca perante entrada de dados
        //set é void pois nao retorna valor
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade) {
            //_quantidade = _quantidade + quantidade;

            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
    }
}

