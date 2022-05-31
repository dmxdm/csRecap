using System;
using System.Globalization;

namespace Course {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int Adiciona) {
            Quantidade = Quantidade + Adiciona;
        }
        public void RemoverProdutos(int Remove) {
            Quantidade = Quantidade - Remove;
        }

        public override string ToString() {
            return Nome 
                + ",  $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade + " unidades, $" 
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}
