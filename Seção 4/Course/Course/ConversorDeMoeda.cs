using System;
using System.Globalization;


namespace Course {
    class ConversorDeMoeda {

        public static double Iof = 6.0;
        public static double Dolar(double cota, double quant) {
            return cota * quant * (1 + Iof / 100);
        }


    }
}
