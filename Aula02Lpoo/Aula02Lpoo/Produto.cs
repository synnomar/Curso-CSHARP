using System.Globalization;

namespace Aula02Lpoo {
    class Produto {

        //Atributo
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtor Padrão
        public Produto() { }

        //Construtor com 3 Atributos
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Properties
        public string Nome { 
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

       //Metodos
        public double ValorTotalEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome +", $ " 
                        + Preco.ToString("F2",CultureInfo.InvariantCulture)
                        +", "
                        + Quantidade 
                        +" unidades, Total: R$"
                        +ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}