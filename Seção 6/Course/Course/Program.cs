using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //// LIST

            //List<string> list = new List<string>();
            
            //list.Add("banana");
            //list.Add("jaca");
            //list.Add("maça");
            //list.Add("pera");
            //list.Add("melao");
            //list.Insert(2,"melancia");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(list.Count);
            //Console.WriteLine("--------------");

            ////string s1 = list.Find(Test);
            //string s1 = list.Find( x => x[0] == 'm'); // quero X tal que X na posição 0 seja m, o primeiro que aparecer
            //Console.WriteLine(s1);
            //Console.WriteLine("--------------");

            //int pos1 = list.FindIndex(x => x[0] == 'm'); // quero X tal que X na posição 0 seja m, o primeiro que aparecer
            //Console.WriteLine(pos1);
            //Console.WriteLine("--------------");

            //string s2 = list.FindLast(x => x[0] == 'm'); // quero X tal que X na posição 0 seja m, o ultimo que aparecer
            //Console.WriteLine(s2);
            //Console.WriteLine("--------------");

            //int pos2 = list.FindLastIndex(x => x[0] == 'm'); // quero X tal que X na posição 0 seja m, o primeiro que aparecer
            //Console.WriteLine(pos2);

            //List<string> list2 = list.FindAll(x => x.Length >= 5);
            //Console.WriteLine("--------------");

            //foreach (string item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Remove("banana");
            //Console.WriteLine( "--------------");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------");

            //list.RemoveAll(x => x.Contains('m'));
            //Console.WriteLine("--------------");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveAt(3);
            //Console.WriteLine("--------------");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.RemoveRange(1,3);
            //Console.WriteLine("--------------");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

        }

        //static bool Test(string s)
        //{
        //    return s[0] == 'm';
        //}

            ////for each

            //string[] vert = { "1", "2", "3" };
            //string[] vert2 = new string[] { "1", "2", "3" };

            //foreach (string item in vert)
            //{
            //    Console.WriteLine(item);
            //}


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
