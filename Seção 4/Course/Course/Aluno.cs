using System;
using System.Globalization;

namespace Course {
    class Aluno {

        public string Nome;
        public double N1, N2, N3;
        public double NotaFinal() {
            return N1 + N2 + N3;
        }

        public string Situacao() {

            if ((N1 + N2 + N3) >= 60) {
                return "APROVADO";
            }
            else {
                return $"REPROVADO, FALTARAM {60 - (N1 + N2 + N3)} PONTOS";
            }
        }
        public override string ToString() {
            return "NOTA FINAL = "
                + NotaFinal().ToString("F2",CultureInfo.InvariantCulture)
                + ", "
                + Situacao();
        }

    }
}
