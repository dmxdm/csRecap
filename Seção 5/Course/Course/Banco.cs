using System;
using System.Globalization;

namespace Course {
    class Banco {

        /* NUMERO DA CONTA -> nunca pode ser alterado - private SET
        NOME DO TITULAR DA CONTA -> pode ser alterado
        VALOR DE DEPOSITO INICIAL -> OPCIONAL sobrecarga de contrutor 
        Saldo só pode ser alterado por metodos da classe,  deposito ou saque
        cada saque tem taxa de 5 pilas, conta pode ficar negativa */

        /* ORDEM SUGERIDA
        PRIVATE
        AUTOPROPERTIES
        CONSTRUCTOR
        CUSTOMIZED PROPERTIES
        OTHER METHODS */


        private int _conta;
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string nome) {
            _conta = conta;
            Nome = nome;
            Saldo = 0.0;
        }

        public Banco(int conta, string nome, double depositoInicial) : this(conta, nome) {
            Deposito(depositoInicial); //caso mude no futuro a regra de depoisitio isso atualiza para o futuro.
        }

        public int GetConta() {
            return _conta;
        }

        public void Deposito(double adcional) {
            Saldo += adcional;
        }

        public void Saque(double retirada) {
            Saldo -= retirada;
            Saldo -= 5.00;
        }

        public override string ToString() {
            return "Conta "
                + _conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}
