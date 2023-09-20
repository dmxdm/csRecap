﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {


            ////UnBoxing 

            //object obj = 10;

            //int y = (int)obj;

            ////Boxing 

            //object obj = 10;


            ////modificador de paramentro OUT e REF

            //int a = 10;

            //Calculator.Triple(a, out int triple);

            //Console.WriteLine(triple);



            //int a = 10;
            //Calculator.Triple(ref a);
            //Console.WriteLine(a);


            ////modificador de paramentro PARAMS

            //int s1 = Calculator.Sum(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(s1);

            //int[] vect = { 1, 2, 3, 4 };
            //int s1 = Calculator.Sum(vect);
            //Console.WriteLine(s1);


            //// VETORES Classe

            //int n = int.Parse(Console.ReadLine());

            //Produto[] vector = new Produto[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    vector[i] = new Produto { Name = name, Preco = price };
            //}

            //double sum = 0.0;

            //for (int j = 0; j < n ; j++)
            //{

            //    sum += vector[j].Preco;

            //}

            //double avg = sum / n;

            //Console.WriteLine("Media = " +  avg.ToString("f2", CultureInfo.InvariantCulture));


            //// VETORES Struct


            //int n = int.Parse(Console.ReadLine());

            //double[] vector = new double[n];

            //for (int i = 0; i < n; i++)
            //{

            //    vector[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //}

            //double sum = 0.0;

            //for (int j = 0; j < n; j++)
            //{ 
            //    sum += vector[j];
            //    Console.WriteLine($"Vector posição {j} tem valor: " + vector[j] + $" Soma: {sum}");

            //}

            //// OPERADOR DE COALESCENCIA NULA

            //double? p = null;
            //double? q = p ?? 11;

            //Console.WriteLine(p.GetValueOrDefault());
            //Console.WriteLine(q.GetValueOrDefault());



            ////NULLABLE

            ////double x = null; não é possivel

            //Nullable<double> y = 10;

            //double? x = null;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(x.HasValue);
            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("null");
            //}


            //Console.WriteLine(y.GetValueOrDefault());
            //Console.WriteLine(y.HasValue);
            //Console.WriteLine(y.Value);







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
