using System;
using System.Globalization;

namespace Course {
    class Retangulo {

        public double Largura, Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (Largura + Altura) * 2;
        }

        public double Diagonal() {
            return Math.Sqrt( Math.Pow(Largura,2) + Math.Pow(Altura, 2) );
        }
        public override string ToString() {
            return "AREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + " PERÍMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " DIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
