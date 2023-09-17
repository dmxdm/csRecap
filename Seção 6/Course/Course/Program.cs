using System;
using System.Runtime.Intrinsics.X86;

namespace Course {
    class Program {
        static void Main(string[] args) {



            // OPERADOR DE COALESCENCIA NULA

            double? p = null;
            double? q = p ?? 11;

            Console.WriteLine(p.GetValueOrDefault());
            Console.WriteLine(q.GetValueOrDefault());



            //NULLABLE

            //double x = null; não é possivel

            Nullable<double> y = 10;

            double? x = null;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("null");
            }


            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(y.HasValue);
            Console.WriteLine(y.Value);


       




            // STRUCT     
            //Point p;

            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);

            //p = new Point();
            //Console.WriteLine(p);





        }

    }
}
