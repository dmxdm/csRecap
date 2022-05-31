using System;

namespace Course {
    class Triangulo {

        public double A, B, C;
        public double Area() {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}

