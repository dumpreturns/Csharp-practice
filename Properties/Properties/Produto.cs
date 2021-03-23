using System.Globalization;

namespace Properties {
    class Produto {
        private string _nome;

        //autoproperty, get é permitido, porem nao set, forma mais simples
        //assim, atributo nao é privado, mas o seu metodo set sim!
        public double Preco { get; private set; }
        //prop tab tab complementa automaticamente!
        public int Quantidade { get; private set; }
        //private int _quantidade;


        //como nome possui LOGICA no seu metodo, nao pode ter auto property
        public Produto() {


        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        //PROPRIEDADE, define um metodo similarmente a um atributo
        //aqui os metodos get e set estao privativos ainda, porem podem ser chamados
        //nota-se que, nao possuimos mais o "nome" como entrada de parametro, portanto,
        //utliziamos o 'value'
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        

        //public int Quantidade {
          //  get { return _quantidade; }
       // }

        //public string GetNome() {
        //    return _nome;
        //}


        //utlizando Set para garantir seguranca perante entrada de dados
        //set é void pois nao retorna valor
        //public void SetNome(string nome) {
        //   if (nome != null && nome.Length > 1) {
        //      _nome = nome;
        // }
        // }



        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade) {
            //_quantidade = _quantidade + quantidade;

            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
    }
}
