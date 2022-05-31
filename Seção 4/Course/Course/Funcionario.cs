using System;
using System.Globalization;

namespace Course {
    class Funcionario {

        public string Nome;
        public double SalarioBruto, Imposto;
        public double SalarioLiquido () { 
            return SalarioBruto - Imposto;
        }

        public void  AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto * (1 + (porcentagem / 100));
        }
    }
}
