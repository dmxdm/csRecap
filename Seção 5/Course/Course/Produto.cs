using System;
using System.Globalization;

namespace Course {
    class Produto {

        /*
        ORDEM SUGERIDA
        PRIVATE
        AUTOPROPERTIES
        CONSTRUCTOR
        CUSTOMIZED PROPERTIES
        OTHER METHODS
         */

        private string _nome;
        public double Preco { get; private set; } //autoproperty
        public int Quantidade { get; private set; } // autoproperty
        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //private string _nome;
        //private double _preco; // public pode ser editado diretameente por um programa exemplo p.Quqnatidade=10
        //private int _quantidade; // private não pode ser modificado sem utilziar um metodo da classe

        //public string Nome;
        //public double Preco; // public pode ser editado diretameente por um programa exemplo p.Quqnatidade=10
        //public int Quantidade; // private não pode ser modificado sem utilziar um metodo da classe

        ////############# CUSTOMIZED PORPERTIES COM GET E SET

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        //public double Preco {
        //    get { return _preco; }
        //}

        //public int Quantidade {
        //    get { return _quantidade; }
        //}

        //public Produto() {
        //}
        //public Produto(string nome, double preco, int quantidade) {
        //    _nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}

        ////############# ENCAPSULAMENTO COM GET E SET + PRIVATE QUE TEM PADRAO _nomedavariavel
        //public string GetNome() {
        //    return _nome;
        //}
        //public double GetPreco() {
        //    return _preco;
        //}
        //public int GetQuantidade() {
        //    return _quantidade;
        //}
        //public void SetNome(string nome) {
        //    if (nome != null && nome.Length > 1) {
        //        _nome = nome;
        //    }
        //}

        ////########### THIS
        //public Produto() {
        //    Quantidade = 10;
        //}
        //public Produto(string nome, double preco) : this() {
        //    Nome = nome;
        //    Preco = preco;
        //}

        //public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
        //    Quantidade = quantidade;
        //}


        ////##### construtor
        //public Produto(string nome, double preco, int quantidade) {
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}
        ////#####  sobrecarga de construtores
        //public Produto(string nome, double preco) {
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = 5;
        //}

        //public Produto() {
        //}

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
